namespace PracticeTeachingManagementSystem
{
    partial class frmConfigHaftYear
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
            this.cboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcConfig = new DevExpress.XtraGrid.GridControl();
            this.gvConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(126, 11);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboYear.Name = "cboYear";
            // 
            // 
            // 
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Size = new System.Drawing.Size(212, 22);
            this.cboYear.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.EditValue = new System.DateTime(2023, 4, 19, 0, 0, 0, 0);
            this.dtpStartDate.Location = new System.Drawing.Point(126, 44);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            // 
            // 
            // 
            this.dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.dtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStartDate.Size = new System.Drawing.Size(279, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Năm học (*):";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày bắt đầu (*):";
            // 
            // gcConfig
            // 
            // 
            // 
            // 
            this.gcConfig.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcConfig.Location = new System.Drawing.Point(12, 112);
            this.gcConfig.MainView = this.gvConfig;
            this.gcConfig.Margin = new System.Windows.Forms.Padding(4);
            this.gcConfig.Name = "gcConfig";
            this.gcConfig.Size = new System.Drawing.Size(393, 222);
            this.gcConfig.TabIndex = 4;
            this.gcConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConfig});
            // 
            // gvConfig
            // 
            this.gvConfig.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gvConfig.DetailHeight = 431;
            this.gvConfig.GridControl = this.gcConfig;
            this.gvConfig.GroupPanelText = "Thông tin quyền";
            this.gvConfig.Name = "gvConfig";
            this.gvConfig.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvConfig.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPermission_CellValueChanged);
            this.gvConfig.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvPermission_KeyUp);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Năm học";
            this.gridColumn2.FieldName = "Year";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 182;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày bắt đầu";
            this.gridColumn3.FieldName = "StartDate";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 293;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 76);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 76);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Bỏ qua";
            // 
            // frmConfigHaftYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gcConfig);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cboYear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigHaftYear";
            this.Text = "Cấu hình cho năm học";
            this.Load += new System.EventHandler(this.frmConfigHaftYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboYear;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConfig;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}