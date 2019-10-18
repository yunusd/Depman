using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        DepmanContext ctx;

        public MainForm()
        {
            InitializeComponent();
            ActivePanel(tlpProjects, btnProjects, "icons8_group_of_projects_25");
            ctx = new DepmanContext();
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

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ActivePanel(tlpProjects, btnProjects, "icons8_group_of_projects_25");
        }

        private void BtnDepartments_Click(object sender, EventArgs e)
        {
            dgvDepartments.AutoGenerateColumns = false;
            SaveAndGetDepartments();
            ActivePanel(tlpDepartments, btnDepartments, "icons8_organization_chart_people_25");
        }


        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtSearch, "Ara", "enter");
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtSearch, "Ara", "leave");
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
                ctx.Question.Add(new Question { QuestionTitle =  questionTitle });
                SaveAndGetQuestions(true);
                txtAddQuestion.Clear();
            }
        }

        private void BtnAddProjectForm_Click(object sender, EventArgs e)
        {
            var f = new AddProjectForm();
            f.Show();
        }

        private void BtnProjectDetailForm_Click(object sender, EventArgs e)
        {
            var f = new DetailProjectForm();
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
                long id = (long)dgvQuestions.SelectedRows[0].Cells[0].Value;
                Question question = ctx.Question.Find(id);
                ctx.Question.Remove(question);
                SaveAndGetQuestions(true);
            }
        }
    }
}
