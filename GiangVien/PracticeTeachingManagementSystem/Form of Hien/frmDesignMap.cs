using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Imaging;  
namespace PracticeTeachingManagementSystem
{
    public partial class frmDesignMap : DevExpress.XtraEditors.XtraForm
    {
        public frmDesignMap()
        {
            InitializeComponent();
        }
        PTMSDataContext db = new PTMSDataContext();
        //name cua textbox = text cua button +_StudentpracticeID
        //text cua textbox=ten sinh vien
        //name cua button= comp + so may
        int so = 0;
        //lưu lại sơ đồ khi có thay đổi
        void SaveMap()
        {
            //xoa mầu
            //foreach (Control ct in ptbMap.Controls)
            //{
            //    if (ct is Button)
            //        ct.BackColor = colColorComputer.Color;
            //}
            CreateColor();
            //xoa so do cu cua phong
            var lst = from dm in db.RoomMaps where dm.RoomName == cboRoomDesign.Text select dm;
            db.RoomMaps.DeleteAllOnSubmit(lst);
            db.SubmitChanges();
            //them lai so dos
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button)
                {
                    RoomMap dm = new RoomMap();
                    dm.RoomName = cboRoomDesign.Text;
                    dm.ComputerName = ct.Text;
                    dm.FontSize = Convert.ToInt32(cboFontSize.Text);
                    dm.Width = Convert.ToInt32(cboWidth.Text);
                    dm.Height = Convert.ToInt32(cboHeight.Text);
                    dm.Point = ct.Left.ToString() + " " + ct.Top.ToString();
                    if(ct.BackColor==colColorComputer.Color)
                    dm.Color = "Comp="+(ct.BackColor.ToArgb()).ToString();
                    else
                    dm.Color = "Othe=" + (ct.BackColor.ToArgb()).ToString();
                    db.RoomMaps.InsertOnSubmit(dm);
                    db.SubmitChanges();

                }
            }
        }
        int x = 0, y = 0;
        private void ptbMap_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            //MessageBox.Show(x + " " + y);
            CreateColor();
           
        }
        Point lastClick;
        //string nameTextbox;
        void b_MouseDown(object sender, MouseEventArgs e)
        {
            nameButton = (sender as Button).Text;
            lastClick = new Point(e.X, e.Y);

            //xoa mầu
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button)
                    ct.BackColor = colColorComputer.Color;
            }

            CreateColor();

            nameButton = (sender as Button).Text;
            if(nameTab=="Design")
            (sender as Button).BackColor = Color.MediumSlateBlue;
            left = (sender as Button).Left;
            top = (sender as Button).Top;

            //xoa text
            foreach (Control tb in ptbMap.Controls)
            {
                if (tb is TextBox && tb.Tag != (Object)"NameStudent")
                {
                    ptbMap.Controls.Remove(tb);
                }
            }

            //hiển  thi danh sach may chuyen
            LoadNumber();
            //hien thi ds sinh vien chuyen cho

                LoadName();
            //hien thi ds sinh vien chua cap nhat
            if (nameTab == "View" && rdoInsertGroup.Checked)
            {
               

                LoadNameNotUse();
            }

            //neu la cac may khac thi khong cho hien thi contextmenustrip de chuyen cho va them ten sv
            string room = "";
            if (rdoViewGroup.Checked)
                room = cboRoom.Text;
            else
                room = cboRoomUpdate.Text;
            var lst = from c in db.Computers where c.PracticeRoom.RoomName == room select c;
            bool ktuse = false;
            foreach (Control ct in ptbMap.Controls)
            {
                ktuse = false;
                if (ct is Button)
                    foreach (var it in lst)
                    {
                        if (it.ComputerNumber == ct.Text)
                        {
                            ktuse = true; break;
                        }
                    }

                if (ct is Button && ct.Text == nameButton)
                {
                    if (ktuse)
                    {
                        if(rdoUpdate.Checked)
                            ctmStudentName.Enabled = true;
                        else ctmStudentName.Enabled = false;
                        ctmMoveStudent.Enabled = true;
                    }
                    else
                    {
                        ctmStudentName.Enabled = false;
                        ctmMoveStudent.Enabled = false;
                    }
                    break;
                }
            }

        }

        void b_MouseMove(object sender, MouseEventArgs e)
        {
            if (nameTab == "Design")
            {
                //nameButton = new Button(sender as Button);
                if (e.Button == MouseButtons.Left)
                {
                    foreach (Control ct in ptbMap.Controls)
                    {
                        if (ct is Button && ct.Text == nameButton)
                        {
                            ct.Left += e.X - lastClick.X;
                            ct.Top += e.Y - lastClick.Y;
                            //tạo đường thẳng bắt dính với các lưới và các điều máy tính khác
                            Graphics g;
                            g = ptbMap.CreateGraphics();
                            Pen p = new Pen(Color.Red, 1);
                            if ((ct.Left % 30 == 0) && chkShowGrid.Checked == true)
                            {
                                Point p1 = new Point(ct.Left, 0);
                                Point p2 = new Point(ct.Left, 1000); ;
                                g.DrawLine(p, p1, p2);

                                //ct.Left += e.X - lastClick.X;
                                //ct.Top += e.Y - lastClick.Y;
                            }
                            if (ct.Top % 30 == 0 && chkShowGrid.Checked == true)
                            {
                                Point p1 = new Point(0, ct.Top);
                                Point p2 = new Point(1000, ct.Top); ;
                                g.DrawLine(p, p1, p2);
                            }

                        }
                    }
                }
            }

        }
        string nameButton = "";
        int left, top;
        void b_MouseHover(object sender, EventArgs e)
        {

        }
        Button b;
        void b_Click(object sender, EventArgs e)
        {

            b = sender as Button;
            nameButton = b.Text;

            //xoa text
            foreach (Control tb in ptbMap.Controls)
            {
                if (tb is TextBox&&tb.Tag!="NameStudent")
                {
                    ptbMap.Controls.Remove(tb);
                }
            }
        }

        private void t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if (e.KeyChar == (Char)Keys.Enter && ktTrungtext == false)
                {
                    //MessageBox.Show("Test");
                    foreach (Control bt in ptbMap.Controls)
                    {
                        if (bt is Button && bt.Text == nameButton)
                        {
                            bt.Text = (sender as TextBox).Text;
                        }
                    }

                    //xoa text
                    foreach (Control tb in ptbMap.Controls)
                    {
                        if (tb is TextBox && tb.Tag != (Object)"NameStudent")
                        {
                            ptbMap.Controls.Remove(tb);
                        }
                    }
                }
            }
            else errorProvider1.SetError((sender as TextBox), "Chưa nhập số máy");
        }
        void UpdateNumber()
        {
            //nhập trọng số
            TextBox t = new TextBox();

            t.Name = "textbox";
            t.Size = new Size(Convert.ToInt32(cboWidth.Text), 20);
            t.Location = new Point(left, top - 22);
            t.Text = "";
            t.BringToFront();

            //t.TextChanged += new EventHandler(t_TextChanged);
            t.KeyPress += new KeyPressEventHandler(t_KeyPress);
            t.TextChanged += new EventHandler(t_TextChanged);

            ptbMap.Controls.Add(t);
            t.Focus();
        }
        private void ctmUpdateNumber_Click(object sender, EventArgs e)
        {
            //nếu không có máy trong ds thì cho phép nhập
            if(ctmUpdateNumber.DropDownItems.Count==0)
            {
                UpdateNumber();
            }
        }
        bool ktTrungtext;
        void t_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ktTrungtext = false;
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == (sender as TextBox).Text)
                {
                    ktTrungtext = true; break;
                }
            }
            if (ktTrungtext)
            {
                errorProvider1.SetError((sender as TextBox), "Số máy bị trùng!");
            }
        }

        private void ctmDeleteAll_Click(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
        }

        private void ctmDeleteComputer_Click(object sender, EventArgs e)
        {
            foreach (Control c in ptbMap.Controls)
            {
                if (c is Button && c.Text == nameButton)
                {
                    ptbMap.Controls.Remove(c);
                    break;
                }
            }
        }

        bool kt = false;
        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if (chkShowGrid.Checked == true)
            {
                kt = true;
                Graphics g;
                g = ptbMap.CreateGraphics();
                Pen p = new Pen(Color.Gainsboro, 1);
                Point p1 = new Point();
                Point p2 = new Point(); ;
                for (int i = 30; i <= 1200; i = i + 30)
                {
                    p1 = new Point(i, 0);
                    p2 = new Point(i, 1200);
                    g.DrawLine(p, p1, p2);
                }
                for (int i = 30; i <= 1200; i = i + 30)
                {
                    p1 = new Point(0, i);
                    p2 = new Point(1200, i);
                    g.DrawLine(p, p1, p2);
                }



            }
            else
            {
                kt = false;
                Graphics g;
                g = ptbMap.CreateGraphics();
                Pen p = new Pen(Color.White, 1);
                Point p1 = new Point();
                Point p2 = new Point(); ;
                for (int i = 30; i <= 1200; i = i + 30)
                {
                    p1 = new Point(i, 0);
                    p2 = new Point(i, 1200);
                    g.DrawLine(p, p1, p2);
                }
                for (int i = 30; i <= 1200; i = i + 30)
                {
                    p1 = new Point(0, i);
                    p2 = new Point(1200, i);
                    g.DrawLine(p, p1, p2);
                }
            }

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            chkShowGrid_CheckedChanged(sender, e);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            foreach (Control bt in ptbMap.Controls)
            {
                if (bt is Button && cboHeight.Text != "")
                {
                    bt.Height = Convert.ToInt32(cboHeight.Text);
                }
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            foreach (Control bt in ptbMap.Controls)
            {
                if (bt is Button && cboWidth.Text != "")
                {
                    bt.Width = Convert.ToInt32(cboWidth.Text);
                }
            }
        }

        void ScreenMap(int x, int y)//x,y vị trí cần chụp
        {
            Bitmap bmpScreenshot;
            Graphics gfxScreenshot;
            bmpScreenshot = new Bitmap(ptbMap.Width-10, ptbMap.Height-10, PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap  
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner  
            gfxScreenshot.CopyFromScreen(x, y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen  
            bmpScreenshot.Save(Application.StartupPath+"\\sodo.png", ImageFormat.Png);
        }
        private void frmDesignMap_Load(object sender, EventArgs e)
        {
            btnSaveMap.Enabled = false;
            btnPrint.Enabled = false;

            nameTab = "View";

            tabMap.SelectedTabPage = tabGroupMap;
            ptbMap.ContextMenuStrip = null;

            //load thông tin lên combobox phòng
            var l = from r in db.PracticeRooms select new { r.RoomName, r.RoomCode };

            foreach (var con in l)
            {
                cboRoomDesign.Properties.Items.Add(con.RoomName);

            }
            cboFontSize.Text = "16";
            cboHeight.Text = "50";
            cboWidth.Text = "100";
            //load cac thong tin de xem so do nhom- load phong
            rdoViewGroup.Checked = true;

            cboRoom.Properties.Items.Clear();
            var lstg = (from g in db.GroupSessions where (from gm in db.GroupMaps select gm.StudentPractice.GroupStudent.GroupStudentID).Contains(g.GroupStudentID) select new {g.PracticeRoom.RoomName}).Distinct();
            foreach (var item in lstg)
            {
                cboRoom.Properties.Items.Add(item.RoomName);
            }

            cboRoomUpdate.Enabled = false;
            cboClassUpdate.Enabled = false;
            cboSubjectUpdate.Enabled = false;
            cboGroupUpdate.Enabled = false;
            panelUpdate.Enabled = false;
            btnSave.Enabled = false;
        }
        bool DisplayComputer()//tra ve false khi chua duoc thiet ke
        {
            bool kt = false;
            if (cboRoomDesign.Text != "")
            {
                var lstc = from c in db.Computers orderby c.ComputerNumber where c.PracticeRoom.RoomName == cboRoomDesign.Text select c;
                if (lstc.Count() != 0)//neu ton tai may tinh thi cho phep hien thi so do hoac cho phep thiet ke con khong thi khong duoc thiet ke
                {
                    ptbMap.Controls.Clear();
                    so = 0;
                    //hien thi so do da thiet ke tu truoc
                    var lst = from d in db.RoomMaps where d.RoomName == cboRoomDesign.Text select d;
                    if (lst.Count() != 0)
                    {
                        foreach (var item in lst)
                        {
                            if (item.Color.Split('=')[0] == "Comp")
                                colColorComputer.Color = Color.FromArgb(Convert.ToInt32(item.Color.Split('=')[1]));
                            else
                                colColorOther.Color = Color.FromArgb(Convert.ToInt32(item.Color.Split('=')[1]));
                            //hiển thị thông tin cần thiết
                            cboFontSize.Text = item.FontSize.ToString();
                            cboHeight.Text = item.Height.ToString();
                            cboWidth.Text = item.Width.ToString();
                            //hiển thị sơ đồ
                            cboFontSize.Text = item.FontSize.ToString();
                            cboHeight.Text = item.Height.ToString();
                            cboWidth.Text = item.Width.ToString();
                            Button b = new Button();
                            b.Location = new Point(Convert.ToInt32(item.Point.Split(' ')[0]), Convert.ToInt32(item.Point.Split(' ')[1]));
                            b.Name = item.Color.Split('=')[0]+(item.ComputerName).ToString();
                            b.Text = (item.ComputerName).ToString();
                            b.Font = new Font("Tahoma", Convert.ToInt32(cboFontSize.Text));
                            b.Size = new Size(Convert.ToInt32(cboWidth.Text), Convert.ToInt32(cboHeight.Text));
                            b.BackColor = Color.FromArgb(Convert.ToInt32(item.Color.Split('=')[1]));
                            if (nameTab == "Design")
                                b.ContextMenuStrip = ContextMenu;
                            else
                            {
                                if (rdoViewGroup.Checked)
                                    b.ContextMenuStrip = contextMenuMove;
                                else
                                {
                                    b.ContextMenuStrip = contextMenuMove;
                                }

                            }

                            b.Click += new EventHandler(b_Click);
                            b.MouseHover += new EventHandler(b_MouseHover);
                            //b.Move += new EventHandler(b_Move);
                            b.MouseMove += new MouseEventHandler(b_MouseMove);
                            b.MouseDown += new MouseEventHandler(b_MouseDown);


                            ptbMap.Controls.Add(b);
                        }
                        kt=true;
                        btnSaveMap.Enabled = true;
                        btnPrint.Enabled = true;
                    }
                    else
                    {
                        x = 0; y = 0;
                        cboFontSize.Text = "16";
                        cboHeight.Text = "50";
                        cboWidth.Text = "100";
                        if (MessageBox.Show("Sơ đồ của phòng này chưa được thiết kế! Thiết kế bây giờ.", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            //load các máy tính
                            foreach (var it in lstc)
                            {
                                AddComputer(it.ComputerNumber.ToString(), colColorComputer.Color);
                            }
                            btnSaveMap.Enabled = true;
                            btnPrint.Enabled = true;
                        }
                        kt= false;
                        
                    }
                   
                }
                else
                {
                    MessageBox.Show("Phòng này chưa có máy tính nên không thể thiết kế đươc sơ đồ!", "Thông báo");
                    kt=false;
                }
                
            }
            return kt;
        }
        private void cboRoomDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            btnSaveMap.Enabled = false;
            btnPrint.Enabled = false;

            x = 0; y = 0;
            colColorOther.Color = Color.Pink;
            colColorComputer.Color = Color.PaleGreen;

            DisplayComputer();

           
           
            
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button)
                {
                    ct.Font = new Font("Tahoma", Convert.ToInt32(cboFontSize.Text));
                }
            }
        }

        private void cboHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button)
                {
                    ct.Height = Convert.ToInt32(cboHeight.Text);
                }
            }
        }

        private void cboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button)
                {
                    ct.Width = Convert.ToInt32(cboWidth.Text);
                }
            }
        }

        private void btnSaveMap_Click(object sender, EventArgs e)
        {
            SaveMap();
            MessageBox.Show("Lưu thành công!", "Thông báo!");
        }

        void ctmMove_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //chuyển số máy
            string text = nameButton;
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == nameButton)
                {
                    ct.Text = "tmp";
                    break;
                }
            }
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == e.ClickedItem.Text)
                {
                    ct.Text = text;
                    break;
                }
            }
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == "tmp")
                {
                    ct.Text = e.ClickedItem.Text;

                    break;
                }
            }
            nameButton = e.ClickedItem.Text;


        }

        void LoadNumber()
        {
            ctmMove.DropDownItems.Clear();
            //load danh sách máy
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text != nameButton)
                {
                    ctmMove.DropDownItems.Add(ct.Text);

                }
            }
            ctmMove.DropDownItemClicked += new ToolStripItemClickedEventHandler(ctmMove_DropDownItemClicked);

            ctmUpdateNumber.DropDownItems.Clear();
            //load danh sách máy
            var lst = from c in db.Computers where c.PracticeRoom.RoomName == cboRoomDesign.Text orderby c.ComputerNumber select c;
            ctmUpdateNumber.DropDownItems.Add("Khác...");
            foreach (var it in lst)
            {
                //kiểm tra chưa được sử dụng thì load 
                bool ktuse = false;
                foreach (Control ct in ptbMap.Controls)
                {
                    if (ct is Button && it.ComputerNumber == ct.Text)
                    {
                        ktuse = true; break;
                    }
                }
                if (ktuse == false)
                    ctmUpdateNumber.DropDownItems.Add(it.ComputerNumber);

            }
            //nếu không có máy thì xóa item "khac..."
            if(ctmUpdateNumber.DropDownItems.Count==1)
            ctmUpdateNumber.DropDownItems.Clear();

            ctmUpdateNumber.DropDownItemClicked += new ToolStripItemClickedEventHandler(ctmUpdateNumber_DropDownItemClicked);
        }
        void LoadName()
        {
            ctmMoveStudent.DropDownItems.Clear();
            //load danh sách máy
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text != nameButton)
                {
                    string room = "";
                    if (rdoViewGroup.Checked)
                        room = cboRoom.Text;
                    else
                        room = cboRoomUpdate.Text;
                    var lst = from c in db.Computers where c.PracticeRoom.RoomName == room select c;
                    bool ktuse = false;
                            foreach (var it in lst)
                            {
                                if (it.ComputerNumber == ct.Text)
                                {
                                    ktuse = true; break;
                                }
                            }

                       if(ktuse)
                    ctmMoveStudent.DropDownItems.Add(ct.Text);

                }
            }
            ctmMoveStudent.DropDownItemClicked += new ToolStripItemClickedEventHandler(ctmMoveStudent_DropDownItemClicked);

            
        }

        void ctmMoveStudent_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bool ktnext1 = false;
            foreach (Control ct in ptbMap.Controls)
                if (ct is TextBox && ct.Name.Split('_')[0] == nameButton)
                { ktnext1 = true; break; }

            bool ktnext2 = false;
            foreach (Control ct in ptbMap.Controls)
                if (ct is TextBox && ct.Name.Split('_')[0] == e.ClickedItem.Text)
                { ktnext2 = true; break; }

            //click để đổi cho sv

            //doi cho cho 2 sinh vien
            int x1 = 0, x2 = 0, y1 = 0,y2 =0;
            if(ktnext1==true &&ktnext2==true)
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is TextBox && ct.Name.Split('_')[0] == nameButton)
                {
                    x1 = ct.Left;
                    y1 = ct.Top;

                    foreach (Control ctb in ptbMap.Controls)
                    {
                        if (ctb is TextBox && ctb.Name.Split('_')[0] == e.ClickedItem.Text)
                        {
                            x2 = ctb.Left;
                            y2 = ctb.Top;

                            ctb.Left = x1;
                            ctb.Top = y1;

                            ct.Left = x2;
                            ct.Top = y2;

                            ct.Name = e.ClickedItem.Text + "_" + ct.Name.Split('_')[1];
                            ctb.Name = nameButton + "_" + ctb.Name.Split('_')[1];

                            break;
                        }
                    }

                    break;

                }
            }

            //doi cho cho sv ra vi tri trong

            if(ktnext1==true&&ktnext2==false)
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is TextBox && ct.Name.Split('_')[0] == nameButton)
                {
                    foreach (Control ctb in ptbMap.Controls)
                    {
                        if (ctb is Button && ctb.Text == e.ClickedItem.Text)
                        {
                            ct.Left = ctb.Left ;
                            ct.Top = ctb.Top + Convert.ToInt32(cboHeight.Text) + 2;

                            ct.Name = e.ClickedItem.Text + "_" + ct.Name.Split('_')[1];
                            //ctb.Name = nameButton + "_" + ctb.Name.Split('_')[1];

                            break;
                        }
                    }

                    break;

                }
            }

            //doi cho vi tri trong  vao mot sv
            if (ktnext1 == false && ktnext2 == true)
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == nameButton)
                {
                    foreach (Control ctb in ptbMap.Controls)
                    {
                        if (ctb is TextBox && ctb.Name.Split('_')[0] == e.ClickedItem.Text)
                        {
                            ctb.Left = ct.Left;
                            ctb.Top = ct.Top + Convert.ToInt32(cboHeight.Text) + 2;

                            ctb.Name = nameButton + "_" + ctb.Name.Split('_')[1];
                            //ctb.Name = nameButton + "_" + ctb.Name.Split('_')[1];

                            break;
                        }
                    }

                    break;

                }
            }       

            nameButton = e.ClickedItem.Text;

            //luu so do neu la chuyen cho cua sv khi xem so do
            if (nameTab == "View" && rdoViewGroup.Checked)
                SaveStudentMap();

        }
        void SaveStudentMap()
        {
            var lst=from g in db.GroupMaps select g;
            //xoa du lieu cu
            if(rdoViewGroup.Checked)
             lst= from g in lst where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoom.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClass.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubject.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroup.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) select g;
            else
                lst = from g in lst where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubjectUpdate.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroupUpdate.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) select g;

            db.GroupMaps.DeleteAllOnSubmit(lst);
            db.SubmitChanges();
            //luu du lieu moi
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is TextBox)
                {
                    GroupMap gm = new GroupMap();
                    string room="";
                    if(rdoViewGroup.Checked)
                        room=cboRoom.Text;
                    else
                        room=cboRoomUpdate.Text;
                    Computer cp = db.Computers.SingleOrDefault(c => c.ComputerNumber.ToString() == ct.Name.Split('_')[0].ToString() && c.PracticeRoom.RoomName == room);
                    gm.ComputerID = cp.ComputerID;
            gm.StudentPracticeID=Convert.ToInt32(ct.Name.Split('_')[1]);
            db.GroupMaps.InsertOnSubmit(gm);
            db.SubmitChanges();
                }
            }

        }
        void LoadNameNotUse()
        {
            ctmStudentName.DropDownItems.Clear();
            //lay ds sinh vien cua phong
            var lst = from g in db.StudentPractices where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubjectUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroupUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) select new { g.Student.FullName, g.StudentPracticeID };
            //load danh sinh viên chưa được sử dụng
            foreach (var sv in lst)
            {
                bool not = false;
                foreach (Control ct in ptbMap.Controls)
                {
                if (ct is TextBox&&sv.FullName==ct.Text)
                {
                    not = true;
                           
                    }

                }
                if(not==false)
                ctmStudentName.DropDownItems.Add(sv.FullName+"("+sv.StudentPracticeID+")");
            }
            ctmStudentName.DropDownItemClicked += new ToolStripItemClickedEventHandler(ctmStudentName_DropDownItemClicked);


        }

        void ctmStudentName_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //xoa sinh vien cu cua may khi chọn lại
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is TextBox && ct.Name.Split('_')[0] == nameButton)
                {
                    ptbMap.Controls.Remove(ct);
                }
            }
            //click vào một sinh viên thì hiển thị tên sinh viên cho máy đó
            foreach (Control ct in ptbMap.Controls)
            {
                if (ct is Button && ct.Text == nameButton)
                {
                    NameStudent(nameButton, ct.Left, ct.Top + Convert.ToInt32(cboHeight.Text) + 2, e.ClickedItem.Text.Split('(')[1].Substring(0,e.ClickedItem.Text.Split('(')[1].Length-1));
                    break;
                }
            }
            
        }
        void ctmUpdateNumber_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Khác...")
                foreach (Control ct in ptbMap.Controls)
                {
                    if (ct is Button && ct.Text == nameButton)
                    {
                        ct.Text = e.ClickedItem.Text;
                    }
                }
            else
                UpdateNumber();
           

        }
        void AddComputer(string text,Color cl)
        {
            Button b = new Button();
            b.Location = new Point(x, y);
            left = x; top = y;
            //nhãn không trùng nhau
            bool kt = false;

            //b.Name = (so).ToString();
            b.Text = text;
            b.Font = new Font("Tahoma", Convert.ToInt32(cboFontSize.Text));
            b.Size = new Size(Convert.ToInt32(cboWidth.Text), Convert.ToInt32(cboHeight.Text));
            b.BackColor = cl;
            b.ContextMenuStrip = ContextMenu;

            b.Click += new EventHandler(b_Click);
            b.MouseHover += new EventHandler(b_MouseHover);
            //b.Move += new EventHandler(b_Move);
            b.MouseMove += new MouseEventHandler(b_MouseMove);
            b.MouseDown += new MouseEventHandler(b_MouseDown);

            ptbMap.Controls.Add(b);
        }
        private void ctmAdd_Click(object sender, EventArgs e)
        {
            if (cboRoomDesign.Text != "")
            {
                do
                {
                    ++so; kt = false;
                    foreach (Control ct in ptbMap.Controls)
                    {
                        if (ct is Button && ct.Text == so.ToString())
                        {
                            kt = true; break;
                        }
                    }
                    if (kt)
                    {
                        so += 1;
                    }
                } while (kt);
                AddComputer(so.ToString(),colColorOther.Color);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng để thiết kế!", "Thông báo!");
            }
        }
        void CreateColor()
        {
            //tạo màu nền cho các máy tính
            var lst = from c in db.Computers where c.PracticeRoom.RoomName == cboRoomDesign.Text select c;

            //kiểm tra chưa được sử dụng thì load 
            bool ktuse = false;
            foreach (Control ct in ptbMap.Controls)
            {
                ktuse = false;
                if (ct is Button)
                    foreach (var it in lst)
                    {
                        if (it.ComputerNumber == ct.Text)
                        {
                            ktuse = true; break;
                        }
                    }

                if (ct is Button)
                if (ktuse)
                    ct.BackColor = colColorComputer.Color;
                else
                    ct.BackColor = colColorOther.Color;

            }
        }
        private void colColorComputer_EditValueChanged(object sender, EventArgs e)
        {
            CreateColor();
        }

        private void colColorOther_EditValueChanged(object sender, EventArgs e)
        {
            CreateColor();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToWord("So do " + cboRoomDesign.Text);
        }

        private void rdoViewGroup_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            if (rdoViewGroup.Checked == true)
            {
                cboRoom.Enabled = true;
                //load lai phong
                cboRoom.Properties.Items.Clear();
                var lstg = (from g in db.GroupSessions where (from gm in db.GroupMaps select gm.StudentPractice.GroupStudent.GroupStudentID).Contains(g.GroupStudentID) select new { g.PracticeRoom.RoomName }).Distinct();
                foreach (var item in lstg)
                {
                    cboRoom.Properties.Items.Add(item.RoomName);
                }
            }
            else
                cboRoom.Enabled = false;

                cboClass.Enabled = false;
                cboSubject.Enabled = false;
                cboGroup.Enabled = false;               
                btnView.Enabled = false;
                btnPrintMap.Enabled = false;
                colComputer.Enabled = false;
                colOther.Enabled = false;
                cboSizeName.Enabled = false;
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load lop theo phong
            cboClass.Properties.Items.Clear();
            cboClass.Text = "";
            if (cboRoom.Text != "")
            {
                cboClass.Enabled = true;
                cboSubject.Enabled = false;
                cboGroup.Enabled = false;
                btnView.Enabled = false;
                btnPrintMap.Enabled = false;
                //load lop
                var lstc = (from g in db.GroupMaps where (from gs in db.GroupSessions where gs.PracticeRoom.RoomName==cboRoom.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID) select new { g.StudentPractice.GroupStudent.Class.ClassName }).Distinct();
                foreach (var item in lstc)
                {
                    cboClass.Properties.Items.Add(item.ClassName);
                }
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load mon theo lop
            cboSubject.Properties.Items.Clear();
            cboSubject.Text = "";
            if (cboClass.Text != "")
            {               
                cboSubject.Enabled = true;
                cboGroup.Enabled = false;
                btnView.Enabled = false;
                btnPrintMap.Enabled = false;
                //load mon hoc
                var lstc = (from g in db.GroupMaps where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoom.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName==cboClass.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) select new { g.StudentPractice.GroupStudent.Subject.SubjectName }).Distinct();
                foreach (var item in lstc)
                {
                    cboSubject.Properties.Items.Add(item.SubjectName);
                }
            }
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load nhom theo mon
            cboGroup.Properties.Items.Clear();
            cboGroup.Text = "";
            if (cboSubject.Text != "")
            {
                cboGroup.Enabled = true;
                btnView.Enabled = false;
                btnPrintMap.Enabled = false;
                //load nhom
                var lstc = (from g in db.GroupMaps where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoom.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClass.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubject.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) select new { g.StudentPractice.GroupStudent.GroupName }).Distinct();
                foreach (var item in lstc)
                {
                    cboGroup.Properties.Items.Add(item.GroupName);
                }
            }
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            btnView.Enabled = true;
            btnPrintMap.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            colComputer.Color = colColorComputer.Color;
            colOther.Color = colColorOther.Color;
            ctmStudentName.Enabled = false;
            ptbMap.Controls.Clear();

            //in so do phong- neu chua co so do thi chuyen sang tab thiet ke con khong thi in ra ds
            cboRoomDesign.Text = cboRoom.Text;
            if (DisplayComputer() == false)
            {
                tabMap.SelectedTabPage = tabDesignMap;
                nameTab = "Design";
                rdoViewGroup.Checked = true;
            }
            else
            {
                //lay ds sinh vien cua phong
                var lst = (from g in db.GroupMaps where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoom.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClass.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubject.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroup.Text select gs.GroupStudentID).Contains(g.StudentPractice.GroupStudent.GroupStudentID)) select new { g.Computer.ComputerNumber,g.StudentPracticeID }).Distinct();
                //duyet va in sinh vien ra so do
                foreach (var sv in lst)
                {
                    foreach (Control ct in ptbMap.Controls)
                    {
                        if(ct is Button)
                            if (sv.ComputerNumber !=null&& sv.ComputerNumber == ct.Text)
                        {
                            NameStudent(sv.ComputerNumber,ct.Left, ct.Top + Convert.ToInt32(cboHeight.Text) + 2, sv.StudentPracticeID.ToString());
                        }
                    }
                }


                btnPrintMap.Enabled = true;
                colComputer.Enabled = true;
                colOther.Enabled = true;
                cboSizeName.Enabled = true;
            }
            cboSizeName.Text = "8";
        }
        void NameStudent(string number,int lefts, int tops, string studenPracticeID)//ham de them ten sinh vien vao duoi may tinh qua o text
        {
            //nhập trọng số
            TextBox tb = new TextBox();

            tb.Name = number+"_"+studenPracticeID;
            tb.Size = new Size(Convert.ToInt32(cboWidth.Text), 40);
            tb.Location = new Point(lefts, tops);
            var sp = db.StudentPractices.SingleOrDefault(s => s.StudentPracticeID == Convert.ToInt32(studenPracticeID));
            if (sp != null)
                tb.Text = sp.Student.FullName;
            else
                tb.Text = "";
            tb.Tag = "NameStudent";
            tb.Multiline = true;
            tb.BorderStyle = BorderStyle.None;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.BringToFront();

            ptbMap.Controls.Add(tb);
        }
        private void btnPrintGroup_Click(object sender, EventArgs e)
        {
            ExportToWord("Sodo "+cboRoom.Text+"-"+cboClass.Text+"-"+cboSubject.Text+"-"+cboGroup.Text);
        }

        string nameTab;


        private void tabMap_Click(object sender, EventArgs e)
        {
            if (tabMap.SelectedTabPage == tabDesignMap)
            {
                nameTab = "Design";
                ptbMap.ContextMenuStrip=contextMenuStripAdd;
                //xóa text
                ptbMap.Controls.Clear();
                DisplayComputer();
                rdoViewGroup.Checked = true;
            }
            else
            {
                chkShowGrid.Checked = false;
                nameTab = "View";
                ptbMap.Controls.Clear();
                ptbMap.ContextMenuStrip = null;
            }
        }

        private void colComputer_EditValueChanged(object sender, EventArgs e)
        {
            colColorComputer.Color = colComputer.Color;
        }

        private void colOther_EditValueChanged(object sender, EventArgs e)
        {
            colColorOther.Color = colOther.Color;
        }

        private void cboSizeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // thay doi co chu cho ten sinh vien duoc hien thi
            foreach (Control item in ptbMap.Controls)
            {
                if (item is TextBox&&item.Tag==(object)"NameStudent")
                {
                    item.Font=new Font("Tahoma", Convert.ToInt32(cboSizeName.Text));
                }
            }
        }





        private void ExportToWord(string fileExport)
        {
            //chụp ảnh
            ScreenMap(this.Location.X+ panel1.Location.X+ptbMap.Location.X+10,this.Location.Y+ panel1.Location.Y+ptbMap.Location.Y+35);
            

            Microsoft.Office.Interop.Word.ApplicationClass wordApp = new Microsoft.Office.Interop.Word.ApplicationClass();
            wordApp.Visible = true;

            //Interop params
            object oMissing = System.Reflection.Missing.Value;
            object save = false;

            //The Word doc paths
            //StreamWriter ghi = new StreamWriter(Application.StartupPath + "\\Test.docx");
            object docFile = Application.StartupPath + "\\Test.docx";
            //MessageBox.Show(docFile.ToString());
            object destFile = fileExport;

            //Open the doc file
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(ref docFile, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);


            //string commentFile = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".tif";

            //wordDoc.Application.Selection.ty
            wordDoc.Application.Selection.Font.Size = 16;
            wordDoc.Application.Selection.Font.Bold = 3;
            wordDoc.Application.Selection.Font.Position = 2;
            string nameRoom = "";
            if (nameTab == "Design")
            {
                nameRoom = cboRoomDesign.Text;
            }
            else
                nameRoom = cboRoom.Text;
            wordDoc.Application.Selection.TypeText("\t\tSƠ ĐỒ PHÒNG THỰC HÀNH "+nameRoom+"-KHOA CNTT");
            wordDoc.Application.Selection.Font.Name = "Arial";
            wordDoc.Application.Selection.Font.Size = 12;
            wordDoc.Application.Selection.Font.Bold = 3;
            wordDoc.Application.Selection.TypeParagraph();

            if (nameTab == "View")
            {
                wordDoc.Application.Selection.TypeText("\t\t\t\t\tLớp:");
                wordDoc.Application.Selection.Font.Bold = 0;
                wordDoc.Application.Selection.TypeText(cboClass.Text);
                wordDoc.Application.Selection.Font.Bold = 3;
                wordDoc.Application.Selection.TypeText("       Nhóm: ");
                wordDoc.Application.Selection.Font.Bold = 0;
                wordDoc.Application.Selection.TypeText(cboGroup.Text);
                wordDoc.Application.Selection.TypeParagraph();
            }
            
            //hiển thị ảnh nên word
            string item = Application.StartupPath + "\\sodo.png";
                wordDoc.Application.Selection.InlineShapes.AddPicture(item, ref oMissing, ref oMissing, ref oMissing);
                wordDoc.Application.Selection.TypeParagraph();
                System.IO.File.Delete(item);//xoa ảnh

            wordDoc.Application.Selection.TypeParagraph();
            wordDoc.Application.Selection.Font.Size = 9;
            wordDoc.Application.Selection.Font.Italic = 3;

            wordDoc.Application.Selection.Font.Bold = 3;
            wordDoc.Application.Selection.Font.Name = "Arial";
            wordDoc.Application.Selection.TypeText("Ghi chú:  ");
            wordDoc.Application.Selection.Font.Bold = 0;

            wordDoc.Application.Selection.TypeText("- Sơ đồ sẽ được phát cho mỗi lớp sinh viên học tại phòng "+nameRoom+". Lớp trưởng sẽ giữ lại để theo dõi");
            wordDoc.Application.Selection.TypeText("\n\t  - Lớp trưởng các lớp cần phải ghi thông tin cố định cho mỗi thành viên trong lớp. Sơ đồ riêng của từng lớp ");
            wordDoc.Application.Selection.TypeText("\n\t  - sẽ được áp dụng cho tất cả các môn học trong mọi buổi thực hành của lớp tại phòng "+nameRoom);
            wordDoc.Application.Selection.TypeText("\n\t  - Mỗi sinh viên có trách nhiệm với máy tính tại vị trí của mình. Nếu có sai hỏng, mất mát sẽ phải bồi thường");

            //try
            //{
                wordDoc.SaveAs(ref destFile, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                // wordApp.Document(ref destFile, ref oMissing, ref oMissing);
            //}
            //catch
            //{
            //    MessageBox.Show("Sơ đồ trước đang mở! hãy đóng lại để ");
            //}
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            //ExportToWord("ketqua");
            
        }

        private void cboRoomUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load lop theo phong
            cboClassUpdate.Properties.Items.Clear();
            cboClassUpdate.Text = "";
            if (cboRoomUpdate.Text != "")
            {
                cboClassUpdate.Enabled = true;
                cboSubjectUpdate.Enabled = false;
                cboGroupUpdate.Enabled = false;
                btnSave.Enabled = false;
                //load lop
                var lstc = (from g in db.StudentPractices where (from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID) select new { g.GroupStudent.Class.ClassName }).Distinct();
                foreach (var item in lstc)
                {
                    cboClassUpdate.Properties.Items.Add(item.ClassName);
                }
            }
        }

        private void cboClassUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load mon theo lop
            cboSubjectUpdate.Properties.Items.Clear();
            cboSubjectUpdate.Text = "";
            if (cboClassUpdate.Text != "")
            {
                cboSubjectUpdate.Enabled = true;
                cboGroupUpdate.Enabled = false;
                btnSave.Enabled = false;
                //load mon hoc
                var lstc = (from g in db.StudentPractices where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) select new { g.GroupStudent.Subject.SubjectName }).Distinct();
                foreach (var item in lstc)
                {
                    cboSubjectUpdate.Properties.Items.Add(item.SubjectName);
                }
            }
        }

        private void cboSubjectUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            //load nhom theo mon
            cboGroupUpdate.Properties.Items.Clear();
            cboGroupUpdate.Text = "";
            if (cboSubjectUpdate.Text != "")
            {
                cboGroupUpdate.Enabled = true;
                btnSave.Enabled = false;
                //load nhom
                var lstc = (from g in db.StudentPractices where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubjectUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) select new { g.GroupStudent.GroupName }).Distinct();
                foreach (var item in lstc)
                {
                    cboGroupUpdate.Properties.Items.Add(item.GroupName);
                }
            }
        }

        private void cboGroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbMap.Controls.Clear();
            btnSave.Enabled = true;
            panelUpdate.Enabled = true;

            rdoUpdateAuto.Checked = true;
            // hien thi so do va ds sinh vien duoc sap xep tu dong
            UpdateAutoMap();

        }
        void UpdateAutoMap()
        {

            //in so do phong- neu chua co so do thi chuyen sang tab thiet ke con khong thi in ra ds
            cboRoomDesign.Text = cboRoomUpdate.Text;
            if (DisplayComputer() == false)
            {
                tabMap.SelectedTabPage = tabDesignMap;
                nameTab = "Design";
                rdoViewGroup.Checked = true;
            }
            else
            {
                //lay ds sinh vien cua phong
                var lst = from g in db.StudentPractices where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubjectUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroupUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) select new { g.Student.FullName, g.StudentPracticeID };
                string[] studentPracticeID =new string[lst.Count()];
                int count = 0;
                foreach (var sv in lst)
                {
                    studentPracticeID[count++]=sv.StudentPracticeID.ToString();
                }
             
                count=0;
                foreach (Button ct in ptbMap.Controls)
                 if(ct.Name.Substring(0,4)=="Comp")//cac button la may tinh
                     ++count;
                //duyet va in sinh vien ra so do
                if (lst.Count() > count)
                    MessageBox.Show("Dư thừa " + (lst.Count() - count) + " sinh viên do tổng số sinh viên lớn hơn tổng số máy tính", "Thông báo");
                else
                    count = lst.Count();

                    int dem = 1;
                    foreach (Control ct in ptbMap.Controls)
                    {
                        if (ct is Button && ct.Name.Substring(0, 4) == "Comp")
                        {
                            //hien thi ten tu dong vao cac so may
                                NameStudent(ct.Text,ct.Left, ct.Top + Convert.ToInt32(cboHeight.Text) + 2, studentPracticeID[dem-1]);
                            //luu tru tam thoi 

                            
                            if (dem == count) break;
                            dem += 1;
                        }
                    }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStudentMap();
            MessageBox.Show("Lưu sơ đồ thành công!","Thông báo!");
        }
        void Clear()
        {
            cboRoom.Text = "";
            cboClass.Text = "";
            cboSubject.Text = "";
            cboGroup.Text = "";
            cboSizeName.Text = "";
            cboRoomUpdate.Text = "";
            cboClassUpdate.Text = "";
            cboSubjectUpdate.Text = "";
            cboGroupUpdate.Text = "";
            rdoUpdateAuto.Checked = true;
        }
        private void rdoInsertGroup_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            if (rdoInsertGroup.Checked)
            {
                cboRoomUpdate.Enabled = true;
                cboRoomUpdate.Properties.Items.Clear();
                var lstg = (from g in db.GroupSessions where (from gm in db.StudentPractices select gm.GroupStudent.GroupStudentID).Contains(g.GroupStudentID) select new { g.PracticeRoom.RoomName }).Distinct();
                foreach (var item in lstg)
                {
                    cboRoomUpdate.Properties.Items.Add(item.RoomName);
                }
            }
            else
                cboRoomUpdate.Enabled = false;

                cboClassUpdate.Enabled = false;
                cboSubjectUpdate.Enabled = false;
                cboGroupUpdate.Enabled = false;
                btnSave.Enabled = false;
                panelUpdate.Enabled = false;
        }

        private void rdoUpdateAuto_CheckedChanged(object sender, EventArgs e)
        {
            //cap nhat so do nhom tu dong
            ptbMap.Controls.Clear();
            if (rdoUpdateAuto.Checked)
            {
                if(cboRoomUpdate.Text!="")
                UpdateAutoMap();
                ctmStudentName.Enabled=false;
            }
            else
                ctmStudentName.Enabled=true; ;
        }

        private void rdoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            //cap nhat so do nhom bang tay
            ptbMap.Controls.Clear(); 
            if (rdoUpdate.Checked)
            {
                //in so do phong- neu chua co so do thi chuyen sang tab thiet ke con khong thi in ra ds
                cboRoomDesign.Text = cboRoomUpdate.Text;
                if (DisplayComputer() == false)
                {
                    tabMap.SelectedTabPage = tabDesignMap;
                    nameTab = "Design";
                    rdoViewGroup.Checked = true;
                }
                else
                {
                    //lay ds sinh vien cua phong
                    var lst = from g in db.StudentPractices where ((from gs in db.GroupSessions where gs.PracticeRoom.RoomName == cboRoomUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Class.ClassName == cboClassUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.Subject.SubjectName == cboSubjectUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) && ((from gs in db.GroupStudents where gs.GroupName == cboGroupUpdate.Text select gs.GroupStudentID).Contains(g.GroupStudent.GroupStudentID)) select new { g.Student.FullName };
                    string[] lstSV = new string[lst.Count()];
                    int count = 0;
                    foreach (var sv in lst)
                    {
                        lstSV[count++] = sv.FullName;
                    }

                   
                }
            }
        }

        private void ptbMap_Click(object sender, EventArgs e)
        {

        }

   

       




    }
}