namespace PracticeTeachingManagementSystem
{
    partial class frmComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputer));
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gcComputer = new DevExpress.XtraGrid.GridControl();
            this.cmsViewConfiguration = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemCấuHìnhMáyTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvComputer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComputerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComputerNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComputerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfiguationCompute = new DevExpress.XtraEditors.SimpleButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtComputerName = new DevExpress.XtraEditors.TextEdit();
            this.txtComputerNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboRoomName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtComputerCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabUpdate = new DevExpress.XtraTab.XtraTabControl();
            this.tabUpdateHand = new DevExpress.XtraTab.XtraTabPage();
            this.tabUpdateAuto = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcSelectedComputer = new DevExpress.XtraGrid.GridControl();
            this.gvSelectedComputer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateAuto = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.gcComputerNotUpdate = new DevExpress.XtraGrid.GridControl();
            this.cmsSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvComputerNotUpdate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboRoom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcComputer)).BeginInit();
            this.cmsViewConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUpdate)).BeginInit();
            this.tabUpdate.SuspendLayout();
            this.tabUpdateHand.SuspendLayout();
            this.tabUpdateAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComputerNotUpdate)).BeginInit();
            this.cmsSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComputerNotUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 105);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 105);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gcComputer
            // 
            this.gcComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcComputer.ContextMenuStrip = this.cmsViewConfiguration;
            this.gcComputer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcComputer.Location = new System.Drawing.Point(5, 140);
            this.gcComputer.MainView = this.gvComputer;
            this.gcComputer.Margin = new System.Windows.Forms.Padding(4);
            this.gcComputer.Name = "gcComputer";
            this.gcComputer.Size = new System.Drawing.Size(1024, 473);
            this.gcComputer.TabIndex = 6;
            this.gcComputer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComputer});
            this.gcComputer.Click += new System.EventHandler(this.gcComputer_Click);
            // 
            // cmsViewConfiguration
            // 
            this.cmsViewConfiguration.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsViewConfiguration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemCấuHìnhMáyTínhToolStripMenuItem});
            this.cmsViewConfiguration.Name = "contextMenuStrip1";
            this.cmsViewConfiguration.Size = new System.Drawing.Size(229, 28);
            // 
            // xemCấuHìnhMáyTínhToolStripMenuItem
            // 
            this.xemCấuHìnhMáyTínhToolStripMenuItem.Name = "xemCấuHìnhMáyTínhToolStripMenuItem";
            this.xemCấuHìnhMáyTínhToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.xemCấuHìnhMáyTínhToolStripMenuItem.Text = "Xem cấu hình máy tính";
            this.xemCấuHìnhMáyTínhToolStripMenuItem.Click += new System.EventHandler(this.xemCấuHìnhMáyTínhToolStripMenuItem_Click);
            // 
            // gvComputer
            // 
            this.gvComputer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomName,
            this.ComputerCode,
            this.ComputerNumber,
            this.ComputerName});
            this.gvComputer.DetailHeight = 431;
            this.gvComputer.GridControl = this.gcComputer;
            this.gvComputer.GroupPanelText = "Thông tin máy tính";
            this.gvComputer.Name = "gvComputer";
            this.gvComputer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvComputer.OptionsSelection.MultiSelect = true;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "Tên phòng";
            this.RoomName.FieldName = "RoomName";
            this.RoomName.MinWidth = 23;
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 0;
            this.RoomName.Width = 192;
            // 
            // ComputerCode
            // 
            this.ComputerCode.Caption = "Mã máy";
            this.ComputerCode.FieldName = "ComputerCode";
            this.ComputerCode.MinWidth = 23;
            this.ComputerCode.Name = "ComputerCode";
            this.ComputerCode.Visible = true;
            this.ComputerCode.VisibleIndex = 1;
            this.ComputerCode.Width = 316;
            // 
            // ComputerNumber
            // 
            this.ComputerNumber.Caption = "Số máy";
            this.ComputerNumber.FieldName = "ComputerNumber";
            this.ComputerNumber.MinWidth = 23;
            this.ComputerNumber.Name = "ComputerNumber";
            this.ComputerNumber.Visible = true;
            this.ComputerNumber.VisibleIndex = 2;
            this.ComputerNumber.Width = 205;
            // 
            // ComputerName
            // 
            this.ComputerName.Caption = "Tên máy";
            this.ComputerName.FieldName = "ComputerName";
            this.ComputerName.MinWidth = 23;
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Visible = true;
            this.ComputerName.VisibleIndex = 3;
            this.ComputerName.Width = 339;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(164, 105);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 28);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "&Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(70, 105);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfiguationCompute
            // 
            this.btnConfiguationCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguationCompute.Location = new System.Drawing.Point(901, 105);
            this.btnConfiguationCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguationCompute.Name = "btnConfiguationCompute";
            this.btnConfiguationCompute.Size = new System.Drawing.Size(88, 28);
            this.btnConfiguationCompute.TabIndex = 5;
            this.btnConfiguationCompute.Text = "&Linh kiện";
            this.btnConfiguationCompute.Click += new System.EventHandler(this.btnViewConfiguationCompute_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportExcel.Location = new System.Drawing.Point(798, 105);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(93, 28);
            this.btnImportExcel.TabIndex = 4;
            this.btnImportExcel.Text = "&Nhập từ excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtComputerName);
            this.panelControl1.Controls.Add(this.txtComputerNumber);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cboRoomName);
            this.panelControl1.Controls.Add(this.txtComputerCode);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 16);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1024, 81);
            this.panelControl1.TabIndex = 50;
            // 
            // txtComputerName
            // 
            this.txtComputerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputerName.Location = new System.Drawing.Point(448, 49);
            this.txtComputerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(544, 22);
            this.txtComputerName.TabIndex = 3;
            this.txtComputerName.TextChanged += new System.EventHandler(this.txtComputerName_TextChanged_1);
            // 
            // txtComputerNumber
            // 
            this.txtComputerNumber.Location = new System.Drawing.Point(66, 44);
            this.txtComputerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtComputerNumber.Name = "txtComputerNumber";
            this.txtComputerNumber.Size = new System.Drawing.Size(284, 22);
            this.txtComputerNumber.TabIndex = 1;
            this.txtComputerNumber.TextChanged += new System.EventHandler(this.txtComputerNumber_TextChanged_1);
            this.txtComputerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComputerNumber_KeyPress_1);
            // 
            // labelControl7
            // 
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(386, 54);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 16);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Tên máy *";
            // 
            // labelControl5
            // 
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(18, 53);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Số máy *";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(388, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Mã máy * ";
            // 
            // cboRoomName
            // 
            this.cboRoomName.Location = new System.Drawing.Point(66, 12);
            this.cboRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoomName.Name = "cboRoomName";
            this.cboRoomName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoomName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoomName.Size = new System.Drawing.Size(284, 22);
            this.cboRoomName.TabIndex = 0;
            this.cboRoomName.TextChanged += new System.EventHandler(this.cboRoomName_TextChanged_1);
            // 
            // txtComputerCode
            // 
            this.txtComputerCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputerCode.Location = new System.Drawing.Point(448, 17);
            this.txtComputerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtComputerCode.Name = "txtComputerCode";
            this.txtComputerCode.Size = new System.Drawing.Size(544, 22);
            this.txtComputerCode.TabIndex = 2;
            this.txtComputerCode.TextChanged += new System.EventHandler(this.txtComputerCode_TextChanged_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 16);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Phòng *";
            // 
            // tabUpdate
            // 
            this.tabUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabUpdate.Location = new System.Drawing.Point(10, 46);
            this.tabUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.SelectedTabPage = this.tabUpdateHand;
            this.tabUpdate.Size = new System.Drawing.Size(1043, 654);
            this.tabUpdate.TabIndex = 51;
            this.tabUpdate.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabUpdateHand,
            this.tabUpdateAuto});
            // 
            // tabUpdateHand
            // 
            this.tabUpdateHand.Controls.Add(this.panelControl1);
            this.tabUpdateHand.Controls.Add(this.btnConfiguationCompute);
            this.tabUpdateHand.Controls.Add(this.btnImportExcel);
            this.tabUpdateHand.Controls.Add(this.btnRefresh);
            this.tabUpdateHand.Controls.Add(this.btnInsert);
            this.tabUpdateHand.Controls.Add(this.gcComputer);
            this.tabUpdateHand.Controls.Add(this.btnDelete);
            this.tabUpdateHand.Controls.Add(this.btnUpdate);
            this.tabUpdateHand.Margin = new System.Windows.Forms.Padding(4);
            this.tabUpdateHand.Name = "tabUpdateHand";
            this.tabUpdateHand.Size = new System.Drawing.Size(1041, 624);
            this.tabUpdateHand.Text = "Cập nhật bằng tay";
            // 
            // tabUpdateAuto
            // 
            this.tabUpdateAuto.Controls.Add(this.labelControl3);
            this.tabUpdateAuto.Controls.Add(this.gcSelectedComputer);
            this.tabUpdateAuto.Controls.Add(this.simpleButton1);
            this.tabUpdateAuto.Controls.Add(this.btnUpdateAuto);
            this.tabUpdateAuto.Controls.Add(this.btnView);
            this.tabUpdateAuto.Controls.Add(this.gcComputerNotUpdate);
            this.tabUpdateAuto.Controls.Add(this.cboRoom);
            this.tabUpdateAuto.Controls.Add(this.labelControl8);
            this.tabUpdateAuto.Margin = new System.Windows.Forms.Padding(4);
            this.tabUpdateAuto.Name = "tabUpdateAuto";
            this.tabUpdateAuto.Size = new System.Drawing.Size(1041, 624);
            this.tabUpdateAuto.Text = "Cập nhật tự động";
            this.tabUpdateAuto.Click += new System.EventHandler(this.tabUpdateAuto_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 596);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(398, 16);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Click chuột phải chọn \"Chọn máy\" để đưa vào danh sách cần cập nhật";
            // 
            // gcSelectedComputer
            // 
            this.gcSelectedComputer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcSelectedComputer.Location = new System.Drawing.Point(523, 50);
            this.gcSelectedComputer.MainView = this.gvSelectedComputer;
            this.gcSelectedComputer.Margin = new System.Windows.Forms.Padding(4);
            this.gcSelectedComputer.Name = "gcSelectedComputer";
            this.gcSelectedComputer.Size = new System.Drawing.Size(503, 538);
            this.gcSelectedComputer.TabIndex = 58;
            this.gcSelectedComputer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectedComputer});
            // 
            // gvSelectedComputer
            // 
            this.gvSelectedComputer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn7,
            this.gridColumn9});
            this.gvSelectedComputer.DetailHeight = 431;
            this.gvSelectedComputer.GridControl = this.gcSelectedComputer;
            this.gvSelectedComputer.GroupPanelText = "Danh sách máy tính được chọn";
            this.gvSelectedComputer.Name = "gvSelectedComputer";
            this.gvSelectedComputer.OptionsSelection.MultiSelect = true;
            this.gvSelectedComputer.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "STT";
            this.gridColumn5.FieldName = "STT";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 44;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phòng";
            this.gridColumn6.FieldName = "RoomName";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã (Tên) máy";
            this.gridColumn8.FieldName = "ComputerCode";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 117;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số máy";
            this.gridColumn7.FieldName = "ComputerNumber";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 66;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.gridColumn9.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn9.Caption = "Thông báo lỗi";
            this.gridColumn9.FieldName = "Massege";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 166;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(744, 271);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 28);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "Cập nhật";
            // 
            // btnUpdateAuto
            // 
            this.btnUpdateAuto.Location = new System.Drawing.Point(906, 15);
            this.btnUpdateAuto.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAuto.Name = "btnUpdateAuto";
            this.btnUpdateAuto.Size = new System.Drawing.Size(119, 28);
            this.btnUpdateAuto.TabIndex = 51;
            this.btnUpdateAuto.Text = "Cập nhật";
            this.btnUpdateAuto.Click += new System.EventHandler(this.btnUpdateAuto_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(174, 16);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(119, 28);
            this.btnView.TabIndex = 51;
            this.btnView.Text = "Xem máy tính";
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gcComputerNotUpdate
            // 
            this.gcComputerNotUpdate.ContextMenuStrip = this.cmsSelect;
            this.gcComputerNotUpdate.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcComputerNotUpdate.Location = new System.Drawing.Point(5, 50);
            this.gcComputerNotUpdate.MainView = this.gvComputerNotUpdate;
            this.gcComputerNotUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gcComputerNotUpdate.Name = "gcComputerNotUpdate";
            this.gcComputerNotUpdate.Size = new System.Drawing.Size(499, 538);
            this.gcComputerNotUpdate.TabIndex = 57;
            this.gcComputerNotUpdate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComputerNotUpdate});
            // 
            // cmsSelect
            // 
            this.cmsSelect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnMáyToolStripMenuItem});
            this.cmsSelect.Name = "cmsSelect";
            this.cmsSelect.Size = new System.Drawing.Size(189, 28);
            // 
            // chọnMáyToolStripMenuItem
            // 
            this.chọnMáyToolStripMenuItem.Name = "chọnMáyToolStripMenuItem";
            this.chọnMáyToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.chọnMáyToolStripMenuItem.Text = "Chọn máy ==>>";
            this.chọnMáyToolStripMenuItem.Click += new System.EventHandler(this.chọnMáyToolStripMenuItem_Click);
            // 
            // gvComputerNotUpdate
            // 
            this.gvComputerNotUpdate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvComputerNotUpdate.DetailHeight = 431;
            this.gvComputerNotUpdate.GridControl = this.gcComputerNotUpdate;
            this.gvComputerNotUpdate.GroupPanelText = "Danh sách máy tính chưa được cập nhật";
            this.gvComputerNotUpdate.Name = "gvComputerNotUpdate";
            this.gvComputerNotUpdate.OptionsSelection.MultiSelect = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 69;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên máy";
            this.gridColumn2.FieldName = "ComputerName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số linh kiện";
            this.gridColumn3.FieldName = "Total";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 82;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cấu hình";
            this.gridColumn4.FieldName = "Configuration";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 226;
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(59, 18);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoom.Size = new System.Drawing.Size(107, 22);
            this.cboRoom.TabIndex = 0;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 23);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 16);
            this.labelControl8.TabIndex = 53;
            this.labelControl8.Text = "Phòng ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 59);
            this.label1.TabIndex = 52;
            this.label1.Text = "CẬP NHẬT MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 705);
            this.Controls.Add(this.tabUpdate);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmComputer.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(664, 489);
            this.Name = "frmComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hỗ trợ giảng dạy và quản lý phòng máy version 1.0";
            this.Load += new System.EventHandler(this.frmComputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcComputer)).EndInit();
            this.cmsViewConfiguration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUpdate)).EndInit();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdateHand.ResumeLayout(false);
            this.tabUpdateAuto.ResumeLayout(false);
            this.tabUpdateAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComputerNotUpdate)).EndInit();
            this.cmsSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvComputerNotUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gcComputer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComputer;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnConfiguationCompute;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn ComputerCode;
        private DevExpress.XtraGrid.Columns.GridColumn ComputerNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ComputerName;
        private System.Windows.Forms.ErrorProvider error;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtComputerName;
        private DevExpress.XtraEditors.TextEdit txtComputerNumber;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoomName;
        private DevExpress.XtraEditors.TextEdit txtComputerCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl tabUpdate;
        private DevExpress.XtraTab.XtraTabPage tabUpdateHand;
        private DevExpress.XtraTab.XtraTabPage tabUpdateAuto;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraGrid.GridControl gcComputerNotUpdate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComputerNotUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoom;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcSelectedComputer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelectedComputer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnUpdateAuto;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ContextMenuStrip cmsViewConfiguration;
        private System.Windows.Forms.ToolStripMenuItem xemCấuHìnhMáyTínhToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.ContextMenuStrip cmsSelect;
        private System.Windows.Forms.ToolStripMenuItem chọnMáyToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label1;
    }
}