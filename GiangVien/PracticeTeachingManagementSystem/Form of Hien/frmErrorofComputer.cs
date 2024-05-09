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
    public partial class frmErrorofComputer : DevExpress.XtraEditors.XtraForm
    {
        public frmErrorofComputer()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        private string computerNumber;
        public string ComputerNumber
        {
            get { return this.computerNumber; }
            set { this.computerNumber = value; }
        }
        public static bool isLoadfrmErrorComputer = false;
       

        private void frmErrorofComputer_Load(object sender, EventArgs e)
        {
            //load lên combobox CboError
            var lst = from er in db.Errors select er;
            foreach (var i in lst)
            {
                cboError.Properties.Items.Add(i.ErrorName);
            }


            LoadGrid();
            dtpDate.Text = frmJoinGroup.Date;

            //load phong
            var r = from rm in db.PracticeRooms
                    select rm;
            foreach (var itm in r)
            {
                cboRoom.Properties.Items.Add(itm.RoomName);
            }
            cboRoom.Text = frmJoinGroup.RoomName;

            if (frmErrorofComputer.isLoadfrmErrorComputer == true)
            {
                cboComputerNumber.Text = this.computerNumber;
            }
            else
            {
                //cboComputerNumber.Text = "";
                LoadCboComputerNumber();
            }
        }
        int GetComputerID()
        {
            Computer cp = db.Computers.SingleOrDefault(c=>c.PracticeRoom.RoomName==cboRoom.Text && c.ComputerNumber==cboComputerNumber.Text);
            if (cp != null)
                return cp.ComputerID;
            else
                return -1;
        }
        int GetErrorComputer()
        {
            ErrorofComputer ec = db.ErrorofComputers.SingleOrDefault(er=>er.ComputerID==GetComputerID()&&er.Time==DateTime.Parse(dtpDate.Text)&&er.Error.ErrorName==cboError.Text);
            if (ec != null)
                return ec.ErrorofComputerID;
            else
                return -1;
        }
        void LoadCboComputerNumber()
        {
            db = new PTMSDataContext();
            var cp = from c in db.Computers
                     where c.PracticeRoom.RoomName == frmJoinGroup.RoomName
                     select new { c.ComputerNumber };
            foreach(var item in cp)
            {
                cboComputerNumber.Properties.Items.Add(item.ComputerNumber);
            }
        }
        void LoadGrid()
        {
            //var ec = from er in db.ErrorofComputers
            //         where er.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
            //         select new { er.Time,er.Computer.ComputerNumber,er.Error};
            var ec = from er in db.ErrorofComputers
                     select new { er.Time,er.Computer.PracticeRoom.RoomName, er.Computer.ComputerNumber, er.Error.ErrorName,er.Status };
           gcErrorofComputer.DataSource = ec;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            if (GetErrorComputer() == -1)
            {
                ErrorofComputer ec = new ErrorofComputer();
                ec.ComputerID = GetComputerID();
                ec.Time = DateTime.Parse(dtpDate.Text);
                ec.ErrorID = db.Errors.SingleOrDefault(ee => ee.ErrorName == cboError.Text).ErrorID;
                db.ErrorofComputers.InsertOnSubmit(ec);
                db.SubmitChanges();
                LoadGrid();
                MessageBox.Show("Thêm thành công!",ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Bản ghi này đã tồn tại!",ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        //private void gcErrorofComputer_Click(object sender, EventArgs e)
        //{
        //    foreach (GridCell cell in gvErrorofComputer.GetSelectedCells())
        //    {
        //        cboComputerNumber.Text = gvErrorofComputer.GetRowCellDisplayText(cell.RowHandle,gridColumn3);
        //        cboError.Text = gvErrorofComputer.GetRowCellDisplayText(cell.RowHandle,gridColumn4);
        //    }
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                ErrorofComputer ec = db.ErrorofComputers.SingleOrDefault(er => er.ComputerID == GetComputerID() && er.Time == DateTime.Parse(dtpDate.Text));
                if (ec != null)
                {
                    var err=db.Errors.SingleOrDefault(er=>er.ErrorName==cboError.Text);
                    if (err!=null)
                    ec.ErrorID = err.ErrorID;
                    db.SubmitChanges();
                    LoadGrid();
                    MessageBox.Show("Sửa thành công!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ErrorofComputer ec = db.ErrorofComputers.SingleOrDefault(er => er.ComputerID == GetComputerID() && er.Time == DateTime.Parse(dtpDate.Text) && er.Error.ErrorName == cboError.Text);
            if (ec != null)
            {
                var err = db.Errors.SingleOrDefault(er => er.ErrorName == cboError.Text);
                if (err != null)
                    ec.ErrorID = err.ErrorID;
                db.ErrorofComputers.DeleteOnSubmit(ec);
                db.SubmitChanges();
                LoadGrid();
                MessageBox.Show("Xóa thành công!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gcErrorofComputer_Click(object sender, EventArgs e)
        {
            foreach (GridCell cell in gvErrorofComputer.GetSelectedCells())
            {
                cboComputerNumber.Text = gvErrorofComputer.GetRowCellDisplayText(cell.RowHandle, gridColumn3);
                cboError.Text = gvErrorofComputer.GetRowCellDisplayText(cell.RowHandle, gridColumn4);
            }
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

            return kt;
        }
        void Empty()
        {
            dtpDate.Text = "";
            cboRoom.Text = "";
            cboComputerNumber.Text = "";
            cboError.Text = "";

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComputerNumber.Properties.Items.Clear();
            //load máy tinh theo phong
            var r = from rm in db.Computers
                    where rm.PracticeRoom.RoomName == cboRoom.Text.Trim()
                    select rm;
            foreach (var itm in r)
            {
                cboComputerNumber.Properties.Items.Add(itm.ComputerNumber);
            }
            cboComputerNumber.Text ="";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new frmError();
            f.ShowDialog();
        }

        private void cboError_Enter(object sender, EventArgs e)
        {
            cboError.Properties.Items.Clear();
            //load lên combobox CboError
            var lst = from er in db.Errors select er;
            foreach (var i in lst)
            {
                cboError.Properties.Items.Add(i.ErrorName);
            }
        }

        private void cboComputerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}