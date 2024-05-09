using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
//using DevExpress.XtraEditors;
//using DevExpress.XtraGrid.Views.Base;

namespace PracticeTeachingManagementSystem
{
    public partial class frmMessagebox : DevExpress.XtraEditors.XtraForm
    {
        public frmMessagebox()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        private void frmMessagebox_Load(object sender, EventArgs e)
        {
            var lst = (from t in db.TemporaryImformations select new { t.ComputerCode }).Distinct();
            foreach (var i in lst)
            {
                cboComputerCode.Properties.Items.Add(i.ComputerCode);
            }
            //Download source code mien phi tai Sharecode.vn
            //load lên cbo tên phòng
            cboRoomName.Properties.Items.Add("Tất cả");
            cboRoom.Properties.Items.Add("Tất cả");
            var lstr = from r in db.PracticeRooms select new { r.RoomName };
            foreach (var item in lstr)
            {
                cboRoomName.Properties.Items.Add(item.RoomName);
                cboRoom.Properties.Items.Add(item.RoomName);
            }

            cboComputerNumber.Enabled = false;
            cboRoomName.Text = "Tất cả";
            cboComputerNumber.Text = "Tất cả";
            cboEquipmentName.Text = "Tất cả";

            //hiển thị các máy tính mới và các máy tính có linh kiện bị thay thế
            MessageComputer(true, true,cboRoom.Text);

            chkChangeEquipment.Checked = true;
            chkNewComputer.Checked = true;
            cboRoom.Text = "Tất cả";

        }

        //hiển thị thông báo với 2 tham số
        void MessageComputer(bool newComputer, bool changeEquipment, string roomName)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("RoomName");
            dt.Columns.Add("ComputerCode");
            dt.Columns.Add("ComputerNumber");
            dt.Columns.Add("Time");
            dt.Columns.Add("Message");

            int STT=0;
            //thêm vào ds máy tính mới
            if (newComputer)
            {
                var lstc = (from c in db.TemporaryImformations select new { c.ComputerCode}).Distinct();
                if (roomName != "Tất cả" && roomName != "")
                {
                    lstc = from c in lstc where c.ComputerCode.Substring(0, cboRoom.Text.Length+4) == "CS01"+roomName select c;
                }
                foreach (var i in lstc)
                {
                    //lấy số phòng và number
                    string room, number;
                    if (i.ComputerCode[7] < '0' || i.ComputerCode[7] > '9')
                    {
                        room = i.ComputerCode.Substring(4, 4);
                        number = i.ComputerCode.Substring(8);
                    }
                    else
                    {
                        room = i.ComputerCode.Substring(4, 3);
                        number = i.ComputerCode.Substring(7);
                    }

                    //thêm
                    dt.Rows.Add((++STT).ToString(), room, i.ComputerCode, number, "", "Máy tính mới");
                }
            }

            //thêm vào ds máy tính có thiết bị bị thay thế
            if (changeEquipment)
            {
                var tmp = (from e in db.Notices select new { e.ComputerCode}).Distinct();
                if (roomName != "Tất cả" && roomName != "")
                {
                    tmp = from e in tmp where e.ComputerCode.Substring(0, e.ComputerCode.IndexOf('#')) == roomName select e;
                }

                var lste = from e in db.Notices select e;
                if (roomName != "Tất cả" && roomName != "")
                {
                    lste = from e in lste where e.ComputerCode.Substring(0, e.ComputerCode.IndexOf('#')) == roomName select e;
                }

                foreach (var i in tmp)
                {
                    //các loai thay đổi
                    string change = "";
                    foreach (var h in lste)
                    {
                        if (h.ComputerCode==i.ComputerCode)
                        {
                            change += h.Message+", ";
                        }
                    }
                    //thêm
                    dt.Rows.Add((++STT).ToString(), i.ComputerCode.Split('#')[0], "CS01" + i.ComputerCode.Split('#')[0] + i.ComputerCode.Split('#')[1], i.ComputerCode.Split('#')[1], "", "Thay "+change);
                }
            }

            gcMessageOfComputer.DataSource = dt;

        }
        
        private void btnWiew_Click(object sender, EventArgs e)
        {
            gcMessage.DataSource = CreateDataTable();
        }
        DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("RoomName");
            dt.Columns.Add("ComputerNumber");
            dt.Columns.Add("Time");
            dt.Columns.Add("Message");
            dt.Columns.Add("OldConfiguration");
            dt.Columns.Add("NewConfiguration");
            dt.Columns.Add("LastUser");

