namespace PracticeTeachingManagementSystem
{
    partial class frmRemoting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoting));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pteRemoting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pteRemoting)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pteRemoting
            // 
            this.pteRemoting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pteRemoting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pteRemoting.Location = new System.Drawing.Point(0, 0);
            this.pteRemoting.Name = "pteRemoting";
            this.pteRemoting.Size = new System.Drawing.Size(796, 566);
            this.pteRemoting.TabIndex = 2;
            this.pteRemoting.TabStop = false;
            this.pteRemoting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pteRemoting_MouseMove);
            this.pteRemoting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pteRemoting_MouseDown);
            this.pteRemoting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pteRemoting_MouseUp);
            // 
            // frmRemoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(796, 566);
            this.Controls.Add(this.pteRemoting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(798, 568);
            this.Name = "frmRemoting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Teacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRemoting_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRemoting_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRemoting_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoting_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRemoting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pteRemoting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pteRemoting;

    }
}