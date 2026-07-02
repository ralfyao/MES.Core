namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class FrmAddSupplierQuotation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSupplierNo = new Label();
            txtSupplierNo = new TextBox();
            lblQuotDate = new Label();
            dtpQuotDate = new DateTimePicker();
            lblItemNo = new Label();
            txtItemNo = new TextBox();
            btnPickItem = new Button();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblMinQty = new Label();
            numMinQty = new NumericUpDown();
            lblMaxQty = new Label();
            numMaxQty = new NumericUpDown();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblCurrency = new Label();
            cboCurrency = new ComboBox();
            lblInquirer = new Label();
            cboInquirer = new ComboBox();
            lblValidDate = new Label();
            dtpValidDate = new DateTimePicker();
            lblVendorItemNo = new Label();
            txtVendorItemNo = new TextBox();
            panelFooter = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numMinQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();

            int labelX = 30, fieldX = 150, fieldW = 300, rowH = 38, y = 20;

            // lblSupplierNo
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Font = new Font("微軟正黑體", 10F);
            lblSupplierNo.Location = new Point(labelX, y + 4);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(64, 18);
            lblSupplierNo.TabIndex = 0;
            lblSupplierNo.Text = "廠商編號";

            // txtSupplierNo
            txtSupplierNo.BackColor = Color.WhiteSmoke;
            txtSupplierNo.Font = new Font("微軟正黑體", 10F);
            txtSupplierNo.Location = new Point(fieldX, y);
            txtSupplierNo.Name = "txtSupplierNo";
            txtSupplierNo.ReadOnly = true;
            txtSupplierNo.Size = new Size(fieldW, 25);
            txtSupplierNo.TabIndex = 1;

            y += rowH;
            // lblQuotDate
            lblQuotDate.AutoSize = true;
            lblQuotDate.Font = new Font("微軟正黑體", 10F);
            lblQuotDate.Location = new Point(labelX, y + 4);
            lblQuotDate.Name = "lblQuotDate";
            lblQuotDate.Size = new Size(64, 18);
            lblQuotDate.TabIndex = 2;
            lblQuotDate.Text = "詢價日期";

            // dtpQuotDate
            dtpQuotDate.Font = new Font("微軟正黑體", 10F);
            dtpQuotDate.Format = DateTimePickerFormat.Custom;
            dtpQuotDate.CustomFormat = "yyyy/MM/dd";
            dtpQuotDate.Location = new Point(fieldX, y);
            dtpQuotDate.Name = "dtpQuotDate";
            dtpQuotDate.Size = new Size(fieldW, 25);
            dtpQuotDate.TabIndex = 3;

            y += rowH;
            // lblItemNo
            lblItemNo.AutoSize = true;
            lblItemNo.Font = new Font("微軟正黑體", 10F);
            lblItemNo.Location = new Point(labelX, y + 4);
            lblItemNo.Name = "lblItemNo";
            lblItemNo.Size = new Size(64, 18);
            lblItemNo.TabIndex = 4;
            lblItemNo.Text = "品項編號";

            // txtItemNo
            txtItemNo.BackColor = Color.WhiteSmoke;
            txtItemNo.Font = new Font("微軟正黑體", 10F);
            txtItemNo.Location = new Point(fieldX, y);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.ReadOnly = true;
            txtItemNo.Size = new Size(fieldW - 32, 25);
            txtItemNo.TabIndex = 5;

            // btnPickItem
            btnPickItem.FlatStyle = FlatStyle.Flat;
            btnPickItem.Font = new Font("Segoe MDL2 Assets", 10F);
            btnPickItem.Location = new Point(fieldX + fieldW - 28, y);
            btnPickItem.Name = "btnPickItem";
            btnPickItem.Size = new Size(28, 25);
            btnPickItem.TabIndex = 6;
            btnPickItem.Text = "";
            btnPickItem.UseVisualStyleBackColor = true;
            btnPickItem.Click += btnPickItem_Click;

            y += rowH;
            // lblUnit
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("微軟正黑體", 10F);
            lblUnit.Location = new Point(labelX, y + 4);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(64, 18);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "採購單位";

            // txtUnit
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Font = new Font("微軟正黑體", 10F);
            txtUnit.Location = new Point(fieldX, y);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(fieldW, 25);
            txtUnit.TabIndex = 8;

            y += rowH;
            // lblMinQty
            lblMinQty.AutoSize = true;
            lblMinQty.Font = new Font("微軟正黑體", 10F);
            lblMinQty.Location = new Point(labelX, y + 4);
            lblMinQty.Name = "lblMinQty";
            lblMinQty.Size = new Size(70, 18);
            lblMinQty.TabIndex = 9;
            lblMinQty.Text = "最低採購量";

            // numMinQty
            numMinQty.Font = new Font("微軟正黑體", 10F);
            numMinQty.Location = new Point(fieldX, y);
            numMinQty.Maximum = 999999;
            numMinQty.Minimum = 0;
            numMinQty.Name = "numMinQty";
            numMinQty.Size = new Size(fieldW, 25);
            numMinQty.TabIndex = 10;

            y += rowH;
            // lblMaxQty
            lblMaxQty.AutoSize = true;
            lblMaxQty.Font = new Font("微軟正黑體", 10F);
            lblMaxQty.Location = new Point(labelX, y + 4);
            lblMaxQty.Name = "lblMaxQty";
            lblMaxQty.Size = new Size(70, 18);
            lblMaxQty.TabIndex = 11;
            lblMaxQty.Text = "最大採購量";

            // numMaxQty
            numMaxQty.Font = new Font("微軟正黑體", 10F);
            numMaxQty.Location = new Point(fieldX, y);
            numMaxQty.Maximum = 999999;
            numMaxQty.Minimum = 0;
            numMaxQty.Name = "numMaxQty";
            numMaxQty.Size = new Size(fieldW, 25);
            numMaxQty.TabIndex = 12;

            y += rowH;
            // lblPrice
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("微軟正黑體", 10F);
            lblPrice.Location = new Point(labelX, y + 4);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 18);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "單價";

            // numPrice
            numPrice.Font = new Font("微軟正黑體", 10F);
            numPrice.Location = new Point(fieldX, y);
            numPrice.Maximum = 99999999;
            numPrice.Minimum = 0;
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(fieldW, 25);
            numPrice.TabIndex = 14;

            y += rowH;
            // lblCurrency
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("微軟正黑體", 10F);
            lblCurrency.Location = new Point(labelX, y + 4);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(36, 18);
            lblCurrency.TabIndex = 15;
            lblCurrency.Text = "幣別";

            // cboCurrency
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.Font = new Font("微軟正黑體", 10F);
            cboCurrency.Location = new Point(fieldX, y);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(fieldW, 25);
            cboCurrency.TabIndex = 16;

            y += rowH;
            // lblInquirer
            lblInquirer.AutoSize = true;
            lblInquirer.Font = new Font("微軟正黑體", 10F);
            lblInquirer.Location = new Point(labelX, y + 4);
            lblInquirer.Name = "lblInquirer";
            lblInquirer.Size = new Size(64, 18);
            lblInquirer.TabIndex = 17;
            lblInquirer.Text = "詢價人員";

            // cboInquirer
            cboInquirer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInquirer.Font = new Font("微軟正黑體", 10F);
            cboInquirer.Location = new Point(fieldX, y);
            cboInquirer.Name = "cboInquirer";
            cboInquirer.Size = new Size(fieldW, 25);
            cboInquirer.TabIndex = 18;

            y += rowH;
            // lblValidDate
            lblValidDate.AutoSize = true;
            lblValidDate.Font = new Font("微軟正黑體", 10F);
            lblValidDate.Location = new Point(labelX, y + 4);
            lblValidDate.Name = "lblValidDate";
            lblValidDate.Size = new Size(90, 18);
            lblValidDate.TabIndex = 19;
            lblValidDate.Text = "報價有效日期";

            // dtpValidDate
            dtpValidDate.Font = new Font("微軟正黑體", 10F);
            dtpValidDate.Format = DateTimePickerFormat.Custom;
            dtpValidDate.CustomFormat = "yyyy/MM/dd";
            dtpValidDate.Location = new Point(fieldX, y);
            dtpValidDate.Name = "dtpValidDate";
            dtpValidDate.Size = new Size(fieldW, 25);
            dtpValidDate.TabIndex = 20;

            y += rowH;
            // lblVendorItemNo
            lblVendorItemNo.AutoSize = true;
            lblVendorItemNo.Font = new Font("微軟正黑體", 10F);
            lblVendorItemNo.Location = new Point(labelX, y + 4);
            lblVendorItemNo.Name = "lblVendorItemNo";
            lblVendorItemNo.Size = new Size(64, 18);
            lblVendorItemNo.TabIndex = 21;
            lblVendorItemNo.Text = "廠商品號";

            // txtVendorItemNo
            txtVendorItemNo.Font = new Font("微軟正黑體", 10F);
            txtVendorItemNo.Location = new Point(fieldX, y);
            txtVendorItemNo.Name = "txtVendorItemNo";
            txtVendorItemNo.Size = new Size(fieldW, 25);
            txtVendorItemNo.TabIndex = 22;

            y += rowH + 20;

            // panelFooter
            panelFooter.BackColor = Color.FromArgb(230, 230, 250);
            panelFooter.Controls.Add(btnExit);
            panelFooter.Controls.Add(btnSave);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, y + 20);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(480, 60);
            panelFooter.TabIndex = 23;

            // btnSave
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(120, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // btnExit
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(260, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 38);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;

            // FrmAddSupplierQuotation
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 250);
            ClientSize = new Size(480, y + 80);
            Controls.Add(lblSupplierNo);
            Controls.Add(txtSupplierNo);
            Controls.Add(lblQuotDate);
            Controls.Add(dtpQuotDate);
            Controls.Add(lblItemNo);
            Controls.Add(txtItemNo);
            Controls.Add(btnPickItem);
            Controls.Add(lblUnit);
            Controls.Add(txtUnit);
            Controls.Add(lblMinQty);
            Controls.Add(numMinQty);
            Controls.Add(lblMaxQty);
            Controls.Add(numMaxQty);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblCurrency);
            Controls.Add(cboCurrency);
            Controls.Add(lblInquirer);
            Controls.Add(cboInquirer);
            Controls.Add(lblValidDate);
            Controls.Add(dtpValidDate);
            Controls.Add(lblVendorItemNo);
            Controls.Add(txtVendorItemNo);
            Controls.Add(panelFooter);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddSupplierQuotation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "廠商供料詢價";
            Load += FrmAddSupplierQuotation_Load;
            ((System.ComponentModel.ISupportInitialize)numMinQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupplierNo;
        private TextBox txtSupplierNo;
        private Label lblQuotDate;
        private DateTimePicker dtpQuotDate;
        private Label lblItemNo;
        private TextBox txtItemNo;
        private Button btnPickItem;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblMinQty;
        private NumericUpDown numMinQty;
        private Label lblMaxQty;
        private NumericUpDown numMaxQty;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblCurrency;
        private ComboBox cboCurrency;
        private Label lblInquirer;
        private ComboBox cboInquirer;
        private Label lblValidDate;
        private DateTimePicker dtpValidDate;
        private Label lblVendorItemNo;
        private TextBox txtVendorItemNo;
        private Panel panelFooter;
        private Button btnSave;
        private Button btnExit;
    }
}
