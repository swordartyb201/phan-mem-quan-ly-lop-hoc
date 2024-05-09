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
using ex = Microsoft.Office.Interop.Excel;

namespace PracticeTeachingManagementSystem
{
    public partial class frmStudentPractic_ : DevExpress.XtraEditors.XtraForm
    {
        public frmStudentPractic_()
        {
            InitializeComponent();
        }
        int team;

        Tool cls = new Tool();
        PTMSDataContext db = new PTMSDataContext();
        #region Load lên GridControl, Combobox,texbox

        /// <summary>
        /// Lấy tên lớp từ bảng lớp load lên combobox
        /// </summary>
        void LoadClassName()
        {
            cboClassName.Properties.Columns.Clear(); cboClassName.Text = "";
            var cl = (from c in db.GroupSessions
                     select new { c.GroupStudent.Class.ClassName, c.GroupStudent.Class.ClassCode, c.GroupStudent.Class.ClassID }).Distinct();
            cboClassName.Properties.DataSource = cl;
            cboClassName.Properties.DisplayMember = "ClassName";
            cboClassName.Properties.ValueMember = "ClassID";
            cboClassName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassCode", 70, "Mã lop"));
            cboClassName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassName", 60, "Tên lop"));

        }
      
        /// <summary>
        /// Lấy tên sinh viên load dữ liệu lên combobox
        /// </summary>
        void LoadStudent()
        {
            cboStudent.Properties.Columns.Clear(); cboStudent.Text = "";
            var tc = (from c in db.Students
                      where c.Class.ClassName == cboClassName.Text
                      select new { c.StudentCode, c.FullName,c.StudentID }).Distinct();
            cboStudent.Properties.DataSource = tc;
            cboStudent.Properties.DisplayMember = "FullName";
            cboStudent.Properties.ValueMember = "StudentID";
            cboStudent.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StudentCode", 50, "Mã sinh viên"));
            cboStudent.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", 70, "Tên sinh viên"));
        }
        /// <summary>
        /// Kiểm tra xem sinh viên này đã tồn tại trong lớp đó chưa???
        /// </summary>
        /// <returns></returns>
        int TestSudentClass(string studentCode)
        {
            Student sd = db.Students.SingleOrDefault(c => c.StudentCode == studentCode && c.Class.ClassName==cboClassName.Text);
            if (sd != null) { return sd.StudentID; }
            else { return -1; }
        }
        /// <summary>
        /// Load môn lên combobox mon
        /// </summary>
        void LoadComboboxSubject()
        {
            cboSubject.Properties.Items.Clear();
            var group = (from c in db.GroupStudents
                         where c.Class.ClassName == cboClassName.Text
                         select new { c.Subject.SubjectName }).Distinct();
            foreach (var item in group)
            {
                cboSubject.Properties.Items.Add(item.SubjectName);
            }
        }

        /// <summary>
        /// Lấy dữ liệu lên group control sao cho tên lớp trùng với combobox lớp;
        /// </summary>
        void LoadGridControl()
        {
            var gr = from c in db.StudentPractices
                     select new { c.GroupStudent.GroupName, c.GroupStudent.Class.ClassName, c.GroupStudent.Subject.SubjectName, c.Student.StudentCode, c.Student.FullName,c.IsTeamLeader };
            if (cboClassName.Text != "")
            {
                gr = from c in gr
                     where c.ClassName == cboClassName.Text
                     select new {  c.GroupName, c.ClassName, c.SubjectName, c.StudentCode, c.FullName, c.IsTeamLeader };
            }
            if (cboSubject.Text != "")
            {
                gr = from c in gr
                     where c.SubjectName == cboSubject.Text
                     select new {  c.GroupName, c.ClassName, c.SubjectName, c.StudentCode, c.FullName, c.IsTeamLeader };
            }
            if (cboGroup.Text != "")
            {
                gr = from c in gr
                     where c.GroupName == cboGroup.Text
                     select new {  c.GroupName, c.ClassName, c.SubjectName, c.StudentCode, c.FullName, c.IsTeamLeader };
            }
            gcStudentPractice.DataSource = gr;
        }
        bool TestIsteamleader()
        {
            bool kt = false;
            var gr = from c in db.StudentPractices
                     select new { c.StudentPracticeID, c.IsTeamLeader };
            foreach (var item in gr)
            {
                if (item.IsTeamLeader == true) { team = item.StudentPracticeID; kt = true; break; }
            }
            return kt;
        }

