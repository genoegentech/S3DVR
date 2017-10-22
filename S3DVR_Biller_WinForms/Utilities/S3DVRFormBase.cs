using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3DVR_Biller_WinForms
{
    public class S3DVRFormBase : DevComponents.DotNetBar.Office2007Form
    {
        private DevComponents.DotNetBar.StyleManager StyleManager1;
    
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
        public void ShowError(string message)
        {
            ShowError(message, "S3DVR-Biller");
        }
        public void ShowError(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        public void ShowError(Exception ex)
        {
            string errorMessage = ex.Message;
            if (ex.InnerException != null)
            {
                if (!string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    errorMessage += Environment.NewLine + ex.InnerException.Message;
                }
            }
            ShowError(errorMessage);
        }
        public void ShowSuccessMessage(string message)
        {
            ShowSuccessMessage(message, "S3DVR-Biller");
        }
        public void ShowSuccessMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void InitializeComponent()
        {
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager();
            this.SuspendLayout();
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // S3DVRFormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.DoubleBuffered = true;
            this.Name = "S3DVRFormBase";
            this.ResumeLayout(false);

        }
    }
}
