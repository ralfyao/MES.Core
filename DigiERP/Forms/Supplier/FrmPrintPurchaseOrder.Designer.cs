using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Supplier
{
    partial class FrmPrintPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintPurchaseOrder));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnPreviewPrint = new Button();
            pictureBoxHeader = new PictureBox();
            panelContent = new Panel();
            lblPoTitle = new Label();
            lblSupplierNameCap = new Label();
            lblSupplierName = new Label();
            lblTaxIdCap = new Label();
            lblTaxId = new Label();
            lblFaxCap = new Label();
            lblFax = new Label();
            lblSupplierNoCap = new Label();
            lblSupplierNo = new Label();
            lblOrderDateCap = new Label();
            lblOrderDate = new Label();
            lblContactCap = new Label();
            lblContact = new Label();
            lblPhoneCap = new Label();
            lblPhone = new Label();
            lblCurrencyCap = new Label();
            lblCurrency = new Label();
            lblOrderNoCap = new Label();
            lblOrderNo = new Label();
            lblDeliveryAddrCap = new Label();
            lblDeliveryAddr = new Label();
            lblDeliveryDateCap = new Label();
            lblDeliveryDate = new Label();
            lblNoteCap = new Label();
            lblNote = new Label();
            dgvItems = new DataGridView();
            colSeq = new DataGridViewTextBoxColumn();
            colProductNo = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            lblSumUntaxedCap = new Label();
            lblSumUntaxed = new Label();
            lblTaxCap = new Label();
            lblTax = new Label();
            lblGrandCap = new Label();
            lblGrandTotal = new Label();
            panelApprovalBox = new Panel();
            lblApprovalCap1 = new Label();
            lblApprovalCap2 = new Label();
            lblApprover = new Label();
            lblHandler = new Label();
            panelApprovalVLine = new Panel();
            panelApprovalHLine = new Panel();
            pictureBoxFooter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelApprovalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFooter).BeginInit();
            SuspendLayout();
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.Red;
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.ForeColor = Color.White;
            btnPreviewPrint.Location = new Point(624, 36);
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
            pictureBoxHeader.Size = new Size(799, 90);
            pictureBoxHeader.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHeader.TabIndex = 1;
            pictureBoxHeader.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblPoTitle);
            panelContent.Controls.Add(lblSupplierNameCap);
            panelContent.Controls.Add(lblSupplierName);
            panelContent.Controls.Add(lblTaxIdCap);
            panelContent.Controls.Add(lblTaxId);
            panelContent.Controls.Add(lblFaxCap);
            panelContent.Controls.Add(lblFax);
            panelContent.Controls.Add(lblSupplierNoCap);
            panelContent.Controls.Add(lblSupplierNo);
            panelContent.Controls.Add(lblOrderDateCap);
            panelContent.Controls.Add(lblOrderDate);
            panelContent.Controls.Add(lblContactCap);
            panelContent.Controls.Add(lblContact);
            panelContent.Controls.Add(lblPhoneCap);
            panelContent.Controls.Add(lblPhone);
            panelContent.Controls.Add(lblCurrencyCap);
            panelContent.Controls.Add(lblCurrency);
            panelContent.Controls.Add(lblOrderNoCap);
            panelContent.Controls.Add(lblOrderNo);
            panelContent.Controls.Add(lblDeliveryAddrCap);
            panelContent.Controls.Add(lblDeliveryAddr);
            panelContent.Controls.Add(lblDeliveryDateCap);
            panelContent.Controls.Add(lblDeliveryDate);
            panelContent.Controls.Add(lblNoteCap);
            panelContent.Controls.Add(lblNote);
            panelContent.Controls.Add(dgvItems);
            panelContent.Controls.Add(lblSumUntaxedCap);
            panelContent.Controls.Add(lblSumUntaxed);
            panelContent.Controls.Add(lblTaxCap);
            panelContent.Controls.Add(lblTax);
            panelContent.Controls.Add(lblGrandCap);
            panelContent.Controls.Add(lblGrandTotal);
            panelContent.Controls.Add(panelApprovalBox);
            panelContent.Dock = DockStyle.Top;
            panelContent.Location = new Point(0, 90);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(799, 594);
            panelContent.TabIndex = 2;
            panelContent.Click += panelContent_Click;
            // 
            // lblPoTitle
            // 
            lblPoTitle.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
            lblPoTitle.Location = new Point(600, 4);
            lblPoTitle.Name = "lblPoTitle";
            lblPoTitle.Size = new Size(160, 30);
            lblPoTitle.TabIndex = 0;
            lblPoTitle.Text = "採 購 單";
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
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("微軟正黑體", 10F);
            lblSupplierName.Location = new Point(90, 10);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(0, 18);
            lblSupplierName.TabIndex = 2;
            // 
            // lblTaxIdCap
            // 
            lblTaxIdCap.AutoSize = true;
            lblTaxIdCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTaxIdCap.Location = new Point(8, 38);
            lblTaxIdCap.Name = "lblTaxIdCap";
            lblTaxIdCap.Size = new Size(64, 18);
            lblTaxIdCap.TabIndex = 3;
            lblTaxIdCap.Text = "統一編號";
            // 
            // lblTaxId
            // 
            lblTaxId.AutoSize = true;
            lblTaxId.Font = new Font("微軟正黑體", 10F);
            lblTaxId.Location = new Point(85, 38);
            lblTaxId.Name = "lblTaxId";
            lblTaxId.Size = new Size(0, 18);
            lblTaxId.TabIndex = 4;
            // 
            // lblFaxCap
            // 
            lblFaxCap.AutoSize = true;
            lblFaxCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblFaxCap.Location = new Point(210, 38);
            lblFaxCap.Name = "lblFaxCap";
            lblFaxCap.Size = new Size(36, 18);
            lblFaxCap.TabIndex = 5;
            lblFaxCap.Text = "傳真";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Font = new Font("微軟正黑體", 10F);
            lblFax.Location = new Point(250, 38);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(0, 18);
            lblFax.TabIndex = 6;
            // 
            // lblSupplierNoCap
            // 
            lblSupplierNoCap.AutoSize = true;
            lblSupplierNoCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSupplierNoCap.Location = new Point(375, 38);
            lblSupplierNoCap.Name = "lblSupplierNoCap";
            lblSupplierNoCap.Size = new Size(36, 18);
            lblSupplierNoCap.TabIndex = 7;
            lblSupplierNoCap.Text = "廠編";
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Font = new Font("微軟正黑體", 10F);
            lblSupplierNo.Location = new Point(410, 38);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(0, 18);
            lblSupplierNo.TabIndex = 8;
            // 
            // lblOrderDateCap
            // 
            lblOrderDateCap.AutoSize = true;
            lblOrderDateCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblOrderDateCap.Location = new Point(495, 38);
            lblOrderDateCap.Name = "lblOrderDateCap";
            lblOrderDateCap.Size = new Size(64, 18);
            lblOrderDateCap.TabIndex = 9;
            lblOrderDateCap.Text = "採購日期";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("微軟正黑體", 10F);
            lblOrderDate.Location = new Point(570, 38);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(0, 18);
            lblOrderDate.TabIndex = 10;
            // 
            // lblContactCap
            // 
            lblContactCap.AutoSize = true;
            lblContactCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblContactCap.Location = new Point(8, 64);
            lblContactCap.Name = "lblContactCap";
            lblContactCap.Size = new Size(50, 18);
            lblContactCap.TabIndex = 11;
            lblContactCap.Text = "聯絡人";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("微軟正黑體", 10F);
            lblContact.Location = new Point(85, 64);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(0, 18);
            lblContact.TabIndex = 12;
            // 
            // lblPhoneCap
            // 
            lblPhoneCap.AutoSize = true;
            lblPhoneCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblPhoneCap.Location = new Point(210, 64);
            lblPhoneCap.Name = "lblPhoneCap";
            lblPhoneCap.Size = new Size(36, 18);
            lblPhoneCap.TabIndex = 13;
            lblPhoneCap.Text = "電話";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("微軟正黑體", 10F);
            lblPhone.Location = new Point(250, 64);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 18);
            lblPhone.TabIndex = 14;
            // 
            // lblCurrencyCap
            // 
            lblCurrencyCap.AutoSize = true;
            lblCurrencyCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCurrencyCap.Location = new Point(375, 64);
            lblCurrencyCap.Name = "lblCurrencyCap";
            lblCurrencyCap.Size = new Size(36, 18);
            lblCurrencyCap.TabIndex = 15;
            lblCurrencyCap.Text = "幣別";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("微軟正黑體", 10F);
            lblCurrency.Location = new Point(410, 64);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(0, 18);
            lblCurrency.TabIndex = 16;
            // 
            // lblOrderNoCap
            // 
            lblOrderNoCap.AutoSize = true;
            lblOrderNoCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblOrderNoCap.Location = new Point(495, 64);
            lblOrderNoCap.Name = "lblOrderNoCap";
            lblOrderNoCap.Size = new Size(64, 18);
            lblOrderNoCap.TabIndex = 17;
            lblOrderNoCap.Text = "採購單號";
            // 
            // lblOrderNo
            // 
            lblOrderNo.AutoSize = true;
            lblOrderNo.Font = new Font("微軟正黑體", 10F);
            lblOrderNo.Location = new Point(570, 64);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(0, 18);
            lblOrderNo.TabIndex = 18;
            // 
            // lblDeliveryAddrCap
            // 
            lblDeliveryAddrCap.AutoSize = true;
            lblDeliveryAddrCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblDeliveryAddrCap.Location = new Point(8, 90);
            lblDeliveryAddrCap.Name = "lblDeliveryAddrCap";
            lblDeliveryAddrCap.Size = new Size(64, 18);
            lblDeliveryAddrCap.TabIndex = 19;
            lblDeliveryAddrCap.Text = "指送地址";
            // 
            // lblDeliveryAddr
            // 
            lblDeliveryAddr.AutoSize = true;
            lblDeliveryAddr.Font = new Font("微軟正黑體", 10F);
            lblDeliveryAddr.Location = new Point(85, 90);
            lblDeliveryAddr.Name = "lblDeliveryAddr";
            lblDeliveryAddr.Size = new Size(0, 18);
            lblDeliveryAddr.TabIndex = 20;
            // 
            // lblDeliveryDateCap
            // 
            lblDeliveryDateCap.AutoSize = true;
            lblDeliveryDateCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblDeliveryDateCap.Location = new Point(495, 90);
            lblDeliveryDateCap.Name = "lblDeliveryDateCap";
            lblDeliveryDateCap.Size = new Size(64, 18);
            lblDeliveryDateCap.TabIndex = 21;
            lblDeliveryDateCap.Text = "交貨日期";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("微軟正黑體", 10F);
            lblDeliveryDate.Location = new Point(570, 90);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(0, 18);
            lblDeliveryDate.TabIndex = 22;
            // 
            // lblNoteCap
            // 
            lblNoteCap.AutoSize = true;
            lblNoteCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblNoteCap.Location = new Point(8, 116);
            lblNoteCap.Name = "lblNoteCap";
            lblNoteCap.Size = new Size(64, 18);
            lblNoteCap.TabIndex = 23;
            lblNoteCap.Text = "注意事項";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("微軟正黑體", 10F);
            lblNote.Location = new Point(85, 116);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(0, 18);
            lblNote.TabIndex = 24;
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
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colSeq, colProductNo, colSpec, colQty, colUnit, colUnitPrice, colAmount, colNote, colProject });
            dgvItems.Font = new Font("微軟正黑體", 9F);
            dgvItems.Location = new Point(8, 146);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowTemplate.Height = 30;
            dgvItems.ScrollBars = ScrollBars.None;
            dgvItems.Size = new Size(784, 140);
            dgvItems.TabIndex = 30;
            // 
            // colSeq
            // 
            colSeq.FillWeight = 40F;
            colSeq.HeaderText = "項次";
            colSeq.Name = "colSeq";
            colSeq.ReadOnly = true;
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
            colSpec.FillWeight = 230F;
            colSpec.HeaderText = "品名描述";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.FillWeight = 55F;
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.FillWeight = 45F;
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.FillWeight = 55F;
            colUnitPrice.HeaderText = "單價";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 65F;
            colAmount.HeaderText = "金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colNote
            // 
            colNote.FillWeight = 60F;
            colNote.HeaderText = "備註";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            // 
            // colProject
            // 
            colProject.FillWeight = 70F;
            colProject.HeaderText = "專案序號";
            colProject.Name = "colProject";
            colProject.ReadOnly = true;
            // 
            // lblSumUntaxedCap
            // 
            lblSumUntaxedCap.AutoSize = true;
            lblSumUntaxedCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumUntaxedCap.Location = new Point(300, 535);
            lblSumUntaxedCap.Name = "lblSumUntaxedCap";
            lblSumUntaxedCap.Size = new Size(64, 18);
            lblSumUntaxedCap.TabIndex = 31;
            lblSumUntaxedCap.Text = "金額合計";
            // 
            // lblSumUntaxed
            // 
            lblSumUntaxed.BorderStyle = BorderStyle.FixedSingle;
            lblSumUntaxed.Font = new Font("微軟正黑體", 10F);
            lblSumUntaxed.Location = new Point(380, 531);
            lblSumUntaxed.Name = "lblSumUntaxed";
            lblSumUntaxed.Size = new Size(90, 24);
            lblSumUntaxed.TabIndex = 32;
            lblSumUntaxed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTaxCap
            // 
            lblTaxCap.AutoSize = true;
            lblTaxCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTaxCap.Location = new Point(485, 535);
            lblTaxCap.Name = "lblTaxCap";
            lblTaxCap.Size = new Size(36, 18);
            lblTaxCap.TabIndex = 33;
            lblTaxCap.Text = "稅額";
            // 
            // lblTax
            // 
            lblTax.BorderStyle = BorderStyle.FixedSingle;
            lblTax.Font = new Font("微軟正黑體", 10F);
            lblTax.Location = new Point(520, 531);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(70, 24);
            lblTax.TabIndex = 34;
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGrandCap
            // 
            lblGrandCap.AutoSize = true;
            lblGrandCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblGrandCap.Location = new Point(605, 535);
            lblGrandCap.Name = "lblGrandCap";
            lblGrandCap.Size = new Size(36, 18);
            lblGrandCap.TabIndex = 35;
            lblGrandCap.Text = "總計";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.BorderStyle = BorderStyle.FixedSingle;
            lblGrandTotal.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblGrandTotal.Location = new Point(645, 531);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(120, 24);
            lblGrandTotal.TabIndex = 36;
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelApprovalBox
            // 
            panelApprovalBox.BorderStyle = BorderStyle.FixedSingle;
            panelApprovalBox.Controls.Add(lblApprovalCap1);
            panelApprovalBox.Controls.Add(lblApprovalCap2);
            panelApprovalBox.Controls.Add(lblApprover);
            panelApprovalBox.Controls.Add(lblHandler);
            panelApprovalBox.Controls.Add(panelApprovalVLine);
            panelApprovalBox.Controls.Add(panelApprovalHLine);
            panelApprovalBox.Location = new Point(8, 531);
            panelApprovalBox.Name = "panelApprovalBox";
            panelApprovalBox.Size = new Size(190, 56);
            panelApprovalBox.TabIndex = 37;
            // 
            // lblApprovalCap1
            // 
            lblApprovalCap1.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblApprovalCap1.Location = new Point(2, 2);
            lblApprovalCap1.Name = "lblApprovalCap1";
            lblApprovalCap1.Size = new Size(93, 24);
            lblApprovalCap1.TabIndex = 0;
            lblApprovalCap1.Text = "核准";
            lblApprovalCap1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApprovalCap2
            // 
            lblApprovalCap2.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblApprovalCap2.Location = new Point(96, 2);
            lblApprovalCap2.Name = "lblApprovalCap2";
            lblApprovalCap2.Size = new Size(92, 24);
            lblApprovalCap2.TabIndex = 1;
            lblApprovalCap2.Text = "承辦";
            lblApprovalCap2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApprover
            // 
            lblApprover.Font = new Font("微軟正黑體", 9F);
            lblApprover.Location = new Point(2, 28);
            lblApprover.Name = "lblApprover";
            lblApprover.Size = new Size(93, 24);
            lblApprover.TabIndex = 2;
            lblApprover.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHandler
            // 
            lblHandler.Font = new Font("微軟正黑體", 9F);
            lblHandler.Location = new Point(96, 28);
            lblHandler.Name = "lblHandler";
            lblHandler.Size = new Size(92, 24);
            lblHandler.TabIndex = 3;
            lblHandler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelApprovalVLine
            // 
            panelApprovalVLine.BackColor = Color.Black;
            panelApprovalVLine.Location = new Point(94, 0);
            panelApprovalVLine.Name = "panelApprovalVLine";
            panelApprovalVLine.Size = new Size(1, 54);
            panelApprovalVLine.TabIndex = 4;
            // 
            // panelApprovalHLine
            // 
            panelApprovalHLine.BackColor = Color.Black;
            panelApprovalHLine.Location = new Point(0, 26);
            panelApprovalHLine.Name = "panelApprovalHLine";
            panelApprovalHLine.Size = new Size(188, 1);
            panelApprovalHLine.TabIndex = 5;
            // 
            // pictureBoxFooter
            // 
            pictureBoxFooter.Dock = DockStyle.Bottom;
            pictureBoxFooter.Image = (Image)resources.GetObject("pictureBoxFooter.Image");
            pictureBoxFooter.Location = new Point(0, 730);
            pictureBoxFooter.Name = "pictureBoxFooter";
            pictureBoxFooter.Size = new Size(799, 90);
            pictureBoxFooter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFooter.TabIndex = 3;
            pictureBoxFooter.TabStop = false;
            // 
            // FrmPrintPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 820);
            Controls.Add(btnPreviewPrint);
            Controls.Add(panelContent);
            Controls.Add(pictureBoxHeader);
            Controls.Add(pictureBoxFooter);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrintPurchaseOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "採購單列印";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelApprovalBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFooter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPreviewPrint;
        private PictureBox pictureBoxHeader;
        private Panel panelContent;
        private Label lblPoTitle;
        private Label lblSupplierNameCap; private Label lblSupplierName;
        private Label lblTaxIdCap; private Label lblTaxId;
        private Label lblFaxCap; private Label lblFax;
        private Label lblSupplierNoCap; private Label lblSupplierNo;
        private Label lblOrderDateCap; private Label lblOrderDate;
        private Label lblContactCap; private Label lblContact;
        private Label lblPhoneCap; private Label lblPhone;
        private Label lblCurrencyCap; private Label lblCurrency;
        private Label lblOrderNoCap; private Label lblOrderNo;
        private Label lblDeliveryAddrCap; private Label lblDeliveryAddr;
        private Label lblDeliveryDateCap; private Label lblDeliveryDate;
        private Label lblNoteCap; private Label lblNote;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colSeq;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colProject;
        private Label lblSumUntaxedCap; private Label lblSumUntaxed;
        private Label lblTaxCap; private Label lblTax;
        private Label lblGrandCap; private Label lblGrandTotal;
        private Panel panelApprovalBox;
        private Label lblApprovalCap1; private Label lblApprovalCap2;
        private Label lblApprover; private Label lblHandler;
        private Panel panelApprovalVLine; private Panel panelApprovalHLine;
        private PictureBox pictureBoxFooter;
    }
}
