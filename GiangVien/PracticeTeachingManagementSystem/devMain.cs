using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Diagnostics;
using PracticeTeachingManagementSystem.Helpers;

namespace PracticeTeachingManagementSystem
{
    public partial class devMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public devMain()
        {
            InitializeComponent();
            InitSkinGallery();
            
       }
       public static List<string> listForm = new List<string>();
        Tool clsTool = new Tool();
        /// <summary>
        /// Tạo một socket để kết nối đến server;
        /// </summary>
        public static Socket client;
        public static List<string> lst = new List<string>();
         static  frmDepartment frmDepartment=null;
        PTMSDataContext db = new PTMSDataContext();
        public static string skinname;
        #region SkinGallery Thay đổi giao diện
        void InitSkinGallery()
        {
            SimpleButton imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                GalleryItem gItem = new GalleryItem();
                int groupIndex = 0;
                if (cnt.SkinName.IndexOf("Office") > -1) groupIndex = 1;
                rgbiSkins.Gallery.Groups[groupIndex].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5);
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
                rgbiSkins.Gallery.Groups[1].Visible = false;
            }
        }
        Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            Bitmap image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                StyleObjectInfoArgs info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent * 2, height - indent * 2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }

        private void rgbiSkins_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
            skinname = e.Item.Caption;
            navMenuLeft.PaintStyleName = "SkinNav:" + e.Item.Caption;
        }

        private void rgbiSkins_Gallery_InitDropDownGallery(object sender, DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(70, 36);
        }



        #endregion
        #region Các tab Quản lý
        private void barDepart_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsTool.ShowFormDepart();
        }
        private void bbiConfigHaftYear_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConfigHaftYear frm = new frmConfigHaftYear();
            frm.Show();
        }

        private void bbiClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormClass();
        }
        private void bbiSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormSubject();
        }
        private void bbiTeacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        private void bbiJoinGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmJoinGroup frm = new frmJoinGroup();
            frm.ShowDialog();
        }
        public static int i = 0;
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
        }
        private void bbiEquipment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmEquipment();
            f.ShowDialog();
        }
        private void nbiStatisticsEquipment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        private void bbiReplacEquipment_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }
        private void bbiErrorOfComputer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmErrorofComputer();
            f.ShowDialog();
        }

       
        private void nbiStatisticsReplacEquipment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }
        private void bbiRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            Form f = new frmPracticeRoom();
            f.ShowDialog();
        }

        private void bbiComputer_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            Form f = new frmComputer();
            f.ShowDialog();
        }
        private void bbi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmRepairComputer();
            f.ShowDialog();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

      
        private void nbiRepair_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         
        }
        #endregion
        #region Giảng dạy
        bool showLogin = true;
        public static bool ktr = false;
        public static ScreenCapture.ScreenCapture myScreen = null;
        public static ObjRef objServer = null;
        public static TcpChannel Channel = null;
        public static void StopListen()
        {
            try
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
            catch { }
        }
        public static void startListen()
        {
            StopListen();
            try
            {
                Channel = (TcpChannel)TcpChanelHelper.GetChannel(6601, true);
                ChannelServices.RegisterChannel(Channel, false);
                myScreen = new ScreenCapture.ScreenCapture();
                objServer = RemotingServices.Marshal(myScreen, "MyCaptureScreenServer");
            }
            catch { }
        }


        string s = "";
        string host;
        Thread trSendMessage;
        /// <summary>
        /// Gửi thông tin sang máy khác
        /// </summary>
        public void SendMessage()
        {
            int port = 63000;
            try
            {
                TcpClient tcpCli = new TcpClient(host, port);
                NetworkStream ns = tcpCli.GetStream();
               // Gửi thông tin tới các thành viên trong nhóm
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                ns.Close();
                trSendMessage.Abort();
            }
            catch
            { trSendMessage.Abort(); }
        }
        private void nbiTeaching_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            timer2.Start();
            startListen();
            tsmiStopTeach.Text = "Ngừng giảng";
            notifyIcon1.BalloonTipText = "Hệ thống đã mở chức năng giảng bài";
            notifyIcon1.BalloonTipTitle = "PTMS Teacher ";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(1000);
            this.WindowState = FormWindowState.Minimized;

        }
        private void tsmiStopTeach_CheckedChanged(object sender, EventArgs e)
        {
            if (tsmiStopTeach.Checked == true && tsmiStopTeach.Text == "Ngừng giảng")
            {
                timer2.Enabled = false;
                timer2.Dispose();
                notifyIcon1.BalloonTipText = "Hệ thống đã tắt chế độ giảng bài!";
                notifyIcon1.BalloonTipTitle = "PTMS Teacher";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(1000);
                tsmiStopTeach.Checked = false;
                StopListen();
                tsmiStopTeach.Text = "Giảng bài";
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (tsmiStopTeach.Checked == true && tsmiStopTeach.Text == "Giảng bài")
                {
                    
                    notifyIcon1.BalloonTipText = "Hệ thống đã mở chức năng giảng bài!";
                    notifyIcon1.BalloonTipTitle = "PTMS";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                    tsmiStopTeach.Checked = false;
                    tsmiStopTeach.Text = "Ngừng giảng";
                    
                    timer2.Start();
                    startListen();
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }
        #endregion
        #region Nhận dữ liệu
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
            mytcpl = new TcpListener(7000);
            mytcpl.Start();
            mysocket = mytcpl.AcceptSocket();
            myns = new NetworkStream(mysocket);
            BinaryFormatter br = new BinaryFormatter();
            object op;

            op = br.Deserialize(myns); // Deserialize the Object from Stream
            bb = new BinaryReader(myns);
            byte[] buffer = bb.ReadBytes(150000000);
            //Kiểm tra file đã tồn tại chưa, nếu tồn tại rồi thì xóa file đó đi

            if (File.Exists(@"D:\PTMS\DuLieu\" + (string)op))
            {
                File.Delete(@"D:\PTMS\DuLieu\" + (string)op);
            }
            CreateFolder(@"D:\PTMS");
            CreateFolder(@"D:\PTMS\DuLieu");
            FileStream fss = new FileStream(@"D:\PTMS\DuLieu\" + (string)op, FileMode.CreateNew, FileAccess.Write);
            //Lưu file mới nhận vào ổ C 

            fss.Write(buffer, 0, buffer.Length);

            fss.Close();
            mytcpl.Stop();
            notifyIcon1.BalloonTipText = "Bạn vừa nhận được một file dữ liệu từ sinh viên";
            notifyIcon1.BalloonTipTitle = "PTMS";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(100);

            //XtraMessageBox.Show("Bạn vừa nhận được một file dữ liệu từ máy khác gửi tới !", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mysocket.Connected == true)
            {
                while (true)
                {
                    File_Receiver();
                }
            }
        }
        #endregion
        #region Nhận yêu cầu chat
        Thread trlisten;
        TcpListener tcpList;
        public static string xau = "";
        private void ListenToServer()
        {
            bool LISTENING = false;

            int port = 6400;
            //' PORT ADDRESS
            ///'''''''' making socket tcpList ''''''''''''''''
            tcpList = new TcpListener(port);
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
                    bool kt = false;
                    if (receivedData.IndexOf("chatlan") >= 0)
                    {
                        string[] mang = receivedData.Split(',');
                        if (frmJoinGroup.RoomName == mang[2].ToString())
                        {
                            foreach (string item in lst)
                            {
                                if (item == mang[1].ToString())
                                { kt = true; }
                            }
                            if (kt == false)
                            {
                                Program.iPClient = mang[1];
                                lst.Add(Program.iPClient);
                                xau = mang[3] + ": " + mang[4];
                                Program.FullNameStudent = mang[3];
                            }
                        }
                    }
                    sr.Close();
                    ns.Close();
                    tcpCli.Close();
                }
                tcpList.Stop();
            }
            catch (Exception ex)
            {
                //error
                LISTENING = false;
            }
        }
        #endregion
        #region Lấy về danh sách sinh viên
        void GetStudent(string style)
        {
            List<string> lst = new List<string>();
            lst.Clear();
            ListView lvitmp = new ListView();
            var ss = from c in db.SessionSpaces
                     //where c.Date == DateTime.Now.Date && c.Session==frmJoinGroup.Session && c.StudentPractice.GroupStudentID == frmJoinGroup.GroupID && c.Computer.ComputerIP != "0.0.0.0"
                     select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };
            foreach (var item in ss)
            {
                string[] mang = { item.FullName, item.ComputerNumber, item.ComputerIP };
                ListViewItem lvi = new ListViewItem(mang);
                lvitmp.Items.Add(lvi);
            }
            for (int i = lvitmp.Items.Count - 1; i >= 0; i--)
            {
                if (clsTool.TestIsAvailable(lvitmp.Items[i].SubItems[0].Text, lst, lvitmp.Items[i].SubItems[1].Text) == false)
                {
                    try
                    {
                        host = lvitmp.Items[i].SubItems[2].Text;
                        s = style;
                        trSendMessage = new Thread(SendMessage);
                        trSendMessage.Start();
                        Thread.Sleep(150);
                    }
                    catch
                    { }
                }
            }
            XtraMessageBox.Show("Đã tắt","Quản lý phòng máy",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion
        #region restart,shutdown,logoff toàn bộ phòng máy
        private void nbiRestart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###REBOOT###");
        }

        private void nbiLogoff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###LOGOFF###");
           
        }
       
        private void nbiShutdownAll_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###SHUTDOWN###");
        }
        #endregion
        
        private void devMain_Load(object sender, EventArgs e)
        {
            barDepart.Visibility = BarItemVisibility.Never;
            bbiEquipment.Visibility = BarItemVisibility.Never;
            bbiTeacher.Visibility = BarItemVisibility.Never;
            bbiSessionGroup.Visibility = BarItemVisibility.Never;
            bbiComputerEquipment.Visibility = BarItemVisibility.Never;
            bbiReplacEquipment.Visibility = BarItemVisibility.Never;
            bbiErrorOfComputer.Visibility = BarItemVisibility.Never;
            bbiFix.Visibility = BarItemVisibility.Never;
            bbiMessage.Visibility = BarItemVisibility.Never;
            bbiRestore.Visibility = BarItemVisibility.Never;

            


            frmLogin frm = new frmLogin();
            frm.ShowDialog();

        }
        private void devMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmLogin.ktr == true)
            {
                if (XtraMessageBox.Show("Ban có chắc chắn muốn đóng chương trình lại không? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Account ch = db.Accounts.SingleOrDefault(c => c.Teacher.TeacherCode == frmLogin.teacherCode);
                        if (ch != null)
                        {
                           
                            ch.IP = null;
                            db.SubmitChanges();
                        }
                        e.Cancel = false;
                        notifyIcon1.Dispose();
                        StopListen();
                        myth?.Abort();
                        mytcpl?.Stop();
                        tcpList?.Stop();
                        trlisten?.Abort();
                        frmChatRoom.trlisten?.Abort();

                    }
                    catch { e.Cancel = false; }

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
           
        }
        string chay = "";
        internal static readonly object PictureBox;

        /// <summary>
        /// Luôn cập nhật từ server xem có sinh viên nào kết nối đến;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frmLogin.ktr == true)
            {

                barDepart.Enabled = true;
                bbiClass.Enabled = true;
                bbiTeacher.Enabled = true;
                bbiStudent.Enabled = true;
                bbiSubject.Enabled = true;
                bbiSoftware.Enabled = true;
                bbiGroupStudent.Enabled = true;
                bbiSessionGroup.Enabled = true;
                bbiStudentPractice.Enabled = true;
                bbiJoinGroup.Enabled = true;
                bbiRoom.Enabled = true;
                bbiComputer.Enabled = true;
                bbiComputerEquipment.Enabled = true;
                bbiEquipment.Enabled = true;
                bbiReplacEquipment.Enabled = true;
                bbiErrorOfComputer.Enabled = true;
                bbiFix.Enabled = true;
                bbiMessage.Enabled = true;
                bbiRestore.Enabled = true;
                btnKetNoi.Enabled = false;

                rgbiSkins.Enabled = true;
                nbiSession.Enabled = true;
                nbiStudentpractice.Enabled = true;
                nbiImportSubject.Enabled = true;
                nbiStatusComputer.Enabled = true;
                nbiStatisticsEquipment.Enabled = true;
                nbiStatisticsReplacEquipment.Enabled = true;
                nbiRepair.Enabled = true;

                // TODO : fine
                if (frmJoinGroup.connectGroup == true)
                {
                    timer3.Enabled = true;
                    timer3.Start();
                    //TestShow();
                    //lắng nghe yêu cầu gửi tài liệu
                    myth = new Thread(new System.Threading.ThreadStart(File_Receiver)); // Start Thread Session
                    myth.Start();
                    //Lắng nghe yêu cầu chat
                    trlisten = new Thread(ListenToServer);
                    trlisten.Start();
                    nbiShutdownAll.Enabled = true;
                    nbiLogoff.Enabled = true;
                    ff.Enabled = true;
                    nbiChatStudent.Enabled = true;
                    nbiDiagramRoom.Enabled = true;
                    nbiRemote.Enabled = true;
                    nbiTeaching.Enabled = true;
                    //nbiCallRool.Enabled = true;
                    //bbiJoinGroup.Enabled = false;
                    nbiChatStudent.Enabled = true;
                    nbiSendFile.Enabled = true;
                    timer1.Enabled = false;
                    timer1.Dispose();
                }
            }
        }
        string GetLocalIP()
        {
            string _IP = null;

            // Resolves a host name or IP address to an IPHostEntry instance.
            // IPHostEntry - Provides a container class for Internet host address information.
            System.Net.IPHostEntry _IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            // IPAddress class contains the address of a computer on an IP network.
            foreach (System.Net.IPAddress _IPAddress in _IPHostEntry.AddressList)
            {
                 
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    _IP = _IPAddress.ToString();
                }
            }
            return _IP;
        }

        private void nbiStatusComputer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        

        private void navBarItem5_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void tsmiStopTeach_Click(object sender, EventArgs e)
        {
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            lst.Clear();
            ListView lvitmp = new ListView();
            
            //var ss = from c in db.SessionSpaces
            //         where c.Date == DateTime.Now.Date && c.Session==frmJoinGroup.Session && c.StudentPractice.GroupStudentID == frmJoinGroup.GroupID && c.Computer.ComputerIP != "0.0.0.0"
            //         select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };

            var ss = from c in db.SessionSpaces
                     where c.Date == DateTime.Now.Date && c.Session == frmJoinGroup.Session && c.Computer.ComputerIP != "0.0.0.0"
                     select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };

            foreach (var item in ss)
            {
                string[] mang = { item.FullName, item.ComputerNumber, item.ComputerIP };
                ListViewItem lvi = new ListViewItem(mang);
                lvitmp.Items.Add(lvi);
            }
            for (int i = lvitmp.Items.Count - 1; i >= 0; i--)
            {
                if (clsTool.TestIsAvailable(lvitmp.Items[i].SubItems[0].Text, lst, lvitmp.Items[i].SubItems[1].Text) == false)
                {
                    try
                    {
                        host = lvitmp.Items[i].SubItems[2].Text;
                        s = frmLogin.IP + " " + "##giangbai##";
                        trSendMessage = new Thread(SendMessage);
                        trSendMessage.Start();
                        Thread.Sleep(150);
                        lst.Add(lvitmp.Items[i].SubItems[0].Text);
                        lst.Add(lvitmp.Items[i].SubItems[1].Text);
                    }
                    catch
                    { }
                }
            }
           
            
        }

        private void nbiSession_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
        }

        private void nbiStudentpractice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (notifyIcon1.BalloonTipText == "Bạn vừa nhận được một file dữ liệu từ sinh viên")
            {
                Process.Start(@"D:\PTMS\DuLieu\");
            }
           
            
        }

        private void bbiMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmMessagebox();
            f.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void nbiImportSubject_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }

        private void bbiGroupStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormGroupStudent();
        }

        private void bbiSessionGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsTool.ShowFormSession();
        }

        private void bbiStudentPractice_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormStudent();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("HelpPTMSStudent.doc");
        }

        private void bbiLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (frmJoinGroup.connectGroup == true)
            {
                if (Program.iPClient != "")
                {

                    Program.loadForm = false;
                    frmClient a = new frmClient();
                    a.Show();
                }

            }
        }

        private void bbiStudent_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormStudentMgr();
        }

        private void bbiSoftware_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            
        }

        private void nbiRemote_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pictureBox1.Visible = false;
            clsTool.ShowFormWatchScreen();

        }

        private void nbiCallRool_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCallRows frm = new frmCallRows();
            frm.ShowDialog();
        }

        private void nbiChatStudent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmChatRoom frm = new frmChatRoom();
            frm.Show();
        }

        private void nbiSendFile_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSend frm = new frmSend();
            frm.Show();
        }

        private void nbiShutdownAll_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###SHUTDOWN###");
        }

        private void nbiLogoff_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###LOGOFF###");

        }

        private void ff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetStudent("###REBOOT###");
        }

        private void nbiStatusComputer_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form f = new frmStatisticsStatusComputer();
            //f.ShowDialog();
        }

        private void nbiStatisticsEquipment_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form f = new frmStatisticsEquipment();
            //f.ShowDialog();
        }

        private void nbiStatisticsReplacEquipment_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form f = new frmStatisticsReplaceEquipment();
            //f.ShowDialog();
        }

        private void nbiRepair_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form f = new frmStatisticsRepair();
            //f.ShowDialog();
        }

        private void nbiDiagramRoom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form f = new frmDesignMap();
            f.ShowDialog();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (notifyIcon1.BalloonTipText == "Bạn vừa nhận được một file dữ liệu từ sinh viên")
            {
                Process.Start(@"D:\PTMS\DuLieu\"); 
            }
        }

        private void navMenuLeft_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConnectIp frm = new frmConnectIp();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
