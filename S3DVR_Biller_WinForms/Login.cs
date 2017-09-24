using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3DVR_Biller_WinForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Border.BorderColor = Color.Black;
            txtPassword.Border.BorderColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Border.BorderColor = Color.Black;
            txtPassword.Border.BorderColor = Color.Black;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Border.BorderColor = Color.Red;
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Border.BorderColor = Color.Red;
                txtPassword.Focus();
                return;
            }
            this.Hide();
            MDIHomeForm mdiParentWindow = new MDIHomeForm();
            mdiParentWindow.Show();
        }
    }
}
