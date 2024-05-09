using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using ex = Microsoft.Office.Interop.Excel;
namespace PracticeTeachingManagementSystem
{
    public partial class frmImportStudent : DevExpress.XtraEditors.XtraForm
    {
        public frmImportStudent()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void btnBrown_Click(object sender, EventArgs e)
        {

            #region Tạo datatable

            DataColumn cl;

            dt = new DataTable();

            cl = new DataColumn();
            cl.ColumnName = "StudentCode";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "StudentName";
            dt.Columns.Add(cl);


            cl = new DataColumn();
            cl.ColumnName = "ClassCode";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "BirthDay";
            dt.Columns.Add(cl);
            #endregion
            #region lấy dữ liệu từ excel vào Gridview

            OpenFileDialog openFi = new OpenFileDialog();
            openFi.Filter = "Kiểu file: (*.xls)|*.xls";
            ex.Application excelObj = new Microsoft.Office.Interop.Excel.Application();
            if (openFi.ShowDialog() == DialogResult.OK)
            {
                this.UseWaitCursor = true;
                ex.Workbook myWorkBook = excelObj.Workbooks.Open(openFi.FileName, 0, true, 5, "", "", true, ex.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0);
                ex.Sheets sheets = myWorkBook.Worksheets;
                ex.Worksheet worksheet = (ex.Worksheet)sheets.get_Item(1);
                object rowIndex = 2;
                int index = 0;
                int count = 2;

                dgvListSubject.Rows.Clear();
                string[] arr = new string[4];

                while (((ex.Range)worksheet.Cells[rowIndex, 1]).Value2 != null)
                {


                    arr[0] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 1]).Value2);
                    arr[1] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 2]).Value2);

                    arr[2] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2);
                    arr[3] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 4]).Value2);


                    dgvListSubject.Rows.Add(arr);
                    dgvListSubject.FirstDisplayedScrollingRowIndex = dgvListSubject.Rows.Count - 1;
                    dt.Rows.Add(arr);
                    index++;



                    rowIndex = ++count;
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                }
                if (dgvListSubject.Rows.Count > 1)
                {

                    btnInsert.Enabled = true;
                }
            }
            #endregion


            //Download source code mien phi tai Sharecode.vn
            this.UseWaitCursor = false;
            btnRefresh.Enabled = true;

            btnBrown.Enabled = false;
        }
        bool TestSubject(string subjectCode)
        {
            PTMSDataContext db = new PTMSDataContext();
            Student sb = db.Students.SingleOrDefault(s => s.StudentCode.Trim().ToLower() == subjectCode.Trim().ToLower());
            if (sb != null)
                return true;
            else return false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            PTMSDataContext db = new PTMSDataContext();
            int count = 0;
            for (int i = 0; i < dgvListSubject.Rows.Count - 1; i++)
            {
                dgvListSubject.FirstDisplayedScrollingRowIndex = i;
                Class cl = db.Classes.SingleOrDefault(c => c.ClassCode.Trim().ToLower() == dgvListSubject[2, i].Value.ToString().Trim().ToLower());
                if (!TestSubject(dgvListSubject[0, i].Value.ToString())&&cl!=null)
                {
                    count++;
                    dgvListSubject[0, i].Style.BackColor = Color.SkyBlue;
                    dgvListSubject[1, i].Style.BackColor = Color.SkyBlue;
                    dgvListSubject[2, i].Style.BackColor = Color.SkyBlue;
                    Student s = new Student();
                    s.StudentCode = dgvListSubject[0, i].Value.ToString();
                    s.FullName= dgvListSubject[1, i].Value.ToString();
                    s.ClassID = cl.ClassID;
                    
                    
                    db.Students.InsertOnSubmit(s);
                    db.SubmitChanges();

                }
                else
                {
                    dgvListSubject[0, i].Style.BackColor = Color.LightPink;
                    dgvListSubject[1, i].Style.BackColor = Color.LightPink;
                    dgvListSubject[2, i].Style.BackColor = Color.LightPink;
                }
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();

            }
            if (count > 0)
            {
                XtraMessageBox.Show("Bạn đã Import " + count.ToString() + " môn học");
            }
            else
            {
                XtraMessageBox.Show("Tất cả các môn học này đã có dữ liệu");
            }
        }
    }
}