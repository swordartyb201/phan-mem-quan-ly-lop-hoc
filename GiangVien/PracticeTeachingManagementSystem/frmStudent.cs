using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace PracticeTeachingManagementSystem
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraForm
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        PTMSDataContext db = new PTMSDataContext();
        Tool clsTool = new Tool();
        #region Các phương thức Load dữ liệu lên GridControl,kiểm tra trùng mã, xóa trắng các điều khiển
        /// <summary>
        ///ẩn hiện các button, checkbox
        /// </summary>
        /// <returns></returns>
        void ShowHide(bool hide)
        {
            btnInsert.Enabled = !hide;
          
            btnDeleteStudent.Enabled = !hide;
            txtStudentCode.Properties.ReadOnly = !hide;
            cboClass.Properties.ReadOnly = !hide;
        }
        /// <summary>
        /// Xóa các dữ liệu trên TextEdit
        /// </summary>
        void Empty()
        {
            foreach (Control ct in groupControl1.Controls)
            {
                if (ct is TextEdit || ct is ComboBoxEdit)
                    ct.Text = "";
            }
            cboClass.Focus();
            gcStudent.DataSource = null;
            ShowHide(true);
        }
        /// <summary>
        /// Load tên khoa lên Combobox
        /// </summary>
        void LoadComboClass()
        {
            cboClass.Properties.Items.Clear();
            var dePart = from d in db.Classes
                         select new { d.ClassName };
            foreach (var item in dePart)
            {
                cboClass.Properties.Items.Add(item.ClassName);
            }

        }
        int GetClassID()
        {
            Class c = db.Classes.Single(d => d.ClassName == cboClass.Text);
            return c.ClassID;
        }
        /// <summary>
        /// Load dữ liệu lên GridControl
        /// </summary>
        void LoadGridControl()
        {
           
            if (cboClass.Text != "")
            {
                var student = from s in db.Students
                              where s.Class.ClassName == cboClass.Text
                              orderby s.StudentCode
                              select new { s.Class.ClassName, s.StudentCode, s.FullName, s.BirthDay };
                gcStudent.DataSource = student;
            }
        }
        #endregion
        #region Cập nhật, xóa sinh viên
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text != "" && txtFullName.Text != "")
            {
                Student st = db.Students.SingleOrDefault(stuDent => stuDent.StudentCode.Trim() == txtStudentCode.Text.Trim());
                if (st != null)
                {
                    st.FullName = txtFullName.Text;
                    st.BirthDay = dtpBirth.Text;
                    db.SubmitChanges();
                    LoadGridControl();
                    MessageBox.Show("Cập nhập thành công", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();

                }
                else
                {

                    Student s = new Student();
                    s.StudentCode = txtStudentCode.Text;
                    s.FullName = txtFullName.Text;
                    s.BirthDay = dtpBirth.Text;
                    s.ClassID = GetClassID();
                  

                    db.Students.InsertOnSubmit(s);
                    db.SubmitChanges();
                    LoadGridControl();
                    MessageBox.Show("Cập nhập thành công", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();
                }
            }
        }
        #endregion
        #region Sự kiện của Combobox, sự kiện của GridControl
        private void gcStudent_Click(object sender, EventArgs e)
        {
            foreach (GridCell cell in gvStudent.GetSelectedCells())
            {

                txtStudentCode.Text = gvStudent.GetRowCellDisplayText(cell.RowHandle, "StudentCode");
                txtFullName.Text = gvStudent.GetRowCellDisplayText(cell.RowHandle, "FullName");
                cboClass.Text = gvStudent.GetRowCellDisplayText(cell.RowHandle, "ClassName");

                dtpBirth.Text = gvStudent.GetRowCellDisplayText(cell.RowHandle, "BirthDay");

                ShowHide(false);
            }
          
        }
        private void txtStudentCode_EditValueChanged(object sender, EventArgs e)
        {
            err.Dispose();
        }

        private void txtFullName_EditValueChanged(object sender, EventArgs e)
        {
            err.Dispose();
            btnInsert.Enabled = true;
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {
            err.Dispose();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Empty();
        }

        #endregion

       

        DataTable dt = new DataTable();
        /// <summary>
        /// Kiểm tra xem mã sinh viên đã được import chưa
        /// </summary>
        /// <param name="StudentCode"></param>
        /// <returns></returns>
        bool Test(string StudentCode)
        {
            Student c = db.Students.SingleOrDefault(s => s.StudentCode.Trim().ToLower() == StudentCode.Trim().ToLower());
            if (c != null)
                return true;
            else
                return false;

        }
      
        private void frmStudent_Load(object sender, EventArgs e)
        {
            cboClass.Focus();
            LoadComboClass();
           

        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            LoadGridControl();
        }

       

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban có chắc chắn muốn xóa học sinh này ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Student s = db.Students.SingleOrDefault(stuDent => stuDent.StudentCode == txtStudentCode.Text);
                if (s != null)
                {
                    var sessonspace = db.SessionSpaces.Where(c => c.StudentPractice.Student.StudentCode.Trim() == txtStudentCode.Text.Trim());
                    if (sessonspace.Count() > 0)
                    {
                        db.SessionSpaces.DeleteAllOnSubmit(sessonspace);
                        db.SubmitChanges();
                    }
                    var callroll = db.CallRools.Where(c => c.StudentPractice.Student.StudentCode.Trim() == txtStudentCode.Text.Trim());
                    if (callroll.Count() > 0)
                    {
                        db.CallRools.DeleteAllOnSubmit(callroll);
                        db.SubmitChanges();
                    }
                    var paractice = db.StudentPractices.Where(c => c.Student.StudentCode.Trim() == txtStudentCode.Text.Trim());
                    if (paractice.Count() > 0)
                    {
                        db.StudentPractices.DeleteAllOnSubmit(paractice);
                        db.SubmitChanges();
                    }
                    db.Students.DeleteOnSubmit(s);

                    db.SubmitChanges();
                    LoadGridControl();
                    Empty();
                    MessageBox.Show("Xóa thành công", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Học sinh này chưa tồn tại", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}