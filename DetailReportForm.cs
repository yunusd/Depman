using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class DetailReportForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        Employee employee;
        Report report;
        bool isLoadedDep = false;
        public DetailReportForm(long employeeId, long reportId)
        {
            employee = ctx.Employee.Find(employeeId);
            report = ctx.Report.Find(reportId);
            InitializeComponent();

            GetDepartments();
            GetEmployee();
            GetQuestions();
            txtReportDescription.Text = report.ReportDescription;
            dtpHireDate.Value = employee.HireDate;
        }

        private void GetFullNameOfEmployee(ListControlConvertEventArgs e)
        {
            string firstname = ((Employee)e.ListItem).EmployeeFirstName;
            string lastname = ((Employee)e.ListItem).EmployeeLastName;
            e.Value = $"{firstname} {lastname}";
        }

        private void GetQuestions()
        {
            if (report.Questions == null) return;
            dgvQuestions.DataSource = report.Questions.ToList();
        }

        private void GetEmployee()
        {
            cboEmployees.DataSource = ctx.Employee.Where(x => x.DepartmentFK == (long)cboDepartment.SelectedValue).ToList();
            cboEmployees.ValueMember = "EmployeeID";
            cboEmployees.SelectedValue = employee.EmployeeID;
        }

        private void GetDepartments()
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedValue = employee.DepartmentFK;
            isLoadedDep = true;
        }

        private void CboEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isLoadedDep) GetEmployee();
        }
    }
}
