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
    public partial class UnitsMastersList : S3DVRFormBase
    {
        public UnitsMastersList()
        {
            InitializeComponent();
        }

        private void UnitsMastersList_Load(object sender, EventArgs e)
        {
            LoadList(txtUnitName.Text, txtDisplayName.Text);
        }
        private void LoadList(string name, string displayName)
        {
            UnitsList unitsList = new UnitsList();
            ListParams lpUnitsList = new ListParams("NameLike", name);
            lpUnitsList.Add("DisplayNameLike", displayName);
            unitsList.GetList(lpUnitsList);
            dgUnitsMastersList.DataSource = unitsList;
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            LoadList(txtUnitName.Text, txtDisplayName.Text);
        }

        private void txtDisplayName_TextChanged(object sender, EventArgs e)
        {
            LoadList(txtUnitName.Text, txtDisplayName.Text);
        }

        private void btnNewUnits_Click(object sender, EventArgs e)
        {
            UnitsMaster frmUnitMaster = new UnitsMaster();
            if (frmUnitMaster.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                LoadList(txtUnitName.Text, txtDisplayName.Text);
            }
        }

        private void btnDeleteUnits_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUnitsMastersList.SelectedRows.Count == 0)
                    throw new ApplicationException("Please select any unit to delete");

                if (Confirm("Are you sure to delete?") == System.Windows.Forms.DialogResult.Yes)
                {
                    Units objUnit = new Units();
                    objUnit.ID = Convert.ToInt32(dgUnitsMastersList.SelectedRows[0].Cells[0].Value);
                    if (objUnit.DeleteUnit())
                    {
                        ShowSuccessMessage("Unit successfully deleted");
                        LoadList(txtUnitName.Text, txtDisplayName.Text);
                    }
                    else
                    {
                        throw new ApplicationException("Error occured while delete unit");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnEditUnits_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUnitsMastersList.SelectedRows.Count == 0)
                    throw new ApplicationException("Please select any unit to edit");

                UnitsMaster frmUnitMaster = new UnitsMaster(Convert.ToInt32(dgUnitsMastersList.SelectedRows[0].Cells[0].Value));
                if (frmUnitMaster.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    LoadList(txtUnitName.Text, txtDisplayName.Text);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    }
}
