using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class MainForm : Form
    {
        TableLayoutPanel activePanel;
        Button activeButton;
        string activeIcon;

        DepmanContext ctx = new DepmanContext();

        public MainForm()
        {
            InitializeComponent();
            GetProjects();
            ActivePanel(tlpProjects, btnProjects, "icons8_group_of_projects_25");
        }

        private void ActivePanel(TableLayoutPanel panel, Button button, string icon)
        {

            // Make unvisible current panel if activePanel is not null
            if (activePanel != null)
            {
                if (panel.Name == activePanel.Name) return; // if clicked button is already clicked then do nothing;
                var img = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{activeIcon}");
                activePanel.Visible = false;
                activeButton.Image = img ?? throw new Exception("image not found"); // throw an exception if image not found
                activeButton.ForeColor = Color.FromArgb(173, 179, 201);
            }
            activePanel = panel; // Change active panel with selected panel
            activeButton = button;
            activeIcon = icon;
            activePanel.Dock = DockStyle.Fill;
            activePanel.Visible = true; // Make visible selected panel
            activeButton.ForeColor = Color.White;
            activeButton.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{icon}_white");
        }

        /**
         * Add placeholder feature to the search textbox by checking value of textbox when entering and leaving from textbox.
         */
        private void MakePlaceholder(TextBox textBox, string placeholder, string eventName)
        {
            // developer needs to input eventName as lowercase
            if (eventName.ToLower() == "enter" && eventName != "enter") throw new Exception("eventName param needs to be lowercase");

            string val = textBox.Text.Trim().ToLower();
            if (eventName == "enter" && val == placeholder.ToLower())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                return;
            }
            else if (eventName == "leave" && string.IsNullOrWhiteSpace(val))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.FromArgb(173, 179, 201);
                return;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ActivePanel(tlpProjects, btnProjects, "icons8_group_of_projects_25");
            GetProjects();
        }

        private void GetProjects(string querystring = "")
        {
            var query = querystring == "" ? ctx.ProjectDetail.Join(ctx.Project, detail => detail.ProjectFK, project => project.ProjectID, (detail, project) => new
            {
                project.ProjectID,
                project.ProjectTitle,
                project.ProjectLeaderEmployeeFK,
                detail.ProjectDetailID,
                detail.ProjectDescription,
                detail.StartDate,
                detail.FinishDate,
                detail.Employees
            }).ToList() : ctx.ProjectDetail.Join(ctx.Project, detail => detail.ProjectFK, project => project.ProjectID, (detail, project) => new
            {
                project.ProjectID,
                project.ProjectTitle,
                project.ProjectLeaderEmployeeFK,
                detail.ProjectDetailID,
                detail.ProjectDescription,
                detail.StartDate,
                detail.FinishDate,
                detail.Employees
            }).Where(x => x.ProjectTitle == querystring).ToList();


            flpProjects.Controls.Clear(); // every time GetProjects() function called delete all panels/controls inside flpProjects and then create new controls.

            foreach (var item in query)
            {
                var sampleLeader = item.Employees.First(); // its not returning leader of team, it's just placeholder from db. TO-DO: get leader of team from db.
                var leader = ctx.Employee.Find(item.ProjectLeaderEmployeeFK);
                Panel newPanel = panel2.Clone();
                Label newLabel = label12.Clone();
                newLabel.Text = item.ProjectTitle;
                Label newLabel9 = label9.Clone();

                Button newButton = button4.Clone();
                newButton.Text = $"{leader.EmployeeFirstName} {leader.EmployeeLastName}";
                newButton.FlatAppearance.BorderSize = 0;
                var img = new Bitmap(File.OpenRead(leader.EmployeeImgPath));
                newButton.Image = ResizeImage(img, 30, 30);

                Label newLabel8 = label8.Clone();
                Label newLabel7 = label7.Clone();
                Label newLabel11 = label11.Clone();

                DateTime.TryParse(item.FinishDate.ToString(), out DateTime finishDate);
                newLabel7.Text = item.FinishDate != null ? $"          {item.StartDate.ToShortDateString()} - {finishDate.ToShortDateString()}" : $"          {item.StartDate.ToShortDateString()} - Devam Ediyor";

                Label newLabel10 = label10.Clone();
                newLabel10.Text = item.ProjectDescription;
                Button newBtnProjectDetailForm = btnProjectDetailForm.Clone();
                newBtnProjectDetailForm.FlatAppearance.BorderSize = 0;
                newBtnProjectDetailForm.Click += (senders, events) =>
                {
                    var f = new DetailProjectForm(item.ProjectID, item.ProjectDetailID);
                    f.FormClosed += (sender, eventh) => GetProjects(); // when form closed get new projects;
                    f.Show();
                };
                newPanel.Controls.Add(newLabel);
                newPanel.Controls.Add(newLabel9);
                newPanel.Controls.Add(newButton);
                newPanel.Controls.Add(newLabel8);
                newPanel.Controls.Add(newLabel7);
                newPanel.Controls.Add(newLabel11);
                newPanel.Controls.Add(newLabel10);
                newPanel.Controls.Add(newBtnProjectDetailForm);
                flpProjects.Controls.Add(newPanel);
                flpProjects.AutoScroll = true;
                newPanel.Visible = true;
                newLabel.Show();
                newLabel9.Show();
                newButton.Show();
                newLabel8.Show();
                newLabel7.Show();
                newLabel11.Show();
                newLabel10.Show();
                newBtnProjectDetailForm.Show();
            }
        }

        private void BtnDepartments_Click(object sender, EventArgs e)
        {
            dgvDepartments.AutoGenerateColumns = false;
            SaveAndGetDepartments();
            ActivePanel(tlpDepartments, btnDepartments, "icons8_organization_chart_people_25");
        }


        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtSearch, "Ara(Enter'a basınız)", "enter");
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtSearch, "Ara(Enter'a basınız)", "leave");
        }

        private void TxtAddDeparment_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtAddDeparment, "Yeni Birim Ekle (Eklemek için Enter'a basınız)", "enter");
        }

        private void TxtAddDeparment_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtAddDeparment, "Yeni Birim Ekle (Eklemek için Enter'a basınız)", "leave");
        }

        private void TxtAddQuestion_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtAddQuestion, "Yeni Soru Ekle (Eklemek için Enter'a basınız)", "enter");
        }

        private void TxtAddQuestion_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtAddQuestion, "Yeni Soru Ekle (Eklemek için Enter'a basınız)", "leave");
        }

        private void BtnQuestions_Click(object sender, EventArgs e)
        {
            dgvQuestions.AutoGenerateColumns = false;
            SaveAndGetQuestions();
            ActivePanel(tlpQuestions, btnQuestions, "icons8_questions_25");
        }

        private void SaveAndGetQuestions(bool save = false)
        {
            if (save) ctx.SaveChanges();
            dgvQuestions.DataSource = ctx.Question.ToList();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ActivePanel(tlpReports, btnReports, "icons8_business_report_25");
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            ActivePanel(tlpEmployees, btnEmployees, "icons8_people_working_together_25");

        }

        private void BtnAddEmployeeForm_Click(object sender, EventArgs e)
        {
            var f = new AddEmployeeForm();
            f.Show();
        }

        private void TxtAddQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            string questionTitle = txtAddQuestion.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(questionTitle))
                {
                    MessageBox.Show("Soru girmediniz!");
                    return;
                }
                ctx.Question.Add(new Question { QuestionTitle = questionTitle });
                SaveAndGetQuestions(true);
                txtAddQuestion.Clear();
            }
        }

        private void BtnAddProjectForm_Click(object sender, EventArgs e)
        {
            var f = new AddProjectForm();
            f.FormClosed += (senders, events) => GetProjects(); // when form closed get new projects;
            f.Show();
        }

        private void TxtAddDeparment_KeyDown(object sender, KeyEventArgs e)
        {
            string department = txtAddDeparment.Text.Trim();

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(department))
                {
                    MessageBox.Show("Birim adı girmediniz!");
                    return;
                }
                e.SuppressKeyPress = true;

                ctx.Department.Add(new Department { DepartmentName = department });
                SaveAndGetDepartments(true);

                txtAddDeparment.Clear();

            }
        }

        private void SaveAndGetDepartments(bool save = false)
        {
            if (save) ctx.SaveChanges();
            dgvDepartments.DataSource = ctx.Department.Select(x => new
            {
                x.DepartmentID,
                x.DepartmentName,
                EmployeesOfDepartment = x.Employees.Count
            }).ToList();
        }

        private void DgvDepartments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvDepartments.SelectedRows.Count > 0)
            {
                long id = (long)dgvDepartments.SelectedRows[0].Cells[0].Value;
                Department department = ctx.Department.Find(id);
                ctx.Department.Remove(department);
                SaveAndGetDepartments(true);
            }
        }

        private void DgvDepartments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = (long)dgvDepartments.SelectedRows[0].Cells[0].Value;
            Department department = ctx.Department.Find(id);
            DialogResult resultEditDepartmentForm = new EditDepartmentForm(department).ShowDialog();
            if (resultEditDepartmentForm == DialogResult.OK)
            {
                ctx.Entry(department).State = EntityState.Modified;
                SaveAndGetDepartments(true);
            }
        }

        private void DgvQuestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvQuestions.SelectedRows.Count > 0)
            {
                Question question = (Question)dgvQuestions.SelectedRows[0].DataBoundItem;
                ctx.Question.Remove(question);
                SaveAndGetQuestions(true);
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(activePanel.Name == "tlpProjects") GetProjects(txtSearch.Text);
                // if(activePanel.Name == "tlpDepartments") 
                // if(activePanel.Name == "tlpEmployees")
                // if(activePanel.Name == "tlpReports")
                // if(activePanel.Name == "tlpQuestions")
            }
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
