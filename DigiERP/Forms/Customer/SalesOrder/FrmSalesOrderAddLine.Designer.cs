namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmSalesOrderAddLine
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
            txtProductId = new Common.CommonTextBox();
            label1 = new Label();
            txtProductName = new Common.CommonTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProductId.Location = new Point(120, 22);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(264, 32);
            txtProductId.TabIndex = 3;
            txtProductId.Leave += txtProductId_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 2;
            label1.Text = "產品編號";
            // 
            // txtProductName
            // 
            txtProductName.Enabled = false;
            txtProductName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProductName.Location = new Point(120, 74);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(264, 32);
            txtProductName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(24, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 5;
            label2.Text = "品名規格";
            // 
            // FrmSalesOrderAddLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "FrmSalesOrderAddLine";
            Text = "新增銷售項目";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.CommonTextBox txtProductId;
        private Label label1;
        private Common.CommonTextBox txtProductName;
        private Label label2;
    }
}