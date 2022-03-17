namespace Session_11
{
    partial class ManagersForm
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
            this.layoutControlManagers = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlManagers = new DevExpress.XtraGrid.GridControl();
            this.gridViewManagers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSallary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsManagers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManagers)).BeginInit();
            this.layoutControlManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlManagers
            // 
            this.layoutControlManagers.Controls.Add(this.btnEdit);
            this.layoutControlManagers.Controls.Add(this.btnDelete);
            this.layoutControlManagers.Controls.Add(this.btnNew);
            this.layoutControlManagers.Controls.Add(this.btnSaveClose);
            this.layoutControlManagers.Controls.Add(this.gridControlManagers);
            this.layoutControlManagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlManagers.Location = new System.Drawing.Point(0, 0);
            this.layoutControlManagers.Name = "layoutControlManagers";
            this.layoutControlManagers.Root = this.Root;
            this.layoutControlManagers.Size = new System.Drawing.Size(762, 550);
            this.layoutControlManagers.TabIndex = 0;
            this.layoutControlManagers.Text = "layoutControl1";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(203, 516);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 22);
            this.btnEdit.StyleController = this.layoutControlManagers;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 22);
            this.btnDelete.StyleController = this.layoutControlManagers;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 516);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(187, 22);
            this.btnNew.StyleController = this.layoutControlManagers;
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "NEW";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(591, 516);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(159, 22);
            this.btnSaveClose.StyleController = this.layoutControlManagers;
            this.btnSaveClose.TabIndex = 5;
            this.btnSaveClose.Text = "SAVE AND CLOSE";
            // 
            // gridControlManagers
            // 
            this.gridControlManagers.Location = new System.Drawing.Point(12, 12);
            this.gridControlManagers.MainView = this.gridViewManagers;
            this.gridControlManagers.Name = "gridControlManagers";
            this.gridControlManagers.Size = new System.Drawing.Size(738, 500);
            this.gridControlManagers.TabIndex = 4;
            this.gridControlManagers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewManagers});
            this.gridControlManagers.Click += new System.EventHandler(this.gridControlManagers_Click);
            // 
            // gridViewManagers
            // 
            this.gridViewManagers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnManager,
            this.gridColumnSurname,
            this.gridColumnSallary});
            this.gridViewManagers.GridControl = this.gridControlManagers;
            this.gridViewManagers.Name = "gridViewManagers";
            // 
            // gridColumnManager
            // 
            this.gridColumnManager.Caption = "Name";
            this.gridColumnManager.Name = "gridColumnManager";
            this.gridColumnManager.Visible = true;
            this.gridColumnManager.VisibleIndex = 0;
            // 
            // gridColumnSurname
            // 
            this.gridColumnSurname.Caption = "Surname";
            this.gridColumnSurname.Name = "gridColumnSurname";
            this.gridColumnSurname.Visible = true;
            this.gridColumnSurname.VisibleIndex = 1;
            // 
            // gridColumnSallary
            // 
            this.gridColumnSallary.Caption = "Sallary Per Month";
            this.gridColumnSallary.Name = "gridColumnSallary";
            this.gridColumnSallary.Visible = true;
            this.gridColumnSallary.VisibleIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(762, 550);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlManagers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(742, 504);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSaveClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(579, 504);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(163, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNew;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 504);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(191, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(398, 504);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(191, 504);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 550);
            this.Controls.Add(this.layoutControlManagers);
            this.Name = "ManagersForm";
            this.Text = "Managers";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManagers)).EndInit();
            this.layoutControlManagers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlManagers;
        private DevExpress.XtraGrid.GridControl gridControlManagers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewManagers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnManager;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSallary;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource bsManagers;
    }
}