namespace PracticeTeachingManagementSystem_Student
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbtShow = new System.Windows.Forms.RichTextBox();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttbB = new System.Windows.Forms.ToolStripButton();
            this.ttbI = new System.Windows.Forms.ToolStripButton();
            this.ttbU = new System.Windows.Forms.ToolStripButton();
            this.ttbColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ttbImgare = new System.Windows.Forms.ToolStripButton();
            this.ttbT = new System.Windows.Forms.ToolStripButton();
            this.ttbBuzz = new System.Windows.Forms.ToolStripButton();
            this.ttbFile = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSize
            // 
            this.cboSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(260, 237);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(48, 21);
            this.cboSize.TabIndex = 60;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // cboFont
            // 
            this.cboFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(133, 236);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 21);
            this.cboFont.TabIndex = 59;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(612, 275);
            this.bar1.FloatSize = new System.Drawing.Size(342, 20);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cãìt";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sao cheìp";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Daìn";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Xoìa";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Choòn tâìt caÒ";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Lýu";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(250, 285);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 39);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lbtShow);
            this.groupControl1.Location = new System.Drawing.Point(7, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(299, 218);
            this.groupControl1.TabIndex = 52;
            this.groupControl1.Text = " Chat với giảng viên";
            // 
            // lbtShow
            // 
            this.lbtShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtShow.Location = new System.Drawing.Point(5, 23);
            this.lbtShow.Name = "lbtShow";
            this.lbtShow.Size = new System.Drawing.Size(286, 190);
            this.lbtShow.TabIndex = 37;
            this.lbtShow.Text = "";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.barManager1.MaxItemId = 9;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(8, 288);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(236, 35);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttbB,
            this.ttbI,
            this.ttbU,
            this.ttbColor});
            this.toolStrip1.Location = new System.Drawing.Point(7, 233);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 77;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ttbB
            // 
            this.ttbB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbB.Image = ((System.Drawing.Image)(resources.GetObject("ttbB.Image")));
            this.ttbB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbB.Name = "ttbB";
            this.ttbB.Size = new System.Drawing.Size(23, 22);
            this.ttbB.Text = "B";
            this.ttbB.Click += new System.EventHandler(this.ttbB_Click);
            // 
            // ttbI
            // 
            this.ttbI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbI.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbI.Image = ((System.Drawing.Image)(resources.GetObject("ttbI.Image")));
            this.ttbI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbI.Name = "ttbI";
            this.ttbI.Size = new System.Drawing.Size(23, 22);
            this.ttbI.Text = "I";
            this.ttbI.Click += new System.EventHandler(this.ttbI_Click);
            // 
            // ttbU
            // 
            this.ttbU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbU.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbU.Image = ((System.Drawing.Image)(resources.GetObject("ttbU.Image")));
            this.ttbU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbU.Name = "ttbU";
            this.ttbU.Size = new System.Drawing.Size(23, 22);
            this.ttbU.Text = "U";
            this.ttbU.Click += new System.EventHandler(this.ttbU_Click);
            // 
            // ttbColor
            // 
            this.ttbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbColor.Image = ((System.Drawing.Image)(resources.GetObject("ttbColor.Image")));
            this.ttbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbColor.Name = "ttbColor";
            this.ttbColor.Size = new System.Drawing.Size(23, 22);
            this.ttbColor.Text = "Chọn màu";
            this.ttbColor.Click += new System.EventHandler(this.ttbColor_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttbImgare,
            this.ttbT,
            this.ttbBuzz,
            this.ttbFile});
            this.toolStrip2.Location = new System.Drawing.Point(7, 258);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(104, 25);
            this.toolStrip2.TabIndex = 78;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ttbImgare
            // 
            this.ttbImgare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbImgare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbImgare.Image = ((System.Drawing.Image)(resources.GetObject("ttbImgare.Image")));
            this.ttbImgare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbImgare.Name = "ttbImgare";
            this.ttbImgare.Size = new System.Drawing.Size(23, 22);
            this.ttbImgare.Text = "Trạng thái";
            this.ttbImgare.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // ttbT
            // 
            this.ttbT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbT.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbT.Image = ((System.Drawing.Image)(resources.GetObject("ttbT.Image")));
            this.ttbT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbT.Name = "ttbT";
            this.ttbT.Size = new System.Drawing.Size(23, 22);
            this.ttbT.Text = "T";
            // 
            // ttbBuzz
            // 
            this.ttbBuzz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbBuzz.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbBuzz.Image = ((System.Drawing.Image)(resources.GetObject("ttbBuzz.Image")));
            this.ttbBuzz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbBuzz.Name = "ttbBuzz";
            this.ttbBuzz.Size = new System.Drawing.Size(23, 22);
            this.ttbBuzz.Text = "Buzz";
            this.ttbBuzz.Click += new System.EventHandler(this.ttbBuzz_Click);
            // 
            // ttbFile
            // 
            this.ttbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbFile.Image = ((System.Drawing.Image)(resources.GetObject("ttbFile.Image")));
            this.ttbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbFile.Name = "ttbFile";
            this.ttbFile.Size = new System.Drawing.Size(23, 22);
            this.ttbFile.Text = "Gửi file";
            this.ttbFile.Click += new System.EventHandler(this.ttbFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 337);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(327, 371);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Student";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboFont;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox lbtShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ttbB;
        private System.Windows.Forms.ToolStripButton ttbI;
        private System.Windows.Forms.ToolStripButton ttbU;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ttbImgare;
        private System.Windows.Forms.ToolStripButton ttbT;
        private System.Windows.Forms.ToolStripButton ttbBuzz;
        private System.Windows.Forms.ToolStripButton ttbFile;
        private System.Windows.Forms.ToolStripButton ttbColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}