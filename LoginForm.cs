using Depman.Models;
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
    public partial class LoginForm : Form
    {
        DepmanContext ctx = new DepmanContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtUsername, "Kullanıcı adı", "enter");

        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtUsername, "Kullanıcı adı", "leave");

        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            MakePlaceholder(txtPassword, "Şifre", "enter");

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            MakePlaceholder(txtPassword, "Şifre", "leave");

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı yada şifre boş olamaz!");
                return;
            }

            var user = ctx.User.Where(x => x.Username.ToLower() == txtUsername.Text.ToLower() && x.Password == x.Password).SingleOrDefault();
            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı yada şifre yanlış!");
                return;
            }

            var f = new MainForm(user);
            f.FormClosed += (senders, events) => this.Close(); // Closing LoginForm when MainForm is closed
            f.Show();
            Visible = false;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }

        }
    }
}
