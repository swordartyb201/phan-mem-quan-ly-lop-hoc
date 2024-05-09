using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System.Management;
using System.Management.Instrumentation;

using System.IO;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmconfiguration : DevExpress.XtraEditors.XtraForm
    {
        public frmconfiguration()
        {
            InitializeComponent();
        }

        private void frmconfiguration_Load(object sender, EventArgs e)
        {


            //Download source code mien phi tai Sharecode.vn
            //Load thông tin phòng, số máy
            if (File.Exists(Application.StartupPath + "/Thongtin.txt"))//nếu đã có thì đọc để hiển thị thông tin
            {
                StreamReader doc = new StreamReader("Thongtin.txt");
                string s = doc.ReadLine();//dòng đầu tiên
                doc.Close();

                lblRoom.Text += s.Split('#')[0];
                lblNumber.Text += s.Split('#')[1];
            }
            //Load thông tin cấu hình máy tính

            DataTable dt=new DataTable();
            dt.Columns.Add("EquipmentCode");
            dt.Columns.Add("EquipmentName");
            dt.Columns.Add("Firm");
            dt.Columns.Add("Configuration");
            string code, name, firm, config;
            //lấy cấu hình của máy
            ScreenCapture.ScreenCapture sc = new ScreenCapture.ScreenCapture();
            string[,] m = sc.GetConfigA();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                code = m[i, 0];
                name = m[i, 1];
                firm = m[i, 2];
                config = m[i, 3];
                dt.Rows.Add(code, name, firm, config);

            }
                //Load thông tin lên gridView
                gcConfiguration.DataSource=dt;
        }
    }
}