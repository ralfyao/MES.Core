using DigiERP.Common;
using DigiERP.UserControl.Common;

namespace DigiERP.UserControl.Customer.RFQ
{
    partial class RFQMaintainControl
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
            btnModify = new Button();
            lblMode = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dtRfqDate = new CommonDateTimePicker();
            label3 = new Label();
            txtRFQNO = new CommonTextBox();
            btnSubmit = new Button();
            txtCompany = new CommonTextBox();
            label4 = new Label();
            txtAlias = new CommonTextBox();
            label5 = new Label();
            label6 = new Label();
            industryCodeSelect1 = new IndustryCodeSelect();
            txtContact = new CommonTextBox();
            label7 = new Label();
            txtPosition = new CommonTextBox();
            label8 = new Label();
            txtCountry = new CommonTextBox();
            label9 = new Label();
            txtTel = new CommonTextBox();
            label10 = new Label();
            txtEmail = new CommonTextBox();
            label11 = new Label();
            txtMa = new CommonTextBox();
            label12 = new Label();
            txtEndUser = new CommonTextBox();
            label13 = new Label();
            label14 = new Label();
            cboAgentList = new CommonComboBox();
            label15 = new Label();
            label16 = new Label();
            salesSelect1 = new SalesSelect();
            txtSource = new CommonTextBox();
            cboSuccessRate = new CommonComboBox();
            label17 = new Label();
            label18 = new Label();
            txtMachine = new CommonTextBox();
            label19 = new Label();
            rfqStatusSelect1 = new RFQStatusSelect();
            label20 = new Label();
            txtComment = new CommonTextBox();
            btnDelete = new Button();
            label21 = new Label();
            dgvQuotation = new DataGridView();
            報價單號 = new DataGridViewTextBoxColumn();
            報價單日期 = new DataGridViewTextBoxColumn();
            dgvQuotationDetail = new DataGridView();
            label22 = new Label();
            dgvWorkRecord = new DataGridView();
            聯絡日期 = new DataGridViewTextBoxColumn();
            內容簡述 = new DataGridViewTextBoxColumn();
            預計再訪日期 = new DataGridViewTextBoxColumn();
            工號 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            label23 = new Label();
            btnWorkRecord = new Button();
            btnQuotation = new Button();
            報價單 = new DataGridViewTextBoxColumn();
            產品編號 = new DataGridViewTextBoxColumn();
            品名規格 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            單價 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvQuotation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuotationDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorkRecord).BeginInit();
            SuspendLayout();
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Teal;
            btnModify.ForeColor = SystemColors.ButtonHighlight;
            btnModify.Location = new Point(160, 17);
            btnModify.Margin = new Padding(2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(64, 22);
            btnModify.TabIndex = 153;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 17);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 152;
            lblMode.Text = "lblMode";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1192, 25);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 154;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(48, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 155;
            label1.Text = "客戶詢問函";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 156;
            label2.Text = "詢問函日期";
            // 
            // dtRfqDate
            // 
            dtRfqDate.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtRfqDate.Location = new Point(120, 54);
            dtRfqDate.Name = "dtRfqDate";
            dtRfqDate.Size = new Size(144, 32);
            dtRfqDate.TabIndex = 157;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(304, 56);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 158;
            label3.Text = "詢問函號";
            // 
            // txtRFQNO
            // 
            txtRFQNO.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtRFQNO.Location = new Point(392, 54);
            txtRFQNO.Name = "txtRFQNO";
            txtRFQNO.Size = new Size(200, 32);
            txtRFQNO.TabIndex = 159;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RosyBrown;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(1112, 27);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 160;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtCompany.Location = new Point(120, 94);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(472, 32);
            txtCompany.TabIndex = 162;
            txtCompany.Leave += txtCompany_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 161;
            label4.Text = "客戶全稱";
            // 
            // txtAlias
            // 
            txtAlias.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtAlias.Location = new Point(120, 134);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(88, 32);
            txtAlias.TabIndex = 164;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(8, 136);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 163;
            label5.Text = "客戶簡稱";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(224, 136);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 165;
            label6.Text = "所屬業別";
            // 
            // industryCodeSelect1
            // 
            industryCodeSelect1.Location = new Point(312, 126);
            industryCodeSelect1.Margin = new Padding(2);
            industryCodeSelect1.Name = "industryCodeSelect1";
            industryCodeSelect1.Size = new Size(280, 44);
            industryCodeSelect1.TabIndex = 166;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtContact.Location = new Point(120, 174);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(176, 32);
            txtContact.TabIndex = 168;
            txtContact.Leave += txtContact_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(8, 176);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 167;
            label7.Text = "聯絡人";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtPosition.Location = new Point(392, 174);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(200, 32);
            txtPosition.TabIndex = 170;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(304, 176);
            label8.Name = "label8";
            label8.Size = new Size(48, 24);
            label8.TabIndex = 169;
            label8.Text = "職位";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtCountry.Location = new Point(392, 222);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 32);
            txtCountry.TabIndex = 174;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(304, 224);
            label9.Name = "label9";
            label9.Size = new Size(48, 24);
            label9.TabIndex = 173;
            label9.Text = "國別";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtTel.Location = new Point(120, 222);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(176, 32);
            txtTel.TabIndex = 172;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(8, 224);
            label10.Name = "label10";
            label10.Size = new Size(48, 24);
            label10.TabIndex = 171;
            label10.Text = "電話";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtEmail.Location = new Point(120, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 32);
            txtEmail.TabIndex = 176;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(8, 272);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 175;
            label11.Text = "電郵";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtMa.Location = new Point(392, 272);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(200, 32);
            txtMa.TabIndex = 178;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(304, 272);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 177;
            label12.Text = "型態分類";
            // 
            // txtEndUser
            // 
            txtEndUser.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtEndUser.Location = new Point(120, 320);
            txtEndUser.Name = "txtEndUser";
            txtEndUser.Size = new Size(176, 32);
            txtEndUser.TabIndex = 180;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(8, 328);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 179;
            label13.Text = "終端使用";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(304, 325);
            label14.Name = "label14";
            label14.Size = new Size(86, 24);
            label14.TabIndex = 181;
            label14.Text = "配合代理";
            // 
            // cboAgentList
            // 
            cboAgentList.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboAgentList.FormattingEnabled = true;
            cboAgentList.Location = new Point(393, 322);
            cboAgentList.Name = "cboAgentList";
            cboAgentList.Size = new Size(199, 32);
            cboAgentList.TabIndex = 182;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(8, 368);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 183;
            label15.Text = "業務編號";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(304, 368);
            label16.Name = "label16";
            label16.Size = new Size(86, 24);
            label16.TabIndex = 185;
            label16.Text = "開發來源";
            // 
            // salesSelect1
            // 
            salesSelect1.Location = new Point(112, 360);
            salesSelect1.Name = "salesSelect1";
            salesSelect1.Size = new Size(184, 50);
            salesSelect1.TabIndex = 186;
            // 
            // txtSource
            // 
            txtSource.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtSource.Location = new Point(392, 368);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(200, 32);
            txtSource.TabIndex = 187;
            // 
            // cboSuccessRate
            // 
            cboSuccessRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSuccessRate.FormattingEnabled = true;
            cboSuccessRate.Items.AddRange(new object[] { "0%", "20%", "40%", "60%", "85%" });
            cboSuccessRate.Location = new Point(120, 424);
            cboSuccessRate.Name = "cboSuccessRate";
            cboSuccessRate.Size = new Size(121, 32);
            cboSuccessRate.TabIndex = 188;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(8, 430);
            label17.Name = "label17";
            label17.Size = new Size(67, 24);
            label17.TabIndex = 189;
            label17.Text = "成交率";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(304, 424);
            label18.Name = "label18";
            label18.Size = new Size(48, 24);
            label18.TabIndex = 190;
            label18.Text = "機台";
            // 
            // txtMachine
            // 
            txtMachine.Font = new Font("Microsoft JhengHei UI", 14.25F);
            txtMachine.Location = new Point(392, 424);
            txtMachine.Name = "txtMachine";
            txtMachine.Size = new Size(200, 32);
            txtMachine.TabIndex = 191;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label19.Location = new Point(8, 480);
            label19.Name = "label19";
            label19.Size = new Size(48, 24);
            label19.TabIndex = 192;
            label19.Text = "狀態";
            // 
            // rfqStatusSelect1
            // 
            rfqStatusSelect1.Location = new Point(112, 472);
            rfqStatusSelect1.Name = "rfqStatusSelect1";
            rfqStatusSelect1.Size = new Size(480, 47);
            rfqStatusSelect1.TabIndex = 193;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label20.Location = new Point(8, 528);
            label20.Name = "label20";
            label20.Size = new Size(48, 24);
            label20.TabIndex = 194;
            label20.Text = "備註";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtComment.Location = new Point(120, 528);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(472, 32);
            txtComment.TabIndex = 195;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1041, 27);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 22);
            btnDelete.TabIndex = 196;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Lime;
            label21.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label21.Location = new Point(616, 56);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(105, 24);
            label21.TabIndex = 197;
            label21.Text = "客戶報價單";
            // 
            // dgvQuotation
            // 
            dgvQuotation.AllowUserToAddRows = false;
            dgvQuotation.AllowUserToDeleteRows = false;
            dgvQuotation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuotation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotation.Columns.AddRange(new DataGridViewColumn[] { 報價單號, 報價單日期 });
            dgvQuotation.Location = new Point(624, 96);
            dgvQuotation.Name = "dgvQuotation";
            dgvQuotation.Size = new Size(560, 150);
            dgvQuotation.TabIndex = 198;
            dgvQuotation.CellContentDoubleClick += dgvQuotation_CellContentDoubleClick;
            // 
            // 報價單號
            // 
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // 報價單日期
            // 
            報價單日期.HeaderText = "報價單日期";
            報價單日期.Name = "報價單日期";
            報價單日期.ReadOnly = true;
            // 
            // dgvQuotationDetail
            // 
            dgvQuotationDetail.AllowUserToAddRows = false;
            dgvQuotationDetail.AllowUserToDeleteRows = false;
            dgvQuotationDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuotationDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotationDetail.Columns.AddRange(new DataGridViewColumn[] { 報價單, 產品編號, 品名規格, 數量, 單價, 金額 });
            dgvQuotationDetail.Location = new Point(624, 296);
            dgvQuotationDetail.Name = "dgvQuotationDetail";
            dgvQuotationDetail.Size = new Size(560, 150);
            dgvQuotationDetail.TabIndex = 200;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Lime;
            label22.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(616, 256);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(143, 24);
            label22.TabIndex = 199;
            label22.Text = "客戶報價單細目";
            // 
            // dgvWorkRecord
            // 
            dgvWorkRecord.AllowUserToAddRows = false;
            dgvWorkRecord.AllowUserToDeleteRows = false;
            dgvWorkRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkRecord.Columns.AddRange(new DataGridViewColumn[] { 聯絡日期, 內容簡述, 預計再訪日期, 工號, 姓名 });
            dgvWorkRecord.Location = new Point(624, 496);
            dgvWorkRecord.Name = "dgvWorkRecord";
            dgvWorkRecord.Size = new Size(560, 232);
            dgvWorkRecord.TabIndex = 202;
            // 
            // 聯絡日期
            // 
            聯絡日期.HeaderText = "聯絡日期";
            聯絡日期.Name = "聯絡日期";
            聯絡日期.ReadOnly = true;
            // 
            // 內容簡述
            // 
            內容簡述.HeaderText = "內容簡述";
            內容簡述.Name = "內容簡述";
            內容簡述.ReadOnly = true;
            // 
            // 預計再訪日期
            // 
            預計再訪日期.HeaderText = "預計再訪日期";
            預計再訪日期.Name = "預計再訪日期";
            預計再訪日期.ReadOnly = true;
            // 
            // 工號
            // 
            工號.HeaderText = "工號";
            工號.Name = "工號";
            工號.ReadOnly = true;
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.Name = "姓名";
            姓名.ReadOnly = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Lime;
            label23.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label23.Location = new Point(616, 456);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(143, 24);
            label23.TabIndex = 201;
            label23.Text = "詢問函追蹤紀錄";
            // 
            // btnWorkRecord
            // 
            btnWorkRecord.BackColor = Color.DarkCyan;
            btnWorkRecord.ForeColor = SystemColors.ButtonHighlight;
            btnWorkRecord.Location = new Point(808, 27);
            btnWorkRecord.Margin = new Padding(2);
            btnWorkRecord.Name = "btnWorkRecord";
            btnWorkRecord.Size = new Size(128, 22);
            btnWorkRecord.TabIndex = 203;
            btnWorkRecord.Text = "撰寫詢問追蹤函紀錄";
            btnWorkRecord.UseVisualStyleBackColor = false;
            btnWorkRecord.Click += btnWorkRecord_Click;
            // 
            // btnQuotation
            // 
            btnQuotation.BackColor = Color.IndianRed;
            btnQuotation.ForeColor = SystemColors.ButtonHighlight;
            btnQuotation.Location = new Point(953, 26);
            btnQuotation.Name = "btnQuotation";
            btnQuotation.Size = new Size(75, 23);
            btnQuotation.TabIndex = 204;
            btnQuotation.Text = "新增報價單";
            btnQuotation.UseVisualStyleBackColor = false;
            // 
            // 報價單
            // 
            報價單.HeaderText = "報價單";
            報價單.Name = "報價單";
            報價單.ReadOnly = true;
            // 
            // 產品編號
            // 
            產品編號.HeaderText = "產品編號";
            產品編號.Name = "產品編號";
            產品編號.ReadOnly = true;
            // 
            // 品名規格
            // 
            品名規格.HeaderText = "品名規格";
            品名規格.Name = "品名規格";
            品名規格.ReadOnly = true;
            // 
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.Name = "數量";
            數量.ReadOnly = true;
            // 
            // 單價
            // 
            單價.HeaderText = "單價";
            單價.Name = "單價";
            單價.ReadOnly = true;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            金額.ReadOnly = true;
            // 
            // RFQMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnQuotation);
            Controls.Add(btnWorkRecord);
            Controls.Add(dgvWorkRecord);
            Controls.Add(label23);
            Controls.Add(dgvQuotationDetail);
            Controls.Add(label22);
            Controls.Add(dgvQuotation);
            Controls.Add(label21);
            Controls.Add(btnDelete);
            Controls.Add(txtComment);
            Controls.Add(label20);
            Controls.Add(rfqStatusSelect1);
            Controls.Add(label19);
            Controls.Add(txtMachine);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(cboSuccessRate);
            Controls.Add(txtSource);
            Controls.Add(salesSelect1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(cboAgentList);
            Controls.Add(label14);
            Controls.Add(txtEndUser);
            Controls.Add(label13);
            Controls.Add(txtMa);
            Controls.Add(label12);
            Controls.Add(txtEmail);
            Controls.Add(label11);
            Controls.Add(txtCountry);
            Controls.Add(label9);
            Controls.Add(txtTel);
            Controls.Add(label10);
            Controls.Add(txtPosition);
            Controls.Add(label8);
            Controls.Add(txtContact);
            Controls.Add(label7);
            Controls.Add(industryCodeSelect1);
            Controls.Add(label6);
            Controls.Add(txtAlias);
            Controls.Add(label5);
            Controls.Add(txtCompany);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(txtRFQNO);
            Controls.Add(label3);
            Controls.Add(dtRfqDate);
            Controls.Add(label2);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnModify);
            Name = "RFQMaintainControl";
            Size = new Size(1223, 750);
            Load += RFQMaintainControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuotation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuotationDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorkRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RFQStatusSelect rfqStatusSelect;
        private Button btnWorkRecord;
        private Label lblMode;
        private Button button1;
        private Label label1;
        private Label label2;
        private CommonDateTimePicker dtRfqDate;
        private Label label3;
        private CommonTextBox txtRFQNO;
        private Button btnSubmit;
        private Button btnModify;
        private CommonTextBox txtCompany;
        private Label label4;
        private CommonTextBox txtAlias;
        private Label label5;
        private Label label6;
        private Common.IndustryCodeSelect industryCodeSelect1;
        private CommonTextBox txtContact;
        private Label label7;
        private CommonTextBox txtPosition;
        private Label label8;
        private CommonTextBox txtCountry;
        private Label label9;
        private CommonTextBox txtTel;
        private Label label10;
        private CommonTextBox txtEmail;
        private Label label11;
        private CommonTextBox txtMa;
        private Label label12;
        private CommonTextBox txtEndUser;
        private Label label13;
        private Label label14;
        private CommonComboBox cboAgentList;
        private Label label15;
        private Label label16;
        private Common.SalesSelect salesSelect1;
        private CommonTextBox txtSource;
        private CommonComboBox cboSuccessRate;
        private Label label17;
        private Label label18;
        private CommonTextBox txtMachine;
        private Label label19;
        private RFQStatusSelect rfqStatusSelect1;
        private Label label20;
        private CommonTextBox txtComment;
        private Button btnDelete;
        private Label label21;
        private DataGridView dgvQuotation;
        private DataGridView dgvQuotationDetail;
        private Label label22;
        private DataGridView dgvWorkRecord;
        private Label label23;
        private DataGridViewTextBoxColumn 報價單號;
        private DataGridViewTextBoxColumn 報價單日期;
        private DataGridViewTextBoxColumn 聯絡日期;
        private DataGridViewTextBoxColumn 內容簡述;
        private DataGridViewTextBoxColumn 預計再訪日期;
        private DataGridViewTextBoxColumn 工號;
        private DataGridViewTextBoxColumn 姓名;
        private Button btnQuotation;
        private DataGridViewTextBoxColumn 報價單;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 品名規格;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 單價;
        private DataGridViewTextBoxColumn 金額;
    }
}
