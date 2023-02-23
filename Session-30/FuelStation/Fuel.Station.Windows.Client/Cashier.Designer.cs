namespace Fuel.Station.Windows.Client
{
    partial class Cashier
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
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItems
            // 
            this.btnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItems.Location = new System.Drawing.Point(467, 151);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(214, 58);
            this.btnItems.TabIndex = 5;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.Location = new System.Drawing.Point(157, 151);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(214, 58);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackLogin.Location = new System.Drawing.Point(293, 274);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(267, 42);
            this.btnBackLogin.TabIndex = 6;
            this.btnBackLogin.Text = "Back to Login Page";
            this.btnBackLogin.UseVisualStyleBackColor = true;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCustomers);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnItems;
        private Button btnCustomers;
        private Button btnBackLogin;
    }
}