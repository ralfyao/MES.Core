using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ToBuy
{
    partial class ToButListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToButListControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnOpen = new Button();
            btnClosed = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colDept = new DataGridViewComboBoxColumn();
            colRequester = new DataGridViewComboBoxColumn();
            colCategory = new DataGridViewComboBoxColumn();
            colItemNo = new DataGridViewComboBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUrgent = new DataGridViewCheckBoxColumn();
            colNeedDate = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewComboBoxColumn();
            colSupplierName = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            colPoNo = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            colSerial = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "請購底稿";
            //
            // btnOpen
            //
            btnOpen.BackColor = Color.SteelBlue;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(340, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(100, 32);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "未結案";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            //
            // btnClosed
            //
            btnClosed.BackColor = Color.SeaGreen;
            btnClosed.FlatStyle = FlatStyle.Flat;
            btnClosed.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClosed.ForeColor = Color.White;
            btnClosed.Location = new Point(450, 12);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(100, 32);
            btnClosed.TabIndex = 2;
            btnClosed.Text = "已結案";
            btnClosed.UseVisualStyleBackColor = false;
            btnClosed.Click += btnClosed_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.Location = new Point(600, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 32);
            btnModify.TabIndex = 3;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(750, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(900, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colDept, colRequester, colCategory, colItemNo, colItemName, colUnit, colQty, colUrgent, colNeedDate, colPurpose, colSupplierNo, colSupplierName, colRemark, colPoNo, colClosed, colSerial });
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
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            //
            // colDate
            //
            colDate.HeaderText = "請購日期";
            colDate.Name = "colDate";
            //
            // colDept
            //
            colDept.HeaderText = "請購部門";
            colDept.Name = "colDept";
            //
            // colRequester
            //
            colRequester.HeaderText = "請購人員";
            colRequester.Name = "colRequester";
            //
            // colCategory
            //
            colCategory.HeaderText = "請購類別";
            colCategory.Name = "colCategory";
            //
            // colItemNo
            //
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            //
            // colItemName
            //
            colItemName.FillWeight = 180F;
            colItemName.HeaderText = "品名";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            //
            // colUnit
            //
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            //
            // colQty
            //
            colQty.HeaderText = "需求數量";
            colQty.Name = "colQty";
            //
            // colUrgent
            //
            colUrgent.HeaderText = "緊急";
            colUrgent.Name = "colUrgent";
            //
            // colNeedDate
            //
            colNeedDate.HeaderText = "需求日期";
            colNeedDate.Name = "colNeedDate";
            //
            // colPurpose
            //
            colPurpose.HeaderText = "用途";
            colPurpose.Name = "colPurpose";
            //
            // colSupplierNo
            //
            colSupplierNo.HeaderText = "指定廠商";
            colSupplierNo.Name = "colSupplierNo";
            //
            // colSupplierName
            //
            colSupplierName.FillWeight = 130F;
            colSupplierName.HeaderText = "廠商簡稱";
            colSupplierName.Name = "colSupplierName";
            colSupplierName.ReadOnly = true;
            //
            // colRemark
            //
            colRemark.FillWeight = 150F;
            colRemark.HeaderText = "註記";
            colRemark.Name = "colRemark";
            //
            // colPoNo
            //
            colPoNo.HeaderText = "採購單號";
            colPoNo.Name = "colPoNo";
            colPoNo.ReadOnly = true;
            //
            // colClosed
            //
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            //
            // colSerial
            //
            colSerial.HeaderText = "序號";
            colSerial.Name = "colSerial";
            colSerial.ReadOnly = true;
            //
            // ToButListControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ToButListControl";
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
        private Button btnOpen;
        private Button btnClosed;
        private Button btnModify;
        private Button btnSave;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colDept;
        private DataGridViewComboBoxColumn colRequester;
        private DataGridViewComboBoxColumn colCategory;
        private DataGridViewComboBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewCheckBoxColumn colUrgent;
        private DataGridViewTextBoxColumn colNeedDate;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewComboBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierName;
        private DataGridViewTextBoxColumn colRemark;
        private DataGridViewTextBoxColumn colPoNo;
        private DataGridViewCheckBoxColumn colClosed;
        private DataGridViewTextBoxColumn colSerial;
    }
}
