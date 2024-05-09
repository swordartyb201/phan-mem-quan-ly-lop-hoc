using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;
using ex = Microsoft.Office.Interop.Excel;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Diagnostics;
using System.Management;
namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        public static string ip;
        void Application_ApplicationExit(object sender, EventArgs e)
        {


        }
        public static bool chatGroup=false;
        public static bool chat = false;
        DataTable dtExportExcell;
        List<string> date;
        List<int> groupSessionID;
        int BuoiKhongPhep = 0;
        int BuoiOm = 0;
        static int sobuoi = 0;
        DataClassesDataContext db = new DataClassesDataContext();
        //Download source code mien phi tai Sharecode.vn

        /// <summary>
        /// Lấy về mã máy của sinh viên đang ngồi
        /// </summary>

        private void rpgJoinGroup_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

           

        }

        private void ribbonPageGroup3_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

           
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (frmJoinGroup.alowLogin == true)
            {
                //Bắt đầu lắng nghe tắt máy, reset;
                string strHostName = Dns.GetHostName();
                IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
                IPAddress[] addr = ipEntry.AddressList;
                ipAddress = addr.First<IPAddress>();
                trlisten = new Thread(ListenToServer);
                trlisten.Start();
                //Bắt đầu lằng nghe gửi tài liệu
                myth = new Thread(new System.Threading.ThreadStart(File_Receiver)); // Start Thread Session
                myth.Start();
                Listen();
                lblRoom.Text += frmJoinGroup.room;
                lblNumber.Text += frmJoinGroup.number;
                lblCode.Text += frmJoinGroup.code;
                lblName.Text += frmJoinGroup.name;
                lblClass.Text += frmJoinGroup.clas;
                timer1.Enabled = false;
                timer1.Dispose();
            }
        }
        private void rpgChat_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.GroupStudentID == frmJoinGroup.GroupID);
            if (gs != null)
            {
                Account ac = db.Accounts.SingleOrDefault(c => c.TeacherID == gs.TeacherID && c.IP != "0.0.0.0");
                if(ac!=null)
                {
                    ip = ac.IP;
                    chat = true;
                    bbiChat.Enabled = false;
                    frmClient a = new frmClient();
                    a.Show();
                }
                else
                {
                    XtraMessageBox.Show("Giáo viên chưa bật máy");
                }
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kt == false)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }


            
           
        }
        
        #region code phan remoting
        public static ScreenCapture.ScreenCapture myScreen = null;
        public static ObjRef objServer = null;
        public static TcpChannel Channel = null;
        public static void StopListen()
        {
            if (objServer != null)
            { RemotingServices.Unmarshal(objServer); }
            if (myScreen != null)
                RemotingServices.Disconnect(myScreen);
            if (Channel != null)
                ChannelServices.UnregisterChannel(Channel);
            myScreen = null;
            Channel = null;
            objServer = null;

        }
        public static void startListen()
        {
            StopListen();
            try
            {
                Channel = new TcpChannel(6600);
                ChannelServices.RegisterChannel(Channel, false);
                myScreen = new ScreenCapture.ScreenCapture();
                objServer = RemotingServices.Marshal(myScreen);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ScreenCapture.ScreenCapture), "MyCaptureScreenServer", WellKnownObjectMode.Singleton);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {

           

            lblRoom.Text = "";
            lblNumber.Text = "";
            lblCode.Text = "";
            lblName.Text = "";
            lblClass.Text = "";
            startListen();
           
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(373, 110);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(577, 436);
            
            //frmJoinGroup a = new frmJoinGroup();
            //a.ShowDialog();

           
           
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
      
       
        private void bbiConfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmConfig frm = new frmConfig();
            //frm.ShowDialog();
        }

        private void bbiChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bbiSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfoSubject frm = new frmInfoSubject();
            frm.ShowDialog();
        }
        void CreatTable()
        {
            #region sử dụng môt bảng để xử lý dữ liệu.
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "Number";
            dc.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "ComputerNumber";
            dc.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "FullName";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "BrithDay";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col1";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col2";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col3";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col4";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col5";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col6";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col7";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col8";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col9";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col10";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col11";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col12";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col13";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col14";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col15";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col16";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col17";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col18";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col19";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col20";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col21";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col22";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);
            #endregion
            //doan nay la de lay ra ngay chuyen vào excell
            //var q = (from stu in db.StudentPractices
            //         where stu.GroupID == frmJoinGroup.GroupID
            //         select new { stu.StudentID }).Distinct();
            //date = new List<string>();
            //foreach (var subq in q)
            //{
            //    var query = from d in db.CallRools
            //                where d.StudentPractice.StudentID == subq.StudentID
            //                orderby d.GroupSession.PracticeDate
            //                select new { d.GroupSession.PracticeDate };
            //    foreach (var sub in query)
            //    {
            //        date.Add(sub.PracticeDate.ToString());
            //    }
            //    break;
            //}
            //for (int i = date.Count; i <= 21; i++)
            //{
            //    date.Add("");
            //}

            //int j = 0;
            //int k = 0;
            //foreach (var item1 in q)
            //{
            //    j++;
            //    var query = from d in db.CallRools
            //                where d.StudentPractice.StudentID == item1.StudentID
            //                //orderby d.GroupSession.PracticeDate
            //                select new { d.StudentPractice.StudentID, d.StudentPractice.Student.FullName, d.StudentPractice.Student.BirthDay, d.StudentPractice.Computer.ComputerNumber, d.IsAvailable };

            //    int i = 0;
            //    DataRow dr = dt.NewRow();
            //    foreach (var item in query)
            //    {

            //        if (i == 0)
            //        {
            //            dr[0] = j;
            //            dr[1] = item.ComputerNumber;
            //            dr[2] = item.FullName;
            //            dr[3] = item.BirthDay.Value.ToShortDateString();
            //            dr[4] = item.IsAvailable;

            //        }
            //        else
            //        {
            //            dr[i + 4] = item.IsAvailable;
            //        }
            //        i++;
            //    }
            //    dt.Rows.Add(dr);
            //    k = i;
            //}
            //dtExportExcell = new DataTable();
            //dtExportExcell = dt;
        }
        /// <summary>
        /// Điểm danh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiWatchCallRool_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            CreatTable();
            #region Tra cứu thông tin điểm danh
            string[] Char = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK" };
            ex.Application ap = new Microsoft.Office.Interop.Excel.Application();
            ex.Workbook eWork;
            ex.Worksheet eSheet;
            eWork = ap.Workbooks.Add(ex.XlWBATemplate.xlWBATWorksheet);
            eSheet = (ex.Worksheet)eWork.Worksheets[1];

            #region  Phần trên
            eSheet.get_Range("A7", "AK" + (dtExportExcell.Rows.Count + 15).ToString()).Borders.LineStyle = ex.Constants.xlSolid;
            eSheet.get_Range("A9", "AK9").Cells.RowHeight = 32.75;
            eSheet.get_Range("A1", "A" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 3.75;
            eSheet.get_Range("B1", "B" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 23;


            eSheet.get_Range("AI1", "AI" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 6.75;
            eSheet.get_Range("AI" + "8", "AI" + "9").MergeCells = true;
            eSheet.get_Range("AI" + "8", "AI" + "9").Value2 = "Chữ ký";
            eSheet.get_Range("AI" + "8", "AI" + "9").VerticalAlignment = ex.XlVAlign.xlVAlignCenter;
            eSheet.get_Range("AI" + "8", "AI" + "9").Font.Size = "9";

            for (int i = 2; i < 26; i++)
            {
                if (Char[i] == "Y")
                {
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "Có lý do";
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
                }
                else
                {
                    if (Char[i] == "Z")
                    {
                        eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                        eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "Không lý do";
                        eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                        eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
                        eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Name = "Times New Roman";
                    }
                    else
                    {
                        if (i < 24)
                        {
                            eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "'" + date[i - 2].ToString();
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
                        }
                        else
                        {
                            eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "'" + date[i - 2].ToString();
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
                        }
                    }
                }
            }

            for (int i = 26; i <= 33; i++)
            {
                eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "";
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
            }
            eSheet.get_Range("AJ1", "AJ" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 13;
            eSheet.get_Range("AJ1", "AK" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 16;

            eSheet.get_Range("A1", "B1").MergeCells = true;
            eSheet.get_Range("A1", "B1").Value2 = "Mẫu theo dõi 3";
            eSheet.get_Range("A1", "B1").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A1", "B1").Font.Name = "Times New Roman";
            eSheet.get_Range("A1", "B1").Font.Italic = true;
            eSheet.get_Range("A1", "B1").Font.Underline = true;
            eSheet.get_Range("A1", "B1").Font.Size = "10";
            eSheet.get_Range("A1", "B1").Cells.RowHeight = 12;

            eSheet.get_Range("A2", "P2").MergeCells = true;
            eSheet.get_Range("A2", "P2").Value2 = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KT HƯNG YÊN";
            eSheet.get_Range("A2", "P2").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A2", "P2").Font.Name = "Times New Roman";
            eSheet.get_Range("A2", "P2").Font.Size = "10";
            eSheet.get_Range("A2", "P2").RowHeight = 12.75;

            eSheet.get_Range("Q2", "AK2").MergeCells = true;
            eSheet.get_Range("Q2", "AK2").Value2 = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            eSheet.get_Range("Q2", "AK2").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("Q2", "AK2").Font.Name = "Times New Roman";
            eSheet.get_Range("Q2", "AK2").Font.Bold = true;
            eSheet.get_Range("Q2", "AK2").Font.Size = "10";
            eSheet.get_Range("Q2", "AK2").RowHeight = 12.75;

            eSheet.get_Range("A3", "P3").MergeCells = true;
            eSheet.get_Range("A3", "P3").Value2 = "KHOA CÔNG NGHỆ THÔNG TIN";
            eSheet.get_Range("A3", "P3").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A3", "P3").Font.Name = "Times New Roman";
            eSheet.get_Range("A3", "P3").Font.Bold = true;
            eSheet.get_Range("C3", "J3").Font.Underline = true;
            eSheet.get_Range("A3", "P3").Font.Size = "10";
            eSheet.get_Range("A3", "P3").Cells.RowHeight = 15.75;

            eSheet.get_Range("Q3", "AK3").MergeCells = true;
            eSheet.get_Range("Q3", "AK3").Value2 = "Độc lập - Tự do - Hạnh phúc";
            eSheet.get_Range("Q3", "AK3").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("Q3", "AK3").Font.Name = "Times New Roman";
            eSheet.get_Range("Q3", "AK3").Font.Bold = true;
            eSheet.get_Range("Y3", "AG3").Font.Underline = true;
            eSheet.get_Range("Q3", "AK3").Font.Size = "10";
            eSheet.get_Range("Q3", "AK3").Cells.RowHeight = 15.75;

            eSheet.get_Range("A4", "AK4").Cells.RowHeight = 6.75;

            eSheet.get_Range("A5", "AK5").MergeCells = true;
            eSheet.get_Range("A5", "AK5").Value2 = "BẢNG THEO DÕI HỌC TẬP(HỌC PHẦN THỰC HÀNH)";
            eSheet.get_Range("A5", "AK5").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A5", "AK5").Font.Name = "Times New Roman";
            eSheet.get_Range("A5", "AK5").Font.Bold = true;
            eSheet.get_Range("A5", "AK5").Font.Size = "13";
            eSheet.get_Range("A5", "AK5").Cells.RowHeight = 18.75;

            eSheet.get_Range("A6", "B6").MergeCells = true;
            eSheet.get_Range("A6", "B6").Value2 = "Môn: " + frmJoinGroup.SubjectName;
            eSheet.get_Range("A6", "B6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A6", "B6").Font.Name = "Times New Roman";
            eSheet.get_Range("A6", "B6").Font.Size = "11";
            eSheet.get_Range("A6", "B6").Cells.RowHeight = 15;

            eSheet.get_Range("C6", "H6").MergeCells = true;
            eSheet.get_Range("C6", "H6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("C6", "H6").Font.Name = "Times New Roman";
            eSheet.get_Range("C6", "H6").Font.Size = "11";
            eSheet.get_Range("C6", "H6").Cells.RowHeight = 15;

            eSheet.get_Range("I6", "K6").MergeCells = true;
            eSheet.get_Range("I6", "K6").Value2 = "Lớp: " + frmJoinGroup.ClassName;
            eSheet.get_Range("I6", "K6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("I6", "K6").Font.Name = "Times New Roman";
            eSheet.get_Range("I6", "K6").Font.Size = "11";
            eSheet.get_Range("I6", "K6").Cells.RowHeight = 15;

            eSheet.get_Range("L6", "O6").MergeCells = true;
            eSheet.get_Range("L6", "O6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("L6", "O6").Font.Name = "Times New Roman";
            eSheet.get_Range("L6", "O6").Font.Size = "11";
            eSheet.get_Range("L6", "O6").Cells.RowHeight = 15;

            eSheet.get_Range("P6", "W6").MergeCells = true;
            eSheet.get_Range("P6", "W6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("P6", "W6").Font.Name = "Times New Roman";
            eSheet.get_Range("P6", "W6").Font.Size = "11";
            eSheet.get_Range("P6", "W6").Cells.RowHeight = 15;

            eSheet.get_Range("X6", "AH6").MergeCells = true;
            eSheet.get_Range("X6", "AH6").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("X6", "AH6").Font.Name = "Times New Roman";
            eSheet.get_Range("X6", "AH6").Font.Size = "11";
            eSheet.get_Range("X6", "AH6").Cells.RowHeight = 15;

            eSheet.get_Range("A7", "A9").MergeCells = true;
            eSheet.get_Range("A7", "A9").Value2 = "STT";
            eSheet.get_Range("A7", "A9").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A7", "A9").VerticalAlignment = ex.XlVAlign.xlVAlignCenter;
            eSheet.get_Range("A7", "A9").Font.Name = "Times New Roman";
            eSheet.get_Range("A7", "A9").Font.Size = "11";

            eSheet.get_Range("B7", "B9").MergeCells = true;
            eSheet.get_Range("B7", "B9").Value2 = "Họ và tên";
            eSheet.get_Range("B7", "B9").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("B7", "B9").VerticalAlignment = ex.XlVAlign.xlVAlignCenter;
            eSheet.get_Range("B7", "B9").Font.Name = "Times New Roman";
            eSheet.get_Range("B7", "B9").Font.Size = "11";

            eSheet.get_Range("C7", "X7").MergeCells = true;
            eSheet.get_Range("C7", "X7").Value2 = "Ngày/tháng";
            eSheet.get_Range("C7", "X7").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("C7", "X7").Font.Name = "Times New Roman";
            eSheet.get_Range("C7", "X7").Font.Size = "11";

            eSheet.get_Range("Y7", "Z7").MergeCells = true;
            eSheet.get_Range("Y7", "Z7").Value2 = "Số buổi";
            eSheet.get_Range("Y7", "Z7").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("Y7", "Z7").Font.Name = "Times New Roman";
            eSheet.get_Range("Y7", "Z7").Font.Size = "11";

            eSheet.get_Range("AA7", "AH7").MergeCells = true;
            eSheet.get_Range("AA7", "AH7").Value2 = "Điểm quá trình";
            eSheet.get_Range("AA7", "AH7").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("AA7", "AH7").Font.Name = "Times New Roman";
            eSheet.get_Range("AA7", "AH7").Font.Size = "11";

            eSheet.get_Range("AJ7", "AJ9").MergeCells = true;
            eSheet.get_Range("AJ7", "AJ9").Value2 = "Kết luận\nĐK dự thi\nKTHP";
            eSheet.get_Range("AJ7", "AJ9").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("AJ7", "AJ9").VerticalAlignment = ex.XlVAlign.xlVAlignCenter;
            eSheet.get_Range("AJ7", "AJ9").Font.Name = "Times New Roman";
            eSheet.get_Range("AJ7", "AJ9").Font.Size = "11";

            eSheet.get_Range("AK7", "AK9").MergeCells = true;
            eSheet.get_Range("AK7", "AK9").Value2 = "Ghi chú";
            eSheet.get_Range("AK7", "AK9").HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("AK7", "AK9").VerticalAlignment = ex.XlVAlign.xlVAlignCenter;
            eSheet.get_Range("AK7", "AK9").Font.Name = "Times New Roman";
            eSheet.get_Range("AK7", "AK9").Font.Size = "11";
            #endregion

            //phần giữa 
            int rowindex = 10;
            foreach (DataRow row in dtExportExcell.Rows)
            {
                int columnsIndex = 0;
                foreach (DataColumn col in dtExportExcell.Columns)
                {
                    if (col.ColumnName == "ComputerNumber" || col.ColumnName == "BrithDay")
                    { }
                    else
                    {
                        columnsIndex++;
                        ap.Cells[rowindex, columnsIndex] = row[col.ColumnName];
                    }

                }
                rowindex++;
            }

            //phần đuôi
            #region Phần đuôi
            string foot = (dtExportExcell.Rows.Count + 16).ToString();
            string foot1 = (dtExportExcell.Rows.Count + 17).ToString();
            eSheet.get_Range("A" + foot, "AK" + foot).Cells.RowHeight = 16.5;
            eSheet.get_Range("A" + foot, "B" + foot).MergeCells = true;
            eSheet.get_Range("A" + foot, "B" + foot).Value2 = "Ký hiệu theo dõi";
            eSheet.get_Range("A" + foot, "B" + foot).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A" + foot, "B" + foot).Font.Bold = true;
            eSheet.get_Range("A" + foot, "B" + foot).Font.Underline = true;
            eSheet.get_Range("A" + foot, "B" + foot).Font.Name = "Times New Roman";
            eSheet.get_Range("A" + foot, "B" + foot).Font.Size = "11";

            eSheet.get_Range("F" + foot, "I" + foot).MergeCells = true;
            eSheet.get_Range("F" + foot, "I" + foot).Value2 = "Nơi nhận";
            eSheet.get_Range("F" + foot, "I" + foot).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("F" + foot, "I" + foot).Font.Bold = true;
            eSheet.get_Range("F" + foot, "H" + foot).Font.Underline = true;
            eSheet.get_Range("F" + foot, "I" + foot).Font.Name = "Times New Roman";
            eSheet.get_Range("F" + foot, "I" + foot).Font.Size = "11";

            eSheet.get_Range("Q" + foot, "Z" + foot).MergeCells = true;
            eSheet.get_Range("Q" + foot, "Z" + foot).Value2 = "Trưởng Khoa/Trưởng Bộ Môn";
            eSheet.get_Range("Q" + foot, "Z" + foot).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("Q" + foot, "Z" + foot).Font.Bold = true;
            eSheet.get_Range("Q" + foot, "Z" + foot).Font.Name = "Times New Roman";
            eSheet.get_Range("Q" + foot, "Z" + foot).Font.Size = "13";

            eSheet.get_Range("AH" + foot, "AK" + foot).MergeCells = true;
            eSheet.get_Range("AH" + foot, "AK" + foot).Value2 = "Giảng viên giảng dạy HP";
            eSheet.get_Range("AH" + foot, "AK" + foot).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Bold = true;
            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Italic = true;
            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Name = "Times New Roman";
            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Size = "13";

            eSheet.get_Range("A" + foot1, "AK" + foot1).Cells.RowHeight = 52;
            eSheet.get_Range("B" + foot1, "D" + foot1).MergeCells = true;
            eSheet.get_Range("B" + foot1, "D" + foot1).Value2 = "+ -Học đủ cả buổi\nB -Bỏ giờ\nÔ -Nghỉ ốm\nK -Nghỉ không lý do";
            eSheet.get_Range("B" + foot1, "D" + foot1).HorizontalAlignment = ex.XlHAlign.xlHAlignLeft;
            eSheet.get_Range("B" + foot1, "D" + foot1).Font.Name = "Times New Roman";
            eSheet.get_Range("B" + foot1, "D" + foot1).Font.Size = "10";

            eSheet.get_Range("H" + foot1, "O" + foot1).MergeCells = true;
            eSheet.get_Range("H" + foot1, "O" + foot1).Value2 = "Nộp trước ngày thi KTHP\nvề\n-Khoa/Bộ môn\n-Ban ĐBCL&KT";
            eSheet.get_Range("H" + foot1, "O" + foot1).HorizontalAlignment = ex.XlHAlign.xlHAlignLeft;
            eSheet.get_Range("H" + foot1, "O" + foot1).Font.Name = "Times New Roman";
            eSheet.get_Range("H" + foot1, "O" + foot1).Font.Size = "10";

            eSheet.get_Range("Q" + foot1, "Z" + foot1).MergeCells = true;
            eSheet.get_Range("Q" + foot1, "Z" + foot1).Value2 = "(Ký, ghi rõ họ tên)";
            eSheet.get_Range("Q" + foot1, "Z" + foot1).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("Q" + foot1, "Z" + foot1).VerticalAlignment = ex.XlVAlign.xlVAlignTop;
            eSheet.get_Range("Q" + foot1, "Z" + foot1).Font.Name = "Times New Roman";
            eSheet.get_Range("Q" + foot1, "Z" + foot1).Font.Size = "12";

            eSheet.get_Range("AH" + foot1, "AK" + foot1).MergeCells = true;
            eSheet.get_Range("AH" + foot1, "AK" + foot1).Value2 = "(Ký, ghi rõ họ tên)";
            eSheet.get_Range("AH" + foot1, "AK" + foot1).HorizontalAlignment = ex.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("AH" + foot1, "AK" + foot1).VerticalAlignment = ex.XlVAlign.xlVAlignTop;
            eSheet.get_Range("AH" + foot1, "AK" + foot1).Font.Name = "Times New Roman";
            eSheet.get_Range("AH" + foot1, "AK" + foot1).Font.Size = "12";

            #endregion
            // Lấy ra số buổi học hiện tại
            var q = (from stu in db.StudentPractices
                     where stu.GroupStudentID == frmJoinGroup.GroupID
                     select new { stu.StudentID }).Distinct();

            foreach (var subq in q)
            {
                var query = from d in db.CallRools
                            where d.StudentPractice.StudentID == subq.StudentID
                            group d by d.StudentPractice.StudentID into g
                            select new { g.Key, b = g.Count() };
                foreach (var sub in query)
                {
                    sobuoi = sub.b;
                    break;
                }
                //  break;
            }
            rowindex = 10;
            foreach (var subq in q)
            {
                //Lấy ra số buổi học của học sinh điểm danh có dấu Ô 
                var queryO = from d in db.CallRools
                             where (d.StudentPractice.StudentID == subq.StudentID) && (d.IsAvailable == "Ô")
                             group d by d.StudentPractice.StudentID into g
                             select new { g.Key, bo = g.Count() };
                //Lấy ra số buổi học của học sinh điểm danh có dấu K
                var queryK = from d in db.CallRools
                             where (d.StudentPractice.StudentID == subq.StudentID) && (d.IsAvailable == "K")
                             group d by d.StudentPractice.StudentID into g
                             select new { g.Key, bk = g.Count() };
                foreach (var sub in queryO)
                {
                    BuoiOm = sub.bo;
                    ap.Cells[rowindex, 25] = BuoiOm.ToString();
                }
                foreach (var item in queryK)
                {
                    BuoiKhongPhep = item.bk;
                    ap.Cells[rowindex, 26] = BuoiKhongPhep.ToString();
                }
                rowindex++;
            }
            ap.Visible = true;
            eSheet.Activate();
            #endregion
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kt == true)
            {
                Application.Exit();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.GroupStudentID == frmJoinGroup.GroupID);
            if (gs != null)
            {
                Account ac = db.Accounts.SingleOrDefault(c => c.TeacherID == gs.TeacherID && c.IP != "0.0.0.0");
                if (ac != null)
                {
                    ip = ac.IP;
                    chatGroup = true;
                    bbiChatGroup.Enabled = false;
                    frmChatRoom a = new frmChatRoom();
                    a.Show();
                }
                else
                {
                    XtraMessageBox.Show("Giáo viên chưa bật máy");
                }
            }
            
           
        }
        private void clientPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.GroupStudentID == frmJoinGroup.GroupID );
            if (gs != null)
            {
                Account ac = db.Accounts.SingleOrDefault(c => c.TeacherID == gs.TeacherID && c.IP !="0.0.0.0");
                if(ac!=null)
                {
                    ip = ac.IP;
                    MessageBox.Show(ip);
                    frmSendFlie a = new frmSendFlie();
                    a.Show();
                }
                else
                {
                    XtraMessageBox.Show("Giáo viên chưa bật máy");
                }
            }
           

        }
        #region Nhận dữ liệu từ máy giáo viên
        NetworkStream myns;
        TcpListener mytcpl;
        Socket mysocket;
        Thread myth;
        BinaryReader bb;
        /// <summary>
        /// Kiểm tra xem thư mục này đã tồn tại hay chưa
        /// Nếu chưa tồn tại thì tạo một thư mục mới
        /// </summary>
        /// <param name="strPath"></param>
        public void CreateFolder(string strPath)
        {
           
            try
            {
                if (Directory.Exists(strPath) == false)
                {
                   
                    Directory.CreateDirectory(strPath);
                }
            }
            catch { }
        }

        /// <summary>
        /// Nhận dữ liệu
        /// </summary>
        void File_Receiver()
        {
            mytcpl = new TcpListener(3047);
            mytcpl.Start();
            mysocket = mytcpl.AcceptSocket();
            myns = new NetworkStream(mysocket);
            BinaryFormatter br = new BinaryFormatter();
            object op;
            op = br.Deserialize(myns); // Deserialize the Object from Stream
            bb = new BinaryReader(myns);
            byte[] buffer = bb.ReadBytes(10000000);
            //Kiểm tra file đã tồn tại chưa, nếu tồn tại rồi thì xóa file đó đi
            if (File.Exists(@"D:\PTMS\DuLieu\" + (string)op))
            {
                File.Delete(@"D:\PTMS\DuLieu\" + (string)op);
            }
            CreateFolder(@"D:\PTMS");
            CreateFolder(@"D:\PTMS\DuLieu");
            
            FileStream fss = new FileStream(@"D:\PTMS\DuLieu\" + (string)op, FileMode.CreateNew, FileAccess.Write);
            notifyIcon1.BalloonTipText = "Bạn đang nhận được một file dữ liệu từ giáo viên ";
            notifyIcon1.BalloonTipTitle = "PTMS sinh viên ";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
            fss.Write(buffer, 0, buffer.Length);
            //StreamWriter sw = new StreamWriter(myns);
            //sw.WriteLine("Nhận dữ liệu thành công");
            //sw.Flush();
            //sw.Close();
            fss.Close();
            mytcpl.Stop();
           
            Process.Start(@"D:\PTMS\DuLieu\");
            //listBox1.Items.Add("Successfully Saved to: " + textBox1.Text + (string)op);
            if (mysocket.Connected == true)
            {
                while (true)
                {
                    File_Receiver();
                }
            }
        }
        #endregion
        #region Trao đổi thông tin với giáo viên
        public static Socket client;
        public static Socket newsock;
        public static IPEndPoint iep = new IPEndPoint(IPAddress.Any, 3046);
        private Thread receiver;
        private static byte[] data = new byte[1024];
        public static bool inform = false;
        /// <summary>
        /// Nhận dữ liệu từ máy giáo viên 
        /// </summary>
        public void ReceiveData()
        {

            try
            {
                int recv;
                string stringData;
                while (true)
                {
                    recv = client.Receive(data);
                    stringData = UnicodeEncoding.UTF8.GetString(data, 0, recv);
                    if (stringData == "Bye")
                    {
                        break;
                    }

                    frmClient.file = stringData + "," + (frmClient.count + 1).ToString();

                    if (stringData == "Buzz")
                    {
                        System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Buzz.wav");
                        sp.Play();
                    }
                }
                newsock.Close();
                client.Close();
                Listen();
            }
            catch
            {
            }
            return;
        }
        /// <summary>
        /// Khi có một kết nối đến thì sẽ tạo một luồng để giao tiếp với kết nối đó
        /// </summary>
        /// <param name="iar"></param>
        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
        }
        /// <summary>
        /// Lắng nghe kết nối từ phía giáo viên
        /// </summary>
        public void Listen()
        {
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            newsock.Bind(iep);
            newsock.Listen(5);
            newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
        }
        /// <summary>
        /// kiểm tra xem form chát đã được bật lên chưa, nếu bật lên rồi thì không bật nữa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (frmJoinGroup.alowLogin == true)
            {
                if (chat == false)
                {
                    bbiChat.Enabled = true;
                }
                if (chatGroup == false)
                {
                    bbiChatGroup.Enabled = true;
                }

            }
            
            if (frmClient.file != ",0")
            {
                if (inform == false)
                {
                    inform = true;
                    frmClient clt = new frmClient();
                    clt.Show();
                }
            }
        }
        #endregion
        #region Nhận các yêu cầu về shutdown,loff,reset máy...
        public enum ShutDown
        {
            LogOff = 0,
            Shutdown = 1,
            Reboot = 2,
            ForcedLogOff = 4,
            ForcedShutdown = 5,
            ForcedReboot = 6,
            PowerOff = 8,
            ForcedPowerOff = 12
        }
        Thread trlisten;
        IPAddress ipAddress;
        public static bool ktr = false;
        private void ListenToServer()
        {
            bool LISTENING = false;
            int port = 63000;
            //' PORT ADDRESS
            ///'''''''' making socket tcpList ''''''''''''''''
            TcpListener tcpList = new TcpListener(port);
            try
            {
                tcpList.Start();
                LISTENING = true;

                while (LISTENING)
                {
                    while (tcpList.Pending() == false & LISTENING == true)
                    {
                        // Yield the CPU for a while.
                        Thread.Sleep(10);
                    }
                    if (!LISTENING)
                        break; // TODO: might not be correct. Was : Exit Do

                    TcpClient tcpCli = tcpList.AcceptTcpClient();
                    //ListBox1.Items.Add("Data from " & "128.10.20.63")
                    NetworkStream ns = tcpCli.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    ///'''''' get data from client '''''''''''''''
                    string receivedData = sr.ReadLine();

                    sr= null;
                    if (receivedData == "###SHUTDOWN###")
                    {
                        shutDown(ShutDown.ForcedShutdown);
                    }
                    if (receivedData == "###REBOOT###")
                    {
                        shutDown(ShutDown.ForcedReboot);
                    }
                    
                    if (receivedData == "###LOGOFF###")
                    {
                        shutDown(ShutDown.ForcedLogOff);
                    }
                    if (frmJoinGroup.alowLogin == true)
                    {
                       if (ktr == false)
                       {
                          ktr = true;
                          if (receivedData.IndexOf("##giangbai##") >= 0)
                          {
                              notifyIcon1.BalloonTipText = "Hệ thống đang bật chế độ giảng bài!\nSau 5s mọi thao tác với chuột và bàn phím đều bị vô hiệu hóa !!!";
                              notifyIcon1.BalloonTipTitle = "PTMS Student";
                              notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                              notifyIcon1.ShowBalloonTip(1000);
                              Thread.Sleep(5000);
                              string[] mang = receivedData.Split(' ');
                              frmTeaching.IP = mang[0];
                              frmTeaching a = new frmTeaching();
                              a.ShowDialog();
                              //frmInfoSubject a = new frmInfoSubject();
                              //a.ShowDialog();
                          }
                       }
                    }
                    string returnedData = "###OK###";
                    //& " From Server"
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(returnedData);
                    sw.Flush();
                    sr = null;
                    sw.Close();
                    ns.Close();
                    //tcpCli.Close();
                    break;
                }
                tcpList.Stop();
                trlisten = new Thread(ListenToServer);
                trlisten.Start();
            }
            catch (Exception ex)
            {
                //error
                LISTENING = false;
            }
        }
        public void shutDown(ShutDown flag)
        {
            ManagementBaseObject outParam = null;
            ManagementClass sysOS = new ManagementClass("Win32_OperatingSystem");
            sysOS.Get();
            // enables required security privilege.
            sysOS.Scope.Options.EnablePrivileges = true;
            // get our in parameters
            ManagementBaseObject inParams = sysOS.GetMethodParameters("Win32Shutdown");
            // pass the flag of 0 = System Shutdown
            inParams["Flags"] = flag;
            inParams["Reserved"] = "0";
            foreach (ManagementObject manObj in sysOS.GetInstances())
            {
                outParam = manObj.InvokeMethod("Win32Shutdown", inParams, null);
            }
        }
        #endregion

        private void bbiConfigurations_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmconfiguration form = new frmconfiguration();
            form.ShowDialog();
        }

        private void bbiImformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmImformation form = new frmImformation();
            form.ShowDialog();
        }
        bool kt = false;
        clsSystem cls = new clsSystem();
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            kt = true;
            cls.DisNoRun();
            cls.EnableCTRLALTDEL();
            cls.ShowStartMenu();
            if (frmJoinGroup.alowLogin == true)
            {
                if (XtraMessageBox.Show("Ban có chắc chắn muốn đóng chương trình lại không? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StopListen();
                    myth.Abort();
                    mytcpl.Stop();
                    trlisten.Abort();
                    try
                    {
                        frmChatRoom.trlisten.Abort();
                    }
                    catch { }
                    Computer cl = db.Computers.SingleOrDefault(c => c.ComputerName == frmJoinGroup.strHostName);
                    if (cl != null)
                    {
                        cl.Status = "Close";
                        cl.ComputerIP = "0.0.0.0";
                        db.SubmitChanges();
                    }
                    //SessionSpace sp = db.SessionSpaces.SingleOrDefault(s => s.StudentPracticeID == frmJoinGroup.StudentPID && s.GroupSessionID == frmJoinGroup.GroupSessionID);
                    //if (sp != null)
                    //{
                    //    db.SessionSpaces.DeleteOnSubmit(sp);
                    //    db.SubmitChanges();
                    //}

                    Application.Exit();
                }
                
            }
          
            //Process.Start("HelpPTMSStudent.doc");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmImformation();
            f.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmconfiguration();
            f.ShowDialog();
        }

      
    }
}