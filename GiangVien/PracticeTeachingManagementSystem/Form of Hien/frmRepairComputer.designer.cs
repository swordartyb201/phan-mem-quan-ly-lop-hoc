namespace PracticeTeachingManagementSystem
{
    partial class frmRepairComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepairComputer));
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvRepair = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRepair = new DevExpress.XtraGrid.GridControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.cboError = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboComputerNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboRepair = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.mmoDetail = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboRoom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPeopleChange = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTime = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboComputerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRepair.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeopleChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày sửa";
            this.gridColumn1.FieldName = "TimeRepair";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(104, 132);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Người sửa";
            this.gridColumn3.FieldName = "PeopleChange";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 87;
            // 
            // gvRepair
            // 
            this.gvRepair.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn8});
            this.gvRepair.DetailHeight = 431;
            this.gvRepair.GridControl = this.gcRepair;
            this.gvRepair.GroupPanelText = "Chọn cột gom nhóm";
            this.gvRepair.Name = "gvRepair";
            this.gvRepair.OptionsSelection.MultiSelect = true;
            this.gvRepair.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Phòng";
            this.gridColumn4.FieldName = "RoomName";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số máy";
            this.gridColumn6.FieldName = "ComputerNumber";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tình trạng";
            this.gridColumn2.FieldName = "Error";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Khắc phục";
            this.gridColumn7.FieldName = "Repair";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Lỗi ngày";
            this.gridColumn5.FieldName = "TimeError";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chi tiết";
            this.gridColumn8.FieldName = "Detail";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 87;
            // 
            // gcRepair
            // 
            this.gcRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRepair.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcRepair.Location = new System.Drawing.Point(9, 167);
            this.gcRepair.MainView = this.gvRepair;
            this.gcRepair.Margin = new System.Windows.Forms.Padding(4);
            this.gcRepair.Name = "gcRepair";
            this.gcRepair.Size = new System.Drawing.Size(1203, 660);
            this.gcRepair.TabIndex = 4;
            this.gcRepair.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRepair});
            this.gcRepair.Click += new System.EventHandler(this.gcRepair_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(293, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 132);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(198, 132);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 28);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "&Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cboError
            // 
            this.cboError.Location = new System.Drawing.Point(617, 10);
            this.cboError.Margin = new System.Windows.Forms.Padding(4);
            this.cboError.Name = "cboError";
            this.cboError.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboError.Properties.Items.AddRange(new object[] {
            "Hỏng (Không hoạt động)",
            "Hỏng Win",
            "Hỏng Chuột",
            "Hỏng Ram",
            "Hỏng Bàn phím",
            "Hỏng CD Rom"});
            this.cboError.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboError.Size = new System.Drawing.Size(149, 22);
            this.cboError.TabIndex = 4;
            this.cboError.SelectedIndexChanged += new System.EventHandler(this.cboError_SelectedIndexChanged);
            this.cboError.TextChanged += new System.EventHandler(this.cboError_TextChanged);
            this.cboError.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboError_MouseClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(534, 15);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 16);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "Tình trạng * :";
            // 
            // cboComputerNumber
            // 
            this.cboComputerNumber.Location = new System.Drawing.Point(344, 42);
            this.cboComputerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cboComputerNumber.Name = "cboComputerNumber";
            this.cboComputerNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboComputerNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboComputerNumber.Size = new System.Drawing.Size(152, 22);
            this.cboComputerNumber.TabIndex = 3;
            this.cboComputerNumber.SelectedIndexChanged += new System.EventHandler(this.cboComputerNumber_SelectedIndexChanged);
            this.cboComputerNumber.TextChanged += new System.EventHandler(this.cboComputerNumber_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(281, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Phòng * :";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1224, 49);
            this.label1.TabIndex = 63;
            this.label1.Text = "SỬA CHỮA, NÂNG CẤP MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(280, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Số máy * :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 14);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 16);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Ngày sửa * :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 46);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 16);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "Người sửa * :";
            // 
            // cboRepair
            // 
            this.cboRepair.Location = new System.Drawing.Point(617, 42);
            this.cboRepair.Margin = new System.Windows.Forms.Padding(4);
            this.cboRepair.Name = "cboRepair";
            this.cboRepair.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRepair.Properties.Items.AddRange(new object[] {
            "Bảo trì, nâng cấp",
            "Thay thế linh kiện",
            "Sửa linh kiện"});
            this.cboRepair.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRepair.Size = new System.Drawing.Size(265, 22);
            this.cboRepair.TabIndex = 5;
            this.cboRepair.SelectedIndexChanged += new System.EventHandler(this.cboRepair_SelectedIndexChanged);
            this.cboRepair.TextChanged += new System.EventHandler(this.cboRepair_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(536, 48);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 16);
            this.labelControl6.TabIndex = 71;
            this.labelControl6.Text = "Khắc phục * :";
            // 
            // mmoDetail
            // 
            this.mmoDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmoDetail.Location = new System.Drawing.Point(971, 10);
            this.mmoDetail.Margin = new System.Windows.Forms.Padding(4);
            this.mmoDetail.Name = "mmoDetail";
            this.mmoDetail.Size = new System.Drawing.Size(223, 57);
            this.mmoDetail.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(916, 14);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 16);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "Chi tiết :";
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(344, 10);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoom.Size = new System.Drawing.Size(153, 22);
            this.cboRoom.TabIndex = 2;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            this.cboRoom.TextChanged += new System.EventHandler(this.cboRoom_TextChanged);
            // 
            // cboPeopleChange
            // 
            this.cboPeopleChange.Location = new System.Drawing.Point(94, 42);
            this.cboPeopleChange.Margin = new System.Windows.Forms.Padding(4);
            this.cboPeopleChange.Name = "cboPeopleChange";
            this.cboPeopleChange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeopleChange.Size = new System.Drawing.Size(153, 22);
            this.cboPeopleChange.TabIndex = 1;
            this.cboPeopleChange.TextChanged += new System.EventHandler(this.cboPeopleChange_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(94, 10);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDate.Size = new System.Drawing.Size(153, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.TextChanged += new System.EventHandler(this.dtpDate_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(774, 10);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(108, 22);
            this.txtTime.TabIndex = 78;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cboPeopleChange);
            this.panelControl1.Controls.Add(this.txtTime);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtpDate);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cboRoom);
            this.panelControl1.Controls.Add(this.cboComputerNumber);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.mmoDetail);
            this.panelControl1.Controls.Add(this.cboError);
            this.panelControl1.Controls.Add(this.cboRepair);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Location = new System.Drawing.Point(9, 48);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1204, 76);
            this.panelControl1.TabIndex = 79;
            // 
            // frmRepairComputer
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 836);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gcRepair);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmRepairComputer.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepairComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hỗ trợ giảng dạy và quản lý phòng máy version 1.0";
            this.Load += new System.EventHandler(this.frmRepairComputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboComputerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRepair.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeopleChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRepair;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gcRepair;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.ComboBoxEdit cboError;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboComputerNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboRepair;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit mmoDetail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoom;
        private DevExpress.XtraEditors.ComboBoxEdit cboPeopleChange;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.TextEdit txtTime;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}