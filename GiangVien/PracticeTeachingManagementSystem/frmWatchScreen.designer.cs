namespace PracticeTeachingManagementSystem
{
    partial class frmWatchScreen
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
            this.tlpListComputer = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateIP = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tlpListComputer
            // 
            this.tlpListComputer.AutoSize = true;
            this.tlpListComputer.ColumnCount = 1;
            this.tlpListComputer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListComputer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListComputer.Location = new System.Drawing.Point(0, 0);
            this.tlpListComputer.Name = "tlpListComputer";
            this.tlpListComputer.RowCount = 1;
            this.tlpListComputer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.87156F));
            this.tlpListComputer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.12844F));
            this.tlpListComputer.Size = new System.Drawing.Size(862, 570);
            this.tlpListComputer.TabIndex = 0;
            // 
            // UpdateIP
            // 
            this.UpdateIP.Enabled = true;
            this.UpdateIP.Interval = 5000;
            this.UpdateIP.Tick += new System.EventHandler(this.UpdateIP_Tick);
            // 
            // frmWatchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 570);
            this.Controls.Add(this.tlpListComputer);
            this.MaximizeBox = false;
            this.Name = "frmWatchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem màn hình SV";
            this.Load += new System.EventHandler(this.frmWatchScreen_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWatchScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListComputer;
        private System.Windows.Forms.Timer UpdateIP;
    }
}