        /// <summary>
        /// Load tên nhóm thực hành
        /// </summary>
        void LoadGroupName()
        {
            cboGroup.Properties.Items.Clear();
            var gr = from c in db.GroupStudents
                     where c.Class.ClassName == cboClassName.Text
                     where c.Subject.SubjectName == cboSubject.Text
                     select new { c.GroupName };
            foreach (var item in gr)
            {
                cboGroup.Properties.Items.Add(item.GroupName);
            }

        }
        #endregion
        #region lấy về các giá trị ,kiểm tra trùng mã
        /// <Kiểm tra trùng mã> 
        /// Kiểm tra trùng máy
        /// </summary>
        void TestComputer()
        {
            StudentPractice sc = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text);
            if (sc != null)
            {
                throw new Exception("Máy này đã có sinh viên ngồi");
            }
        }
        /// <summary>
        /// Kiểm tra sinh viên đã tồn tại trong nhóm chưa
        /// </summary>
        bool TestSutdent(string studentID)
        {
            StudentPractice sp = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.StudentID ==int.Parse(studentID));
            if (sp != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        string GetRoomName()
        {
            string rooName="";
            var gs = db.GroupSessions.Where(c => c.GroupStudentID == GetGroupID());

            foreach (var item in gs)
            {
                rooName = item.PracticeRoom.RoomName; break;
            }
            return rooName;
        }
        int GetGroupID()
        {
            GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.Class.ClassName == cboClassName.Text && c.Subject.SubjectName == cboSubject.Text && c.GroupName == cboGroup.Text);
            if (gs != null)
            {
                return gs.GroupStudentID;
            }
            else return -1;
        }
        
