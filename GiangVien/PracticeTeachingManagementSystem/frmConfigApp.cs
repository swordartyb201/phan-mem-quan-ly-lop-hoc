using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Xml;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
using System.Management;
using System.IO;
namespace PracticeTeachingManagementSystem
{
   public partial class frmConfigApp : DevExpress.XtraEditors.XtraForm
   {
      public frmConfigApp()
      {
         InitializeComponent();
      }
     // Server serSQL;
      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {

      }

      private void btnTest_Click(object sender, EventArgs e)
      {

         string strCon = @"Data Source=DESKTOP-M63MHF7;Initial Catalog=PTMS;Integrated Security=True";
         if (rbtSQL.Checked == true)
            strCon = "Data Source=" + cboServerName.Text + ";Initial Catalog=" + cboDB.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPass.Text;
         else
            strCon = "Data Source=" + cboServerName.Text + ";Initial Catalog=" + cboDB.Text + "Integrated Security=True";
         try
         {
            System.Data.SqlClient.SqlDataAdapter sqlAdap = new System.Data.SqlClient.SqlDataAdapter("select * from Computers", strCon);
            DataTable dt = new DataTable();
            sqlAdap.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
               MessageBox.Show("Thành công!");
            }
         }
         catch { MessageBox.Show("Không kết nối được SQL!"); };
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         try
         {
            Program.iP = txtIPServer.Text;
            string strCon = "Data Source=DESKTOP-M63MHF7;Initial Catalog=PTMS;Integrated Security=True";
            if (rbtSQL.Checked == true)
               strCon = "Data Source=" + cboServerName.Text + ";Initial Catalog=" + cboDB.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPass.Text;
            else
               strCon = "Data Source=" + cboServerName.Text + ";Initial Catalog=" + cboDB.Text + "Integrated Security=True";
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\App.config");
            XmlNode appSettingsNode =
               xmlDoc.SelectSingleNode("/configuration/connectionStrings");
            foreach (XmlNode childNode in appSettingsNode)
               childNode.Attributes["connectionString"].Value = strCon;
            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\App.config");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            
            string path = @"Software\Microsoft\Windows";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
            key.SetValue("PTMS", strCon + "," + txtIPServer.Text.Trim());
            key.Close();
            Application.Restart();
         }
         catch (Exception ex) { MessageBox.Show(ex.Message); }
      }

      private void rbtSQL_CheckedChanged(object sender, EventArgs e)
      {
         if (rbtSQL.Checked)
         {
            txtPass.Enabled = true;
            txtUser.Enabled = true;
         }
         else
         {
            txtPass.Enabled = false;
            txtUser.Enabled = false;
         }
      }
    ////  void LoadDBName()
    //  {
    //     cboDB.Items.Clear();
    //     if (cboServerName.Text != "")
    //     {
    //        ServerConnection srvCon = new ServerConnection(cboServerName.Text);
    //        if (rbtSQL.Checked == true)
    //        {
    //           srvCon.LoginSecure = false;
    //           srvCon.Password = txtPass.Text.Trim();
    //           srvCon.Login = txtUser.Text.Trim();
    //           serSQL = new Server(srvCon);
    //        }
    //        else
    //        {
    //           srvCon.LoginSecure = true;
    //           serSQL = new Server(srvCon);
    //        }

    //        if (serSQL.State.ToString() == "Existing")
    //        {
    //           foreach (Database dbser in serSQL.Databases)
    //           {
    //              cboDB.Items.Add(dbser.Name);
    //           }

    //        }
    //     }
    //     else
    //     {
    //        MessageBox.Show("Bạn chưa chọn ServerName!");
    //     }
    //  }
      private void frmConfigApp_Load(object sender, EventArgs e)
      {
         //bool ok = false;
         //StreamReader sr = File.OpenText(@"Config.txt");
         //string xau = sr.ReadLine();

         //if (xau != null && xau != "")
         //{
         //   string str = xau.Split(',')[0];
         //   try
         //   {
         //      System.Data.SqlClient.SqlDataAdapter sqlAdap = new System.Data.SqlClient.SqlDataAdapter("select * from Computers", str);
         //      DataTable dt1 = new DataTable();
         //      sqlAdap.Fill(dt1);
         //      if (dt1.Rows.Count > 0)
         //      {
         //         ok = true;
         //      }
         //   }
         //   catch { ok = false; }
         //}
         //if (ok == false)
         //{
         //DataTable dt = SmoApplication.EnumAvailableSqlServers(true);

         //if (dt.Rows.Count > 0)
         //{

         //   // Loop through each server in the DataTable

         //   foreach (DataRow dr in dt.Rows)
         //   {
         //      //cmbsrv_name is name of combo box in //which all server name will be loaded..

         //      cboServerName.Items.Add(dr["Name"]);

         //   }

         //}
         //else
         //{
         //   DialogResult dr = MessageBox.Show("Không tìm thấy Server trên máy bạn!\n Bạn có muốn thoát khỏi ứng dụng này?", "Quản Lý Phòng Máy!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
         //   if (dr == DialogResult.OK)
         //   {
         //      Application.ExitThread();
         //      Application.Exit();
         //   }
         //}
         //}
      }

      private void btnTest_Click_1(object sender, EventArgs e)
      {
         //LoadDBName();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void cboServerName_Validated(object sender, EventArgs e)
      {

      }

      private void cboServerName_SelectedIndexChanged(object sender, EventArgs e)
      {
         // LoadDBName();
      }

      private void txtIPServer_Validated(object sender, EventArgs e)
      {
         cboServerName.Text = txtIPServer.Text;
      }

      private void frmConfigApp_FormClosed(object sender, FormClosedEventArgs e)
      {
          Application.Exit();
      }
   }
}