namespace PracticeTeachingManagementSystem
{
    partial class frmSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSend));
            this.lviSendFile = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lviSendFile
            // 
            this.lviSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviSendFile.CheckBoxes = true;
            this.lviSendFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7});
            this.lviSendFile.FullRowSelect = true;
            this.lviSendFile.GridLines = true;
            this.lviSendFile.HideSelection = false;
            this.lviSendFile.Location = new System.Drawing.Point(14, 15);
            this.lviSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.lviSendFile.Name = "lviSendFile";
            this.lviSendFile.Size = new System.Drawing.Size(540, 235);
            this.lviSendFile.TabIndex = 11;
            this.lviSendFile.UseCompatibleStateImageBehavior = false;
            this.lviSendFile.View = System.Windows.Forms.View.Details;
            this.lviSendFile.Click += new System.EventHandler(this.lviSendFile_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 291;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số máy";
            this.columnHeader6.Width = 213;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IP";
            // 
            // prgFile
            // 
            this.prgFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgFile.Location = new System.Drawing.Point(12, 300);
            this.prgFile.Margin = new System.Windows.Forms.Padding(4);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(540, 28);
            this.prgFile.TabIndex = 12;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(14, 258);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(84, 34);
            this.btnSelectAll.TabIndex = 13;
            this.btnSelectAll.Text = "Chọn tất cả";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnSelectAll.Location = new System.Drawing.Point(105, 258);
            this.btnUnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Size = new System.Drawing.Size(84, 34);
            this.btnUnSelectAll.TabIndex = 14;
            this.btnUnSelectAll.Text = "Bỏ chọn";
            this.btnUnSelectAll.Click += new System.EventHandler(this.btnUnSelectAll_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Đường dẫn :";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(514, 261);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 26);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = ". . .";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(310, 262);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(197, 22);
            this.txtFile.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Location = new System.Drawing.Point(196, 266);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 21);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // frmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 337);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnSelectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.prgFile);
            this.Controls.Add(this.lviSendFile);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSend.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Teacher";
            this.Load += new System.EventHandler(this.frmSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviSendFile;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ProgressBar prgFile;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnUnSelectAll;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}