        #endregion
        /// <summary>
        /// Thêm một sinh viên mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cls.CheckLookupEdit(cboClassName, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false && cls.CheckLookupEdit(cboStudent, "Chưa chọn sinh viên", err) == false)
            {
                try
                {
                    if (TestSutdent(cboStudent.EditValue.ToString()) == false)
                    {
                        StudentPractice sp = new StudentPractice();
                        if (GetGroupID() != -1)
                        {
                            sp.GroupStudentID = GetGroupID();
                            sp.StudentID = int.Parse(cboStudent.EditValue.ToString());
                            if (ckeTemleader.Checked == true)
                            {
                                StudentPractice cl1 = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.IsTeamLeader == true);
                                if (cl1 != null)
                                {
                                    if (XtraMessageBox.Show("Thay đổi nhóm truong??", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        cl1.IsTeamLeader = false;
                                        sp.IsTeamLeader = ckeTemleader.Checked;
                                    }
                                }
                                else
                                { sp.IsTeamLeader = ckeTemleader.Checked; }

                            }
                            else { sp.IsTeamLeader = false; }
                            db.StudentPractices.InsertOnSubmit(sp);
                            db.SubmitChanges();

                            var group = from c in db.GroupSessions
                                        where c.GroupStudentID == GetGroupID()
                                        select new { c.GroupSessionID };
                            foreach (var item in group)
                            {
                                CallRool cr = new CallRool();
                                cr.StudentPracticeID = sp.StudentPracticeID;
                                cr.GroupSessionID = item.GroupSessionID;
                                db.CallRools.InsertOnSubmit(cr);
                                db.SubmitChanges();
                            }
                            LoadGridControl();
                            btnEdit.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Sinh viên đã tồn tại trong nhóm", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } 
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Sửa 1 bản ghi của sinh viên thực hành
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cls.CheckLookupEdit(cboClassName, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false && cls.CheckLookupEdit(cboStudent, "Chưa chọn sinh viên", err) == false)
            {
                StudentPractice cl = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.StudentID == int.Parse(cboStudent.EditValue.ToString()));
                if (cl != null)
                {
                    //    try
                    //    {

                    if (XtraMessageBox.Show("Bạn có thực sự muốn sửa thông của sinh viên này không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (ckeTemleader.Checked == true)
                        {

                            if (TestTeam() == true)
                            {
                                if (XtraMessageBox.Show("Thay đổi nhóm truong??", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    StudentPractice cl1 = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.IsTeamLeader == true);
                                    cl1.IsTeamLeader = false;
                                    cl.IsTeamLeader = ckeTemleader.Checked;
                                }
                            }
                            else
                            { cl.IsTeamLeader = ckeTemleader.Checked; }
                        }
                        else
                        {
                            if (cl.IsTeamLeader == true)
                            {
                                cl.IsTeamLeader = false;
                            }

                        }
                        db.SubmitChanges();
                        LoadGridControl();
                        XtraMessageBox.Show("Sửa thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ////}
                    ////catch (Exception ex)
                    ////{
                    ////    XtraMessageBox.Show(ex.Message, "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ////}
                }
                else
                {
                    XtraMessageBox.Show("Sinh viên này không tồn tại", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        /// <summary>
        /// Xóa 1 bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cls.CheckLookupEdit(cboClassName, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false && cls.CheckLookupEdit(cboStudent, "Chưa chọn sinh viên", err) == false)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn xoá không?", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        StudentPractice cl = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.StudentID == int.Parse(cboStudent.EditValue.ToString()));
                        if (cl != null)
                        {
                            db.StudentPractices.DeleteOnSubmit(cl);
                            db.SubmitChanges();
                            LoadGridControl();
                            btnEdit.Enabled = false;
                            btnAdd.Enabled = false;
                            btnDelete.Enabled = false;
                            btnDeleteAll.Enabled = false;
                            XtraMessageBox.Show("Xóa thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể xóa sinh viên bạn muốn xóa", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
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
        /// Làm mới các combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ckeTemleader.Checked = false;
            cboClassName.Text = "";
            btnDeleteAll.Enabled = true;
            cboStudent.Enabled = true;
            txtRoom.Text = "";
            cboClassName.Enabled = true;
            cboSubject.Enabled = true;

            cboGroup.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            LoadGridControl();
        }
        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentPractic__Load(object sender, EventArgs e)
        {
            LoadGridControl();
            LoadClassName();

        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubject.Text = "";
            LoadComboboxSubject();
            LoadStudent();
            var gr = from c in db.StudentPractices
                     where c.GroupStudent.Class.ClassName == cboClassName.Text
                     select new {  c.GroupStudent.GroupName, c.GroupStudent.Class.ClassName, c.GroupStudent.Subject.SubjectName, c.Student.StudentCode, c.Student.FullName };
            gcStudentPractice.DataSource = gr;
            if (cboClassName.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGroup.Text = "";
            LoadGroupName();
            if (cboSubject.Text.Trim() != "")
            {
                err.Dispose();
            }
            var gr = from c in db.StudentPractices
                     where c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text
                     select new {  c.GroupStudent.GroupName, c.GroupStudent.Class.ClassName, c.GroupStudent.Subject.SubjectName, c.Student.StudentCode, c.Student.FullName };
            gcStudentPractice.DataSource = gr;
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.Text = "";
            GetGroupID();
            txtRoom.Text = GetRoomName();
            if (cboGroup.Text.Trim() != "")
            {
                err.Dispose();
            }
            LoadGridControl();
        }



        string studentCode = ""; string computerNumber = "";
        private void gcStudentPractice_Click(object sender, EventArgs e)
        {
            studentCode = ""; computerNumber = "";
            foreach (GridCell cell in gvStudentPractice.GetSelectedCells())
            {

                cboStudent.Text = gvStudentPractice.GetRowCellDisplayText(cell.RowHandle, "FullName");
                cboClassName.Text = gvStudentPractice.GetRowCellDisplayText(cell.RowHandle, "ClassName");
                cboSubject.Text = gvStudentPractice.GetRowCellDisplayText(cell.RowHandle, "SubjectName");
                cboGroup.Text = gvStudentPractice.GetRowCellDisplayText(cell.RowHandle, "GroupName");
                cboClassName.Enabled = false;
                cboSubject.Enabled = false;
                cboStudent.Enabled = false;
                cboGroup.Enabled = false;
                btnEdit.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;

            }
        }
        /// <summary>
        /// Kiểm tra xem sinh viên này có phải nhóm truong không???
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool TestTeam()
        {
            StudentPractice cl = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.IsTeamLeader == true);
            {
                if (cl != null)
                {
                    return true;
                }
                else
                { return false; }
            }

        }
        private void cboStudent_EditValueChanged(object sender, EventArgs e)
        {
            return;
            // TODO : ERRROR CHECK
            StudentPractice cl = db.StudentPractices.SingleOrDefault(c => c.GroupStudent.Class.ClassName == cboClassName.Text && c.GroupStudent.Subject.SubjectName == cboSubject.Text && c.GroupStudent.GroupName == cboGroup.Text && c.StudentID ==int.Parse(cboStudent.EditValue.ToString()) && c.IsTeamLeader == true);
            {
                if (cl != null)
                {
                    ckeTemleader.Checked = true;
                }
                else { ckeTemleader.Checked = false; }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cls.CheckLookupEdit(cboClassName, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false)
            {
                var gs = db.StudentPractices.Where(c => c.GroupStudentID == GetGroupID());
                if (gs != null)
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xóa nhóm thực hành này không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.StudentPractices.DeleteAllOnSubmit(gs);
                        db.SubmitChanges();
                        btnAdd.Enabled = false;
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        XtraMessageBox.Show("Xóa thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridControl();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không tồn tại nhóm thực hành cần xóa", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        DataTable dt;
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            
            if (cls.CheckLookupEdit(cboClassName, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false)
            {
                btnImport.Enabled = true;
                #region Tạo datatable

                DataColumn cl;

                dt = new DataTable();

                cl = new DataColumn();
                cl.ColumnName = "GroupName";
                dt.Columns.Add(cl);

                cl = new DataColumn();
                cl.ColumnName = "ClassName";
                dt.Columns.Add(cl);

                cl = new DataColumn();
                cl.ColumnName = "SubjectName";
                dt.Columns.Add(cl);

                cl = new DataColumn();
                cl.ColumnName = "StudentCode";
                dt.Columns.Add(cl);

                cl = new DataColumn();
                cl.ColumnName = "FullName";
                dt.Columns.Add(cl);
                #endregion
                #region lấy dữ liệu từ excel vào Gridview

                OpenFileDialog openFi = new OpenFileDialog();
                openFi.Filter = "Kiểu file: (*.xls)|*.xls";
                ex.Application excelObj = new Microsoft.Office.Interop.Excel.Application();
                if (openFi.ShowDialog() == DialogResult.OK)
                {
                    this.UseWaitCursor = true;
                    ex.Workbook myWorkBook = excelObj.Workbooks.Open(openFi.FileName, 0, true, 5, "", "", true, ex.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0);
                    ex.Sheets sheets = myWorkBook.Worksheets;
                    ex.Worksheet worksheet = (ex.Worksheet)sheets.get_Item(1);
                    object rowIndex = 7;
                    int index = 0;
                    int count = 7;

                    string[] arr = new string[5];

                    while (((ex.Range)worksheet.Cells[rowIndex,2]).Value2 != null)
                    {
                        if (Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 1]).Value2) != null && ((Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2) != null)))
                        {
                            arr[0] = cboGroup.Text;
                            arr[1] = cboClassName.Text;
                            arr[2] = cboSubject.Text;
                            arr[3] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 2]).Value2);
                            arr[4] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2);
                            dt.Rows.Add(arr);
                            index++;


                        }
                        rowIndex = ++count;
                        System.Threading.Thread.Sleep(5);
                        Application.DoEvents();
                    }

                }
                gcStudentPractice.DataSource = dt;
                #endregion

                this.UseWaitCursor = false;
            }
            
        }
        /// <summary>
        /// Nhập sinh viên thực hành từ excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    if (TestSudentClass(dt.Rows[i][3].ToString()) == -1)
                    {
                        
                        Student sd = new Student();
                        sd.StudentCode = dt.Rows[i][3].ToString();
                        sd.FullName = dt.Rows[i][4].ToString();
                        sd.ClassID = int.Parse(cboClassName.EditValue.ToString());
                        db.Students.InsertOnSubmit(sd);
                        db.SubmitChanges();

                        if (TestSutdent(TestSudentClass(dt.Rows[i][3].ToString()).ToString()) == false)
                        {
                            StudentPractice sp = new StudentPractice();
                            sp.StudentID = TestSudentClass(dt.Rows[i][3].ToString());
                            sp.GroupStudentID = GetGroupID();
                            db.StudentPractices.InsertOnSubmit(sp);
                            db.SubmitChanges();
                            LoadStudent();

                            var group = from c in db.GroupSessions
                                        where c.GroupStudentID == GetGroupID()
                                        select new { c.GroupSessionID };
                            foreach (var item in group)
                            {
                                CallRool cr = new CallRool();
                                cr.StudentPracticeID = sp.StudentPracticeID;
                                cr.GroupSessionID = item.GroupSessionID;
                                db.CallRools.InsertOnSubmit(cr);
                                db.SubmitChanges();
                            }
                        }
                    }
                    else
                    {
                        if (TestSutdent(TestSudentClass(dt.Rows[i][3].ToString()).ToString()) == false)
                        {
                            StudentPractice sp = new StudentPractice();
                            sp.StudentID = TestSudentClass(dt.Rows[i][3].ToString());
                            sp.GroupStudentID = GetGroupID();
                            db.StudentPractices.InsertOnSubmit(sp);
                            db.SubmitChanges();
                            LoadStudent();

                            var group = from c in db.GroupSessions
                                        where c.GroupStudentID == GetGroupID()
                                        select new { c.GroupSessionID };
                            foreach (var item in group)
                            {
                                CallRool cr = new CallRool();
                                cr.StudentPracticeID = sp.StudentPracticeID;
                                cr.GroupSessionID = item.GroupSessionID;
                                db.CallRools.InsertOnSubmit(cr);
                                db.SubmitChanges();
                            }
                        }
                    }
                }
                catch
                { }
               
            }
            XtraMessageBox.Show("Import thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboClassName_EditValueChanged(object sender, EventArgs e)
        {
            LoadStudent();
            LoadComboboxSubject();
            if (cboClassName.Text == "")
            {
                cboSubject.Text = "";
                cboStudent.Text = "";
            }
        }
    }
}