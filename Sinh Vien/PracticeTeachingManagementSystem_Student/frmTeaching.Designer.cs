namespace PracticeTeachingManagementSystem_Student
{
    partial class frmTeaching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeaching));
            this.pteTeaching = new System.Windows.Forms.PictureBox();
            this.Runtime = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pteTeaching)).BeginInit();
            this.SuspendLayout();
            // 
            // pteTeaching
            // 
            this.pteTeaching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pteTeaching.Location = new System.Drawing.Point(0, 0);
            this.pteTeaching.Name = "pteTeaching";
            this.pteTeaching.Size = new System.Drawing.Size(497, 258);
            this.pteTeaching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pteTeaching.TabIndex = 0;
            this.pteTeaching.TabStop = false;
            // 
            // Runtime
            // 
            this.Runtime.Interval = 30;
            this.Runtime.Tick += new System.EventHandler(this.Runtime_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmTeaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 258);
            this.Controls.Add(this.pteTeaching);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeaching";
            this.Text = "Lắng nghe bài giảng";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeaching_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeaching_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pteTeaching)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pteTeaching;
        private System.Windows.Forms.Timer Runtime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}