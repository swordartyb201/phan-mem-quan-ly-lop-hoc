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
    public partial class frmConfigHaftYear : DevExpress.XtraEditors.XtraForm
    {
        public frmConfigHaftYear()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        private void LoadYear()
        {
            cboYear.Properties.Items.Clear();
            
            int y = DateTime.Now.Year-3;
            for (int i = y ; i < y+ 4; i++)
            {
                cboYear.Properties.Items.Add(i.ToString() +" - "+(i+1).ToString());

            }
            // cbeStartYear.SelectedIndex = 4;
        }
        void LoadGrid()
        {

            var cf = from c in db.ConfigHaflYears
                     select new { c.Year,c.StartDate};
            gcConfig.DataSource = db.ConfigHaflYears;
            
        }
        private void frmConfigHaftYear_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadYear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConfigHaflYear cf = db.ConfigHaflYears.SingleOrDefault(y=>y.Year==cboYear.Text);
            if (cf == null)
            {
                cf = new ConfigHaflYear();
                cf.Year = cboYear.Text;
                cf.StartDate = DateTime.Parse(dtpStartDate.Text);
                db.ConfigHaflYears.InsertOnSubmit(cf);
                db.SubmitChanges();
                LoadGrid();
                XtraMessageBox.Show("Cấu hình thành công",ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void gvPermission_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (gvConfig.SelectedRowsCount < 0)
                    return;
                else
                {
                    DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (ds == DialogResult.OK)
                    {
                        MessageBox.Show(gvConfig.SelectedRowsCount.ToString());
                        gvConfig.DeleteRow(gvConfig.SelectedRowsCount);
                        db.SubmitChanges();
                    }
                }
            }
        }

        private void gvPermission_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SubmitChanges();
        }

       
       
    }
}