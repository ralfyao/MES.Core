namespace DigiERP.UserControl.Customer.Repair
{
    partial class RepairFormMaintainControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblMode = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnTransferParts = new Button();
            btnApprove = new Button();
            btnCancelApprove = new Button();
            btnBack = new Button();
            panelMain = new Panel();
            label1 = new Label();
            dtApplyDate = new DigiERP.Common.CommonDateTimePicker();
            label2 = new Label();
            txtFormNo = new DigiERP.Common.CommonTextBox();
            label3 = new Label();
            txtEqpModel = new DigiERP.Common.CommonTextBox();
            label4 = new Label();
            cboInspectorCode = new DigiERP.Common.CommonComboBox();
            txtInspectorName = new DigiERP.Common.CommonTextBox();
            label5 = new Label();
            txtCustId = new DigiERP.Common.CommonTextBox();
            btnCustLookup = new Button();
            label6 = new Label();
            txtProjectSerial = new DigiERP.Common.CommonTextBox();
            label7 = new Label();
            txtEqpType = new DigiERP.Common.CommonTextBox();
            label8 = new Label();
            txtEqpName = new DigiERP.Common.CommonTextBox();
            label9 = new Label();
            cboServiceType = new DigiERP.Common.CommonComboBox();
            label10 = new Label();
            txtCustName = new DigiERP.Common.CommonTextBox();
            label11 = new Label();
            dtActualDate = new DigiERP.Common.CommonDateTimePicker();
            label12 = new Label();
            txtCustContact = new DigiERP.Common.CommonTextBox();
            label13 = new Label();
            txtRepairLocation = new DigiERP.Common.CommonTextBox();
            label14 = new Label();
            txtFaultDesc = new DigiERP.Common.CommonTextBox();
            label15 = new Label();
            dtDesiredDate = new DigiERP.Common.CommonDateTimePicker();
            label16 = new Label();
            dtCloseDate = new DigiERP.Common.CommonDateTimePicker();
            label17 = new Label();
            txtServiceHours = new DigiERP.Common.CommonTextBox();
            chkTransferParts = new CheckBox();
            btnOpenPartsOrder = new Button();
            label18 = new Label();
            txtPartsWorkOrder = new DigiERP.Common.CommonTextBox();
            labelR1 = new Label();
            txtDiagnosis1 = new DigiERP.Common.CommonTextBox();
            labelR2 = new Label();
            txtDesc1 = new DigiERP.Common.CommonTextBox();
            labelR3 = new Label();
            labelR4 = new Label();
            cboReason1 = new DigiERP.Common.CommonComboBox();
            labelR5 = new Label();
            txtRecommendation = new DigiERP.Common.CommonTextBox();
            labelR6 = new Label();
            txtCustomerReaction = new DigiERP.Common.CommonTextBox();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(192, 255, 192);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblMode);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnDelete);
            panelHeader.Controls.Add(btnTransferParts);
            panelHeader.Controls.Add(btnApprove);
            panelHeader.Controls.Add(btnCancelApprove);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1500, 110);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "維修服務單";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.ForeColor = Color.DarkRed;
            lblMode.Location = new Point(248, 16);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(46, 23);
            lblMode.TabIndex = 1;
            lblMode.Text = "新增";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(16, 62);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(138, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTransferParts
            // 
            btnTransferParts.BackColor = Color.DarkOrange;
            btnTransferParts.ForeColor = Color.White;
            btnTransferParts.Location = new Point(260, 62);
            btnTransferParts.Name = "btnTransferParts";
            btnTransferParts.Size = new Size(140, 38);
            btnTransferParts.TabIndex = 4;
            btnTransferParts.Text = "轉零件申請單";
            btnTransferParts.UseVisualStyleBackColor = false;
            btnTransferParts.Click += btnTransferParts_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SeaGreen;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(412, 62);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(110, 38);
            btnApprove.TabIndex = 5;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnCancelApprove
            // 
            btnCancelApprove.BackColor = Color.DarkGoldenrod;
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(534, 62);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(110, 38);
            btnCancelApprove.TabIndex = 6;
            btnCancelApprove.Text = "取消生效";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Visible = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(656, 62);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 38);
            btnBack.TabIndex = 7;
            btnBack.Text = "關閉";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(192, 255, 192);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(dtApplyDate);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(txtFormNo);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(txtEqpModel);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(cboInspectorCode);
            panelMain.Controls.Add(txtInspectorName);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(txtCustId);
            panelMain.Controls.Add(btnCustLookup);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(txtProjectSerial);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(txtEqpType);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(txtEqpName);
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(cboServiceType);
            panelMain.Controls.Add(label10);
            panelMain.Controls.Add(txtCustName);
            panelMain.Controls.Add(label11);
            panelMain.Controls.Add(dtActualDate);
            panelMain.Controls.Add(label12);
            panelMain.Controls.Add(txtCustContact);
            panelMain.Controls.Add(label13);
            panelMain.Controls.Add(txtRepairLocation);
            panelMain.Controls.Add(label14);
            panelMain.Controls.Add(txtFaultDesc);
            panelMain.Controls.Add(label15);
            panelMain.Controls.Add(dtDesiredDate);
            panelMain.Controls.Add(label16);
            panelMain.Controls.Add(dtCloseDate);
            panelMain.Controls.Add(label17);
            panelMain.Controls.Add(txtServiceHours);
            panelMain.Controls.Add(chkTransferParts);
            panelMain.Controls.Add(btnOpenPartsOrder);
            panelMain.Controls.Add(label18);
            panelMain.Controls.Add(txtPartsWorkOrder);
            panelMain.Controls.Add(labelR1);
            panelMain.Controls.Add(txtDiagnosis1);
            panelMain.Controls.Add(labelR2);
            panelMain.Controls.Add(txtDesc1);
            panelMain.Controls.Add(labelR3);
            panelMain.Controls.Add(labelR4);
            panelMain.Controls.Add(cboReason1);
            panelMain.Controls.Add(labelR5);
            panelMain.Controls.Add(txtRecommendation);
            panelMain.Controls.Add(labelR6);
            panelMain.Controls.Add(txtCustomerReaction);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 110);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1500, 821);
            panelMain.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 16);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "申請日期";
            // 
            // dtApplyDate
            // 
            dtApplyDate.CustomFormat = "yyyy/MM/dd";
            dtApplyDate.Format = DateTimePickerFormat.Custom;
            dtApplyDate.Location = new Point(90, 12);
            dtApplyDate.Name = "dtApplyDate";
            dtApplyDate.Size = new Size(150, 31);
            dtApplyDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 16);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 2;
            label2.Text = "單號";
            // 
            // txtFormNo
            // 
            txtFormNo.BackColor = Color.LightGray;
            txtFormNo.Location = new Point(300, 12);
            txtFormNo.Name = "txtFormNo";
            txtFormNo.ReadOnly = true;
            txtFormNo.Size = new Size(200, 31);
            txtFormNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 16);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "機台型號";
            // 
            // txtEqpModel
            // 
            txtEqpModel.Location = new Point(610, 12);
            txtEqpModel.Name = "txtEqpModel";
            txtEqpModel.Size = new Size(258, 31);
            txtEqpModel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(900, 16);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 6;
            label4.Text = "檢修人員";
            // 
            // cboInspectorCode
            // 
            cboInspectorCode.FormattingEnabled = true;
            cboInspectorCode.Location = new Point(996, 12);
            cboInspectorCode.Name = "cboInspectorCode";
            cboInspectorCode.Size = new Size(160, 31);
            cboInspectorCode.TabIndex = 7;
            cboInspectorCode.SelectedIndexChanged += cboInspectorCode_SelectedIndexChanged;
            // 
            // txtInspectorName
            // 
            txtInspectorName.BackColor = Color.LightYellow;
            txtInspectorName.Location = new Point(1166, 12);
            txtInspectorName.Name = "txtInspectorName";
            txtInspectorName.ReadOnly = true;
            txtInspectorName.Size = new Size(260, 31);
            txtInspectorName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 56);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 9;
            label5.Text = "客戶簡稱";
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(90, 50);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(120, 31);
            txtCustId.TabIndex = 10;
            txtCustId.MouseClick += txtCustId_MouseClick;
            // 
            // btnCustLookup
            // 
            btnCustLookup.FlatStyle = FlatStyle.Flat;
            btnCustLookup.Location = new Point(212, 50);
            btnCustLookup.Name = "btnCustLookup";
            btnCustLookup.Size = new Size(28, 31);
            btnCustLookup.TabIndex = 11;
            btnCustLookup.Text = "…";
            btnCustLookup.Click += btnCustLookup_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 56);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 12;
            label6.Text = "專案序號";
            // 
            // txtProjectSerial
            // 
            txtProjectSerial.Location = new Point(350, 50);
            txtProjectSerial.Name = "txtProjectSerial";
            txtProjectSerial.Size = new Size(120, 31);
            txtProjectSerial.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(484, 56);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 14;
            label7.Text = "機台類型";
            // 
            // txtEqpType
            // 
            txtEqpType.Location = new Point(580, 50);
            txtEqpType.Name = "txtEqpType";
            txtEqpType.Size = new Size(100, 31);
            txtEqpType.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(694, 56);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 16;
            label8.Text = "機台名稱";
            // 
            // txtEqpName
            // 
            txtEqpName.Location = new Point(790, 50);
            txtEqpName.Name = "txtEqpName";
            txtEqpName.Size = new Size(178, 31);
            txtEqpName.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1064, 52);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 18;
            label9.Text = "服務型態";
            // 
            // cboServiceType
            // 
            cboServiceType.FormattingEnabled = true;
            cboServiceType.Items.AddRange(new object[] { "", "外派維修", "後送內修", "線上指導", "視訊教學" });
            cboServiceType.Location = new Point(1164, 50);
            cboServiceType.Name = "cboServiceType";
            cboServiceType.Size = new Size(262, 31);
            cboServiceType.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(-1, 94);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 20;
            label10.Text = "客戶名稱";
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(90, 88);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(878, 31);
            txtCustName.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1024, 90);
            label11.Name = "label11";
            label11.Size = new Size(124, 24);
            label11.TabIndex = 22;
            label11.Text = "實際服務日期";
            // 
            // dtActualDate
            // 
            dtActualDate.CustomFormat = "yyyy/MM/dd";
            dtActualDate.Format = DateTimePickerFormat.Custom;
            dtActualDate.Location = new Point(1178, 84);
            dtActualDate.Name = "dtActualDate";
            dtActualDate.Size = new Size(150, 31);
            dtActualDate.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(-1, 132);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 24;
            label12.Text = "聯絡窗口";
            // 
            // txtCustContact
            // 
            txtCustContact.Location = new Point(90, 126);
            txtCustContact.Name = "txtCustContact";
            txtCustContact.Size = new Size(200, 31);
            txtCustContact.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(304, 132);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 26;
            label13.Text = "維修地點";
            // 
            // txtRepairLocation
            // 
            txtRepairLocation.Location = new Point(400, 126);
            txtRepairLocation.Name = "txtRepairLocation";
            txtRepairLocation.Size = new Size(568, 31);
            txtRepairLocation.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(-1, 170);
            label14.Name = "label14";
            label14.Size = new Size(86, 24);
            label14.TabIndex = 28;
            label14.Text = "故障情形";
            // 
            // txtFaultDesc
            // 
            txtFaultDesc.Location = new Point(90, 164);
            txtFaultDesc.Multiline = true;
            txtFaultDesc.Name = "txtFaultDesc";
            txtFaultDesc.ScrollBars = ScrollBars.Vertical;
            txtFaultDesc.Size = new Size(878, 185);
            txtFaultDesc.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1024, 166);
            label15.Name = "label15";
            label15.Size = new Size(124, 24);
            label15.TabIndex = 30;
            label15.Text = "希望服務日期";
            // 
            // dtDesiredDate
            // 
            dtDesiredDate.CustomFormat = "yyyy/MM/dd";
            dtDesiredDate.Format = DateTimePickerFormat.Custom;
            dtDesiredDate.Location = new Point(1178, 160);
            dtDesiredDate.Name = "dtDesiredDate";
            dtDesiredDate.Size = new Size(150, 31);
            dtDesiredDate.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1024, 204);
            label16.Name = "label16";
            label16.Size = new Size(124, 24);
            label16.TabIndex = 32;
            label16.Text = "維修結案日期";
            // 
            // dtCloseDate
            // 
            dtCloseDate.CustomFormat = "yyyy/MM/dd";
            dtCloseDate.Format = DateTimePickerFormat.Custom;
            dtCloseDate.Location = new Point(1178, 198);
            dtCloseDate.Name = "dtCloseDate";
            dtCloseDate.Size = new Size(150, 31);
            dtCloseDate.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1024, 242);
            label17.Name = "label17";
            label17.Size = new Size(124, 24);
            label17.TabIndex = 34;
            label17.Text = "維修服務時數";
            // 
            // txtServiceHours
            // 
            txtServiceHours.Location = new Point(1178, 236);
            txtServiceHours.Name = "txtServiceHours";
            txtServiceHours.Size = new Size(100, 31);
            txtServiceHours.TabIndex = 35;
            // 
            // chkTransferParts
            // 
            chkTransferParts.AutoSize = true;
            chkTransferParts.Enabled = false;
            chkTransferParts.Location = new Point(1024, 286);
            chkTransferParts.Name = "chkTransferParts";
            chkTransferParts.Size = new Size(124, 28);
            chkTransferParts.TabIndex = 36;
            chkTransferParts.Text = "轉零件工令";
            // 
            // btnOpenPartsOrder
            // 
            btnOpenPartsOrder.BackColor = Color.SteelBlue;
            btnOpenPartsOrder.ForeColor = Color.White;
            btnOpenPartsOrder.Location = new Point(1154, 282);
            btnOpenPartsOrder.Name = "btnOpenPartsOrder";
            btnOpenPartsOrder.Size = new Size(160, 34);
            btnOpenPartsOrder.TabIndex = 37;
            btnOpenPartsOrder.Text = "開立零件申請單";
            btnOpenPartsOrder.UseVisualStyleBackColor = false;
            btnOpenPartsOrder.Click += btnTransferParts_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1024, 330);
            label18.Name = "label18";
            label18.Size = new Size(105, 24);
            label18.TabIndex = 38;
            label18.Text = "零件申請單";
            // 
            // txtPartsWorkOrder
            // 
            txtPartsWorkOrder.BackColor = Color.LightGray;
            txtPartsWorkOrder.Location = new Point(1154, 324);
            txtPartsWorkOrder.Name = "txtPartsWorkOrder";
            txtPartsWorkOrder.ReadOnly = true;
            txtPartsWorkOrder.Size = new Size(200, 31);
            txtPartsWorkOrder.TabIndex = 39;
            // 
            // labelR1
            // 
            labelR1.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelR1.ForeColor = Color.DarkRed;
            labelR1.Location = new Point(8, 358);
            labelR1.Name = "labelR1";
            labelR1.Size = new Size(75, 120);
            labelR1.TabIndex = 40;
            labelR1.Text = "查修結果";
            labelR1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDiagnosis1
            // 
            txtDiagnosis1.Location = new Point(90, 358);
            txtDiagnosis1.Multiline = true;
            txtDiagnosis1.Name = "txtDiagnosis1";
            txtDiagnosis1.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis1.Size = new Size(878, 120);
            txtDiagnosis1.TabIndex = 41;
            // 
            // labelR2
            // 
            labelR2.AutoSize = true;
            labelR2.ForeColor = Color.DimGray;
            labelR2.Location = new Point(0, 486);
            labelR2.Name = "labelR2";
            labelR2.Size = new Size(86, 24);
            labelR2.TabIndex = 42;
            labelR2.Text = "簡要描述";
            // 
            // txtDesc1
            // 
            txtDesc1.Location = new Point(90, 486);
            txtDesc1.Multiline = true;
            txtDesc1.Name = "txtDesc1";
            txtDesc1.Size = new Size(370, 110);
            txtDesc1.TabIndex = 43;
            // 
            // labelR3
            // 
            labelR3.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelR3.ForeColor = Color.DarkRed;
            labelR3.Location = new Point(474, 486);
            labelR3.Name = "labelR3";
            labelR3.Size = new Size(75, 110);
            labelR3.TabIndex = 46;
            labelR3.Text = "可能原因";
            labelR3.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelR4
            // 
            labelR4.AutoSize = true;
            labelR4.ForeColor = Color.DimGray;
            labelR4.Location = new Point(556, 484);
            labelR4.Name = "labelR4";
            labelR4.Size = new Size(86, 24);
            labelR4.TabIndex = 47;
            labelR4.Text = "原因類別";
            // 
            // cboReason1
            // 
            cboReason1.FormattingEnabled = true;
            cboReason1.Location = new Point(556, 512);
            cboReason1.Name = "cboReason1";
            cboReason1.Size = new Size(412, 31);
            cboReason1.TabIndex = 48;
            // 
            // labelR5
            // 
            labelR5.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelR5.ForeColor = Color.DarkRed;
            labelR5.Location = new Point(8, 606);
            labelR5.Name = "labelR5";
            labelR5.Size = new Size(75, 110);
            labelR5.TabIndex = 51;
            labelR5.Text = "建議更換或維修零件";
            labelR5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(90, 606);
            txtRecommendation.Multiline = true;
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.ScrollBars = ScrollBars.Vertical;
            txtRecommendation.Size = new Size(878, 110);
            txtRecommendation.TabIndex = 52;
            // 
            // labelR6
            // 
            labelR6.AutoSize = true;
            labelR6.Location = new Point(-1, 728);
            labelR6.Name = "labelR6";
            labelR6.Size = new Size(86, 24);
            labelR6.TabIndex = 53;
            labelR6.Text = "客戶反應";
            // 
            // txtCustomerReaction
            // 
            txtCustomerReaction.Location = new Point(90, 724);
            txtCustomerReaction.Multiline = true;
            txtCustomerReaction.Name = "txtCustomerReaction";
            txtCustomerReaction.ScrollBars = ScrollBars.Vertical;
            txtCustomerReaction.Size = new Size(878, 90);
            txtCustomerReaction.TabIndex = 54;
            // 
            // RepairFormMaintainControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "RepairFormMaintainControl";
            Size = new Size(1500, 931);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ───────────────────────────────────────────
        private Panel panelHeader;
        private Panel panelMain;
        internal Label lblMode;
        private Label lblTitle;
        private Button btnSave;
        private Button btnDelete;
        private Button btnTransferParts;
        private Button btnApprove;
        private Button btnCancelApprove;
        private Button btnBack;
        // Row 1
        private Label label1;
        private DigiERP.Common.CommonDateTimePicker dtApplyDate;
        private Label label2;
        private DigiERP.Common.CommonTextBox txtFormNo;
        private Label label3;
        private DigiERP.Common.CommonTextBox txtEqpModel;
        private Label label4;
        private DigiERP.Common.CommonComboBox cboInspectorCode;
        private DigiERP.Common.CommonTextBox txtInspectorName;
        // Row 2
        private Label label5;
        private DigiERP.Common.CommonTextBox txtCustId;
        private Button btnCustLookup;
        private Label label6;
        private DigiERP.Common.CommonTextBox txtProjectSerial;
        private Label label7;
        private DigiERP.Common.CommonTextBox txtEqpType;
        private Label label8;
        private DigiERP.Common.CommonTextBox txtEqpName;
        private Label label9;
        private DigiERP.Common.CommonComboBox cboServiceType;
        // Row 3
        private Label label10;
        private DigiERP.Common.CommonTextBox txtCustName;
        private Label label11;
        private DigiERP.Common.CommonDateTimePicker dtActualDate;
        // Row 4
        private Label label12;
        private DigiERP.Common.CommonTextBox txtCustContact;
        private Label label13;
        private DigiERP.Common.CommonTextBox txtRepairLocation;
        // Fault + dates
        private Label label14;
        private DigiERP.Common.CommonTextBox txtFaultDesc;
        private Label label15;
        private DigiERP.Common.CommonDateTimePicker dtDesiredDate;
        private Label label16;
        private DigiERP.Common.CommonDateTimePicker dtCloseDate;
        private Label label17;
        private DigiERP.Common.CommonTextBox txtServiceHours;
        private CheckBox chkTransferParts;
        private Button btnOpenPartsOrder;
        private Label label18;
        private DigiERP.Common.CommonTextBox txtPartsWorkOrder;
        // Analysis
        private Label labelR1;
        private DigiERP.Common.CommonTextBox txtDiagnosis1;
        private Label labelR2;
        private DigiERP.Common.CommonTextBox txtDesc1;
        private Label labelR3;
        private Label labelR4;
        private DigiERP.Common.CommonComboBox cboReason1;
        private Label labelR5;
        private DigiERP.Common.CommonTextBox txtRecommendation;
        private Label labelR6;
        private DigiERP.Common.CommonTextBox txtCustomerReaction;
    }
}
