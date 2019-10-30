namespace Depman
{
    partial class AddReportForm
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
            this.cboProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.clmQuestionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuestionRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProjects
            // 
            this.cboProjects.FormattingEnabled = true;
            this.cboProjects.Location = new System.Drawing.Point(190, 44);
            this.cboProjects.Margin = new System.Windows.Forms.Padding(6);
            this.cboProjects.Name = "cboProjects";
            this.cboProjects.Size = new System.Drawing.Size(866, 33);
            this.cboProjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proje:";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmQuestionTitle,
            this.clmQuestionRating});
            this.dgvQuestions.Location = new System.Drawing.Point(190, 148);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(6);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 82;
            this.dgvQuestions.Size = new System.Drawing.Size(870, 340);
            this.dgvQuestions.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorular:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(190, 500);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(866, 142);
            this.txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(6, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açıklama:";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnAddProject.Location = new System.Drawing.Point(920, 679);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(140, 58);
            this.btnAddProject.TabIndex = 31;
            this.btnAddProject.Text = "Ekle";
            this.btnAddProject.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Çalışan:";
            // 
            // cboEmployees
            // 
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(190, 96);
            this.cboEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(866, 33);
            this.cboEmployees.TabIndex = 32;
            this.cboEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboEmployees_Format);
            // 
            // clmQuestionTitle
            // 
            this.clmQuestionTitle.DataPropertyName = "QuestionTitle";
            this.clmQuestionTitle.HeaderText = "Soru";
            this.clmQuestionTitle.MinimumWidth = 10;
            this.clmQuestionTitle.Name = "clmQuestionTitle";
            // 
            // clmQuestionRating
            // 
            this.clmQuestionRating.DataPropertyName = "Rating";
            this.clmQuestionRating.HeaderText = "Puan";
            this.clmQuestionRating.MinimumWidth = 10;
            this.clmQuestionRating.Name = "clmQuestionRating";
            // 
            // AddReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1100, 779);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEmployees);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProjects);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddReportForm";
            this.Text = "AddReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestionRating;
    }
}