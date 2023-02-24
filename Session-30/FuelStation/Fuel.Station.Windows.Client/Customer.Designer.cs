namespace Fuel.Station.Windows.Client
{
    partial class Customer
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
            this.tabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabCustomers = new DevExpress.XtraTab.XtraTabPage();
            this.grvCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabCustomers;
            this.tabControlMain.Size = new System.Drawing.Size(860, 390);
            this.tabControlMain.TabIndex = 15;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabCustomers});
            // 
            // xtraTabCustomers
            // 
            this.xtraTabCustomers.Controls.Add(this.grvCustomers);
            this.xtraTabCustomers.Name = "xtraTabCustomers";
            this.xtraTabCustomers.Size = new System.Drawing.Size(858, 365);
            this.xtraTabCustomers.Text = "Customers";
            // 
            // grvCustomers
            // 
            this.grvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCustomers.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvCustomers.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvCustomers.Location = new System.Drawing.Point(0, 0);
            this.grvCustomers.MainView = this.gridView1;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.Size = new System.Drawing.Size(858, 365);
            this.grvCustomers.TabIndex = 1;
            this.grvCustomers.UseEmbeddedNavigator = true;
            this.grvCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerCardNumber});
            this.gridView1.GridControl = this.grvCustomers;
            this.gridView1.Name = "gridView1";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 1;
            // 
            // colCustomerCardNumber
            // 
            this.colCustomerCardNumber.Caption = "Card Number";
            this.colCustomerCardNumber.FieldName = "CardNumber";
            this.colCustomerCardNumber.Name = "colCustomerCardNumber";
            this.colCustomerCardNumber.Visible = true;
            this.colCustomerCardNumber.VisibleIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(622, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(249, 33);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back to Login Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabCustomers;
        private DevExpress.XtraGrid.GridControl grvCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCardNumber;
        private BindingSource customerBindingSource;
        private Button btnBack;
        private Button button1;
    }
}