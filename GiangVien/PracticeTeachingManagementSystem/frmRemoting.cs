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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using PracticeTeachingManagementSystem.Helpers;

namespace PracticeTeachingManagementSystem
{
    public partial class frmRemoting : DevExpress.XtraEditors.XtraForm
    {
        public frmRemoting()
        {
            InitializeComponent();
        }
        public frmRemoting(Size t)
        {
            InitializeComponent();

            desktopClient = t;
            pteRemoting.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 10, Screen.PrimaryScreen.Bounds.Height - 55);
        }

        Size desktopClient;
        ScreenCapture.ScreenCapture obj;
        TcpChannel chan;
        string URI;
        public static bool conect;
        public string ip;
        public string IP
        {
            get { return this.ip; }
            set { this.ip = value; }
        }
        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(
            uint uCode, //virtual-key code or scan code
            uint umapType //translation to perform
            );
        //void Start()
        //{

        //   //try
        //   //{
        //   URI = "Tcp://" + this.IP + ":6600/MyCaptureScreenServer";
        //   chan = new TcpChannel();
        //   ChannelServices.RegisterChannel(chan, false);
        //   obj = (ScreenCapture.ScreenCapture)Activator.GetObject(typeof(ScreenCapture.ScreenCapture), URI);
        //   conect = true;
        //   //PathWallPaper = obj.GetCurrentWallpaper();
        //   //obj.SetWallpaper();
        //  byte[] buffer = obj.GetDesktopBitmapBytes(Screen.PrimaryScreen.Bounds.Width-5);
        //   byte[] tmp = ScreenCapture.QuickLZ.decompress(buffer);
        //   MemoryStream ms = new MemoryStream(tmp);
        //   pteRemoting.Image = Image.FromStream(ms);
        //   timer1.Enabled = true;
        //   ChannelServices.UnregisterChannel(chan);

        //   //}
        //   //catch (Exception) { Stop(); };
        //}


        void Stop()
        {
            //MessageBox.Show(PathWallPaper);
            // obj.ReSetWallpaper(PathWallPaper, 2, 0);
            try
            {
                conect = false;
                timer1.Enabled = false;
                ChannelServices.UnregisterChannel(chan);
            }
            catch { }
            // RemotingServices.Disconnect(obj);


        }
        
        
        private void frmRemoting_Load(object sender, EventArgs e)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            //devMain.StopListen();
            try
            {
                URI = "Tcp://" + this.IP + ":7700/MyCaptureScreenServer";
                chan = (TcpChannel) TcpChanelHelper.GetChannel(rnd.Next(6010, 6999), true);

                ChannelServices.RegisterChannel(chan, false);
                

                obj = (ScreenCapture.ScreenCapture)Activator.GetObject(typeof(ScreenCapture.ScreenCapture), URI);
                conect = true;
                timer1.Enabled = true;
            }
            catch {
                ChannelServices.UnregisterChannel(chan);
            }
            // Start(); 

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Start();
            //try
            //{
                conect = true;
                byte[] buffer = obj.GetDesktopBitmapBytes(Screen.PrimaryScreen.Bounds.Width-10,Screen.PrimaryScreen.Bounds.Height-55);
                byte[] tmp = ScreenCapture.QuickLZ.decompress(buffer);
                MemoryStream ms = new MemoryStream(tmp);
                pteRemoting.Image = Image.FromStream(ms);

               

            //}
            //catch
            //{
            //    Stop();
                //PTMSDataContext db = new PTMSDataContext();
                //Computer c = db.Computers.SingleOrDefault(cp => cp.ComputerIP == this.IP);
                //if (c != null)
                //{
                //   MessageBox.Show("Máy " + c.ComputerNumber + " vừa ngắt kết nối!");
                //}
                //else
                //{
                //   MessageBox.Show(this.IP + " vừa ngắt kết nối!");
                //}
            //}

        }

        private void pteRemoting_MouseMove(object sender, MouseEventArgs e)
        {
            if (conect == true)
            {
                obj.MoveMouse(e.X * desktopClient.Width / (Screen.PrimaryScreen.Bounds.Width - 10), e.Y * desktopClient.Height / (Screen.PrimaryScreen.Bounds.Height - 55));
            }
        }

        private void pteRemoting_MouseDown(object sender, MouseEventArgs e)
        {

            if (conect == true)
            {
               
                obj.PressOrReleaseMouseButton(true, e.Button == MouseButtons.Left, e.X * desktopClient.Width / (Screen.PrimaryScreen.Bounds.Width - 10), e.Y * desktopClient.Height / (Screen.PrimaryScreen.Bounds.Height - 55));
            }
        }

        private void pteRemoting_MouseUp(object sender, MouseEventArgs e)
        {
            if (conect == true)
            {
                obj.PressOrReleaseMouseButton(false, e.Button == MouseButtons.Left, e.X * desktopClient.Width / (Screen.PrimaryScreen.Bounds.Width - 10), e.Y * desktopClient.Height / (Screen.PrimaryScreen.Bounds.Height - 55));
            }
        }



        // private int tempHeight = 0, tempWidth = 0;
        // private int FixHeight = 1024, FixWidth = 768;

        private void frmRemoting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            Tool cls = new Tool();
            cls.ShowFormWatchScreen();
            frmWatchScreen.ReloadScreen = true;
        }


        private void tsmiLockkeyandMouse_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {

        }

        private void frmRemoting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmRemoting_KeyUp(object sender, KeyEventArgs e)
        {
            if (conect == true)
            {

                e.Handled = true;
                obj.SendKeystroke((byte)e.KeyCode, (byte)MapVirtualKey((uint)e.KeyCode, 0), false, false);
            }

        }

        private void frmRemoting_KeyDown(object sender, KeyEventArgs e)
        {
            if (conect == true)
            {
                e.Handled = true;
                obj.SendKeystroke((byte)e.KeyCode, (byte)MapVirtualKey((uint)e.KeyCode, 0), true, false);
            }
        }
    }
}