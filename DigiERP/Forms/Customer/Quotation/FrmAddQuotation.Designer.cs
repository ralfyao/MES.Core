namespace DigiERP.Forms.Customer.Quotation
{
    partial class FrmAddQuotation
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
            label1 = new Label();
            txtProductId = new Common.CommonTextBox();
            button1 = new Button();
            txtProductName = new Common.CommonTextBox();
            label2 = new Label();
            label3 = new Label();
            numQuantity = new Common.CommonNumericUpDown();
            label4 = new Label();
            numUnitPrice = new Common.CommonNumericUpDown();
            label5 = new Label();
            numAmount = new Common.CommonNumericUpDown();
            txtUnit = new Common.CommonTextBox();
            label6 = new Label();
            txtDescription = new Common.CommonTextBox();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "產品編號";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProductId.Location = new Point(120, 16);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(264, 32);
            txtProductId.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(392, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "查詢";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Enabled = false;
            txtProductName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProductName.Location = new Point(120, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(264, 32);
            txtProductName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 3;
            label2.Text = "品名規格";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 5;
            label3.Text = "數量";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            numQuantity.Location = new Point(120, 120);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 32);
            numQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(24, 216);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 7;
            label4.Text = "單價";
            // 
            // numUnitPrice
            // 
            numUnitPrice.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            numUnitPrice.Location = new Point(120, 212);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(120, 32);
            numUnitPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(24, 272);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 9;
            label5.Text = "金額";
            // 
            // numAmount
            // 
            numAmount.Enabled = false;
            numAmount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            numAmount.Location = new Point(120, 267);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 32);
            numAmount.TabIndex = 10;
            // 
            // txtUnit
            // 
            txtUnit.Enabled = false;
            txtUnit.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtUnit.Location = new Point(120, 166);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(120, 32);
            txtUnit.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(24, 171);
            label6.Name = "label6";
            label6.Size = new Size(48, 24);
            label6.TabIndex = 11;
            label6.Text = "單位";
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDescription.Location = new Point(120, 314);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(264, 118);
            txtDescription.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(24, 320);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 13;
            label7.Text = "描述";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(312, 448);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 15;
            button2.Text = "新增";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmAddQuotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 491);
            Controls.Add(button2);
            Controls.Add(txtDescription);
            Controls.Add(label7);
            Controls.Add(txtUnit);
            Controls.Add(label6);
            Controls.Add(numAmount);
            Controls.Add(label5);
            Controls.Add(numUnitPrice);
            Controls.Add(label4);
            Controls.Add(numQuantity);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAddQuotation";
            Text = "新增報價單明細";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Common.CommonTextBox txtProductId;
        private Button button1;
        private Common.CommonTextBox txtProductName;
        private Label label2;
        private Label label3;
        private Common.CommonNumericUpDown numQuantity;
        private Label label4;
        private Common.CommonNumericUpDown numUnitPrice;
        private Label label5;
        private Common.CommonNumericUpDown numAmount;
        private Common.CommonTextBox txtUnit;
        private Label label6;
        private Common.CommonTextBox txtDescription;
        private Label label7;
        private Button button2;
    }
}