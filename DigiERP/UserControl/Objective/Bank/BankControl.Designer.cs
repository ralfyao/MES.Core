using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class BankControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblMonthEnd = new Label();
            dtMonthEnd = new DateTimePicker();
            btnMonthBalance = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colBankCode = new DataGridViewTextBoxColumn();
            colBankName = new DataGridViewTextBoxColumn();
            colBankFullName = new DataGridViewTextBoxColumn();
            colBeneficiary = new DataGridViewTextBoxColumn();
            colAccountNo = new DataGridViewTextBoxColumn();
            colSwiftCode = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colExt = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblMonthEnd);
            panel1.Controls.Add(dtMonthEnd);
            panel1.Controls.Add(btnMonthBalance);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "銀行設定總覽";
            // 
            // lblMonthEnd
            // 
            lblMonthEnd.AutoSize = true;
            lblMonthEnd.Font = new Font("微軟正黑體", 10F);
            lblMonthEnd.Location = new Point(300, 20);
            lblMonthEnd.Name = "lblMonthEnd";
            lblMonthEnd.Size = new Size(50, 18);
            lblMonthEnd.TabIndex = 1;
            lblMonthEnd.Text = "月底日";
            // 
            // dtMonthEnd
            // 
            dtMonthEnd.Format = DateTimePickerFormat.Short;
            dtMonthEnd.Location = new Point(370, 14);
            dtMonthEnd.Name = "dtMonthEnd";
            dtMonthEnd.Size = new Size(140, 25);
            dtMonthEnd.TabIndex = 2;
            // 
            // btnMonthBalance
            // 
            btnMonthBalance.BackColor = Color.Gainsboro;
            btnMonthBalance.FlatStyle = FlatStyle.Flat;
            btnMonthBalance.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnMonthBalance.Location = new Point(540, 12);
            btnMonthBalance.Name = "btnMonthBalance";
            btnMonthBalance.Size = new Size(100, 32);
            btnMonthBalance.TabIndex = 3;
            btnMonthBalance.Text = "月結餘額";
            btnMonthBalance.UseVisualStyleBackColor = false;
            btnMonthBalance.Click += btnMonthBalance_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gainsboro;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnRefresh.Location = new Point(670, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "重新整理";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1780, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1670, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBankCode, colBankName, colBankFullName, colBeneficiary, colAccountNo, colSwiftCode, colContact, colPhone, colExt });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colBankCode
            // 
            colBankCode.HeaderText = "編碼代號";
            colBankCode.Name = "colBankCode";
            colBankCode.ReadOnly = true;
            // 
            // colBankName
            // 
            colBankName.FillWeight = 150F;
            colBankName.HeaderText = "代號名稱";
            colBankName.Name = "colBankName";
            colBankName.ReadOnly = true;
            // 
            // colBankFullName
            // 
            colBankFullName.FillWeight = 220F;
            colBankFullName.HeaderText = "銀行全名";
            colBankFullName.Name = "colBankFullName";
            colBankFullName.ReadOnly = true;
            // 
            // colBeneficiary
            // 
            colBeneficiary.FillWeight = 200F;
            colBeneficiary.HeaderText = "帳戶名稱";
            colBeneficiary.Name = "colBeneficiary";
            colBeneficiary.ReadOnly = true;
            // 
            // colAccountNo
            // 
            colAccountNo.FillWeight = 150F;
            colAccountNo.HeaderText = "帳號";
            colAccountNo.Name = "colAccountNo";
            colAccountNo.ReadOnly = true;
            // 
            // colSwiftCode
            // 
            colSwiftCode.HeaderText = "SwiftCode";
            colSwiftCode.Name = "colSwiftCode";
            colSwiftCode.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.HeaderText = "聯絡窗口";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "電話";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colExt
            // 
            colExt.HeaderText = "分機";
            colExt.Name = "colExt";
            colExt.ReadOnly = true;
            // 
            // BankControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "BankControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblMonthEnd;
        private DateTimePicker dtMonthEnd;
        private Button btnMonthBalance;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colBankCode;
        private DataGridViewTextBoxColumn colBankName;
        private DataGridViewTextBoxColumn colBankFullName;
        private DataGridViewTextBoxColumn colBeneficiary;
        private DataGridViewTextBoxColumn colAccountNo;
        private DataGridViewTextBoxColumn colSwiftCode;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colExt;
    }
}
