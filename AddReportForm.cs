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
    public partial class AddReportForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        Employee leader;
        public AddReportForm(long leaderId)
        {
            leader = ctx.Employee.Find(leaderId);
            InitializeComponent();
            cboProjects.DataSource = ctx.Project.Where(x => x.ProjectLeaderEmployeeFK == leader.EmployeeID).ToList();
            cboProjects.DisplayMember = "ProjectTitle";
            cboProjects.ValueMember = "ProjectID";
            GetEmployees();
            GetQuestions();
        }

        private void GetFullNameOfEmployee(ListControlConvertEventArgs e)
        {
            string firstname = ((Employee)e.ListItem).EmployeeFirstName;
            string lastname = ((Employee)e.ListItem).EmployeeLastName;
            e.Value = $"{firstname} {lastname}";
        }

        private void GetQuestions()
        {
            dgvQuestions.AutoGenerateColumns = false;
            dgvQuestions.DataSource = ctx.Question.ToList();
        }

        private void GetEmployees()
        {
            if (cboProjects.SelectedIndex == -1) return;
            long selectedProjectId = (long)cboProjects.SelectedValue;
            var query = ctx.ProjectDetail.Where(x => x.ProjectDetailID == selectedProjectId).Join(ctx.Project, detail => detail.ProjectFK, project => project.ProjectID, (detail, project) => new
            {
                detail.Employees,
            }).ToList().SingleOrDefault();

            foreach (var item in query.Employees)
            {
                cboEmployees.Items.Add(item);
            }
            //cboEmployees.DataSource = ctx.Employee.Where(x => x.ProjectDetails.FirstOrDefault().ProjectFK == selectedProjectId).ToList();
            cboEmployees.ValueMember = "EmployeeID";
        }

        private void CboEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }
    }
}
