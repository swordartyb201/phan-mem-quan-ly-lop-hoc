using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;

namespace PracticeTeachingManagementSystem
{
    public partial class frmEquipment : DevExpress.XtraEditors.XtraForm
    {
        public frmEquipment()
        {
            InitializeComponent();
        }
        Tool clsTool = new Tool();
        PTMSDataContext db = new PTMSDataContext();
        void LoadGrid()
        {
            var eq = from equip in db.Equipments
                     select new { equip.EquipmentCode,equip.EquipmentName,equip.Firm,equip.Configuration};
            gcEquipment.DataSource = eq;
        }
        bool Test()
        {
            if (txtEquipmentCode.Text != "")
            {
                Equipment eq = db.Equipments.FirstOrDefault(e => e.EquipmentCode == txtEquipmentCode.Text);
                if (eq != null)
                    return true;
                else return false;
            }
            else return false;

        }
        void Empty()
        {
            txtConfiguration.Text = "";
            txtEquipmentCode.Text = "";
            cboEquipmentName.Text = "";
            cboFirm.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ( !clsTool.CheckEmptyCbo(cboEquipmentName, "Bạn chưa nhập tên thiết bị", err))
            {
                if (!Test())
                {
                    Equipment eq = new Equipment();
                    eq.EquipmentCode = txtEquipmentCode.Text;
                    eq.EquipmentName = cboEquipmentName.Text;
                    eq.Firm = cboFirm.Text;
                    eq.Configuration = txtConfiguration.Text;
                    db.Equipments.InsertOnSubmit(eq);
                    db.SubmitChanges();
                    LoadGrid();
                    MessageBox.Show("Nhập thành công", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();

                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Equipment eq = db.Equipments.FirstOrDefault(equip=>equip.EquipmentCode==eequipcode&&equip.EquipmentName==eequipname&&equip.Firm==ffirm&&equip.Configuration==cconfi);
            if (eq != null)
            {
                eq.EquipmentName = cboEquipmentName.Text;
                eq.Firm = cboFirm.Text;
                eq.Configuration = txtConfiguration.Text;
                db.SubmitChanges();
                LoadGrid();
                MessageBox.Show("Sửa thành công", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();

                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc chắn muốn xóa thiết bị này " , ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Equipment eq = db.Equipments.FirstOrDefault(equip => equip.EquipmentCode == eequipcode && equip.EquipmentName == eequipname && equip.Firm == ffirm && equip.Configuration == cconfi);
                if (eq != null)
                {
                    //xoa cac bang lien quan
                    db.ComputerEquipments.DeleteAllOnSubmit(db.ComputerEquipments.Where(ce => ce.EquipmentID == eq.EquipmentID));
                    db.ReplaceEquipments.DeleteAllOnSubmit(db.ReplaceEquipments.Where(ce => ce.ComputerEquipment.EquipmentID == eq.EquipmentID));

                    db.Equipments.DeleteOnSubmit(eq);
                    db.SubmitChanges();
                    LoadGrid();
                    Empty();
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
        string eequipcode, eequipname, ffirm, cconfi;
        private void gcEquipment_Click(object sender, EventArgs e)
        {
            foreach (GridCell cell in gvEquipment.GetSelectedCells())
            {
                txtEquipmentCode.Text =eequipcode= gvEquipment.GetRowCellDisplayText(cell.RowHandle, "EquipmentCode");
                cboEquipmentName.Text =eequipname= gvEquipment.GetRowCellDisplayText(cell.RowHandle, "EquipmentName");
                cboFirm.Text =ffirm= gvEquipment.GetRowCellDisplayText(cell.RowHandle, "Firm");
                txtConfiguration.Text =cconfi= gvEquipment.GetRowCellDisplayText(cell.RowHandle, "Configuration");
            }
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Empty();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            err.Clear();
        }

        private void cboEquipmentName_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtEquipmentCode_TextChanged(object sender, EventArgs e)
        {
            err.Clear();

            if (txtEquipmentCode.Text != "")
            {
                Equipment eq = db.Equipments.FirstOrDefault(x => x.EquipmentCode == txtEquipmentCode.Text);
                if (eq != null)
                    err.SetError(txtEquipmentCode, "Trùng mã");
            }
        }

       

       

      
    }
}