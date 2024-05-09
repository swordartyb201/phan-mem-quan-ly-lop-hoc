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
    public partial class frmSubject : DevExpress.XtraEditors.XtraForm
    {
        public frmSubject()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        bool clickGrid = false;
        void LoadCboChair()
        {

            var chairs = from c in db.Chairs
                         select new { c.ChairID, c.ChairCode, c.ChairName };
            cboChair.Properties.DataSource = chairs;
        }
        void LoadGrid()
        {
            var subJects = from s in db.Subjects
                           orderby s.Chair.ChairName, s.SubjectName
                           select new { s.Chair.ChairName, s.SubjectCode, s.SubjectName, s.Total };
            gcSubject.DataSource = subJects;
        }

        void Empty()
        {
            cboChair.Text = "";
            txtSubjectCode.Text = "";
            txtSubjectName.Text = "";
            spinTotal.Value = 2;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;


            LoadCboChair();
            LoadGrid();
        }
        private void frmSubject_Load(object sender, EventArgs e)
        {
            Empty();
        }

        private void cboChair_TextChanged(object sender, EventArgs e)
        {
            if (clickGrid == false)
            {
                var subJects = from s in db.Subjects
                               where s.ChairID == int.Parse(cboChair.EditValue.ToString())
                               orderby s.Chair.ChairName, s.SubjectName
                               select new { s.Chair.ChairName, s.SubjectCode, s.SubjectName, s.Total };
                gcSubject.DataSource = subJects;
                txtSubjectCode.Enabled = true;
                txtSubjectCode.Focus();
            }
        }

        bool SameSubjectCode()
        {
            Subject sub = db.Subjects.SingleOrDefault(s => s.SubjectCode.ToLower().Trim() == txtSubjectCode.Text.ToLower().Trim());
            if (sub != null)
                return true;
            else return false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!SameSubjectCode())//Neu khong trung thi Insert
            {
                Subject s = new Subject();
                s.SubjectCode = txtSubjectCode.Text;
                s.SubjectName = txtSubjectName.Text;
                s.Total = int.Parse(spinTotal.Text);
                s.ChairID = int.Parse(cboChair.EditValue.ToString());
                db.Subjects.InsertOnSubmit(s);
                db.SubmitChanges();
                LoadGrid();
                XtraMessageBox.Show("Thêm thành công!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                XtraMessageBox.Show("Trùng mã môn học!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void spinTotal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gcSubject_Click(object sender, EventArgs e)
        {
            clickGrid = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            int row = gvSubject.FocusedRowHandle;
            cboChair.Text = gvSubject.GetRowCellDisplayText(row, "ChairName");
            txtSubjectCode.Text = gvSubject.GetRowCellDisplayText(row, "SubjectCode");
            txtSubjectName.Text = gvSubject.GetRowCellDisplayText(row, "SubjectName");
            spinTotal.Text = gvSubject.GetRowCellDisplayText(row, "Total");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Subject s = db.Subjects.SingleOrDefault(sub => sub.SubjectCode.ToLower().Trim() == txtSubjectCode.Text.ToLower().Trim());
            if (s != null)
            {
                s.ChairID = int.Parse(cboChair.EditValue.ToString());
                s.Total = int.Parse(spinTotal.Text);
                s.SubjectName = txtSubjectName.Text;
                db.SubmitChanges();
                LoadGrid();
                XtraMessageBox.Show("Sửa thành công!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
                clickGrid = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Empty();
            cboChair.EditValue = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Subject s = db.Subjects.SingleOrDefault(sub => sub.SubjectCode.ToLower().Trim() == txtSubjectCode.Text.ToLower().Trim());
            if (s != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Subjects.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    LoadGrid();
                    Empty();
                    clickGrid = false;
                }
            }
        }

        private void txtSubjectCode_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void txtSubjectName_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void spinTotal_ValueChanged(object sender, EventArgs e)
        {
            if (clickGrid == false)
                btnInsert.Enabled = true;
        }
    }
}