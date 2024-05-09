namespace PracticeTeachingManagementSystem_Student
{
    partial class frmBg
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblInf = new System.Windows.Forms.Label();
            this.lbltitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblInf
            // 
            this.lblInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInf.BackColor = System.Drawing.Color.Transparent;
            this.lblInf.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf.ForeColor = System.Drawing.Color.Snow;
            this.lblInf.Location = new System.Drawing.Point(116, 161);
            this.lblInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(773, 69);
            this.lblInf.TabIndex = 1;
            this.lblInf.Text = "Hệ thống quản lý phòng máy thực hành và hỗ trợ giảng dạy trong mạng Lan .        " +
    "                                                 ";
            this.lblInf.Click += new System.EventHandler(this.lblInf_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.lbltitle.Appearance.Options.UseFont = true;
            this.lbltitle.Appearance.Options.UseForeColor = true;
            this.lbltitle.Location = new System.Drawing.Point(270, 53);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(89, 40);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "lbltitle";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 247);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(344, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sinh viên click vào form hoặc bấm phím bất kì để đăng nhập";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::PracticeTeachingManagementSystem_Student.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblInf);
            this.ForeColor = System.Drawing.Color.LightCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBg";
            this.ShowIcon = false;
            this.Text = "frmBg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBg_FormClosing);
            this.Load += new System.EventHandler(this.frmBg_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBg_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmBg_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblInf;
        private DevExpress.XtraEditors.LabelControl lbltitle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button button1;
    }
}