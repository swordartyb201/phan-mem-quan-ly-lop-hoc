namespace PracticeTeachingManagementSystem
{
    partial class UCTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTool));
            this.rbtControl = new System.Windows.Forms.RadioButton();
            this.rbtLockKeyBoard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtControl
            // 
            this.rbtControl.AutoSize = true;
            this.rbtControl.Checked = true;
            this.rbtControl.Location = new System.Drawing.Point(4, 17);
            this.rbtControl.Name = "rbtControl";
            this.rbtControl.Size = new System.Drawing.Size(75, 17);
            this.rbtControl.TabIndex = 1;
            this.rbtControl.TabStop = true;
            this.rbtControl.Text = "Điều khiển";
            this.rbtControl.UseVisualStyleBackColor = true;
            this.rbtControl.CheckedChanged += new System.EventHandler(this.rbtControl_CheckedChanged);
            // 
            // rbtLockKeyBoard
            // 
            this.rbtLockKeyBoard.AutoSize = true;
            this.rbtLockKeyBoard.Location = new System.Drawing.Point(4, 40);
            this.rbtLockKeyBoard.Name = "rbtLockKeyBoard";
            this.rbtLockKeyBoard.Size = new System.Drawing.Size(138, 17);
            this.rbtLockKeyBoard.TabIndex = 2;
            this.rbtLockKeyBoard.TabStop = true;
            this.rbtLockKeyBoard.Text = "Khóa chuột && bàn phím ";
            this.rbtLockKeyBoard.UseVisualStyleBackColor = true;
            this.rbtLockKeyBoard.CheckedChanged += new System.EventHandler(this.rbtLockKeyBoard_CheckedChanged);
            // 
            // UCTool
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rbtLockKeyBoard);
            this.Controls.Add(this.rbtControl);
            this.DoubleBuffered = true;
            this.Name = "UCTool";
            this.Size = new System.Drawing.Size(148, 76);
            this.Load += new System.EventHandler(this.UCTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtControl;
        private System.Windows.Forms.RadioButton rbtLockKeyBoard;
    }
}
