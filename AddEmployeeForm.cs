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
        string picPathName;
        public AddEmployeeForm()
        {
            InitializeComponent();
            ListDepartments();
        }

        private void ListDepartments()
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedIndex = -1;
            cboDepartment.Text = "Lütfen seçim yapınız";
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
            cboManager.Text = "  ";
        }

        private void BtnUploadEmployeePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog employeePic = new OpenFileDialog();
            employeePic.Filter = "Resim Dosyası |*.jpg; *.png";
            employeePic.Title = "Çalışan Fotoğrafı";
            employeePic.ShowDialog();
            picPath = employeePic.FileName;
            pictureBox2.ImageLocation = picPath;
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

            //Resmi klasöre kaydetme

            picPathName = Path.GetFileName(picPath);
            string source = picPath;
            string target = Application.StartupPath + @"\img";
            string newPicName = Guid.NewGuid() + ".jpg"; //benzersiz isim
            File.Copy(source, target + newPicName);




            if (employeeFirstName != "" || employeeLastName != "" || employeeMail != "" || employeePhone != "" || employeeSalary != 0 || employeeDepartmentID > 0 ||
                employeeAdress != "" || employeeDegree != "")
            {
                if (employeeMail.Contains("@") == false)
                {
                    MessageBox.Show("Geçerli bir mail adresi giriniz!");
                }
                else if(cboManager.SelectedIndex == -1)
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
                        Degree = employeeDegree
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
                        EmployeeFK = employeeManager
                    });
                    
                }
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
