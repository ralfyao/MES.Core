using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class FrmSelectPurchaseRequest
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
            dgvRequest = new DataGridView();
            colProductNo = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUrgent = new DataGridViewTextBoxColumn();
            colDemandDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            SuspendLayout();
            // 
            // dgvRequest
            // 
            dgvRequest.AllowUserToAddRows = false;
            dgvRequest.AllowUserToDeleteRows = false;
            dgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequest.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequest.Columns.AddRange(new DataGridViewColumn[] { colProductNo, colSpec, colQty, colUrgent, colDemandDate });
            dgvRequest.Dock = DockStyle.Fill;
            dgvRequest.Font = new Font("微軟正黑體", 10F);
            dgvRequest.Location = new Point(0, 0);
            dgvRequest.Name = "dgvRequest";
            dgvRequest.ReadOnly = true;
            dgvRequest.RowHeadersVisible = false;
            dgvRequest.RowTemplate.Height = 26;
            dgvRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequest.Size = new Size(831, 550);
            dgvRequest.TabIndex = 0;
            dgvRequest.CellDoubleClick += dgvRequest_CellDoubleClick;
            // 
            // colProductNo
            // 
            colProductNo.FillWeight = 110F;
            colProductNo.HeaderText = "產品編號";
            colProductNo.Name = "colProductNo";
            colProductNo.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.FillWeight = 260F;
            colSpec.HeaderText = "品名規格";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.FillWeight = 90F;
            colQty.HeaderText = "請購數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colUrgent
            // 
            colUrgent.FillWeight = 60F;
            colUrgent.HeaderText = "緊急";
            colUrgent.Name = "colUrgent";
            colUrgent.ReadOnly = true;
            // 
            // colDemandDate
            // 
            colDemandDate.FillWeight = 90F;
            colDemandDate.HeaderText = "需求日期";
            colDemandDate.Name = "colDemandDate";
            colDemandDate.ReadOnly = true;
            // 
            // FrmSelectPurchaseRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 550);
            Controls.Add(dgvRequest);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(500, 300);
            Name = "FrmSelectPurchaseRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "料號選擇";
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRequest;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUrgent;
        private DataGridViewTextBoxColumn colDemandDate;
    }
}
