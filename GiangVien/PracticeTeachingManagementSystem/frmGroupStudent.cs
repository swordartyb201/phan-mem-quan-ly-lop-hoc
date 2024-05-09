using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
namespace PracticeTeachingManagementSystem
{
    public partial class frmGroupStudent : DevExpress.XtraEditors.XtraForm
    {
        public frmGroupStudent()
        {
            InitializeComponent();
        }
        Tool cls = new Tool();
        PTMSDataContext db = new PTMSDataContext();
        #region Load lên GridControl, Combobox,texbox
        /// <summary>
        /// Lấy dữ liệu lên group control;
        /// </summary>
        void LoadGridControl()
        {
            var gr = from c in db.GroupStudents
                     select new {  c.GroupName, c.Class.ClassName, c.Subject.SubjectName,c.Teacher.TeacherName,c.Year,c.HaflYear};
            if (cboClassName.Text != "")
            {
                gr=from c in gr
                        where c.ClassName==cboClassName.Text
                        select new {c.GroupName, c.ClassName, c.SubjectName,c.TeacherName, c.Year, c.HaflYear };
            }
            if (cboSubject.Text != "")
            {
                gr = from c in gr
                     where c.SubjectName==cboSubject.Text
                     select new {  c.GroupName,c.ClassName, c.SubjectName,c.TeacherName, c.Year, c.HaflYear };
            }
            gcGroupStudent.DataSource = gr;
        }
     
        /// <summary>
        /// Load năm học theo lop
        /// </summary>
        void LoadYear()
        {
            cboYear.Properties.Items.Clear();
            cboYear.Text = "";
            Class cl = db.Classes.SingleOrDefault(c=>c.ClassName==cboClassName.Text);
            if (cl != null)
            {
                int starYear =int.Parse(cl.StartYear.ToString());
                int endYear = int.Parse(cl.EndYear.ToString());
                while (starYear != endYear)
                {
                    cboYear.Properties.Items.Add(starYear.ToString() + " - " + (starYear + 1).ToString());
                    starYear = starYear + 1;
                }

            }
            cboYear.Text = (DateTime.Now.Year - 1).ToString() + " - " + DateTime.Now.Year.ToString();
        }
        
          
        /// <summary>
        /// Lấy tên giáo viên load dữ liệu lên combobox
        /// </summary>
        void LoadTeacher()
        {
            cboTeacherName.Properties.Columns.Clear();
            var teacher = from c in db.Teachers
                          select new { c.TeacherCode, c.TeacherName,c.TeacherID };
            cboTeacherName.Properties.DataSource = teacher;
            cboTeacherName.Properties.DisplayMember = "TeacherName";
            cboTeacherName.Properties.ValueMember = "TeacherID";
            cboTeacherName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeacherName", 70, "Tên giáo viên"));
            cboTeacherName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeacherCode", 60, "Mã giáo viên"));
        }
        /// <summary>
        /// Lấy tên môn học load lên combobox môn học
        /// </summary>
        void LoadSubjectName()
        {
            cboSubject.Text = "";
            cboSubject.Properties.Columns.Clear();
            var subject = from c in db.Subjects
                          select new { c.SubjectName, c.SubjectID, c.SubjectCode };
            cboSubject.Properties.DataSource = subject;
            cboSubject.Properties.DisplayMember = "SubjectName";
            cboSubject.Properties.ValueMember = "SubjectID";
            cboSubject.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", 60, "Mã môn"));
            cboSubject.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName",80, "Tên môn học"));
        }

        /// <summary>
        /// Lấy tên lớp từ bảng lớp load lên combobox
        /// </summary>
        void LoadClassName()
        {
            cboClassName.Properties.Columns.Clear(); cboClassName.Text = "";
            var cl = from c in db.Classes
                     select new { c.ClassName,c.ClassCode,c.ClassID };
            cboClassName.Properties.DataSource = cl;
            cboClassName.Properties.DisplayMember = "ClassName";
            cboClassName.Properties.ValueMember = "ClassID";
            cboClassName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassCode", 70, "Mã lop"));
            cboClassName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassName", 60, "Tên lop"));

        }
      
