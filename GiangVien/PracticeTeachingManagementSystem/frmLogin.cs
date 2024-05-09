using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Data.SqlClient;

namespace PracticeTeachingManagementSystem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        Tool cs = new Tool();
        public static string teacherCode;
        public static string FullName;
        public static string IP;
        public static bool ktr = false;
        PTMSDataContext db = new PTMSDataContext();

        //public void AutoLogin()
        //{
        //    txtLogin.Text = "admin";
        //    txtPass.Text = "1";
        //    Thread.Sleep(1000);
        //    btnLogin_Click(null, null);
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cs.CheckEmptyTxt1(txtLogin, "Chua nhap", err) == false && cs.CheckEmptyTxt1(txtPass, "Chua nhap", err) == false)
            {
               try
               {
                   Account c = db.Accounts.SingleOrDefault(cp => cp.UserName.Trim().ToString() == txtLogin.Text && cp.PassWord.Trim().ToString() == txtPass.Text);
                  if (c != null)
                  {
                      teacherCode = c.Teacher.TeacherCode;
                      FullName = c.Teacher.TeacherName;
                      ktr = true;
                      this.Close();
                     
                  }
                  else
                  {
                     XtraMessageBox.Show("Đăng nhập không thành công !", "Hệ thống hỗ trợ giảng dạy thực hành và quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
               }
               catch(Exception ex)
               {
                   MessageBox.Show("Lỗi kết nối CSDL");
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtLogin_EditValueChanged(object sender, EventArgs e)
        {
            if (cs.CheckEmptyTxt1(txtLogin, "Chua nhap", err) == false)
            { err.Dispose(); }
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {

            if (cs.CheckEmptyTxt1(txtPass, "Chua nhap", err) == false)
            { err.Dispose(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}