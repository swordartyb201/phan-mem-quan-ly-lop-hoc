namespace PracticeTeachingManagementSystem
{
    partial class frmAutoUpdateComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoUpdateComputer));
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cboRoomName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gvEquipment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEquipment = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 49);
            this.label1.TabIndex = 47;
            this.label1.Text = "CẬP NHẬT TỰ ĐỘNG THIẾT BỊ MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Phòng";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomName,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Danh sách máy tính được chọn";
            this.gridView1.Name = "gridView1";
            // 
            // RoomName
            // 
            this.RoomName.Caption = "STT";
            this.RoomName.MinWidth = 23;
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 0;
            this.RoomName.Width = 50;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã máy";
            this.gridColumn1.FieldName = "ComputerCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 128;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên máy";
            this.gridColumn2.FieldName = "ComputerName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 128;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số máy";
            this.gridColumn3.FieldName = "ComputerNumber";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 135;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(609, 212);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(467, 246);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(775, 465);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu lại";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(392, 64);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 28);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Xem";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(575, 302);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(88, 28);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = ">";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(575, 337);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(88, 28);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "<";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(593, 60);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(117, 22);
            this.textEdit1.TabIndex = 2;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(651, 466);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(117, 22);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(609, 470);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Phòng";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(183, 60);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Thiết bị mới hoặc bị thay thế"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Toàn bộ thiết bị")});
            this.radioGroup1.Size = new System.Drawing.Size(202, 66);
            this.radioGroup1.TabIndex = 48;
            // 
            // cboRoomName
            // 
            this.cboRoomName.Location = new System.Drawing.Point(59, 60);
            this.cboRoomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRoomName.Name = "cboRoomName";
            this.cboRoomName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoomName.Size = new System.Drawing.Size(117, 22);
            this.cboRoomName.TabIndex = 49;
            // 
            // gvEquipment
            // 
            this.gvEquipment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvEquipment.DetailHeight = 431;
            this.gvEquipment.GridControl = this.gcEquipment;
            this.gvEquipment.GroupPanelText = "Danh sách thông tin thiết bị";
            this.gvEquipment.Name = "gvEquipment";
            this.gvEquipment.OptionsSelection.MultiSelect = true;
            this.gvEquipment.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên máy";
            this.gridColumn8.FieldName = "ComputerName";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 111;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã thiết bị";
            this.gridColumn4.FieldName = "EquipmentCode";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 103;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên thiết bị";
            this.gridColumn5.FieldName = "EquipmentName";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Hãng";
            this.gridColumn6.FieldName = "Firm";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 85;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cấu hình";
            this.gridColumn7.FieldName = "Configuration";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gcEquipment
            // 
            this.gcEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEquipment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcEquipment.Location = new System.Drawing.Point(10, 132);
            this.gcEquipment.MainView = this.gvEquipment;
            this.gcEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcEquipment.Name = "gcEquipment";
            this.gcEquipment.Size = new System.Drawing.Size(570, 359);
            this.gcEquipment.TabIndex = 51;
            this.gcEquipment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEquipment});
            // 
            // frmAutoUpdateComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 501);
            this.Controls.Add(this.gcEquipment);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cboRoomName);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmAutoUpdateComputer.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAutoUpdateComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoomName;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEquipment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.GridControl gcEquipment;
    }
}