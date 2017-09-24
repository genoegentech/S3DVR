using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace S3DVR_Biller_WinForms.UserControls
{
    public partial class TextInputControl : UserControl
    {
        public TextInputControl()
        {
            InitializeComponent();
        }
        //public string PlaceHolderText
        //{
        //    get { return txtInput.WatermarkText; }
        //    set { txtInput.WatermarkText = value; }
        //}
        public new int Width
        {
            get { return this.Width; }
            set
            {
                txtInput.Width = value;
                this.Width = value;
            }
        }
        public StyleManager StyleManager
        {
            get { return styleManager1; }
            set { styleManager1 = value; }
        }
        //public Color BackGroundColor
        //{
        //    get { return this.BackColor; }
        //    set { this.BackColor = value; }
        //}

        public void get()
        {
            //this.Width = 
        }

        private void TextInputControl_Load(object sender, EventArgs e)
        {
            //this.Width = 100;
        }
    }
}
