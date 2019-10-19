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
        string picPath;

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
            picPath = ofdUploadEmployeePic.FileName;
            pbPlaceholderProfilePic.ImageLocation = picPath;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeFirstName = txtFirstName.Text.Trim();
            string employeeLastName = txtLastName.Text.Trim();
            string employeeMail = txtEmail.Text.Trim();
            string employeePhone = txtPhone.Text.Trim();
            string employeeDegree = txtDegree.Text.Trim();
            decimal employeeSalary = nudSalary.Value;
            long employeeDepartmentID = (long)cboDepartment.SelectedValue;
            var employeeHireDate = dtpHireDate.Value;
            string employeeAdress = txtAddress.Text.Trim();
            string sex = cboSex.SelectedItem.ToString();

            //Resmi klasöre kaydetme
            string source = picPath;
            string target = Application.StartupPath + @"\img\";
            Directory.CreateDirectory(target);
            string newPicName = Guid.NewGuid() + ".jpg"; //benzersiz isim
            File.Copy(source, target + newPicName);
            string employeePicPathName = target + newPicName;


            if (employeeFirstName != "" || employeeLastName != "" || employeeMail != "" || employeePhone != "" || employeeSalary != 0 || employeeDepartmentID > 0 ||
                employeeAdress != "" || employeeDegree != "" || employeePicPathName != "")
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
                        EmployeeImgPath = employeePicPathName
                    });

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
                        EmployeeImgPath = employeePicPathName
                    });

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
