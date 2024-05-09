using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace PracticeTeachingManagementSystem
{
    public partial class frmPermission : DevExpress.XtraEditors.XtraForm
    {
        public frmPermission()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        void LoadGrid()
        {
            gcPermission.DataSource = db.Permissions;
        }
        bool TestPermissionName(string permissionName)
        {
            Permission per = db.Permissions.SingleOrDefault(p=>p.PermissionName==permissionName);
            if (per != null)
                return true;
            else return false;
        }
        private void frmPermission_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void gvPermission_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SubmitChanges();
        }

        private void gvPermission_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            db.SubmitChanges();
           
         
        }

        private void gvPermission_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int row = gvPermission.RowCount - 2;
            string a = gvPermission.GetRowCellDisplayText(row, "PermissionName");
            MessageBox.Show(a);
            if (a != null && a != "")
            {
                if (!TestPermissionName(a))
                {
                    db.SubmitChanges();
                }
                else
                {

                    XtraMessageBox.Show("Mã quyền bị trùng, bạn hãy nhập lại", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn không được để trống quyền", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvPermission_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void gvPermission_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
               
                if (gvPermission.SelectedRowsCount < 0)
                    return;
                else
                {
                   DialogResult ds= XtraMessageBox.Show("Bạn chắc chắn muốn xóa?",Application.ProductName,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                   if (ds == DialogResult.OK)
                   {
                       gvPermission.DeleteRow(gvPermission.SelectedRowsCount);
                       db.SubmitChanges();
                   }
                }
            }
        }
    }
}