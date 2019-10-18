using Depman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        bool whitetheme = false;

        DepmanContext ctx;

        public MainForm()
        {
            InitializeComponent();
            ActivePanel(tlpProjects, btnProjects, "icons8_group_of_projects_25");
            ctx = new DepmanContext();
            dgvQuestions.DataSource = ctx.Question.ToList();
            dgvDepartments.AutoGenerateColumns = false;
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
            ActivePanel(tlpDepartments, btnDepartments, "icons8_organization_chart_people_25");
            ListDepartments();
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
            ActivePanel(tlpQuestions, btnQuestions, "icons8_questions_25");
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

        private void txtAddQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void TxtAddQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctx.Question.Add(new Question { QuestionTitle = txtAddQuestion.Text });
                ctx.SaveChanges();
                dgvQuestions.DataSource = ctx.Question.ToList();
            }
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

                ctx.Department.Add(new Department { DepartmentName = department });
                ctx.SaveChanges();
                dgvDepartments.DataSource = ctx.Department.ToList();

                txtAddDeparment.Clear();

                e.SuppressKeyPress = true;
            }
        }

        private void DgvDepartments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvDepartments.SelectedRows.Count > 0)
            {
                Department department = (Department)dgvDepartments.SelectedRows[0].DataBoundItem;
                ctx.Department.Remove(department);
                ctx.SaveChanges();
                ListDepartments();
                // int selectedDepID = dgvDepartments.CurrentRow.Index;

                //if (selectedDepID != 0)
                //{
                //    dgvDepartments.Rows[selectedDepID - 1].Selected = true;

                //}
                //else
                //    dgvDepartments.ClearSelection();
            }
        }

        private void ListDepartments()
        {
            dgvDepartments.DataSource = ctx.Department.ToList();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            ActivePanel(tlpSettings, btnSettings, "icons8_settings_25");
        }

        private void TlpSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel)
                {
                    ((Panel)x).BackColor = Color.FromArgb(204, 204, 204);
                }
            }

            btnProjects.ForeColor = Color.FromArgb(23, 28, 48);

            btnEmployees.ForeColor = Color.FromArgb(23, 28, 48);

            btnDepartments.ForeColor = Color.FromArgb(23, 28, 48);

            btnReports.ForeColor = Color.FromArgb(23, 28, 48);

            btnQuestions.ForeColor = Color.FromArgb(23, 28, 48);

            btnSettings.ForeColor = Color.FromArgb(23, 28, 48);

            label13.ForeColor = Color.FromArgb(23, 28, 48);

            label1.ForeColor = Color.FromArgb(23, 28, 48);

            dgvDepartments.BackgroundColor = Color.FromArgb(217, 217, 217);

            dgvQuestions.BackgroundColor = Color.FromArgb(217, 217, 217);

            panel5.BackColor = Color.FromArgb(255, 255, 255);

            btnDetailReport.BackColor = Color.FromArgb(255, 255, 255);

            btnDetailReport.ForeColor = Color.FromArgb(217, 217, 217);

            //whitetheme = true;

            //foreach (Control c in Controls)
            //{
            //    c.BackColor = Color.FromArgb(217, 217, 217);
            //    c.ForeColor = Color.FromArgb(23, 28, 48);
            //}
        }

        private void BtnDark_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel)
                {
                    ((Panel)x).BackColor = Color.FromArgb(23, 28, 48);
                }
            }

            btnProjects.ForeColor = Color.FromArgb(217, 217, 217);

            btnEmployees.ForeColor = Color.FromArgb(217, 217, 217);

            btnDepartments.ForeColor = Color.FromArgb(217, 217, 217);

            btnReports.ForeColor = Color.FromArgb(217, 217, 217);

            btnQuestions.ForeColor = Color.FromArgb(217, 217, 217);

            btnSettings.ForeColor = Color.FromArgb(217, 217, 217);

            label13.ForeColor = Color.FromArgb(217, 217, 217);

            label1.ForeColor = Color.FromArgb(217, 217, 217);

            dgvDepartments.BackgroundColor = Color.FromArgb(23, 28, 48);

            dgvQuestions.BackgroundColor = Color.FromArgb(23, 28, 48);
        }
    }
}