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


namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmSendFlie : DevExpress.XtraEditors.XtraForm
    {
        public frmSendFlie()
        {
            InitializeComponent();
        }
        string FileName;
      
        FileStream fs1;
        public bool IsFileUsedbyAnotherProcess(string fileName)
        {
            bool kt = false;
            
            try
            {
                fs1 = new FileStream(txtFile.Text, FileMode.Open,FileAccess.Read,FileShare.None); 
            }
            catch
            {

                kt = true;
            }
            fs1.Close();
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
                XtraMessageBox.Show("Đường dẫn không đúng", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
       
        
        private void frmSendFlie_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                FileInfo TheFile = new FileInfo(txtFile.Text); // Get The File Name
                FileName = TheFile.Name;
                FileSize(txtFile.Text);
                if (size > 0)
                {
                    prgFile.Maximum = (int)size;
                    prgFile.Minimum = 0;
                    prgFile.Value = 0;

                    if (size <= 100000000)
                    {
                        if (IsFileUsedbyAnotherProcess(txtFile.Text) == false)
                        {

                            try
                            {
                                lblMessage.Text = "Đang trong quá trình gửi, vui lòng chờ trong giây lát";
                                FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
                                byte[] buffer = new byte[fs.Length];
                                int len = (int)fs.Length;
                                fs.Read(buffer, 0, len);
                                fs.Close();
                                BinaryFormatter br = new BinaryFormatter();
                                TcpClient myclient = new TcpClient(frmMain.ip, 7000);
                                NetworkStream myns = myclient.GetStream();
                                br.Serialize(myns, FileName);
                                BinaryWriter mysw = new BinaryWriter(myns);
                                mysw.Write(buffer);
                                mysw.Close();
                                myns.Close();
                                myclient.Close();
                                prgFile.Value = prgFile.Maximum;
                                lblMessage.Text = "Đã gửi thành công";
                                MessageBox.Show("Đã gửi thành công");
                                this.Close();

                            }
                            catch
                            {
                                lblMessage.Text = "Không kết nối tới máy giáo viên, Thử lại sau";
                                XtraMessageBox.Show("Không kết nối tới máy giáo viên", "Quản lý phòng máy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
            }
           
        }
    }
}