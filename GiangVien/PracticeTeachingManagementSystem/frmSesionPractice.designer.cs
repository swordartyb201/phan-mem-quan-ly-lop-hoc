namespace PracticeTeachingManagementSystem
{
    partial class frmSesionPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSesionPractice));
            this.gcSession = new DevExpress.XtraGrid.GridControl();
            this.gvSesson = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalWeek = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cboDayOfWeek = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtStartWeek = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSession = new DevExpress.XtraEditors.TextEdit();
            this.cboRoom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboStartSession = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDayOfWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSession.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartSession.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSession
            // 
            this.gcSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSession.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcSession.Location = new System.Drawing.Point(10, 185);
            this.gcSession.MainView = this.gvSesson;
            this.gcSession.Margin = new System.Windows.Forms.Padding(4);
            this.gcSession.Name = "gcSession";
            this.gcSession.Size = new System.Drawing.Size(1190, 416);
            this.gcSession.TabIndex = 68;
            this.gcSession.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSesson});
            this.gcSession.Click += new System.EventHandler(this.gcSession_Click);
            // 
            // gvSesson
            // 
            this.gvSesson.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.ClassName,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvSesson.DetailHeight = 431;
            this.gvSesson.GridControl = this.gcSession;
            this.gvSesson.GroupPanelText = "Chọn cột gom nhóm";
            this.gvSesson.Name = "gvSesson";
            this.gvSesson.OptionsSelection.MultiSelect = true;
            this.gvSesson.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvSesson.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên phòng";
            this.gridColumn1.FieldName = "RoomName";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 96;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhóm";
            this.gridColumn2.FieldName = "GroupName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 97;
            // 
            // ClassName
            // 
            this.ClassName.Caption = "Lớp";
            this.ClassName.FieldName = "ClassName";
            this.ClassName.MinWidth = 23;
            this.ClassName.Name = "ClassName";
            this.ClassName.Visible = true;
            this.ClassName.VisibleIndex = 1;
            this.ClassName.Width = 111;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Môn học";
            this.gridColumn3.FieldName = "SubjectName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 178;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tuần học";
            this.gridColumn5.FieldName = "Week";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 73;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tiết bắt đầu";
            this.gridColumn6.FieldName = "StartSession";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 80;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tổng số tiết";
            this.gridColumn7.FieldName = "TotalSession";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Thứ";
            this.gridColumn8.FieldName = "DayOfWeek";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 58;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ghi chú";
            this.gridColumn9.FieldName = "Note";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 163;
            // 
            // cboGroup
            // 
            this.cboGroup.Location = new System.Drawing.Point(400, 47);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboGroup.Size = new System.Drawing.Size(145, 22);
            this.cboGroup.TabIndex = 2;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // cboSubject
            // 
            this.cboSubject.Location = new System.Drawing.Point(72, 82);
            this.cboSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubject.Size = new System.Drawing.Size(234, 22);
            this.cboSubject.TabIndex = 1;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // cboClass
            // 
            this.cboClass.Location = new System.Drawing.Point(72, 47);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClass.Properties.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.cboClass.Size = new System.Drawing.Size(234, 22);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(75, 140);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(314, 50);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Nhóm :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Tên lớp :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 87);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Môn học :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 140);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtTotalWeek);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cboDayOfWeek);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtStartWeek);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTotalSession);
            this.groupControl1.Controls.Add(this.cboRoom);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cboStartSession);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cboGroup);
            this.groupControl1.Controls.Add(this.cboSubject);
            this.groupControl1.Controls.Add(this.cboClass);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(7, 7);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1185, 126);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Chọn các thông tin cập nhật ca thực hành (Phím tắt F6, F7:Thêm,F8:Sua, F9:Xoa ,F1" +
    "0:Nhập exel)";
            // 
            // txtTotalWeek
            // 
            this.txtTotalWeek.Location = new System.Drawing.Point(631, 82);
            this.txtTotalWeek.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalWeek.Name = "txtTotalWeek";
            this.txtTotalWeek.Size = new System.Drawing.Size(107, 22);
            this.txtTotalWeek.TabIndex = 5;
            this.txtTotalWeek.EditValueChanged += new System.EventHandler(this.txtTotalWeek_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(553, 86);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 16);
            this.labelControl9.TabIndex = 84;
            this.labelControl9.Text = "Số tuần học:";
            // 
            // cboDayOfWeek
            // 
            this.cboDayOfWeek.Location = new System.Drawing.Point(779, 82);
            this.cboDayOfWeek.Margin = new System.Windows.Forms.Padding(4);
            this.cboDayOfWeek.Name = "cboDayOfWeek";
            this.cboDayOfWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDayOfWeek.Properties.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboDayOfWeek.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDayOfWeek.Size = new System.Drawing.Size(103, 22);
            this.cboDayOfWeek.TabIndex = 6;
            this.cboDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.cboDayOfWeek_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(746, 85);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 16);
            this.labelControl7.TabIndex = 82;
            this.labelControl7.Text = "Thứ:";
            // 
            // txtStartWeek
            // 
            this.txtStartWeek.Location = new System.Drawing.Point(400, 82);
            this.txtStartWeek.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartWeek.Name = "txtStartWeek";
            this.txtStartWeek.Size = new System.Drawing.Size(145, 22);
            this.txtStartWeek.TabIndex = 3;
            this.txtStartWeek.EditValueChanged += new System.EventHandler(this.txtStartWeek_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(314, 87);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 16);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Tuần bắt đầu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(889, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 79;
            this.labelControl2.Text = "Số tiết học :";
            // 
            // txtTotalSession
            // 
            this.txtTotalSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSession.Location = new System.Drawing.Point(972, 82);
            this.txtTotalSession.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSession.Name = "txtTotalSession";
            this.txtTotalSession.Size = new System.Drawing.Size(201, 22);
            this.txtTotalSession.TabIndex = 8;
            this.txtTotalSession.EditValueChanged += new System.EventHandler(this.txtTotalSession_EditValueChanged);
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(631, 47);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoom.Size = new System.Drawing.Size(251, 22);
            this.cboRoom.TabIndex = 4;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(553, 49);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 77;
            this.labelControl5.Text = "Phòng :";
            // 
            // cboStartSession
            // 
            this.cboStartSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStartSession.Location = new System.Drawing.Point(972, 47);
            this.cboStartSession.Margin = new System.Windows.Forms.Padding(4);
            this.cboStartSession.Name = "cboStartSession";
            this.cboStartSession.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartSession.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboStartSession.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStartSession.Size = new System.Drawing.Size(201, 22);
            this.cboStartSession.TabIndex = 7;
            this.cboStartSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(889, 50);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 16);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tiết bắt đầu :";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1098, 140);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(264, 140);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(358, 140);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.Location = new System.Drawing.Point(453, 140);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(161, 28);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "&Xóa tất cả ca của nhóm";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(621, 146);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(89, 17);
            this.labelControl10.TabIndex = 69;
            this.labelControl10.Text = "Nhập sinh viên";
            this.labelControl10.Click += new System.EventHandler(this.labelControl10_Click);
            // 
            // frmSesionPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 615);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gcSession);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnExit);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSesionPractice.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSesionPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca thực hành";
            this.Load += new System.EventHandler(this.frmSesionPractice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDayOfWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSession.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartSession.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSession;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSesson;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.ComboBoxEdit cboGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cboSubject;
        private System.Windows.Forms.ErrorProvider err;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboStartSession;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboClass;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalSession;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cboDayOfWeek;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtStartWeek;
        private DevExpress.XtraEditors.TextEdit txtTotalWeek;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoom;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}