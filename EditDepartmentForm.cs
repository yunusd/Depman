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
    public partial class EditDepartmentForm : Form
    {
        Department department;
        public EditDepartmentForm(Department department)
        {
            this.department = department;
            InitializeComponent();
            txtDepartmentName.Text = department.DepartmentName;
        }

        private void BtnEditDeparment_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text.Trim();
            if (string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("Birim adı boş olmamalı!");
                return;
            }
            department.DepartmentName = departmentName;
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
