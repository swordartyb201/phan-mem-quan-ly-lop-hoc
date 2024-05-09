using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using DevExpress.XtraEditors;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PracticeTeachingManagementSystem
{
    public partial class frmSend : DevExpress.XtraEditors.XtraForm
    {
        public frmSend()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        Tool ct = new Tool();
        
        void LoadListView()
        {
            List<string> lst = new List<string>();
            lviSendFile.Items.Clear();
            lst.Clear();
           
            ListView lvitmp = new ListView();
            var ss = from c in db.SessionSpaces
                     // TODO : ERROR
                     //where c.Date == DateTime.Now.Date && c.Session==frmJoinGroup.Session && c.StudentPractice.GroupStudentID == frmJoinGroup.GroupID && c.Computer.ComputerIP != "0.0.0.0" && c.Computer.PracticeRoom.RoomName==frmJoinGroup.RoomName
                     select new { c.StudentPractice.Student.FullName, c.Computer.ComputerNumber, c.Computer.ComputerIP };
            foreach (var item in ss)
            {
                string[] mang = { item.FullName, item.ComputerNumber, item.ComputerIP };
                ListViewItem lvi = new ListViewItem(mang);
                lvitmp.Items.Add(lvi);
            }
            for (int i = lvitmp.Items.Count - 1; i >= 0; i--)
            {
                if (ct.TestIsAvailable(lvitmp.Items[i].SubItems[0].Text, lst, lvitmp.Items[i].SubItems[1].Text) == false)
                {
                    string[] gv = { lvitmp.Items[i].SubItems[0].Text, lvitmp.Items[i].SubItems[1].Text, lvitmp.Items[i].SubItems[2].Text };
                    ListViewItem lvgv = new ListViewItem(gv);
                    lviSendFile.Items.Add(lvgv);
                    lst.Add(lvitmp.Items[i].SubItems[0].Text);
                    lst.Add(lvitmp.Items[i].SubItems[1].Text);
                }
            }
        }
        /// <summary>
        /// Kiểm tra xem file cần gửi có đang được mở hay không???
        /// </summary>
       
        public bool IsFileUsedbyAnotherProcess(string fileName)
        {
            bool kt = false;
            try
            {
                FileStream fs1 = new FileStream(txtFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
                fs1.Close();
            }
            catch
            {

                kt = true;
            }
            return kt;

        }
        /// <summary>
        /// Lấy về dung lượng của một file;
        /// </summary>
        /// <param name="parth"></param>
        /// <returns></returns>
        long size = 0;
        void FileSize(string parth)
        {
            try
            {
                string fileName = parth;
                FileInfo f2 = new FileInfo(fileName);
                size = f2.Length;
            }
            catch
            {
                XtraMessageBox.Show("Đường dẫn không đúng","Quản lý phòng máy",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }

        private void lviSendFile_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lviSendFile.FocusedItem;
            if (lvi.Checked == false)
                lvi.Checked = true;
            else
                lvi.Checked = false;
        }

        private void frmSend_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
       

       
      /// <summary>
      /// Chọn tất cả sinh viên để gửi
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lviSendFile.Items.Count; i++)
            {
                lviSendFile.Items[i].Checked = true;
            }

        }
        /// <summary>
        /// Bỏ chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lviSendFile.Items.Count; i++)
            {
                lviSendFile.Items[i].Checked = false;
            }
            
        }

        /// <summary>
        /// Tìm file cần gửi sau đó gửi dữ liệu tới máy sinh viên đã được chọn
        /// </summary>
        string FileName;
        private void btnSend_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lviSendFile.Items.Count; i++)
            {
                if (lviSendFile.Items[i].Checked == true)
                { count++; }
            }
            prgFile.Maximum = count;
            prgFile.Minimum = 0;
            prgFile.Value = 0;
            //openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                FileInfo TheFile = new FileInfo(txtFile.Text); // Get The File Name
                FileName = TheFile.Name;
                FileSize(txtFile.Text);
                if (size > 0)
                {
                    if (count > 0)
                    {
                        if (size <= 100000000)
                        {
                            if (IsFileUsedbyAnotherProcess(txtFile.Text) == false)
                            {
                                for (int i = 0; i < lviSendFile.Items.Count; i++)
                                {

                                    if (lviSendFile.Items[i].Checked == true)
                                    {
                                        try
                                        {
                                            FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
                                            byte[] buffer = new byte[fs.Length];
                                            int len = (int)fs.Length;
                                            fs.Read(buffer, 0, len);
                                            fs.Close();
                                            BinaryFormatter br = new BinaryFormatter();
                                            TcpClient myclient = new TcpClient(lviSendFile.Items[i].SubItems[2].Text, 3047);
                                            NetworkStream myns = myclient.GetStream();
                                            br.Serialize(myns, FileName);
                                            BinaryWriter mysw = new BinaryWriter(myns);

                                            mysw.Write(buffer);
                                            mysw.Close();

                                            myns.Close();
                                            myclient.Close();
                                        }
                                        catch
                                        {
                                            XtraMessageBox.Show("Không gửi được tới sinh viên:" + lviSendFile.Items[i].SubItems[0].Text, "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        prgFile.Value++;
                                    }

                                }
                                //XtraMessageBox.Show("Gửi xong", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                XtraMessageBox.Show("File bạn cần gửi đang được mở bởi một chương trình khác", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Quá dung lượng cho phép (100Mb)", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn sinh viên nào để gửi", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
    }
}