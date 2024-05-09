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

namespace PracticeTeachingManagementSystem
{
    public partial class frmChatRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmChatRoom()
        {
            InitializeComponent();
        }
        Tool cl = new Tool();
        PTMSDataContext db = new PTMSDataContext();
        void LoadListView()
        {
            List<string> lst = new List<string>();
            lviChat.Items.Clear();
            lst.Clear();
            GroupStudent tc = db.GroupStudents.SingleOrDefault(c => c.GroupStudentID == frmJoinGroup.GroupID);
            if (tc != null)
            {
                Account ac = db.Accounts.SingleOrDefault(c => c.TeacherID == tc.TeacherID);
                if (ac != null)
                {
                    string[] gv = { tc.Teacher.TeacherName, "Teacher", ac.IP };
                    ListViewItem lvgv = new ListViewItem(gv);
                    lviChat.Items.Add(lvgv);
                }
            }
            ListView lvitmp = new ListView();
            var ss = from c in db.SessionSpaces
                     // TODO: ERROR
                     //where c.Date == DateTime.Now.Date && c.Session==frmJoinGroup.Session && c.StudentPractice.GroupStudentID == frmJoinGroup.GroupID && c.Computer.ComputerIP != "0.0.0.0" && c.Computer.PracticeRoom.RoomName == frmJoinGroup.RoomName
                     select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };
            foreach (var item in ss)
            {
                string[] mang = { item.FullName, item.ComputerNumber, item.ComputerIP };
                ListViewItem lvi = new ListViewItem(mang);
                lvitmp.Items.Add(lvi);
            }
            for (int i = lvitmp.Items.Count - 1; i >= 0; i--)
            {
                if (cl.TestIsAvailable(lvitmp.Items[i].SubItems[0].Text, lst, lvitmp.Items[i].SubItems[1].Text) == false)
                {
                    string[] gv = { lvitmp.Items[i].SubItems[0].Text, lvitmp.Items[i].SubItems[1].Text, lvitmp.Items[i].SubItems[2].Text };
                    ListViewItem lvgv = new ListViewItem(gv);
                    lviChat.Items.Add(lvgv);
                    lst.Add(lvitmp.Items[i].SubItems[0].Text);
                    lst.Add(lvitmp.Items[i].SubItems[1].Text);
                }
            }
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
            //Bắt đầu lắng nghe tắt máy, reset;
           
            trlisten = new Thread(ListenToServer);
            trlisten.Start();
        }
        string host;
        int port;
        Thread trSendMessage;
        /// <summary>
        /// Gửi thông tin sang máy khác
        /// </summary>
        public void SendMessage()
        {

            try
            {
            TcpClient tcpCli = new TcpClient(host,port);
            NetworkStream ns = tcpCli.GetStream();
            // Gửi thông tin tới các thành viên trong nhóm
            StreamWriter sw = new StreamWriter(ns);
            string x = frmLogin.FullName + ":" +s;
            sw.WriteLine(x);
            sw.Flush();
            sw.Close();
            ns.Close();
            tcpCli.Close();
            trSendMessage.Abort();
            }
            catch
            { }
        }
        #region Lắng nghe các kết nối từ máy khác
        string receivedData = "";
        public static Thread trlisten;
        TcpListener tcpList;
        /// <summary>
        /// Lắng nghe kết nối từ một máy bất kỳ
        /// </summary>
        private void ListenToServer()
        {
            bool LISTENING = false;
            //IPAddress localhostAddress = ipAddress;
            string[] mang = frmJoinGroup.IP.Split('.');
            int porst = frmJoinGroup.GroupID+int.Parse(mang[3]);
            //' PORT ADDRESS
            ///'''''''' making socket tcpList ''''''''''''''''

             tcpList = new TcpListener(porst);
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
                    NetworkStream ns = tcpCli.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    ///'''''' get data from client '''''''''''''''
                     receivedData = sr.ReadLine();
                    //MessageBox.Show(receivedData);
                 
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
        string s = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtSend.Text != "")
            {
                s = txtSend.Text;
                for (int i = 0; i < lviChat.Items.Count; i++)
                {
                    try
                    {
                        host = lviChat.Items[i].SubItems[2].Text;
                        string[] mang = host.Split('.');
                        port = frmJoinGroup.GroupID + int.Parse(mang[3]);
                        trSendMessage = new Thread(SendMessage);
                        trSendMessage.Start();
                        Thread.Sleep(100);
                    }
                    catch
                    { }
                }
                   
              
               
            }
            txtSend.Text = "";
           
        }
        private void frmChatRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            tcpList.Stop();
            trlisten.Abort();
        }
       
        string ip;
        private void lviChat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem lvi = lviChat.FocusedItem;
                ip = lvi.SubItems[2].Text;
                if (ip != "")
                {
                    Program.FullNameStudent = lvi.SubItems[0].Text;
                    Program.iPClient = ip;
                    Program.loadForm = true;
                    frmClient a = new frmClient();
                    a.Show();
                }
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
            if (ttbU.Checked == false)
            {
                ttbU.Checked = true;
            }

            else
            {
                ttbU.Checked = false;
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
            s = "Buzz";
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Buzz.wav");
            sp.Play();
            SendMessage();
            txtSend.Text = "";
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
        /// <summary>
        /// Chọn cỡ chữ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSend.Focus();
        }
        /// <summary>
        /// Ẩn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbT_Click(object sender, EventArgs e)
        {
            if (ttbT.Checked == false)
            {
                ttbT.Checked = true;
                
            }

            else
            {
                ttbT.Checked = false;
            }
            txtSend.Focus();

        }
       
        /// <summary>
        /// Thay đổi khi  text thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            if (txtSend.Text == "")
            { btnSend.Enabled = false; }
            else
            { btnSend.Enabled = true; }
            txtSend.SelectionFont = new Font(cboFont.Text, int.Parse(cboSize.Text), cl.KieuFont(ttbB, ttbI, ttbU));
            txtSend.Focus();
            txtSend.SelectionColor = colorDialog1.Color;
        }
        #endregion

        private void lviChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadListView();
        }

    }
}