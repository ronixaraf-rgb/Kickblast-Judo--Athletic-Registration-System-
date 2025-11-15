using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kickblast_Judo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Username = (String)txtUsername.Text;
            String Password=(String)txtPassword.Text;
            if (Username == "admin" && Password == "admin123") {
                MessageBox.Show("Login Successful!","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                this.Hide();
                Registration newRegistration = new Registration();
                newRegistration.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } 
        }
    }
}
