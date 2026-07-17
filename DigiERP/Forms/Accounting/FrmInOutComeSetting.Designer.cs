using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class FrmInOutComeSetting
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colPayType = new DataGridViewComboBoxColumn();
            colAccountCode = new DataGridViewComboBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnSave = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 460);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colItemNo, colItemName, colPayType, colAccountCode, colDesc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 460);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colId
            // 
            colId.HeaderText = "識別";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colItemNo
            // 
            colItemNo.HeaderText = "項目編號";
            colItemNo.Name = "colItemNo";
            // 
            // colItemName
            // 
            colItemName.FillWeight = 150F;
            colItemName.HeaderText = "項目名稱";
            colItemName.Name = "colItemName";
            // 
            // colPayType
            // 
            colPayType.HeaderText = "收付別";
            colPayType.Name = "colPayType";
            // 
            // colAccountCode
            // 
            colAccountCode.HeaderText = "會科代碼";
            colAccountCode.Name = "colAccountCode";
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "說明";
            colDesc.Name = "colDesc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 48);
            panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(320, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(500, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmInOutComeSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 508);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmInOutComeSetting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "收支項目設定";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewComboBoxColumn colPayType;
        private DataGridViewComboBoxColumn colAccountCode;
        private DataGridViewTextBoxColumn colDesc;
        private Panel panel2;
        private Button btnSave;
        private Button btnExit;
    }
}
