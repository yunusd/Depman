namespace Depman
{
    partial class EditDepartmentForm
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
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditDeparment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(167, 61);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(242, 40);
            this.txtDepartmentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birim Adı:";
            // 
            // btnEditDeparment
            // 
            this.btnEditDeparment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnEditDeparment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDeparment.FlatAppearance.BorderSize = 0;
            this.btnEditDeparment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeparment.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDeparment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnEditDeparment.Location = new System.Drawing.Point(1, 157);
            this.btnEditDeparment.Name = "btnEditDeparment";
            this.btnEditDeparment.Size = new System.Drawing.Size(212, 50);
            this.btnEditDeparment.TabIndex = 6;
            this.btnEditDeparment.Text = "Kaydet";
            this.btnEditDeparment.UseVisualStyleBackColor = false;
            this.btnEditDeparment.Click += new System.EventHandler(this.BtnEditDeparment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnCancel.Location = new System.Drawing.Point(231, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(439, 207);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditDeparment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartmentName);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "EditDepartmentForm";
            this.Text = "EditDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditDeparment;
        private System.Windows.Forms.Button btnCancel;
    }
}