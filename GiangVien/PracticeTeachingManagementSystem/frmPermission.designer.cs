namespace PracticeTeachingManagementSystem
{
    partial class frmPermission
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
            this.gvPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPermission = new DevExpress.XtraGrid.GridControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPermission
            // 
            this.gvPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gvPermission.GridControl = this.gcPermission;
            this.gvPermission.GroupPanelText = "Thông tin quyền";
            this.gvPermission.Name = "gvPermission";
            this.gvPermission.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvPermission.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPermission_CellValueChanged);
            this.gvPermission.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvPermission_InitNewRow);
            this.gvPermission.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPermission_RowUpdated);
            this.gvPermission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvPermission_KeyPress);
            this.gvPermission.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvPermission_KeyUp);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên quyền";
            this.gridColumn2.FieldName = "PermissionName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 156;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô tả";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 251;
            // 
            // gcPermission
            // 
            this.gcPermission.Location = new System.Drawing.Point(9, 9);
            this.gcPermission.MainView = this.gvPermission;
            this.gcPermission.Name = "gcPermission";
            this.gcPermission.Size = new System.Drawing.Size(507, 353);
            this.gcPermission.TabIndex = 1;
            this.gcPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPermission});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã quyền";
            this.gridColumn1.FieldName = "PermissionCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 371);
            this.Controls.Add(this.gcPermission);
            this.Name = "frmPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật quyền";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl gcPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}