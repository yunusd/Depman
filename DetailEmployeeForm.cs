using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class DetailEmployeeForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        Employee employee;
        string pictureCurrentPath;
        string employeePicSavePathame;
        bool isOpened = false;


        public DetailEmployeeForm(long employeeId)
        {
            InitializeComponent();
            employee = ctx.Employee.Find(employeeId);
            GetEmployee();
            ListDepartments();
            ListManager();
        }



        private void ListDepartments()
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedValue = employee.DepartmentFK;
            isOpened = true;

        }

        private void ListManager()
        {
            if (employee.EmployeeFK == null) return;

            long slcValue = (long)cboDepartment.SelectedValue;
            cboManager.DataSource = ctx.Employee.Where(x => x.DepartmentFK == slcValue && x.EmployeeID != employee.EmployeeID).ToList();
            cboManager.DisplayMember = "EmployeeFirstName";
            cboManager.ValueMember = "EmployeeID";
            cboManager.SelectedValue = (int)employee.EmployeeFK;
            cboManager.SelectedItem = employee.Manager;

        }

        private void GetEmployee()
        {
            label1.Text = employee.EmployeeFirstName + " Adlı Çalışanın Bilgileri";
            txtFirstName.Text = employee.EmployeeFirstName;
            txtLastName.Text = employee.EmployeeLastName;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtDegree.Text = employee.Degree;
            nudSalary.Value = employee.Salary;
            txtAddress.Text = employee.Address;
            dtpHireDate.Value = employee.HireDate;
            pbPlaceholderProfilePic.ImageLocation = employee.EmployeeImgPath;


            cboSex.Items.Add("Erkek");
            cboSex.Items.Add("Kadın");
            cboSex.SelectedItem = employee.Sex;
        }





        private void BtnUploadEmployeePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdUploadEmployeePic = new OpenFileDialog();
            ofdUploadEmployeePic.Filter = "Resim Dosyası |*.jpg; *.png";
            ofdUploadEmployeePic.Title = "Çalışan Fotoğrafı";
            ofdUploadEmployeePic.ShowDialog();

            //Fotoğrafın kaydedilecek dizin yolunu oluşturma
            pictureCurrentPath = ofdUploadEmployeePic.FileName;
            pbPlaceholderProfilePic.ImageLocation = pictureCurrentPath;
            string target = Application.StartupPath + @"\img\";

            Directory.CreateDirectory(target);
            string newPicName = Guid.NewGuid() + ".jpg"; //benzersiz isim
            employeePicSavePathame = target + newPicName;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeFirstName = txtFirstName.Text.Trim();
            string employeeLastName = txtLastName.Text.Trim();
            string employeeMail = txtEmail.Text.Trim();
            string employeePhone = txtPhone.Text.Trim();
            string employeeDegree = txtDegree.Text.Trim();
            decimal employeeSalary = nudSalary.Value;
            long employeeDepartmentID = cboDepartment.SelectedValue != null ? (long)cboDepartment.SelectedValue : -1;
            var employeeHireDate = dtpHireDate.Value;
            string employeeAdress = txtAddress.Text.Trim();
            string sex = cboSex.SelectedIndex >= 0 ? cboSex.SelectedItem.ToString() : null;


            if (employeeFirstName != "" || employeeLastName != "" || employeeMail != "" || employeePhone != "" || employeeSalary != 0 || employeeDepartmentID > 0 ||
                employeeAdress != "" || employeeDegree != "" || pictureCurrentPath != "")
            {
                if (employeeMail.Contains("@") == false)
                {
                    MessageBox.Show("Geçerli bir mail adresi giriniz!");
                }

                if (employeePhone.Length != 11)
                {
                    MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                }
                else if (cboManager.SelectedIndex == -1)
                {

                    employee.EmployeeFirstName = employeeFirstName;
                    employee.EmployeeLastName = employeeLastName;
                    employee.Address = employeeAdress;
                    employee.Phone = employeePhone;
                    employee.Salary = employeeSalary;
                    employee.DepartmentFK = employeeDepartmentID;
                    employee.Email = employeeMail;
                    employee.HireDate = employeeHireDate;
                    employee.Degree = employeeDegree;
                    employee.Sex = sex;

                    if (pictureCurrentPath != null)
                    {
                        employee.EmployeeImgPath = employeePicSavePathame;
                        File.Copy(pictureCurrentPath, employeePicSavePathame);
                    } // Fotoğrafı kaydet
                }
                else
                {
                    long employeeManager = (long)cboManager.SelectedValue;
                    employee.EmployeeFirstName = employeeFirstName;
                    employee.EmployeeLastName = employeeLastName;
                    employee.Address = employeeAdress;
                    employee.Phone = employeePhone;
                    employee.Salary = employeeSalary;
                    employee.DepartmentFK = employeeDepartmentID;
                    employee.Email = employeeMail;
                    employee.HireDate = employeeHireDate;
                    employee.Degree = employeeDegree;
                    employee.Sex = sex;
                    employee.EmployeeFK = employeeManager;
                    if (pictureCurrentPath != null)
                    {
                        employee.EmployeeImgPath = employeePicSavePathame;
                        File.Copy(pictureCurrentPath, employeePicSavePathame);
                    } // Fotoğrafı kaydet
                }
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!");
                return;
            }
            ctx.Entry(employee).State = EntityState.Modified;
            var status = ctx.SaveChanges();
            if (status == 1)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi!");
                Close();
            }
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex == -1 || !isOpened) return;
            ListManager();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ctx.Employee.Remove(employee);
            if (ctx.SaveChanges() == 1)
            {
                File.Delete(employee.EmployeeImgPath); // klasörden resim silme
                Close();
            }
            MessageBox.Show("Silinemedi!");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtAddress.ReadOnly = false;
            txtDegree.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            btnAddEmployee.Visible = true;
            btnUploadEmployeePic.Visible = true;
            btnEdit.Visible = false;
        }
    }
}
