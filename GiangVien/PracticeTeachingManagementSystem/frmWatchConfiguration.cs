using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace PracticeTeachingManagementSystem
{
    public partial class frmWatchConfiguration : DevExpress.XtraEditors.XtraForm
    {
        private string computerNumber;
        public string ComputerNumber
        {
            get { return this.computerNumber; }
            set { this.computerNumber = value; }
        }
        public frmWatchConfiguration()
        {
            InitializeComponent();
        }
        string config = "";
        public string GetConfig
        {
            get { return config; }
            set { config = value; }
        }
       // PTMSDataContext db = new PTMSDataContext();
        private void frmWatchConfiguration_Load(object sender, EventArgs e)
        {
            if (this.GetConfig != "")
            {
                string[] tmp = this.GetConfig.Split(',');
                lblProcessor.Text = tmp[0];
                lblRam.Text = tmp[1];
                lblHDD.Text = tmp[3];
                lblCDROM.Text = tmp[2];
                lblBios.Text = tmp[4];
                lblKeyBoard.Text = tmp[5];
            }
        //    var c = from d in db.ComputerEquipments
        //            where d.Computer.ComputerNumber == this.computerNumber && d.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
        //            select new { d.Equipment.EquipmentName,d.Equipment.Configuration };
        //    foreach (var eq in c)
        //    {
        //        lblConfig.Text += eq.EquipmentName + ":  " + eq.Configuration + "\n\n";
        //    }
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBios_Click(object sender, EventArgs e)
        {

        }

        private void lblKeyBoard_Click(object sender, EventArgs e)
        {

        }

        private void lblHDD_Click(object sender, EventArgs e)
        {

        }

        private void lblRam_Click(object sender, EventArgs e)
        {

        }

        private void lblProcessor_Click(object sender, EventArgs e)
        {

        }
    }
}