namespace PracticeTeachingManagementSystem
{
    partial class frmEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipment));
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboFirm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEquipmentCode = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtConfiguration = new DevExpress.XtraEditors.MemoEdit();
            this.cboEquipmentName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gcEquipment = new DevExpress.XtraGrid.GridControl();
            this.gvEquipment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cboFirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfiguration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEquipmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 132);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(386, 16);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 16);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Cấu hình ";
            // 
            // cboFirm
            // 
            this.cboFirm.Location = new System.Drawing.Point(266, 43);
            this.cboFirm.Margin = new System.Windows.Forms.Padding(4);
            this.cboFirm.Name = "cboFirm";
            this.cboFirm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFirm.Properties.Items.AddRange(new object[] {
            "Foxconn",
            "Intel",
            "Kingston",
            "Samsung",
            "Golden Field",
            "Mitsumi",
            "Powermax",
            "AOC",
            "",
            "",
            ""});
            this.cboFirm.Size = new System.Drawing.Size(84, 22);
            this.cboFirm.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(231, 49);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 16);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Hãng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(288, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(194, 132);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 28);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "&Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 49);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Tên thiết bị *";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 16);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Mã thiết bị ";
            // 
            // txtEquipmentCode
            // 
            this.txtEquipmentCode.Location = new System.Drawing.Point(89, 10);
            this.txtEquipmentCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentCode.Name = "txtEquipmentCode";
            this.txtEquipmentCode.Properties.MaxLength = 10;
            this.txtEquipmentCode.Size = new System.Drawing.Size(261, 22);
            this.txtEquipmentCode.TabIndex = 0;
            this.txtEquipmentCode.TextChanged += new System.EventHandler(this.txtEquipmentCode_TextChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtConfiguration);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cboFirm);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtEquipmentCode);
            this.panelControl1.Controls.Add(this.cboEquipmentName);
            this.panelControl1.Location = new System.Drawing.Point(10, 47);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 78);
            this.panelControl1.TabIndex = 39;
            // 
            // txtConfiguration
            // 
            this.txtConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfiguration.Location = new System.Drawing.Point(446, 12);
            this.txtConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfiguration.Name = "txtConfiguration";
            this.txtConfiguration.Size = new System.Drawing.Size(307, 58);
            this.txtConfiguration.TabIndex = 3;
            // 
            // cboEquipmentName
            // 
            this.cboEquipmentName.Location = new System.Drawing.Point(89, 42);
            this.cboEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.cboEquipmentName.Name = "cboEquipmentName";
            this.cboEquipmentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEquipmentName.Properties.Items.AddRange(new object[] {
            "Main",
            "Chip",
            "RAM",
            "HDD",
            "CDROM",
            "FDD",
            "Case",
            "Monitor",
            "KeyBoard",
            "Mouse"});
            this.cboEquipmentName.Size = new System.Drawing.Size(106, 22);
            this.cboEquipmentName.TabIndex = 1;
            this.cboEquipmentName.TextChanged += new System.EventHandler(this.cboEquipmentName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(99, 132);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 49);
            this.label1.TabIndex = 45;
            this.label1.Text = "CẬP NHẬT THIẾT BỊ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcEquipment
            // 
            this.gcEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEquipment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcEquipment.Location = new System.Drawing.Point(9, 167);
            this.gcEquipment.MainView = this.gvEquipment;
            this.gcEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.gcEquipment.Name = "gcEquipment";
            this.gcEquipment.Size = new System.Drawing.Size(765, 402);
            this.gcEquipment.TabIndex = 4;
            this.gcEquipment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEquipment});
            this.gcEquipment.Click += new System.EventHandler(this.gcEquipment_Click);
            // 
            // gvEquipment
            // 
            this.gvEquipment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvEquipment.DetailHeight = 431;
            this.gvEquipment.GridControl = this.gcEquipment;
            this.gvEquipment.GroupPanelText = "Danh sách thông tin thiết bị";
            this.gvEquipment.Name = "gvEquipment";
            this.gvEquipment.OptionsSelection.MultiSelect = true;
            this.gvEquipment.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã thiết bị";
            this.gridColumn1.FieldName = "EquipmentCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 189;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên thiết bị";
            this.gridColumn2.FieldName = "EquipmentName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 117;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hãng";
            this.gridColumn3.FieldName = "Firm";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 117;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cấu hình";
            this.gridColumn4.FieldName = "Configuration";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 337;
            // 
            // frmEquipment
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 583);
            this.Controls.Add(this.gcEquipment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEquipment.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(682, 506);
            this.Name = "frmEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Teacher";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboFirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfiguration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEquipmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cboFirm;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.ErrorProvider err;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEquipmentCode;
        private DevExpress.XtraEditors.ComboBoxEdit cboEquipmentName;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcEquipment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEquipment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.MemoEdit txtConfiguration;
    }
}