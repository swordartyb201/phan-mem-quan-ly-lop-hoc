using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PracticeTeachingManagementSystem
{
    public partial class UCTool : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTool()
        {
            InitializeComponent();
            frmRemoting.conect = true;
        }

        //private void rbtOnlyWatch_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbtOnlyWatch.Checked)
        //        frmRemoting.conect = true;
        //    else
        //        frmRemoting.conect = false;
        //}

        private void rbtControl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtControl.Checked)
                frmRemoting.conect = false;
            else
                frmRemoting.conect = true;
        }

        private void rbtLockKeyBoard_CheckedChanged(object sender, EventArgs e)
        {
        }

        //private void rbtExit_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbtExit.Checked)
        //        frmRemoting.closeForm = true;
        //    else
        //        frmRemoting.closeForm = false;
        //}

        private void UCTool_Load(object sender, EventArgs e)
        {
          
        }
        
    }
}
