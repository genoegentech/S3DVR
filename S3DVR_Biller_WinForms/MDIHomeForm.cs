using S3DVR_Biller_WinForms.Masters;
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
    public partial class MDIHomeForm : S3DVRFormBase
    {
        private UnitsMastersList _unitMasterList;
        public MDIHomeForm()
        {
            InitializeComponent();
        }

        private void MDIHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Confirm("Are you sure to exit?") == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
                ApplicationExit();
            }
            else
                e.Cancel = true;
        }

        private void btnRibbonUnitMaster_Click(object sender, EventArgs e)
        {
            if (_unitMasterList == null)
            {
                _unitMasterList = new UnitsMastersList();
                _unitMasterList.FormClosing += _unitMasterList_FormClosing;
            }
            _unitMasterList.StartPosition = FormStartPosition.CenterParent;
            _unitMasterList.MdiParent = this;
            _unitMasterList.WindowState = FormWindowState.Normal;
            _unitMasterList.Show();
        }

        private void _unitMasterList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitMasterList.FormClosing -= _unitMasterList_FormClosing;
            _unitMasterList = null;
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            MasterSample  MS= new MasterSample();
            MS.StartPosition = FormStartPosition.CenterParent;
            MS.MdiParent = this;
            MS.WindowState = FormWindowState.Normal;
            MS.Show();
        }
    }
}
