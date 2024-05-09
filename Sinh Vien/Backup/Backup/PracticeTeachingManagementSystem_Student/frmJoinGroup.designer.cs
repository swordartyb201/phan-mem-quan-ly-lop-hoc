namespace PracticeTeachingManagementSystem_Student
{
    partial class frmJoinGroup
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
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnJoin = new DevExpress.XtraEditors.SimpleButton();
            this.txtStudentCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(66, 48);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(187, 20);
            this.txtPass.TabIndex = 55;
            this.txtPass.EditValueChanged += new System.EventHandler(this.txtPass_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Mật khẩu:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(66, 101);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 57;
            this.btnJoin.Text = "Join";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(66, 21);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(187, 20);
            this.txtStudentCode.TabIndex = 54;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 24);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Mã SV:";
            // 
            // cboSubject
            // 
            this.cboSubject.EditValue = "";
            this.cboSubject.Location = new System.Drawing.Point(66, 74);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubject.Size = new System.Drawing.Size(187, 20);
            this.cboSubject.TabIndex = 56;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Môn học:";
            // 
            // frmJoinGroup
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(285, 148);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(285, 148);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 148);
            this.Name = "frmJoinGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmJoinGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider err;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnJoin;
        private DevExpress.XtraEditors.TextEdit txtStudentCode;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboSubject;
        private DevExpress.XtraEditors.LabelControl labelControl3;


    }
}