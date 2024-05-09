using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PracticeTeachingManagementSystem_Student
{
    static class Program
    {
        /// <summary>
        /// Ip của server
        /// </summary>
    //public static string iP = "169.254.227.235";
       // public static string iP = "127.0.0.1";
        public static string iP = "127.0.0.1";
        public static bool chat = false;
        public static bool ngat = false;
        //Lấy ra ComputerID
        public static int ComputerID =0;
        //Lấy ra GroupID của các nhóm mà giảng viên đang Join trên mạng Lan (1 danh sách các nhóm đang thực hành)
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBg());
        }
    }
}