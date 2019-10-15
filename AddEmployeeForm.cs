using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depman
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnUploadEmployeePic_Click(object sender, EventArgs e)
        {
            ofdUploadEmployeePic.ShowDialog();
        }
    }
}
