namespace PracticeTeachingManagementSystem
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dtpBirth = new DevExpress.XtraEditors.DateEdit();
            this.txtStudentCode = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteStudent = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 39);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(25, 16);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Lớp:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(152, 94);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 28);
            this.btnInsert.TabIndex = 55;
            this.btnInsert.Text = "&Cập nhật";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gcStudent
            // 
            this.gcStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStudent.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudent.Location = new System.Drawing.Point(9, 132);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(1368, 452);
            this.gcStudent.TabIndex = 59;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            this.gcStudent.Click += new System.EventHandler(this.gcStudent_Click);
            // 
            // gvStudent
            // 
            this.gvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5});
            this.gvStudent.DetailHeight = 431;
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.GroupPanelText = "Dùng chuột kéo thả các cột vào đây để gom nhóm dữ liệu theo cột đó";
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.OptionsSelection.MultiSelect = true;
            this.gvStudent.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvStudent.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lớp";
            this.gridColumn1.FieldName = "ClassName";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 82;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã sinh viên";
            this.gridColumn2.FieldName = "StudentCode";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 117;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ tên";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 210;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày sinh";
            this.gridColumn5.FieldName = "BirthDay";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 93;
            // 
            // cboClass
            // 
            this.cboClass.Location = new System.Drawing.Point(48, 36);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClass.Size = new System.Drawing.Size(189, 22);
            this.cboClass.TabIndex = 2;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(57, 94);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.EditValue = null;
            this.dtpBirth.Location = new System.Drawing.Point(972, 36);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpBirth.Size = new System.Drawing.Size(271, 22);
            this.dtpBirth.TabIndex = 5;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.EditValue = "";
            this.txtStudentCode.Location = new System.Drawing.Point(341, 36);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Properties.MaxLength = 10;
            this.txtStudentCode.Size = new System.Drawing.Size(189, 22);
            this.txtStudentCode.TabIndex = 3;
            this.txtStudentCode.ToolTip = "Nhập mã sinh viên nhỏ hơn 10 ký tự";
            this.txtStudentCode.EditValueChanged += new System.EventHandler(this.txtStudentCode_EditValueChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(611, 36);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.MaxLength = 50;
            this.txtFullName.Size = new System.Drawing.Size(271, 22);
            this.txtFullName.TabIndex = 4;
            this.txtFullName.ToolTip = "Nhập tên học sinh nhỏ hơn 50 ký tự!";
            this.txtFullName.EditValueChanged += new System.EventHandler(this.txtFullName_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(906, 39);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Ngày sinh:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(559, 39);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Họ tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(262, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Mã sinh viên:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(247, 94);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(88, 28);
            this.btnDeleteStudent.TabIndex = 62;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(343, 94);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboClass);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dtpBirth);
            this.groupControl1.Controls.Add(this.txtFullName);
            this.groupControl1.Controls.Add(this.txtStudentCode);
            this.groupControl1.Location = new System.Drawing.Point(9, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1258, 76);
            this.groupControl1.TabIndex = 63;
            this.groupControl1.Text = "Nhập thông tin sinh viên";
            // 
            // frmStudent
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 598);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.btnRefresh);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmStudent.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật sinh viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.ComboBoxEdit cboClass;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.DateEdit dtpBirth;
        private DevExpress.XtraEditors.TextEdit txtStudentCode;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteStudent;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}