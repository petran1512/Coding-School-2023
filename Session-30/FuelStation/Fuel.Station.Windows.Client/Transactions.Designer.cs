namespace Fuel.Station.Windows.Client
{
    partial class Transactions
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
            this.btnBack = new System.Windows.Forms.Button();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.grvTransactions = new DevExpress.XtraGrid.GridControl();
            this.transactionlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grvTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLineTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(726, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(245, 30);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back to Login Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Location = new System.Drawing.Point(7, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabTransactions;
            this.tabControlMain.Size = new System.Drawing.Size(959, 280);
            this.tabControlMain.TabIndex = 14;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabTransactions});
            this.tabControlMain.Click += new System.EventHandler(this.tabControlMain_Click);
            // 
            // xtraTabTransactions
            // 
            this.xtraTabTransactions.Controls.Add(this.grvTransactions);
            this.xtraTabTransactions.Name = "xtraTabTransactions";
            this.xtraTabTransactions.Size = new System.Drawing.Size(957, 255);
            this.xtraTabTransactions.Text = "Transactions";
            // 
            // grvTransactions
            // 
            this.grvTransactions.DataSource = this.transactionlineBindingSource;
            this.grvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransactions.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvTransactions.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvTransactions.Location = new System.Drawing.Point(0, 0);
            this.grvTransactions.MainView = this.gridView1;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.Size = new System.Drawing.Size(957, 255);
            this.grvTransactions.TabIndex = 1;
            this.grvTransactions.UseEmbeddedNavigator = true;
            this.grvTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionEmployee,
            this.colTransactionCustomer,
            this.colTransactionDate,
            this.colTransactionPaymentMethod,
            this.colTransactionTotalValue});
            this.gridView1.GridControl = this.grvTransactions;
            this.gridView1.Name = "gridView1";
            // 
            // colTransactionEmployee
            // 
            this.colTransactionEmployee.Caption = "Employee";
            this.colTransactionEmployee.FieldName = "Employee";
            this.colTransactionEmployee.Name = "colTransactionEmployee";
            this.colTransactionEmployee.Visible = true;
            this.colTransactionEmployee.VisibleIndex = 0;
            // 
            // colTransactionCustomer
            // 
            this.colTransactionCustomer.Caption = "Customer";
            this.colTransactionCustomer.FieldName = "Customer";
            this.colTransactionCustomer.Name = "colTransactionCustomer";
            this.colTransactionCustomer.Visible = true;
            this.colTransactionCustomer.VisibleIndex = 1;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Date";
            this.colTransactionDate.FieldName = "Date";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 2;
            // 
            // colTransactionPaymentMethod
            // 
            this.colTransactionPaymentMethod.Caption = "Payment Method";
            this.colTransactionPaymentMethod.FieldName = "PaymentMethod";
            this.colTransactionPaymentMethod.Name = "colTransactionPaymentMethod";
            this.colTransactionPaymentMethod.Visible = true;
            this.colTransactionPaymentMethod.VisibleIndex = 3;
            // 
            // colTransactionTotalValue
            // 
            this.colTransactionTotalValue.Caption = "Total Value";
            this.colTransactionTotalValue.FieldName = "TotalValue";
            this.colTransactionTotalValue.Name = "colTransactionTotalValue";
            this.colTransactionTotalValue.Visible = true;
            this.colTransactionTotalValue.VisibleIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 289);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(957, 224);
            this.xtraTabControl1.TabIndex = 16;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grvTransactionLines);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(955, 199);
            this.xtraTabPage1.Text = "TransactionLines";
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransactionLines.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvTransactionLines.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvTransactionLines.Location = new System.Drawing.Point(0, 0);
            this.grvTransactionLines.MainView = this.gridView2;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.Size = new System.Drawing.Size(955, 199);
            this.grvTransactionLines.TabIndex = 1;
            this.grvTransactionLines.UseEmbeddedNavigator = true;
            this.grvTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionLineTransaction,
            this.colTransactionLineItem,
            this.colTransactionLineQuantity,
            this.colTransactionLineItemPrice,
            this.colTransactionLineNetValue,
            this.colTransactionLineDiscountPercent,
            this.colTransactionLineDiscountValue,
            this.colTransactionLineTotalValue});
            this.gridView2.GridControl = this.grvTransactionLines;
            this.gridView2.Name = "gridView2";
            // 
            // colTransactionLineTransaction
            // 
            this.colTransactionLineTransaction.Caption = "Transaction";
            this.colTransactionLineTransaction.FieldName = "Transaction";
            this.colTransactionLineTransaction.Name = "colTransactionLineTransaction";
            // 
            // colTransactionLineItem
            // 
            this.colTransactionLineItem.Caption = "Item";
            this.colTransactionLineItem.FieldName = "Item";
            this.colTransactionLineItem.Name = "colTransactionLineItem";
            // 
            // colTransactionLineQuantity
            // 
            this.colTransactionLineQuantity.Caption = "Quantity";
            this.colTransactionLineQuantity.FieldName = "Quantity";
            this.colTransactionLineQuantity.Name = "colTransactionLineQuantity";
            // 
            // colTransactionLineItemPrice
            // 
            this.colTransactionLineItemPrice.Caption = "Item Price";
            this.colTransactionLineItemPrice.FieldName = "ItemPrice";
            this.colTransactionLineItemPrice.Name = "colTransactionLineItemPrice";
            this.colTransactionLineItemPrice.Width = 60;
            // 
            // colTransactionLineNetValue
            // 
            this.colTransactionLineNetValue.Caption = "Net Value";
            this.colTransactionLineNetValue.FieldName = "NetValue";
            this.colTransactionLineNetValue.Name = "colTransactionLineNetValue";
            this.colTransactionLineNetValue.Visible = true;
            this.colTransactionLineNetValue.VisibleIndex = 0;
            this.colTransactionLineNetValue.Width = 60;
            // 
            // colTransactionLineDiscountPercent
            // 
            this.colTransactionLineDiscountPercent.Caption = "Discount Percent";
            this.colTransactionLineDiscountPercent.FieldName = "DiscountPercent";
            this.colTransactionLineDiscountPercent.Name = "colTransactionLineDiscountPercent";
            this.colTransactionLineDiscountPercent.Visible = true;
            this.colTransactionLineDiscountPercent.VisibleIndex = 1;
            this.colTransactionLineDiscountPercent.Width = 100;
            // 
            // colTransactionLineDiscountValue
            // 
            this.colTransactionLineDiscountValue.Caption = "Discount Value";
            this.colTransactionLineDiscountValue.FieldName = "DiscountValue";
            this.colTransactionLineDiscountValue.Name = "colTransactionLineDiscountValue";
            this.colTransactionLineDiscountValue.Visible = true;
            this.colTransactionLineDiscountValue.VisibleIndex = 2;
            this.colTransactionLineDiscountValue.Width = 95;
            // 
            // colTransactionLineTotalValue
            // 
            this.colTransactionLineTotalValue.Caption = "Total Value";
            this.colTransactionLineTotalValue.FieldName = "TotalValue";
            this.colTransactionLineTotalValue.Name = "colTransactionLineTotalValue";
            this.colTransactionLineTotalValue.Visible = true;
            this.colTransactionLineTotalValue.VisibleIndex = 3;
            this.colTransactionLineTotalValue.Width = 60;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnBack);
            this.Name = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBack;
        private BindingSource transactionBindingSource;
        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabTransactions;
        private DevExpress.XtraGrid.GridControl grvTransactions;
        private BindingSource transactionlineBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button button1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grvTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
    }
}