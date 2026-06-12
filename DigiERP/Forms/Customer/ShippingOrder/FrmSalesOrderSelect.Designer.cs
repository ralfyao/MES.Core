namespace DigiERP.Forms.Customer.ShippingOrder
{
    partial class FrmSalesOrderSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProductNo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            SalesOrderNo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ProductNo, ProductName, Qty, Unit, UnitPrice, SalesOrderNo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(947, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "識別";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // ProductNo
            // 
            ProductNo.HeaderText = "產品編號";
            ProductNo.Name = "ProductNo";
            ProductNo.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "品名規格";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "訂單數量";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.HeaderText = "單位";
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "單價";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // SalesOrderNo
            // 
            SalesOrderNo.HeaderText = "訂單編號";
            SalesOrderNo.Name = "SalesOrderNo";
            SalesOrderNo.ReadOnly = true;
            // 
            // FrmSalesOrderSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 343);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "FrmSalesOrderSelect";
            Text = "訂單分配";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProductNo;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn SalesOrderNo;
    }
}