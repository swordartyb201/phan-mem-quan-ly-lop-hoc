namespace PracticeTeachingManagementSystem_Student
{
    partial class frmconfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfiguration));
            this.label1 = new System.Windows.Forms.Label();
            this.gcConfiguration = new DevExpress.XtraGrid.GridControl();
            this.gvConfiguration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblRoom = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfiguration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 54);
            this.label1.TabIndex = 34;
            this.label1.Text = "CẤU HÌNH MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcConfiguration
            // 
            this.gcConfiguration.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcConfiguration.Location = new System.Drawing.Point(12, 108);
            this.gcConfiguration.MainView = this.gvConfiguration;
            this.gcConfiguration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcConfiguration.Name = "gcConfiguration";
            this.gcConfiguration.Size = new System.Drawing.Size(666, 340);
            this.gcConfiguration.TabIndex = 35;
            this.gcConfiguration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConfiguration});
            // 
            // gvConfiguration
            // 
            this.gvConfiguration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvConfiguration.DetailHeight = 431;
            this.gvConfiguration.GridControl = this.gcConfiguration;
            this.gvConfiguration.GroupPanelText = "Thông tin cấu hình máy tính";
            this.gvConfiguration.Name = "gvConfiguration";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã linh kiện";
            this.gridColumn1.FieldName = "EquipmentCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 133;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên linh kiện";
            this.gridColumn2.FieldName = "EquipmentName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 118;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hãng SX";
            this.gridColumn3.FieldName = "Firm";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cấu hình";
            this.gridColumn4.FieldName = "Configuration";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 283;
            // 
            // lblNumber
            // 
            this.lblNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Appearance.Options.UseFont = true;
            this.lblNumber.Location = new System.Drawing.Point(215, 74);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(69, 21);
            this.lblNumber.TabIndex = 37;
            this.lblNumber.Text = "Số máy: ";
            // 
            // lblRoom
            // 
            this.lblRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Appearance.Options.UseFont = true;
            this.lblRoom.Location = new System.Drawing.Point(15, 74);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(66, 21);
            this.lblRoom.TabIndex = 36;
            this.lblRoom.Text = "Phòng: ";
            // 
            // frmconfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 458);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.gcConfiguration);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmconfiguration.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmconfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMS Student";
            this.Load += new System.EventHandler(this.frmconfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfiguration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcConfiguration;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConfiguration;
        private DevExpress.XtraEditors.LabelControl lblNumber;
        private DevExpress.XtraEditors.LabelControl lblRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}