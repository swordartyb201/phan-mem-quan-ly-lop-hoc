using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace PracticeTeachingManagementSystem
{
   public partial class frmJoinGroup : DevExpress.XtraEditors.XtraForm
   {
      public frmJoinGroup()
      {
         InitializeComponent();
      }
      public static bool connectGroup = false;
      Tool clsTool = new Tool();
      PTMSDataContext db = new PTMSDataContext();
      public static int GroupID;
      public static int GroupSessionID;
      public static string ClassName;
      public static string SubjectName;
      public static string RoomName;
      public static string GroupName;
      public static string Year;
      public static string HalfYear;
      public static string Total;
      public static string Date;
     // public static string Sesion;
      public static string TeacherName;
      public static string IP;
      public static string hoststring;

      #region Truyền dữ lieuj sang các form khác!
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
       
      //string ss()
      //{

      //   return txtSession.Text;
      //}
      int GetGroupID()
      {
         GroupStudent gs = db.GroupStudents.SingleOrDefault(c => c.GroupName == cboGroup.Text.Trim() && c.Class.ClassName == cboClass.Text.Trim() && c.Subject.SubjectName == cboSubject.Text.Trim());

         if (gs != null)
         {
            return gs.GroupStudentID;
         }
         else
            return -1;
      }
      void LoadWeekPractic()
      {
          //cboWeek.Properties.Items.Clear(); cboWeek.Text = "";
          //var cl = (db.GroupSessions.Where(c => c.GroupID == GetGroupID())).Distinct();
          //foreach (var item in cl)
          //{
          //    cboWeek.Properties.Items.Add(item.Week);
          //}
      }
      void LoadRoom()
      {
          cboRoom.Text = "";
          cboRoom.Properties.Items.Clear();
          var room = (from c in db.GroupSessions
                     where c.GroupStudentID==GetGroupID()
                     select new { c.PracticeRoom.RoomName }).Distinct();
          foreach (var item in room)
          {
              cboRoom.Text = item.RoomName.ToString();
          }
          var room1 = from c in db.PracticeRooms
                      select new { c.RoomName };
          foreach (var item in room1)
          {
              cboRoom.Properties.Items.Add(item.RoomName);
          }

      }
      
      /// <summary>
      /// Kiểm tra xem ca thực hành của nhóm đã tồn tại chưa
      /// </summary>
      /// <returns></returns>
      bool GetGroupSessionID()
      {
            return true;
            // TODO: FIX ERROR
          bool kt = false;
         var gs = db.GroupSessions
                .Where(c => c.GroupStudentID == GetGroupID() && c.Date == DateTime.Now.Date && (c.StartSession.ToString() + (c.StartSession + 1).ToString()+(c.StartSession+2).ToString())==GetSession());
         
         foreach (var item in gs)
         {
             kt = true; break; 
         }
         return kt;
      }
    
      
      #endregion
      #region Load Lên combobox, kiểm tra dữ liệu, Sự kiện của Combobox
      int RoomID()
      {
         PracticeRoom p = db.PracticeRooms.Single(pr => pr.RoomName == cboRoom.Text);
         return p.RoomID;
      }
     
      string LoadSession()
      {
          int h = DateTime.Now.Hour;
          string  ss="";
          if (h >= 6 && h < 9)
          {
              ss = "123"; ;
          }
          if (h >= 9 && h < 12)
          {
              ss = "456";
          }
          if (h >= 12 && h < 15)
          {
            ss = "789";
          }
          if (h >= 15 && h < 18)
          {
             ss = "012";
          }
          if (h >= 18 && h < 22)
          {
            ss = "345";
          }
          return ss;
      }
      void LoadComboClass()
      {
         cboSubject.Properties.Items.Clear();
         var grs = (from c in db.GroupSessions
                    where c.GroupStudent.Teacher.TeacherCode == frmLogin.teacherCode
                    select new { c.GroupStudent.Class.ClassName }).Distinct();
         foreach (var itm in grs)
         {
            cboClass.Properties.Items.Add(itm.ClassName);
         }

      }
      void LoadComboSubject()
      {
          cboSubject.Text = "";
             cboSubject.Properties.Items.Clear();
                 var grs = (from c in db.GroupSessions
                           where c.GroupStudent.Class.ClassName==cboClass.Text && c.GroupStudent.Teacher.TeacherCode==frmLogin.teacherCode
                           select new { c.GroupStudent.Subject.SubjectName }).Distinct();
                 foreach (var item in grs)
                 {
                     cboSubject.Properties.Items.Add(item.SubjectName);
                 }
               
      }
      void LoadComboGroup()
      {
         cboGroup.Properties.Items.Clear();
         var gr = (from g in db.GroupSessions
                  where (g.GroupStudent.Class.ClassName == cboClass.Text && g.GroupStudent.Subject.SubjectName == cboSubject.Text)
                  select new { g.GroupStudent.GroupName }).Distinct();
         foreach (var q in gr)
         {
            cboGroup.Properties.Items.Add(q.GroupName);
         }
      }
      private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
      {
         LoadComboSubject();
      }

      private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
      {
         LoadComboGroup();
      }

      private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
      {
        
         LoadRoom();
      }
      #endregion
      private void frmJoinGroup_Load(object sender, EventArgs e)
      {
         cboClass.Focus();
         LoadComboClass();
         LoadSession();
            Session = GetSession();
      }
     
      bool TestSession()
      {
          //HistoryTeach ht = db.HistoryTeaches.SingleOrDefault(c => c.GroupID == GetGroupID() && c.Date == DateTime.Now.ToShortDateString() && c.Session == Session());
          //if (ht != null)
          //{
          //    return true;
          //}
          //else
          //{
          //    return false;
          // }
          return false;
      }
   
      private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!clsTool.CheckEmptyCbo(cboClass, "Bạn chưa chọn lớp", err) && !clsTool.CheckEmptyCbo(cboSubject, "Bạn chưa chọn môn học", err) && !clsTool.CheckEmptyCbo(cboGroup, "Bạn chưa chọn nhóm", err) && !clsTool.CheckEmptyCbo(cboRoom, "Bạn chưa chọn nhóm", err))
            {
                if (GetGroupSessionID() ==true)
                {

                    //Hiển các Form Điểm danh, xem màn hình máy sinh viên...
                   
                    db = new PTMSDataContext();
                    GroupID = GetGroupID();
                    GroupName = cboGroup.Text.Trim();
                    ClassName = cboClass.Text.Trim();
                    SubjectName = cboSubject.Text.Trim();
                    RoomName = cboRoom.Text.Trim();
                    GroupStudent gr = db.GroupStudents.SingleOrDefault(g=>g.GroupStudentID==GroupID);
                    if (gr != null)
                    {
                        Year = gr.Year;
                        HalfYear = gr.HaflYear;
                    }
                    else
                    {
                        Year = ""; HalfYear = "";
                    }
                    //Total = GetTotal();
                    //Date = cbo.Text;
                    //Sesion = ss();
                  
                    Account tc = db.Accounts.SingleOrDefault(cp => cp.Teacher.TeacherCode == frmLogin.teacherCode);
                    if (tc != null)
                    {

                        hoststring = Dns.GetHostName();
                        IPHostEntry iphostentry = Dns.GetHostByName(hoststring);
                        foreach (IPAddress ipaddress in iphostentry.AddressList)
                        {

                            if (ipaddress.AddressFamily.ToString() == "InterNetwork")
                            {

                                //tc.IP = ipaddress.ToString();
                                IP = ipaddress.ToString();
                                frmLogin.FullName = tc.Teacher.TeacherName;
                                TeacherName = tc.Teacher.TeacherName;
                                tc.IP = IP;
                                frmLogin.IP = ipaddress.ToString();
                            }
                        }
                        //HistoryTeach ht = db.HistoryTeaches.SingleOrDefault(c => c.GroupID == GetGroupID() && c.Date == DateTime.Now.ToShortDateString() && c.Session == Session());
                        //if (ht != null)
                        //{
                        //    ht.TeacherCode = frmLogin.teacherCode;
                        //    ht.RoomID = RoomID();
                        //    db.SubmitChanges();
                        //}
                        //else
                        //{
                        //    HistoryTeach teach = new HistoryTeach();
                        //    teach.GroupID = GetGroupID();
                        //    teach.Date = DateTime.Now.ToShortDateString();
                        //    teach.RoomID = RoomID();
                        //    teach.Session = Session();
                        //    teach.TeacherCode = frmLogin.teacherCode;
                        //    db.HistoryTeaches.InsertOnSubmit(teach);
                        //    db.SubmitChanges();

                        //}
                       
                        connectGroup = true;
                        db.SubmitChanges();
                        this.Close();
                        //frmGroupStudent frm = new frmGroupStudent();
                        //frm.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Kết nối không thành công !", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    

                }
                else
                {
                    XtraMessageBox.Show("Chưa tồn tại ca thưc hành này","Quản lý phòng máy",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
            }
        }
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}