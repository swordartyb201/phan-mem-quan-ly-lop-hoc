using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmInfoSubject : DevExpress.XtraEditors.XtraForm
    {
        public frmInfoSubject()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void frmInfoSubject_Load(object sender, EventArgs e)
        {
            frmMain.ktr = true;
            var s =( from st in db.StudentPractices
                    where st.GroupStudentID == frmJoinGroup.GroupID
                    select new {st.GroupStudent.Class.ClassName, st.GroupStudent.Subject.SubjectName,st.GroupStudent.HaflYear,st.GroupStudent.Year,st.GroupStudent.Teacher.TeacherName}).Distinct();
            gcSubject.DataSource = s;
        }

        private void frmInfoSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.ktr = false;
        }
    }
}