namespace PracticeTeachingManagementSystem
{
    partial class frmError
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtErrorName = new DevExpress.XtraEditors.TextEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.gcError = new DevExpress.XtraGrid.GridControl();
            this.gvError = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComputerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComputerNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtErrorName);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnInsert);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnUpdate);
            this.panelControl1.Location = new System.Drawing.Point(10, 58);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(736, 79);
            this.panelControl1.TabIndex = 56;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(424, 10);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // txtErrorName
            // 
            this.txtErrorName.Location = new System.Drawing.Point(55, 10);
            this.txtErrorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorName.Name = "txtErrorName";
            this.txtErrorName.Size = new System.Drawing.Size(276, 22);
            this.txtErrorName.TabIndex = 1;
            this.txtErrorName.TextChanged += new System.EventHandler(this.txtErrorName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(55, 42);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "&Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(149, 42);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 28);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "&Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(385, 14);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 16);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Mô tả";
            // 
            // labelControl5
            // 
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(10, 14);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 16);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Tên lỗi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(338, 42);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 42);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 28);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gcError
            // 
            this.gcError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcError.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcError.Location = new System.Drawing.Point(10, 144);
            this.gcError.MainView = this.gvError;
            this.gcError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcError.Name = "gcError";
            this.gcError.Size = new System.Drawing.Size(736, 390);
            this.gcError.TabIndex = 55;
            this.gcError.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvError});
            this.gcError.Click += new System.EventHandler(this.gcError_Click);
            // 
            // gvError
            // 
            this.gvError.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomName,
            this.ComputerCode,
            this.ComputerNumber});
            this.gvError.DetailHeight = 431;
            this.gvError.GridControl = this.gcError;
            this.gvError.GroupPanelText = "Danh sác các loại lỗi";
            this.gvError.Name = "gvError";
            this.gvError.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvError.OptionsSelection.MultiSelect = true;
            this.gvError.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "STT";
            this.RoomName.FieldName = "STT";
            this.RoomName.MinWidth = 23;
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 0;
            this.RoomName.Width = 57;
            // 
            // ComputerCode
            // 
            this.ComputerCode.Caption = "Tên lỗi";
            this.ComputerCode.FieldName = "ErrorName";
            this.ComputerCode.MinWidth = 23;
            this.ComputerCode.Name = "ComputerCode";
            this.ComputerCode.Visible = true;
            this.ComputerCode.VisibleIndex = 1;
            this.ComputerCode.Width = 269;
            // 
            // ComputerNumber
            // 
            this.ComputerNumber.Caption = "Mô tả";
            this.ComputerNumber.FieldName = "Description";
            this.ComputerNumber.MinWidth = 23;
            this.ComputerNumber.Name = "ComputerNumber";
            this.ComputerNumber.Visible = true;
            this.ComputerNumber.VisibleIndex = 2;
            this.ComputerNumber.Width = 379;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 54);
            this.label1.TabIndex = 57;
            this.label1.Text = "CÁC LOẠI LỖI MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcError);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(650, 472);
            this.Name = "frmError";
            this.Text = "Hỗ trợ giảng dạy và quản lý phòng máy version 1.0";
            this.Load += new System.EventHandler(this.frmError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtErrorName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.GridControl gcError;
        private DevExpress.XtraGrid.Views.Grid.GridView gvError;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn ComputerCode;
        private DevExpress.XtraGrid.Columns.GridColumn ComputerNumber;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
    }
}