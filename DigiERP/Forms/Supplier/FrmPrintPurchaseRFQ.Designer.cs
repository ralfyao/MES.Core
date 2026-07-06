using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Supplier
{
    partial class FrmPrintPurchaseRFQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintPurchaseRFQ));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnPreviewPrint = new Button();
            pictureBoxHeader = new PictureBox();
            panelContent = new Panel();
            lblRfqTitle = new Label();
            lblSupplierNameCap = new Label();
            lblSupplierNo = new Label();
            lblSupplierName = new Label();
            lblTaxIdCap = new Label();
            lblTaxId = new Label();
            lblFaxCap = new Label();
            lblFax = new Label();
            lblInquiryDateCap = new Label();
            lblInquiryDate = new Label();
            lblContactCap = new Label();
            lblContact = new Label();
            lblPhoneCap = new Label();
            lblPhone = new Label();
            lblInquiryPersonCap = new Label();
            lblInquiryPerson = new Label();
            lblSupplierPartNoCap = new Label();
            lblSupplierPartNo = new Label();
            lblMinQtyCap = new Label();
            lblMinQty = new Label();
            lblValidDateCap = new Label();
            lblValidDate = new Label();
            dgvItems = new DataGridView();
            colProductNo = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            lblRemarkCap = new Label();
            txtRemark = new TextBox();
            lblConfirmCap = new Label();
            panelConfirmBox = new Panel();
            pictureBoxFooter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFooter).BeginInit();
            SuspendLayout();
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.Red;
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.ForeColor = Color.White;
            btnPreviewPrint.Location = new Point(684, 36);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(100, 30);
            btnPreviewPrint.TabIndex = 0;
            btnPreviewPrint.Text = "預覽列印";
            btnPreviewPrint.UseVisualStyleBackColor = false;
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            // 
            // pictureBoxHeader
            // 
            pictureBoxHeader.Dock = DockStyle.Top;
            pictureBoxHeader.Image = (Image)resources.GetObject("pictureBoxHeader.Image");
            pictureBoxHeader.Location = new Point(0, 0);
            pictureBoxHeader.Name = "pictureBoxHeader";
            pictureBoxHeader.Size = new Size(830, 90);
            pictureBoxHeader.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHeader.TabIndex = 1;
            pictureBoxHeader.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblRfqTitle);
            panelContent.Controls.Add(lblSupplierNameCap);
            panelContent.Controls.Add(lblSupplierNo);
            panelContent.Controls.Add(lblSupplierName);
            panelContent.Controls.Add(lblTaxIdCap);
            panelContent.Controls.Add(lblTaxId);
            panelContent.Controls.Add(lblFaxCap);
            panelContent.Controls.Add(lblFax);
            panelContent.Controls.Add(lblInquiryDateCap);
            panelContent.Controls.Add(lblInquiryDate);
            panelContent.Controls.Add(lblContactCap);
            panelContent.Controls.Add(lblContact);
            panelContent.Controls.Add(lblPhoneCap);
            panelContent.Controls.Add(lblPhone);
            panelContent.Controls.Add(lblInquiryPersonCap);
            panelContent.Controls.Add(lblInquiryPerson);
            panelContent.Controls.Add(lblSupplierPartNoCap);
            panelContent.Controls.Add(lblSupplierPartNo);
            panelContent.Controls.Add(lblMinQtyCap);
            panelContent.Controls.Add(lblMinQty);
            panelContent.Controls.Add(lblValidDateCap);
            panelContent.Controls.Add(lblValidDate);
            panelContent.Controls.Add(dgvItems);
            panelContent.Controls.Add(lblRemarkCap);
            panelContent.Controls.Add(txtRemark);
            panelContent.Controls.Add(lblConfirmCap);
            panelContent.Controls.Add(panelConfirmBox);
            panelContent.Dock = DockStyle.Top;
            panelContent.Location = new Point(0, 90);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(830, 454);
            panelContent.TabIndex = 2;
            panelContent.Click += panelContent_Click;
            // 
            // lblRfqTitle
            // 
            lblRfqTitle.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
            lblRfqTitle.Location = new Point(600, 4);
            lblRfqTitle.Name = "lblRfqTitle";
            lblRfqTitle.Size = new Size(160, 30);
            lblRfqTitle.TabIndex = 0;
            lblRfqTitle.Text = "詢 價 單";
            // 
            // lblSupplierNameCap
            // 
            lblSupplierNameCap.AutoSize = true;
            lblSupplierNameCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSupplierNameCap.Location = new Point(8, 10);
            lblSupplierNameCap.Name = "lblSupplierNameCap";
            lblSupplierNameCap.Size = new Size(64, 18);
            lblSupplierNameCap.TabIndex = 1;
            lblSupplierNameCap.Text = "廠商名稱";
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Font = new Font("微軟正黑體", 10F);
            lblSupplierNo.Location = new Point(90, 10);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(0, 18);
            lblSupplierNo.TabIndex = 2;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("微軟正黑體", 10F);
            lblSupplierName.Location = new Point(150, 10);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(0, 18);
            lblSupplierName.TabIndex = 3;
            // 
            // lblTaxIdCap
            // 
            lblTaxIdCap.AutoSize = true;
            lblTaxIdCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTaxIdCap.Location = new Point(8, 42);
            lblTaxIdCap.Name = "lblTaxIdCap";
            lblTaxIdCap.Size = new Size(64, 18);
            lblTaxIdCap.TabIndex = 4;
            lblTaxIdCap.Text = "統一編號";
            // 
            // lblTaxId
            // 
            lblTaxId.AutoSize = true;
            lblTaxId.Font = new Font("微軟正黑體", 10F);
            lblTaxId.Location = new Point(90, 42);
            lblTaxId.Name = "lblTaxId";
            lblTaxId.Size = new Size(0, 18);
            lblTaxId.TabIndex = 5;
            // 
            // lblFaxCap
            // 
            lblFaxCap.AutoSize = true;
            lblFaxCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblFaxCap.Location = new Point(280, 42);
            lblFaxCap.Name = "lblFaxCap";
            lblFaxCap.Size = new Size(36, 18);
            lblFaxCap.TabIndex = 6;
            lblFaxCap.Text = "傳真";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Font = new Font("微軟正黑體", 10F);
            lblFax.Location = new Point(330, 42);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(0, 18);
            lblFax.TabIndex = 7;
            // 
            // lblInquiryDateCap
            // 
            lblInquiryDateCap.AutoSize = true;
            lblInquiryDateCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblInquiryDateCap.Location = new Point(500, 42);
            lblInquiryDateCap.Name = "lblInquiryDateCap";
            lblInquiryDateCap.Size = new Size(64, 18);
            lblInquiryDateCap.TabIndex = 8;
            lblInquiryDateCap.Text = "詢價日期";
            // 
            // lblInquiryDate
            // 
            lblInquiryDate.AutoSize = true;
            lblInquiryDate.Font = new Font("微軟正黑體", 10F);
            lblInquiryDate.Location = new Point(580, 42);
            lblInquiryDate.Name = "lblInquiryDate";
            lblInquiryDate.Size = new Size(0, 18);
            lblInquiryDate.TabIndex = 9;
            // 
            // lblContactCap
            // 
            lblContactCap.AutoSize = true;
            lblContactCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblContactCap.Location = new Point(8, 74);
            lblContactCap.Name = "lblContactCap";
            lblContactCap.Size = new Size(50, 18);
            lblContactCap.TabIndex = 10;
            lblContactCap.Text = "聯絡人";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("微軟正黑體", 10F);
            lblContact.Location = new Point(90, 74);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(0, 18);
            lblContact.TabIndex = 11;
            // 
            // lblPhoneCap
            // 
            lblPhoneCap.AutoSize = true;
            lblPhoneCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblPhoneCap.Location = new Point(280, 74);
            lblPhoneCap.Name = "lblPhoneCap";
            lblPhoneCap.Size = new Size(36, 18);
            lblPhoneCap.TabIndex = 12;
            lblPhoneCap.Text = "電話";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("微軟正黑體", 10F);
            lblPhone.Location = new Point(330, 74);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 18);
            lblPhone.TabIndex = 13;
            // 
            // lblInquiryPersonCap
            // 
            lblInquiryPersonCap.AutoSize = true;
            lblInquiryPersonCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblInquiryPersonCap.Location = new Point(500, 74);
            lblInquiryPersonCap.Name = "lblInquiryPersonCap";
            lblInquiryPersonCap.Size = new Size(64, 18);
            lblInquiryPersonCap.TabIndex = 14;
            lblInquiryPersonCap.Text = "詢價人員";
            // 
            // lblInquiryPerson
            // 
            lblInquiryPerson.AutoSize = true;
            lblInquiryPerson.Font = new Font("微軟正黑體", 10F);
            lblInquiryPerson.Location = new Point(580, 74);
            lblInquiryPerson.Name = "lblInquiryPerson";
            lblInquiryPerson.Size = new Size(0, 18);
            lblInquiryPerson.TabIndex = 15;
            // 
            // lblSupplierPartNoCap
            // 
            lblSupplierPartNoCap.AutoSize = true;
            lblSupplierPartNoCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSupplierPartNoCap.Location = new Point(8, 106);
            lblSupplierPartNoCap.Name = "lblSupplierPartNoCap";
            lblSupplierPartNoCap.Size = new Size(64, 18);
            lblSupplierPartNoCap.TabIndex = 16;
            lblSupplierPartNoCap.Text = "廠商品號";
            // 
            // lblSupplierPartNo
            // 
            lblSupplierPartNo.AutoSize = true;
            lblSupplierPartNo.Font = new Font("微軟正黑體", 10F);
            lblSupplierPartNo.Location = new Point(90, 106);
            lblSupplierPartNo.Name = "lblSupplierPartNo";
            lblSupplierPartNo.Size = new Size(0, 18);
            lblSupplierPartNo.TabIndex = 17;
            // 
            // lblMinQtyCap
            // 
            lblMinQtyCap.AutoSize = true;
            lblMinQtyCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblMinQtyCap.Location = new Point(280, 106);
            lblMinQtyCap.Name = "lblMinQtyCap";
            lblMinQtyCap.Size = new Size(78, 18);
            lblMinQtyCap.TabIndex = 18;
            lblMinQtyCap.Text = "最低採購量";
            // 
            // lblMinQty
            // 
            lblMinQty.AutoSize = true;
            lblMinQty.Font = new Font("微軟正黑體", 10F);
            lblMinQty.Location = new Point(370, 106);
            lblMinQty.Name = "lblMinQty";
            lblMinQty.Size = new Size(0, 18);
            lblMinQty.TabIndex = 19;
            // 
            // lblValidDateCap
            // 
            lblValidDateCap.AutoSize = true;
            lblValidDateCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblValidDateCap.Location = new Point(500, 106);
            lblValidDateCap.Name = "lblValidDateCap";
            lblValidDateCap.Size = new Size(78, 18);
            lblValidDateCap.TabIndex = 20;
            lblValidDateCap.Text = "報價有效日";
            // 
            // lblValidDate
            // 
            lblValidDate.AutoSize = true;
            lblValidDate.Font = new Font("微軟正黑體", 10F);
            lblValidDate.Location = new Point(590, 106);
            lblValidDate.Name = "lblValidDate";
            lblValidDate.Size = new Size(0, 18);
            lblValidDate.TabIndex = 21;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProductNo, colSpec, colQty, colUnit, colUnitPrice, colCurrency, colAmount });
            dgvItems.Font = new Font("微軟正黑體", 9F);
            dgvItems.Location = new Point(8, 136);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowTemplate.Height = 44;
            dgvItems.ScrollBars = ScrollBars.None;
            dgvItems.Size = new Size(810, 90);
            dgvItems.TabIndex = 20;
            // 
            // colProductNo
            // 
            colProductNo.FillWeight = 110F;
            colProductNo.HeaderText = "產品編號";
            colProductNo.Name = "colProductNo";
            colProductNo.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.FillWeight = 300F;
            colSpec.HeaderText = "品名描述";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.FillWeight = 70F;
            colQty.HeaderText = "採購量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.FillWeight = 60F;
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.FillWeight = 70F;
            colUnitPrice.HeaderText = "單價";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.FillWeight = 60F;
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 80F;
            colAmount.HeaderText = "金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // lblRemarkCap
            // 
            lblRemarkCap.AutoSize = true;
            lblRemarkCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblRemarkCap.ForeColor = Color.Firebrick;
            lblRemarkCap.Location = new Point(8, 366);
            lblRemarkCap.Name = "lblRemarkCap";
            lblRemarkCap.Size = new Size(68, 18);
            lblRemarkCap.TabIndex = 22;
            lblRemarkCap.Text = "廠商備註:";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(8, 388);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(650, 56);
            txtRemark.TabIndex = 23;
            // 
            // lblConfirmCap
            // 
            lblConfirmCap.Font = new Font("微軟正黑體", 9F);
            lblConfirmCap.Location = new Point(670, 388);
            lblConfirmCap.Name = "lblConfirmCap";
            lblConfirmCap.Size = new Size(60, 40);
            lblConfirmCap.TabIndex = 24;
            lblConfirmCap.Text = "廠商回簽\r\n確認";
            lblConfirmCap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelConfirmBox
            // 
            panelConfirmBox.BorderStyle = BorderStyle.FixedSingle;
            panelConfirmBox.Location = new Point(735, 388);
            panelConfirmBox.Name = "panelConfirmBox";
            panelConfirmBox.Size = new Size(85, 56);
            panelConfirmBox.TabIndex = 25;
            // 
            // pictureBoxFooter
            // 
            pictureBoxFooter.Dock = DockStyle.Bottom;
            pictureBoxFooter.Image = (Image)resources.GetObject("pictureBoxFooter.Image");
            pictureBoxFooter.Location = new Point(0, 554);
            pictureBoxFooter.Name = "pictureBoxFooter";
            pictureBoxFooter.Size = new Size(830, 90);
            pictureBoxFooter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFooter.TabIndex = 3;
            pictureBoxFooter.TabStop = false;
            // 
            // FrmPrintPurchaseRFQ
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 644);
            Controls.Add(btnPreviewPrint);
            Controls.Add(panelContent);
            Controls.Add(pictureBoxHeader);
            Controls.Add(pictureBoxFooter);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrintPurchaseRFQ";
            StartPosition = FormStartPosition.CenterParent;
            Text = "詢價單列印";
            Click += FrmPrintPurchaseRFQ_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFooter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPreviewPrint;
        private PictureBox pictureBoxHeader;
        private Panel panelContent;
        private Label lblRfqTitle;
        private Label lblSupplierNameCap; private Label lblSupplierNo; private Label lblSupplierName;
        private Label lblTaxIdCap; private Label lblTaxId;
        private Label lblFaxCap; private Label lblFax;
        private Label lblInquiryDateCap; private Label lblInquiryDate;
        private Label lblContactCap; private Label lblContact;
        private Label lblPhoneCap; private Label lblPhone;
        private Label lblInquiryPersonCap; private Label lblInquiryPerson;
        private Label lblSupplierPartNoCap; private Label lblSupplierPartNo;
        private Label lblMinQtyCap; private Label lblMinQty;
        private Label lblValidDateCap; private Label lblValidDate;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colAmount;
        private Label lblRemarkCap;
        private TextBox txtRemark;
        private Label lblConfirmCap;
        private Panel panelConfirmBox;
        private PictureBox pictureBoxFooter;
    }
}
