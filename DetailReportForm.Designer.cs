namespace Depman
{
    partial class DetailReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.clmQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuestionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReportDescription = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(131, 53);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(165, 21);
            this.cboEmployees.TabIndex = 38;
            this.cboEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboEmployees_Format);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnGoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoruntule.FlatAppearance.BorderSize = 0;
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnGoruntule.Location = new System.Drawing.Point(386, 408);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(109, 30);
            this.btnGoruntule.TabIndex = 35;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmQuestionID,
            this.clmQuestionTitle});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQuestions.Location = new System.Drawing.Point(131, 124);
            this.dgvQuestions.Name = "dgvQuestions";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuestions.Size = new System.Drawing.Size(499, 160);
            this.dgvQuestions.TabIndex = 34;
            // 
            // clmQuestionID
            // 
            this.clmQuestionID.DataPropertyName = "QuestionID";
            this.clmQuestionID.HeaderText = "Soru ID";
            this.clmQuestionID.Name = "clmQuestionID";
            this.clmQuestionID.ReadOnly = true;
            // 
            // clmQuestionTitle
            // 
            this.clmQuestionTitle.DataPropertyName = "QuestionTitle";
            this.clmQuestionTitle.HeaderText = "Soru Başlık";
            this.clmQuestionTitle.Name = "clmQuestionTitle";
            this.clmQuestionTitle.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(48, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sorular:";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnAddProject.Location = new System.Drawing.Point(521, 408);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(109, 30);
            this.btnAddProject.TabIndex = 30;
            this.btnAddProject.Text = "Kaydet";
            this.btnAddProject.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(35, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(36, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Birim Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Çalışan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rapor Detay";
            // 
            // txtReportDescription
            // 
            this.txtReportDescription.Location = new System.Drawing.Point(131, 290);
            this.txtReportDescription.Multiline = true;
            this.txtReportDescription.Name = "txtReportDescription";
            this.txtReportDescription.Size = new System.Drawing.Size(499, 112);
            this.txtReportDescription.TabIndex = 7;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(477, 52);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(153, 22);
            this.dtpHireDate.TabIndex = 6;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(131, 88);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(165, 21);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.CboDepartment_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboEmployees);
            this.panel2.Controls.Add(this.btnGoruntule);
            this.panel2.Controls.Add(this.dgvQuestions);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAddProject);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtReportDescription);
            this.panel2.Controls.Add(this.dtpHireDate);
            this.panel2.Controls.Add(this.cboDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 460);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(306, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "İşe Başlama Tarihi:";
            // 
            // DetailReportForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 460);
            this.Controls.Add(this.panel2);
            this.Name = "DetailReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestionTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReportDescription;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}