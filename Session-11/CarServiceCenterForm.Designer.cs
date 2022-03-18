namespace Session_11
{
    partial class CarServiceCenterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTrasaction = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.carToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.engineerToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.monthlyLedgerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomer});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // editCustomer
            // 
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(180, 22);
            this.editCustomer.Text = "Edit...";
            this.editCustomer.Click += new System.EventHandler(this.editCustomer_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit...";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editCar_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem2});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.staffToolStripMenuItem.Text = "Manager";
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem2.Text = "Edit...";
            // 
            // engineerToolStripMenuItem
            // 
            this.engineerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem3});
            this.engineerToolStripMenuItem.Name = "engineerToolStripMenuItem";
            this.engineerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.engineerToolStripMenuItem.Text = "Engineer";
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.editToolStripMenuItem3.Text = "Edit..";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrasaction});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // newTrasaction
            // 
            this.newTrasaction.Name = "newTrasaction";
            this.newTrasaction.Size = new System.Drawing.Size(103, 22);
            this.newTrasaction.Text = "Edit...";
            // 
            // monthlyLedgerToolStripMenuItem
            // 
            this.monthlyLedgerToolStripMenuItem.Name = "monthlyLedgerToolStripMenuItem";
            this.monthlyLedgerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.monthlyLedgerToolStripMenuItem.Text = "Monthly Ledger";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(765, 345);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(765, 345);
            this.Root.TextVisible = false;
            // 
            // CarServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 369);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarServiceCenterForm";
            this.Text = "CarServiceCenter";
            this.Load += new System.EventHandler(this.CarServiceCenterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem newTrasaction;
        private ToolStripMenuItem staffToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private ToolStripMenuItem monthlyLedgerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem editCustomer;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem engineerToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem3;
    }
}