namespace PracticeTeachingManagementSystem_Student
{
    partial class frmSendQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendQuestion));
            this.lviChat = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lviChat
            // 
            this.lviChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lviChat.GridLines = true;
            this.lviChat.Location = new System.Drawing.Point(215, 136);
            this.lviChat.Name = "lviChat";
            this.lviChat.Size = new System.Drawing.Size(243, 304);
            this.lviChat.TabIndex = 35;
            this.lviChat.UseCompatibleStateImageBehavior = false;
            this.lviChat.View = System.Windows.Forms.View.Details;
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
            // frmSendQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 501);
            this.Controls.Add(this.lviChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Student";
            this.Load += new System.EventHandler(this.frmSendQuestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lviChat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}