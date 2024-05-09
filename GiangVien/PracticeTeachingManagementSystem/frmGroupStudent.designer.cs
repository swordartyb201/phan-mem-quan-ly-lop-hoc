namespace PracticeTeachingManagementSystem
{
    partial class frmGroupStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroupStudent));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.cboTeacherName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboHaftYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mmeNote = new DevExpress.XtraEditors.MemoEdit();
            this.cboClassName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboGroupName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.gcGroupStudent = new DevExpress.XtraGrid.GridControl();
            this.gvGroupStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInputExcel = new DevExpress.XtraEditors.SimpleButton();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTeacherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHaftYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroupStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cboSubject);
            this.groupControl1.Controls.Add(this.cboTeacherName);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cboHaftYear);
            this.groupControl1.Controls.Add(this.cboYear);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mmeNote);
            this.groupControl1.Controls.Add(this.cboClassName);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cboGroupName);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(8, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1197, 148);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chọn các thông tin cập nhật nhóm thực hành(Phím tắt F6:Làm mới, F7:Thêm,F8:Sửa, F" +
    "9:Xóa ,F10:Nhập exel)";
            // 
            // cboSubject
            // 
            this.cboSubject.Location = new System.Drawing.Point(71, 73);
            this.cboSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubject.Properties.NullText = "";
            this.cboSubject.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cboSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSubject.Size = new System.Drawing.Size(517, 22);
            this.cboSubject.TabIndex = 2;
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTeacherName.Location = new System.Drawing.Point(668, 36);
            this.cboTeacherName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTeacherName.Properties.NullText = "";
            this.cboTeacherName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cboTeacherName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTeacherName.Size = new System.Drawing.Size(511, 22);
            this.cboTeacherName.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(595, 39);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 16);
            this.labelControl10.TabIndex = 78;
            this.labelControl10.Text = "Giảng viên :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(334, 110);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Học kỳ :";
            // 
            // cboHaftYear
            // 
            this.cboHaftYear.Location = new System.Drawing.Point(386, 111);
            this.cboHaftYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboHaftYear.Name = "cboHaftYear";
            this.cboHaftYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHaftYear.Properties.Items.AddRange(new object[] {
            "I",
            "II"});
            this.cboHaftYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboHaftYear.Size = new System.Drawing.Size(202, 22);
            this.cboHaftYear.TabIndex = 4;
            this.cboHaftYear.SelectedIndexChanged += new System.EventHandler(this.cboHaftYear_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(71, 111);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboYear.Name = "cboYear";
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboYear.Size = new System.Drawing.Size(255, 22);
            this.cboYear.TabIndex = 3;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 114);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Năm học :";
            // 
            // mmeNote
            // 
            this.mmeNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmeNote.Location = new System.Drawing.Point(668, 74);
            this.mmeNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mmeNote.Name = "mmeNote";
            this.mmeNote.Size = new System.Drawing.Size(511, 62);
            this.mmeNote.TabIndex = 6;
            // 
            // cboClassName
            // 
            this.cboClassName.Location = new System.Drawing.Point(71, 36);
            this.cboClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClassName.Properties.NullText = "";
            this.cboClassName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cboClassName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboClassName.Size = new System.Drawing.Size(255, 22);
            this.cboClassName.TabIndex = 0;
            this.cboClassName.EditValueChanged += new System.EventHandler(this.cboClassName_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(595, 75);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 16);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Ghi chú:";
            // 
            // cboGroupName
            // 
            this.cboGroupName.Location = new System.Drawing.Point(386, 36);
            this.cboGroupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroupName.Properties.Items.AddRange(new object[] {
            "I",
            "II"});
            this.cboGroupName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboGroupName.Size = new System.Drawing.Size(202, 22);
            this.cboGroupName.TabIndex = 1;
            this.cboGroupName.SelectedIndexChanged += new System.EventHandler(this.cboGroupName_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 76);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Môn học :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(334, 34);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Nhóm :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 39);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên lớp :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(78, 167);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(266, 167);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(360, 167);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1115, 167);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gcGroupStudent
            // 
            this.gcGroupStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGroupStudent.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcGroupStudent.Location = new System.Drawing.Point(8, 201);
            this.gcGroupStudent.MainView = this.gvGroupStudent;
            this.gcGroupStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcGroupStudent.Name = "gcGroupStudent";
            this.gcGroupStudent.Size = new System.Drawing.Size(1197, 382);
            this.gcGroupStudent.TabIndex = 63;
            this.gcGroupStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGroupStudent});
            this.gcGroupStudent.Click += new System.EventHandler(this.gcGroupStudent_Click);
            // 
            // gvGroupStudent
            // 
            this.gvGroupStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GroupName,
            this.ClassName,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn1});
            this.gvGroupStudent.DetailHeight = 431;
            this.gvGroupStudent.GridControl = this.gcGroupStudent;
            this.gvGroupStudent.GroupPanelText = "Chọn cột gom nhóm";
            this.gvGroupStudent.Name = "gvGroupStudent";
            this.gvGroupStudent.OptionsSelection.MultiSelect = true;
            this.gvGroupStudent.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvGroupStudent.OptionsView.ShowAutoFilterRow = true;
            // 
            // GroupName
            // 
            this.GroupName.Caption = "Tên nhóm";
            this.GroupName.FieldName = "GroupName";
            this.GroupName.MinWidth = 23;
            this.GroupName.Name = "GroupName";
            this.GroupName.Visible = true;
            this.GroupName.VisibleIndex = 0;
            this.GroupName.Width = 76;
            // 
            // ClassName
            // 
            this.ClassName.Caption = "Lớp";
            this.ClassName.FieldName = "ClassName";
            this.ClassName.MinWidth = 23;
            this.ClassName.Name = "ClassName";
            this.ClassName.Visible = true;
            this.ClassName.VisibleIndex = 1;
            this.ClassName.Width = 76;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Môn học";
            this.gridColumn3.FieldName = "SubjectName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 115;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Học kỳ";
            this.gridColumn2.FieldName = "HaflYear";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Năm học";
            this.gridColumn5.FieldName = "Year";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 105;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Giảng viên";
            this.gridColumn1.FieldName = "TeacherName";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 87;
            // 
            // btnInputExcel
            // 
            this.btnInputExcel.Location = new System.Drawing.Point(455, 167);
            this.btnInputExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInputExcel.Name = "btnInputExcel";
            this.btnInputExcel.Size = new System.Drawing.Size(88, 28);
            this.btnInputExcel.TabIndex = 4;
            this.btnInputExcel.Text = "&Nhập excel";
            this.btnInputExcel.Click += new System.EventHandler(this.btnInputExcel_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(555, 174);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(118, 17);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Nhập ca thực hành";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(677, 174);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 17);
            this.labelControl9.TabIndex = 66;
            this.labelControl9.Text = "Nhập sinh viên";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // frmGroupStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1214, 590);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnInputExcel);
            this.Controls.Add(this.gcGroupStudent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmGroupStudent.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGroupStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm thực hành";
            this.Load += new System.EventHandler(this.frmGroupStudent_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGroupStudent_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTeacherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHaftYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroupStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboGroupName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit mmeNote;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.GridControl gcGroupStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGroupStudent;
        private DevExpress.XtraGrid.Columns.GridColumn GroupName;
        private DevExpress.XtraGrid.Columns.GridColumn ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnInputExcel;
        private System.Windows.Forms.ErrorProvider err;
        private DevExpress.XtraEditors.LookUpEdit cboClassName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboHaftYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cboTeacherName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LookUpEdit cboSubject;
    }
}