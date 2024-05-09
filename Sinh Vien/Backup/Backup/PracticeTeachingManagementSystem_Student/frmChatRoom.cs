using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using DevExpress.XtraEditors;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmChatRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmChatRoom()
        {
            InitializeComponent();
        }
        ClassTool cl = new ClassTool();
        DataClassesDataContext db = new DataClassesDataContext();
        List<string> lst = new List<string>();
        void LoadListView()
        {
            //Download source code mien phi tai Sharecode.vn
            DataClassesDataContext db = new DataClassesDataContext();
            lviChat.Items.Clear();
            lst.Clear();
            GroupStudent tc = db.GroupStudents.SingleOrDefault(c => c.GroupStudentID == frmJoinGroup.GroupID);
            if (tc != null)
            {
                Account ac = db.Accounts.SingleOrDefault(c => c.TeacherID == tc.TeacherID);
                if (ac != null) {
                    string[] gv = { tc.Teacher.TeacherName, "Teacher",ac.IP };
                    ListViewItem lvgv = new ListViewItem(gv);
                    lviChat.Items.Add(lvgv);
                }
            }
            ListView lvitmp = new ListView();
            var ss = from c in db.SessionSpaces
                     where c.Date == DateTime.Now.Date && c.StudentPractice.GroupStudentID == frmJoinGroup.GroupID && c.Computer.Status == "Open" && c.Computer.ComputerIP != "0.0.0.0" && c.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
                     select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };
            foreach (var item in ss)
            {
                string[] mang = { item.FullName, item.ComputerNumber, item.ComputerIP };
                ListViewItem lvi = new ListViewItem(mang);
                lvitmp.Items.Add(lvi);
            }
            for (int i =lvitmp.Items.Count-1;i>=0; i--)
            {
                if (TestIsAvailable(lvitmp.Items[i].SubItems[0].Text) == false)
                {
                    string[] gv = { lvitmp.Items[i].SubItems[0].Text, lvitmp.Items[i].SubItems[1].Text, lvitmp.Items[i].SubItems[2].Text };
                    ListViewItem lvgv = new ListViewItem(gv);
                    lviChat.Items.Add(lvgv);
                    lst.Add(lvitmp.Items[i].SubItems[0].Text);
                }
            }
        }
        /// <summary>
        /// Kiểm tra sinh viên đã tồn tại trong nhóm
        /// </summary>
        /// <returns></returns>
        bool TestIsAvailable(string name)
        {
            bool kt = false;
            foreach (string item in lst)
            {
                if (item == name) { kt = true; }
            }
            return kt;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (receivedData != "")
            {
                lbtShow.AppendText("\n");
                lbtShow.AppendText(receivedData);
                receivedData = "";
            }
            
        }
        private void frmChatRoom_Load(object sender, EventArgs e)
        {
            Computer cp = db.Computers.SingleOrDefault(c => c.ComputerName == frmJoinGroup.strHostName);
            cp.Status = "Open";
            db.SubmitChanges();
            LoadListView();
            foreach (FontFamily item in FontFamily.Families)
            {
                cboFont.Items.Add(item.Name);
            }
            cboFont.Text = "Arial";
            for (int i = 1; i <= 32; i++)
            {
                cboSize.Items.Add(i);
            }
            cboSize.Text = "12";
            //Bắt đầu lắng nghe xem có máy nào kết nối đến
            trlisten = new Thread(ListenToServer);
            trlisten.Start();
        }
        string host;
        int port;
        Thread trSendMessage;
        /// <summary>
        /// Gửi thông tin tới máy cần gửi
        /// </summary>
        public void SendMessage()
        {
               
                try
                {
                    TcpClient tcpCli = new TcpClient(host, port);
                    NetworkStream ns = tcpCli.GetStream();
                    //Gửi thông tin tới các thành viên trong nhóm
                    StreamWriter sw = new StreamWriter(ns);
                    string x = frmJoinGroup.FullName + ":" + infomation;
                    sw.WriteLine(x);
                    sw.Flush();
                    sw.Close();
                    ns.Close();
                    trSendMessage.Abort();
                }
                catch
                { trSendMessage.Abort(); }
           
        }
        #region Lắng nghe các kết nối từ máy khác
      
        public static Thread trlisten;
        TcpListener tcpList;
        string receivedData="";
        private void ListenToServer()
        {
            bool LISTENING = false;
            //IPAddress localhostAddress = ipAddress;
            string[] mang = frmJoinGroup.IP.Split('.');
            port = frmJoinGroup.GroupID + int.Parse(mang[3]);
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
                    receivedData = sr.ReadLine();
                   
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
        string infomation = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            infomation = txtSend.Text;
            for (int i = 0; i < lviChat.Items.Count; i++)
            {
                try
                {
                    
                    host = lviChat.Items[i].SubItems[2].Text;
                    string[] mang = host.Split('.');
                    port = frmJoinGroup.GroupID + int.Parse(mang[3]);
                    trSendMessage = new Thread(SendMessage);
                    trSendMessage.Start();
                    Thread.Sleep(150);
                }
                catch
                { }
            }
            txtSend.Text = "";
        }
      
        private void frmChatRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmMain.chatGroup = false;
                Computer cp = db.Computers.SingleOrDefault(c => c.ComputerName == frmJoinGroup.strHostName);
                cp.Status = "Close";
                db.SubmitChanges();
                tcpList.Stop();
                trlisten.Abort();
            }
            catch
            { }

        }
        #region Các chức năng phụ
        /// <summary>
        /// In đậm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbB_Click_1(object sender, EventArgs e)
        {
            if (ttbB.Checked == false)
            {
                ttbB.Checked = true;
            }

            else
            {
                ttbB.Checked = false;
            }
            txtSend.Focus();
        }
        /// <summary>
        /// In nghiêng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbI_Click_1(object sender, EventArgs e)
        {
            if (ttbI.Checked == false)
            {
                ttbI.Checked = true;
            }

            else
            {
                ttbI.Checked = false;
            }
            txtSend.Focus();

        }
        /// <summary>
        /// Ngạch chân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbU_Click_1(object sender, EventArgs e)
        {
            if (ttbI.Checked == false)
            {
                ttbI.Checked = true;
            }

            else
            {
                ttbI.Checked = false;
            }
            txtSend.Focus();

        }
        /// <summary>
        /// Chọn màu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbColor_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSend.SelectionColor = colorDialog1.Color;
                txtSend.Focus();
            }
        }
        /// <summary>
        /// Buzz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbBuzz_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ẩn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbT_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Chọn kiểu chữ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSend.Focus();
        }

        private void cboSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSend.Focus();
        }

        private void txtSend_TextChanged_2(object sender, EventArgs e)
        {
            if (txtSend.Text == "")
            { btnSend.Enabled = false; }
            else
            { btnSend.Enabled = true; }
            txtSend.SelectionFont = new Font(cboFont.Text, int.Parse(cboSize.Text), cl.KieuFont(ttbB, ttbI, ttbU));
            txtSend.Focus();
            txtSend.SelectionColor = colorDialog1.Color;
        }

        private void ttbBuzz_Click_2(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Buzz.wav");
            sp.Play();
        }
#endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend.Text != "")
            {
                infomation = txtSend.Text;
                for (int i = 0; i < lviChat.Items.Count; i++)
                {
                    host = lviChat.Items[i].SubItems[2].Text;
                    string[] mang = host.Split('.');
                    port = frmJoinGroup.GroupID + int.Parse(mang[3]);
                    trSendMessage = new Thread(SendMessage);
                    trSendMessage.Start();
                    Thread.Sleep(100);
                }
            }
            txtSend.Text = "";
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadListView();
        }

    }
}