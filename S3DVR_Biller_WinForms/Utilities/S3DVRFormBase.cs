using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3DVR_Biller_WinForms
{
    public class S3DVRFormBase : Form
    {
        public DialogResult Confirm(string message)
        {
            return Confirm(message, "S3DVR-Biller");
        }
        public DialogResult Confirm(string message, string caption)
        {
            return ConfirmBox(message, caption);
        }
        private DialogResult ConfirmBox(string message, string caption)
        {
            return MessageBox.Show(message, "S3DVR-Biller", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public void ApplicationExit()
        {
            Environment.Exit(0);
        }
    }
}