        #endregion
        #region lấy về các giá trị ,kiểm tra trùng mã
        /// <summary>&&
        /// Lấy mã SubjectClassID trong bảng SubjectClass có 2 trường classID và subjectID trùng với getID của cboClassName và cboSubjectName
        /// </summary>
        /// <returns></returns>
        private int GetSubjectID()
        {

            Subject sj = db.Subjects.SingleOrDefault(c=>c.SubjectID==int.Parse(cboSubject.EditValue.ToString()));
            if (sj != null)
            { return sj.SubjectID; }
            else return -1;
        }
       
        /// <summary>
        /// Kiểm tra trùng nhóm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        bool TestGroup()
        {

            GroupStudent gr = db.GroupStudents.SingleOrDefault(c => c.Class.ClassName == cboClassName.Text && c.Subject.SubjectName == cboSubject.Text && c.GroupName == cboGroupName.Text);
            if (gr != null)
            {
                return true;
            }
            else
            { return false; }
        }
       
        #endregion
        /// <summary>
        /// Làm mới các textbox,combobox,listbox về rỗng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Empty()
        {
            
            cboClassName.Text = "";
            cboGroupName.Text = "";
            cboSubject.Text = "";
            cboTeacherName.Text = "";
            mmeNote.Text = "";
            cboYear.Text = ((DateTime.Now.Year - 1) + " - " + (DateTime.Now.Year)).ToString();
            cboHaftYear.Text = "";
            cboSubject.ClosePopup();
            cboTeacherName.ClosePopup();
            cboClassName.ClosePopup();
        }
        /// <summary>
        /// Làm mới các textbox,combobox,listbox về rỗng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            cboSubject.Enabled = true;
            cboClassName.Enabled = true;
            cboGroupName.Enabled = true;
            Empty();
            LoadGridControl();
            LoadTeacher();
            LoadClassName();
         
           

        }
        /// <summary>
        /// Thêm một nhóm thực hành mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cls.StandardStringName(mmeNote.Text);
                if (!cls.CheckLookupEdit(cboClassName, "Bạn chưa chọn lớp", err) && !cls.CheckEmptyCbo(cboGroupName, "Bạn chưa chọn nhóm", err) && !cls.CheckLookupEdit(cboSubject, "Bạn chưa chọn môn", err) && !cls.CheckEmptyCbo(cboYear, "Bạn chưa chọn nhóm", err) && !cls.CheckEmptyCbo(cboHaftYear, "Bạn chưa chọn nhóm", err) &&!cls.CheckLookupEdit(cboTeacherName,"Giảng viên",err))
                {
                    if (TestGroup() == false)
                    {
                        GroupStudent tc = new GroupStudent();
                        tc.GroupName = cboGroupName.Text;
                        tc.SubjectID = GetSubjectID();
                        tc.TeacherID = int.Parse(cboTeacherName.EditValue.ToString());
                        tc.ClassID = int.Parse(cboClassName.EditValue.ToString());
                        tc.HaflYear = cboHaftYear.Text;
                        tc.Year = cboYear.Text;
                        db.GroupStudents.InsertOnSubmit(tc);
                        db.SubmitChanges();
                        LoadGridControl();
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        XtraMessageBox.Show("Đã Thêm thành công ! ", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { XtraMessageBox.Show("Đã tồn tại nhóm này ! ", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }
        /// <summary>
        /// Sửa một nhóm thực hành mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cls.StandardStringName(mmeNote.Text);
                if (!cls.CheckLookupEdit(cboClassName, "Bạn chưa chọn lớp", err) && !cls.CheckEmptyCbo(cboGroupName, "Bạn chưa chọn nhóm", err) && !cls.CheckLookupEdit(cboSubject, "Bạn chưa chọn môn", err) && !cls.CheckLookupEdit(cboTeacherName, "Giảng viên",err))
                {

                    GroupStudent tc = db.GroupStudents.SingleOrDefault(c => c.Class.ClassName == cboClassName.Text && c.Subject.SubjectName == cboSubject.Text && c.GroupName == cboGroupName.Text);
                    if (tc != null)
                    {
                        if (XtraMessageBox.Show("Bạn có thực sựu muốn Sua không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            tc.GroupName = cboGroupName.Text;
                           
                            tc.HaflYear = cboHaftYear.Text;
                            tc.Year = cboYear.Text;
                            tc.TeacherID = int.Parse(cboTeacherName.EditValue.ToString());
                            db.SubmitChanges();
                            LoadGridControl();
                            btnAdd.Enabled = false;
                            btnDelete.Enabled = false;
                            btnEdit.Enabled = false;
                            XtraMessageBox.Show("Đã sửa thành công ! ", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Không tồn tại nhóm! ", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        /// <summary>
        /// Xóa một nhóm thực hành mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GroupStudent gr = db.GroupStudents.SingleOrDefault(c => c.Class.ClassName == cboClassName.Text && c.Subject.SubjectName == cboSubject.Text && c.GroupName == cboGroupName.Text);
                if (gr != null)
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xoá không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.GroupStudents.DeleteOnSubmit(gr);
                        db.SubmitChanges();
                        LoadGridControl();
                       
                        btnAdd.Enabled = false;
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        XtraMessageBox.Show("Đã xóa thành công ! ", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { XtraMessageBox.Show("Không thể xóa nhóm bạn muốn xóa", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// Thoát khỏi form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       /// <summary>
       /// Load form
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmGroupStudent_Load(object sender, EventArgs e)
        {
           
            LoadGridControl();
            LoadTeacher();
            LoadSubjectName();
            LoadClassName();
            //cboSubjectName.Text = "---Chọn môn---";
           
            cboYear.Text = ((DateTime.Now.Year-1) + " - " + (DateTime.Now.Year)).ToString();
        }
        /// <summary>
        /// Nhập từ excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputExcel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Xuất excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutputExcel_Click(object sender, EventArgs e)
        {

        }

        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjectName();
            if (cboClassName.Text.Trim() != "")
            {
                err.Dispose();
            }
            LoadGridControl();
        }

       

        private void cboGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupName.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void cboSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubject.Text.Trim() != "")
            {
                err.Dispose();
            }
            LoadGridControl();
            
        }

        
        private void gcGroupStudent_Click(object sender, EventArgs e)
        {
            foreach (GridCell item in gvGroupStudent.GetSelectedCells())
            {
               
                cboClassName.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "ClassName");
                cboGroupName.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "GroupName");
                cboSubject.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "SubjectName");
                cboYear.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "Year");
                cboHaftYear.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "HaflYear");
                cboTeacherName.Text = gvGroupStudent.GetRowCellDisplayText(item.RowHandle, "TeacherName");
                cboGroupName.Enabled = false;
                cboClassName.Enabled = false;
                cboSubject.Enabled = false;
               
                cboClassName.ClosePopup();
                cboSubject.ClosePopup();
                cboTeacherName.ClosePopup();
               
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void cboClassName_EditValueChanged(object sender, EventArgs e)
        {
            if (cboClassName.Text.Trim() != "")
            {
                err.Dispose();
            }
            LoadYear();
            
            LoadGridControl();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void cboHaftYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.Text.Trim() != "")
            {
                err.Dispose();
            }
        }
        private void labelControl7_Click(object sender, EventArgs e)
        {
            cls.ShowFormSession();
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
            cls.ShowFormStudent();
        }

      
        private void frmGroupStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }



    }
}