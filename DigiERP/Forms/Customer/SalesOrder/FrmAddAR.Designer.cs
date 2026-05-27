namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmAddAR
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
            label2 = new Label();
            numPercent = new Common.CommonNumericUpDown();
            numAmount = new Common.CommonNumericUpDown();
            label3 = new Label();
            button1 = new Button();
            cboInstallmentPeriod = new Common.CommonComboBox();
            ((System.ComponentModel.ISupportInitialize)numPercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "款項期別";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "成數";
            // 
            // numPercent
            // 
            numPercent.Location = new Point(84, 52);
            numPercent.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numPercent.Name = "numPercent";
            numPercent.Size = new Size(100, 23);
            numPercent.TabIndex = 3;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(84, 84);
            numAmount.Maximum = new decimal(new int[] { -159383553, 46653770, 5421, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(100, 23);
            numAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 88);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "金額";
            // 
            // button1
            // 
            button1.Location = new Point(108, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboInstallmentPeriod
            // 
            cboInstallmentPeriod.FormattingEnabled = true;
            cboInstallmentPeriod.Items.AddRange(new object[] { "", "訂金", "期約", "裝機", "驗機", "出貨", "交貨", "售後" });
            cboInstallmentPeriod.Location = new Point(84, 20);
            cboInstallmentPeriod.Name = "cboInstallmentPeriod";
            cboInstallmentPeriod.Size = new Size(100, 23);
            cboInstallmentPeriod.TabIndex = 7;
            // 
            // FrmAddAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 171);
            Controls.Add(cboInstallmentPeriod);
            Controls.Add(button1);
            Controls.Add(numAmount);
            Controls.Add(label3);
            Controls.Add(numPercent);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAddAR";
            Text = "新增應收款";
            ((System.ComponentModel.ISupportInitialize)numPercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Common.CommonNumericUpDown numPercent;
        private Common.CommonNumericUpDown numAmount;
        private Label label3;
        private Button button1;
        private Common.CommonComboBox cboInstallmentPeriod;
    }
}