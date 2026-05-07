namespace DigiERP.UserControl.Common
{
    partial class BankCodeSelect : System.Windows.Forms.UserControl
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
            cboIndustry = new ComboBox();
            lblIndustryCodeDesc = new Label();
            SuspendLayout();
            // 
            // cboIndustry
            // 
            cboIndustry.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboIndustry.FormattingEnabled = true;
            cboIndustry.Location = new Point(10, 5);
            cboIndustry.Margin = new Padding(2, 2, 2, 2);
            cboIndustry.Name = "cboIndustry";
            cboIndustry.Size = new Size(117, 32);
            cboIndustry.TabIndex = 0;
            cboIndustry.Click += cboIndustry_Click;
            cboIndustry.Leave += cboIndustry_Leave;
            // 
            // lblIndustryCodeDesc
            // 
            lblIndustryCodeDesc.AutoSize = true;
            lblIndustryCodeDesc.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblIndustryCodeDesc.Location = new Point(132, 5);
            lblIndustryCodeDesc.Margin = new Padding(2, 0, 2, 0);
            lblIndustryCodeDesc.Name = "lblIndustryCodeDesc";
            lblIndustryCodeDesc.Size = new Size(85, 24);
            lblIndustryCodeDesc.TabIndex = 1;
            lblIndustryCodeDesc.Text = "               ";
            // 
            // BankCodeSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIndustryCodeDesc);
            Controls.Add(cboIndustry);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BankCodeSelect";
            Size = new Size(234, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboIndustry;
        private Label lblIndustryCodeDesc;
    }
}
