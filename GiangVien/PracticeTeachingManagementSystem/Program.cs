using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PracticeTeachingManagementSystem
{
    static class Program
    {
       // public static string iP = "192.168.1.114";
     // public static string iP = "192.168.2.10";
       public static string iP = "192.168.1.12";
      // public static string iP = "169.254.153.43";
      // public static string iP = "192.168.9.23";
        public static string iPClient = "";
        public static string connect = "";
        public static bool ktra = false;
        public static bool loadForm = false;
        public static string FullNameStudent = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new devMain());
        }
    }
}
