using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class AddEmployeeForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        bool isOpened = false;
        string pictureCurrentPath;
        string employeePicSavePathame;

        public AddEmployeeForm()
        {
            InitializeComponent();
            GetReadyForm();
        }
        private void GetReadyForm()
        {
            ListSex();
            ListDepartments();
            ListManager();
        }

        private void ListSex()
        {
            cboSex.Items.Add("Erkek");
            cboSex.Items.Add("Kadın");
            cboSex.SelectedIndex = -1;
            cboSex.Text = "Seçim Yapınız";
        }

        private void ListDepartments()
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedIndex = -1;
            cboDepartment.Text = "Seçim yapınız";
            isOpened = true;


        }
        private void ListManager()
        {
            if (cboDepartment.SelectedIndex < 0) return;
            long slcValue = (long)cboDepartment.SelectedValue;
            cboManager.DataSource = ctx.Employee.Where(x => x.DepartmentFK == slcValue).ToList();
            cboManager.DisplayMember = "EmployeeFirstName";
            cboManager.ValueMember = "EmployeeID";
            cboManager.SelectedIndex = -1;
            cboManager.Text = "Yok";
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
            string sex = cboSex.SelectedIndex > 0 ? cboSex.SelectedItem.ToString() : null;


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
                    ctx.Employee.Add(new Employee
                    {
                        EmployeeFirstName = employeeFirstName,
                        EmployeeLastName = employeeLastName,
                        Address = employeeAdress,
                        Phone = employeePhone,
                        Salary = employeeSalary,
                        DepartmentFK = employeeDepartmentID,
                        Email = employeeMail,
                        HireDate = employeeHireDate,
                        Degree = employeeDegree,
                        Sex = sex,
                        EmployeeImgPath = employeePicSavePathame
                    });
                    File.Copy(pictureCurrentPath, employeePicSavePathame); // Fotoğrafı kaydet
                }
                else
                {
                    long employeeManager = (long)cboManager.SelectedValue;
                    ctx.Employee.Add(new Employee
                    {
                        EmployeeFirstName = employeeFirstName,
                        EmployeeLastName = employeeLastName,
                        Address = employeeAdress,
                        Phone = employeePhone,
                        Salary = employeeSalary,
                        DepartmentFK = employeeDepartmentID,
                        Email = employeeMail,
                        HireDate = employeeHireDate,
                        Degree = employeeDegree,
                        EmployeeFK = employeeManager,
                        Sex = sex,
                        EmployeeImgPath = employeePicSavePathame
                    });
                    File.Copy(pictureCurrentPath, employeePicSavePathame); // Fotoğrafı kaydet
                }
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!");
            }

            if (ctx.SaveChanges() == 1)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi!");
            }
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex == -1 || !isOpened) return;
            ListManager();
        }
    }
}
