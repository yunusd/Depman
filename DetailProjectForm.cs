using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class DetailProjectForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        long projectId;
        long projectDetailId;

        bool isOpenDepartment = false;
        bool isOpenLeaderOfTeam = false;

        public DetailProjectForm(long projectId, long projectDetailId)
        {
            this.projectId = projectId;
            this.projectDetailId = projectDetailId;
            InitializeComponent();
        }

        private void DetailProjectForm_Load(object sender, EventArgs e)
        {
            var query = ctx.ProjectDetail.Where(x => x.ProjectDetailID == projectDetailId).Join(ctx.Project, detail => detail.ProjectFK, project => project.ProjectID, (detail, project) => new
            {
                project.ProjectID,
                project.ProjectTitle,
                project.ProjectLeaderEmployeeFK,
                detail.ProjectDetailID,
                detail.ProjectDescription,
                detail.StartDate,
                detail.FinishDate,
                detail.Employees,
                detail.DepartmentFK
            }).ToList().SingleOrDefault();

            txtProjectName.Text = query.ProjectTitle;
            txtDescription.Text = query.ProjectDescription;
            txtDescription.Text = query.ProjectDescription;
            dtpStartDate.Value = query.StartDate;

            foreach (var item in query.Employees.ToList())
            {
                lstMemberOfTeam.Items.Add(item);
            }
            lstMemberOfTeam.ValueMember = "EmployeeID";

            GetDepartments((long)query.DepartmentFK);
            GetEmployeesForLeader((long)query.ProjectLeaderEmployeeFK);
            GetEmployeesForMembers();
        }

        private void GetDepartments(long departmentId)
        {
            cboDepartment.DataSource = ctx.Department.ToList();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.SelectedValue = departmentId;
            isOpenDepartment = true;

        }

        private void GetEmployeesForLeader(long leaderID = -1)
        {
            // Create autocompletestringcollection for textbox
            // when user start typing it will show and append suggested data from collection
            var source = new AutoCompleteStringCollection();
            var selectedDepartment = cboDepartment.SelectedValue ?? (long)0;

            foreach (var e in ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment).ToList())
            {
                if (!lstMemberOfTeam.Items.Contains(e)) source.Add($"{e.EmployeeFirstName} {e.EmployeeLastName}");
            }


            // leader of team
            cboLeaderOfTeam.DataSource = ctx.Employee.Where(x => x.DepartmentFK == (long)selectedDepartment).ToList();
            cboLeaderOfTeam.ValueMember = "EmployeeID";
            if (leaderID == -1)
            {
                cboLeaderOfTeam.SelectedIndex = (int)leaderID;
                cboLeaderOfTeam.Text = "Kişi Seçin";
            }
            else
            {
                cboLeaderOfTeam.SelectedValue = leaderID;
            }

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

        private void LstMemberOfTeam_KeyDown(object sender, KeyEventArgs e)
        {
            int selectedMember = lstMemberOfTeam.SelectedIndex;
            if (e.KeyCode == Keys.Delete && selectedMember >= 0)
            {
                lstMemberOfTeam.Items.RemoveAt(selectedMember);
                //var pd = ctx.ProjectDetail.Find(projectDetailId);
                //pd.Employees.Remove((Employee)lstMemberOfTeam.SelectedItem);
                //ctx.SaveChanges();
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
                lstMemberOfTeam.ValueMember = "EmployeeID";
            }
        }

        private void CboLeaderOfTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLeaderOfTeam.SelectedIndex >= 0 && isOpenLeaderOfTeam)
            {
                GetEmployeesForMembers();
                return;
            }
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex >= 0 && isOpenDepartment)
            {
                GetEmployeesForLeader();
                lstMemberOfTeam.Items.Clear();
                return;
            }
        }

        private void GetFullNameOfEmployee(ListControlConvertEventArgs e)
        {
            string firstname = ((Employee)e.ListItem).EmployeeFirstName;
            string lastname = ((Employee)e.ListItem).EmployeeLastName;
            e.Value = $"{firstname} {lastname}";
        }

        private void CboAddMemberOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void CboLeaderOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void LstMemberOfTeam_Format(object sender, ListControlConvertEventArgs e)
        {
            GetFullNameOfEmployee(e);
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            var projectName = txtProjectName.Text.Trim();
            var projectDescription = txtDescription.Text.Trim();
            var startDate = dtpStartDate.Value;
            var departmentFK = cboDepartment.SelectedIndex != -1 ? (long)cboDepartment.SelectedValue : -1;
            var leaderOfTeam = (long)cboLeaderOfTeam.SelectedValue;
            var lstMembers = lstMemberOfTeam.Items;
            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectDescription) || departmentFK == -1 || lstMembers.Count == 0)
            {
                MessageBox.Show("Tüm alanların dolu olması gerekiyor!");
                return;
            }
            var resultProject = ctx.Project.Find(projectId);
            resultProject.ProjectTitle = txtProjectName.Text;
            resultProject.ProjectLeaderEmployeeFK = leaderOfTeam;
            ctx.Entry(resultProject).State = EntityState.Modified;

            var resultProjectDetail = ctx.ProjectDetail.Find(projectDetailId);
            resultProjectDetail.DepartmentFK = departmentFK;
            foreach (var item in lstMembers)
            {
                var employee = ctx.Employee.Find((long)((Employee)item).EmployeeID);
                var res = resultProjectDetail.Employees.Where(x => x.EmployeeID == employee.EmployeeID).SingleOrDefault();
                if (res != null)
                {
                    resultProjectDetail.Employees.Add(employee);
                    continue;
                }
            }
            resultProjectDetail.ProjectDescription = projectDescription;
            resultProjectDetail.StartDate = startDate;
            ctx.Entry(resultProjectDetail).State = EntityState.Modified;

            int status = ctx.SaveChanges();
            if (status == 0)
            {
                MessageBox.Show("Hata");
                return;
            }
            MessageBox.Show("Kaydedildi!");
            Close();
        }
    }
}
