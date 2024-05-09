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
    public partial class frmError : DevExpress.XtraEditors.XtraForm
    {
        public frmError()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        private void frmError_Load(object sender, EventArgs e)
        {
            LoadgcError();

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Clear();

            error.Clear();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            error.Clear();
        }
        void Clear()
        {
            txtDescription.Text = "";
            txtErrorName.Text = "";
        }
        void LoadgcError()
        {
            var lst = from e in db.Errors select e;
            //Download source code mien phi tai Sharecode.vn
            DataTable dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("ErrorName");
            dt.Columns.Add("Description");

            int dem = 0;
            foreach (var i in lst)
            {
                dt.Rows.Add((++dem).ToString(), i.ErrorName, i.Description);
            }
            gcError.DataSource = dt;
        }
        /// <summary> 
        /// Kiểm tra textbox,combobox có dữ liệu hay chưa?
        /// </summary>
        /// <param name="ct">Tên điều khiển cần kiểm tra</param>
        /// <param name="errror">Nội dung lỗi cần hiển thị</param>
        /// <returns></returns>
        private bool CheckEmptyControl(Control ct, string errror)
        {
            if (ct.Text == "")
            {
                error.SetError(ct, errror);
                ct.Focus();
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }
        /// <summary>
        /// Kiểm tra tên lỗi(Không trùng với bất kì lỗi nào)
        /// </summary>
        /// <param name="code">Tên lỗi cần kiểm tra</param>
        ///  <param name="code">Tên lỗi cần  loại trừ kiểm tra</param>
        /// <returns>Trả về true nếu có trùng mã ngược lại trả về false</returns>
        bool CheckErrorName(string errorName, string errorNameSkip)
        {
            error.Clear();
            bool kt = false;

            var lst = from c in db.Errors select new { c.ErrorName };
            foreach (var i in lst)
            {
                if (i.ErrorName.Trim() == errorName.Trim() && i.ErrorName.Trim() != errorNameSkip.Trim())
                {
                    kt = true;
                    error.SetError(txtErrorName, "Tên lỗi này đã tồn tại.");
                    txtErrorName.Focus();
                    break;
                }
            }
            return kt;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyControl(txtErrorName, "Chưa nhập tên lỗi") == false && CheckErrorName(txtErrorName.Text, "") == false)
            {
                Error er = new Error();

                er.ErrorName = txtErrorName.Text;
                er.Description = txtDescription.Text;
                db.Errors.InsertOnSubmit(er);
                db.SubmitChanges();
                //load lại dữ liệu
                LoadgcError();
                Clear();
                MessageBox.Show("Đã Thêm thông tin thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void txtErrorName_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
        string errorName;
        private void gcError_Click(object sender, EventArgs e)
        {
            foreach (GridCell item in gvError.GetSelectedCells())
            {
                errorName = txtErrorName.Text = gvError.GetRowCellDisplayText(item.RowHandle, "ErrorName");
                txtDescription.Text = gvError.GetRowCellDisplayText(item.RowHandle, "Description");
            }
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyControl(txtErrorName, "Chưa nhập tên lỗi") == false && CheckErrorName(txtErrorName.Text, errorName) == false)
            {
                Error er = db.Errors.SingleOrDefault(x => x.ErrorName == errorName);

                er.ErrorName = txtErrorName.Text;
                er.Description = txtDescription.Text;

                db.SubmitChanges();


                LoadgcError();
                Clear();
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Đã sửa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nỗi ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Error er = db.Errors.SingleOrDefault(x => x.ErrorName == errorName);
                db.Errors.DeleteOnSubmit(er);
                db.SubmitChanges();

                LoadgcError();
                Clear();
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Đã xóa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }



    }
}
