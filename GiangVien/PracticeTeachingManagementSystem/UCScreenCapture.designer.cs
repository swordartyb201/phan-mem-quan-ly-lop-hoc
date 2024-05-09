namespace PracticeTeachingManagementSystem
{
    partial class UCScreenCapture
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labComputerName = new System.Windows.Forms.Label();
            this.pteScreenCapture = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiError = new System.Windows.Forms.ToolStripMenuItem();
            this.xemCấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.runtime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pteScreenCapture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labComputerName
            // 
            this.labComputerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labComputerName.Location = new System.Drawing.Point(0, 131);
            this.labComputerName.Name = "labComputerName";
            this.labComputerName.Size = new System.Drawing.Size(150, 19);
            this.labComputerName.TabIndex = 1;
            this.labComputerName.Text = "label1";
            this.labComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pteScreenCapture
            // 
            this.pteScreenCapture.ContextMenuStrip = this.contextMenuStrip1;
            this.pteScreenCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pteScreenCapture.Image = global::PracticeTeachingManagementSystem.Properties.Resources.Internet_Disconnect;
            this.pteScreenCapture.Location = new System.Drawing.Point(0, 0);
            this.pteScreenCapture.Name = "pteScreenCapture";
            this.pteScreenCapture.Size = new System.Drawing.Size(150, 150);
            this.pteScreenCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pteScreenCapture.TabIndex = 0;
            this.pteScreenCapture.TabStop = false;
            this.pteScreenCapture.Click += new System.EventHandler(this.pteScreenCapture_Click);
            this.pteScreenCapture.DoubleClick += new System.EventHandler(this.pteScreenCapture_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSinhViênToolStripMenuItem,
            //this.chatToolStripMenuItem,
            this.logoffToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            //this.tsmiChangeSpace,
            //this.tsmiError,
            this.xemCấuHìnhToolStripMenuItem,
            /*this.tsm*/});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 224);
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thôngTinSinhViênToolStripMenuItem.Text = "Thông tin sinh viên";
            this.thôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSinhViênToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            //this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            //this.chatToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            //this.chatToolStripMenuItem.Text = "Chat";
            //this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.CheckOnClick = true;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.CheckOnClick = true;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.CheckOnClick = true;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.CheckedChanged += new System.EventHandler(this.shutdownToolStripMenuItem_CheckedChanged);
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // tsmiChangeSpace
            // 
            //this.tsmiChangeSpace.Name = "tsmiChangeSpace";
            //this.tsmiChangeSpace.Size = new System.Drawing.Size(198, 22);
            //this.tsmiChangeSpace.Text = "Đổi chỗ máy sinh viên";
            //this.tsmiChangeSpace.Click += new System.EventHandler(this.tsmiChangeSpace_Click);
            // 
            // tsmiError
            // 
            //this.tsmiError.Name = "tsmiError";
            //this.tsmiError.Size = new System.Drawing.Size(198, 22);
            //this.tsmiError.Text = "Lỗi máy tính";
            //this.tsmiError.Click += new System.EventHandler(this.tsmiError_Click);
            // 
            // xemCấuHìnhToolStripMenuItem
            // 
            this.xemCấuHìnhToolStripMenuItem.Name = "xemCấuHìnhToolStripMenuItem";
            this.xemCấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.xemCấuHìnhToolStripMenuItem.Text = "Cấu hình của máy";
            this.xemCấuHìnhToolStripMenuItem.Click += new System.EventHandler(this.xemCấuHìnhToolStripMenuItem_Click);
            // 
            // tsm
            // 
            //this.tsm.CheckOnClick = true;
            //this.tsm.Name = "tsm";
            //this.tsm.Size = new System.Drawing.Size(198, 22);
            //this.tsm.Text = "Cảnh báo đến sinh viên";
            //this.tsm.Visible = false;
            //this.tsm.Click += new System.EventHandler(this.cảnhBáoChoSinhViênToolStripMenuItem_Click);
            // 
            // runtime
            // 
            this.runtime.Tick += new System.EventHandler(this.runtime_Tick);
            // 
            // UCScreenCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labComputerName);
            this.Controls.Add(this.pteScreenCapture);
            this.Name = "UCScreenCapture";
            ((System.ComponentModel.ISupportInitialize)(this.pteScreenCapture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pteScreenCapture;
        private System.Windows.Forms.Label labComputerName;
        private System.Windows.Forms.Timer runtime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeSpace;
        private System.Windows.Forms.ToolStripMenuItem tsmiError;
        private System.Windows.Forms.ToolStripMenuItem xemCấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm;
    }
}
