namespace DigiERP.UserControl.Customer.EQPCSustService
{
    partial class EQPCustServiceMaintainControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            lblMode = new Label();
            label1 = new Label();
            cboCustId = new DigiERP.Common.CommonComboBox();
            label2 = new Label();
            txtCompany = new DigiERP.Common.CommonTextBox();
            label5 = new Label();
            label3 = new Label();
            dtORDERDATE = new DigiERP.Common.CommonDateTimePicker();
            txtOrderNo = new DigiERP.Common.CommonTextBox();
            label4 = new Label();
            txtDescription = new DigiERP.Common.CommonTextBox();
            label6 = new Label();
            label7 = new Label();
            cboProjectSerial = new DigiERP.Common.CommonComboBox();
            label8 = new Label();
            dtEQPShippingDate = new DigiERP.Common.CommonDateTimePicker();
            label9 = new Label();
            cboCustContact = new DigiERP.Common.CommonComboBox();
            btnClose = new Button();
            label10 = new Label();
            cboMType = new DigiERP.Common.CommonComboBox();
            txtEQPNo = new DigiERP.Common.CommonTextBox();
            label11 = new Label();
            txtEQPName = new DigiERP.Common.CommonTextBox();
            label12 = new Label();
            label13 = new Label();
            cbo機款 = new DigiERP.Common.CommonComboBox();
            label14 = new Label();
            cbo機種 = new DigiERP.Common.CommonComboBox();
            label15 = new Label();
            cbo機種分類 = new DigiERP.Common.CommonComboBox();
            label16 = new Label();
            cbo問題歸類 = new DigiERP.Common.CommonComboBox();
            label17 = new Label();
            cbo狀況 = new DigiERP.Common.CommonComboBox();
            dataGridView1 = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            customerFeedback = new DataGridViewTextBoxColumn();
            questionFeedback = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            technical = new DataGridViewTextBoxColumn();
            businessRecord = new DataGridViewTextBoxColumn();
            repairNo = new DataGridViewTextBoxColumn();
            quotation = new DataGridViewTextBoxColumn();
            btn修改 = new Button();
            btn送出 = new Button();
            btn新增機台服務紀錄 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 8);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 158;
            lblMode.Text = "lblMode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(69, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 159;
            label1.Text = "機台客服";
            // 
            // cboCustId
            // 
            cboCustId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(112, 44);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(121, 32);
            cboCustId.TabIndex = 232;
            cboCustId.SelectedIndexChanged += cboCustId_SelectedIndexChanged;
            cboCustId.Enter += cboCustId_Enter;
            cboCustId.Leave += cboCustId_Leave;
            cboCustId.MouseClick += cboCustId_MouseClick;
            cboCustId.MouseLeave += cboCustId_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 233;
            label2.Text = "客戶編號";
            // 
            // txtCompany
            // 
            txtCompany.Enabled = false;
            txtCompany.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCompany.Location = new Point(112, 88);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(576, 32);
            txtCompany.TabIndex = 240;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label5.Location = new Point(11, 92);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 239;
            label5.Text = "客戶全名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label3.Location = new Point(248, 48);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 242;
            label3.Text = "日期";
            // 
            // dtORDERDATE
            // 
            dtORDERDATE.Enabled = false;
            dtORDERDATE.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtORDERDATE.Location = new Point(296, 44);
            dtORDERDATE.Name = "dtORDERDATE";
            dtORDERDATE.Size = new Size(184, 32);
            dtORDERDATE.TabIndex = 241;
            dtORDERDATE.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtOrderNo
            // 
            txtOrderNo.Enabled = false;
            txtOrderNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOrderNo.Location = new Point(546, 46);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(144, 32);
            txtOrderNo.TabIndex = 244;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(492, 48);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 243;
            label4.Text = "單號";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDescription.Location = new Point(845, 48);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(667, 32);
            txtDescription.TabIndex = 246;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label6.Location = new Point(744, 52);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 245;
            label6.Text = "晴雨觀測";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(744, 92);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 248;
            label7.Text = "專案序號";
            // 
            // cboProjectSerial
            // 
            cboProjectSerial.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboProjectSerial.FormattingEnabled = true;
            cboProjectSerial.Location = new Point(844, 88);
            cboProjectSerial.Name = "cboProjectSerial";
            cboProjectSerial.Size = new Size(121, 32);
            cboProjectSerial.TabIndex = 247;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label8.Location = new Point(976, 92);
            label8.Name = "label8";
            label8.Size = new Size(105, 24);
            label8.TabIndex = 250;
            label8.Text = "機台交貨日";
            // 
            // dtEQPShippingDate
            // 
            dtEQPShippingDate.Enabled = false;
            dtEQPShippingDate.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtEQPShippingDate.Location = new Point(1092, 88);
            dtEQPShippingDate.Name = "dtEQPShippingDate";
            dtEQPShippingDate.Size = new Size(184, 32);
            dtEQPShippingDate.TabIndex = 249;
            dtEQPShippingDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1284, 92);
            label9.Name = "label9";
            label9.Size = new Size(105, 24);
            label9.TabIndex = 252;
            label9.Text = "客戶聯絡人";
            // 
            // cboCustContact
            // 
            cboCustContact.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustContact.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCustContact.FormattingEnabled = true;
            cboCustContact.Location = new Point(1390, 88);
            cboCustContact.Name = "cboCustContact";
            cboCustContact.Size = new Size(121, 32);
            cboCustContact.TabIndex = 251;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1480, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 32);
            btnClose.TabIndex = 253;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 140);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 255;
            label10.Text = "機台類型";
            // 
            // cboMType
            // 
            cboMType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMType.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMType.FormattingEnabled = true;
            cboMType.Location = new Point(112, 136);
            cboMType.Name = "cboMType";
            cboMType.Size = new Size(121, 32);
            cboMType.TabIndex = 254;
            // 
            // txtEQPNo
            // 
            txtEQPNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEQPNo.Location = new Point(345, 136);
            txtEQPNo.Name = "txtEQPNo";
            txtEQPNo.Size = new Size(343, 32);
            txtEQPNo.TabIndex = 257;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label11.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label11.Location = new Point(244, 140);
            label11.Name = "label11";
            label11.Size = new Size(86, 24);
            label11.TabIndex = 256;
            label11.Text = "機台型號";
            // 
            // txtEQPName
            // 
            txtEQPName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEQPName.Location = new Point(845, 136);
            txtEQPName.Name = "txtEQPName";
            txtEQPName.Size = new Size(663, 32);
            txtEQPName.TabIndex = 259;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label12.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label12.Location = new Point(744, 140);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 258;
            label12.Text = "機台名稱";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 188);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 261;
            label13.Text = "機款";
            // 
            // cbo機款
            // 
            cbo機款.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo機款.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo機款.FormattingEnabled = true;
            cbo機款.Location = new Point(112, 184);
            cbo機款.Name = "cbo機款";
            cbo機款.Size = new Size(121, 32);
            cbo機款.TabIndex = 260;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(244, 188);
            label14.Name = "label14";
            label14.Size = new Size(48, 24);
            label14.TabIndex = 263;
            label14.Text = "機種";
            // 
            // cbo機種
            // 
            cbo機種.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo機種.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo機種.FormattingEnabled = true;
            cbo機種.Location = new Point(304, 184);
            cbo機種.Name = "cbo機種";
            cbo機種.Size = new Size(161, 32);
            cbo機種.TabIndex = 262;
            cbo機種.SelectedIndexChanged += cbo機種_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(480, 188);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 265;
            label15.Text = "機種分類";
            // 
            // cbo機種分類
            // 
            cbo機種分類.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo機種分類.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo機種分類.FormattingEnabled = true;
            cbo機種分類.Location = new Point(572, 184);
            cbo機種分類.Name = "cbo機種分類";
            cbo機種分類.Size = new Size(161, 32);
            cbo機種分類.TabIndex = 264;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(748, 188);
            label16.Name = "label16";
            label16.Size = new Size(86, 24);
            label16.TabIndex = 267;
            label16.Text = "問題歸類";
            // 
            // cbo問題歸類
            // 
            cbo問題歸類.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo問題歸類.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo問題歸類.FormattingEnabled = true;
            cbo問題歸類.Location = new Point(848, 184);
            cbo問題歸類.Name = "cbo問題歸類";
            cbo問題歸類.Size = new Size(292, 32);
            cbo問題歸類.TabIndex = 266;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1152, 188);
            label17.Name = "label17";
            label17.Size = new Size(48, 24);
            label17.TabIndex = 269;
            label17.Text = "狀況";
            // 
            // cbo狀況
            // 
            cbo狀況.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo狀況.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo狀況.FormattingEnabled = true;
            cbo狀況.Location = new Point(1216, 184);
            cbo狀況.Name = "cbo狀況";
            cbo狀況.Size = new Size(288, 32);
            cbo狀況.TabIndex = 268;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { date, customerFeedback, questionFeedback, reason, technical, businessRecord, repairNo, quotation });
            dataGridView1.Location = new Point(20, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1484, 472);
            dataGridView1.TabIndex = 270;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            date.DefaultCellStyle = dataGridViewCellStyle9;
            date.HeaderText = "日期";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // customerFeedback
            // 
            customerFeedback.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            customerFeedback.DefaultCellStyle = dataGridViewCellStyle10;
            customerFeedback.HeaderText = "客戶反映";
            customerFeedback.Name = "customerFeedback";
            customerFeedback.ReadOnly = true;
            customerFeedback.Width = 111;
            // 
            // questionFeedback
            // 
            questionFeedback.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            questionFeedback.DefaultCellStyle = dataGridViewCellStyle11;
            questionFeedback.HeaderText = "問題回覆";
            questionFeedback.Name = "questionFeedback";
            questionFeedback.ReadOnly = true;
            // 
            // reason
            // 
            reason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            reason.DefaultCellStyle = dataGridViewCellStyle12;
            reason.HeaderText = "原因分析";
            reason.Name = "reason";
            reason.ReadOnly = true;
            // 
            // technical
            // 
            technical.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            technical.DefaultCellStyle = dataGridViewCellStyle13;
            technical.HeaderText = "技術判定人員";
            technical.Name = "technical";
            technical.ReadOnly = true;
            // 
            // businessRecord
            // 
            businessRecord.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            businessRecord.DefaultCellStyle = dataGridViewCellStyle14;
            businessRecord.HeaderText = "業務記錄";
            businessRecord.Name = "businessRecord";
            businessRecord.ReadOnly = true;
            // 
            // repairNo
            // 
            repairNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            repairNo.DefaultCellStyle = dataGridViewCellStyle15;
            repairNo.HeaderText = "維修單號";
            repairNo.Name = "repairNo";
            repairNo.ReadOnly = true;
            // 
            // quotation
            // 
            quotation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            quotation.DefaultCellStyle = dataGridViewCellStyle16;
            quotation.HeaderText = "報價單號";
            quotation.Name = "quotation";
            quotation.ReadOnly = true;
            // 
            // btn修改
            // 
            btn修改.BackColor = Color.DarkKhaki;
            btn修改.ForeColor = SystemColors.ButtonHighlight;
            btn修改.Location = new Point(160, 4);
            btn修改.Name = "btn修改";
            btn修改.Size = new Size(112, 32);
            btn修改.TabIndex = 271;
            btn修改.Text = "修改";
            btn修改.UseVisualStyleBackColor = false;
            btn修改.Click += btn修改_Click;
            // 
            // btn送出
            // 
            btn送出.BackColor = Color.Gold;
            btn送出.Location = new Point(1368, 8);
            btn送出.Name = "btn送出";
            btn送出.Size = new Size(92, 36);
            btn送出.TabIndex = 272;
            btn送出.Text = "送出";
            btn送出.UseVisualStyleBackColor = false;
            btn送出.Click += btn送出_Click;
            // 
            // btn新增機台服務紀錄
            // 
            btn新增機台服務紀錄.BackColor = SystemColors.ActiveCaption;
            btn新增機台服務紀錄.ForeColor = SystemColors.ButtonHighlight;
            btn新增機台服務紀錄.Location = new Point(292, 4);
            btn新增機台服務紀錄.Name = "btn新增機台服務紀錄";
            btn新增機台服務紀錄.Size = new Size(212, 32);
            btn新增機台服務紀錄.TabIndex = 273;
            btn新增機台服務紀錄.Text = "新增機台服務紀錄";
            btn新增機台服務紀錄.UseVisualStyleBackColor = false;
            btn新增機台服務紀錄.Click += btn新增機台服務紀錄_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(520, 4);
            button1.Name = "button1";
            button1.Size = new Size(212, 32);
            button1.TabIndex = 274;
            button1.Text = "查詢機台服務歷程";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EQPCustServiceMaintainControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SpringGreen;
            Controls.Add(button1);
            Controls.Add(btn新增機台服務紀錄);
            Controls.Add(btn送出);
            Controls.Add(btn修改);
            Controls.Add(dataGridView1);
            Controls.Add(label17);
            Controls.Add(cbo狀況);
            Controls.Add(label16);
            Controls.Add(cbo問題歸類);
            Controls.Add(label15);
            Controls.Add(cbo機種分類);
            Controls.Add(label14);
            Controls.Add(cbo機種);
            Controls.Add(label13);
            Controls.Add(cbo機款);
            Controls.Add(txtEQPName);
            Controls.Add(label12);
            Controls.Add(txtEQPNo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboMType);
            Controls.Add(btnClose);
            Controls.Add(label9);
            Controls.Add(cboCustContact);
            Controls.Add(label8);
            Controls.Add(dtEQPShippingDate);
            Controls.Add(label7);
            Controls.Add(cboProjectSerial);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(txtOrderNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtORDERDATE);
            Controls.Add(txtCompany);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(cboCustId);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "EQPCustServiceMaintainControl";
            Size = new Size(1528, 726);
            Load += EQPCustServiceMaintainControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private Label label1;
        private DigiERP.Common.CommonComboBox cboCustId;
        private Label label2;
        private DigiERP.Common.CommonTextBox txtCompany;
        private Label label5;
        private Label label3;
        private DigiERP.Common.CommonDateTimePicker dtORDERDATE;
        private DigiERP.Common.CommonTextBox txtOrderNo;
        private Label label4;
        private DigiERP.Common.CommonTextBox txtDescription;
        private Label label6;
        private Label label7;
        private DigiERP.Common.CommonComboBox cboProjectSerial;
        private Label label8;
        private DigiERP.Common.CommonDateTimePicker dtEQPShippingDate;
        private Label label9;
        private DigiERP.Common.CommonComboBox cboCustContact;
        private Button btnClose;
        private Label label10;
        private DigiERP.Common.CommonComboBox cboMType;
        private DigiERP.Common.CommonTextBox txtEQPNo;
        private Label label11;
        private DigiERP.Common.CommonTextBox txtEQPName;
        private Label label12;
        private Label label13;
        private DigiERP.Common.CommonComboBox cbo機款;
        private Label label14;
        private DigiERP.Common.CommonComboBox cbo機種;
        private Label label15;
        private DigiERP.Common.CommonComboBox cbo機種分類;
        private Label label16;
        private DigiERP.Common.CommonComboBox cbo問題歸類;
        private Label label17;
        private DigiERP.Common.CommonComboBox cbo狀況;
        private DataGridView dataGridView1;
        private Button btn修改;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn customerFeedback;
        private DataGridViewTextBoxColumn questionFeedback;
        private DataGridViewTextBoxColumn reason;
        private DataGridViewTextBoxColumn technical;
        private DataGridViewTextBoxColumn businessRecord;
        private DataGridViewTextBoxColumn repairNo;
        private DataGridViewTextBoxColumn quotation;
        private Button btn送出;
        private Button btn新增機台服務紀錄;
        private Button button1;
    }
}
