using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Linq;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void XtraForm1_Load(object sender, EventArgs e)
        {
           // //ScreenCapture.ScreenCapture sc = new ScreenCapture.ScreenCapture();
           // //string[,] m = new string[10, 4];
           // //m = sc.GetConfig();
           // //for (int i = 0; i < 10; i++)
           // //{
           // //    //lLoad thông tin lên gridView
           // //    dgvConfiguration.Rows.Add(m[i, 0], m[i, 1], m[i, 2], m[i, 3]);
           // //}



           // //sau khi đăng nhập thành công thì lưu tên của sinh viên vào (sinh viên cuối)
           // StreamWriter ghi = new StreamWriter("LastUser.txt");
           // //ghi.WriteLine(masv+"#"+tensv)<<<<<<<<<<<<<===========
           // ghi.WriteLine("123213#đinh văn hiển");//tam
           // ghi.Close();



           // //trong khi load của form kết nối
           // //nếu chưa có file chứ thông tin tên phòng thì hiển thị form để nhập
           // if (!File.Exists(Application.StartupPath + "/Thongtin.txt"))
           // {
           //     frmImformation form = new frmImformation();
           //     form.ShowDialog();
           // }

            

           // //kiểm tra các thay đổi và thông báo về cho xưởng trưởng
           // StreamReader doc = new StreamReader("Thongtin.txt");
           // string s = doc.ReadLine();string tt=s;//dòng đầu tiên    
           // //đọc cấu hình của máy hiện tại
           // ScreenCapture.ScreenCapture sc = new ScreenCapture.ScreenCapture();
           // string[,] m = sc.GetConfigA();
           // //so sánh với cấu hình được lưu
           // string code, name, firm, config;
           //for (int i = 0; i < m.GetLength(0); i++)
           // {
           //     s = doc.ReadLine();

           //     code = s.Split('#')[0];
           //     name = s.Split('#')[1];
           //     firm = s.Split('#')[2];
           //     config = s.Split('#')[3];
           //     //so sánh
           //     if (code!=m[i,0]||name!=m[i,1]||firm!=m[i,2]||config!=m[i,3])
           //     {
           //         Notice nt = new Notice();
           //         nt.ComputerCode = tt;
           //         nt.Time = DateTime.Now;
           //         nt.Message = "Thay đổi " + name;
           //         nt.OldConfiguration = s.Split('#')[0] + " " + s.Split('#')[1] + " " + s.Split('#')[2] + " " + s.Split('#')[3];
           //         nt.NewConfiguration = code + " " + name + " " + firm + " " + config;
           //         if (lastUser != null && lastUser != "")
           //             nt.LastUser = lastUser.Split('#')[0] + " " + lastUser.Split('#')[1];
           //         db.Notices.InsertOnSubmit(nt);
           //         db.SubmitChanges();
           //     }
           // }
                
           // doc.Close();
           // //LƯU THÔNG TIN TẠI MÁY
           // StreamWriter ghidl = new StreamWriter("Thongtin.txt");
           // //lưu tên phòng và số máy
           // ghidl.WriteLine(tt);

           // //lưu lại cấu hình
           // //lấy cấu hình của máy
           // for (int i = 0; i < m.GetLength(0); i++)
           // {
           //     code = m[i, 0];
           //     name = m[i, 1];
           //     firm = m[i, 2];
           //     config = m[i, 3];
           //     ghidl.WriteLine(code + "#" + name + "#" + firm + "#" + config);

           // }

           // ghidl.Close();




           // //lấy thông tin của người sử dụng cuối cùng cuối cùng
           // string lastUser = "";
           // if (File.Exists(Application.StartupPath + "/LastUser.txt"))
           // {
           //     StreamReader docUser = new StreamReader("LastUser.txt");
           //     lastUser = docUser.ReadLine();
           //     docUser.Close();
           // }

           // //trong sự kiện load của form main
           // if (File.Exists(Application.StartupPath + "/Thongtin.txt"))//nếu đã có thì đọc để hiển thị thông tin
           // {
           //     StreamReader doctt = new StreamReader("Thongtin.txt");
           //     string x = doctt.ReadLine();//dòng đầu tiên             

           //     lblRoom.Text += x.Split('#')[0];
           //     lblNumber.Text += x.Split('#')[1];

           //     string studencode=lastUser.Split('#')[0];
           //     lblCode.Text +=studencode ;
           //     lblName.Text += lastUser.Split('#')[1];
           //     lblClass.Text += db.Students.SingleOrDefault(s=>s.StudentCode==studencode).Class.ClassName;

           //     doctt.Close();
           // }
           

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("Select " + textBox1.Text + " from Win32_CDROMDrive");

            //foreach (ManagementObject processor in searcher1.Get())
            //{
            //    textBox2.Text = processor.GetPropertyValue(textBox1.Text).ToString();

            //}
            ////MessageBox.Show("ok");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kiểm tra và lưu thông tin vào file "Thông tin"(khi chương trình hoạt động)
            //nếu là lần đâu tiên  thì tạo ra file

        }
    }
}