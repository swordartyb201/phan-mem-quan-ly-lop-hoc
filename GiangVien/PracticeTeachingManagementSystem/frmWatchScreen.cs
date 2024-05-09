using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Remoting.Channels;
using System.Linq;
namespace PracticeTeachingManagementSystem
{
    public partial class frmWatchScreen : DevExpress.XtraEditors.XtraForm
    {
        public frmWatchScreen()
        {
            InitializeComponent();
        }
        List<string> ListIPUpdate = new List<string>();
        public static bool ReloadScreen = false;
        PTMSDataContext db = new PTMSDataContext();
        bool Test(int computerID)
        {
            bool ok = false;
            var S = from st in db.SessionSpaces
                    select new { st.ComputerID };
            foreach (var itm in S)
            {
                if (itm.ComputerID == computerID)
                {
                    ok = true; break;
                }

            }
            return ok;

        }
        bool TestIPInSesspace(string computerIP)
        {
            var s = db.SessionSpaces.Where(c => c.Computer.ComputerIP == computerIP && c.Session==frmJoinGroup.Session && c.Date==DateTime.Now.Date);

            if (s.Count() > 0)
                return true;
            else
                return false;

           

        }
        private void frmWatchScreen_Load(object sender, EventArgs e)
        {

            LoadtblLayout();
            #region load màn hình sinh viên
            //var query1 = from c in db.StudentPractices
            //             where c.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
            //             select new { c.Computer.ComputerNumber, c.Computer.ComputerIP, c.Computer.Status };
            // TODO : ERROR CHECK
            var query1 = from c in db.Computers
                         //where c.PracticeRoom.RoomName == frmJoinGroup.RoomName
                         select new { c.ComputerID, c.ComputerNumber, c.ComputerIP, c.Status };

            foreach (var q in query1)
            {
                //Nếu máy đã có học sinh ngồi 

                //Lấy ra tên học sinh ngồi máy
                UCScreenCapture uc = new UCScreenCapture();
                if (q.ComputerIP != "0.0.0.0")// && TestIPInSesspace(q.ComputerIP))
                {
                    uc.ComputerNumber = "Máy " + q.ComputerNumber.ToString();
                    uc.GetIP = q.ComputerIP;
                }
                else
                {
                    uc.ComputerNumber = "Máy " + q.ComputerNumber.ToString();
                    uc.GetIP = "0.0.0.0";

                }


                tlpListComputer.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.Start();
            }
            #endregion
        }
        //Load số cột và hàng
        void LoadtblLayout()
        {
            tlpListComputer.ColumnCount = 7;
            tlpListComputer.RowCount = 5;
            for (int k = 0; k < 7; k++)
            {
                tlpListComputer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            for (int l = 0; l < tlpListComputer.RowCount; l++)
            {
                tlpListComputer.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            }
        }

        private void UpdateIP_Tick(object sender, EventArgs e)
        {
            if (ReloadScreen)
            {
                ReloadScreen = false;
                #region Load lại màn hình sinh viên

                tlpListComputer.Controls.Clear();
                var query1 = from c in db.Computers
                             where c.PracticeRoom.RoomName == frmJoinGroup.RoomName
                             select new { c.ComputerID, c.ComputerNumber, c.ComputerIP, c.Status };

                foreach (var q in query1)
                {
                    //Nếu máy đã có học sinh ngồi 

                    //Lấy ra tên học sinh ngồi máy
                    UCScreenCapture uc = new UCScreenCapture();
                    if (q.ComputerIP != "0.0.0.0" && TestIPInSesspace(q.ComputerIP))
                    {
                        uc.ComputerNumber = "Máy " + q.ComputerNumber.ToString();
                        uc.GetIP = q.ComputerIP;
                    }
                    else
                    {
                        uc.ComputerNumber = "Máy " + q.ComputerNumber.ToString();
                        uc.GetIP = "0.0.0.0";

                    }


                    tlpListComputer.Controls.Add(uc);
                    uc.Dock = DockStyle.Fill;
                    uc.Start();
                }
                #endregion
            }
            ListIPUpdate.Clear();
            var query = from c in db.Computers
                        where c.PracticeRoom.RoomName == frmJoinGroup.RoomName
                        select new { c.ComputerID, c.ComputerNumber, c.ComputerIP, };
            foreach (var item in query)
            {
               if (TestIPInSesspace(item.ComputerIP))
                    ListIPUpdate.Add(item.ComputerNumber.ToString() + "," + item.ComputerIP);
            }
            foreach (UCScreenCapture a in tlpListComputer.Controls)
            {
                //MessageBox.Show(a.ComputerNumber);


                foreach (string item in ListIPUpdate)
                {

                    if (a.ComputerNumber.Trim().ToLower() == "máy ".ToLower() + item.Split(',')[0].Trim().ToLower() && a.GetIP.Trim().ToLower() != item.Split(',')[1].Trim().ToLower() && item.Split(',')[1].Trim().ToLower() != "0.0.0.0".ToLower())
                    {
                        a.GetIP = item.Split(',')[1].Trim();
                        a.Start();
                     
                    }
                    else
                    {
                        if (a.ComputerNumber.Trim().ToLower() == "Máy ".ToLower() + item.Split(',')[0].Trim().ToLower() && a.GetIP.Trim().ToLower() != item.Split(',')[1].Trim().ToLower() && item.Split(',')[1].Trim().ToLower() == "0.0.0.0".ToLower())
                        {

                            a.GetIP = "0.0.0.0";
                            a.ResetPicture();
                            a.Start();
                            
                        }
                    }
                }

            }
        }

        private void frmWatchScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}