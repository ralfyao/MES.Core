namespace DigiERP.Forms.Customer.ShippingOrder
{
    partial class FrmPrintShippingOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintShippingOrder));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtCustName = new TextBox();
            txtCustNo = new TextBox();
            label2 = new Label();
            txtContact = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1042, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 888);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1042, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 124);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 2;
            label1.Text = "客戶名稱";
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(96, 120);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(528, 32);
            txtCustName.TabIndex = 3;
            // 
            // txtCustNo
            // 
            txtCustNo.Location = new Point(660, 120);
            txtCustNo.Name = "txtCustNo";
            txtCustNo.Size = new Size(169, 32);
            txtCustNo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(868, 120);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 5;
            label2.Text = "出貨單";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(96, 172);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(244, 32);
            txtContact.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 176);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 6;
            label3.Text = "聯絡人";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(424, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 32);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 176);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 8;
            label4.Text = "電郵";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(836, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 32);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 176);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 11;
            label5.Text = "日期";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 32);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 228);
            label6.Name = "label6";
            label6.Size = new Size(48, 24);
            label6.TabIndex = 12;
            label6.Text = "電話";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(424, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 32);
            textBox3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 228);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 14;
            label7.Text = "電郵";
            // 
            // FrmPrintShippingOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1042, 995);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustNo);
            Controls.Add(txtCustName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmPrintShippingOrder";
            Text = "FrmPrintShippingOrder";
            Click += FrmPrintShippingOrder_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtCustName;
        private TextBox txtCustNo;
        private Label label2;
        private TextBox txtContact;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
    }
}