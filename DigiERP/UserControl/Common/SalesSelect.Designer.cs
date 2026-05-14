namespace DigiERP.UserControl.Common
{
    partial class SalesSelect
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
            cboSales = new DigiERP.Common.CommonComboBox();
            lblSalesName = new Label();
            SuspendLayout();
            // 
            // cboSales
            // 
            cboSales.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSales.FormattingEnabled = true;
            cboSales.Location = new Point(8, 8);
            cboSales.Name = "cboSales";
            cboSales.Size = new Size(64, 32);
            cboSales.TabIndex = 0;
            cboSales.SelectedIndexChanged += cboSales_SelectedIndexChanged;
            // 
            // lblSalesName
            // 
            lblSalesName.AutoSize = true;
            lblSalesName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblSalesName.Location = new Point(80, 8);
            lblSalesName.Name = "lblSalesName";
            lblSalesName.Size = new Size(132, 24);
            lblSalesName.TabIndex = 1;
            lblSalesName.Text = "lblSalesName";
            // 
            // SalesSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSalesName);
            Controls.Add(cboSales);
            Name = "SalesSelect";
            Size = new Size(301, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DigiERP.Common.CommonComboBox cboSales;
        private Label lblSalesName;
    }
}
