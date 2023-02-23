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
            this.grvEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvEmployeeSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(642, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(206, 44);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back to Login Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Fuel.Station.Model.Transaction);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabTransactions;
            this.tabControlMain.Size = new System.Drawing.Size(836, 374);
            this.tabControlMain.TabIndex = 14;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabTransactions});
            // 
            // xtraTabTransactions
            // 
            this.xtraTabTransactions.Controls.Add(this.grvEmployees);
            this.xtraTabTransactions.Name = "xtraTabTransactions";
            this.xtraTabTransactions.Size = new System.Drawing.Size(834, 349);
            this.xtraTabTransactions.Text = "Transactions";
            // 
            // grvEmployees
            // 
            this.grvEmployees.DataSource = this.transactionBindingSource1;
            this.grvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmployees.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grvEmployees.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grvEmployees.Location = new System.Drawing.Point(0, 0);
            this.grvEmployees.MainView = this.gridView1;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.Size = new System.Drawing.Size(834, 349);
            this.grvEmployees.TabIndex = 1;
            this.grvEmployees.UseEmbeddedNavigator = true;
            this.grvEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colEmployeeSurname,
            this.colEmployeePost,
            this.colvEmployeeSalary});
            this.gridView1.GridControl = this.grvEmployees;
            this.gridView1.Name = "gridView1";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Name";
            this.colEmployeeName.FieldName = "Name";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colEmployeeSurname
            // 
            this.colEmployeeSurname.Caption = "Surname";
            this.colEmployeeSurname.FieldName = "Surname";
            this.colEmployeeSurname.Name = "colEmployeeSurname";
            this.colEmployeeSurname.Visible = true;
            this.colEmployeeSurname.VisibleIndex = 1;
            // 
            // colEmployeePost
            // 
            this.colEmployeePost.Caption = "Employee Post";
            this.colEmployeePost.FieldName = "EmpType";
            this.colEmployeePost.Name = "colEmployeePost";
            this.colEmployeePost.Visible = true;
            this.colEmployeePost.VisibleIndex = 2;
            // 
            // colvEmployeeSalary
            // 
            this.colvEmployeeSalary.Caption = "Salary";
            this.colvEmployeeSalary.FieldName = "SalaryPerMonth";
            this.colvEmployeeSalary.Name = "colvEmployeeSalary";
            this.colvEmployeeSalary.Visible = true;
            this.colvEmployeeSalary.VisibleIndex = 3;
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(Fuel.Station.Model.Transaction);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnBack);
            this.Name = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBack;
        private BindingSource transactionBindingSource;
        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabTransactions;
        private DevExpress.XtraGrid.GridControl grvEmployees;
        private BindingSource transactionBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePost;
        private DevExpress.XtraGrid.Columns.GridColumn colvEmployeeSalary;
    }
}