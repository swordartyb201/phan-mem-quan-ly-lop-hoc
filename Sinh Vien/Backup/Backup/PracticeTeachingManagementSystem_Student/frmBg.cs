using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Management;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmBg : Form
    {
        clsSystem cls = new clsSystem();

       

        public frmBg()
        {
            InitializeComponent();
        }

        private void frmBg_MouseClick(object sender, MouseEventArgs e)
        {
           
            frmJoinGroup frm = new frmJoinGroup();
            frm.ShowDialog();
        }

        private void frmBg_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmJoinGroup frm = new frmJoinGroup();
            frm.ShowDialog();
        }

        int dem = 0;
       
        private void frmBg_Load(object sender, EventArgs e)
        {
            //Download source code mien phi tai Sharecode.vn
            //RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //rkApp.SetValue("QuanLyPhongMay", Application.ExecutablePath.ToString());
            //cls.NoRun();
            //cls.Kill_Key_Sys();
            //cls.KillStartMenu();
            //cls.KillCtrlAltDelete();
       
         
        }

        string tieude = " Software develop group -  utehy    ";
        int i = 0, tg = 0;
        //Lay ten tieu de` cua Form
        public void TitleRun()
        {
            //Lam chu nha'y nha'y
            if (i >= tieude.Length - 1)
            {
                if (tg == 15)
                {
                    i = 0; tg = 0;
                    lbltitle.Text = "";
                }
                tg++;
                if (tg % 2 != 0)
                    lbltitle.Text = "";
                else
                    lbltitle.Text = " Software develop group -  utehy    ";
            }

            //Lam chu chay
            if (i < tieude.Length - 1)
            {
                while(tieude[i]==' '&&i < tieude.Length - 1) i++;
                lbltitle.Text=tieude.Substring(0, i);
                i++;
            }
        }

        public void InfoRun()
        {
            string tglb1, tglb11, tglb12;
            tglb1 = lblInf.Text;
            tglb11 = tglb1.Substring(0, 1);
            tglb12 = tglb1.Substring(1, tglb1.Length - 1);
            lblInf.Text= tglb12 + tglb11;
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            TitleRun();
            InfoRun();
            if (frmJoinGroup.alowLogin == true)
            {
                cls.ShowStartMenu();
                //cls.EnableCTRLALTDEL();
                this.Hide();
                timer2.Enabled = false;
                timer2.Dispose();
                
            }
        }
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
        private void cboRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cboStatus.Text == "Log off")
            {
                shutDown(ShutDown.ForcedLogOff);
            }
            if (cboStatus.Text == "Restart")
            {
                shutDown(ShutDown.ForcedReboot);
            }

            if (cboStatus.Text == "Shutdown")
            {
                shutDown(ShutDown.ForcedShutdown);
                
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            shutDown(ShutDown.ForcedShutdown);
        }

        private void frmBg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmJoinGroup.alowLogin == false)
            {
                e.Cancel = true;
            }
        }

    }
}
