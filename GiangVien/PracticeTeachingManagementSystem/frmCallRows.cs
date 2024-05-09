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
    public partial class frmCallRows : DevExpress.XtraEditors.XtraForm
    {
        public frmCallRows()
        {
            InitializeComponent();
        }
        bool ok = false;
        PTMSDataContext db = new PTMSDataContext();
        DataTable dtExportExcell;
        List<string> date;
        List<int> groupSessionID;
        static int sobuoi = 0;
        private void frmCallRows_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        void LoadGrid()
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                ok = true;
            }
            else
                ok = false;

            #region sử dụng môt bảng để xử lý dữ liệu.
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "Number";
            dc.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(dc);

            //dc = new DataColumn();
            //dc.ColumnName = "ComputerNumber";
            //dc.DataType = Type.GetType("System.Int32");
            //dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "StudentCode";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "FullName";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);



            dc = new DataColumn();
            dc.ColumnName = "col1";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col2";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col3";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col4";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col5";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col6";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col7";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col8";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col9";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col10";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col11";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col12";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col13";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col14";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col15";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col16";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);


            dc = new DataColumn();
            dc.ColumnName = "col17";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col18";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col19";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col20";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col21";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "col22";
            dc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dc);
            #endregion

            #region Gán dữ liệu vào bảng và GridControl


            var q = (from stu in db.CallRools
                     where stu.GroupSession.GroupStudentID == frmJoinGroup.GroupID
                     select new { stu.StudentPractice.StudentID }).Distinct();

            date = new List<string>();

            foreach (var subq in q)
            {

                var query = from d in db.CallRools
                            where d.StudentPractice.StudentID == subq.StudentID
                            orderby d.CallRoolID
                            select new { d.GroupSession.Date };
                if (query.Count() > 0)
                    foreach (var sub in query)
                    {
                        date.Add(sub.Date.Value.ToShortDateString());
                    }
                break;
            }
            for (int i = date.Count; i <= 21; i++)
            {
                date.Add("");
            }

            int j = 0;
            int k = 0;
            foreach (var item1 in q)
            {
                j++;
                var query = from d in db.CallRools
                            where d.StudentPractice.StudentID == item1.StudentID && d.StudentPractice.GroupStudentID == frmJoinGroup.GroupID
                            orderby d.CallRoolID
                            select new { d.StudentPractice.Student.FullName, d.StudentPractice.Student.StudentCode, d.IsAvailable };

                int i = 0;
                DataRow dr = dt.NewRow();

                foreach (var item in query)
                {


                    if (i == 0)
                    {
                        dr[0] = j;
                        dr[1] = item.StudentCode;
                        dr[2] = item.FullName;
                        if (item.IsAvailable == null)
                            dr[3] = "";
                        else
                            dr[3] = item.IsAvailable;

                    }
                    else
                    {
                        if (item.IsAvailable == null)
                            dr[i + 3] = "";
                        else
                            dr[i + 3] = item.IsAvailable;
                    }
                    i++;
                }
                dt.Rows.Add(dr);
                k = i;
            }
            sobuoi = k;
            lblClass.Text = frmJoinGroup.ClassName;
            lblClass1.Text = frmJoinGroup.ClassName;
            lblSubject1.Text = frmJoinGroup.SubjectName;
            lblTeacher1.Text = frmJoinGroup.TeacherName;
            lblGroup1.Text = frmJoinGroup.GroupName;
            lblYear1.Text = frmJoinGroup.Year;
            lblTotal1.Text = frmJoinGroup.Total;
            lblHaftYear.Text = frmJoinGroup.HalfYear;
            lblSubject.Text = frmJoinGroup.SubjectName;
            lblGroup.Text = frmJoinGroup.GroupName;
            lblHalfYear.Text = frmJoinGroup.HalfYear;
            lblYear.Text = frmJoinGroup.Year;
            lblTotal.Text = frmJoinGroup.Total;
            lblDate.Text = frmJoinGroup.Date;
            lblTeacher.Text = frmJoinGroup.TeacherName;
          //  gvCallRoll.Columns[k + 3].AppearanceCell.BackColor = Color.Aqua;
            //gvCallRool1.Columns[k + 3].AppearanceCell.BackColor = Color.Aqua;
            lblsession.Text = "BẢNG THEO DÕI HỌC TẬP ( HỌC PHẦN THỰC HÀNH) ";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (ok)
                {

                    for (int j1 = 0; j1 < dt.Columns.Count; j1++)
                    {
                        dt.Columns[j1].ReadOnly = true;
                    }
                }
                else
                {
                    for (int j1 = 0; j1 < dt.Columns.Count; j1++)
                    {
                        if (j1 == 0 || j1 == 1 || j1 == 2 || j1 > k + 2)
                            dt.Columns[j1].ReadOnly = true;
                        else
                            dt.Columns[j1].ReadOnly = false;
                    }
                }

            }
            dtExportExcell = dt;
            gcCallRool.DataSource = dtExportExcell;
            gcCallRool1.DataSource = dtExportExcell;
            #endregion
        }
        void Export()
        {
            string[] Char = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK" };
            Microsoft.Office.Interop.Excel.Application ap = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook eWork;
            Microsoft.Office.Interop.Excel.Worksheet eSheet;
            eWork = ap.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            eSheet = (Microsoft.Office.Interop.Excel.Worksheet)eWork.Worksheets[1];


            eSheet.get_Range("A7", "AL" + (dtExportExcell.Rows.Count + 15).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            eSheet.get_Range("A9", "AK9").Cells.RowHeight = 32.75;

            eSheet.get_Range("A1", "AK100").Cells.Font.Name = "Times New Roman";
            eSheet.get_Range("A1", "A" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 3.75;
            eSheet.get_Range("B1", "B" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 23;


            eSheet.get_Range("AI1", "AI" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 6.75;
            eSheet.get_Range("AJ" + "8", "AJ" + "9").MergeCells = true;
            eSheet.get_Range("AJ" + "8", "AJ" + "9").Value2 = "Chữ ký";



            for (int i = 3; i < 27; i++)
            {
                if (Char[i] == "Z")
                {
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "Có lý do";
                    eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;

                }
                else
                {
                    if (Char[i] == "AA")
                    {

                        eSheet.get_Range("AA8", "AA9").MergeCells = true;
                        eSheet.get_Range("AA8", "AA9").Value2 = "Không lý do";
                        eSheet.get_Range("AA8", "AA9").Orientation = 90;


                    }
                    else
                    {
                        if (i < 25)
                        {
                            eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "'" + date[i - 3].ToString();
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Font.Size = "9";
                        }
                        else
                        {
                            eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "'" + date[i - 3].ToString();
                            eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;

                        }
                    }
                }
            }

            for (int i = 27; i <= 34; i++)
            {
                eSheet.get_Range(Char[i] + "1", Char[i] + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 2.75;
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").MergeCells = true;
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").Value2 = "";
                eSheet.get_Range(Char[i] + "8", Char[i] + "9").Orientation = 90;

            }
            eSheet.get_Range("AJ1", "AJ" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 13;
            eSheet.get_Range("AJ1", "AK" + (dtExportExcell.Rows.Count + 15)).Cells.ColumnWidth = 16;

            eSheet.get_Range("A1", "B1").MergeCells = true;
            eSheet.get_Range("A1", "B1").Value2 = "Mẫu theo dõi 3";
            eSheet.get_Range("A1", "B1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            eSheet.get_Range("A1", "B1").Font.Italic = true;
            eSheet.get_Range("A1", "B1").Font.Underline = true;

            eSheet.get_Range("A1", "B1").Cells.RowHeight = 12;

            eSheet.get_Range("A2", "P2").MergeCells = true;
            eSheet.get_Range("A2", "P2").Value2 = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KT HƯNG YÊN";
            eSheet.get_Range("A2", "P2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            eSheet.get_Range("A2", "P2").RowHeight = 12.75;

            eSheet.get_Range("Q2", "AK2").MergeCells = true;
            eSheet.get_Range("Q2", "AK2").Value2 = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            eSheet.get_Range("Q2", "AK2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            eSheet.get_Range("Q2", "AK2").Font.Bold = true;

            eSheet.get_Range("Q2", "AK2").RowHeight = 12.75;

            eSheet.get_Range("A3", "P3").MergeCells = true;
            eSheet.get_Range("A3", "P3").Value2 = "KHOA CÔNG NGHỆ THÔNG TIN";
            eSheet.get_Range("A3", "P3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            eSheet.get_Range("A3", "P3").Font.Bold = true;
            eSheet.get_Range("C3", "J3").Font.Underline = true;

            eSheet.get_Range("A3", "P3").Cells.RowHeight = 15.75;

            eSheet.get_Range("Q3", "AK3").MergeCells = true;
            eSheet.get_Range("Q3", "AK3").Value2 = "Độc lập - Tự do - Hạnh phúc";
            eSheet.get_Range("Q3", "AK3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            eSheet.get_Range("Q3", "AK3").Font.Bold = true;
            eSheet.get_Range("Y3", "AG3").Font.Underline = true;

            eSheet.get_Range("Q3", "AK3").Cells.RowHeight = 15.75;

            eSheet.get_Range("A4", "AK4").Cells.RowHeight = 6.75;

            eSheet.get_Range("AK7", "AK9").MergeCells = true;
            eSheet.get_Range("AK7", "AK9").Value2 = "BẢNG THEO DÕI HỌC TẬP(HỌC PHẦN THỰC HÀNH)";
            eSheet.get_Range("AK7", "AK9").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            eSheet.get_Range("AK7", "AK9").Font.Bold = true;

            eSheet.get_Range("AK7", "AK9").Cells.RowHeight = 18.75;

            eSheet.get_Range("A6", "B6").MergeCells = true;
            eSheet.get_Range("A6", "B6").Value2 = "Môn: " + frmJoinGroup.SubjectName;
            eSheet.get_Range("A6", "AH6").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            eSheet.get_Range("C6", "H6").MergeCells = true;
            eSheet.get_Range("C6", "H6").Value2 = "Số ĐVHT/TC: " + frmJoinGroup.Total;

            eSheet.get_Range("C6", "H6").Cells.RowHeight = 15;

            eSheet.get_Range("I6", "K6").MergeCells = true;
            eSheet.get_Range("I6", "K6").Value2 = "Lớp: " + frmJoinGroup.ClassName;

            eSheet.get_Range("L6", "O6").MergeCells = true;
            eSheet.get_Range("L6", "O6").Value2 = "Học kỳ: " + frmJoinGroup.HalfYear;

            eSheet.get_Range("P6", "W6").MergeCells = true;
            eSheet.get_Range("P6", "W6").Value2 = "Năm học: " + frmJoinGroup.Year;

            eSheet.get_Range("X6", "AH6").MergeCells = true;
            eSheet.get_Range("X6", "AH6").Value2 = "GV giảng dạy: " + frmJoinGroup.TeacherName;

            eSheet.get_Range("A7", "A9").MergeCells = true;
            eSheet.get_Range("A7", "A9").Value2 = "STT";
            eSheet.get_Range("A1", "AL7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A7", "AL9").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


            eSheet.get_Range("B7", "B9").MergeCells = true;
            eSheet.get_Range("B7", "B7").Cells.ColumnWidth = 10;

            eSheet.get_Range("C7", "C7").Cells.ColumnWidth = 23;

            eSheet.get_Range("B7", "B9").Value2 = "Mã SV";

            eSheet.get_Range("C7", "C9").MergeCells = true;
            eSheet.get_Range("C7", "C9").Value2 = "Họ và tên";

            eSheet.get_Range("D7", "Y7").MergeCells = true;
            eSheet.get_Range("D7", "Y7").Value2 = "Ngày/tháng";

            eSheet.get_Range("Z7", "AA7").MergeCells = true;
            eSheet.get_Range("Z7", "AA7").Value2 = "Số buổi";

            eSheet.get_Range("AB7", "AI7").MergeCells = true;
            eSheet.get_Range("AB7", "AI7").Value2 = "Điểm quá trình";

            eSheet.get_Range("AK7", "AK9").MergeCells = true;
            eSheet.get_Range("AK7", "AK9").Value2 = "Kết luận\nĐK dự thi\nKTHP";

            eSheet.get_Range("AL7", "AL9").MergeCells = true;
            eSheet.get_Range("AL7", "AL9").Value2 = "Ghi chú";



            //phần giữa 
            int rowindex = 10;
            foreach (DataRow row in dtExportExcell.Rows)
            {
                int columnsIndex = 0;
                foreach (DataColumn col in dtExportExcell.Columns)
                {

                    columnsIndex++;
                    ap.Cells[rowindex, columnsIndex] = row[col.ColumnName];


                }
                rowindex++;
            }

            //phần đuôi

            string foot = (dtExportExcell.Rows.Count + 16).ToString();
            string foot1 = (dtExportExcell.Rows.Count + 17).ToString();
            eSheet.get_Range("A" + foot, "AK" + foot).Cells.RowHeight = 16.5;
            eSheet.get_Range("A" + foot, "AK" + foot1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            eSheet.get_Range("A" + foot, "B" + foot).MergeCells = true;
            eSheet.get_Range("A" + foot, "B" + foot).Value2 = "Ký hiệu theo dõi";

            eSheet.get_Range("A" + foot, "B" + foot).Font.Bold = true;
            eSheet.get_Range("A" + foot, "B" + foot).Font.Underline = true;

            eSheet.get_Range("A1", "AK" + foot).Font.Size = "11";

            eSheet.get_Range("F" + foot, "I" + foot).MergeCells = true;
            eSheet.get_Range("F" + foot, "I" + foot).Value2 = "Nơi nhận";



            eSheet.get_Range("Q" + foot, "Z" + foot).MergeCells = true;
            eSheet.get_Range("Q" + foot, "Z" + foot).Value2 = "Trưởng Khoa/Trưởng Bộ Môn";



            eSheet.get_Range("Q" + foot, "Z" + foot).Font.Size = "13";

            eSheet.get_Range("AH" + foot, "AK" + foot).MergeCells = true;
            eSheet.get_Range("AH" + foot, "AK" + foot).Value2 = "Giảng viên giảng dạy HP";

            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Bold = true;
            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Underline = true;

            eSheet.get_Range("AH" + foot, "AK" + foot).Font.Size = "13";

            eSheet.get_Range("A" + foot1, "AK" + foot1).Cells.RowHeight = 52;
            eSheet.get_Range("B" + foot1, "D" + foot1).MergeCells = true;
            eSheet.get_Range("B" + foot1, "D" + foot1).Value2 = "+ -Học đủ cả buổi\nB -Bỏ giờ\nÔ -Nghỉ ốm\nK -Nghỉ không lý do";


            eSheet.get_Range("B" + foot1, "D" + foot1).Font.Size = "10";

            eSheet.get_Range("H" + foot1, "O" + foot1).MergeCells = true;
            eSheet.get_Range("H" + foot1, "O" + foot1).Value2 = "Nộp trước ngày thi KTHP\nvề\n-Khoa/Bộ môn\n-Ban ĐBCL&KT";


            eSheet.get_Range("H" + foot1, "O" + foot1).Font.Size = "10";

            eSheet.get_Range("Q" + foot1, "Z" + foot1).MergeCells = true;
            eSheet.get_Range("Q" + foot1, "Z" + foot1).Value2 = "(Ký, ghi rõ họ tên)";

            eSheet.get_Range("Q" + foot1, "Z" + foot1).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignTop;

            eSheet.get_Range("Q" + foot1, "Z" + foot1).Font.Size = "12";

            eSheet.get_Range("AH" + foot1, "AK" + foot1).MergeCells = true;
            eSheet.get_Range("AH" + foot1, "AK" + foot1).Value2 = "(Ký, ghi rõ họ tên)";

            eSheet.get_Range("AH" + foot1, "AK" + foot1).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignTop;

            eSheet.get_Range("AH" + foot1, "AK" + foot1).Font.Size = "12";


            ap.Visible = true;

            ap.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(eWork);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);

        }

        private void btnExportToExcell_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)//Nếu tự động thì gán ok bằng true, Nếu điểm danh bằng tay gán OK bằng False
            {
                ok = true;
            }
            else
                ok = false;
            LoadGrid();
        }
        private void gvCallRool1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            string studentcode = gvCallRool1.GetRowCellDisplayText(e.RowHandle, "StudentCode");
            string b = gvCallRool1.GetRowCellDisplayText(e.RowHandle, "FullName");
            int StudentPracticeID = -1;
            StudentPractice sp = db.StudentPractices.SingleOrDefault(c => c.Student.StudentCode == gvCallRool1.GetRowCellDisplayText(e.RowHandle, "StudentCode") && c.GroupStudentID == frmJoinGroup.GroupID);
            if (sp != null)
            {
                StudentPracticeID = sp.StudentPracticeID;

            }
            else
                StudentPracticeID = -1;
            //Lấy ra ca thực hành mà bạn sửa:
            var q = (from stu in db.StudentPractices
                     where stu.GroupStudentID == frmJoinGroup.GroupID
                     select new { stu.StudentID }).Distinct();
            //date = new List<string>();
            groupSessionID = new List<int>();
            foreach (var subq in q)
            {
                var query = from d in db.CallRools
                            where d.StudentPractice.StudentID == subq.StudentID
                            orderby d.CallRoolID
                            // orderby d.GroupSession.Session.PracticeDate
                            select new { d.GroupSessionID };
                foreach (var sub in query)
                {
                    groupSessionID.Add(sub.GroupSessionID.Value);
                }
                break;
            }

            CallRool cr = db.CallRools.SingleOrDefault(subcr => subcr.StudentPracticeID == StudentPracticeID && subcr.GroupSessionID == groupSessionID[e.Column.ColumnHandle - 3]);
            if (cr != null)
            {
                // cr.GroupSessionID = groupSessionID[e.Column.ColumnHandle];
                cr.IsAvailable = e.Value.ToString();
                db.SubmitChanges();

            }
            else
            { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Export();
        }
    }

}