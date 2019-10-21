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
    public partial class AddProjectForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        bool isOpenDepartment = false;
        bool isOpenLeaderOfTeam = false;

        public AddProjectForm()
        {
            InitializeComponent();
            GetDepartments();
        }

        private void GetDepartments()
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedIndex = -1;
            cboDepartment.Text = "Birim Seç";
            isOpenDepartment = true;
        }

        private void GetEmployeesForLeader() {
            // Create autocompletestringcollection for textbox
            // when user start typing it will show and append suggested data from collection
            var source = new AutoCompleteStringCollection();
            var selectedDepartment = cboDepartment.SelectedValue ?? (long)0;

            foreach (var e in ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment).ToList())
            {
                source.Add($"{e.EmployeeFirstName} {e.EmployeeLastName}");
            }


            // leader of team
            cboLeaderOfTeam.DataSource = ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment).ToList();
            cboLeaderOfTeam.ValueMember = "EmployeeID";
            cboLeaderOfTeam.SelectedIndex = -1;
            cboLeaderOfTeam.Text = "Kişi Seç";

            cboLeaderOfTeam.AutoCompleteCustomSource = source;
            cboLeaderOfTeam.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLeaderOfTeam.AutoCompleteSource = AutoCompleteSource.ListItems;
            isOpenLeaderOfTeam = true;
        }

        private void GetEmployeesForMembers()
        {
            // Create autocompletestringcollection for textbox
            // when user start typing it will show and append suggested data from collection
            var source = new AutoCompleteStringCollection();
            var selectedDepartment = cboDepartment.SelectedValue ?? (long)0;
            var selectedLeader = cboLeaderOfTeam.SelectedValue ?? (long)0;

            foreach (var e in ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment && x.EmployeeFK != (long)selectedLeader).ToList())
            {
                source.Add($"{e.EmployeeFirstName} {e.EmployeeLastName}");
            }

            var selectedLeaderCtx = ctx.Employee.Find((long)selectedLeader);

            // members of team
            cboAddMemberOfTeam.DataSource = ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment && x.EmployeeID != selectedLeaderCtx.EmployeeFK && x.EmployeeID != (long)selectedLeader).ToList();
            cboAddMemberOfTeam.ValueMember = "EmployeeID";
            cboAddMemberOfTeam.SelectedIndex = -1;
            cboAddMemberOfTeam.Text = "Kişi Seç";

            cboAddMemberOfTeam.AutoCompleteCustomSource = source;
            cboAddMemberOfTeam.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAddMemberOfTeam.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GetFullNameOfEmployee(ListControlConvertEventArgs e)
        {
            string firstname = ((Employee)e.ListItem).EmployeeFirstName;
            string lastname = ((Employee)e.ListItem).EmployeeLastName;
            e.Value = $"{firstname} {lastname}";
        }

        private void CboLeaderOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void CboAddMemberOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void LstMemberOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void LstMemberOfTeam_KeyDown(object sender, KeyEventArgs e)
        {
            int selectedMember = lstMemberOfTeam.SelectedIndex;
            if (e.KeyCode == Keys.Delete && selectedMember >= 0)
            {
                lstMemberOfTeam.Items.RemoveAt(selectedMember);
            }
        }


        private void CboAddMemberOfTeam_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && cboAddMemberOfTeam.SelectedIndex >= 0)
            {
                if (cboLeaderOfTeam.SelectedIndex < 0)
                {
                    MessageBox.Show("İlk önce ekip lideri seçmelisin!");
                    return;
                }

                var memberOfTeam = cboAddMemberOfTeam.SelectedItem;
                bool isContainInList = lstMemberOfTeam.Items.Contains(memberOfTeam);
                bool isAlreadyInLeaderList = cboLeaderOfTeam.SelectedItem == memberOfTeam;
                if (isAlreadyInLeaderList)
                {
                    MessageBox.Show("Bu kişi ekip lideri olarak ekipte zaten bulunuyor!");
                    return;
                }
                if (isContainInList)
                {
                    MessageBox.Show("Bu kişi zaten ekipte!");
                    return;
                }
                lstMemberOfTeam.Items.Add(memberOfTeam);
                lstMemberOfTeam.ValueMember = "Id";
            }
        }

        private void CboLeaderOfTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLeaderOfTeam.SelectedIndex >= 0 && isOpenLeaderOfTeam)
            {
                GetEmployeesForMembers();
                txtPasiveMemberOfTeam.Visible = false;
                cboAddMemberOfTeam.Visible = true;
                return;
            }
            txtPasiveMemberOfTeam.Visible = true;
            cboAddMemberOfTeam.Visible = false;
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex >= 0 && isOpenDepartment)
            {
                GetEmployeesForLeader();
                txtPasiveLeaderOfTeam.Visible = false;
                cboLeaderOfTeam.Visible = true;
                return;
            }
            txtPasiveLeaderOfTeam.Visible = true;
            cboLeaderOfTeam.Visible = false;
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            var projectName = txtProjectName.Text.Trim();
            var projectDescription = txtDescription.Text.Trim();
            var startDate = dtpStartDate.Value;
            var departmentFK = cboDepartment.SelectedIndex != -1 ? (long)cboDepartment.SelectedValue : -1;
            var lstMembers = lstMemberOfTeam.Items;
            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectDescription) || departmentFK == -1 || lstMembers.Count == 0)
            {
                MessageBox.Show("Tüm alanların dolu olması gerekiyor!");
                return;
            }

            var project = new Project
            {
                ProjectTitle = projectName,
                ProjectLeaderEmployeeFK = (long)cboLeaderOfTeam.SelectedValue
            };

            var savedProject = ctx.Project.Add(project);
            var projectDetail = new ProjectDetail
            {
                ProjectDescription = projectDescription,
                StartDate = startDate,
                ProjectFK = savedProject.ProjectID,
                DepartmentFK = departmentFK,
            };
            foreach (var item in lstMembers)
            {
                projectDetail.Employees.Add(ctx.Employee.Find((long)((Employee)item).EmployeeID));
            }
            ctx.ProjectDetail.Add(projectDetail);
            ctx.SaveChanges();
            MessageBox.Show("Yeni proje oluşturuldu!");
            Close(); // Closes form
        }

    }
}
