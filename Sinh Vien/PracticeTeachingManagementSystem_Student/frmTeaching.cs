using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using PracticeTeachingManagementSystem_Student.Helpers;

namespace PracticeTeachingManagementSystem_Student
{

   public partial class frmTeaching : DevExpress.XtraEditors.XtraForm
   {
      public frmTeaching()
      {
         InitializeComponent();
      }
      public static string IP = "";
      [return: MarshalAs(UnmanagedType.Bool)]
      [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
      public static extern void BlockInput([In, MarshalAs(UnmanagedType.Bool)]bool fBlockIt);
      private void frmTeaching_Load(object sender, EventArgs e)
      {

         frmMain.StopListen();

         Start();
          
         

      }
      ScreenCapture.ScreenCapture obj;
      TcpChannel channel;
      void Start()
      {

         string URI = "Tcp://" + IP + ":6601/MyCaptureScreenServer";

         obj = new ScreenCapture.ScreenCapture();
            channel = (TcpChannel) TcpChanelHelper.GetChannel(new Random(DateTime.Now.Millisecond).Next(7000, 60000), true);
         ChannelServices.RegisterChannel(channel, false);
         obj = (ScreenCapture.ScreenCapture)Activator.GetObject(typeof(ScreenCapture.ScreenCapture), URI);

         Runtime.Enabled = true;




      }
      void Stop()
      {
         try
         {
            frmMain.ktr = false;
            Runtime.Enabled = false;
            ChannelServices.UnregisterChannel(channel);
            frmMain.startListen();
            this.Close();

         }
         catch { frmMain.startListen(); }
      }
      public void KillCtrlAltDelete()
      {
          RegistryKey regkey;
          string keyValueInt = "1";
          string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
          try
          {
              regkey = Registry.CurrentUser.CreateSubKey(subKey);
              regkey.SetValue("DisableTaskMgr", keyValueInt);
              regkey.Close();
          }
          catch { }
      }
      private void Runtime_Tick(object sender, EventArgs e)
      {
         try
         {
             BlockInput(true);
             KillCtrlAltDelete();
            string URI = "Tcp://" + IP + ":6601/MyCaptureScreenServer";

            byte[] buff = obj.GetDesktopBitmapBytes(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            byte[] tmp = ScreenCapture.QuickLZ.decompress(buff);
            MemoryStream ms = new MemoryStream(tmp);
            pteTeaching.Image = Image.FromStream(ms);
         }
         catch { 

            Stop(); }
      }
      public void EnableCTRLALTDEL()
      {
          try
          {
              string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
              RegistryKey rk = Registry.CurrentUser;
              RegistryKey sk1 = rk.OpenSubKey(subKey);
              if (sk1 != null)
                  rk.DeleteSubKeyTree(subKey);
          }
          catch
          {
          }
      }
      private void frmTeaching_FormClosing(object sender, FormClosingEventArgs e)
      {
         frmMain.ktr = false;
         
                Stop();

                BlockInput(false);
                EnableCTRLALTDEL();
      }

   }
}