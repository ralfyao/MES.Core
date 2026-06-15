namespace DigiERP.Forms.Customer.ShippingOrder
{
    partial class FrmShippingOrderPrint
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
            txtOrderNo = new Common.CommonTextBox();
            txtCustID = new Common.CommonTextBox();
            label2 = new Label();
            txtCustName = new Common.CommonTextBox();
            label3 = new Label();
            txtRemark = new Common.CommonTextBox();
            label4 = new Label();
            btnPreview = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 0;
            label1.Text = "單號";
            // 
            // txtOrderNo
            // 
            txtOrderNo.Enabled = false;
            txtOrderNo.Location = new Point(48, 6);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(168, 32);
            txtOrderNo.TabIndex = 1;
            // 
            // txtCustID
            // 
            txtCustID.Enabled = false;
            txtCustID.Location = new Point(324, 6);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(168, 32);
            txtCustID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 8);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 2;
            label2.Text = "客戶";
            // 
            // txtCustName
            // 
            txtCustName.Enabled = false;
            txtCustName.Location = new Point(104, 50);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(384, 32);
            txtCustName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 52);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "客戶名稱";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(8, 128);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(480, 180);
            txtRemark.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 96);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 6;
            label4.Text = "備註(補充說明)";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(364, 312);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(124, 31);
            btnPreview.TabIndex = 8;
            btnPreview.Text = "預覽報表";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // FrmShippingOrderPrint
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(499, 351);
            Controls.Add(btnPreview);
            Controls.Add(txtRemark);
            Controls.Add(label4);
            Controls.Add(txtCustName);
            Controls.Add(label3);
            Controls.Add(txtCustID);
            Controls.Add(label2);
            Controls.Add(txtOrderNo);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "FrmShippingOrderPrint";
            Text = "出貨單列印框";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Common.CommonTextBox txtOrderNo;
        private Common.CommonTextBox txtCustID;
        private Label label2;
        private Common.CommonTextBox txtCustName;
        private Label label3;
        private Common.CommonTextBox txtRemark;
        private Label label4;
        private Button btnPreview;
    }
}