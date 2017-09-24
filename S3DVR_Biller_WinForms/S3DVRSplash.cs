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
    public partial class S3DVRSplash : Form
    {
        public S3DVRSplash()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (splashProgress.Value == 100)
            {
                this.Hide();
                Login frmLogin = new Login();
                frmLogin.Show();
                splashTimer.Enabled = false;
            }
            splashProgress.Value += 10;
        }

        private void S3DVRSplash_Load(object sender, EventArgs e)
        {
            splashProgress.Value = 1;
        }
    }
}
