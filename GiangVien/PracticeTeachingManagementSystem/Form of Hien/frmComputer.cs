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
using Excel = Microsoft.Office.Interop.Excel;

namespace PracticeTeachingManagementSystem
{
    public partial class frmComputer : DevExpress.XtraEditors.XtraForm
    {
        public frmComputer()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        DataTable dt = new DataTable();
        public static string staComputerNumber = "", staRoomName = "";
        public static bool click;
        private void btnViewConfiguationCompute_Click(object sender, EventArgs e)
        {
            try
            {

                click = true;
                staComputerNumber = cptNumber;
                staRoomName = rroom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void frmComputer_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                LoadgcComputer();

                //Các thông tin mặc định
                btnView.Enabled = false;
                cboRoom.Properties.Items.Add("Tất cả");
                //load thông tin lên combobox mã phòng
                var l = from r in db.PracticeRooms select new { r.RoomName, r.RoomCode };

                foreach (var con in l)
                {
                    cboRoomName.Properties.Items.Add(con.RoomName);
                    cboRoom.Properties.Items.Add(con.RoomName);

                }



                Clear();
                if (cboRoomName.Text != "")
                    RoomID = db.PracticeRooms.Single(m => m.RoomName == cboRoomName.Text).RoomID;


                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                btnConfiguationCompute.Enabled = false;

                error.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }
        /// <summary>
        /// Load dữ liệu trong bảng Computer lên GridControl gcComputer 
        /// </summary>
        private void LoadgcComputer()
        {
            try
            {
                Clear();
                var list = from c in db.Computers select new { c.PracticeRoom.RoomName, c.ComputerCode, c.ComputerNumber, c.ComputerName };
                gcComputer.DataSource = list;
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
            txtComputerCode.Text = "";
            txtComputerNumber.Text = "";
            txtComputerName.Text = "";
            btnImportExcel.Enabled = true;

            btnConfiguationCompute.Enabled = false;
        }
        /// <summary>
        /// Kiểm tra mã máy tính (Không trùng với bất kì máy tính nào)
        /// </summary>
        /// <param name="code">Mã máy tính cần kiểm tra</param>
        ///  /// <param name="codeSkip">Mã máy tính bỏ qua kiểm tra</param>
        /// <returns>Trả về true nếu có trùng mã ngược lại trả về false</returns>
        bool CheckComputerCode(string code, string codeSkip)
        {

            error.Clear();
            bool kt = false;
            try
            {
                var lst = from c in db.Computers select new { c.ComputerCode };
                foreach (var i in lst)
                {
                    if (i.ComputerCode.Trim() == code.Trim() && i.ComputerCode.Trim() != codeSkip.Trim())
                    {
                        kt = true;
                        error.SetError(txtComputerCode, "Mã máy tính này đã tồn tại. Hãy chọn lại");
                        txtComputerCode.Focus();
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
        /// Kiểm tra trùng"Số máy" (Trong một phòng số máy không được trùng)
        /// </summary>
        /// <param name="ComputerNumber">Số máy cần kiểm tra</param>
        /// <param name="ComputerNumber">Số máy bỏ qua kiểm tra</param>
        /// /// <param name="RoomID">Mã phòng cần kiểm tra</param>
        /// <returns>Trả về true nếu có trùng số máy ngược lại trả về false</returns>
        bool CheckComputerNumber(string ComputerNumber, string computeNumberSkip, int RoomID)
        {

            error.Clear();
            bool kt = false;
            try
            {
                var lst = from c in db.Computers select new { c.ComputerNumber, c.RoomID };
                foreach (var i in lst)
                {
                    if (i.ComputerNumber.ToString() == ComputerNumber && i.ComputerNumber.ToString() != computeNumberSkip && i.RoomID == RoomID)
                    {
                        kt = true;
                        error.SetError(txtComputerNumber, "Số máy này đã tồn tại trong phòng. Hãy chọn lại");
                        txtComputerNumber.Focus();
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
        /// Kiểm tra trùng "Tên máy" (Trong một phòng tên máy không được trùng)
        /// </summary>
        /// <param name="ComputerNumber">Tên máy cần kiểm tra</param>
        /// /// <param name="ComputerNumber">Tên máy bỏ qua kiểm tra</param>
        /// /// <param name="RoomID">Mã phòng cần kiểm tra</param>
        /// <returns>Trả về true nếu có trùng tên máy ngược lại trả về false</returns>
        bool CheckComputerName(string ComputerName, string computerNameSkip, int RoomID)
        {

            error.Clear();
            bool kt = false;
            try
            {
                var lst = from c in db.Computers select new { c.ComputerName, c.RoomID };
                foreach (var i in lst)
                {
                    if (i.ComputerName.Trim() == ComputerName.Trim() && i.ComputerName.Trim() != computerNameSkip.Trim() && i.RoomID == RoomID)
                    {
                        kt = true;
                        error.SetError(txtComputerName, "Tên máy này đã tồn tại trong phòng. Hãy chọn lại");
                        txtComputerName.Focus();
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
                //db = new PTMSDataContext();
                if (CheckEmptyControl(cboRoomName, "Chưa chọn mã phòng") == false && CheckEmptyControl(txtComputerNumber, "Chưa nhập số máy") == false && CheckComputerNumber(txtComputerNumber.Text, "", RoomID) == false && CheckEmptyControl(txtComputerCode, "Chưa nhập mã máy") == false && CheckComputerCode(txtComputerCode.Text, "") == false && CheckEmptyControl(txtComputerName, "Chưa nhập tên máy") == false && CheckComputerName(txtComputerName.Text, "", RoomID) == false)
                {
                    Computer c = new Computer();
                    //lấy RoomID thông qua tên Room
                    c.RoomID = db.PracticeRooms.Single(m => m.RoomName == cboRoomName.Text).RoomID;

                    c.ComputerCode = txtComputerCode.Text;
                    c.ComputerNumber = (txtComputerNumber.Text);
                    c.ComputerName = txtComputerName.Text;
                    c.ComputerIP = "0.0.0.0";
                    c.Status = "Close";
                    //c.Status = cboStatus.Text;


                    //c.Description = mmoDescription.Text;

                    db.Computers.InsertOnSubmit(c);
                    db.SubmitChanges();
                    //load lại dữ liệu
                    LoadgcComputer();
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
                if (CheckEmptyControl(cboRoomName, "Chưa chọn mã phòng") == false && CheckEmptyControl(txtComputerCode, "Chưa nhập mã máy") == false && CheckEmptyControl(txtComputerNumber, "Chưa nhập số máy") == false && CheckEmptyControl(txtComputerName, "Chưa nhập tên máy") == false && CheckComputerCode(txtComputerCode.Text, cptCode) == false && CheckComputerNumber(txtComputerNumber.Text, cptNumber, RoomID) == false && CheckComputerName(txtComputerName.Text, cptName, RoomID) == false)
                {
                    Computer c = db.Computers.FirstOrDefault(a => a.ComputerCode == cptCode);

                    if (c != null)
                    {
                        c.RoomID = db.PracticeRooms.Single(m => m.RoomName == cboRoomName.Text).RoomID;
                        c.ComputerCode = txtComputerCode.Text;
                        c.ComputerNumber = (txtComputerNumber.Text);
                        c.ComputerName = txtComputerName.Text;
                        db.SubmitChanges();
                        Clickgv = false;

                        LoadgcComputer();
                        Clear();
                        btnInsert.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        MessageBox.Show("Đã sửa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clickgv = false;
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa TT máy tính này và các TT liên quan không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //xóa các dữ liệu ở bảng con
                    Computer cc = db.Computers.SingleOrDefault(d => d.ComputerCode == cptCode);

                    var lstE = db.ErrorofComputers.Where(x => x.ComputerID == cc.ComputerID);
                    db.ErrorofComputers.DeleteAllOnSubmit(lstE);

                    var lstC = db.ComputerEquipments.Where(x => x.ComputerID == cc.ComputerID);
                    db.ComputerEquipments.DeleteAllOnSubmit(lstC);

                    var lstS = db.GroupMaps.Where(x => x.ComputerID == cc.ComputerID);
                    db.GroupMaps.DeleteAllOnSubmit(lstS);

                    var lstR = db.RepairErrors.Where(x => x.ComputerID == cc.ComputerID);
                    db.RepairErrors.DeleteAllOnSubmit(lstR);

                    db.SubmitChanges();

                    //xóa dữ liệu ở bảng tra
                    Computer c = db.Computers.Single(a => a.ComputerCode == cptCode);
                    db.Computers.DeleteOnSubmit(c);
                    db.SubmitChanges();


                    LoadgcComputer();

                    Clear();
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    MessageBox.Show("Đã xóa thành công ! ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clickgv = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        string rroom, cptCode, cptNumber, cptName;
        bool Clickgv;

        string StringSkip = "";
        private void txtComputerCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem có trùng mã máy hay không? nếu trùng đưa ra thông báo
                if (txtComputerCode.Text != "")
                {
                    if (Clickgv == true)
                        StringSkip = cptCode;
                    else StringSkip = "";

                    if (CheckComputerCode(txtComputerCode.Text, StringSkip) == false)
                        error.Clear();
                }

                //ẩn hiện button Linh kiện
                if (txtComputerCode.Text != "")
                    btnConfiguationCompute.Enabled = true;
                else btnConfiguationCompute.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtComputerNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem có trùng số máy trong phòng đang xét hay không? nếu trùng đưa ra thông báo
                if (txtComputerNumber.Text != "")
                {
                    if (Clickgv == true)
                        StringSkip = cptNumber;
                    else StringSkip = "";

                    if (CheckComputerNumber(txtComputerNumber.Text, StringSkip, RoomID) == false)
                        error.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem có trùng tên máy trong phòng đang xét hay không? nếu trùng đưa ra thông báo
                if (txtComputerName.Text != "")
                {
                    if (Clickgv == true)
                        StringSkip = cptName;
                    else StringSkip = "";

                    if (CheckComputerName(txtComputerName.Text, StringSkip, RoomID) == false)
                        error.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }
        int RoomID;
        private void cboRoomName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                //lấy RoomID
                if (cboRoomName.Text != "")
                    RoomID = db.PracticeRooms.Single(m => m.RoomName == cboRoomName.Text).RoomID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtComputerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gcComputer_Click(object sender, EventArgs e)
        {
            try
            {
                Clickgv = true;
                //MessageBox.Show("Test");
                foreach (GridCell item in gvComputer.GetSelectedCells())
                {

                    cboRoomName.Text = rroom = gvComputer.GetRowCellDisplayText(item.RowHandle, "RoomName");

                    txtComputerCode.Text = cptCode = gvComputer.GetRowCellDisplayText(item.RowHandle, "ComputerCode");
                    txtComputerNumber.Text = cptNumber = gvComputer.GetRowCellDisplayText(item.RowHandle, "ComputerNumber");
                    txtComputerName.Text = cptName = gvComputer.GetRowCellDisplayText(item.RowHandle, "ComputerName");


                }
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDelete.Enabled = true;
                btnConfiguationCompute.Enabled = true;
                btnImportExcel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void txtComputerIP_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
        int GetRoomID()
        {
            PracticeRoom p = db.PracticeRooms.Single(pr => pr.RoomName == cboRoomName.Text);
            return p.RoomID;
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                #region Tạo bảng
                DataColumn cl;
                dt = new DataTable();
                cl = new DataColumn();
                //cl.DataType = Type.GetType("System.String");
                cl.ColumnName = "ComputerCode";
                dt.Columns.Add(cl);

                cl = new DataColumn();
                //cl.DataType = Type.GetType("System.String");
                cl.ColumnName = "ComputerNumber";
                dt.Columns.Add(cl);
                #endregion
                this.openFileDialog1.FileName = "* .xls";
                Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Excel.Workbook myWorkBook = ExcelObj.Workbooks.Open(
                        openFileDialog1.FileName, 0, true, 5,
                        "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false,
                        0, true, 0, 0);
                    Excel.Sheets sheets = myWorkBook.Worksheets;
                    object indx = null;
                    if (cboRoomName.Text == "402ACS1")
                        indx = 2;
                    if (cboRoomName.Text == "403CS1")
                        indx = 1;
                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(indx);
                    int index = 0;
                    object rowIndex = 3;
                    DataRow row;
                    //MessageBox.Show(((Excel.Range)worksheet.Cells[rowIndex, 1]).Value2.ToString());
                    while (((Excel.Range)worksheet.Cells[rowIndex, 1]).Value2 != null)
                    {
                        rowIndex = 3 + index;
                        row = dt.NewRow();
                        row["ComputerCode"] = Convert.ToString(((Excel.Range)worksheet.Cells[rowIndex, 1]).Value2);
                        row["ComputerNumber"] = Convert.ToString(((Excel.Range)worksheet.Cells[rowIndex, 2]).Value2);
                        index++;
                        dt.Rows.Add(row);
                        //MessageBox.Show(dt.Rows.Count.ToString());
                        //gcComputer.DataSource = dt;
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        Computer s = db.Computers.SingleOrDefault(c => c.ComputerCode == dr[0].ToString());
                        if (s == null)
                        {
                            s = new Computer();
                            s.RoomID = GetRoomID();
                            s.ComputerCode = dr[0].ToString();
                            s.ComputerNumber = dr[1].ToString();
                            s.ComputerName = "May" + dr[1].ToString();
                            s.ComputerIP = "0.0.0.0";
                            db.Computers.InsertOnSubmit(s);
                            db.SubmitChanges();
                        }
                        //else
                        //{
                        //    s.ComputerNumber = dr[1].ToString();
                        //    s.ComputerName = "May" + dr[1].ToString();
                        //    s.ComputerIP = "0.0.0.0";
                        //    db.SubmitChanges();
                        //}
                    }
                    gcComputer.DataSource = dt;
                    LoadgcComputer();
                    MessageBox.Show("Import thành công!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName);
            }
        }

        private void cboRoomName_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtComputerNumber_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtComputerCode_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtComputerName_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtComputerNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void btnUpdateAuto_Click(object sender, EventArgs e)
        {

            //cập nhật thêm các máy tính
            string thu = "",list="",listError="";
            int total = 0, totalerror=0;
            for (int i = 0; i < gvSelectedComputer.RowCount; i++)
            {
                message = "";
                CheckError(gvSelectedComputer.GetRowCellDisplayText(i, "ComputerCode"));

                string cpc = gvSelectedComputer.GetRowCellDisplayText(i, "ComputerCode");
                string nu = gvSelectedComputer.GetRowCellDisplayText(i, "ComputerNumber");
                string ro = gvSelectedComputer.GetRowCellDisplayText(i, "RoomName");
                if (message == "")
                {
                    //cập nhật máy tính đang xử lý
                    Computer c = new Computer();
                    c.RoomID = db.PracticeRooms.Single(m => m.RoomName == ro).RoomID;
                    c.ComputerCode = cpc;
                    c.ComputerNumber = nu;
                    c.ComputerName = cpc;
                    c.ComputerIP = "0.0.0.0";
                    c.Status = "Close";

                    db.Computers.InsertOnSubmit(c);
                    //db.SubmitChanges();

                    total++;
                    list += cpc + ", ";

                    //danh sách các linh kiện của máy tính đang xử lý
                    var listselect = from s in db.TemporaryImformations where s.ComputerCode == cpc select s;
                    foreach (var item in listselect)
                    {
                        //cập nhật thêm các linh kiện 
                        Equipment eq = new Equipment();
                        eq.EquipmentCode = item.EquipmentCode;
                        eq.EquipmentName = item.EquipmentName;
                        eq.Firm = item.Firm;
                        eq.Configuration = item.Configuration;
                        db.Equipments.InsertOnSubmit(eq);                      
                        db.SubmitChanges();
                        int maLK = eq.EquipmentID;

                        //cập nhật linh kiện cho máy tính đang xử lý
                        ComputerEquipment ce = new ComputerEquipment();
                        ce.ComputerID = db.Computers.SingleOrDefault(cp => cp.ComputerCode.ToString() == cpc && cp.PracticeRoom.RoomName == ro).ComputerID;
                        ce.EquipmentID = maLK;
                        ce.Total ="1";
                        db.ComputerEquipments.InsertOnSubmit(ce);
                        db.SubmitChanges();
                    }
                    //xóa linh kiện của máy trong bảng tạm TemprorayrImformation
                    var lstTI = from ti in db.TemporaryImformations where ti.ComputerCode == cpc select ti;
                    db.TemporaryImformations.DeleteAllOnSubmit(lstTI);
                    db.SubmitChanges();

                    //hiển thị thông báo đã cập nhật thành công
                    gvSelectedComputer.SetRowCellValue(i, "Massege","Cập nhật thành công");
                }
                else
                {
                    totalerror++;
                    listError += cpc + ", ";
                }
                
            }
            if(total>0)
                thu += "Đã cập nhât thành công " + total + " máy:" + list;
            if(totalerror>0)
            thu += "\n Chưa cập nhật thành công " + totalerror + " máy lỗi:" + listError;
            MessageBox.Show(thu,"Thông báo!");



            btnUpdateAuto.Enabled = false;


        }

        private void xemCấuHìnhMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmViewConfiguration();
            f.Show();
        }

        private void tabUpdateAuto_Click(object sender, EventArgs e)
        {

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoom.Text != "")
                btnView.Enabled = true;
            else btnView.Enabled = false;

            //Load những máy chưa được cập nhật lên gird
            CreatTable();
            gcComputerNotUpdate.DataSource = dt;
            btnUpdateAuto.Enabled = true;

            gcSelectedComputer.DataSource = new DataTable();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ////Load những máy chưa được cập nhật lên gird
            //CreatTable();
            //gcComputerNotUpdate.DataSource = dt;
            //btnUpdateAuto.Enabled = true;

            //gcSelectedComputer.DataSource = new DataTable();

        }



        //Tạo bảng dữ liệu chứa các máy tính chưa được cập nhật
        void CreatTable()
        {
            DataColumn cl;
            dt = new DataTable();

            cl = new DataColumn();
            cl.ColumnName = "STT";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "ComputerName";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "Total";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "Configuration";
            dt.Columns.Add(cl);

            int stt = 0;
            int total = 0;
            string name = "", Config = "";
            var lst = from a in db.TemporaryImformations orderby a.ComputerCode select new { a.ComputerCode, a.EquipmentName, a.Configuration };
            if (cboRoom.Text != "Tất cả")// Khi mã máy không đúng định dạng
                lst = (from a in db.TemporaryImformations where a.ComputerCode.Substring(4, 3).ToString() == cboRoom.Text orderby a.ComputerCode select new { a.ComputerCode, a.EquipmentName, a.Configuration });

            if (lst.Count() > 0)
            {
                name = lst.First().ComputerCode;
                foreach (var it in lst)
                {
                    if (name != it.ComputerCode)
                    {
                        ++stt;
                        dt.Rows.Add(stt.ToString(), name, total.ToString(), Config);
                        name = it.ComputerCode;

                        //thêm dữ liệu
                        Config = it.Configuration;
                        total = 1;
                    }
                    else
                    {
                        Config += "  " + it.Configuration;
                        ++total;
                    }

                }
                //hien thi ket qua cuoi cung
                dt.Rows.Add((stt + 1).ToString(), name, total.ToString(), Config);
            }


        }



        private void chọnMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tao bang
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("RoomName");
            dt.Columns.Add("ComputerCode");
            dt.Columns.Add("ComputerNumber");
            dt.Columns.Add("Massege");
            //chuyển máy tính được chọn sang một grid control

            string rName = "";
            int dem = 0;
            foreach (int index in gvComputerNotUpdate.GetSelectedRows())
            {

                rName = gvComputerNotUpdate.GetRowCellDisplayText(index, "ComputerName");


                CheckError(rName);
                //thêm thông tin bảng chọn
                dt.Rows.Add((++dem).ToString(), rName.Substring(4, 4), rName, rName.Substring(8),message);
                gcSelectedComputer.DataSource = dt;
            }
            //MessageBox.Show(rName);
        }
        string message="";
        void CheckError(string compuName)//Kiểm tra lỗi định đạng
        {
            message = "";
            //kiểm tra định dạng tên phòng
            bool kt = false;
            for (int i = 0; i < cboRoom.Properties.Items.Count; i++)
            {
                if (compuName.Substring(4, 4).ToString() == cboRoom.Properties.Items[i].ToString())
                { kt = true; break; }
            }
            if (kt == false)
                message += "Tên phòng không tồn tại";
            //kiểm tra mã máy
            if (compuName.Substring(0, 2) != "CS" || compuName[2] > '9' || compuName[2] < '0' || compuName[compuName.Length-1] > '9' || compuName[compuName.Length-1]  < '0')
                message += ", Mã máy không đúng định dạng";
            // kiểm tra số máy
            string so = compuName.Substring(8);
            bool ktso = true;
            for (int i = 0; i < so.Length; i++)
            {
                if (so[i] < '0' || so[i] > '9')
                    ktso = false;
            }
            if (ktso == false)
                message += ", Số máy là chữ";

            

        }
        //void ham(string ma) =mc01
        //{
        //    hien thi "ma"
        //        bien bool kt
                    
        //    foreach (phantu i in macha)
        //    {
        //        if(neu i =ma)
        //            hien thi " mathanhvien tuong ung cua i la con cua ma" va goi ham(mathanhvien)
        //    }
        //}

    }
}