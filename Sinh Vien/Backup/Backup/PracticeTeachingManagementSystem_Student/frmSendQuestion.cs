using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmSendQuestion : DevExpress.XtraEditors.XtraForm
    {
        public frmSendQuestion()
        {
            InitializeComponent();
        }

        private void frmSendQuestion_Load(object sender, EventArgs e)
        {
            string[] mang = { "321", "321", "321" };
            ListViewItem lvi = new ListViewItem(mang);
            lviChat.Items.Add(lvi);
        }
    }
}