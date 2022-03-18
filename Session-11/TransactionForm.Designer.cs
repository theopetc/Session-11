namespace Session_11
{
    partial class TransactionForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSaveClose);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.grdTransactionLines);
            this.layoutControl1.Controls.Add(this.grdTransactions);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1150, 613, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(860, 449);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(860, 449);
            this.Root.TextVisible = false;
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(12, 12);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(836, 211);
            this.grdTransactions.TabIndex = 4;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTransactions;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(840, 215);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 227);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.Size = new System.Drawing.Size(648, 210);
            this.grdTransactionLines.TabIndex = 5;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdTransactionLines;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 215);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(652, 214);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(652, 215);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(188, 77);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(664, 304);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(184, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Transaction";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNew;
            this.layoutControlItem3.Location = new System.Drawing.Point(652, 292);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Transaction";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(652, 335);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(664, 395);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(184, 22);
            this.btnSaveClose.StyleController = this.layoutControl1;
            this.btnSaveClose.TabIndex = 8;
            this.btnSaveClose.Text = "Save and Close";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSaveClose;
            this.layoutControlItem5.Location = new System.Drawing.Point(652, 383);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(652, 318);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(188, 17);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(652, 361);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(188, 22);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(652, 409);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(188, 20);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 449);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}