using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ex = Microsoft.Office.Interop.Excel;
using System.Linq;
namespace PracticeTeachingManagementSystem
{
    public partial class frmImportClass : DevExpress.XtraEditors.XtraForm
    {
        public frmImportClass()
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
            cl.ColumnName = "ClassCode";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "ClassName";
            dt.Columns.Add(cl);




            cl = new DataColumn();
            cl.ColumnName = "DepartmentCode";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "BranchCode";
            dt.Columns.Add(cl);
            cl = new DataColumn();
            cl.ColumnName = "TrainCode";
            dt.Columns.Add(cl);
            cl = new DataColumn();
            cl.ColumnName = "StartYear";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "StartHalfYear";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "EndYear";
            dt.Columns.Add(cl);

            cl = new DataColumn();
            cl.ColumnName = "LocationCode";
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
                string[] arr = new string[9];

                while (((ex.Range)worksheet.Cells[rowIndex, 1]).Value2 != null)
                {


                    arr[0] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 1]).Value2);
                    arr[1] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2);

                    arr[2] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 4]).Value2);
                    arr[3] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 5]).Value2);
                    arr[4] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 6]).Value2);
                    arr[5] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 9]).Value2);
                    arr[6] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 10]).Value2);
                    arr[7] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 11]).Value2).Split('-')[1].Trim();
                    arr[8] = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 12]).Value2);
                    dgvListSubject.Rows.Add(arr);
                    dgvListSubject.FirstDisplayedScrollingRowIndex = dgvListSubject.Rows.Count - 1;
                    dt.Rows.Add(arr);
                    index++;



                    rowIndex = ++count;
                    System.Threading.Thread.Sleep(5);
                    Application.DoEvents();
                }
                if (dgvListSubject.Rows.Count > 1)
                {

                    btnInsert.Enabled = true;
                }
            }
            #endregion




            this.UseWaitCursor = false;
            btnRefresh.Enabled = true;

            btnBrown.Enabled = false;
        }
        bool TestClass(string classCode)
        {
            PTMSDataContext db = new PTMSDataContext();
            Class sb = db.Classes.SingleOrDefault(s => s.ClassCode.Trim().ToLower() == classCode.Trim().ToLower());
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
                if (!TestClass(dgvListSubject[0, i].Value.ToString()))
                {
                    count++;
                    dgvListSubject[0, i].Style.BackColor = Color.SkyBlue;
                    dgvListSubject[1, i].Style.BackColor = Color.SkyBlue;
                    dgvListSubject[2, i].Style.BackColor = Color.SkyBlue;

                    Class c = new Class();
                    c.ClassCode = dgvListSubject[0, i].Value.ToString();
                    c.ClassName = dgvListSubject[1, i].Value.ToString();
                    Department d = db.Departments.SingleOrDefault(c1 => c1.DepartmentCode.Trim().ToLower() == dgvListSubject[2, i].Value.ToString().Trim().ToLower());

                    c.DepartmentID = d.DepartmentID;
                    Branch b = db.Branches.SingleOrDefault(c2 => c2.BranchCode.Trim().ToLower() == dgvListSubject[3, i].Value.ToString().Trim().ToLower());
                    c.BranchID = b.BranchID;
                    Train t = db.Trains.SingleOrDefault(c3 => c3.TrainCode.Trim().ToLower() == dgvListSubject[4, i].Value.ToString().Trim().ToLower());
                    c.TrainID = t.TrainID;
                    c.StartYear = int.Parse(dgvListSubject[5, i].Value.ToString());
                    c.StartHaftYear = int.Parse(dgvListSubject[6, i].Value.ToString());
                    c.EndYear = int.Parse(dgvListSubject[7, i].Value.ToString());

                    c.LocationID = db.Locations.SingleOrDefault(c4 => c4.LocationCode.Trim().ToLower() == dgvListSubject[8, i].Value.ToString().Trim().ToLower()).LocationID;

                    db.Classes.InsertOnSubmit(c);
                    db.SubmitChanges();

                }
                else
                {
                    dgvListSubject[0, i].Style.BackColor = Color.LightPink;
                    dgvListSubject[1, i].Style.BackColor = Color.LightPink;
                    dgvListSubject[2, i].Style.BackColor = Color.LightPink;
                }
                System.Threading.Thread.Sleep(50);
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