using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.IO;

using Microsoft.Win32;
using System.Management;
using System.Management.Instrumentation;


namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmImformation : DevExpress.XtraEditors.XtraForm
    {
        public frmImformation()
        {
            InitializeComponent();
        }
        string pass;
        DataClassesDataContext db = new DataClassesDataContext();
        private void frmImformation_Load(object sender, EventArgs e)
        {
            //lấy pass 
            pass = "123";
            grImformation.Enabled = false;

            //hiển thị tên phòng và số máy
            if (File.Exists(Application.StartupPath + "/Thongtin.txt"))//nếu đã có thì đọc để hiển thị thông tin
            {
                StreamReader doc = new StreamReader("Thongtin.txt");
                string s = doc.ReadLine();//dòng đầu tiên
                doc.Close();

                cboRoom.Text = s.Split('#')[0];
                txtComputerNumber.Text = s.Split('#')[1];


            }
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (pass == txtPass.Text)
            {
                grImformation.Enabled = true;

                txtComputerNumber.Enabled = false;

                //Load phòng
                var list = from r in db.PracticeRooms select r;
                foreach (var i in list)
                {
                    cboRoom.Properties.Items.Add(i.RoomName);
                }

            }
            else
            {
                error.SetError(txtPass, "Mật khẩu không đúng. Hãy nhập lại!");
            }
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //LƯU THÔNG TIN TẠI MÁY
            StreamWriter ghi = new StreamWriter("Thongtin.txt");
            //lưu tên phòng và số máy
            ghi.WriteLine(cboRoom.Text + "#" + txtComputerNumber.Text);

            //lưu lại cấu hình
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
                ghi.WriteLine(code + "#" + name + "#" + firm + "#" + config);

            }

            ghi.Close();
            this.Close();
            //LƯU THÔNG TIN LÊN CSDL
            for (int i = 0; i < m.GetLength(0); i++)
            {
                code = m[i, 0];
                name = m[i, 1];
                firm = m[i, 2];
                config = m[i, 3];
                TemporaryImformation ti = new TemporaryImformation();
                ti.ComputerCode = "CS01" + cboRoom.Text + txtComputerNumber.Text;
                ti.EquipmentCode = code;
                ti.EquipmentName = name;
                ti.Firm = firm;
                ti.Configuration = config;
                db.TemporaryImformations.InsertOnSubmit(ti);
                db.SubmitChanges();
            }


        }





        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cboRoom.Text != "")
            {
                txtComputerNumber.Enabled = true;


            }
            else
                txtComputerNumber.Enabled = false;
        }



        private void txtComputerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}