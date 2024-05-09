namespace PracticeTeachingManagementSystem_Student
{
    partial class frmImformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImformation));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnAcept = new DevExpress.XtraEditors.SimpleButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grImformation = new DevExpress.XtraEditors.GroupControl();
            this.cboRoom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtComputerNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grImformation)).BeginInit();
            this.grImformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 33;
            this.label1.Text = "CÀI ĐẶT THÔNG TIN MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 117);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 47);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Tên phòng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 16);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Số máy";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 71);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 16);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(72, 68);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(208, 22);
            this.txtPass.TabIndex = 36;
            this.txtPass.EditValueChanged += new System.EventHandler(this.txtPass_EditValueChanged);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(312, 66);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(88, 28);
            this.btnAcept.TabIndex = 34;
            this.btnAcept.Text = "Đồng ý";
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // grImformation
            // 
            this.grImformation.Controls.Add(this.cboRoom);
            this.grImformation.Controls.Add(this.btnSave);
            this.grImformation.Controls.Add(this.labelControl1);
            this.grImformation.Controls.Add(this.txtComputerNumber);
            this.grImformation.Controls.Add(this.labelControl2);
            this.grImformation.Location = new System.Drawing.Point(14, 102);
            this.grImformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grImformation.Name = "grImformation";
            this.grImformation.Size = new System.Drawing.Size(385, 160);
            this.grImformation.TabIndex = 38;
            this.grImformation.Text = "Thông tin";
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(78, 43);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoom.Size = new System.Drawing.Size(262, 22);
            this.cboRoom.TabIndex = 38;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // txtComputerNumber
            // 
            this.txtComputerNumber.Location = new System.Drawing.Point(78, 80);
            this.txtComputerNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComputerNumber.Name = "txtComputerNumber";
            this.txtComputerNumber.Properties.MaxLength = 3;
            this.txtComputerNumber.Size = new System.Drawing.Size(262, 22);
            this.txtComputerNumber.TabIndex = 36;
            this.txtComputerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComputerNumber_KeyPress);
            // 
            // frmImformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 274);
            this.Controls.Add(this.grImformation);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmImformation.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmImformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Student";
            this.Load += new System.EventHandler(this.frmImformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grImformation)).EndInit();
            this.grImformation.ResumeLayout(false);
            this.grImformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton btnAcept;
        private System.Windows.Forms.ErrorProvider error;
        private DevExpress.XtraEditors.GroupControl grImformation;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoom;
        private DevExpress.XtraEditors.TextEdit txtComputerNumber;
    }
}