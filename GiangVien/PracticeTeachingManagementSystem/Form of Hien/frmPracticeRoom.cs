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
    public partial class frmPracticeRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmPracticeRoom()
        {
            InitializeComponent();
        }

        PTMSDataContext db = new PTMSDataContext();
        private void frmPracticeRoom_Load(object sender, EventArgs e)
        {
            try
            {

                LoadgcRoom();

                var lstb = from b in db.Locations select b;
                foreach (var it in lstb)
                {
                    cboLotication.Properties.Items.Add(it.LocationName);
                }

                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Clear();

                error.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }
        /// <summary>
        /// Load dữ liệu trong bảng PracticeRoom lên GridControl gcRoom
        /// </summary>
        private void LoadgcRoom()
        {
            try
            {

            Clear();
            //var list = from c in db.PracticeRooms 
                   
            //           select new {c.RoomCode,c.RoomName, c.Total,c.Note };

                //var list=from c in db.Computers
                //         group c by c.RoomID into g
                //         select new {}

            var list = from c in db.PracticeRooms
                       select new 
                       { c.RoomCode, c.RoomName,c.Location.LocationName,
                         Total = (from x in c.Computers select x).Count(), 
                           c.Note };

            gcRoom.DataSource = list;
              }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
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
        /// Xóa trắng textbox, combobox hoặc đưa combobox về mặc định
        /// </summary>
        void Clear()
        {
            txtRoomCode.Text = "";
            txtRoomName.Text = "";
            txtTotal.Text = "0";
            mmoNote.Text = "";
            txtRoomCode.Enabled = true;
        }
        /// <summary>
        /// Kiểm tra mã phòng (Không trùng với bất kì phòng nào)
        /// </summary>
        /// <param name="code">Mã phòng cần kiểm tra</param>
        ///  /// <param name="codeSkip">Mã phòng bỏ qua kiểm tra</param>
        /// <returns>Trả về true nếu có trùng mã ngược lại trả về false</returns>
        bool CheckRoomCode(string roomCode, string roomCodeSkip)
        {
            

            error.Clear();
            bool kt = false;
            try
            {
            var lst = from c in db.PracticeRooms select new { c.RoomCode };
            foreach (var i in lst)
            {
                if (i.RoomCode.Trim() == roomCode.Trim() && i.RoomCode.Trim() != roomCodeSkip.Trim())
                {
                    kt = true;
                    error.SetError(txtRoomCode, "Mã phòng này đã tồn tại. Hãy chọn lại");
                    txtRoomCode.Focus();
                    break;
                }
            }
        }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
            return kt;
        }
        /// <summary>
        /// Kiểm tra tên phòng (Không trùng với bất kì phòng nào)
        /// </summary>
        /// <param name="code">Tên phòng cần kiểm tra</param>
        ///  /// <param name="codeSkip">Tên phòng bỏ qua kiểm tra</param>
        /// <returns>Trả về true nếu có trùng mã ngược lại trả về false</returns>
        bool CheckRoomName(string roomName, string roomNameSkip)
        {
            error.Clear();
            bool kt = false;
            try
            {
                var lst = from c in db.PracticeRooms select new { c.RoomName };
                foreach (var i in lst)
                {
                    if (i.RoomName.Trim() == roomName.Trim() && i.RoomName.Trim() != roomNameSkip.Trim())
                    {
                        kt = true;
                        error.SetError(txtRoomName, "Tên phòng này đã tồn tại. Hãy chọn lại");
                        txtRoomName.Focus();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
            return kt;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            error.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmptyControl(txtRoomCode, "Chưa nhập mã phòng") == false && CheckRoomCode(txtRoomCode.Text, "") == false && CheckEmptyControl(txtRoomName, "Chưa nhập tên phòng") == false && CheckRoomName(txtRoomName.Text, "") == false && CheckEmptyControl(txtTotal, "Chưa nhập số lượng máy tính") == false)
                {
                    PracticeRoom r = new PracticeRoom();

                    r.RoomCode = txtRoomCode.Text;
                    r.RoomName = txtRoomName.Text;
                    r.Total = Convert.ToInt32(txtTotal.Text);
                    r.Note = mmoNote.Text;

                    db.PracticeRooms.InsertOnSubmit(r);
                    db.SubmitChanges();
                    //load lại dữ liệu
                    LoadgcRoom();
                    Clear();
                    MessageBox.Show("Đã Thêm thông tin thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmptyControl(txtRoomCode, "Chưa nhập mã phòng") == false && CheckRoomCode(txtRoomCode.Text, rRoomcode) == false && CheckEmptyControl(txtRoomName, "Chưa nhập tên phòng") == false && CheckRoomName(txtRoomName.Text, rRoomName) == false && CheckEmptyControl(txtTotal, "Chưa nhập số lượng máy tính") == false)
                {
                    PracticeRoom r = db.PracticeRooms.SingleOrDefault(a => a.RoomCode == rRoomcode);

                    r.RoomCode = txtRoomCode.Text;
                    r.RoomName = txtRoomName.Text;
                    r.Total = Convert.ToInt32(txtTotal.Text);
                    r.Note = mmoNote.Text;

                    db.SubmitChanges();

                    LoadgcRoom();
                    Clear();
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    MessageBox.Show("Đã sửa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRoomCode.Enabled = true;
                    Clickgv = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("Bạn có thực sự muốn xóa TT phòng này và các thông tin liên quan ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        PracticeRoom pp = db.PracticeRooms.SingleOrDefault(s => s.RoomCode == rRoomcode);

            //        //xóa các thông tin liên quan
            //        var lstC = db.Computers.Where(s => s.RoomID == pp.RoomID);
            //        foreach (var item in lstC)
            //        {
            //            var lstS = db.GroupMaps.Where(f => f.ComputerID == item.ComputerID);

            //            foreach (var i in lstS)
            //            {
            //                var lstCC = db.CallRools.Where(f => f.StudentPracticeID == i.StudentPracticeID);
            //                db.CallRools.DeleteAllOnSubmit(lstCC);
            //            }
            //            db.GroupMaps.DeleteAllOnSubmit(lstS);
            //        }
            //        db.Computers.DeleteAllOnSubmit(lstC);


            //        //var lstE = db.Equipments.Where(s => s.RoomID == pp.RoomID);
            //        //db.Equipments.DeleteAllOnSubmit(lstE);


            //        var lstG = db.GroupSessions.Where(s => s.RoomID == pp.RoomID);
            //        foreach (var item in lstG)
            //        {
            //            var lstGS = db.GroupSessions.Where(f => f.GroupID == item.GroupID);
            //            db.GroupSessions.DeleteAllOnSubmit(lstGS);
            //        }
            //        db.GroupStudents.DeleteAllOnSubmit(lstG);


            //        db.SubmitChanges();
            //        //xóa thông tin của phòng 
            //        PracticeRoom c = db.PracticeRooms.SingleOrDefault(a => a.RoomCode == rRoomcode);
            //        db.PracticeRooms.DeleteOnSubmit(c);
            //        db.SubmitChanges();


            //        LoadgcRoom();
            //        Clear();
            //        btnInsert.Enabled = true;
            //        btnUpdate.Enabled = false;
            //        btnDelete.Enabled = false;
            //        MessageBox.Show("Đã xóa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtRoomCode.Enabled = true;
            //        Clickgv = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ProductName);
            //}
        }
        string rRoomcode,rRoomName;
        bool Clickgv;
        private void gcRoom_Click(object sender, EventArgs e)
        {
            try
            {
                Clickgv = true;
                foreach (GridCell item in gvRoom.GetSelectedCells())
                {
                    txtRoomCode.Text = rRoomcode = gvRoom.GetRowCellDisplayText(item.RowHandle, "RoomCode");
                    txtRoomName.Text = rRoomName = gvRoom.GetRowCellDisplayText(item.RowHandle, "RoomName");
                    txtTotal.Text = gvRoom.GetRowCellDisplayText(item.RowHandle, "Total");
                    mmoNote.Text = gvRoom.GetRowCellDisplayText(item.RowHandle, "Note");



                }
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtRoomCode.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        string StringSkip;
        private void txtRoomCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem có trùng mã phòng hay không? nếu trùng đưa ra thông báo
                if (txtRoomCode.Text != "")
                {
                    if (Clickgv == true)
                        StringSkip = rRoomcode;
                    else StringSkip = "";

                    if (CheckRoomCode(txtRoomCode.Text, StringSkip) == false)
                        error.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem có trùng tên phòng hay không? nếu trùng đưa ra thông báo
                if (txtRoomName.Text != "")
                {
                    if (Clickgv == true)
                        StringSkip = rRoomName;
                    else StringSkip = "";

                    if (CheckRoomName(txtRoomName.Text, StringSkip) == false)
                        error.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtRoomCode_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtRoomName_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtTotal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}