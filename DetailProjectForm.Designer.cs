namespace Depman
{
    partial class DetailProjectForm
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
            this.cboAddMemberOfTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(19, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ekip Üyeleri:";
            // 
            // lstMemberOfTeam
            // 
            this.lstMemberOfTeam.FormattingEnabled = true;
            this.lstMemberOfTeam.Location = new System.Drawing.Point(130, 166);
            this.lstMemberOfTeam.Margin = new System.Windows.Forms.Padding(2);
            this.lstMemberOfTeam.Name = "lstMemberOfTeam";
            this.lstMemberOfTeam.Size = new System.Drawing.Size(128, 121);
            this.lstMemberOfTeam.TabIndex = 49;
            this.lstMemberOfTeam.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LstMemberOfTeam_Format);
            this.lstMemberOfTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstMemberOfTeam_KeyDown);
            // 
            // cboLeaderOfTeam
            // 
            this.cboLeaderOfTeam.FormattingEnabled = true;
            this.cboLeaderOfTeam.Location = new System.Drawing.Point(130, 95);
            this.cboLeaderOfTeam.Name = "cboLeaderOfTeam";
            this.cboLeaderOfTeam.Size = new System.Drawing.Size(127, 21);
            this.cboLeaderOfTeam.TabIndex = 48;
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
            this.btnAddProject.Location = new System.Drawing.Point(518, 318);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(109, 30);
            this.btnAddProject.TabIndex = 47;
            this.btnAddProject.Text = "Kaydet";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(311, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(271, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Başlama Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(311, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Birim Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ekip Lideri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(84, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Proje Detay";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(403, 129);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 161);
            this.txtDescription.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(405, 89);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(223, 25);
            this.dtpStartDate.TabIndex = 39;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(405, 53);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(223, 21);
            this.cboDepartment.TabIndex = 38;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.CboDepartment_SelectedIndexChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(130, 53);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(128, 20);
            this.txtProjectName.TabIndex = 37;
            // 
            // cboAddMemberOfTeam
            // 
            this.cboAddMemberOfTeam.FormattingEnabled = true;
            this.cboAddMemberOfTeam.Location = new System.Drawing.Point(130, 130);
            this.cboAddMemberOfTeam.Name = "cboAddMemberOfTeam";
            this.cboAddMemberOfTeam.Size = new System.Drawing.Size(127, 21);
            this.cboAddMemberOfTeam.TabIndex = 54;
            this.cboAddMemberOfTeam.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboAddMemberOfTeam_Format);
            this.cboAddMemberOfTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboAddMemberOfTeam_KeyDown);
            // 
            // DetailProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(653, 374);
            this.Controls.Add(this.cboAddMemberOfTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstMemberOfTeam);
            this.Controls.Add(this.cboLeaderOfTeam);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.txtProjectName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailProjectForm";
            this.Text = "DetailProjectForm";
            this.Load += new System.EventHandler(this.DetailProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMemberOfTeam;
        private System.Windows.Forms.ComboBox cboLeaderOfTeam;
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
        private System.Windows.Forms.ComboBox cboAddMemberOfTeam;
    }
}