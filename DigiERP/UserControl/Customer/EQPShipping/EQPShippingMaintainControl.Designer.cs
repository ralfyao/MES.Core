namespace DigiERP.UserControl.Customer.EQPShipping
{
    partial class EQPShippingMaintainControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBack = new Button();
            btnCancelApprove = new Button();
            btnApprove = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdateBox = new Button();
            btnPrint = new Button();
            lblMode = new Label();
            panelForm = new Panel();
            txtPaymentTerm = new TextBox();
            txtPaymentCode = new TextBox();
            lblPayCode = new Label();
            txtPaymentRatio = new TextBox();
            lblPaymentRatio = new Label();
            txtReceivableTotal = new TextBox();
            lblReceivable = new Label();
            cboCurrency = new ComboBox();
            lbl幣別 = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtCaseNo = new TextBox();
            lblCaseNo = new Label();
            txtDestination = new TextBox();
            lblDestination = new Label();
            lblShippingMark = new Label();
            txtMark2 = new TextBox();
            cboMark = new ComboBox();
            lblMark = new Label();
            cboDoc = new ComboBox();
            lblDoc = new Label();
            txtVoyage = new TextBox();
            lblVoyage = new Label();
            cboSurrenderBL = new ComboBox();
            lblSurrenderBL = new Label();
            cboCertOfOrigin = new ComboBox();
            lblCertOfOrigin = new Label();
            txtForwarder = new TextBox();
            lblForwarder = new Label();
            txtShipName = new TextBox();
            lblShipName = new Label();
            cboTypesOfBL = new ComboBox();
            lblTypesOfBL = new Label();
            txtETA = new TextBox();
            lblETA = new Label();
            txtETD = new TextBox();
            lblETD = new Label();
            txtCutOff = new TextBox();
            lblCutOff = new Label();
            cboInsurance = new ComboBox();
            lblInsurance = new Label();
            txtContainerPort = new TextBox();
            lblContainerPort = new Label();
            cboPacking = new ComboBox();
            lblPacking = new Label();
            txtDestinationPort = new TextBox();
            lblDestPort = new Label();
            cboDeliveryTerm = new ComboBox();
            lblDeliveryTerm = new Label();
            txtContainerType = new TextBox();
            lblContainerType = new Label();
            cboContainer = new ComboBox();
            lblContainer = new Label();
            txtPINumber = new TextBox();
            lblPI = new Label();
            txtPONumber = new TextBox();
            lblPO = new Label();
            cboTel = new ComboBox();
            lblTel = new Label();
            txtDeliveryAdd = new TextBox();
            lblDeliveryAdd = new Label();
            cboAttn = new ComboBox();
            lblAttn = new Label();
            txtPostalAdd = new TextBox();
            lblPostalAdd = new Label();
            txtMachine = new TextBox();
            lblMachine = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtConsignee = new TextBox();
            lblConsignee = new Label();
            txtClient = new TextBox();
            lblClient = new Label();
            cboSerialNo = new ComboBox();
            lbl序號 = new Label();
            txtFormNo = new TextBox();
            lbl單號 = new Label();
            dtDate = new DateTimePicker();
            lbl日期 = new Label();
            panelFooter = new Panel();
            txtCreateDate = new TextBox();
            txtCreator = new TextBox();
            lblCreatorLbl = new Label();
            txtModifyDate = new TextBox();
            txtModifier = new TextBox();
            lblModifierLbl = new Label();
            txtApproveDate = new TextBox();
            txtApprover = new TextBox();
            lblApproverLbl = new Label();
            panelDetail = new Panel();
            splitContainer1 = new SplitContainer();
            dgvBox = new DataGridView();
            colDesc = new DataGridViewTextBoxColumn();
            colQTY = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colDollar1 = new DataGridViewComboBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colDollar2 = new DataGridViewComboBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colNW = new DataGridViewTextBoxColumn();
            colGW = new DataGridViewTextBoxColumn();
            colDim = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            panelBoxTotal = new Panel();
            txtBoxTotalGW = new TextBox();
            lblBoxGWLbl = new Label();
            txtBoxTotalNW = new TextBox();
            lblBoxNWLbl = new Label();
            txtBoxTotalAmount = new TextBox();
            lblBoxAmountLbl = new Label();
            lblBoxTotalHeader = new Label();
            lblBoxTitle = new Label();
            dgvPayment = new DataGridView();
            colPayDate = new DataGridViewTextBoxColumn();
            colPayItem = new DataGridViewTextBoxColumn();
            colPayType = new DataGridViewTextBoxColumn();
            colWriteOff = new DataGridViewTextBoxColumn();
            colReceived = new DataGridViewTextBoxColumn();
            colFee = new DataGridViewTextBoxColumn();
            colOtherDeduct = new DataGridViewTextBoxColumn();
            colDeductReason = new DataGridViewTextBoxColumn();
            colOperator = new DataGridViewTextBoxColumn();
            colReview = new DataGridViewTextBoxColumn();
            panelPaymentTotal = new Panel();
            txtPayTotalReceived = new TextBox();
            lblPayReceivedLbl = new Label();
            txtPayTotalWriteOff = new TextBox();
            lblPayWriteOffLbl = new Label();
            lblPayTotalHeader = new Label();
            lblPaymentTitle = new Label();
            panel1.SuspendLayout();
            panelForm.SuspendLayout();
            panelFooter.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBox).BeginInit();
            panelBoxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            panelPaymentTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCancelApprove);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnUpdateBox);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(lblMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 60);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DimGray;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(650, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 44);
            btnBack.TabIndex = 6;
            btnBack.Text = "關閉";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCancelApprove
            // 
            btnCancelApprove.BackColor = Color.CornflowerBlue;
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(540, 8);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(100, 44);
            btnCancelApprove.TabIndex = 5;
            btnCancelApprove.Text = "取消生效";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.CornflowerBlue;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(430, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(100, 44);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(320, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(210, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 44);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateBox
            // 
            btnUpdateBox.BackColor = Color.MediumSeaGreen;
            btnUpdateBox.ForeColor = Color.White;
            btnUpdateBox.Location = new Point(80, 8);
            btnUpdateBox.Name = "btnUpdateBox";
            btnUpdateBox.Size = new Size(120, 44);
            btnUpdateBox.TabIndex = 1;
            btnUpdateBox.Text = "更新裝箱明細";
            btnUpdateBox.UseVisualStyleBackColor = false;
            btnUpdateBox.Visible = false;
            btnUpdateBox.Click += btnUpdateBox_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.DarkOrange;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(760, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 44);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            lblMode.Location = new Point(8, 16);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(48, 24);
            lblMode.TabIndex = 0;
            lblMode.Text = "新增";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(255, 248, 240);
            panelForm.Controls.Add(txtPaymentTerm);
            panelForm.Controls.Add(txtPaymentCode);
            panelForm.Controls.Add(lblPayCode);
            panelForm.Controls.Add(txtPaymentRatio);
            panelForm.Controls.Add(lblPaymentRatio);
            panelForm.Controls.Add(txtReceivableTotal);
            panelForm.Controls.Add(lblReceivable);
            panelForm.Controls.Add(cboCurrency);
            panelForm.Controls.Add(lbl幣別);
            panelForm.Controls.Add(txtTotal);
            panelForm.Controls.Add(lblTotal);
            panelForm.Controls.Add(txtCaseNo);
            panelForm.Controls.Add(lblCaseNo);
            panelForm.Controls.Add(txtDestination);
            panelForm.Controls.Add(lblDestination);
            panelForm.Controls.Add(lblShippingMark);
            panelForm.Controls.Add(txtMark2);
            panelForm.Controls.Add(cboMark);
            panelForm.Controls.Add(lblMark);
            panelForm.Controls.Add(cboDoc);
            panelForm.Controls.Add(lblDoc);
            panelForm.Controls.Add(txtVoyage);
            panelForm.Controls.Add(lblVoyage);
            panelForm.Controls.Add(cboSurrenderBL);
            panelForm.Controls.Add(lblSurrenderBL);
            panelForm.Controls.Add(cboCertOfOrigin);
            panelForm.Controls.Add(lblCertOfOrigin);
            panelForm.Controls.Add(txtForwarder);
            panelForm.Controls.Add(lblForwarder);
            panelForm.Controls.Add(txtShipName);
            panelForm.Controls.Add(lblShipName);
            panelForm.Controls.Add(cboTypesOfBL);
            panelForm.Controls.Add(lblTypesOfBL);
            panelForm.Controls.Add(txtETA);
            panelForm.Controls.Add(lblETA);
            panelForm.Controls.Add(txtETD);
            panelForm.Controls.Add(lblETD);
            panelForm.Controls.Add(txtCutOff);
            panelForm.Controls.Add(lblCutOff);
            panelForm.Controls.Add(cboInsurance);
            panelForm.Controls.Add(lblInsurance);
            panelForm.Controls.Add(txtContainerPort);
            panelForm.Controls.Add(lblContainerPort);
            panelForm.Controls.Add(cboPacking);
            panelForm.Controls.Add(lblPacking);
            panelForm.Controls.Add(txtDestinationPort);
            panelForm.Controls.Add(lblDestPort);
            panelForm.Controls.Add(cboDeliveryTerm);
            panelForm.Controls.Add(lblDeliveryTerm);
            panelForm.Controls.Add(txtContainerType);
            panelForm.Controls.Add(lblContainerType);
            panelForm.Controls.Add(cboContainer);
            panelForm.Controls.Add(lblContainer);
            panelForm.Controls.Add(txtPINumber);
            panelForm.Controls.Add(lblPI);
            panelForm.Controls.Add(txtPONumber);
            panelForm.Controls.Add(lblPO);
            panelForm.Controls.Add(cboTel);
            panelForm.Controls.Add(lblTel);
            panelForm.Controls.Add(txtDeliveryAdd);
            panelForm.Controls.Add(lblDeliveryAdd);
            panelForm.Controls.Add(cboAttn);
            panelForm.Controls.Add(lblAttn);
            panelForm.Controls.Add(txtPostalAdd);
            panelForm.Controls.Add(lblPostalAdd);
            panelForm.Controls.Add(txtMachine);
            panelForm.Controls.Add(lblMachine);
            panelForm.Controls.Add(txtModel);
            panelForm.Controls.Add(lblModel);
            panelForm.Controls.Add(txtConsignee);
            panelForm.Controls.Add(lblConsignee);
            panelForm.Controls.Add(txtClient);
            panelForm.Controls.Add(lblClient);
            panelForm.Controls.Add(cboSerialNo);
            panelForm.Controls.Add(lbl序號);
            panelForm.Controls.Add(txtFormNo);
            panelForm.Controls.Add(lbl單號);
            panelForm.Controls.Add(dtDate);
            panelForm.Controls.Add(lbl日期);
            panelForm.Dock = DockStyle.Top;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1654, 432);
            panelForm.TabIndex = 1;
            // 
            // txtPaymentTerm
            // 
            txtPaymentTerm.BackColor = Color.WhiteSmoke;
            txtPaymentTerm.Location = new Point(680, 360);
            txtPaymentTerm.Name = "txtPaymentTerm";
            txtPaymentTerm.ReadOnly = true;
            txtPaymentTerm.Size = new Size(962, 25);
            txtPaymentTerm.TabIndex = 0;
            // 
            // txtPaymentCode
            // 
            txtPaymentCode.BackColor = Color.WhiteSmoke;
            txtPaymentCode.Location = new Point(592, 360);
            txtPaymentCode.Name = "txtPaymentCode";
            txtPaymentCode.ReadOnly = true;
            txtPaymentCode.Size = new Size(80, 25);
            txtPaymentCode.TabIndex = 1;
            // 
            // lblPayCode
            // 
            lblPayCode.Location = new Point(524, 364);
            lblPayCode.Name = "lblPayCode";
            lblPayCode.Size = new Size(64, 22);
            lblPayCode.TabIndex = 2;
            lblPayCode.Text = "收款條件";
            lblPayCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPaymentRatio
            // 
            txtPaymentRatio.BackColor = Color.WhiteSmoke;
            txtPaymentRatio.Location = new Point(436, 360);
            txtPaymentRatio.Name = "txtPaymentRatio";
            txtPaymentRatio.ReadOnly = true;
            txtPaymentRatio.Size = new Size(80, 25);
            txtPaymentRatio.TabIndex = 3;
            // 
            // lblPaymentRatio
            // 
            lblPaymentRatio.Location = new Point(340, 364);
            lblPaymentRatio.Name = "lblPaymentRatio";
            lblPaymentRatio.Size = new Size(92, 22);
            lblPaymentRatio.TabIndex = 4;
            lblPaymentRatio.Text = "累計收款比例";
            lblPaymentRatio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtReceivableTotal
            // 
            txtReceivableTotal.BackColor = Color.WhiteSmoke;
            txtReceivableTotal.Location = new Point(212, 360);
            txtReceivableTotal.Name = "txtReceivableTotal";
            txtReceivableTotal.ReadOnly = true;
            txtReceivableTotal.Size = new Size(120, 25);
            txtReceivableTotal.TabIndex = 5;
            // 
            // lblReceivable
            // 
            lblReceivable.Location = new Point(136, 364);
            lblReceivable.Name = "lblReceivable";
            lblReceivable.Size = new Size(72, 22);
            lblReceivable.TabIndex = 6;
            lblReceivable.Text = "應收款合計";
            lblReceivable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboCurrency
            // 
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.Location = new Point(48, 360);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(80, 26);
            cboCurrency.TabIndex = 7;
            // 
            // lbl幣別
            // 
            lbl幣別.Location = new Point(8, 364);
            lbl幣別.Name = "lbl幣別";
            lbl幣別.Size = new Size(36, 22);
            lbl幣別.TabIndex = 8;
            lbl幣別.Text = "幣別";
            lbl幣別.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.LemonChiffon;
            txtTotal.Location = new Point(804, 309);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 25);
            txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(760, 301);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 22);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCaseNo
            // 
            txtCaseNo.BackColor = Color.LemonChiffon;
            txtCaseNo.Location = new Point(628, 312);
            txtCaseNo.Name = "txtCaseNo";
            txtCaseNo.Size = new Size(120, 25);
            txtCaseNo.TabIndex = 11;
            // 
            // lblCaseNo
            // 
            lblCaseNo.Location = new Point(560, 313);
            lblCaseNo.Name = "lblCaseNo";
            lblCaseNo.Size = new Size(64, 22);
            lblCaseNo.TabIndex = 12;
            lblCaseNo.Text = "Case No";
            lblCaseNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDestination
            // 
            txtDestination.BackColor = Color.LemonChiffon;
            txtDestination.Location = new Point(316, 313);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(228, 25);
            txtDestination.TabIndex = 13;
            // 
            // lblDestination
            // 
            lblDestination.Location = new Point(192, 313);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(124, 22);
            lblDestination.TabIndex = 14;
            lblDestination.Text = "Destination Port";
            lblDestination.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblShippingMark
            // 
            lblShippingMark.BackColor = Color.Yellow;
            lblShippingMark.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lblShippingMark.Location = new Point(20, 312);
            lblShippingMark.Name = "lblShippingMark";
            lblShippingMark.Size = new Size(152, 26);
            lblShippingMark.TabIndex = 15;
            lblShippingMark.Text = "Shipping Mark";
            lblShippingMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMark2
            // 
            txtMark2.Location = new Point(336, 264);
            txtMark2.Name = "txtMark2";
            txtMark2.Size = new Size(768, 25);
            txtMark2.TabIndex = 16;
            // 
            // cboMark
            // 
            cboMark.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMark.Location = new Point(170, 264);
            cboMark.Name = "cboMark";
            cboMark.Size = new Size(160, 26);
            cboMark.TabIndex = 17;
            // 
            // lblMark
            // 
            lblMark.Location = new Point(12, 268);
            lblMark.Name = "lblMark";
            lblMark.Size = new Size(154, 22);
            lblMark.TabIndex = 18;
            lblMark.Text = "Brand or Trade mark:";
            lblMark.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboDoc
            // 
            cboDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoc.Location = new Point(1248, 228);
            cboDoc.Name = "cboDoc";
            cboDoc.Size = new Size(100, 26);
            cboDoc.TabIndex = 19;
            // 
            // lblDoc
            // 
            lblDoc.Location = new Point(1084, 232);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(160, 22);
            lblDoc.TabIndex = 20;
            lblDoc.Text = "Doc with Consignee:";
            lblDoc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVoyage
            // 
            txtVoyage.Location = new Point(924, 232);
            txtVoyage.Name = "txtVoyage";
            txtVoyage.Size = new Size(150, 25);
            txtVoyage.TabIndex = 21;
            // 
            // lblVoyage
            // 
            lblVoyage.Location = new Point(812, 236);
            lblVoyage.Name = "lblVoyage";
            lblVoyage.Size = new Size(108, 22);
            lblVoyage.TabIndex = 22;
            lblVoyage.Text = "Voyage Number";
            lblVoyage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboSurrenderBL
            // 
            cboSurrenderBL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSurrenderBL.Location = new Point(640, 232);
            cboSurrenderBL.Name = "cboSurrenderBL";
            cboSurrenderBL.Size = new Size(112, 26);
            cboSurrenderBL.TabIndex = 23;
            // 
            // lblSurrenderBL
            // 
            lblSurrenderBL.Location = new Point(532, 236);
            lblSurrenderBL.Name = "lblSurrenderBL";
            lblSurrenderBL.Size = new Size(104, 22);
            lblSurrenderBL.TabIndex = 24;
            lblSurrenderBL.Text = "Surrender B/L";
            lblSurrenderBL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboCertOfOrigin
            // 
            cboCertOfOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCertOfOrigin.Location = new Point(1246, 200);
            cboCertOfOrigin.Name = "cboCertOfOrigin";
            cboCertOfOrigin.Size = new Size(90, 26);
            cboCertOfOrigin.TabIndex = 25;
            // 
            // lblCertOfOrigin
            // 
            lblCertOfOrigin.Location = new Point(1136, 204);
            lblCertOfOrigin.Name = "lblCertOfOrigin";
            lblCertOfOrigin.Size = new Size(106, 22);
            lblCertOfOrigin.TabIndex = 26;
            lblCertOfOrigin.Text = "Cert Of Origin";
            lblCertOfOrigin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtForwarder
            // 
            txtForwarder.Location = new Point(100, 232);
            txtForwarder.Name = "txtForwarder";
            txtForwarder.Size = new Size(364, 25);
            txtForwarder.TabIndex = 27;
            // 
            // lblForwarder
            // 
            lblForwarder.Location = new Point(8, 236);
            lblForwarder.Name = "lblForwarder";
            lblForwarder.Size = new Size(92, 22);
            lblForwarder.TabIndex = 28;
            lblForwarder.Text = "Forwarder";
            lblForwarder.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(916, 200);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(172, 25);
            txtShipName.TabIndex = 29;
            // 
            // lblShipName
            // 
            lblShipName.Location = new Point(812, 204);
            lblShipName.Name = "lblShipName";
            lblShipName.Size = new Size(100, 22);
            lblShipName.TabIndex = 30;
            lblShipName.Text = "Ship Name";
            lblShipName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboTypesOfBL
            // 
            cboTypesOfBL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypesOfBL.Location = new Point(636, 200);
            cboTypesOfBL.Name = "cboTypesOfBL";
            cboTypesOfBL.Size = new Size(160, 26);
            cboTypesOfBL.TabIndex = 31;
            // 
            // lblTypesOfBL
            // 
            lblTypesOfBL.Location = new Point(532, 204);
            lblTypesOfBL.Name = "lblTypesOfBL";
            lblTypesOfBL.Size = new Size(92, 22);
            lblTypesOfBL.TabIndex = 32;
            lblTypesOfBL.Text = "Types of B/L";
            lblTypesOfBL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtETA
            // 
            txtETA.Location = new Point(404, 200);
            txtETA.Name = "txtETA";
            txtETA.Size = new Size(120, 25);
            txtETA.TabIndex = 33;
            // 
            // lblETA
            // 
            lblETA.Location = new Point(364, 204);
            lblETA.Name = "lblETA";
            lblETA.Size = new Size(36, 22);
            lblETA.TabIndex = 34;
            lblETA.Text = "ETA";
            lblETA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtETD
            // 
            txtETD.Location = new Point(236, 200);
            txtETD.Name = "txtETD";
            txtETD.Size = new Size(120, 25);
            txtETD.TabIndex = 35;
            // 
            // lblETD
            // 
            lblETD.Location = new Point(196, 204);
            lblETD.Name = "lblETD";
            lblETD.Size = new Size(36, 22);
            lblETD.TabIndex = 36;
            lblETD.Text = "ETD";
            lblETD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCutOff
            // 
            txtCutOff.Location = new Point(68, 200);
            txtCutOff.Name = "txtCutOff";
            txtCutOff.Size = new Size(120, 25);
            txtCutOff.TabIndex = 37;
            // 
            // lblCutOff
            // 
            lblCutOff.Location = new Point(8, 204);
            lblCutOff.Name = "lblCutOff";
            lblCutOff.Size = new Size(56, 22);
            lblCutOff.TabIndex = 38;
            lblCutOff.Text = "Cut Off";
            lblCutOff.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboInsurance
            // 
            cboInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInsurance.Location = new Point(1244, 168);
            cboInsurance.Name = "cboInsurance";
            cboInsurance.Size = new Size(398, 26);
            cboInsurance.TabIndex = 39;
            // 
            // lblInsurance
            // 
            lblInsurance.Location = new Point(1136, 172);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(100, 22);
            lblInsurance.TabIndex = 40;
            lblInsurance.Text = "Insurance";
            lblInsurance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContainerPort
            // 
            txtContainerPort.Location = new Point(360, 168);
            txtContainerPort.Name = "txtContainerPort";
            txtContainerPort.Size = new Size(152, 25);
            txtContainerPort.TabIndex = 41;
            // 
            // lblContainerPort
            // 
            lblContainerPort.Location = new Point(240, 172);
            lblContainerPort.Name = "lblContainerPort";
            lblContainerPort.Size = new Size(116, 22);
            lblContainerPort.TabIndex = 42;
            lblContainerPort.Text = "Container Port";
            lblContainerPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboPacking
            // 
            cboPacking.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPacking.Location = new Point(920, 168);
            cboPacking.Name = "cboPacking";
            cboPacking.Size = new Size(164, 26);
            cboPacking.TabIndex = 41;
            // 
            // lblPacking
            // 
            lblPacking.Location = new Point(808, 172);
            lblPacking.Name = "lblPacking";
            lblPacking.Size = new Size(76, 22);
            lblPacking.TabIndex = 42;
            lblPacking.Text = "Packing";
            lblPacking.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDestinationPort
            // 
            txtDestinationPort.Location = new Point(640, 168);
            txtDestinationPort.Name = "txtDestinationPort";
            txtDestinationPort.Size = new Size(160, 25);
            txtDestinationPort.TabIndex = 43;
            // 
            // lblDestPort
            // 
            lblDestPort.Location = new Point(516, 172);
            lblDestPort.Name = "lblDestPort";
            lblDestPort.Size = new Size(120, 22);
            lblDestPort.TabIndex = 44;
            lblDestPort.Text = "Destination Port";
            lblDestPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboDeliveryTerm
            // 
            cboDeliveryTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeliveryTerm.Location = new Point(120, 168);
            cboDeliveryTerm.Name = "cboDeliveryTerm";
            cboDeliveryTerm.Size = new Size(108, 26);
            cboDeliveryTerm.TabIndex = 45;
            // 
            // lblDeliveryTerm
            // 
            lblDeliveryTerm.Location = new Point(8, 172);
            lblDeliveryTerm.Name = "lblDeliveryTerm";
            lblDeliveryTerm.Size = new Size(116, 22);
            lblDeliveryTerm.TabIndex = 46;
            lblDeliveryTerm.Text = "Delivery Term";
            lblDeliveryTerm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContainerType
            // 
            txtContainerType.Location = new Point(924, 136);
            txtContainerType.Name = "txtContainerType";
            txtContainerType.Size = new Size(686, 25);
            txtContainerType.TabIndex = 47;
            // 
            // lblContainerType
            // 
            lblContainerType.Location = new Point(808, 140);
            lblContainerType.Name = "lblContainerType";
            lblContainerType.Size = new Size(112, 22);
            lblContainerType.TabIndex = 48;
            lblContainerType.Text = "Container Type";
            lblContainerType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboContainer
            // 
            cboContainer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContainer.Location = new Point(640, 136);
            cboContainer.Name = "cboContainer";
            cboContainer.Size = new Size(160, 26);
            cboContainer.TabIndex = 49;
            // 
            // lblContainer
            // 
            lblContainer.Location = new Point(520, 140);
            lblContainer.Name = "lblContainer";
            lblContainer.Size = new Size(124, 22);
            lblContainer.TabIndex = 50;
            lblContainer.Text = "Container";
            lblContainer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPINumber
            // 
            txtPINumber.Location = new Point(360, 136);
            txtPINumber.Name = "txtPINumber";
            txtPINumber.Size = new Size(152, 25);
            txtPINumber.TabIndex = 51;
            // 
            // lblPI
            // 
            lblPI.Location = new Point(240, 136);
            lblPI.Name = "lblPI";
            lblPI.Size = new Size(96, 22);
            lblPI.TabIndex = 52;
            lblPI.Text = "P/I Number";
            lblPI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPONumber
            // 
            txtPONumber.Location = new Point(124, 136);
            txtPONumber.Name = "txtPONumber";
            txtPONumber.Size = new Size(104, 25);
            txtPONumber.TabIndex = 53;
            // 
            // lblPO
            // 
            lblPO.Location = new Point(8, 140);
            lblPO.Name = "lblPO";
            lblPO.Size = new Size(104, 22);
            lblPO.TabIndex = 54;
            lblPO.Text = "P/O Number";
            lblPO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboTel
            // 
            cboTel.Location = new Point(1016, 104);
            cboTel.Name = "cboTel";
            cboTel.Size = new Size(626, 26);
            cboTel.TabIndex = 55;
            // 
            // lblTel
            // 
            lblTel.Location = new Point(980, 108);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(32, 22);
            lblTel.TabIndex = 56;
            lblTel.Text = "TEL";
            lblTel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDeliveryAdd
            // 
            txtDeliveryAdd.Location = new Point(98, 104);
            txtDeliveryAdd.Name = "txtDeliveryAdd";
            txtDeliveryAdd.Size = new Size(870, 25);
            txtDeliveryAdd.TabIndex = 57;
            // 
            // lblDeliveryAdd
            // 
            lblDeliveryAdd.Location = new Point(8, 108);
            lblDeliveryAdd.Name = "lblDeliveryAdd";
            lblDeliveryAdd.Size = new Size(86, 22);
            lblDeliveryAdd.TabIndex = 58;
            lblDeliveryAdd.Text = "Delivery Add";
            lblDeliveryAdd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboAttn
            // 
            cboAttn.Location = new Point(1024, 72);
            cboAttn.Name = "cboAttn";
            cboAttn.Size = new Size(618, 26);
            cboAttn.TabIndex = 59;
            // 
            // lblAttn
            // 
            lblAttn.Location = new Point(980, 76);
            lblAttn.Name = "lblAttn";
            lblAttn.Size = new Size(40, 22);
            lblAttn.TabIndex = 60;
            lblAttn.Text = "ATTN";
            lblAttn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPostalAdd
            // 
            txtPostalAdd.Location = new Point(96, 72);
            txtPostalAdd.Name = "txtPostalAdd";
            txtPostalAdd.Size = new Size(872, 25);
            txtPostalAdd.TabIndex = 61;
            // 
            // lblPostalAdd
            // 
            lblPostalAdd.Location = new Point(8, 76);
            lblPostalAdd.Name = "lblPostalAdd";
            lblPostalAdd.Size = new Size(76, 22);
            lblPostalAdd.TabIndex = 62;
            lblPostalAdd.Text = "Postal Add";
            lblPostalAdd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMachine
            // 
            txtMachine.BackColor = Color.WhiteSmoke;
            txtMachine.Location = new Point(404, 40);
            txtMachine.Name = "txtMachine";
            txtMachine.ReadOnly = true;
            txtMachine.Size = new Size(1238, 25);
            txtMachine.TabIndex = 63;
            // 
            // lblMachine
            // 
            lblMachine.Location = new Point(276, 40);
            lblMachine.Name = "lblMachine";
            lblMachine.Size = new Size(124, 22);
            lblMachine.TabIndex = 64;
            lblMachine.Text = "Machine";
            lblMachine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.WhiteSmoke;
            txtModel.Location = new Point(96, 40);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(174, 25);
            txtModel.TabIndex = 65;
            // 
            // lblModel
            // 
            lblModel.Location = new Point(8, 44);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(60, 22);
            lblModel.TabIndex = 66;
            lblModel.Text = "Model";
            lblModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConsignee
            // 
            txtConsignee.Location = new Point(928, 8);
            txtConsignee.Name = "txtConsignee";
            txtConsignee.Size = new Size(714, 25);
            txtConsignee.TabIndex = 67;
            // 
            // lblConsignee
            // 
            lblConsignee.Location = new Point(828, 8);
            lblConsignee.Name = "lblConsignee";
            lblConsignee.Size = new Size(90, 22);
            lblConsignee.TabIndex = 68;
            lblConsignee.Text = "Consignee";
            lblConsignee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClient
            // 
            txtClient.BackColor = Color.WhiteSmoke;
            txtClient.Location = new Point(700, 8);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(120, 25);
            txtClient.TabIndex = 69;
            // 
            // lblClient
            // 
            lblClient.Location = new Point(632, 12);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(56, 22);
            lblClient.TabIndex = 70;
            lblClient.Text = "Client";
            lblClient.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboSerialNo
            // 
            cboSerialNo.Location = new Point(480, 8);
            cboSerialNo.Name = "cboSerialNo";
            cboSerialNo.Size = new Size(142, 26);
            cboSerialNo.TabIndex = 71;
            cboSerialNo.SelectedIndexChanged += cboSerialNo_SelectedIndexChanged;
            // 
            // lbl序號
            // 
            lbl序號.Location = new Point(390, 12);
            lbl序號.Name = "lbl序號";
            lbl序號.Size = new Size(98, 22);
            lbl序號.TabIndex = 72;
            lbl序號.Text = "Serial No.";
            lbl序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFormNo
            // 
            txtFormNo.BackColor = Color.WhiteSmoke;
            txtFormNo.Location = new Point(250, 8);
            txtFormNo.Name = "txtFormNo";
            txtFormNo.ReadOnly = true;
            txtFormNo.Size = new Size(130, 25);
            txtFormNo.TabIndex = 73;
            // 
            // lbl單號
            // 
            lbl單號.Location = new Point(190, 12);
            lbl單號.Name = "lbl單號";
            lbl單號.Size = new Size(56, 22);
            lbl單號.TabIndex = 74;
            lbl單號.Text = "D/O No";
            lbl單號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(62, 8);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(120, 25);
            dtDate.TabIndex = 75;
            // 
            // lbl日期
            // 
            lbl日期.Location = new Point(8, 12);
            lbl日期.Name = "lbl日期";
            lbl日期.Size = new Size(50, 22);
            lbl日期.TabIndex = 76;
            lbl日期.Text = "DATE";
            lbl日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(230, 230, 250);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(lblCreatorLbl);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(lblModifierLbl);
            panelFooter.Controls.Add(txtApproveDate);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(lblApproverLbl);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 900);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1654, 32);
            panelFooter.TabIndex = 3;
            // 
            // txtCreateDate
            // 
            txtCreateDate.BackColor = Color.WhiteSmoke;
            txtCreateDate.Location = new Point(716, 4);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(100, 25);
            txtCreateDate.TabIndex = 0;
            // 
            // txtCreator
            // 
            txtCreator.BackColor = Color.WhiteSmoke;
            txtCreator.Location = new Point(592, 4);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(120, 25);
            txtCreator.TabIndex = 1;
            // 
            // lblCreatorLbl
            // 
            lblCreatorLbl.Location = new Point(552, 6);
            lblCreatorLbl.Name = "lblCreatorLbl";
            lblCreatorLbl.Size = new Size(36, 22);
            lblCreatorLbl.TabIndex = 2;
            lblCreatorLbl.Text = "建檔";
            lblCreatorLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtModifyDate
            // 
            txtModifyDate.BackColor = Color.WhiteSmoke;
            txtModifyDate.Location = new Point(444, 4);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(100, 25);
            txtModifyDate.TabIndex = 3;
            // 
            // txtModifier
            // 
            txtModifier.BackColor = Color.WhiteSmoke;
            txtModifier.Location = new Point(320, 4);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(120, 25);
            txtModifier.TabIndex = 4;
            // 
            // lblModifierLbl
            // 
            lblModifierLbl.Location = new Point(280, 6);
            lblModifierLbl.Name = "lblModifierLbl";
            lblModifierLbl.Size = new Size(36, 22);
            lblModifierLbl.TabIndex = 5;
            lblModifierLbl.Text = "修改";
            lblModifierLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtApproveDate
            // 
            txtApproveDate.BackColor = Color.WhiteSmoke;
            txtApproveDate.Location = new Point(172, 4);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(100, 25);
            txtApproveDate.TabIndex = 6;
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.WhiteSmoke;
            txtApprover.Location = new Point(48, 4);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(120, 25);
            txtApprover.TabIndex = 7;
            // 
            // lblApproverLbl
            // 
            lblApproverLbl.Location = new Point(8, 6);
            lblApproverLbl.Name = "lblApproverLbl";
            lblApproverLbl.Size = new Size(36, 22);
            lblApproverLbl.TabIndex = 8;
            lblApproverLbl.Text = "核准";
            lblApproverLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(splitContainer1);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 492);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1654, 408);
            panelDetail.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvBox);
            splitContainer1.Panel1.Controls.Add(panelBoxTotal);
            splitContainer1.Panel1.Controls.Add(lblBoxTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvPayment);
            splitContainer1.Panel2.Controls.Add(panelPaymentTotal);
            splitContainer1.Panel2.Controls.Add(lblPaymentTitle);
            splitContainer1.Size = new Size(1654, 408);
            splitContainer1.SplitterDistance = 240;
            splitContainer1.TabIndex = 0;
            // 
            // dgvBox
            // 
            dgvBox.AllowUserToDeleteRows = false;
            dgvBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBox.Columns.AddRange(new DataGridViewColumn[] { colDesc, colQTY, colUnit, colDollar1, colUnitPrice, colDollar2, colAmount, colNW, colGW, colDim, colHS });
            dgvBox.Dock = DockStyle.Fill;
            dgvBox.Location = new Point(0, 22);
            dgvBox.Name = "dgvBox";
            dgvBox.RowHeadersVisible = false;
            dgvBox.Size = new Size(1654, 190);
            dgvBox.TabIndex = 1;
            dgvBox.CellValueChanged += dgvBox_CellValueChanged;
            dgvBox.DataError += dgvBox_DataError;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            // 
            // colQTY
            // 
            colQTY.FillWeight = 60F;
            colQTY.HeaderText = "QTY";
            colQTY.Name = "colQTY";
            // 
            // colUnit
            // 
            colUnit.FillWeight = 60F;
            colUnit.HeaderText = "Unit";
            colUnit.Name = "colUnit";
            // 
            // colDollar1
            // 
            colDollar1.FillWeight = 60F;
            colDollar1.HeaderText = "Cy";
            colDollar1.Name = "colDollar1";
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            // 
            // colDollar2
            // 
            colDollar2.FillWeight = 60F;
            colDollar2.HeaderText = "Cy";
            colDollar2.Name = "colDollar2";
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colNW
            // 
            colNW.FillWeight = 80F;
            colNW.HeaderText = "NW (kgs)";
            colNW.Name = "colNW";
            // 
            // colGW
            // 
            colGW.FillWeight = 80F;
            colGW.HeaderText = "GW (kgs)";
            colGW.Name = "colGW";
            // 
            // colDim
            // 
            colDim.FillWeight = 130F;
            colDim.HeaderText = "Dimension (cm)";
            colDim.Name = "colDim";
            // 
            // colHS
            // 
            colHS.HeaderText = "HS Code";
            colHS.Name = "colHS";
            // 
            // panelBoxTotal
            // 
            panelBoxTotal.BackColor = Color.LightYellow;
            panelBoxTotal.Controls.Add(txtBoxTotalGW);
            panelBoxTotal.Controls.Add(lblBoxGWLbl);
            panelBoxTotal.Controls.Add(txtBoxTotalNW);
            panelBoxTotal.Controls.Add(lblBoxNWLbl);
            panelBoxTotal.Controls.Add(txtBoxTotalAmount);
            panelBoxTotal.Controls.Add(lblBoxAmountLbl);
            panelBoxTotal.Controls.Add(lblBoxTotalHeader);
            panelBoxTotal.Dock = DockStyle.Bottom;
            panelBoxTotal.Location = new Point(0, 212);
            panelBoxTotal.Name = "panelBoxTotal";
            panelBoxTotal.Size = new Size(1654, 28);
            panelBoxTotal.TabIndex = 3;
            // 
            // txtBoxTotalGW
            // 
            txtBoxTotalGW.BackColor = Color.LightYellow;
            txtBoxTotalGW.Location = new Point(656, 2);
            txtBoxTotalGW.Name = "txtBoxTotalGW";
            txtBoxTotalGW.ReadOnly = true;
            txtBoxTotalGW.Size = new Size(140, 25);
            txtBoxTotalGW.TabIndex = 2;
            txtBoxTotalGW.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBoxGWLbl
            // 
            lblBoxGWLbl.Location = new Point(572, 4);
            lblBoxGWLbl.Name = "lblBoxGWLbl";
            lblBoxGWLbl.Size = new Size(80, 22);
            lblBoxGWLbl.TabIndex = 3;
            lblBoxGWLbl.Text = "GW (kgs):";
            lblBoxGWLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxTotalNW
            // 
            txtBoxTotalNW.BackColor = Color.LightYellow;
            txtBoxTotalNW.Location = new Point(420, 2);
            txtBoxTotalNW.Name = "txtBoxTotalNW";
            txtBoxTotalNW.ReadOnly = true;
            txtBoxTotalNW.Size = new Size(140, 25);
            txtBoxTotalNW.TabIndex = 1;
            txtBoxTotalNW.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBoxNWLbl
            // 
            lblBoxNWLbl.Location = new Point(336, 4);
            lblBoxNWLbl.Name = "lblBoxNWLbl";
            lblBoxNWLbl.Size = new Size(80, 22);
            lblBoxNWLbl.TabIndex = 4;
            lblBoxNWLbl.Text = "NW (kgs):";
            lblBoxNWLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxTotalAmount
            // 
            txtBoxTotalAmount.BackColor = Color.LightYellow;
            txtBoxTotalAmount.Location = new Point(184, 2);
            txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            txtBoxTotalAmount.ReadOnly = true;
            txtBoxTotalAmount.Size = new Size(140, 25);
            txtBoxTotalAmount.TabIndex = 0;
            txtBoxTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBoxAmountLbl
            // 
            lblBoxAmountLbl.Location = new Point(100, 4);
            lblBoxAmountLbl.Name = "lblBoxAmountLbl";
            lblBoxAmountLbl.Size = new Size(80, 22);
            lblBoxAmountLbl.TabIndex = 5;
            lblBoxAmountLbl.Text = "Amount:";
            lblBoxAmountLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxTotalHeader
            // 
            lblBoxTotalHeader.Font = new Font("Microsoft JhengHei UI", 10.5F, FontStyle.Bold);
            lblBoxTotalHeader.Location = new Point(8, 4);
            lblBoxTotalHeader.Name = "lblBoxTotalHeader";
            lblBoxTotalHeader.Size = new Size(80, 22);
            lblBoxTotalHeader.TabIndex = 6;
            lblBoxTotalHeader.Text = "TOTAL";
            lblBoxTotalHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxTitle
            // 
            lblBoxTitle.BackColor = Color.FromArgb(180, 220, 255);
            lblBoxTitle.Dock = DockStyle.Top;
            lblBoxTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lblBoxTitle.Location = new Point(0, 0);
            lblBoxTitle.Name = "lblBoxTitle";
            lblBoxTitle.Size = new Size(1654, 22);
            lblBoxTitle.TabIndex = 2;
            lblBoxTitle.Text = "專案機台裝箱明細";
            lblBoxTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvPayment
            // 
            dgvPayment.AllowUserToAddRows = false;
            dgvPayment.AllowUserToDeleteRows = false;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Columns.AddRange(new DataGridViewColumn[] { colPayDate, colPayItem, colPayType, colWriteOff, colReceived, colFee, colOtherDeduct, colDeductReason, colOperator, colReview });
            dgvPayment.Dock = DockStyle.Fill;
            dgvPayment.Location = new Point(0, 22);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.ReadOnly = true;
            dgvPayment.RowHeadersVisible = false;
            dgvPayment.Size = new Size(1654, 114);
            dgvPayment.TabIndex = 1;
            // 
            // colPayDate
            // 
            colPayDate.HeaderText = "收款日期";
            colPayDate.Name = "colPayDate";
            colPayDate.ReadOnly = true;
            // 
            // colPayItem
            // 
            colPayItem.HeaderText = "收款項目";
            colPayItem.Name = "colPayItem";
            colPayItem.ReadOnly = true;
            // 
            // colPayType
            // 
            colPayType.HeaderText = "交付形式";
            colPayType.Name = "colPayType";
            colPayType.ReadOnly = true;
            // 
            // colWriteOff
            // 
            colWriteOff.HeaderText = "沖帳金額";
            colWriteOff.Name = "colWriteOff";
            colWriteOff.ReadOnly = true;
            // 
            // colReceived
            // 
            colReceived.HeaderText = "實收金額";
            colReceived.Name = "colReceived";
            colReceived.ReadOnly = true;
            // 
            // colFee
            // 
            colFee.FillWeight = 80F;
            colFee.HeaderText = "手續費";
            colFee.Name = "colFee";
            colFee.ReadOnly = true;
            // 
            // colOtherDeduct
            // 
            colOtherDeduct.HeaderText = "其他折減額";
            colOtherDeduct.Name = "colOtherDeduct";
            colOtherDeduct.ReadOnly = true;
            // 
            // colDeductReason
            // 
            colDeductReason.FillWeight = 120F;
            colDeductReason.HeaderText = "折減科目";
            colDeductReason.Name = "colDeductReason";
            colDeductReason.ReadOnly = true;
            // 
            // colOperator
            // 
            colOperator.HeaderText = "沖帳人員";
            colOperator.Name = "colOperator";
            colOperator.ReadOnly = true;
            // 
            // colReview
            // 
            colReview.HeaderText = "業務覆核";
            colReview.Name = "colReview";
            colReview.ReadOnly = true;
            // 
            // panelPaymentTotal
            // 
            panelPaymentTotal.BackColor = Color.FromArgb(220, 255, 230);
            panelPaymentTotal.Controls.Add(txtPayTotalReceived);
            panelPaymentTotal.Controls.Add(lblPayReceivedLbl);
            panelPaymentTotal.Controls.Add(txtPayTotalWriteOff);
            panelPaymentTotal.Controls.Add(lblPayWriteOffLbl);
            panelPaymentTotal.Controls.Add(lblPayTotalHeader);
            panelPaymentTotal.Dock = DockStyle.Bottom;
            panelPaymentTotal.Location = new Point(0, 136);
            panelPaymentTotal.Name = "panelPaymentTotal";
            panelPaymentTotal.Size = new Size(1654, 28);
            panelPaymentTotal.TabIndex = 3;
            // 
            // txtPayTotalReceived
            // 
            txtPayTotalReceived.BackColor = Color.FromArgb(220, 255, 230);
            txtPayTotalReceived.Location = new Point(400, 2);
            txtPayTotalReceived.Name = "txtPayTotalReceived";
            txtPayTotalReceived.ReadOnly = true;
            txtPayTotalReceived.Size = new Size(140, 25);
            txtPayTotalReceived.TabIndex = 1;
            txtPayTotalReceived.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPayReceivedLbl
            // 
            lblPayReceivedLbl.Location = new Point(316, 4);
            lblPayReceivedLbl.Name = "lblPayReceivedLbl";
            lblPayReceivedLbl.Size = new Size(80, 22);
            lblPayReceivedLbl.TabIndex = 2;
            lblPayReceivedLbl.Text = "實收金額:";
            lblPayReceivedLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPayTotalWriteOff
            // 
            txtPayTotalWriteOff.BackColor = Color.FromArgb(220, 255, 230);
            txtPayTotalWriteOff.Location = new Point(164, 2);
            txtPayTotalWriteOff.Name = "txtPayTotalWriteOff";
            txtPayTotalWriteOff.ReadOnly = true;
            txtPayTotalWriteOff.Size = new Size(140, 25);
            txtPayTotalWriteOff.TabIndex = 0;
            txtPayTotalWriteOff.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPayWriteOffLbl
            // 
            lblPayWriteOffLbl.Location = new Point(80, 4);
            lblPayWriteOffLbl.Name = "lblPayWriteOffLbl";
            lblPayWriteOffLbl.Size = new Size(80, 22);
            lblPayWriteOffLbl.TabIndex = 3;
            lblPayWriteOffLbl.Text = "沖帳金額:";
            lblPayWriteOffLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPayTotalHeader
            // 
            lblPayTotalHeader.Font = new Font("Microsoft JhengHei UI", 10.5F, FontStyle.Bold);
            lblPayTotalHeader.Location = new Point(8, 4);
            lblPayTotalHeader.Name = "lblPayTotalHeader";
            lblPayTotalHeader.Size = new Size(60, 22);
            lblPayTotalHeader.TabIndex = 4;
            lblPayTotalHeader.Text = "合計";
            lblPayTotalHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.BackColor = Color.FromArgb(180, 255, 200);
            lblPaymentTitle.Dock = DockStyle.Top;
            lblPaymentTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lblPaymentTitle.Location = new Point(0, 0);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(1654, 22);
            lblPaymentTitle.TabIndex = 2;
            lblPaymentTitle.Text = "專案應收沖款明細";
            lblPaymentTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EQPShippingMaintainControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panelDetail);
            Controls.Add(panelFooter);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "EQPShippingMaintainControl";
            Size = new Size(1654, 932);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelDetail.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBox).EndInit();
            panelBoxTotal.ResumeLayout(false);
            panelBoxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            panelPaymentTotal.ResumeLayout(false);
            panelPaymentTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── toolbar ───────────────────────────────────────────────────────
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnUpdateBox;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnCancelApprove;
        private System.Windows.Forms.Button btnBack;

        // ── form panel ────────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lbl日期;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lbl單號;
        private System.Windows.Forms.TextBox txtFormNo;
        private System.Windows.Forms.Label lbl序號;
        private System.Windows.Forms.ComboBox cboSerialNo;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblConsignee;
        private System.Windows.Forms.TextBox txtConsignee;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblPostalAdd;
        private System.Windows.Forms.TextBox txtPostalAdd;
        private System.Windows.Forms.Label lblAttn;
        private System.Windows.Forms.ComboBox cboAttn;
        private System.Windows.Forms.Label lblDeliveryAdd;
        private System.Windows.Forms.TextBox txtDeliveryAdd;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.ComboBox cboTel;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Label lblPI;
        private System.Windows.Forms.TextBox txtPINumber;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.ComboBox cboContainer;
        private System.Windows.Forms.Label lblContainerType;
        private System.Windows.Forms.TextBox txtContainerType;
        private System.Windows.Forms.Label lblDeliveryTerm;
        private System.Windows.Forms.ComboBox cboDeliveryTerm;
        private System.Windows.Forms.Label lblDestPort;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Label lblPacking;
        private System.Windows.Forms.ComboBox cboPacking;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.ComboBox cboInsurance;
        private System.Windows.Forms.Label lblContainerPort;
        private System.Windows.Forms.TextBox txtContainerPort;
        private System.Windows.Forms.Label lblCutOff;
        private System.Windows.Forms.TextBox txtCutOff;
        private System.Windows.Forms.Label lblETD;
        private System.Windows.Forms.TextBox txtETD;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.TextBox txtETA;
        private System.Windows.Forms.Label lblTypesOfBL;
        private System.Windows.Forms.ComboBox cboTypesOfBL;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label lblForwarder;
        private System.Windows.Forms.TextBox txtForwarder;
        private System.Windows.Forms.Label lblCertOfOrigin;
        private System.Windows.Forms.ComboBox cboCertOfOrigin;
        private System.Windows.Forms.Label lblSurrenderBL;
        private System.Windows.Forms.ComboBox cboSurrenderBL;
        private System.Windows.Forms.Label lblVoyage;
        private System.Windows.Forms.TextBox txtVoyage;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.ComboBox cboDoc;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.ComboBox cboMark;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.Label lblShippingMark;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblCaseNo;
        private System.Windows.Forms.TextBox txtCaseNo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbl幣別;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.Label lblReceivable;
        private System.Windows.Forms.TextBox txtReceivableTotal;
        private System.Windows.Forms.Label lblPaymentRatio;
        private System.Windows.Forms.TextBox txtPaymentRatio;
        private System.Windows.Forms.Label lblPayCode;
        private System.Windows.Forms.TextBox txtPaymentCode;
        private System.Windows.Forms.TextBox txtPaymentTerm;

        // ── footer ────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblApproverLbl;
        private System.Windows.Forms.TextBox txtApprover;
        private System.Windows.Forms.TextBox txtApproveDate;
        private System.Windows.Forms.Label lblModifierLbl;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.TextBox txtModifyDate;
        private System.Windows.Forms.Label lblCreatorLbl;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.TextBox txtCreateDate;

        // ── detail ────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblBoxTitle;
        private System.Windows.Forms.DataGridView dgvBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDollar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDollar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNW;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHS;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWriteOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherDeduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReview;

        // ── grid total footers ───────────────────────────────────────────────
        private System.Windows.Forms.Panel panelBoxTotal;
        private System.Windows.Forms.Label lblBoxTotalHeader;
        private System.Windows.Forms.Label lblBoxAmountLbl;
        private System.Windows.Forms.TextBox txtBoxTotalAmount;
        private System.Windows.Forms.Label lblBoxNWLbl;
        private System.Windows.Forms.TextBox txtBoxTotalNW;
        private System.Windows.Forms.Label lblBoxGWLbl;
        private System.Windows.Forms.TextBox txtBoxTotalGW;
        private System.Windows.Forms.Panel panelPaymentTotal;
        private System.Windows.Forms.Label lblPayTotalHeader;
        private System.Windows.Forms.Label lblPayWriteOffLbl;
        private System.Windows.Forms.TextBox txtPayTotalWriteOff;
        private System.Windows.Forms.Label lblPayReceivedLbl;
        private System.Windows.Forms.TextBox txtPayTotalReceived;
    }
}
