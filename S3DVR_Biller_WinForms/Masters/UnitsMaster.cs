using S3DVR_Biller_BL;
using S3DVR_Biller_BL.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3DVR_Biller_WinForms.Masters
{
    public partial class UnitsMaster : S3DVRFormBase
    {
        public UnitsMaster()
        {
            InitializeComponent();
        }
        public UnitsMaster(int? iD)
            : this()
        {
            if (iD != null)
            {
                UnitsList unitsList = new UnitsList();
                unitsList.GetList(new ListParams("ID", iD));
                if (unitsList.Count > 0)
                {
                    txtUnitID.Text = unitsList[0].ID.ToString();
                    txtUnitName.Text = unitsList[0].Name;
                    txtDisplayName.Text = unitsList[0].DisplayName;
                    chkIsCompound.Checked = unitsList[0].IsCompound;
                    btnSaveUnit.Text = "Update";
                }
            }
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUnitMaster())
                {
                    Units objUnit = new Units();
                    if (!string.IsNullOrEmpty(txtUnitID.Text))
                        objUnit.ID = Convert.ToInt32(txtUnitID.Text);
                    objUnit.Name = txtUnitName.Text.Trim();
                    objUnit.DisplayName = txtDisplayName.Text.Trim();
                    objUnit.IsCompound = chkIsCompound.Checked;
                    if (objUnit.IsExistsUnit())
                        throw new ApplicationException("Same Unit already exists");
                    if (objUnit.UpdateData())
                    {
                        if (btnSaveUnit.Text == "Save")
                            ShowSuccessMessage("Unit created successfully");
                        else
                            ShowSuccessMessage("Unit updated successfully");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        throw new ApplicationException("Error occured while create or update Unit");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private bool ValidateUnitMaster()
        {
            txtUnitName.Border.BorderColor = Color.Black;
            txtDisplayName.Border.BorderColor = Color.Black;
            if (string.IsNullOrEmpty(txtUnitName.Text))
            {
                txtUnitName.Border.BorderColor = Color.Red;
                txtUnitName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDisplayName.Text))
            {
                txtDisplayName.Border.BorderColor = Color.Red;
                txtDisplayName.Focus();
                return false;
            }
            return true;
        }
    }
}
