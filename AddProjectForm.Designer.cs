namespace Depman
{
    partial class AddProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMemberOfTeam = new System.Windows.Forms.ListBox();
            this.cboLeaderOfTeam = new System.Windows.Forms.ComboBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtPasiveMemberOfTeam = new System.Windows.Forms.TextBox();
            this.cboAddMemberOfTeam = new System.Windows.Forms.ComboBox();
            this.txtPasiveLeaderOfTeam = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.txtPasiveLeaderOfTeam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lstMemberOfTeam);
            this.panel2.Controls.Add(this.cboLeaderOfTeam);
            this.panel2.Controls.Add(this.btnAddProject);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.cboDepartment);
            this.panel2.Controls.Add(this.txtProjectName);
            this.panel2.Controls.Add(this.txtPasiveMemberOfTeam);
            this.panel2.Controls.Add(this.cboAddMemberOfTeam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 690);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(18, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 43);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ekip Üyeleri:";
            // 
            // lstMemberOfTeam
            // 
            this.lstMemberOfTeam.FormattingEnabled = true;
            this.lstMemberOfTeam.ItemHeight = 30;
            this.lstMemberOfTeam.Location = new System.Drawing.Point(240, 321);
            this.lstMemberOfTeam.Margin = new System.Windows.Forms.Padding(4);
            this.lstMemberOfTeam.Name = "lstMemberOfTeam";
            this.lstMemberOfTeam.Size = new System.Drawing.Size(252, 244);
            this.lstMemberOfTeam.TabIndex = 32;
            this.lstMemberOfTeam.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LstMemberOfTeam_Format);
            this.lstMemberOfTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstMemberOfTeam_KeyDown);
            // 
            // cboLeaderOfTeam
            // 
            this.cboLeaderOfTeam.FormattingEnabled = true;
            this.cboLeaderOfTeam.Location = new System.Drawing.Point(240, 185);
            this.cboLeaderOfTeam.Margin = new System.Windows.Forms.Padding(6);
            this.cboLeaderOfTeam.Name = "cboLeaderOfTeam";
            this.cboLeaderOfTeam.Size = new System.Drawing.Size(250, 38);
            this.cboLeaderOfTeam.TabIndex = 31;
            this.cboLeaderOfTeam.Visible = false;
            this.cboLeaderOfTeam.SelectedIndexChanged += new System.EventHandler(this.CboLeaderOfTeam_SelectedIndexChanged);
            this.cboLeaderOfTeam.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboLeaderOfTeam_Format);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnAddProject.Location = new System.Drawing.Point(1016, 612);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(218, 58);
            this.btnAddProject.TabIndex = 30;
            this.btnAddProject.Text = "Kaydet";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(602, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 43);
            this.label10.TabIndex = 29;
            this.label10.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(522, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 43);
            this.label9.TabIndex = 28;
            this.label9.Text = "Başlama Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(602, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 43);
            this.label7.TabIndex = 26;
            this.label7.Text = "Birim Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 43);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ekip Lideri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(148, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 43);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Proje Ekle";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(786, 250);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(448, 306);
            this.txtDescription.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(790, 173);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(442, 43);
            this.dtpStartDate.TabIndex = 6;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(790, 102);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(6);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(442, 38);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.CboDepartment_SelectedIndexChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(240, 104);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(6);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(252, 37);
            this.txtProjectName.TabIndex = 0;
            // 
            // txtPasiveMemberOfTeam
            // 
            this.txtPasiveMemberOfTeam.Location = new System.Drawing.Point(240, 254);
            this.txtPasiveMemberOfTeam.Margin = new System.Windows.Forms.Padding(6);
            this.txtPasiveMemberOfTeam.Name = "txtPasiveMemberOfTeam";
            this.txtPasiveMemberOfTeam.ReadOnly = true;
            this.txtPasiveMemberOfTeam.Size = new System.Drawing.Size(252, 37);
            this.txtPasiveMemberOfTeam.TabIndex = 38;
            this.txtPasiveMemberOfTeam.Text = "Ekip lideri seçili olmalı!";
            // 
            // cboAddMemberOfTeam
            // 
            this.cboAddMemberOfTeam.FormattingEnabled = true;
            this.cboAddMemberOfTeam.Location = new System.Drawing.Point(242, 254);
            this.cboAddMemberOfTeam.Margin = new System.Windows.Forms.Padding(6);
            this.cboAddMemberOfTeam.Name = "cboAddMemberOfTeam";
            this.cboAddMemberOfTeam.Size = new System.Drawing.Size(250, 38);
            this.cboAddMemberOfTeam.TabIndex = 37;
            this.cboAddMemberOfTeam.Visible = false;
            this.cboAddMemberOfTeam.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboAddMemberOfTeam_Format);
            this.cboAddMemberOfTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboAddMemberOfTeam_KeyDown);
            // 
            // txtPasiveLeaderOfTeam
            // 
            this.txtPasiveLeaderOfTeam.Location = new System.Drawing.Point(240, 186);
            this.txtPasiveLeaderOfTeam.Margin = new System.Windows.Forms.Padding(6);
            this.txtPasiveLeaderOfTeam.Name = "txtPasiveLeaderOfTeam";
            this.txtPasiveLeaderOfTeam.ReadOnly = true;
            this.txtPasiveLeaderOfTeam.Size = new System.Drawing.Size(252, 37);
            this.txtPasiveLeaderOfTeam.TabIndex = 39;
            this.txtPasiveLeaderOfTeam.Text = "Birim seçili olmalı!";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1306, 761);
            this.MinimumSize = new System.Drawing.Size(1306, 761);
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depman - Proje Ekle";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMemberOfTeam;
        private System.Windows.Forms.ComboBox cboLeaderOfTeam;
        private System.Windows.Forms.ComboBox cboAddMemberOfTeam;
        private System.Windows.Forms.TextBox txtPasiveMemberOfTeam;
        private System.Windows.Forms.TextBox txtPasiveLeaderOfTeam;
    }
}