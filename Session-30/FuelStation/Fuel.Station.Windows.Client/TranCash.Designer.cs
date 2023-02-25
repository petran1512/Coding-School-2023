namespace Fuel.Station.Windows.Client
{
    partial class TranCash
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
            this.xtraTabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.grvTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grvTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTree = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colTransactionLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.ListBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboItems = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsItemTypes = new System.Windows.Forms.BindingSource(this.components);
            this.transactionlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabTransactions;
            this.tabControlMain.Size = new System.Drawing.Size(878, 280);
            this.tabControlMain.TabIndex = 15;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabTransactions});
            // 
            // xtraTabTransactions
            // 
            this.xtraTabTransactions.Controls.Add(this.grvTransactions);
            this.xtraTabTransactions.Name = "xtraTabTransactions";
            this.xtraTabTransactions.Size = new System.Drawing.Size(876, 255);
            this.xtraTabTransactions.Text = "Transactions";
            // 
            // grvTransactions
            // 
            this.grvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransactions.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvTransactions.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvTransactions.Location = new System.Drawing.Point(0, 0);
            this.grvTransactions.MainView = this.gridView1;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees});
            this.grvTransactions.Size = new System.Drawing.Size(876, 255);
            this.grvTransactions.TabIndex = 1;
            this.grvTransactions.UseEmbeddedNavigator = true;
            this.grvTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionEmployee,
            this.colTransactionCustomerId,
            this.colTransactionDate,
            this.colTransactionPaymentMethod,
            this.colTransactionTotalValue,
            this.colTransactionID});
            this.gridView1.GridControl = this.grvTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView5_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView5_ValidateRow);
            // 
            // colTransactionEmployee
            // 
            this.colTransactionEmployee.Caption = "Employee";
            this.colTransactionEmployee.ColumnEdit = this.repEmployees;
            this.colTransactionEmployee.FieldName = "Employee";
            this.colTransactionEmployee.Name = "colTransactionEmployee";
            this.colTransactionEmployee.Visible = true;
            this.colTransactionEmployee.VisibleIndex = 0;
            // 
            // repEmployees
            // 
            this.repEmployees.AutoHeight = false;
            this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployees.Name = "repEmployees";
            // 
            // colTransactionCustomerId
            // 
            this.colTransactionCustomerId.Caption = "CustomerId";
            this.colTransactionCustomerId.FieldName = "CustomerId";
            this.colTransactionCustomerId.Name = "colTransactionCustomerId";
            this.colTransactionCustomerId.Visible = true;
            this.colTransactionCustomerId.VisibleIndex = 1;
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
            // colTransactionID
            // 
            this.colTransactionID.Caption = "Id";
            this.colTransactionID.FieldName = "Id";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = true;
            this.colTransactionID.VisibleIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 300);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(876, 224);
            this.xtraTabControl1.TabIndex = 17;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grvTransactionLines);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(874, 199);
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
            this.grvTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemTree});
            this.grvTransactionLines.Size = new System.Drawing.Size(874, 199);
            this.grvTransactionLines.TabIndex = 1;
            this.grvTransactionLines.UseEmbeddedNavigator = true;
            this.grvTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionLineId,
            this.colTransactionLineTransactionId,
            this.colTransactionLineQuantity,
            this.colTransactionLineItemPrice,
            this.colTransactionLineItemId,
            this.colTransactionLineNetValue,
            this.colTransactionLineDiscountPercent,
            this.colTransactionLineDiscountValue,
            this.colTransactionLineTotalValue});
            this.gridView2.GridControl = this.grvTransactionLines;
            this.gridView2.Name = "gridView2";
            // 
            // colTransactionLineId
            // 
            this.colTransactionLineId.Caption = "Id";
            this.colTransactionLineId.FieldName = "Id";
            this.colTransactionLineId.Name = "colTransactionLineId";
            this.colTransactionLineId.Visible = true;
            this.colTransactionLineId.VisibleIndex = 4;
            // 
            // colTransactionLineTransactionId
            // 
            this.colTransactionLineTransactionId.Caption = "TransactionId";
            this.colTransactionLineTransactionId.FieldName = "TransactionId";
            this.colTransactionLineTransactionId.Name = "colTransactionLineTransactionId";
            this.colTransactionLineTransactionId.Visible = true;
            this.colTransactionLineTransactionId.VisibleIndex = 5;
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
            // colTransactionLineItemId
            // 
            this.colTransactionLineItemId.Caption = "Item";
            this.colTransactionLineItemId.ColumnEdit = this.repItemTree;
            this.colTransactionLineItemId.FieldName = "ItemId";
            this.colTransactionLineItemId.Name = "colTransactionLineItemId";
            // 
            // repItemTree
            // 
            this.repItemTree.AutoHeight = false;
            this.repItemTree.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemTree.Name = "repItemTree";
            this.repItemTree.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(181, 24);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1100, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 23);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listItems
            // 
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 15;
            this.listItems.Location = new System.Drawing.Point(896, 63);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(198, 94);
            this.listItems.TabIndex = 44;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(914, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 21);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Items:";
            // 
            // comboItems
            // 
            this.comboItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboItems.FormattingEnabled = true;
            this.comboItems.Location = new System.Drawing.Point(995, 36);
            this.comboItems.Name = "comboItems";
            this.comboItems.Size = new System.Drawing.Size(99, 23);
            this.comboItems.TabIndex = 42;
            this.comboItems.SelectedIndexChanged += new System.EventHandler(this.comboItems_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(965, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 30);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Login Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TranCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboItems);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "TranCash";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TranCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabTransactions;
        private DevExpress.XtraGrid.GridControl grvTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grvTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repItemTree;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
        private Button button1;
        private Button btnAdd;
        private ListBox listItems;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ComboBox comboItems;
        private Button btnBack;
        private BindingSource transactionBindingSource;
        private BindingSource bsItemTypes;
        private BindingSource transactionlineBindingSource;
        private BindingSource bindingSource1;
        private BindingSource bsItems;
    }
}