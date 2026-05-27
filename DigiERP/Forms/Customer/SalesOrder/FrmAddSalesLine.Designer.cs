using DigiERP.Common;

namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmAddSalesLine
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
            txtProductId = new CommonTextBox();
            txtProductName = new CommonTextBox();
            label2 = new Label();
            txtSalesUnit = new CommonTextBox();
            label3 = new Label();
            label4 = new Label();
            numQuantity = new CommonNumericUpDown();
            numOrderUnitPrice = new CommonNumericUpDown();
            label5 = new Label();
            txtComment = new CommonTextBox();
            label6 = new Label();
            txtProjSerial = new CommonTextBox();
            label7 = new Label();
            btnAdd = new Button();
            cboEqpType = new CommonComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOrderUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "產品編號";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(80, 20);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(264, 23);
            txtProductId.TabIndex = 1;
            txtProductId.Leave += txtProductId_Leave;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(80, 60);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(264, 23);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "品名";
            // 
            // txtSalesUnit
            // 
            txtSalesUnit.Location = new Point(80, 100);
            txtSalesUnit.Name = "txtSalesUnit";
            txtSalesUnit.Size = new Size(264, 23);
            txtSalesUnit.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 104);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "銷售單位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 144);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "數量";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(76, 140);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(272, 23);
            numQuantity.TabIndex = 7;
            // 
            // numOrderUnitPrice
            // 
            numOrderUnitPrice.Location = new Point(76, 176);
            numOrderUnitPrice.Name = "numOrderUnitPrice";
            numOrderUnitPrice.Size = new Size(272, 23);
            numOrderUnitPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "訂單單價";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(80, 216);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(264, 23);
            txtComment.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "註記";
            // 
            // txtProjSerial
            // 
            txtProjSerial.Location = new Point(80, 284);
            txtProjSerial.Name = "txtProjSerial";
            txtProjSerial.Size = new Size(264, 23);
            txtProjSerial.TabIndex = 13;
            txtProjSerial.TextChanged += this.txtProjSerial_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 288);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "專案序號";
            label7.Click += label7_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(268, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "加入";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboEqpType
            // 
            cboEqpType.FormattingEnabled = true;
            cboEqpType.Location = new Point(76, 248);
            cboEqpType.Name = "cboEqpType";
            cboEqpType.Size = new Size(268, 23);
            cboEqpType.TabIndex = 15;
            cboEqpType.Enter += cboEqpType_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 252);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 16;
            label8.Text = "機台類型";
            // 
            // FrmAddSalesLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 383);
            Controls.Add(label8);
            Controls.Add(cboEqpType);
            Controls.Add(btnAdd);
            Controls.Add(txtProjSerial);
            Controls.Add(label7);
            Controls.Add(txtComment);
            Controls.Add(label6);
            Controls.Add(numOrderUnitPrice);
            Controls.Add(label5);
            Controls.Add(numQuantity);
            Controls.Add(label4);
            Controls.Add(txtSalesUnit);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAddSalesLine";
            Text = "新增訂單項目";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOrderUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CommonTextBox txtProductId;
        private CommonTextBox txtProductName;
        private Label label2;
        private CommonTextBox txtSalesUnit;
        private Label label3;
        private Label label4;
        private CommonNumericUpDown numQuantity;
        private CommonNumericUpDown numOrderUnitPrice;
        private Label label5;
        private CommonTextBox txtComment;
        private Label label6;
        private CommonTextBox txtProjSerial;
        private Label label7;
        private Button btnAdd;
        private CommonComboBox cboEqpType;
        private Label label8;
    }
}