namespace DigiERP.UserControl.Customer.Receivables
{
    partial class ReceivableMaintainControl
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
            lblMode = new Label();
            label1 = new Label();
            btnReceive = new Button();
            btnSubpoena = new Button();
            btnImportDetail = new Button();
            btnDelete = new Button();
            btnActivate = new Button();
            btnCancelActivate = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            label2 = new Label();
            dt收款日 = new DigiERP.Common.CommonDateTimePicker();
            label3 = new Label();
            txt單號 = new DigiERP.Common.CommonTextBox();
            label4 = new Label();
            cbo收款類別 = new DigiERP.Common.CommonComboBox();
            txt憑證種類 = new DigiERP.Common.CommonTextBox();
            label5 = new Label();
            label6 = new Label();
            dt發票日期 = new DigiERP.Common.CommonDateTimePicker();
            txt未稅金額 = new DigiERP.Common.CommonTextBox();
            label7 = new Label();
            label8 = new Label();
            txt客戶編號 = new DigiERP.Common.CommonTextBox();
            btnCustSearch = new Button();
            txt客戶名稱 = new DigiERP.Common.CommonTextBox();
            label9 = new Label();
            txt發票號碼 = new DigiERP.Common.CommonTextBox();
            label10 = new Label();
            txt收票金額 = new DigiERP.Common.CommonTextBox();
            label11 = new Label();
            txt會計傳票 = new DigiERP.Common.CommonTextBox();
            label12 = new Label();
            label13 = new Label();
            cbo幣別 = new DigiERP.Common.CommonComboBox();
            txt匯率 = new DigiERP.Common.CommonTextBox();
            label14 = new Label();
            txt收款單號 = new DigiERP.Common.CommonTextBox();
            label15 = new Label();
            btn單筆收款 = new Button();
            label16 = new Label();
            chk結案 = new CheckBox();
            txt備註 = new DigiERP.Common.CommonTextBox();
            label17 = new Label();
            txtTotalAmount = new DigiERP.Common.CommonTextBox();
            label18 = new Label();
            dataGridView1 = new DataGridView();
            AccountSource = new DataGridViewComboBoxColumn();
            WriteOffCode = new DataGridViewComboBoxColumn();
            OriCurrencyAmount = new DataGridViewTextBoxColumn();
            NTDAmount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProjectNo = new DataGridViewTextBoxColumn();
            label19 = new Label();
            label20 = new Label();
            lbl原幣收帳金額 = new Label();
            lbl台幣換算金額 = new Label();
            lbl財務覆核 = new Label();
            label23 = new Label();
            lbl財務覆核日 = new Label();
            lbl修改日期 = new Label();
            lbl修改人員 = new Label();
            label25 = new Label();
            lbl建立日期 = new Label();
            lbl建立人員 = new Label();
            label26 = new Label();
            btnModify = new Button();
            btn送出 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(4, 4);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 160;
            lblMode.Text = "lblMode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(61, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 161;
            label1.Text = "應收款";
            // 
            // btnReceive
            // 
            btnReceive.BackColor = Color.ForestGreen;
            btnReceive.ForeColor = SystemColors.ButtonHighlight;
            btnReceive.Location = new Point(552, 4);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(80, 24);
            btnReceive.TabIndex = 162;
            btnReceive.Text = "出納收款";
            btnReceive.UseVisualStyleBackColor = false;
            // 
            // btnSubpoena
            // 
            btnSubpoena.BackColor = SystemColors.ControlDark;
            btnSubpoena.ForeColor = SystemColors.ButtonHighlight;
            btnSubpoena.Location = new Point(640, 4);
            btnSubpoena.Name = "btnSubpoena";
            btnSubpoena.Size = new Size(80, 24);
            btnSubpoena.TabIndex = 163;
            btnSubpoena.Text = "會計傳票";
            btnSubpoena.UseVisualStyleBackColor = false;
            // 
            // btnImportDetail
            // 
            btnImportDetail.BackColor = Color.DodgerBlue;
            btnImportDetail.ForeColor = SystemColors.ButtonHighlight;
            btnImportDetail.Location = new Point(732, 4);
            btnImportDetail.Name = "btnImportDetail";
            btnImportDetail.Size = new Size(104, 24);
            btnImportDetail.TabIndex = 164;
            btnImportDetail.Text = "收款明細導入";
            btnImportDetail.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(844, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 24);
            btnDelete.TabIndex = 165;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = SystemColors.ControlDark;
            btnActivate.ForeColor = SystemColors.ButtonHighlight;
            btnActivate.Location = new Point(932, 4);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(80, 24);
            btnActivate.TabIndex = 166;
            btnActivate.Text = "覆核";
            btnActivate.UseVisualStyleBackColor = false;
            // 
            // btnCancelActivate
            // 
            btnCancelActivate.BackColor = SystemColors.ControlDark;
            btnCancelActivate.ForeColor = SystemColors.ButtonHighlight;
            btnCancelActivate.Location = new Point(1020, 4);
            btnCancelActivate.Name = "btnCancelActivate";
            btnCancelActivate.Size = new Size(80, 24);
            btnCancelActivate.TabIndex = 167;
            btnCancelActivate.Text = "取消覆核";
            btnCancelActivate.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ControlDark;
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(1108, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 24);
            btnPrint.TabIndex = 168;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1396, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 169;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(8, 44);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 170;
            label2.Text = "日期";
            // 
            // dt收款日
            // 
            dt收款日.CalendarFont = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dt收款日.Enabled = false;
            dt收款日.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dt收款日.Location = new Point(64, 40);
            dt收款日.Name = "dt收款日";
            dt收款日.Size = new Size(172, 32);
            dt收款日.TabIndex = 171;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(252, 44);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 172;
            label3.Text = "單號";
            // 
            // txt單號
            // 
            txt單號.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt單號.Location = new Point(304, 40);
            txt單號.Name = "txt單號";
            txt單號.ReadOnly = true;
            txt單號.Size = new Size(168, 32);
            txt單號.TabIndex = 173;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(484, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 174;
            label4.Text = "收款類別";
            // 
            // cbo收款類別
            // 
            cbo收款類別.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo收款類別.FormattingEnabled = true;
            cbo收款類別.Items.AddRange(new object[] { "", "訂金", "期約", "裝機", "驗機", "出貨", "交機", "售後", "零件", "服務", "其他" });
            cbo收款類別.Location = new Point(576, 40);
            cbo收款類別.Name = "cbo收款類別";
            cbo收款類別.Size = new Size(121, 32);
            cbo收款類別.TabIndex = 175;
            // 
            // txt憑證種類
            // 
            txt憑證種類.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt憑證種類.Location = new Point(800, 40);
            txt憑證種類.Name = "txt憑證種類";
            txt憑證種類.Size = new Size(96, 32);
            txt憑證種類.TabIndex = 177;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(708, 44);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 176;
            label5.Text = "憑證種類";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(908, 44);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 178;
            label6.Text = "發票日期";
            // 
            // dt發票日期
            // 
            dt發票日期.CalendarFont = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dt發票日期.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dt發票日期.Location = new Point(996, 40);
            dt發票日期.Name = "dt發票日期";
            dt發票日期.Size = new Size(188, 32);
            dt發票日期.TabIndex = 179;
            // 
            // txt未稅金額
            // 
            txt未稅金額.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt未稅金額.Location = new Point(1284, 40);
            txt未稅金額.Name = "txt未稅金額";
            txt未稅金額.Size = new Size(132, 32);
            txt未稅金額.TabIndex = 181;
            txt未稅金額.Text = "0";
            txt未稅金額.Leave += txt未稅金額_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(1192, 44);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 180;
            label7.Text = "未稅金額";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(8, 84);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 182;
            label8.Text = "客戶編號";
            // 
            // txt客戶編號
            // 
            txt客戶編號.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt客戶編號.Location = new Point(104, 80);
            txt客戶編號.Name = "txt客戶編號";
            txt客戶編號.ReadOnly = true;
            txt客戶編號.Size = new Size(132, 32);
            txt客戶編號.TabIndex = 183;
            // 
            // btnCustSearch
            // 
            btnCustSearch.Image = Properties.Resources.search_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            btnCustSearch.Location = new Point(244, 76);
            btnCustSearch.Name = "btnCustSearch";
            btnCustSearch.Size = new Size(52, 36);
            btnCustSearch.TabIndex = 184;
            btnCustSearch.UseVisualStyleBackColor = true;
            btnCustSearch.Click += btnCustSearch_Click;
            // 
            // txt客戶名稱
            // 
            txt客戶名稱.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt客戶名稱.Location = new Point(404, 80);
            txt客戶名稱.Name = "txt客戶名稱";
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.Size = new Size(492, 32);
            txt客戶名稱.TabIndex = 186;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(308, 84);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 185;
            label9.Text = "客戶名稱";
            // 
            // txt發票號碼
            // 
            txt發票號碼.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt發票號碼.Location = new Point(996, 80);
            txt發票號碼.Name = "txt發票號碼";
            txt發票號碼.Size = new Size(188, 32);
            txt發票號碼.TabIndex = 188;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(908, 84);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 187;
            label10.Text = "發票號碼";
            // 
            // txt收票金額
            // 
            txt收票金額.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt收票金額.Location = new Point(1280, 82);
            txt收票金額.Name = "txt收票金額";
            txt收票金額.Size = new Size(136, 32);
            txt收票金額.TabIndex = 190;
            txt收票金額.Text = "0";
            txt收票金額.Leave += txt收票金額_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(1196, 84);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 189;
            label11.Text = "稅額";
            // 
            // txt會計傳票
            // 
            txt會計傳票.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt會計傳票.Location = new Point(104, 124);
            txt會計傳票.Name = "txt會計傳票";
            txt會計傳票.Size = new Size(132, 32);
            txt會計傳票.TabIndex = 192;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(8, 128);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 191;
            label12.Text = "會計傳票";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(248, 128);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 193;
            label13.Text = "幣別";
            // 
            // cbo幣別
            // 
            cbo幣別.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbo幣別.FormattingEnabled = true;
            cbo幣別.Items.AddRange(new object[] { "", "訂金", "期約", "裝機", "驗機", "出貨", "交機", "售後", "零件", "服務", "其他" });
            cbo幣別.Location = new Point(304, 124);
            cbo幣別.Name = "cbo幣別";
            cbo幣別.Size = new Size(96, 32);
            cbo幣別.TabIndex = 194;
            cbo幣別.SelectedIndexChanged += cbo幣別_SelectedIndexChanged;
            // 
            // txt匯率
            // 
            txt匯率.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt匯率.Location = new Point(468, 124);
            txt匯率.Name = "txt匯率";
            txt匯率.ReadOnly = true;
            txt匯率.Size = new Size(96, 32);
            txt匯率.TabIndex = 196;
            txt匯率.Text = "1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(412, 128);
            label14.Name = "label14";
            label14.Size = new Size(48, 24);
            label14.TabIndex = 195;
            label14.Text = "匯率";
            // 
            // txt收款單號
            // 
            txt收款單號.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt收款單號.Location = new Point(668, 124);
            txt收款單號.Name = "txt收款單號";
            txt收款單號.Size = new Size(136, 32);
            txt收款單號.TabIndex = 198;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(576, 128);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 197;
            label15.Text = "收款單號";
            // 
            // btn單筆收款
            // 
            btn單筆收款.BackColor = Color.DarkOrange;
            btn單筆收款.ForeColor = SystemColors.ButtonHighlight;
            btn單筆收款.Location = new Point(816, 128);
            btn單筆收款.Name = "btn單筆收款";
            btn單筆收款.Size = new Size(80, 24);
            btn單筆收款.TabIndex = 199;
            btn單筆收款.Text = "單筆收款";
            btn單筆收款.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(912, 128);
            label16.Name = "label16";
            label16.Size = new Size(48, 24);
            label16.TabIndex = 200;
            label16.Text = "結案";
            // 
            // chk結案
            // 
            chk結案.AutoSize = true;
            chk結案.Location = new Point(976, 132);
            chk結案.Name = "chk結案";
            chk結案.Size = new Size(15, 14);
            chk結案.TabIndex = 201;
            chk結案.UseVisualStyleBackColor = true;
            chk結案.CheckedChanged += chk結案_CheckedChanged;
            // 
            // txt備註
            // 
            txt備註.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt備註.Location = new Point(1052, 124);
            txt備註.Name = "txt備註";
            txt備註.Size = new Size(140, 32);
            txt備註.TabIndex = 203;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(1000, 128);
            label17.Name = "label17";
            label17.Size = new Size(48, 24);
            label17.TabIndex = 202;
            label17.Text = "帳期";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtTotalAmount.Location = new Point(1280, 124);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(136, 32);
            txtTotalAmount.TabIndex = 205;
            txtTotalAmount.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(1196, 128);
            label18.Name = "label18";
            label18.Size = new Size(48, 24);
            label18.TabIndex = 204;
            label18.Text = "總額";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AccountSource, WriteOffCode, OriCurrencyAmount, NTDAmount, Description, ProjectNo });
            dataGridView1.Location = new Point(16, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1396, 480);
            dataGridView1.TabIndex = 206;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // AccountSource
            // 
            AccountSource.HeaderText = "帳款來源";
            AccountSource.Name = "AccountSource";
            // 
            // WriteOffCode
            // 
            WriteOffCode.HeaderText = "沖銷碼";
            WriteOffCode.Name = "WriteOffCode";
            // 
            // OriCurrencyAmount
            // 
            OriCurrencyAmount.HeaderText = "原幣金額";
            OriCurrencyAmount.Name = "OriCurrencyAmount";
            // 
            // NTDAmount
            // 
            NTDAmount.HeaderText = "台幣換算金額";
            NTDAmount.Name = "NTDAmount";
            NTDAmount.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "說明";
            Description.Name = "Description";
            // 
            // ProjectNo
            // 
            ProjectNo.HeaderText = "專案序號";
            ProjectNo.Name = "ProjectNo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label19.Location = new Point(12, 664);
            label19.Name = "label19";
            label19.Size = new Size(124, 24);
            label19.TabIndex = 207;
            label19.Text = "原幣收帳金額";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label20.Location = new Point(12, 700);
            label20.Name = "label20";
            label20.Size = new Size(124, 24);
            label20.TabIndex = 208;
            label20.Text = "台幣換算金額";
            // 
            // lbl原幣收帳金額
            // 
            lbl原幣收帳金額.AutoSize = true;
            lbl原幣收帳金額.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl原幣收帳金額.Location = new Point(172, 664);
            lbl原幣收帳金額.Name = "lbl原幣收帳金額";
            lbl原幣收帳金額.Size = new Size(146, 24);
            lbl原幣收帳金額.TabIndex = 209;
            lbl原幣收帳金額.Text = "lbl原幣收帳金額";
            // 
            // lbl台幣換算金額
            // 
            lbl台幣換算金額.AutoSize = true;
            lbl台幣換算金額.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl台幣換算金額.Location = new Point(172, 700);
            lbl台幣換算金額.Name = "lbl台幣換算金額";
            lbl台幣換算金額.Size = new Size(146, 24);
            lbl台幣換算金額.TabIndex = 210;
            lbl台幣換算金額.Text = "lbl台幣換算金額";
            // 
            // lbl財務覆核
            // 
            lbl財務覆核.AutoSize = true;
            lbl財務覆核.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl財務覆核.Location = new Point(108, 820);
            lbl財務覆核.Name = "lbl財務覆核";
            lbl財務覆核.Size = new Size(108, 24);
            lbl財務覆核.TabIndex = 212;
            lbl財務覆核.Text = "lbl財務覆核";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label23.Location = new Point(8, 820);
            label23.Name = "label23";
            label23.Size = new Size(86, 24);
            label23.TabIndex = 211;
            label23.Text = "財務覆核";
            // 
            // lbl財務覆核日
            // 
            lbl財務覆核日.AutoSize = true;
            lbl財務覆核日.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl財務覆核日.Location = new Point(228, 820);
            lbl財務覆核日.Name = "lbl財務覆核日";
            lbl財務覆核日.Size = new Size(127, 24);
            lbl財務覆核日.TabIndex = 213;
            lbl財務覆核日.Text = "lbl財務覆核日";
            // 
            // lbl修改日期
            // 
            lbl修改日期.AutoSize = true;
            lbl修改日期.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl修改日期.Location = new Point(768, 820);
            lbl修改日期.Name = "lbl修改日期";
            lbl修改日期.Size = new Size(108, 24);
            lbl修改日期.TabIndex = 216;
            lbl修改日期.Text = "lbl修改日期";
            // 
            // lbl修改人員
            // 
            lbl修改人員.AutoSize = true;
            lbl修改人員.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl修改人員.Location = new Point(648, 820);
            lbl修改人員.Name = "lbl修改人員";
            lbl修改人員.Size = new Size(108, 24);
            lbl修改人員.TabIndex = 215;
            lbl修改人員.Text = "lbl修改人員";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label25.Location = new Point(548, 820);
            label25.Name = "label25";
            label25.Size = new Size(86, 24);
            label25.TabIndex = 214;
            label25.Text = "修改人員";
            // 
            // lbl建立日期
            // 
            lbl建立日期.AutoSize = true;
            lbl建立日期.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl建立日期.Location = new Point(1296, 820);
            lbl建立日期.Name = "lbl建立日期";
            lbl建立日期.Size = new Size(108, 24);
            lbl建立日期.TabIndex = 219;
            lbl建立日期.Text = "lbl建立日期";
            // 
            // lbl建立人員
            // 
            lbl建立人員.AutoSize = true;
            lbl建立人員.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl建立人員.Location = new Point(1176, 820);
            lbl建立人員.Name = "lbl建立人員";
            lbl建立人員.Size = new Size(108, 24);
            lbl建立人員.TabIndex = 218;
            lbl建立人員.Text = "lbl建立人員";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label26.Location = new Point(1076, 820);
            label26.Name = "label26";
            label26.Size = new Size(86, 24);
            label26.TabIndex = 217;
            label26.Text = "建立人員";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Red;
            btnModify.ForeColor = SystemColors.ButtonHighlight;
            btnModify.Location = new Point(136, 5);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 24);
            btnModify.TabIndex = 220;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btn送出
            // 
            btn送出.BackColor = Color.Goldenrod;
            btn送出.ForeColor = SystemColors.ButtonHighlight;
            btn送出.Location = new Point(1300, 8);
            btn送出.Name = "btn送出";
            btn送出.Size = new Size(80, 24);
            btn送出.TabIndex = 221;
            btn送出.Text = "送出";
            btn送出.UseVisualStyleBackColor = false;
            btn送出.Click += btn送出_Click;
            // 
            // ReceivableMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn送出);
            Controls.Add(btnModify);
            Controls.Add(lbl建立日期);
            Controls.Add(lbl建立人員);
            Controls.Add(label26);
            Controls.Add(lbl修改日期);
            Controls.Add(lbl修改人員);
            Controls.Add(label25);
            Controls.Add(lbl財務覆核日);
            Controls.Add(lbl財務覆核);
            Controls.Add(label23);
            Controls.Add(lbl台幣換算金額);
            Controls.Add(lbl原幣收帳金額);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(dataGridView1);
            Controls.Add(txtTotalAmount);
            Controls.Add(label18);
            Controls.Add(txt備註);
            Controls.Add(label17);
            Controls.Add(chk結案);
            Controls.Add(label16);
            Controls.Add(btn單筆收款);
            Controls.Add(txt收款單號);
            Controls.Add(label15);
            Controls.Add(txt匯率);
            Controls.Add(label14);
            Controls.Add(cbo幣別);
            Controls.Add(label13);
            Controls.Add(txt會計傳票);
            Controls.Add(label12);
            Controls.Add(txt收票金額);
            Controls.Add(label11);
            Controls.Add(txt發票號碼);
            Controls.Add(label10);
            Controls.Add(txt客戶名稱);
            Controls.Add(label9);
            Controls.Add(btnCustSearch);
            Controls.Add(txt客戶編號);
            Controls.Add(label8);
            Controls.Add(txt未稅金額);
            Controls.Add(label7);
            Controls.Add(dt發票日期);
            Controls.Add(label6);
            Controls.Add(txt憑證種類);
            Controls.Add(label5);
            Controls.Add(cbo收款類別);
            Controls.Add(label4);
            Controls.Add(txt單號);
            Controls.Add(label3);
            Controls.Add(dt收款日);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnCancelActivate);
            Controls.Add(btnActivate);
            Controls.Add(btnDelete);
            Controls.Add(btnImportDetail);
            Controls.Add(btnSubpoena);
            Controls.Add(btnReceive);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Name = "ReceivableMaintainControl";
            Size = new Size(1432, 868);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private Label label1;
        private Button btnReceive;
        private Button btnSubpoena;
        private Button btnImportDetail;
        private Button btnDelete;
        private Button btnActivate;
        private Button btnCancelActivate;
        private Button btnPrint;
        private Button btnClose;
        private Label label2;
        private DigiERP.Common.CommonDateTimePicker dt收款日;
        private Label label3;
        private DigiERP.Common.CommonTextBox txt單號;
        private Label label4;
        private DigiERP.Common.CommonComboBox cbo收款類別;
        private DigiERP.Common.CommonTextBox txt憑證種類;
        private Label label5;
        private Label label6;
        private DigiERP.Common.CommonDateTimePicker dt發票日期;
        private DigiERP.Common.CommonTextBox txt未稅金額;
        private Label label7;
        private Label label8;
        private DigiERP.Common.CommonTextBox txt客戶編號;
        private Button btnCustSearch;
        private DigiERP.Common.CommonTextBox txt客戶名稱;
        private Label label9;
        private DigiERP.Common.CommonTextBox txt發票號碼;
        private Label label10;
        private DigiERP.Common.CommonTextBox txt收票金額;
        private Label label11;
        private DigiERP.Common.CommonTextBox txt會計傳票;
        private Label label12;
        private Label label13;
        private DigiERP.Common.CommonComboBox cbo幣別;
        private DigiERP.Common.CommonTextBox txt匯率;
        private Label label14;
        private DigiERP.Common.CommonTextBox txt收款單號;
        private Label label15;
        private Button btn單筆收款;
        private Label label16;
        private CheckBox chk結案;
        private DigiERP.Common.CommonTextBox txt備註;
        private Label label17;
        private DigiERP.Common.CommonTextBox txtTotalAmount;
        private Label label18;
        private DataGridView dataGridView1;
        private Label label19;
        private Label label20;
        private Label lbl原幣收帳金額;
        private Label lbl台幣換算金額;
        private Label lbl財務覆核;
        private Label label23;
        private Label lbl財務覆核日;
        private Label lbl修改日期;
        private Label lbl修改人員;
        private Label label25;
        private Label lbl建立日期;
        private Label lbl建立人員;
        private Label label26;
        private Button btnModify;
        private Button btn送出;
        private DataGridViewComboBoxColumn AccountSource;
        private DataGridViewComboBoxColumn WriteOffCode;
        private DataGridViewTextBoxColumn OriCurrencyAmount;
        private DataGridViewTextBoxColumn NTDAmount;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProjectNo;
    }
}