           var lstn = from n in db.Notices select new { n.ComputerCode,n.Time,n.Message,n.OldConfiguration,n.NewConfiguration,n.LastUser};

           if (cboRoomName.Text != "" && cboRoomName.Text != "Tất cả")
           {
               lstn = from n in lstn where cboRoomName.Text.Trim() == n.ComputerCode.Substring(0,n.ComputerCode.IndexOf('#')) select n;
           }
           if (cboComputerNumber.Text != "" && cboComputerNumber.Text != "Tất cả")
           {
               lstn = from n in lstn where n.ComputerCode.Substring(n.ComputerCode.IndexOf('#')+1) == cboComputerNumber.Text select n;
           }
           if (cboEquipmentName.Text != "" && cboEquipmentName.Text != "Tất cả")
           {
               lstn = from n in lstn where n.Message == cboEquipmentName.Text select n;
           }

            int dem = 1;
            if(lstn!=new Notice()&&lstn!=null)
            foreach (var item in lstn)
            {
                dt.Rows.Add(dem++.ToString(),item.ComputerCode.Split('#')[0],item.ComputerCode.Split('#')[1],item.Time,"Thay thế "+item.Message,item.OldConfiguration,item.NewConfiguration,item.LastUser);
            }
            return dt;
        }

        private void cboRoomName_TextChanged(object sender, EventArgs e)
        {
            cboComputerNumber.Enabled = false;
            //load lên cbo số máy
            if (cboRoomName.Text != "Tất cả")
            {
                cboComputerNumber.Properties.Items.Add("Tất cả");
                cboComputerNumber.Enabled = true;
                var lstc = from c in db.Computers where c.PracticeRoom.RoomName == cboRoomName.Text select new { c.ComputerNumber };
                foreach (var item in lstc)
                {
                    cboComputerNumber.Properties.Items.Add(item.ComputerNumber);
                }
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageComputer(chkNewComputer.Checked, chkChangeEquipment.Checked, cboRoom.Text);
        }

        private void chkNewComputer_CheckStateChanged(object sender, EventArgs e)
        {
            MessageComputer(chkNewComputer.Checked, chkChangeEquipment.Checked, cboRoom.Text);
        }

        private void chkChangeEquipment_CheckStateChanged(object sender, EventArgs e)
        {
            MessageComputer(chkNewComputer.Checked, chkChangeEquipment.Checked, cboRoom.Text);
        }

        //xem chi tiết
        private void ctmsViewDetail_Click(object sender, EventArgs e)
        {
            if (gvMessageOfComputer.GetRowCellDisplayText(gvMessageOfComputer.GetSelectedRows()[0], "Message") != "Máy tính mới")
            {
                //hiển thị chi tiết thay thế
                xtraTabControl1.SelectedTabPage = xtraTabPage2;
                cboRoomName.Text = gvMessageOfComputer.GetRowCellDisplayText(gvMessageOfComputer.GetSelectedRows()[0], "RoomName");
                cboComputerNumber.Text = gvMessageOfComputer.GetRowCellDisplayText(gvMessageOfComputer.GetSelectedRows()[0], "ComputerNumber");
                btnWiew_Click(sender,e);
            }
            else
            {
                //hiển thi chi tiết cấu hình của máy mới
                xtraTabControl1.SelectedTabPage = xtraTabPage3;
                cboComputerCode.Text = gvMessageOfComputer.GetRowCellDisplayText(gvMessageOfComputer.GetSelectedRows()[0], "ComputerCode");
            }
        }

        private void cboComputerCode_TextChanged(object sender, EventArgs e)
        {
            var lstc = from c in db.TemporaryImformations where c.ComputerCode==cboComputerCode.Text select c;

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("EquipmentCode");
            dt.Columns.Add("EquipmentName");
            dt.Columns.Add("Firm");
            dt.Columns.Add("Configuration");

            int dem = 0;
            foreach (var i in lstc)
            {
                dt.Rows.Add((++dem).ToString(), i.EquipmentCode, i.EquipmentName, i.Firm, i.Configuration);
            }
            gcConfiguration.DataSource = dt;

        }

        
       
    }
}