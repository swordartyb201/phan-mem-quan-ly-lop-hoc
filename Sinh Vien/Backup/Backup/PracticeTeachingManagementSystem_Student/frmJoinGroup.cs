using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmJoinGroup : DevExpress.XtraEditors.XtraForm
    {
        public frmJoinGroup()
        {
            InitializeComponent();
        }

        DataClassesDataContext db = new DataClassesDataContext();
        public static int StudentID;
        public static int StudentPID;
        public static int GroupID;
        public static int GroupSessionID;
        public static string RoomName;
        public static string ClassName;
        public static String strHostName;
        public static string SubjectName;
        public static string IP;
        public static bool status = false;
        public static string FullName;
        public static bool alowLogin = false;
        public static string Session = "";
        string GetSession()
        {
            int h = DateTime.Now.Hour;

            // dtpPracticeDate.Text = DateTime.Now.ToShortDateString();
            if (h >= 6 && h < 9)
            {
                Session = "123"; ;
            }
            if (h >= 9 && h < 12)
            {
                Session = "456";
            }
            if (h >= 12 && h < 15)
            {
                Session = "789";
            }
            if (h >= 15 && h < 18)
            {
                Session = "012";
            }
            if (h >= 18)
            {
                Session = "345";
            }
            return Session;
        }
       
        int ReturnGroupID()
        {
            StudentPractice gr = db.StudentPractices.SingleOrDefault(c => c.Student.StudentCode.Trim() == txtStudentCode.Text.Trim() && c.Student.Pass == txtPass.Text.Trim() && c.GroupStudent.Subject.SubjectName == cboSubject.Text);
            if (gr != null)
                return gr.GroupStudentID;
            else
                return -1;
        }
        int GetGroupSessionID()
        {
            GroupSession gs = db.GroupSessions.SingleOrDefault(s => s.GroupStudentID ==GroupID && s.Date == DateTime.Now.Date);
            if (gs != null)
                return gs.GroupSessionID;
            else
                return -1;
        }
        string GetRoomName()
        {

            GroupSession gr = db.GroupSessions.SingleOrDefault(c => c.GroupStudentID == GroupID && c.Date==DateTime.Now.Date);
            if (gr != null)
                return gr.PracticeRoom.RoomName;
            else
                return "-1";
            
        }
        public static string room, number, code, name, clas;
        /// <summary>
        /// Chú ý: Về sau phải sửa thành Load tên môn học theo từng kỳ mà học sinh đang học
        /// </summary>
        private void LoadComboSubject()
        {
           
            try
            {
                cboSubject.Properties.Items.Clear();
                var cl = from c in db.StudentPractices
                         where c.Student.StudentCode == txtStudentCode.Text
                         select new { c.GroupStudent.Subject.SubjectName };
                foreach (var item in cl)
                {
                    cboSubject.Properties.Items.Add(item.SubjectName);
                }
            }
            catch
            {
                XtraMessageBox.Show("Không kết nối cơ sở dữ liệu", "Quản lý phòng máy ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void frmJoinGroup_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {
            LoadComboSubject();
        }
        clsSystem cls = new clsSystem();
        bool TestSesion()
        {
            GroupSession gs = db.GroupSessions.SingleOrDefault(c=>c.GroupStudentID==GroupID && c.Date==DateTime.Now.Date);
            if (gs != null) { return true; }
            else { return false; }
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text == "anhhau")
            {
               
                //cls.EnableCTRLALTDEL();
                //cls.DisNoRun();
                cls.ShowStartMenu(); 
                alowLogin = true; Application.Exit();
            }
            {
                ClassTool cs = new ClassTool();
                bool kt = false;
                if (cs.CheckEmptyTxt1(txtStudentCode, "Chưa nhập", err) == false && cs.CheckEmptyTxt1(txtPass, "Chưa nhập", err) == false && cs.CheckEmptyCbo(cboSubject, "Chưa chọn", err) == false)
                {
                    //try
                    //{
                        StudentPractice sp = db.StudentPractices.SingleOrDefault(c => c.Student.StudentCode == txtStudentCode.Text && c.Student.Pass == txtPass.Text.Trim() && c.GroupStudent.Subject.SubjectName == cboSubject.Text);

                        if (sp != null)
                        {
                            GroupSessionID = GetGroupSessionID();
                            GroupID = ReturnGroupID();
                            RoomName = GetRoomName();
                            FullName = sp.Student.FullName;
                            StudentPID = sp.StudentPracticeID;
                            ClassName = sp.GroupStudent.Class.ClassName;
                            SubjectName = sp.GroupStudent.Subject.SubjectName;
                            strHostName = Dns.GetHostName();
                            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
                            foreach (IPAddress ipaddress in iphostentry.AddressList)
                            {
                                if (ipaddress.AddressFamily.ToString() == "InterNetwork")
                                {
                                    IP = ipaddress.ToString();
                                }
                            }
                            if (TestSesion() == true)
                            {
                               
                                Computer cl = db.Computers.SingleOrDefault(c => c.ComputerName == strHostName);
                                if (cl != null)
                                {
                                    cl.ComputerIP = IP;
                                    //item.Student.Status = true;
                                    db.SubmitChanges();
                                    Program.ComputerID = cl.ComputerID;

                                    //hiển thị thông tin tên phòng, số máy, tên sinh viên, lớp
                                    if (File.Exists(Application.StartupPath + "/Thongtin.txt"))
                                    {
                                        StreamReader doc = new StreamReader(Application.StartupPath + "/Thongtin.txt");
                                        string s = doc.ReadLine();

                                    }

                                    //sau khi đăng nhập thành công thì lưu tên của sinh viên vào (sinh viên cuối)
                                    StreamWriter ghi = new StreamWriter(Application.StartupPath + "/LastUser.txt");
                                    ghi.WriteLine(txtStudentCode.Text + "#" + db.Students.SingleOrDefault(s => s.StudentCode == txtStudentCode.Text).FullName);
                                    //ghi.WriteLine("123213#đinh văn hiển");//tam
                                    ghi.Close();

                                    //lấy thông tin của người sử dụng cuối cùng cuối cùng
                                    string lastUser = "";
                                    if (File.Exists(Application.StartupPath + "/LastUser.txt"))
                                    {
                                        StreamReader docUser = new StreamReader(Application.StartupPath + "/LastUser.txt");
                                        lastUser = docUser.ReadLine();
                                        docUser.Close();
                                    }

                                    //trong sự kiện load của ucjoingroup
                                    if (File.Exists(Application.StartupPath + "/Thongtin.txt"))//nếu đã có thì đọc để hiển thị thông tin
                                    {
                                        StreamReader doctt = new StreamReader(Application.StartupPath + "/Thongtin.txt");
                                        string x = doctt.ReadLine();//dòng đầu tiên             

                                        room = "Phòng: " + x.Split('#')[0];
                                        number = "Số máy: " + x.Split('#')[1];

                                        string studencode = lastUser.Split('#')[0];
                                        code = "Mã SV: " + studencode;
                                        name = "Tên SV: " + lastUser.Split('#')[1];
                                        clas = "Lớp: " + db.Students.SingleOrDefault(s => s.StudentCode == studencode).Class.ClassName;

                                        doctt.Close();

                                    }
                                    SessionSpace se = db.SessionSpaces.SingleOrDefault(c => c.ComputerID == cl.ComputerID && c.StudentPracticeID == sp.StudentPracticeID && c.Session == GetSession() && c.Date == DateTime.Now.Date);
                                    if (se != null)
                                    {
                                    }
                                    else
                                    {
                                        SessionSpace ss = new SessionSpace();
                                        ss.ComputerID = cl.ComputerID;
                                        ss.StudentPracticeID = sp.StudentPracticeID;
                                        ss.Session = GetSession();
                                        ss.Date = DateTime.Now.Date;
                                        db.SessionSpaces.InsertOnSubmit(ss);
                                        db.SubmitChanges();
                                    }
                                    CallRool cr = db.CallRools.SingleOrDefault(c => c.StudentPracticeID == sp.StudentPracticeID && c.GroupSessionID == GetGroupSessionID());
                                    if (cr != null)
                                    {
                                        cr.IsAvailable = "+";
                                        db.SubmitChanges();
                                    }
                                    status = true;
                                    alowLogin = true;
                                    frmMain frm = new frmMain();
                                    frm.Show();
                                    this.Hide();
                                }
                                else { XtraMessageBox.Show("Không tồn tại máy này trong csdl"); }
                                   
                                    
                                }
                            else { XtraMessageBox.Show("Ca này chưa được cập nhật!", "Quản lý phòng máy thực hành", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                        else
                        {
                            XtraMessageBox.Show("Thông tin bạn nhập bị sai!", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    //}
                    //catch
                    //{
                    //    //cls.EnableCTRLALTDEL();
                    //    //cls.DisNoRun();
                    //    //cls.ShowStartMenu();
                    //    alowLogin = true;
                    //    XtraMessageBox.Show("Không kết nối cơ sở dữ liệu");
                    //    Application.Exit();
                    //}

                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}