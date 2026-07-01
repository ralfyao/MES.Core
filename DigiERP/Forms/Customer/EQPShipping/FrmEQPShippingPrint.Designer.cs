using DigiERP.Forms.Customer.Quotation;

namespace DigiERP.Forms.Customer.EQPShipping
{
    partial class FrmEQPShippingPrint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEQPShippingPrint));
            btnPrint = new Button();
            lblTitle = new Label();
            lblDate = new Label();
            txtDate = new TextBox();
            lblDONo = new Label();
            txtDONo = new TextBox();
            lblSerialNo = new Label();
            txtSerialNo = new TextBox();
            lblConsignee = new Label();
            txtConsignee = new TextBox();
            lblPostalAdd = new Label();
            txtPostalAdd = new TextBox();
            lblDeliveryAdd = new Label();
            txtDeliveryAdd = new TextBox();
            lblAttn = new Label();
            txtAttn = new TextBox();
            lblPO = new Label();
            txtPONumber = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();
            lblPI = new Label();
            txtPINumber = new TextBox();
            lblContainer = new Label();
            txtContainer = new TextBox();
            lblContainerType = new Label();
            txtContainerType = new TextBox();
            lblDeliveryTerm = new Label();
            txtDeliveryTerm = new TextBox();
            lblContainerPort = new Label();
            txtContainerPort = new TextBox();
            lblDestPort = new Label();
            txtDestPort = new TextBox();
            lblInsurance = new Label();
            txtInsurance = new TextBox();
            lblPacking = new Label();
            txtPacking = new TextBox();
            lblETD = new Label();
            txtETD = new TextBox();
            lblETA = new Label();
            txtETA = new TextBox();
            lblCutOff = new Label();
            txtCutOff = new TextBox();
            lblCertOfOrigin = new Label();
            txtCertOfOrigin = new TextBox();
            lblTypesOfBL = new Label();
            txtTypesOfBL = new TextBox();
            lblSurrenderBL = new Label();
            txtSurrenderBL = new TextBox();
            lblForwarder = new Label();
            txtForwarder = new TextBox();
            lblShipName = new Label();
            txtShipName = new TextBox();
            lblDoc = new Label();
            txtDoc = new TextBox();
            lblVoyage = new Label();
            txtVoyage = new TextBox();
            lblBrandMark = new Label();
            txtMark = new TextBox();
            lblSpecify = new Label();
            dgvItems = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colQTY = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colCy1 = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colCy2 = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colNW = new DataGridViewTextBoxColumn();
            colGW = new DataGridViewTextBoxColumn();
            colDim = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            lblTotalAmtLbl = new Label();
            txtTotalAmount = new TextBox();
            lblTotalNWLbl = new Label();
            txtTotalNW = new TextBox();
            lblTotalGWLbl = new Label();
            txtTotalGW = new TextBox();
            panelShipMark = new Panel();
            lblShipMarkTitle = new Label();
            txtShipMarkContent = new TextBox();
            panelSignature = new Panel();
            txtCaseNo = new TextBox();
            lblTotalRight = new Label();
            txtTotal = new TextBox();
            lblPackingRight = new Label();
            txtPackingRight = new TextBox();
            lblConfirm = new Label();
            lblSigLine = new Label();
            lblFooter1 = new Label();
            lblFooter2 = new Label();
            lblFooter3 = new Label();
            pictureBox1 = new PictureBox();
            btnPreviewPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelShipMark.SuspendLayout();
            panelSignature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.DarkOrange;
            btnPrint.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(880, 26);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 48);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "預覽列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 104);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1050, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "DELIVERY ORDER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.White;
            lblDate.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDate.Location = new Point(0, 148);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 28);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.ButtonHighlight;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Location = new Point(56, 148);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(208, 17);
            txtDate.TabIndex = 4;
            // 
            // lblDONo
            // 
            lblDONo.BackColor = Color.White;
            lblDONo.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDONo.Location = new Point(272, 148);
            lblDONo.Name = "lblDONo";
            lblDONo.Size = new Size(70, 28);
            lblDONo.TabIndex = 5;
            lblDONo.Text = "D/O No.";
            lblDONo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDONo
            // 
            txtDONo.BackColor = SystemColors.ButtonHighlight;
            txtDONo.BorderStyle = BorderStyle.None;
            txtDONo.Location = new Point(352, 148);
            txtDONo.Name = "txtDONo";
            txtDONo.ReadOnly = true;
            txtDONo.Size = new Size(224, 17);
            txtDONo.TabIndex = 6;
            // 
            // lblSerialNo
            // 
            lblSerialNo.BackColor = Color.White;
            lblSerialNo.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblSerialNo.Location = new Point(588, 148);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(80, 28);
            lblSerialNo.TabIndex = 7;
            lblSerialNo.Text = "Serial No.";
            lblSerialNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSerialNo
            // 
            txtSerialNo.BackColor = SystemColors.ButtonHighlight;
            txtSerialNo.BorderStyle = BorderStyle.None;
            txtSerialNo.Location = new Point(680, 148);
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.ReadOnly = true;
            txtSerialNo.Size = new Size(360, 17);
            txtSerialNo.TabIndex = 8;
            // 
            // lblConsignee
            // 
            lblConsignee.BackColor = Color.White;
            lblConsignee.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblConsignee.Location = new Point(0, 180);
            lblConsignee.Name = "lblConsignee";
            lblConsignee.Size = new Size(156, 28);
            lblConsignee.TabIndex = 9;
            lblConsignee.Text = "Consignee";
            lblConsignee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConsignee
            // 
            txtConsignee.BackColor = SystemColors.ButtonHighlight;
            txtConsignee.BorderStyle = BorderStyle.None;
            txtConsignee.Location = new Point(164, 180);
            txtConsignee.Name = "txtConsignee";
            txtConsignee.ReadOnly = true;
            txtConsignee.Size = new Size(876, 17);
            txtConsignee.TabIndex = 10;
            // 
            // lblPostalAdd
            // 
            lblPostalAdd.BackColor = Color.White;
            lblPostalAdd.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblPostalAdd.Location = new Point(0, 212);
            lblPostalAdd.Name = "lblPostalAdd";
            lblPostalAdd.Size = new Size(156, 28);
            lblPostalAdd.TabIndex = 11;
            lblPostalAdd.Text = "Postal Add";
            lblPostalAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPostalAdd
            // 
            txtPostalAdd.BackColor = SystemColors.ButtonHighlight;
            txtPostalAdd.BorderStyle = BorderStyle.None;
            txtPostalAdd.Location = new Point(164, 212);
            txtPostalAdd.Name = "txtPostalAdd";
            txtPostalAdd.ReadOnly = true;
            txtPostalAdd.Size = new Size(876, 17);
            txtPostalAdd.TabIndex = 12;
            // 
            // lblDeliveryAdd
            // 
            lblDeliveryAdd.BackColor = Color.White;
            lblDeliveryAdd.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDeliveryAdd.Location = new Point(0, 244);
            lblDeliveryAdd.Name = "lblDeliveryAdd";
            lblDeliveryAdd.Size = new Size(156, 28);
            lblDeliveryAdd.TabIndex = 13;
            lblDeliveryAdd.Text = "Delivery Add";
            lblDeliveryAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDeliveryAdd
            // 
            txtDeliveryAdd.BackColor = SystemColors.ButtonHighlight;
            txtDeliveryAdd.BorderStyle = BorderStyle.None;
            txtDeliveryAdd.Location = new Point(164, 244);
            txtDeliveryAdd.Name = "txtDeliveryAdd";
            txtDeliveryAdd.ReadOnly = true;
            txtDeliveryAdd.Size = new Size(876, 17);
            txtDeliveryAdd.TabIndex = 14;
            // 
            // lblAttn
            // 
            lblAttn.BackColor = Color.White;
            lblAttn.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblAttn.Location = new Point(0, 276);
            lblAttn.Name = "lblAttn";
            lblAttn.Size = new Size(156, 28);
            lblAttn.TabIndex = 15;
            lblAttn.Text = "Attn.";
            lblAttn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAttn
            // 
            txtAttn.BackColor = SystemColors.ButtonHighlight;
            txtAttn.BorderStyle = BorderStyle.None;
            txtAttn.Location = new Point(164, 276);
            txtAttn.Name = "txtAttn";
            txtAttn.ReadOnly = true;
            txtAttn.Size = new Size(356, 17);
            txtAttn.TabIndex = 16;
            // 
            // lblPO
            // 
            lblPO.BackColor = Color.White;
            lblPO.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblPO.Location = new Point(528, 275);
            lblPO.Name = "lblPO";
            lblPO.Size = new Size(100, 28);
            lblPO.TabIndex = 17;
            lblPO.Text = "P/O Number";
            lblPO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPONumber
            // 
            txtPONumber.BackColor = SystemColors.ButtonHighlight;
            txtPONumber.BorderStyle = BorderStyle.None;
            txtPONumber.Location = new Point(636, 276);
            txtPONumber.Name = "txtPONumber";
            txtPONumber.ReadOnly = true;
            txtPONumber.Size = new Size(404, 17);
            txtPONumber.TabIndex = 18;
            // 
            // lblTel
            // 
            lblTel.BackColor = Color.White;
            lblTel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTel.Location = new Point(0, 308);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(156, 28);
            lblTel.TabIndex = 19;
            lblTel.Text = "Tel";
            lblTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTel
            // 
            txtTel.BackColor = SystemColors.ButtonHighlight;
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.Location = new Point(164, 308);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(356, 17);
            txtTel.TabIndex = 20;
            // 
            // lblPI
            // 
            lblPI.BackColor = Color.White;
            lblPI.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblPI.Location = new Point(528, 307);
            lblPI.Name = "lblPI";
            lblPI.Size = new Size(96, 28);
            lblPI.TabIndex = 21;
            lblPI.Text = "P/I Number";
            lblPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPINumber
            // 
            txtPINumber.BackColor = SystemColors.ButtonHighlight;
            txtPINumber.BorderStyle = BorderStyle.None;
            txtPINumber.Location = new Point(632, 308);
            txtPINumber.Name = "txtPINumber";
            txtPINumber.ReadOnly = true;
            txtPINumber.Size = new Size(408, 17);
            txtPINumber.TabIndex = 22;
            // 
            // lblContainer
            // 
            lblContainer.BackColor = Color.White;
            lblContainer.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblContainer.Location = new Point(0, 340);
            lblContainer.Name = "lblContainer";
            lblContainer.Size = new Size(160, 28);
            lblContainer.TabIndex = 23;
            lblContainer.Text = "Container";
            lblContainer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContainer
            // 
            txtContainer.BackColor = SystemColors.ButtonHighlight;
            txtContainer.BorderStyle = BorderStyle.None;
            txtContainer.Location = new Point(168, 340);
            txtContainer.Name = "txtContainer";
            txtContainer.ReadOnly = true;
            txtContainer.Size = new Size(352, 17);
            txtContainer.TabIndex = 24;
            // 
            // lblContainerType
            // 
            lblContainerType.BackColor = Color.White;
            lblContainerType.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblContainerType.Location = new Point(528, 340);
            lblContainerType.Name = "lblContainerType";
            lblContainerType.Size = new Size(104, 28);
            lblContainerType.TabIndex = 25;
            lblContainerType.Text = "Container Type";
            lblContainerType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContainerType
            // 
            txtContainerType.BackColor = SystemColors.ButtonHighlight;
            txtContainerType.BorderStyle = BorderStyle.None;
            txtContainerType.Location = new Point(636, 340);
            txtContainerType.Name = "txtContainerType";
            txtContainerType.ReadOnly = true;
            txtContainerType.Size = new Size(406, 17);
            txtContainerType.TabIndex = 26;
            // 
            // lblDeliveryTerm
            // 
            lblDeliveryTerm.BackColor = Color.White;
            lblDeliveryTerm.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDeliveryTerm.Location = new Point(0, 372);
            lblDeliveryTerm.Name = "lblDeliveryTerm";
            lblDeliveryTerm.Size = new Size(132, 28);
            lblDeliveryTerm.TabIndex = 27;
            lblDeliveryTerm.Text = "Delivery Term";
            lblDeliveryTerm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDeliveryTerm
            // 
            txtDeliveryTerm.BackColor = SystemColors.ButtonHighlight;
            txtDeliveryTerm.BorderStyle = BorderStyle.None;
            txtDeliveryTerm.Location = new Point(140, 372);
            txtDeliveryTerm.Name = "txtDeliveryTerm";
            txtDeliveryTerm.ReadOnly = true;
            txtDeliveryTerm.Size = new Size(176, 17);
            txtDeliveryTerm.TabIndex = 28;
            // 
            // lblContainerPort
            // 
            lblContainerPort.BackColor = Color.White;
            lblContainerPort.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblContainerPort.Location = new Point(328, 368);
            lblContainerPort.Name = "lblContainerPort";
            lblContainerPort.Size = new Size(110, 28);
            lblContainerPort.TabIndex = 29;
            lblContainerPort.Text = "Container Port";
            lblContainerPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContainerPort
            // 
            txtContainerPort.BackColor = SystemColors.ButtonHighlight;
            txtContainerPort.BorderStyle = BorderStyle.None;
            txtContainerPort.Location = new Point(444, 372);
            txtContainerPort.Name = "txtContainerPort";
            txtContainerPort.ReadOnly = true;
            txtContainerPort.Size = new Size(180, 17);
            txtContainerPort.TabIndex = 30;
            // 
            // lblDestPort
            // 
            lblDestPort.BackColor = Color.White;
            lblDestPort.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDestPort.Location = new Point(636, 370);
            lblDestPort.Name = "lblDestPort";
            lblDestPort.Size = new Size(120, 28);
            lblDestPort.TabIndex = 31;
            lblDestPort.Text = "Destination Port";
            lblDestPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDestPort
            // 
            txtDestPort.BackColor = SystemColors.ButtonHighlight;
            txtDestPort.BorderStyle = BorderStyle.None;
            txtDestPort.Location = new Point(768, 372);
            txtDestPort.Name = "txtDestPort";
            txtDestPort.ReadOnly = true;
            txtDestPort.Size = new Size(276, 17);
            txtDestPort.TabIndex = 32;
            // 
            // lblInsurance
            // 
            lblInsurance.BackColor = Color.White;
            lblInsurance.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblInsurance.Location = new Point(0, 404);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(160, 28);
            lblInsurance.TabIndex = 33;
            lblInsurance.Text = "Insurance";
            lblInsurance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInsurance
            // 
            txtInsurance.BackColor = SystemColors.ButtonHighlight;
            txtInsurance.BorderStyle = BorderStyle.None;
            txtInsurance.Location = new Point(168, 404);
            txtInsurance.Name = "txtInsurance";
            txtInsurance.ReadOnly = true;
            txtInsurance.Size = new Size(348, 17);
            txtInsurance.TabIndex = 34;
            // 
            // lblPacking
            // 
            lblPacking.BackColor = Color.White;
            lblPacking.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblPacking.Location = new Point(528, 404);
            lblPacking.Name = "lblPacking";
            lblPacking.Size = new Size(100, 28);
            lblPacking.TabIndex = 35;
            lblPacking.Text = "Packing";
            lblPacking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPacking
            // 
            txtPacking.BackColor = SystemColors.ButtonHighlight;
            txtPacking.BorderStyle = BorderStyle.None;
            txtPacking.Location = new Point(636, 404);
            txtPacking.Name = "txtPacking";
            txtPacking.ReadOnly = true;
            txtPacking.Size = new Size(404, 17);
            txtPacking.TabIndex = 36;
            // 
            // lblETD
            // 
            lblETD.BackColor = Color.White;
            lblETD.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblETD.Location = new Point(0, 436);
            lblETD.Name = "lblETD";
            lblETD.Size = new Size(160, 28);
            lblETD.TabIndex = 37;
            lblETD.Text = "ETD";
            lblETD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtETD
            // 
            txtETD.BackColor = SystemColors.ButtonHighlight;
            txtETD.BorderStyle = BorderStyle.None;
            txtETD.Location = new Point(168, 436);
            txtETD.Name = "txtETD";
            txtETD.ReadOnly = true;
            txtETD.Size = new Size(348, 17);
            txtETD.TabIndex = 38;
            // 
            // lblETA
            // 
            lblETA.BackColor = Color.White;
            lblETA.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblETA.Location = new Point(528, 434);
            lblETA.Name = "lblETA";
            lblETA.Size = new Size(100, 28);
            lblETA.TabIndex = 39;
            lblETA.Text = "ETA";
            lblETA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtETA
            // 
            txtETA.BackColor = SystemColors.ButtonHighlight;
            txtETA.BorderStyle = BorderStyle.None;
            txtETA.Location = new Point(636, 436);
            txtETA.Name = "txtETA";
            txtETA.ReadOnly = true;
            txtETA.Size = new Size(404, 17);
            txtETA.TabIndex = 40;
            // 
            // lblCutOff
            // 
            lblCutOff.BackColor = Color.White;
            lblCutOff.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblCutOff.Location = new Point(0, 468);
            lblCutOff.Name = "lblCutOff";
            lblCutOff.Size = new Size(160, 28);
            lblCutOff.TabIndex = 41;
            lblCutOff.Text = "Cut Off Date";
            lblCutOff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCutOff
            // 
            txtCutOff.BackColor = SystemColors.ButtonHighlight;
            txtCutOff.BorderStyle = BorderStyle.None;
            txtCutOff.Location = new Point(168, 468);
            txtCutOff.Name = "txtCutOff";
            txtCutOff.ReadOnly = true;
            txtCutOff.Size = new Size(348, 17);
            txtCutOff.TabIndex = 42;
            // 
            // lblCertOfOrigin
            // 
            lblCertOfOrigin.BackColor = Color.White;
            lblCertOfOrigin.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblCertOfOrigin.Location = new Point(528, 468);
            lblCertOfOrigin.Name = "lblCertOfOrigin";
            lblCertOfOrigin.Size = new Size(100, 28);
            lblCertOfOrigin.TabIndex = 43;
            lblCertOfOrigin.Text = "Cert Of Origin";
            lblCertOfOrigin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCertOfOrigin
            // 
            txtCertOfOrigin.BackColor = SystemColors.ButtonHighlight;
            txtCertOfOrigin.BorderStyle = BorderStyle.None;
            txtCertOfOrigin.Location = new Point(636, 468);
            txtCertOfOrigin.Name = "txtCertOfOrigin";
            txtCertOfOrigin.ReadOnly = true;
            txtCertOfOrigin.Size = new Size(404, 17);
            txtCertOfOrigin.TabIndex = 44;
            // 
            // lblTypesOfBL
            // 
            lblTypesOfBL.BackColor = Color.White;
            lblTypesOfBL.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTypesOfBL.Location = new Point(0, 500);
            lblTypesOfBL.Name = "lblTypesOfBL";
            lblTypesOfBL.Size = new Size(160, 28);
            lblTypesOfBL.TabIndex = 45;
            lblTypesOfBL.Text = "Types of B/L";
            lblTypesOfBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTypesOfBL
            // 
            txtTypesOfBL.BackColor = SystemColors.ButtonHighlight;
            txtTypesOfBL.BorderStyle = BorderStyle.None;
            txtTypesOfBL.Location = new Point(168, 500);
            txtTypesOfBL.Name = "txtTypesOfBL";
            txtTypesOfBL.ReadOnly = true;
            txtTypesOfBL.Size = new Size(348, 17);
            txtTypesOfBL.TabIndex = 46;
            // 
            // lblSurrenderBL
            // 
            lblSurrenderBL.BackColor = Color.White;
            lblSurrenderBL.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblSurrenderBL.Location = new Point(528, 499);
            lblSurrenderBL.Name = "lblSurrenderBL";
            lblSurrenderBL.Size = new Size(100, 28);
            lblSurrenderBL.TabIndex = 47;
            lblSurrenderBL.Text = "Surrender B/L";
            lblSurrenderBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSurrenderBL
            // 
            txtSurrenderBL.BackColor = SystemColors.ButtonHighlight;
            txtSurrenderBL.BorderStyle = BorderStyle.None;
            txtSurrenderBL.Location = new Point(636, 500);
            txtSurrenderBL.Name = "txtSurrenderBL";
            txtSurrenderBL.ReadOnly = true;
            txtSurrenderBL.Size = new Size(404, 17);
            txtSurrenderBL.TabIndex = 48;
            // 
            // lblForwarder
            // 
            lblForwarder.BackColor = Color.White;
            lblForwarder.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblForwarder.Location = new Point(0, 532);
            lblForwarder.Name = "lblForwarder";
            lblForwarder.Size = new Size(160, 28);
            lblForwarder.TabIndex = 49;
            lblForwarder.Text = "Forwarder";
            lblForwarder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtForwarder
            // 
            txtForwarder.BackColor = SystemColors.ButtonHighlight;
            txtForwarder.BorderStyle = BorderStyle.None;
            txtForwarder.Location = new Point(168, 532);
            txtForwarder.Name = "txtForwarder";
            txtForwarder.ReadOnly = true;
            txtForwarder.Size = new Size(348, 17);
            txtForwarder.TabIndex = 50;
            // 
            // lblShipName
            // 
            lblShipName.BackColor = Color.White;
            lblShipName.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblShipName.Location = new Point(528, 532);
            lblShipName.Name = "lblShipName";
            lblShipName.Size = new Size(100, 28);
            lblShipName.TabIndex = 51;
            lblShipName.Text = "Ship Name";
            lblShipName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtShipName
            // 
            txtShipName.BackColor = SystemColors.ButtonHighlight;
            txtShipName.BorderStyle = BorderStyle.None;
            txtShipName.Location = new Point(636, 532);
            txtShipName.Name = "txtShipName";
            txtShipName.ReadOnly = true;
            txtShipName.Size = new Size(404, 17);
            txtShipName.TabIndex = 52;
            // 
            // lblDoc
            // 
            lblDoc.BackColor = Color.White;
            lblDoc.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblDoc.Location = new Point(0, 564);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(160, 28);
            lblDoc.TabIndex = 53;
            lblDoc.Text = "Doc with Consignment:";
            lblDoc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDoc
            // 
            txtDoc.BackColor = SystemColors.ButtonHighlight;
            txtDoc.BorderStyle = BorderStyle.None;
            txtDoc.Location = new Point(168, 564);
            txtDoc.Name = "txtDoc";
            txtDoc.ReadOnly = true;
            txtDoc.Size = new Size(348, 17);
            txtDoc.TabIndex = 54;
            // 
            // lblVoyage
            // 
            lblVoyage.BackColor = Color.White;
            lblVoyage.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblVoyage.Location = new Point(528, 564);
            lblVoyage.Name = "lblVoyage";
            lblVoyage.Size = new Size(100, 28);
            lblVoyage.TabIndex = 55;
            lblVoyage.Text = "Voyage & No.";
            lblVoyage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVoyage
            // 
            txtVoyage.BackColor = SystemColors.ButtonHighlight;
            txtVoyage.BorderStyle = BorderStyle.None;
            txtVoyage.Location = new Point(636, 564);
            txtVoyage.Name = "txtVoyage";
            txtVoyage.ReadOnly = true;
            txtVoyage.Size = new Size(404, 17);
            txtVoyage.TabIndex = 56;
            // 
            // lblBrandMark
            // 
            lblBrandMark.BackColor = Color.White;
            lblBrandMark.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblBrandMark.Location = new Point(0, 596);
            lblBrandMark.Name = "lblBrandMark";
            lblBrandMark.Size = new Size(160, 28);
            lblBrandMark.TabIndex = 57;
            lblBrandMark.Text = "Brand or Trade mark:";
            lblBrandMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMark
            // 
            txtMark.BackColor = SystemColors.ButtonHighlight;
            txtMark.BorderStyle = BorderStyle.None;
            txtMark.Location = new Point(168, 596);
            txtMark.Name = "txtMark";
            txtMark.ReadOnly = true;
            txtMark.Size = new Size(872, 17);
            txtMark.TabIndex = 58;
            // 
            // lblSpecify
            // 
            lblSpecify.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblSpecify.Location = new Point(160, 596);
            lblSpecify.Name = "lblSpecify";
            lblSpecify.Size = new Size(0, 0);
            lblSpecify.TabIndex = 0;
            lblSpecify.Visible = false;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colNo, colDesc, colQTY, colUnit, colCy1, colUnitPrice, colCy2, colAmount, colNW, colGW, colDim, colHS });
            dgvItems.Location = new Point(0, 628);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(1050, 200);
            dgvItems.TabIndex = 2;
            // 
            // colNo
            // 
            colNo.FillWeight = 30F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 190F;
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colQTY
            // 
            colQTY.FillWeight = 50F;
            colQTY.HeaderText = "QTY";
            colQTY.Name = "colQTY";
            colQTY.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.FillWeight = 50F;
            colUnit.HeaderText = "Unit";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colCy1
            // 
            colCy1.FillWeight = 40F;
            colCy1.HeaderText = "Cy";
            colCy1.Name = "colCy1";
            colCy1.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.FillWeight = 80F;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colCy2
            // 
            colCy2.FillWeight = 40F;
            colCy2.HeaderText = "Cy";
            colCy2.Name = "colCy2";
            colCy2.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 80F;
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colNW
            // 
            colNW.FillWeight = 70F;
            colNW.HeaderText = "NW (kgs)";
            colNW.Name = "colNW";
            colNW.ReadOnly = true;
            // 
            // colGW
            // 
            colGW.FillWeight = 70F;
            colGW.HeaderText = "GW (kgs)";
            colGW.Name = "colGW";
            colGW.ReadOnly = true;
            // 
            // colDim
            // 
            colDim.FillWeight = 110F;
            colDim.HeaderText = "Dimension (cm)";
            colDim.Name = "colDim";
            colDim.ReadOnly = true;
            // 
            // colHS
            // 
            colHS.FillWeight = 90F;
            colHS.HeaderText = "HS Code";
            colHS.Name = "colHS";
            colHS.ReadOnly = true;
            // 
            // lblTotalAmtLbl
            // 
            lblTotalAmtLbl.BackColor = Color.FromArgb(240, 240, 180);
            lblTotalAmtLbl.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTotalAmtLbl.Location = new Point(180, 832);
            lblTotalAmtLbl.Name = "lblTotalAmtLbl";
            lblTotalAmtLbl.Size = new Size(100, 28);
            lblTotalAmtLbl.TabIndex = 59;
            lblTotalAmtLbl.Text = "Total Amount:";
            lblTotalAmtLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.FromArgb(255, 255, 220);
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            txtTotalAmount.Location = new Point(280, 832);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(200, 16);
            txtTotalAmount.TabIndex = 60;
            // 
            // lblTotalNWLbl
            // 
            lblTotalNWLbl.BackColor = Color.FromArgb(240, 240, 180);
            lblTotalNWLbl.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTotalNWLbl.Location = new Point(500, 832);
            lblTotalNWLbl.Name = "lblTotalNWLbl";
            lblTotalNWLbl.Size = new Size(80, 28);
            lblTotalNWLbl.TabIndex = 61;
            lblTotalNWLbl.Text = "Total NW:";
            lblTotalNWLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTotalNW
            // 
            txtTotalNW.BackColor = Color.FromArgb(255, 255, 220);
            txtTotalNW.BorderStyle = BorderStyle.None;
            txtTotalNW.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            txtTotalNW.Location = new Point(580, 832);
            txtTotalNW.Name = "txtTotalNW";
            txtTotalNW.ReadOnly = true;
            txtTotalNW.Size = new Size(140, 16);
            txtTotalNW.TabIndex = 62;
            // 
            // lblTotalGWLbl
            // 
            lblTotalGWLbl.BackColor = Color.FromArgb(240, 240, 180);
            lblTotalGWLbl.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTotalGWLbl.Location = new Point(730, 832);
            lblTotalGWLbl.Name = "lblTotalGWLbl";
            lblTotalGWLbl.Size = new Size(80, 28);
            lblTotalGWLbl.TabIndex = 63;
            lblTotalGWLbl.Text = "Total GW:";
            lblTotalGWLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTotalGW
            // 
            txtTotalGW.BackColor = Color.FromArgb(255, 255, 220);
            txtTotalGW.BorderStyle = BorderStyle.None;
            txtTotalGW.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            txtTotalGW.Location = new Point(810, 832);
            txtTotalGW.Name = "txtTotalGW";
            txtTotalGW.ReadOnly = true;
            txtTotalGW.Size = new Size(140, 16);
            txtTotalGW.TabIndex = 64;
            // 
            // panelShipMark
            // 
            panelShipMark.BackColor = Color.White;
            panelShipMark.BorderStyle = BorderStyle.FixedSingle;
            panelShipMark.Controls.Add(lblShipMarkTitle);
            panelShipMark.Controls.Add(txtShipMarkContent);
            panelShipMark.Location = new Point(0, 864);
            panelShipMark.Name = "panelShipMark";
            panelShipMark.Size = new Size(420, 164);
            panelShipMark.TabIndex = 5;
            // 
            // lblShipMarkTitle
            // 
            lblShipMarkTitle.BackColor = Color.FromArgb(210, 220, 240);
            lblShipMarkTitle.Dock = DockStyle.Top;
            lblShipMarkTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lblShipMarkTitle.Location = new Point(0, 0);
            lblShipMarkTitle.Name = "lblShipMarkTitle";
            lblShipMarkTitle.Size = new Size(418, 26);
            lblShipMarkTitle.TabIndex = 0;
            lblShipMarkTitle.Text = "SHIPPING MARK";
            lblShipMarkTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtShipMarkContent
            // 
            txtShipMarkContent.BackColor = Color.White;
            txtShipMarkContent.BorderStyle = BorderStyle.None;
            txtShipMarkContent.Dock = DockStyle.Fill;
            txtShipMarkContent.Font = new Font("Microsoft JhengHei UI", 9.5F, FontStyle.Bold);
            txtShipMarkContent.Location = new Point(0, 0);
            txtShipMarkContent.Multiline = true;
            txtShipMarkContent.Name = "txtShipMarkContent";
            txtShipMarkContent.ReadOnly = true;
            txtShipMarkContent.Size = new Size(418, 162);
            txtShipMarkContent.TabIndex = 1;
            txtShipMarkContent.TextAlign = HorizontalAlignment.Center;
            // 
            // panelSignature
            // 
            panelSignature.BackColor = Color.White;
            panelSignature.BorderStyle = BorderStyle.FixedSingle;
            panelSignature.Controls.Add(txtCaseNo);
            panelSignature.Controls.Add(lblTotalRight);
            panelSignature.Controls.Add(txtTotal);
            panelSignature.Controls.Add(lblPackingRight);
            panelSignature.Controls.Add(txtPackingRight);
            panelSignature.Controls.Add(lblConfirm);
            panelSignature.Controls.Add(lblSigLine);
            panelSignature.Location = new Point(424, 864);
            panelSignature.Name = "panelSignature";
            panelSignature.Size = new Size(626, 164);
            panelSignature.TabIndex = 6;
            // 
            // txtCaseNo
            // 
            txtCaseNo.BorderStyle = BorderStyle.None;
            txtCaseNo.Location = new Point(4, 32);
            txtCaseNo.Name = "txtCaseNo";
            txtCaseNo.ReadOnly = true;
            txtCaseNo.Size = new Size(614, 17);
            txtCaseNo.TabIndex = 0;
            // 
            // lblTotalRight
            // 
            lblTotalRight.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblTotalRight.Location = new Point(4, 4);
            lblTotalRight.Name = "lblTotalRight";
            lblTotalRight.Size = new Size(50, 24);
            lblTotalRight.TabIndex = 1;
            lblTotalRight.Text = "Total:";
            lblTotalRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Location = new Point(54, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(160, 17);
            txtTotal.TabIndex = 2;
            // 
            // lblPackingRight
            // 
            lblPackingRight.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblPackingRight.Location = new Point(228, 4);
            lblPackingRight.Name = "lblPackingRight";
            lblPackingRight.Size = new Size(70, 24);
            lblPackingRight.TabIndex = 3;
            lblPackingRight.Text = "Packing:";
            lblPackingRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPackingRight
            // 
            txtPackingRight.BorderStyle = BorderStyle.None;
            txtPackingRight.Location = new Point(302, 4);
            txtPackingRight.Name = "txtPackingRight";
            txtPackingRight.ReadOnly = true;
            txtPackingRight.Size = new Size(316, 17);
            txtPackingRight.TabIndex = 4;
            // 
            // lblConfirm
            // 
            lblConfirm.Font = new Font("Microsoft JhengHei UI", 9F);
            lblConfirm.Location = new Point(4, 62);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(614, 52);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "We confirm that above information is correct for Dahching to proceed for dispatch.";
            lblConfirm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSigLine
            // 
            lblSigLine.Font = new Font("Microsoft JhengHei UI", 9F);
            lblSigLine.Location = new Point(4, 118);
            lblSigLine.Name = "lblSigLine";
            lblSigLine.Size = new Size(614, 40);
            lblSigLine.TabIndex = 6;
            lblSigLine.Text = "Authorized Signature: ___________________________        Date: _______________";
            lblSigLine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFooter1
            // 
            lblFooter1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblFooter1.Location = new Point(0, 1032);
            lblFooter1.Name = "lblFooter1";
            lblFooter1.Size = new Size(1050, 20);
            lblFooter1.TabIndex = 65;
            lblFooter1.Text = "Dahching Electric Industrial Co.,Ltd                                                                                                  V.A.T.No. 34410448";
            lblFooter1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFooter2
            // 
            lblFooter2.Font = new Font("Microsoft JhengHei UI", 8.5F);
            lblFooter2.Location = new Point(0, 1052);
            lblFooter2.Name = "lblFooter2";
            lblFooter2.Size = new Size(1050, 18);
            lblFooter2.TabIndex = 66;
            lblFooter2.Text = "Postal Add: 1-57 Kangnan Li, Anting District, Tainan City 745, Taiwan";
            // 
            // lblFooter3
            // 
            lblFooter3.Font = new Font("Microsoft JhengHei UI", 8.5F);
            lblFooter3.Location = new Point(0, 1070);
            lblFooter3.Name = "lblFooter3";
            lblFooter3.Size = new Size(1050, 18);
            lblFooter3.TabIndex = 67;
            lblFooter3.Text = "Billing Add: 311-2 Kangnan Li, Anting District, Tainan City 745, Taiwan";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1050, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.Red;
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.ForeColor = SystemColors.ButtonFace;
            btnPreviewPrint.Location = new Point(820, 36);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(148, 35);
            btnPreviewPrint.TabIndex = 69;
            btnPreviewPrint.Text = "Preview Print";
            btnPreviewPrint.UseVisualStyleBackColor = false;
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            // 
            // FrmEQPShippingPrint
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1050, 1090);
            Controls.Add(btnPreviewPrint);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrint);
            Controls.Add(lblTitle);
            Controls.Add(lblDate);
            Controls.Add(txtDate);
            Controls.Add(lblDONo);
            Controls.Add(txtDONo);
            Controls.Add(lblSerialNo);
            Controls.Add(txtSerialNo);
            Controls.Add(lblConsignee);
            Controls.Add(txtConsignee);
            Controls.Add(lblPostalAdd);
            Controls.Add(txtPostalAdd);
            Controls.Add(lblDeliveryAdd);
            Controls.Add(txtDeliveryAdd);
            Controls.Add(lblAttn);
            Controls.Add(txtAttn);
            Controls.Add(lblPO);
            Controls.Add(txtPONumber);
            Controls.Add(lblTel);
            Controls.Add(txtTel);
            Controls.Add(lblPI);
            Controls.Add(txtPINumber);
            Controls.Add(lblContainer);
            Controls.Add(txtContainer);
            Controls.Add(lblContainerType);
            Controls.Add(txtContainerType);
            Controls.Add(lblDeliveryTerm);
            Controls.Add(txtDeliveryTerm);
            Controls.Add(lblContainerPort);
            Controls.Add(txtContainerPort);
            Controls.Add(lblDestPort);
            Controls.Add(txtDestPort);
            Controls.Add(lblInsurance);
            Controls.Add(txtInsurance);
            Controls.Add(lblPacking);
            Controls.Add(txtPacking);
            Controls.Add(lblETD);
            Controls.Add(txtETD);
            Controls.Add(lblETA);
            Controls.Add(txtETA);
            Controls.Add(lblCutOff);
            Controls.Add(txtCutOff);
            Controls.Add(lblCertOfOrigin);
            Controls.Add(txtCertOfOrigin);
            Controls.Add(lblTypesOfBL);
            Controls.Add(txtTypesOfBL);
            Controls.Add(lblSurrenderBL);
            Controls.Add(txtSurrenderBL);
            Controls.Add(lblForwarder);
            Controls.Add(txtForwarder);
            Controls.Add(lblShipName);
            Controls.Add(txtShipName);
            Controls.Add(lblDoc);
            Controls.Add(txtDoc);
            Controls.Add(lblVoyage);
            Controls.Add(txtVoyage);
            Controls.Add(lblBrandMark);
            Controls.Add(txtMark);
            Controls.Add(dgvItems);
            Controls.Add(lblTotalAmtLbl);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblTotalNWLbl);
            Controls.Add(txtTotalNW);
            Controls.Add(lblTotalGWLbl);
            Controls.Add(txtTotalGW);
            Controls.Add(panelShipMark);
            Controls.Add(panelSignature);
            Controls.Add(lblFooter1);
            Controls.Add(lblFooter2);
            Controls.Add(lblFooter3);
            Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmEQPShippingPrint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DELIVERY ORDER 預覽列印";
            Load += FrmEQPShippingPrint_Load;
            Click += FrmEQPShippingPrint_Click;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelShipMark.ResumeLayout(false);
            panelShipMark.PerformLayout();
            panelSignature.ResumeLayout(false);
            panelSignature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrint;
        private Label lblTitle;
        // Row 1
        private Label lblDate;
        private TextBox txtDate;
        private Label lblDONo;
        private TextBox txtDONo;
        private Label lblSerialNo;
        private TextBox txtSerialNo;
        // Row 2-4
        private Label lblConsignee;
        private TextBox txtConsignee;
        private Label lblPostalAdd;
        private TextBox txtPostalAdd;
        private Label lblDeliveryAdd;
        private TextBox txtDeliveryAdd;
        // Row 5-6
        private Label lblAttn;
        private TextBox txtAttn;
        private Label lblPO;
        private TextBox txtPONumber;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblPI;
        private TextBox txtPINumber;
        // Row 7
        private Label lblContainer;
        private TextBox txtContainer;
        private Label lblContainerType;
        private TextBox txtContainerType;
        // Row 8
        private Label lblDeliveryTerm;
        private TextBox txtDeliveryTerm;
        private Label lblContainerPort;
        private TextBox txtContainerPort;
        private Label lblDestPort;
        private TextBox txtDestPort;
        // Row 9
        private Label lblInsurance;
        private TextBox txtInsurance;
        private Label lblPacking;
        private TextBox txtPacking;
        // Row 10
        private Label lblETD;
        private TextBox txtETD;
        private Label lblETA;
        private TextBox txtETA;
        // Row 11
        private Label lblCutOff;
        private TextBox txtCutOff;
        private Label lblCertOfOrigin;
        private TextBox txtCertOfOrigin;
        // Row 12
        private Label lblTypesOfBL;
        private TextBox txtTypesOfBL;
        private Label lblSurrenderBL;
        private TextBox txtSurrenderBL;
        // Row 13
        private Label lblForwarder;
        private TextBox txtForwarder;
        private Label lblShipName;
        private TextBox txtShipName;
        // Row 14
        private Label lblDoc;
        private TextBox txtDoc;
        private Label lblVoyage;
        private TextBox txtVoyage;
        // Row 15
        private Label lblBrandMark;
        private TextBox txtMark;
        private Label lblSpecify;
        // Grid
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colQTY;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colCy1;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colCy2;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colNW;
        private DataGridViewTextBoxColumn colGW;
        private DataGridViewTextBoxColumn colDim;
        private DataGridViewTextBoxColumn colHS;
        // Totals
        private Label lblTotalAmtLbl;
        private TextBox txtTotalAmount;
        private Label lblTotalNWLbl;
        private TextBox txtTotalNW;
        private Label lblTotalGWLbl;
        private TextBox txtTotalGW;
        // Shipping Mark
        private Panel panelShipMark;
        private Label lblShipMarkTitle;
        private TextBox txtShipMarkContent;
        // Signature
        private Panel panelSignature;
        private Label lblTotalRight;
        private TextBox txtTotal;
        private TextBox txtCaseNo;
        private Label lblPackingRight;
        private TextBox txtPackingRight;
        private Label lblConfirm;
        private Label lblSigLine;
        // Footer
        private Label lblFooter1;
        private Label lblFooter2;
        private Label lblFooter3;
        private PictureBox pictureBox1;
        private Button btnPreviewPrint;
    }
}
