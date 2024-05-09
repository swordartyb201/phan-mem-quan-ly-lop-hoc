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
    public partial class frmInfoStudent : DevExpress.XtraEditors.XtraForm
    {
        public frmInfoStudent()
        {
            InitializeComponent();
        }
        public string ip;
        public string IP
        {
            get { return this.ip; }
            set { this.ip = value; }
        }
        private  string computerNumber;
        public string ComputerNumber
        {
            get { return this.computerNumber; }
            set { this.computerNumber= value; }
        }
        PTMSDataContext db = new PTMSDataContext();
        /// <summary>
        /// Lấy ra ca (123,456,...) từ một thời gian
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        string GetSession(DateTime t)
        {
            MessageBox.Show(t.Hour.ToString());
            string ss;
            int h=t.Hour;
            if (h >= 6 && h < 9)
            {
                ss= "123"; ;
            }
            if (h >= 9 && h < 12)
            {
               ss = "456";
            }
            if (h >= 12 && h < 15)
            {
                ss = "789";
            }
            if (h >= 15 && h < 18)
            {
                ss = "012";
            }
            if (h >= 18 && h < 22)
            {
                ss = "345";
            }
            else
                ss = "";
            return ss;
        }
        private void frmInfoStudent_Load(object sender, EventArgs e)
        {
            //var c = from d in db.StudentPractices
            //        where d.Computer.ComputerNumber == this.computerNumber && d.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
            //        select new { d.Computer.ComputerName, d.Computer.ComputerIP, d.Computer.ComputerNumber, d.Student.FullName, d.Student.BirthDay };
            //var c = from d in db.SessionSpaces
            //        where d.Computer.ComputerNumber == this.computerNumber && d.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName && d.Computer.ComputerIP!="0.0.0.0" && d.GroupSessionID==frmJoinGroup.GroupSessionID
            //        select new { d.Computer.ComputerName, d.Computer.ComputerIP, d.Computer.ComputerNumber,d.StudentPractice.Student.FullName, d.StudentPractice.Student.BirthDay };
            //gridControl1.DataSource = c;

            //var c = from d in db.SessionSpaces
            //        where d.Computer.ComputerNumber == this.computerNumber && d.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName && d.Computer.ComputerIP != "0.0.0.0"
            //        select new { d.Computer.ComputerName, d.Computer.ComputerIP, d.Computer.ComputerNumber, d.StudentPractice.Student.FullName, d.StudentPractice.Student.BirthDay };
            // TODO : ERROR CHECK
            var c = (from d in db.SessionSpaces
                    where d.Computer.ComputerNumber == this.computerNumber
                    orderby d.SessionSpaceID descending
                    select new { d.Computer.ComputerName, d.Computer.ComputerIP, d.Computer.ComputerNumber, d.StudentPractice.Student.FullName, d.StudentPractice.Student.BirthDay }).FirstOrDefault();
            if (c != null)
                gridControl1.DataSource = new[] { c };
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}