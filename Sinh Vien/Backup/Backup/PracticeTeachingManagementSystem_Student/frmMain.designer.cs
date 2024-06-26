namespace PracticeTeachingManagementSystem_Student
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiChat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiWatchCallRool = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInfoComputer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfig = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChatGroup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSenFile = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfig1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgFind = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.lblNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblClass = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblRoom = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thuNhỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonKeyTip = "";
            this.ribbon.ApplicationIcon = null;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiChat,
            this.bbiWatchCallRool,
            this.bbiInfoComputer,
            this.bbiConfig,
            this.bbiHelp,
            this.barButtonItem2,
            this.bbiChangePass,
            this.bbiChatGroup,
            this.bbiSenFile,
            this.bbiConfig1,
            this.barButtonItem5,
            this.barButtonItem4,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbon.LargeImages = this.imageCollection1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.rbgFind});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ribbon.SelectedPage = this.rbgFind;
            this.ribbon.Size = new System.Drawing.Size(328, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbiChat
            // 
            this.bbiChat.Caption = "Trao đổi với Giảng Viên";
            this.bbiChat.Id = 4;
            this.bbiChat.LargeImageIndex = 11;
            this.bbiChat.LargeWidth = 120;
            this.bbiChat.Name = "bbiChat";
            this.bbiChat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bbiWatchCallRool
            // 
            this.bbiWatchCallRool.Caption = "TT điểm danh";
            this.bbiWatchCallRool.Id = 6;
            this.bbiWatchCallRool.LargeImageIndex = 15;
            this.bbiWatchCallRool.LargeWidth = 70;
            this.bbiWatchCallRool.Name = "bbiWatchCallRool";
            this.bbiWatchCallRool.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiWatchCallRool_ItemClick);
            // 
            // bbiInfoComputer
            // 
            this.bbiInfoComputer.Caption = "Thông tin máy";
            this.bbiInfoComputer.Id = 8;
            this.bbiInfoComputer.LargeImageIndex = 10;
            this.bbiInfoComputer.LargeWidth = 80;
            this.bbiInfoComputer.Name = "bbiInfoComputer";
            this.bbiInfoComputer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiConfig
            // 
            this.bbiConfig.Caption = "Cấu hình máy";
            this.bbiConfig.Id = 9;
            this.bbiConfig.LargeImageIndex = 14;
            this.bbiConfig.LargeWidth = 80;
            this.bbiConfig.Name = "bbiConfig";
            this.bbiConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConfig_ItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Trợ giúp";
            this.bbiHelp.Id = 10;
            this.bbiHelp.LargeImageIndex = 7;
            this.bbiHelp.LargeWidth = 100;
            this.bbiHelp.Name = "bbiHelp";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bbiChangePass
            // 
            this.bbiChangePass.Caption = "Đổi mật khẩu";
            this.bbiChangePass.Id = 12;
            this.bbiChangePass.LargeImageIndex = 3;
            this.bbiChangePass.LargeWidth = 100;
            this.bbiChangePass.Name = "bbiChangePass";
            this.bbiChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePass_ItemClick);
            // 
            // bbiChatGroup
            // 
            this.bbiChatGroup.Caption = "Trao đổi nhóm";
            this.bbiChatGroup.Id = 13;
            this.bbiChatGroup.LargeImageIndex = 1;
            this.bbiChatGroup.LargeWidth = 80;
            this.bbiChatGroup.Name = "bbiChatGroup";
            this.bbiChatGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bbiSenFile
            // 
            this.bbiSenFile.Caption = "Gửi file";
            this.bbiSenFile.Id = 14;
            this.bbiSenFile.LargeImageIndex = 6;
            this.bbiSenFile.LargeWidth = 70;
            this.bbiSenFile.Name = "bbiSenFile";
            this.bbiSenFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // bbiConfig1
            // 
            this.bbiConfig1.Caption = "Cấu hình máy";
            this.bbiConfig1.Id = 18;
            this.bbiConfig1.LargeImageIndex = 14;
            this.bbiConfig1.LargeWidth = 80;
            this.bbiConfig1.Name = "bbiConfig1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Cài đặt thông tin máy";
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.LargeImageIndex = 10;
            this.barButtonItem5.LargeWidth = 110;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Help";
            this.barButtonItem4.Id = 20;
            this.barButtonItem4.LargeImageIndex = 7;
            this.barButtonItem4.LargeWidth = 80;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cấu hình máy";
            this.barButtonItem6.Id = 22;
            this.barButtonItem6.LargeImageIndex = 14;
            this.barButtonItem6.LargeWidth = 75;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Cài đặt TT máy";
            this.barButtonItem7.Id = 23;
            this.barButtonItem7.LargeImageIndex = 10;
            this.barButtonItem7.LargeWidth = 80;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Help";
            this.barButtonItem8.Id = 24;
            this.barButtonItem8.LargeImageIndex = 7;
            this.barButtonItem8.LargeWidth = 55;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.KeyTip = "";
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Trao đổi thông tin";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiChat);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiChatGroup);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiSenFile);
            this.ribbonPageGroup5.KeyTip = "";
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // rbgFind
            // 
            this.rbgFind.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgInfo});
            this.rbgFind.KeyTip = "";
            this.rbgFind.Name = "rbgFind";
            this.rbgFind.Text = "Tiện ích";
            // 
            // rpgInfo
            // 
            this.rpgInfo.ItemLinks.Add(this.bbiWatchCallRool);
            this.rpgInfo.ItemLinks.Add(this.barButtonItem6);
            this.rpgInfo.ItemLinks.Add(this.barButtonItem7);
            this.rpgInfo.ItemLinks.Add(this.barButtonItem8);
            this.rpgInfo.KeyTip = "";
            this.rpgInfo.Name = "rpgInfo";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 401);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(328, 23);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.lblNumber);
            this.clientPanel.Controls.Add(this.lblCode);
            this.clientPanel.Controls.Add(this.lblClass);
            this.clientPanel.Controls.Add(this.lblName);
            this.clientPanel.Controls.Add(this.lblRoom);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 147);
            this.clientPanel.LookAndFeel.SkinName = "Money Twins";
            this.clientPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(328, 254);
            this.clientPanel.TabIndex = 2;
            this.clientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.clientPanel_Paint);
            // 
            // lblNumber
            // 
            this.lblNumber.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Appearance.Options.UseBackColor = true;
            this.lblNumber.Appearance.Options.UseFont = true;
            this.lblNumber.Location = new System.Drawing.Point(136, 194);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 14);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Số máy:";
            // 
            // lblCode
            // 
            this.lblCode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Appearance.Options.UseBackColor = true;
            this.lblCode.Appearance.Options.UseFont = true;
            this.lblCode.Location = new System.Drawing.Point(14, 214);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 14);
            this.lblCode.TabIndex = 13;
            this.lblCode.Text = "Mã SV:";
            // 
            // lblClass
            // 
            this.lblClass.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Appearance.Options.UseBackColor = true;
            this.lblClass.Appearance.Options.UseFont = true;
            this.lblClass.Location = new System.Drawing.Point(242, 194);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(24, 14);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "Lớp:";
            // 
            // lblName
            // 
            this.lblName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.Options.UseBackColor = true;
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(135, 214);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 14);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Tên SV:";
            // 
            // lblRoom
            // 
            this.lblRoom.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Appearance.Options.UseBackColor = true;
            this.lblRoom.Appearance.Options.UseFont = true;
            this.lblRoom.Location = new System.Drawing.Point(14, 194);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(43, 14);
            this.lblRoom.TabIndex = 12;
            this.lblRoom.Text = "Phòng: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hệ thống sinh viên";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuNhỏToolStripMenuItem,
            this.tsmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // thuNhỏToolStripMenuItem
            // 
            this.thuNhỏToolStripMenuItem.CheckOnClick = true;
            this.thuNhỏToolStripMenuItem.Name = "thuNhỏToolStripMenuItem";
            this.thuNhỏToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.thuNhỏToolStripMenuItem.Text = "Thu nhỏ";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(119, 22);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 424);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 425);
            this.MinimumSize = new System.Drawing.Size(336, 425);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbgFind;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgInfo;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem bbiChat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem bbiWatchCallRool;
        private DevExpress.XtraBars.BarButtonItem bbiInfoComputer;
        private DevExpress.XtraBars.BarButtonItem bbiConfig;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbiChangePass;
        private DevExpress.XtraBars.BarButtonItem bbiChatGroup;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thuNhỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private DevExpress.XtraBars.BarButtonItem bbiSenFile;
        private System.Windows.Forms.Timer timer4;
        private DevExpress.XtraBars.BarButtonItem bbiConfig1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraEditors.LabelControl lblNumber;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblClass;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblRoom;
    }
}