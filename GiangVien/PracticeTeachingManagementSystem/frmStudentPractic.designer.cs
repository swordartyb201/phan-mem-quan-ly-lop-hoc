namespace PracticeTeachingManagementSystem
{
    partial class frmStudentPractic_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentPractic_));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboClassName = new DevExpress.XtraEditors.LookUpEdit();
            this.cboStudent = new DevExpress.XtraEditors.LookUpEdit();
            this.ckeTemleader = new DevExpress.XtraEditors.CheckEdit();
            this.txtRoom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.gcStudentPractice = new DevExpress.XtraGrid.GridControl();
            this.gvStudentPractice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTemleader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentPractice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentPractice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cboClassName);
            this.groupControl1.Controls.Add(this.cboStudent);
            this.groupControl1.Controls.Add(this.ckeTemleader);
            this.groupControl1.Controls.Add(this.txtRoom);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cboGroup);
            this.groupControl1.Controls.Add(this.cboSubject);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(8, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1161, 105);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Cập nhật sinh viên thực hành";
            // 
            // cboClassName
            // 
            this.cboClassName.Location = new System.Drawing.Point(69, 37);
            this.cboClassName.Margin = new System.Windows.Forms.Padding(4);
            this.cboClassName.Name = "cboClassName";
            // 
            // 
            // 
            this.cboClassName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClassName.Properties.NullText = "";
            this.cboClassName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cboClassName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboClassName.Size = new System.Drawing.Size(229, 22);
            this.cboClassName.TabIndex = 75;
            this.cboClassName.EditValueChanged += new System.EventHandler(this.cboClassName_EditValueChanged);
            // 
            // cboStudent
            // 
            this.cboStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStudent.Location = new System.Drawing.Point(639, 37);
            this.cboStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cboStudent.Name = "cboStudent";
            // 
            // 
            // 
            this.cboStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStudent.Properties.NullText = "";
            this.cboStudent.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cboStudent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboStudent.Size = new System.Drawing.Size(500, 22);
            this.cboStudent.TabIndex = 74;
            this.cboStudent.EditValueChanged += new System.EventHandler(this.cboStudent_EditValueChanged);
            // 
            // ckeTemleader
            // 
            this.ckeTemleader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckeTemleader.Location = new System.Drawing.Point(1048, 71);
            this.ckeTemleader.Margin = new System.Windows.Forms.Padding(4);
            this.ckeTemleader.Name = "ckeTemleader";
            // 
            // 
            // 
            this.ckeTemleader.Properties.Caption = "Nhóm trưởng";
            this.ckeTemleader.Size = new System.Drawing.Size(107, 24);
            this.ckeTemleader.TabIndex = 73;
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoom.Enabled = false;
            this.txtRoom.Location = new System.Drawing.Point(639, 71);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(401, 22);
            this.txtRoom.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(555, 78);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 16);
            this.labelControl1.TabIndex = 72;
            this.labelControl1.Text = "Phòng: ";
            // 
            // cboGroup
            // 
            this.cboGroup.Location = new System.Drawing.Point(351, 37);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboGroup.Name = "cboGroup";
            // 
            // 
            // 
            this.cboGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroup.Size = new System.Drawing.Size(197, 22);
            this.cboGroup.TabIndex = 2;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // cboSubject
            // 
            this.cboSubject.Location = new System.Drawing.Point(69, 71);
            this.cboSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cboSubject.Name = "cboSubject";
            // 
            // 
            // 
            this.cboSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubject.Size = new System.Drawing.Size(479, 22);
            this.cboSubject.TabIndex = 1;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(555, 43);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(81, 16);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Tên sinh viên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 75);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Môn học :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(304, 41);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Nhóm :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 41);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Tên lớp :";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(265, 122);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(77, 122);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 122);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(359, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(856, 122);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gcStudentPractice
            // 
            this.gcStudentPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gcStudentPractice.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudentPractice.Location = new System.Drawing.Point(8, 158);
            this.gcStudentPractice.MainView = this.gvStudentPractice;
            this.gcStudentPractice.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudentPractice.Name = "gcStudentPractice";
            this.gcStudentPractice.Size = new System.Drawing.Size(1167, 443);
            this.gcStudentPractice.TabIndex = 72;
            this.gcStudentPractice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentPractice});
            this.gcStudentPractice.Click += new System.EventHandler(this.gcStudentPractice_Click);
            // 
            // gvStudentPractice
            // 
            this.gvStudentPractice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.ClassName,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn4});
            this.gvStudentPractice.DetailHeight = 431;
            this.gvStudentPractice.GridControl = this.gcStudentPractice;
            this.gvStudentPractice.GroupPanelText = "Chọn cột gom nhóm";
            this.gvStudentPractice.Name = "gvStudentPractice";
            this.gvStudentPractice.OptionsSelection.MultiSelect = true;
            this.gvStudentPractice.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvStudentPractice.OptionsView.ShowAutoFilterRow = true;
            this.gvStudentPractice.ViewCaption = "Sinh viên thực hành";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.Location = new System.Drawing.Point(454, 122);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(206, 28);
            this.btnDeleteAll.TabIndex = 73;
            this.btnDeleteAll.Text = "Xóa toàn bộ sinh viên của nhóm";
            this.btnDeleteAll.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(667, 122);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(88, 28);
            this.btnImportExcel.TabIndex = 75;
            this.btnImportExcel.Text = "Chọn tệp";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnImport
            // 
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(762, 122);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(88, 28);
            this.btnImport.TabIndex = 76;
            this.btnImport.Text = "Lưu";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhóm";
            this.gridColumn2.FieldName = "GroupName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 68;
            // 
            // ClassName
            // 
            this.ClassName.Caption = "Lớp";
            this.ClassName.FieldName = "ClassName";
            this.ClassName.MinWidth = 23;
            this.ClassName.Name = "ClassName";
            this.ClassName.Visible = true;
            this.ClassName.VisibleIndex = 1;
            this.ClassName.Width = 82;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Môn học";
            this.gridColumn3.FieldName = "SubjectName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 124;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã sinh viên";
            this.gridColumn5.FieldName = "StudentCode";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 89;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên sinh viên";
            this.gridColumn6.FieldName = "FullName";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 163;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhóm truong";
            this.gridColumn4.FieldName = "IsTeamLeader";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 87;
            // 
            // frmStudentPractic_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 607);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.gcStudentPractice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmStudentPractic_.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentPractic_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên thực hành";
            this.Load += new System.EventHandler(this.frmStudentPractic__Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTemleader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentPractice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentPractice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtRoom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cboSubject;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.GridControl gcStudentPractice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentPractice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ErrorProvider err;
        private DevExpress.XtraEditors.CheckEdit ckeTemleader;
        private DevExpress.XtraEditors.LookUpEdit cboStudent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.LookUpEdit cboClassName;
    }
}