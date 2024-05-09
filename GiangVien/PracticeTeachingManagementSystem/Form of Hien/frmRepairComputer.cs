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
    public partial class frmRepairComputer : DevExpress.XtraEditors.XtraForm
    {
        public frmRepairComputer()
        {
            InitializeComponent();
        }

        PTMSDataContext db = new PTMSDataContext();
        private void cboRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRepair.Text == "Thay thế linh kiện")
            {
                //Form f = new frmReplaceEquipment();
                //f.ShowDialog();
            }


        }
        void LoadData()
        {
            var list = from s in db.RepairErrors select new {s.TimeRepair,s.PeopleChange,s.Computer.PracticeRoom.RoomName,s.Computer.ComputerNumber,s.Error,s.TimeError,s.Repair,s.Detail};
            gcRepair.DataSource = list;

            //load nguoi sua
            var r = from rm in db.RepairErrors
                    select rm;
            foreach (var itm in r)
            {
                cboPeopleChange.Properties.Items.Add(itm.PeopleChange);
            }
            cboPeopleChange.Text = "";
        }

        private void frmRepairComputer_Load(object sender, EventArgs e)
        {
            LoadData();

            //load phong
            var r = from rm in db.PracticeRooms
                    select rm;
            foreach (var itm in r)
            {
                cboRoom.Properties.Items.Add(itm.RoomName);
            }
            cboRoom.Text = "";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            cboComputerNumber.Enabled = false;
            cboError.Enabled = false;
        }
        String rroom, ccoputeName, eerror, ttime,rrepairID;
        private void gcRepair_Click(object sender, EventArgs e)
        {
            foreach (GridCell item in gvRepair.GetSelectedCells())
            {
                dtpDate.Text = ttime = gvRepair.GetRowCellDisplayText(item.RowHandle, "TimeRepair");
                cboPeopleChange.Text = gvRepair.GetRowCellDisplayText(item.RowHandle, "PeopleChange");
                cboRoom.Text = rroom = gvRepair.GetRowCellDisplayText(item.RowHandle, "RoomName");
                cboComputerNumber.Text = ccoputeName = gvRepair.GetRowCellDisplayText(item.RowHandle, "ComputerNumber");
                cboError.Text = eerror = gvRepair.GetRowCellDisplayText(item.RowHandle, "Error");
                txtTime.Text = ttime= gvRepair.GetRowCellDisplayText(item.RowHandle, "TimeError");
                cboRepair.Text = gvRepair.GetRowCellDisplayText(item.RowHandle, "Repair");
                mmoDetail.Text = gvRepair.GetRowCellDisplayText(item.RowHandle, "Detail");

            }
            if (dtpDate.Text != "")
            {
                //lay id
                rrepairID = db.RepairErrors.SingleOrDefault(r => r.TimeRepair == Convert.ToDateTime(dtpDate.Text) && r.PeopleChange == cboPeopleChange.Text && r.Computer.PracticeRoom.RoomName == cboRoom.Text && r.Computer.ComputerNumber == cboComputerNumber.Text && r.Error == cboError.Text && r.Repair == cboRepair.Text).RepairErrorID.ToString();

                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }

            //khoa khi sua
            //cboComputerNumber.Enabled = false;
            //cboError.Enabled = false;
        }
        void Empty()
        {
            dtpDate.Text = "";
            cboPeopleChange.Text = "";
            cboRoom.Text = "";
            cboComputerNumber.Text = "";
            cboError.Text = "";
            cboRepair.Text = "";
            mmoDetail.Text = "";
            txtTime.Text = "";

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            loadPeopleChange();

        }
        bool CheckEmpty()
        {
            bool kt = true;
            if (dtpDate.Text == "")
            {
                errorProvider1.SetError(dtpDate, "Chưa chọn ngày.");
                dtpDate.Focus();
                kt = false;
            }
            else if (cboPeopleChange.Text == "")
            {
                errorProvider1.SetError(cboPeopleChange, "Chưa nhập người sửa.");
                cboPeopleChange.Focus();
                kt = false;
            }
            else if (cboRoom.Text == "")
            {
                errorProvider1.SetError(cboRoom, "Chưa chọn phòng.");
                cboRoom.Focus();
                kt = false;
            }
            else if (cboComputerNumber.Text == "")
            {
                errorProvider1.SetError(cboComputerNumber, "Chưa chọn số máy.");
                cboComputerNumber.Focus();
                kt = false;
            }
            else if (cboError.Text == "")
            {
                errorProvider1.SetError(cboError, "Chưa chọn tình trạng.");
                cboError.Focus();
                kt = false;
            }
            else if (cboRepair.Text == "")
            {
                errorProvider1.SetError(cboRepair, "Chưa chọn cách khắc phục.");
                cboRepair.Focus();
                kt = false;
            }
            return kt;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                RepairError le = new RepairError();
                le.TimeRepair = Convert.ToDateTime(dtpDate.Text);
                le.PeopleChange = cboPeopleChange.Text;
                le.ComputerID = db.Computers.Single(c => c.PracticeRoom.RoomName == cboRoom.Text && c.ComputerNumber == cboComputerNumber.Text).ComputerID;
                le.Error = cboError.Text;
                if(txtTime.Text!="")
                le.TimeError = Convert.ToDateTime(txtTime.Text);
                else
                    le.TimeError = null;
                le.Repair = cboRepair.Text;
                le.Detail = mmoDetail.Text;

                db.RepairErrors.InsertOnSubmit(le);
                db.SubmitChanges();

                LoadData();

                if(cboError.Text!="Bình thường")
                {
                //cập nhật trạng thái đã sửa cho bảng errorofcomputer
                ErrorofComputer er = db.ErrorofComputers.SingleOrDefault(r =>r.Computer.PracticeRoom.RoomName==cboRoom.Text&& r.Computer.ComputerNumber == cboComputerNumber.Text && r.Error.ErrorName == cboError.Text && r.Time == DateTime.Parse(txtTime.Text));
                er.Status="Đã sửa";
                db.SubmitChanges();
                }

                Empty();
                
            }
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                RepairError le = db.RepairErrors.Single(er => er.RepairErrorID == int.Parse(rrepairID));
                le.TimeRepair = Convert.ToDateTime(dtpDate.Text);
                le.PeopleChange = cboPeopleChange.Text;
                le.ComputerID = db.Computers.Single(c => c.PracticeRoom.RoomName == cboRoom.Text && c.ComputerNumber == cboComputerNumber.Text).ComputerID;
                le.Error = cboError.Text;
                if (txtTime.Text != "")
                le.TimeError = Convert.ToDateTime(txtTime.Text);
                else
                    le.TimeError = null;
                le.Repair = cboRepair.Text;
                le.Detail = mmoDetail.Text;

                db.SubmitChanges();

                LoadData();

                //cập nhật trạng thái cho bảng errorofcomputer
                //xoa
                if (ttime != "")
                {
                    ErrorofComputer err = db.ErrorofComputers.SingleOrDefault(r => r.Computer.PracticeRoom.RoomName == rroom && r.Computer.ComputerNumber == ccoputeName && r.Error.ErrorName == eerror && r.Time == DateTime.Parse(ttime));
                    err.Status = "";
                    db.SubmitChanges();
                }
                //them
                if (txtTime.Text != "")
                {
                    ErrorofComputer erx = db.ErrorofComputers.SingleOrDefault(r => r.Computer.PracticeRoom.RoomName == cboRoom.Text && r.Computer.ComputerNumber == cboComputerNumber.Text && r.Error.ErrorName == cboError.Text && r.Time == DateTime.Parse(txtTime.Text));
                    erx.Status = "Đã sửa";
                    db.SubmitChanges();
                }

                Empty();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phòng \"" + rroom + "\", Số máy \"" + ccoputeName + "\", Tình trang \"" + eerror + "\" \nBạn có muốn xóa không?", "Thông báo xóa dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var le = from er in db.RepairErrors where er.RepairErrorID == int.Parse(rrepairID) select er;
                db.RepairErrors.DeleteAllOnSubmit(le);
                db.SubmitChanges();
                LoadData();

                //cập nhật trạng thái đã sửa cho bảng errorofcomputer
                if (ttime != "")
                {
                    ErrorofComputer err = db.ErrorofComputers.SingleOrDefault(r => r.Computer.PracticeRoom.RoomName == rroom && r.Computer.ComputerNumber == ccoputeName && r.Error.ErrorName == eerror && r.Time == DateTime.Parse(ttime));
                    err.Status = "";
                    db.SubmitChanges();
                }


                Empty();
            }

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComputerNumber.Properties.Items.Clear();
            //load máy tinh theo phong
            // cboComputerNumber.Properties.Items.Add("Tất cả");
            var r = from rm in db.Computers
                    where rm.PracticeRoom.RoomName == cboRoom.Text.Trim()
                    select rm;
            foreach (var itm in r)
            {
                cboComputerNumber.Properties.Items.Add(itm.ComputerNumber);
            }
            cboComputerNumber.Text = "";

            cboComputerNumber.Enabled = false;
            if (cboRoom.Text != "")
                cboComputerNumber.Enabled = true;
        }

        void loadPeopleChange()
        {
            cboPeopleChange.Properties.Items.Clear();
            //load nguoi sua
            var r = (from rm in db.RepairErrors
                     where rm.PeopleChange != ""
                     select new { rm.PeopleChange }).Distinct();
            foreach (var itm in r)
            {
                cboPeopleChange.Properties.Items.Add(itm.PeopleChange);
            }
        }

        private void cboComputerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboError.Text = "";
            //load tinh trang cua may
            cboError.Properties.Items.Clear();
            cboError.Properties.Items.Add("Bình thường");
            var r = from rm in db.ErrorofComputers
                    where rm.Computer.ComputerNumber == cboComputerNumber.Text.Trim() && rm.Computer.PracticeRoom.RoomName == cboRoom.Text
                    select rm;
            foreach (var itm in r)
            {
                cboError.Properties.Items.Add(itm.Error.ErrorName);
            }
                cboError.Text = "Bình thường";

            cboError.Enabled = false;
            if (cboComputerNumber.Text != "")
                cboError.Enabled = true;
        }

        private void dtpDate_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboPeopleChange_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboRoom_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboComputerNumber_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboError_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboRepair_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboError_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTime.Text = "";
            if (cboError.Text != "Bình thường" && cboError.Text != "")
                txtTime.Text = db.ErrorofComputers.SingleOrDefault(er => er.Computer.ComputerNumber==cboComputerNumber.Text&&er.Computer.PracticeRoom.RoomName==cboRoom.Text&&er.Error.ErrorName==cboError.Text).Time.ToString();
            if (cboError.Text == "Bình thường")
                txtTime.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboError_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

    }
}