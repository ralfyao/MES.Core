using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmSelectWorkOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnConfirm = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(230, 230, 250);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnConfirm);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(900, 48);
            panelToolbar.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案序號選擇";
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.FromArgb(198, 216, 255);
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(760, 6);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "確定選擇";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 250);
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colMachineType, colCustomerName, colMachineModel, colMachineName });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 413);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colProjectNo
            //
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            //
            // colMachineType
            //
            colMachineType.HeaderText = "機台";
            colMachineType.Name = "colMachineType";
            colMachineType.ReadOnly = true;
            //
            // colCustomerName
            //
            colCustomerName.HeaderText = "客戶名稱";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            //
            // colMachineModel
            //
            colMachineModel.HeaderText = "機台型號";
            colMachineModel.Name = "colMachineModel";
            colMachineModel.ReadOnly = true;
            //
            // colMachineName
            //
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            //
            // FrmSelectWorkOrder
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 461);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(700, 400);
            Name = "FrmSelectWorkOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "專案序號選擇";
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnConfirm;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colMachineName;
    }
}
