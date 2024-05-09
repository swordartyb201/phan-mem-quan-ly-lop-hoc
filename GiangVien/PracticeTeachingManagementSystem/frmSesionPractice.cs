using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace PracticeTeachingManagementSystem
{
    public partial class frmSesionPractice : DevExpress.XtraEditors.XtraForm
    {
        public frmSesionPractice()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        Tool cls = new Tool();
        #region Load lên GridControl, Combobox,texbox, Lấy về các giá trị
        /// <summary>
        /// Load tên lopứ lên combobox lop
        /// </summary>
        void LoadComboboxClass()
        {

            cboClass.Properties.Items.Clear();
            var group = (from c in db.GroupStudents
                         select new { c.Class.ClassName }).Distinct();
            foreach (var item in group)
            {
                cboClass.Properties.Items.Add(item.ClassName);
            }
        }
        /// <summary>
        /// Load lên mã phòng
        /// </summary>
        void LoadRoom()
        {
            cboRoom.Properties.Items.Clear();
            var room = from c in db.PracticeRooms
                       select new { c.RoomName };
            foreach (var item in room)
            {
                cboRoom.Properties.Items.Add(item.RoomName);
            }

        }
      
        
        /// <summary>
        /// Load môn lên combobox mon
        /// </summary>
        void LoadComboboxSubject()
        {

            cboSubject.Properties.Items.Clear(); cboSubject.Text = "";
            var group = (from c in db.GroupStudents
                         where c.Class.ClassName == cboClass.Text
                         select new { c.Subject.SubjectName }).Distinct();
            foreach (var item in group)
            {
                cboSubject.Properties.Items.Add(item.SubjectName);
            }
        }
        /// <summary>
        /// Load lên gridview
        /// </summary>
        void LoadGrid()
        {
            var gr = from c in db.GroupSessions
                     select new { c.GroupStudent.GroupName, c.GroupStudent.Class.ClassName, c.GroupStudent.Subject.SubjectName,c.PracticeRoom.RoomName,c.Week,c.StartSession,c.TotalSession,c.DayOfWeek };
            if (cboClass.Text != "")
            {
                gr = from c in gr
                     where c.ClassName == cboClass.Text
                     select new { c.GroupName, c.ClassName, c.SubjectName,c.RoomName, c.Week, c.StartSession, c.TotalSession, c.DayOfWeek };

            }
            if (cboSubject.Text != "")
            {
                gr = from c in gr
                     where c.SubjectName == cboSubject.Text
                     select new { c.GroupName, c.ClassName, c.SubjectName,c.RoomName, c.Week, c.StartSession, c.TotalSession, c.DayOfWeek};

            }
            if (cboGroup.Text != "")
            {
                gr = from c in gr
                     where c.GroupName == cboGroup.Text
                     select new { c.GroupName, c.ClassName, c.SubjectName,c.RoomName, c.Week, c.StartSession, c.TotalSession, c.DayOfWeek};

            }
            gcSession.DataSource = gr;
        }
     
        /// <summary>
        /// Load tên nhóm thực hành vào combobox với tên lớp và tên môn trùng với combobox
        /// </summary>
        void LoadGroupName()
        {
            cboGroup.Properties.Items.Clear(); cboGroup.Text = "";
            var gr = from c in db.GroupStudents
                     where c.Class.ClassName == cboClass.Text && c.Subject.SubjectName == cboSubject.Text
                     select new { c.GroupName };
            foreach (var item in gr)
            {
                cboGroup.Properties.Items.Add(item.GroupName);
            }

        }
        string year = "";
        /// <summary>
        /// Lấy về mã nhóm,tên phòng
        /// </summary>
        /// <returns></returns>
        int GetGroupID()
        {
            GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.Class.ClassName == cboClass.Text && c.Subject.SubjectName == cboSubject.Text && c.GroupName == cboGroup.Text);
            if (gs != null)
            {
                year = gs.Year;
                return gs.GroupStudentID;

            }
            else
            { return -1; }
        }
        /// <summary>
        /// Kiểm tra trùng ca thực hành
        /// </summary>
        /// <returns></returns>
        bool TestCode()
        {
            bool kt = false;
            GroupSession gs = db.GroupSessions.SingleOrDefault(c => c.GroupStudentID == GetGroupID() && c.DayOfWeek == cboDayOfWeek.Text && c.Week == int.Parse(txtStartWeek.Text) && c.StartSession == int.Parse(cboStartSession.Text));
            if (gs != null)
            {
                kt = true;
            }
            GroupSession ss = db.GroupSessions.SingleOrDefault(c => c.GroupStudentID != GetGroupID() && c.DayOfWeek == cboDayOfWeek.Text && c.Week == int.Parse(txtStartWeek.Text) && c.StartSession == int.Parse(cboStartSession.Text) && c.PracticeRoom.RoomName == cboRoom.Text);
            if (ss != null) { kt = true; }
            return kt;
        }
        ///// <summary>
        ///// Kiểm tra tuần bắt đầu có trùng hok
        ///// </summary>
        ///// <returns></returns>
        //bool TestStartWeek()
        //{
        //    bool kt = false;
        //    var cl=from c in db.GroupSessions
        //           where c.GroupID==GetGroupID()
        //          select new {c.Week};
        //    if (cl != null)
        //    {
        //        if (txtStartWeek.Text == cl.FirstOrDefault().Week.ToString())
        //        { kt = true; }
        //    }
        //    else { kt = true; }
        //    return kt;
        //}
        /// <summary>
        /// Kiểm tra xem ca đó có lớp nào học không
        /// </summary>
        /// <returns></returns>
        bool TestSesionCode()
        {
            bool kt = false;
            var cl = from c in db.GroupSessions
                     where c.Week != int.Parse(week) || c.DayOfWeek !=DayOfWeek || c.StartSession != int.Parse(StartSession) || c.PracticeRoom.RoomName != RoomName
                     select c;
            foreach (var item in cl)
            {
                if (txtStartWeek.Text == item.Week.ToString() && cboDayOfWeek.Text == item.DayOfWeek.ToString() && cboStartSession.Text == item.StartSession.ToString() && item.GroupStudentID==GetGroupID())
                { kt = true; break; }
                if (txtStartWeek.Text == item.Week.ToString() && cboDayOfWeek.Text == item.DayOfWeek.ToString() && cboStartSession.Text == item.StartSession.ToString()&& cboRoom.Text==item.PracticeRoom.RoomName )
                {
                    kt = true; break;
                }
            }
            
            return kt;
        }
        /// <summary>
        /// Chuyển đổi tuần và thứ sang năm;
        /// </summary>
        /// <param name="songay"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
       int[] getmonth(int songay, int nam)
        {
            int[] mangngaythang = new int[2];
            if (songay < 32)
            {
                mangngaythang[0] = 1;

                mangngaythang[1] = songay;
                return mangngaythang;
            }
            else
            {

                if (nam % 4 == 0)
                {
                    for (int i = 2; i <= 12; i++)
                    {
                        if (i == 2)
                        {
                            songay = songay - 31;

                            if (songay < 30)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            songay = songay - 29;

                            if (songay < 32)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 5 || i == 7 || i == 12 || i == 8 || i == 10)
                        {
                            songay = songay - 30;

                            if (songay < 32)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 4 || i == 6 || i == 9 || i == 11)
                        {
                            songay = songay - 31;

                            if (songay < 31)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                    }
                    return mangngaythang;
                }
                else
                {
                    for (int i = 2; i <= 12; i++)
                    {
                        if (i == 2)
                        {
                            songay = songay - 31;

                            if (songay < 30)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            songay = songay - 28;

                            if (songay < 32)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 5 || i == 7 || i == 12||i==10||i==8)
                        {
                            if (i == 8)
                                songay = songay - 31;
                            else
                                songay = songay - 30;
                            if (songay < 32)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                        if (i == 4 || i == 6   || i == 9 || i == 11)
                        {
                            songay = songay - 31;

                            if (songay < 31)
                            {
                                mangngaythang[0] = i;

                                mangngaythang[1] = songay;
                                break;
                            }
                        }
                    }

                    return mangngaythang;
                }
            }
        }
        /// <summary>
        /// Lấy mã phòng
        /// </summary>
        int GetRoomID()
        {
            PracticeRoom pr = db.PracticeRooms.SingleOrDefault(c => c.RoomName.Trim().ToString() == cboRoom.Text.Trim().ToString());
            if (pr != null) 
            { return pr.RoomID;
            }
            else { return -1; }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cls.CheckEmptyCbo(cboClass, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false && cls.CheckEmptyCbo(cboRoom, "Phong", err) == false && cls.CheckEmptyTxt1(txtStartWeek, "Tuần bắt đầu", err) == false && cls.CheckEmptyTxt1(txtTotalWeek, "Số tuần học", err) == false && cls.CheckEmptyCbo(cboDayOfWeek, "Thứ", err) == false && cls.CheckEmptyCbo(cboStartSession, "Tiết bắt đầu", err) == false && cls.CheckEmptyTxt1(txtTotalSession, "Chưa chọn tiết", err) == false)
            {
                //Download source code mien phi tai Sharecode.vn
                if (TestCode() == false)
                {
                    //if (TestStartWeek() ==true)
                    //{
                        int Week = int.Parse(txtStartWeek.Text);
                        for (int i = 0; i < int.Parse(txtTotalWeek.Text); i++)
                        {
                            GroupSession gs = new GroupSession();
                            gs.GroupStudentID = GetGroupID();
                            gs.StartSession = int.Parse(cboStartSession.Text);
                            gs.TotalSession = int.Parse(txtTotalSession.Text);
                            gs.Week = Week;
                            gs.RoomID = GetRoomID();
                            gs.DayOfWeek = cboDayOfWeek.Text;


                            try
                            {
                                ConfigHaflYear cf = db.ConfigHaflYears.SingleOrDefault(c => c.Year == year);
                                if (cf != null)
                                {

                                    int namcauhinh = cf.StartDate.Year ;
                                    int ngaytrongnamcauhinh = cf.StartDate.DayOfYear;
                                    int ngaydentuanchon = 0;

                                    ngaydentuanchon = ((Week - 1) * 7) + (int.Parse(cboDayOfWeek.Text)) - 2;

                                    int ngayhientaitrongnam = 0;
                                    if (namcauhinh % 4 == 0)
                                    {
                                        //cùng nam
                                        if (366 - ngaydentuanchon - ngaytrongnamcauhinh > 0)
                                        {
                                            ngayhientaitrongnam = ngaydentuanchon + ngaytrongnamcauhinh;
                                        }
                                        else
                                        {
                                            //khác nam
                                            ngayhientaitrongnam = ngaydentuanchon - (365 - ngaytrongnamcauhinh);
                                            namcauhinh = namcauhinh + 1;
                                        }
                                    }
                                    else
                                    {
                                        //cùng nam
                                        if (365 - ngaydentuanchon - ngaytrongnamcauhinh > 0)
                                        {
                                            ngayhientaitrongnam = ngaydentuanchon + ngaytrongnamcauhinh;
                                        }
                                        else
                                        {
                                            //khác nam
                                            namcauhinh = namcauhinh + 1;
                                            if (namcauhinh % 4 == 0)
                                                ngayhientaitrongnam = ngaydentuanchon - (366 - ngaytrongnamcauhinh);
                                            else
                                                ngayhientaitrongnam = ngaydentuanchon - (365 - ngaytrongnamcauhinh);
                                        }
                                    }
                                    int[] ngaythang = getmonth(ngayhientaitrongnam, namcauhinh);
                                    DateTime t = new DateTime(namcauhinh, ngaythang[0], ngaythang[1]);
                                    gs.Date = t;
                                    db.SubmitChanges();
                                }
                            }
                            catch
                            { }
                            db.GroupSessions.InsertOnSubmit(gs);
                            db.SubmitChanges();
                            Week += 1;
                        }
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show("Một nhóm không thể có 2 tuần bắt đầu", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    LoadGrid();
                    //btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    XtraMessageBox.Show("Trùng mã ca thực hành", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmSesionPractice_Load(object sender, EventArgs e)
        {
            LoadComboboxClass();
            LoadGrid();
            LoadRoom();
            txtTotalSession.Text = "3";
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGroupName();
            LoadGrid();
            if (cboSubject.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
            LoadComboboxSubject();
            if (cboClass.Text.Trim() != "")
            {
                err.Dispose();
            }
        }
        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGroupID();
            LoadGrid();
            if (cboGroup.Text.Trim() != "")
            {
                err.Dispose();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cls.CheckEmptyCbo(cboClass, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false && cls.CheckEmptyCbo(cboRoom, "Phong", err) == false && cls.CheckEmptyTxt1(txtStartWeek, "Tuần bắt đầu", err) == false && cls.CheckEmptyCbo(cboDayOfWeek, "Thứ", err) == false && cls.CheckEmptyCbo(cboStartSession, "Tiết bắt đầu", err) == false && cls.CheckEmptyTxt1(txtTotalSession, "Chưa chọn tiết", err) == false )
            {
                GroupSession gs = db.GroupSessions.SingleOrDefault(c => c.GroupStudentID == GetGroupID() && c.Week == int.Parse(week) && c.StartSession == int.Parse(StartSession) && c.DayOfWeek == DayOfWeek);
                if (gs != null)
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xóa ca thực hành này không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.GroupSessions.DeleteOnSubmit(gs);
                        db.SubmitChanges();
                        LoadGrid();
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        XtraMessageBox.Show("Xóa thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không tồn tại ca thực hành cần xóa", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        string DayOfWeek = ""; string week = ""; string StartSession = ""; string RoomName = "";
        private void gcSession_Click(object sender, EventArgs e)
        {
            foreach (GridCell item in gvSesson.GetSelectedCells())
            {
                cboClass.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "ClassName");
                cboSubject.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "SubjectName");
                cboGroup.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "GroupName");
                cboStartSession.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "StartSession");
                txtTotalSession.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "TotalSession");
                txtStartWeek.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "Week");
                cboRoom.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "RoomName");
                cboDayOfWeek.Text = gvSesson.GetRowCellDisplayText(item.RowHandle, "DayOfWeek");
                RoomName = cboRoom.Text;
                DayOfWeek = cboDayOfWeek.Text;
                week = txtStartWeek.Text;
                StartSession = cboStartSession.Text;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnExit.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnEdit.Enabled = true;
                cboClass.Enabled = false;
                cboSubject.Enabled = false;
                cboGroup.Enabled = false;

                txtTotalWeek.Enabled = false;
                txtStartWeek.Enabled = false;
                LoadGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboClass.Text = "";
            cboSubject.Text = "";
            cboGroup.Text = "";
            cboStartSession.Text = "";
            txtStartWeek.Text = "";
            txtTotalSession.Text = "";
            txtTotalWeek.Text = "";
            cboDayOfWeek.Text = "";

            cboClass.Enabled = true;
            cboSubject.Enabled = true;
            txtStartWeek.Enabled = true;
            btnEdit.Enabled = false;
            txtTotalWeek.Enabled = true;
            cboGroup.Enabled =true;
            cboStartSession.Enabled = true;
            cboClass.Focus();
            LoadGrid();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStartSession.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void mmeNote_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoom.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void txtStartWeek_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStartWeek.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void txtTotalWeek_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTotalWeek.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void cboDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDayOfWeek.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

        private void txtTotalSession_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTotalSession.Text.Trim() != "")
            {
                err.Dispose();
            }
        }

      
        /// <summary>
        /// Xóa tất cả ca của nhóm sinh viên thực hành
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (cls.CheckEmptyCbo(cboClass, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false)
            {
                var gs = db.GroupSessions.Where(c => c.GroupStudentID == GetGroupID());
                if (gs != null)
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xóa ca thực hành này không?", "Quản lý phòng máy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.GroupSessions.DeleteAllOnSubmit(gs);
                        db.SubmitChanges();
                        LoadGrid();
                        btnAdd.Enabled = false;
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        XtraMessageBox.Show("Xóa thành công", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không tồn tại ca thực hành cần xóa", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (StartSession != "" && DayOfWeek != "" && GetGroupID() != -1 && week != "")
            {
                if (cls.CheckEmptyCbo(cboClass, "Chưa chọn lớp", err) == false && cls.CheckEmptyCbo(cboSubject, "Chưa chọn môn", err) == false && cls.CheckEmptyCbo(cboGroup, "Chưa chọn nhóm", err) == false)
                {
                    if (TestSesionCode() == false)
                    {
                        GroupSession gs = db.GroupSessions.SingleOrDefault(c => c.GroupStudentID == GetGroupID() && c.Week == int.Parse(week) && c.StartSession == int.Parse(StartSession) && c.DayOfWeek == DayOfWeek);
                        if (gs != null)
                        {
                            gs.GroupStudentID = GetGroupID();
                            gs.StartSession = int.Parse(cboStartSession.Text);
                            gs.TotalSession = int.Parse(txtTotalSession.Text);
                            gs.RoomID = GetRoomID();
                            gs.DayOfWeek = cboDayOfWeek.Text;
                            DayOfWeek = cboDayOfWeek.Text;
                            StartSession = cboStartSession.Text;
                            db.SubmitChanges();
                            XtraMessageBox.Show("Sửa thành công","Quản lý phòng máy",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Không tồn tại ca cần sửa", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Ca này đã được thực hành","Quản lý phòng máy");
                    }
                    LoadGrid();
                }
            }
        }
        private void labelControl10_Click(object sender, EventArgs e)
        {
            cls.ShowFormStudent();
        }
    }
}