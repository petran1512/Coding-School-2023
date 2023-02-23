namespace Fuel.Station.Windows.Client
{
    partial class AutoCustomerFinder
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxCustomFinder = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Please ender Customer\'s Card Number:";
            // 
            // boxCustomFinder
            // 
            this.boxCustomFinder.Location = new System.Drawing.Point(43, 100);
            this.boxCustomFinder.Multiline = true;
            this.boxCustomFinder.Name = "boxCustomFinder";
            this.boxCustomFinder.Size = new System.Drawing.Size(265, 35);
            this.boxCustomFinder.TabIndex = 37;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(43, 167);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(73, 37);
            this.btnFind.TabIndex = 38;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(697, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 44);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AutoCustomerFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.boxCustomFinder);
            this.Controls.Add(this.label1);
            this.Name = "AutoCustomerFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox boxCustomFinder;
        private Button btnFind;
        private Button btnBack;
    }
}