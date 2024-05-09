using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using PracticeTeachingManagementSystem_Student.Helpers;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmServerRemote : Form
    {
        public frmServerRemote()
        {
            InitializeComponent();
        }

        private void frmServerRemote_Load(object sender, EventArgs e)
        {
            TcpChannel chan = (TcpChannel)TcpChanelHelper.GetChannel(7700, true);
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(Type.GetType("ScreenCapture, ScreenCapture"), "MyCaptureScreenServer", WellKnownObjectMode.Singleton);
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Hide();
            
        }
    }
}
