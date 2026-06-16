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
            txtOrderDate = new TextBox();
            label5 = new Label();
            txtTel = new TextBox();
            label6 = new Label();
            txtSales = new TextBox();
            label7 = new Label();
            btnPreview = new Button();
            label8 = new Label();
            txtOrderNo = new TextBox();
            txtAddress = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtCurrency = new TextBox();
            txtPriceCond = new TextBox();
            label11 = new Label();
            txtShipMethod = new TextBox();
            label12 = new Label();
            txtPaymentTerm = new TextBox();
            label13 = new Label();
            txtShipDate = new TextBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            ProductNo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            txtRemark = new TextBox();
            label15 = new Label();
            label16 = new Label();
            txtTotalAmount = new TextBox();
            label17 = new Label();
            txtTax = new TextBox();
            label18 = new Label();
            txtAmount = new TextBox();
            label19 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1030, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 983);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1030, 107);
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
            txtCustName.BackColor = SystemColors.ButtonHighlight;
            txtCustName.Location = new Point(96, 120);
            txtCustName.Name = "txtCustName";
            txtCustName.ReadOnly = true;
            txtCustName.Size = new Size(528, 32);
            txtCustName.TabIndex = 3;
            // 
            // txtCustNo
            // 
            txtCustNo.BackColor = SystemColors.ButtonHighlight;
            txtCustNo.Location = new Point(660, 120);
            txtCustNo.Name = "txtCustNo";
            txtCustNo.ReadOnly = true;
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
            txtContact.BackColor = SystemColors.ButtonHighlight;
            txtContact.Location = new Point(96, 166);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(244, 32);
            txtContact.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 170);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 6;
            label3.Text = "聯絡人";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ButtonHighlight;
            txtEmail.Location = new Point(424, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(288, 32);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 170);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 8;
            label4.Text = "電郵";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BackColor = SystemColors.ButtonHighlight;
            txtOrderDate.Location = new Point(836, 166);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(169, 32);
            txtOrderDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 170);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 11;
            label5.Text = "日期";
            // 
            // txtTel
            // 
            txtTel.BackColor = SystemColors.ButtonHighlight;
            txtTel.Location = new Point(96, 212);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(244, 32);
            txtTel.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 216);
            label6.Name = "label6";
            label6.Size = new Size(48, 24);
            label6.TabIndex = 12;
            label6.Text = "電話";
            // 
            // txtSales
            // 
            txtSales.BackColor = SystemColors.ButtonHighlight;
            txtSales.Location = new Point(424, 212);
            txtSales.Name = "txtSales";
            txtSales.ReadOnly = true;
            txtSales.Size = new Size(284, 32);
            txtSales.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 216);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 14;
            label7.Text = "業務員";
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.Red;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.ForeColor = SystemColors.ButtonHighlight;
            btnPreview.Location = new Point(812, 44);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(116, 44);
            btnPreview.TabIndex = 16;
            btnPreview.Text = "預覽列印";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(780, 212);
            label8.Name = "label8";
            label8.Size = new Size(48, 24);
            label8.TabIndex = 18;
            label8.Text = "單號";
            // 
            // txtOrderNo
            // 
            txtOrderNo.BackColor = SystemColors.ButtonHighlight;
            txtOrderNo.Location = new Point(836, 208);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.ReadOnly = true;
            txtOrderNo.Size = new Size(169, 32);
            txtOrderNo.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ButtonHighlight;
            txtAddress.Location = new Point(96, 260);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(612, 32);
            txtAddress.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 264);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 19;
            label9.Text = "交貨地址";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(780, 260);
            label10.Name = "label10";
            label10.Size = new Size(48, 24);
            label10.TabIndex = 22;
            label10.Text = "幣別";
            // 
            // txtCurrency
            // 
            txtCurrency.BackColor = SystemColors.ButtonHighlight;
            txtCurrency.Location = new Point(836, 256);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.ReadOnly = true;
            txtCurrency.Size = new Size(169, 32);
            txtCurrency.TabIndex = 21;
            // 
            // txtPriceCond
            // 
            txtPriceCond.BackColor = SystemColors.ButtonHighlight;
            txtPriceCond.Location = new Point(96, 308);
            txtPriceCond.Name = "txtPriceCond";
            txtPriceCond.ReadOnly = true;
            txtPriceCond.Size = new Size(912, 32);
            txtPriceCond.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 312);
            label11.Name = "label11";
            label11.Size = new Size(86, 24);
            label11.TabIndex = 23;
            label11.Text = "價格條件";
            // 
            // txtShipMethod
            // 
            txtShipMethod.BackColor = SystemColors.ButtonHighlight;
            txtShipMethod.Location = new Point(96, 356);
            txtShipMethod.Name = "txtShipMethod";
            txtShipMethod.ReadOnly = true;
            txtShipMethod.Size = new Size(912, 32);
            txtShipMethod.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 360);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 25;
            label12.Text = "交貨方式";
            // 
            // txtPaymentTerm
            // 
            txtPaymentTerm.BackColor = SystemColors.ButtonHighlight;
            txtPaymentTerm.Location = new Point(94, 404);
            txtPaymentTerm.Multiline = true;
            txtPaymentTerm.Name = "txtPaymentTerm";
            txtPaymentTerm.ReadOnly = true;
            txtPaymentTerm.Size = new Size(910, 52);
            txtPaymentTerm.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(2, 408);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 27;
            label13.Text = "付款條件";
            // 
            // txtShipDate
            // 
            txtShipDate.BackColor = SystemColors.ButtonHighlight;
            txtShipDate.Location = new Point(96, 462);
            txtShipDate.Name = "txtShipDate";
            txtShipDate.ReadOnly = true;
            txtShipDate.Size = new Size(912, 32);
            txtShipDate.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 465);
            label14.Name = "label14";
            label14.Size = new Size(86, 24);
            label14.TabIndex = 29;
            label14.Text = "交貨日期";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, ProductNo, ProductName, Qty, Unit, UnitPrice, Amount, Remark });
            dataGridView1.Location = new Point(12, 499);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(996, 224);
            dataGridView1.TabIndex = 31;
            // 
            // No
            // 
            No.HeaderText = "序號";
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 73;
            // 
            // ProductNo
            // 
            ProductNo.HeaderText = "產品編號";
            ProductNo.Name = "ProductNo";
            ProductNo.ReadOnly = true;
            ProductNo.Width = 111;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "品名描述";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 111;
            // 
            // Qty
            // 
            Qty.HeaderText = "數量";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 73;
            // 
            // Unit
            // 
            Unit.HeaderText = "單位";
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.Width = 73;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "單價";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 73;
            // 
            // Amount
            // 
            Amount.HeaderText = "金額";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 73;
            // 
            // Remark
            // 
            Remark.HeaderText = "備註";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            Remark.Width = 73;
            // 
            // txtRemark
            // 
            txtRemark.BackColor = SystemColors.ButtonHighlight;
            txtRemark.Location = new Point(12, 764);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.ReadOnly = true;
            txtRemark.Size = new Size(716, 208);
            txtRemark.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 732);
            label15.Name = "label15";
            label15.Size = new Size(48, 24);
            label15.TabIndex = 33;
            label15.Text = "備註";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(780, 854);
            label16.Name = "label16";
            label16.Size = new Size(48, 24);
            label16.TabIndex = 39;
            label16.Text = "總計";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.ButtonHighlight;
            txtTotalAmount.Location = new Point(836, 850);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(169, 32);
            txtTotalAmount.TabIndex = 38;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(756, 808);
            label17.Name = "label17";
            label17.Size = new Size(67, 24);
            label17.TabIndex = 37;
            label17.Text = "營業稅";
            // 
            // txtTax
            // 
            txtTax.BackColor = SystemColors.ButtonHighlight;
            txtTax.Location = new Point(836, 802);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(169, 32);
            txtTax.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(740, 764);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 35;
            label18.Text = "金額合計";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.ButtonHighlight;
            txtAmount.Location = new Point(836, 760);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(169, 32);
            txtAmount.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(744, 944);
            label19.Name = "label19";
            label19.Size = new Size(124, 24);
            label19.TabIndex = 41;
            label19.Text = "客戶簽收回執";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(872, 940);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(137, 32);
            textBox1.TabIndex = 40;
            // 
            // FrmPrintShippingOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1030, 1090);
            Controls.Add(label19);
            Controls.Add(textBox1);
            Controls.Add(label16);
            Controls.Add(txtTotalAmount);
            Controls.Add(label17);
            Controls.Add(txtTax);
            Controls.Add(label18);
            Controls.Add(txtAmount);
            Controls.Add(label15);
            Controls.Add(txtRemark);
            Controls.Add(dataGridView1);
            Controls.Add(txtShipDate);
            Controls.Add(label14);
            Controls.Add(txtPaymentTerm);
            Controls.Add(label13);
            Controls.Add(txtShipMethod);
            Controls.Add(label12);
            Controls.Add(txtPriceCond);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtCurrency);
            Controls.Add(txtAddress);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtOrderNo);
            Controls.Add(btnPreview);
            Controls.Add(txtSales);
            Controls.Add(label7);
            Controls.Add(txtTel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtOrderDate);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtOrderDate;
        private Label label5;
        private TextBox txtTel;
        private Label label6;
        private TextBox txtSales;
        private Label label7;
        private Button btnPreview;
        private Label label8;
        private TextBox txtOrderNo;
        private TextBox txtAddress;
        private Label label9;
        private Label label10;
        private TextBox txtCurrency;
        private TextBox txtPriceCond;
        private Label label11;
        private TextBox txtShipMethod;
        private Label label12;
        private TextBox txtPaymentTerm;
        private Label label13;
        private TextBox txtShipDate;
        private Label label14;
        private DataGridView dataGridView1;
        private TextBox txtRemark;
        private Label label15;
        private Label label16;
        private TextBox txtTotalAmount;
        private Label label17;
        private TextBox txtTax;
        private Label label18;
        private TextBox txtAmount;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ProductNo;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Remark;
        private Label label19;
        private TextBox textBox1;
    }
}