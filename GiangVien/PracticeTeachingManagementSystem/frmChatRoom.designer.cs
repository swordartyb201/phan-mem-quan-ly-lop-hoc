namespace PracticeTeachingManagementSystem
{
    partial class frmChatRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatRoom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttbB = new System.Windows.Forms.ToolStripButton();
            this.ttbI = new System.Windows.Forms.ToolStripButton();
            this.ttbU = new System.Windows.Forms.ToolStripButton();
            this.ttbColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ttbImgare = new System.Windows.Forms.ToolStripButton();
            this.ttbT = new System.Windows.Forms.ToolStripButton();
            this.ttbBuzz = new System.Windows.Forms.ToolStripButton();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lbtShow = new System.Windows.Forms.RichTextBox();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.lviChat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.cboFont);
            this.groupBox1.Controls.Add(this.cboSize);
            this.groupBox1.Controls.Add(this.lbtShow);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.lviChat);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(595, 508);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trao đổi thông tin nhóm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttbB,
            this.ttbI,
            this.ttbU,
            this.ttbColor});
            this.toolStrip1.Location = new System.Drawing.Point(9, 369);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(129, 27);
            this.toolStrip1.TabIndex = 84;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ttbB
            // 
            this.ttbB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbB.Image = ((System.Drawing.Image)(resources.GetObject("ttbB.Image")));
            this.ttbB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbB.Name = "ttbB";
            this.ttbB.Size = new System.Drawing.Size(29, 24);
            this.ttbB.Text = "B";
            this.ttbB.Click += new System.EventHandler(this.ttbB_Click_1);
            // 
            // ttbI
            // 
            this.ttbI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbI.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbI.Image = ((System.Drawing.Image)(resources.GetObject("ttbI.Image")));
            this.ttbI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbI.Name = "ttbI";
            this.ttbI.Size = new System.Drawing.Size(29, 24);
            this.ttbI.Text = "I";
            this.ttbI.Click += new System.EventHandler(this.ttbI_Click_1);
            // 
            // ttbU
            // 
            this.ttbU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttbU.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbU.Image = ((System.Drawing.Image)(resources.GetObject("ttbU.Image")));
            this.ttbU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbU.Name = "ttbU";
            this.ttbU.Size = new System.Drawing.Size(29, 24);
            this.ttbU.Text = "U";
            this.ttbU.Click += new System.EventHandler(this.ttbU_Click_1);
            // 
            // ttbColor
            // 
            this.ttbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbColor.Image = ((System.Drawing.Image)(resources.GetObject("ttbColor.Image")));
            this.ttbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbColor.Name = "ttbColor";
            this.ttbColor.Size = new System.Drawing.Size(29, 24);
            this.ttbColor.Text = "Chọn màu";
            this.ttbColor.Click += new System.EventHandler(this.ttbColor_Click_1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttbImgare,
            this.ttbT,
            this.ttbBuzz});
            this.toolStrip2.Location = new System.Drawing.Point(10, 395);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(100, 27);
            this.toolStrip2.TabIndex = 85;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ttbImgare
            // 
            this.ttbImgare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbImgare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbImgare.Image = ((System.Drawing.Image)(resources.GetObject("ttbImgare.Image")));
            this.ttbImgare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbImgare.Name = "ttbImgare";
            this.ttbImgare.Size = new System.Drawing.Size(29, 24);
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
            this.ttbT.Size = new System.Drawing.Size(29, 24);
            this.ttbT.Text = "T";
            this.ttbT.Click += new System.EventHandler(this.ttbT_Click);
            // 
            // ttbBuzz
            // 
            this.ttbBuzz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbBuzz.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttbBuzz.Image = ((System.Drawing.Image)(resources.GetObject("ttbBuzz.Image")));
            this.ttbBuzz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbBuzz.Name = "ttbBuzz";
            this.ttbBuzz.Size = new System.Drawing.Size(29, 24);
            this.ttbBuzz.Text = "Buzz";
            this.ttbBuzz.Click += new System.EventHandler(this.ttbBuzz_Click_1);
            // 
            // cboFont
            // 
            this.cboFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(141, 368);
            this.cboFont.Margin = new System.Windows.Forms.Padding(4);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(204, 24);
            this.cboFont.TabIndex = 82;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged_1);
            // 
            // cboSize
            // 
            this.cboSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(351, 368);
            this.cboSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(47, 24);
            this.cboSize.TabIndex = 83;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged_1);
            // 
            // lbtShow
            // 
            this.lbtShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtShow.Location = new System.Drawing.Point(13, 25);
            this.lbtShow.Margin = new System.Windows.Forms.Padding(4);
            this.lbtShow.Name = "lbtShow";
            this.lbtShow.Size = new System.Drawing.Size(340, 333);
            this.lbtShow.TabIndex = 2;
            this.lbtShow.Text = "";
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(12, 434);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(480, 58);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // lviChat
            // 
            this.lviChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviChat.GridLines = true;
            this.lviChat.HideSelection = false;
            this.lviChat.Location = new System.Drawing.Point(360, 25);
            this.lviChat.Margin = new System.Windows.Forms.Padding(4);
            this.lviChat.Name = "lviChat";
            this.lviChat.Size = new System.Drawing.Size(230, 333);
            this.lviChat.TabIndex = 34;
            this.lviChat.UseCompatibleStateImageBehavior = false;
            this.lviChat.View = System.Windows.Forms.View.Details;
            this.lviChat.SelectedIndexChanged += new System.EventHandler(this.lviChat_SelectedIndexChanged);
            this.lviChat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviChat_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sinh viên";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số máy";
            this.columnHeader2.Width = 171;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(499, 433);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 58);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi nội dung";
            this.btnSend.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmChatRoom
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 522);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmChatRoom.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChatRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChatRoom_FormClosing);
            this.Load += new System.EventHandler(this.frmChatRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lviChat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RichTextBox lbtShow;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ttbB;
        private System.Windows.Forms.ToolStripButton ttbI;
        private System.Windows.Forms.ToolStripButton ttbU;
        private System.Windows.Forms.ToolStripButton ttbColor;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ttbImgare;
        private System.Windows.Forms.ToolStripButton ttbT;
        private System.Windows.Forms.ToolStripButton ttbBuzz;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Timer timer2;
    }
}