using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PracticeTeachingManagementSystem
{
    public partial class frmClient : DevExpress.XtraEditors.XtraForm
    {
        public frmClient()
        {
            InitializeComponent();
        }
        Tool ct = new Tool();
        Socket client;
        string ip = "";
        byte[] data = new byte[1024];
        void Connected(IAsyncResult iar)
        {
            try
            {
                Thread receiver = new Thread(new ThreadStart(ReceiveData));
                receiver.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Không kết nối tới máy sinh viên", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
        void SendData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int sent = remote.EndSend(iar);
            }
            catch
            { }
        }
        string stringData = "";
        void ReceiveData()
        {
            try
            {
                int recv;
              
                while (true)
                {
                    recv = client.Receive(data);
                    stringData = UnicodeEncoding.UTF8.GetString(data, 0, recv);
                    if (stringData == "Bye")
                    {
                        break;
                    }
                    this.TopMost = true;
                   
                   
                }
            }
            catch
            {
                if (client.Connected==false)
                {
                    //MessageBox.Show("Ngắt kết nối tới máy sinh viên", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); client.Close(); this.Close();

                }
               
              
            }
            return;
        }
        private void ClientToConnect()
        {
            client= new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), 3046);
            client.BeginConnect(iep, new AsyncCallback(Connected), client);
        }
        void SenDL(string x)
        {
            try
            {
                byte[] message = UnicodeEncoding.UTF8.GetBytes(x);
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
            }
            catch
            { }
 
        }
       
        private void SendMessage()
        {
            if (client.Connected == true)
            {
                try
                {
                    string x = "";
                    if (txtSend.Text != "")
                    {
                        if (txtSend.Text == "Buzz")
                        {
                            lbcShow.AppendText("\n");
                            ct.AppendText(lbcShow, "Buzz", Color.Red, "Arial", 14, ttbB, ttbI, ttbU);
                            SenDL("Buzz");
                        }
                        else
                        {
                            x = x + frmLogin.FullName + " : " + txtSend.Text;
                            lbcShow.AppendText("\n");
                            lbcShow.AppendText(frmLogin.FullName + ": ");
                            ct.AppendText(lbcShow, txtSend.Text, colorDialog1.Color, cboFont.Text, float.Parse(cboSize.Text), ttbB, ttbI, ttbU);
                            SenDL(x);
                        }
                       
                       
                    }
                }
                catch
                {
                    MessageBox.Show("Không kết nối");
                }
            }
            else
            {
                 ClientToConnect();
                 lbcShow.AppendText("\n");
                 lbcShow.AppendText(frmLogin.FullName + ": ");
                 ct.AppendText(lbcShow, txtSend.Text, colorDialog1.Color, cboFont.Text, float.Parse(cboSize.Text), ttbB, ttbI, ttbU);
                 Thread.Sleep(1000);
                 if (client.Connected == false)
                 {
                     lbcShow.AppendText("\n");
                     lbcShow.AppendText("Không kết nối tới sinh viên");
                 }

            }
            txtSend.Text = "";
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            foreach (FontFamily item in FontFamily.Families)
            {
                cboFont.Items.Add(item.Name);
            }
            cboFont.Text = "Arial";
            for (int i = 1; i <= 32; i++)
            {
                cboSize.Items.Add(i);
            }
            cboSize.Text = "10";
            ip = Program.iPClient;
            Program.iPClient = "";
            ClientToConnect();
            timer1.Enabled = true;
            this.Text = Program.FullNameStudent;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void MmeSend_TextChanged(object sender, EventArgs e)
        {
            if (txtSend.Text == "")
            { btnSend.Enabled = false; }
            else
            {
                btnSend.Enabled = true;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            SenDL("Buzz");
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (string item in devMain.lst)
                {
                    if (item == ip)
                    { devMain.lst.Remove(item); break; }
                }
                if (client.Connected == true)
                {
                    SenDL("Bye");
                }
                client.Close();
            }
            catch
            { }
        }
        private void MmeSend_TextChanged_1(object sender, EventArgs e)
        {

            if (txtSend.Text == "")
            { btnSend.Enabled = false; }
            else
            {
                btnSend.Enabled = true;
            }
            txtSend.SelectionFont = new Font(cboFont.Text, int.Parse(cboSize.Text), ct.KieuFont(ttbB, ttbI, ttbU));
            txtSend.Focus();
            txtSend.SelectionColor = colorDialog1.Color;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.loadForm == false)
            {
                if (client.Connected == true)
                {
                    this.TopMost = true;
                    lbcShow.AppendText("\n");
                    lbcShow.AppendText(devMain.xau);
                    timer1.Enabled = false;
                }
            }
        }

        #region Các chức năng phụ
        /// <summary>
        /// In đậm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbB_Click(object sender, EventArgs e)
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
        private void ttbI_Click(object sender, EventArgs e)
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
        private void ttbU_Click(object sender, EventArgs e)
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
        private void ttbColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSend.SelectionColor = colorDialog1.Color;
                txtSend.Focus();
            }
            txtSend.Focus();
        }
        string FileName;
        /// <summary>
        /// Gửi tài liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbFile_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            FileInfo TheFile = new FileInfo(filename); // Get The File Name
            FileName = TheFile.Name;
            ct.FileSize(filename);
            if (ct.size > 0)
            {
               

                if (ct.size <= 100000000)
                {
                    if (ct.IsFileUsedbyAnotherProcess(filename) == false)
                    {

                        try
                        {
                            
                            FileStream fs = new FileStream(filename, FileMode.Open);
                            byte[] buffer = new byte[fs.Length];
                            int len = (int)fs.Length;
                            fs.Read(buffer, 0, len);
                            fs.Close();
                            BinaryFormatter br = new BinaryFormatter();
                            TcpClient myclient = new TcpClient(ip, 3047);
                            NetworkStream myns = myclient.GetStream();
                            br.Serialize(myns, FileName);
                            BinaryWriter mysw = new BinaryWriter(myns);
                            mysw.Write(buffer);
                            mysw.Close();
                            myns.Close();
                            myclient.Close();
                            lbcShow.AppendText("\n");
                            ct.AppendText(lbcShow, "Bạn đã gửi thành công" + ":" + FileName, Color.Blue, "Arial", 14,ttbB,ttbI,ttbU);
                           
                        }
                        catch
                        {
                            XtraMessageBox.Show("Không kết nối tới máy giáo viên", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("File bạn cần gửi đang được mở bởi một chương trình khác", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Quá dung lượng cho phép (100Mb)", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        /// <summary>
        /// Buzz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbBuzz_Click(object sender, EventArgs e)
        {
            txtSend.Text = "Buzz";
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
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSend.Focus();
        }
        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (stringData != "")
            {
                if (stringData == "Buzz")
                {
                    this.MaximizeBox = true;
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Buzz.wav");
                    sp.Play();
                    lbcShow.AppendText("\n");
                    ct.AppendText(lbcShow, "Buzz", Color.Red, "Arial", 14, ttbB, ttbI, ttbU);
                }
                else
                {
                    lbcShow.AppendText("\n");
                    lbcShow.AppendText(stringData);
                }
                stringData = "";
            }
        }
    }
}