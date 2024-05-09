using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Linq;
using PracticeTeachingManagementSystem.Helpers;


namespace PracticeTeachingManagementSystem
{
   public partial class UCScreenCapture : DevExpress.XtraEditors.XtraUserControl
   {    
      public UCScreenCapture()
      {
         InitializeComponent();
      }

      PTMSDataContext db = new PTMSDataContext();
      string ip;
      string Config = "";
      int alowString = 1;
      Size getSize;
      public string ComputerNumber
      {
         get { return labComputerName.Text; }
         set { labComputerName.Text = value; }
      }
      public string GetIP
      {
         get { return ip; }
         set { ip = value; }
      }
      int GetComputerID()
      {
         Computer cp = db.Computers.SingleOrDefault(c => c.ComputerNumber == this.ComputerNumber && c.PracticeRoom.RoomName == frmJoinGroup.RoomName);
         if (cp != null)
            return cp.ComputerID;
         else return -1;
      }
      void Stop()
      {
         try
         {
            runtime.Enabled = false;
            ChannelServices.UnregisterChannel(channel);
            runtime.Dispose();

         }
         catch (Exception ex) { runtime.Enabled = false; ResetPicture(); };
      }
      public void ResetPicture()
      {
         pteScreenCapture.Image = Properties.Resources.Internet_Disconnect;
      }
      ScreenCapture.ScreenCapture obj;
      TcpChannel channel;
      public void Start()
      {
            var rnd = new Random(DateTime.Now.Millisecond);

            if (GetIP != "0.0.0.0")
         {
            try
            {
               channel = (TcpChannel)TcpChanelHelper.GetChannel(rnd.Next(6020, 6999), true);
                    ChannelServices.RegisterChannel(channel, false);
               string URI = "Tcp://" + this.GetIP + ":7700/MyCaptureScreenServer";
               obj = (ScreenCapture.ScreenCapture)Activator.GetObject(typeof(ScreenCapture.ScreenCapture), URI);
               byte[] buff = obj.UCGetDesktopBitmapBytes();
               if (alowString == 1)
               {
                  Config = obj.GetConfig(); getSize = obj.GetDesktopBitmapSize();
               }
               byte[] tmp = ScreenCapture.QuickLZ.decompress(buff);
               MemoryStream ms = new MemoryStream(tmp);
               pteScreenCapture.Image = Image.FromStream(ms);
               ChannelServices.UnregisterChannel(channel);
               runtime.Enabled = true;
            }
            catch {
               ResetPicture(); 
             }
         }
         else
         {
            runtime.Enabled = false;
            runtime.Dispose();

         }
         //Stop(); }
      }

      private void pteScreenCapture_Click(object sender, EventArgs e)
      {

      }

      private void runtime_Tick(object sender, EventArgs e)
      {
         try
         {
            Start();
         }
         catch { Stop(); }
      }

      private void pteScreenCapture_DoubleClick(object sender, EventArgs e)
      {
         if (this.GetIP != "0.0.0.0")
         {
            runtime.Enabled = false;
            //devMain frm = new devMain();
            frmRemoting t = new frmRemoting(getSize);
            t.IP = this.GetIP;
            t.StartPosition = FormStartPosition.CenterScreen;
            t.ShowDialog();

         }
         else
         {
            MessageBox.Show("Bạn chưa kết nối được với máy này", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmInfoStudent frm = new frmInfoStudent();
         frm.ComputerNumber = this.ComputerNumber.Substring(4); 
         frm.ShowDialog();
      }

      private void xemCấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmWatchConfiguration frm = new frmWatchConfiguration();
         frm.GetConfig = this.Config;
         frm.Show();
      }

      //private void tsmiError_Click(object sender, EventArgs e)
      //{
      //   //frmErrorofComputer.isLoadfrmErrorComputer = true;
      //   //if (frmErrorofComputer.isLoadfrmErrorComputer == true)
      //   //{
      //   //   frmErrorofComputer frm = new frmErrorofComputer();
      //   //   frm.ComputerNumber = this.ComputerNumber.Substring(4);
      //   //   frm.ShowDialog();
      //   //}
      //}

      //private void tsmiChangeSpace_Click(object sender, EventArgs e)
      //{
      //   //frmChangeSpace frm = new frmChangeSpace();
      //   //frm.ComputerNumber = this.ComputerNumber.Substring(4);
      //   //frm.ShowDialog();
      //}

      private void shutdownToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
      {

      }
      #region shutdown, reset, loffof, cảnh báo
      private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
      {
         trSendMessage = new Thread(SendMessage);
         trSendMessage.Start();
      }
      Thread trSendMessage;
      public void SendMessage()
      {
         string host = ip;
         // Gui thong diep
         int port = 63000;
         //try
         //{
         TcpClient tcpCli = new TcpClient(host, port);
         NetworkStream ns = tcpCli.GetStream();
 
         // Gửi yêu cầu sang bên sinh viên
         StreamWriter sw = new StreamWriter(ns);
         if (shutdownToolStripMenuItem.Checked == true)
         {
            sw.WriteLine("###SHUTDOWN###");
         }
         if (restartToolStripMenuItem.Checked == true)
         {

            sw.WriteLine("###REBOOT###");
         }
         if (logoffToolStripMenuItem.Checked == true)
         {

            sw.WriteLine("###LOGOFF###");
         }
         sw.Flush();
         // Nhận dữ liệu bên sinh viên trả về kết quả
         StreamReader sr = new StreamReader(ns);
         string result = sr.ReadLine();
         if (result == "###OK###")
         {
            MessageBox.Show("Đã tắt!!!");
         }
         sr.Close();
         sw.Close();
         ns.Close();
         try
         {
             trSendMessage.Abort();
            
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message);
         }
      }

      private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
      {
         trSendMessage = new Thread(SendMessage);
         trSendMessage.Start();
      }

      private void restartToolStripMenuItem_Click(object sender, EventArgs e)
      {
         trSendMessage = new Thread(SendMessage);
         trSendMessage.Start();
      }
      //private void cảnhBáoChoSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    trSendMessage = new Thread(SendMessage);
      //    trSendMessage.Start();
      //}

        #endregion

        //private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
