namespace DigiERP.UserControl.Common
{
    partial class IndustryCodeSelect : System.Windows.Forms.UserControl
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
            cboIndustry.Location = new Point(16, 8);
            cboIndustry.Name = "cboIndustry";
            cboIndustry.Size = new Size(182, 44);
            cboIndustry.TabIndex = 0;
            cboIndustry.Click += cboIndustry_Click;
            cboIndustry.Leave += cboIndustry_Leave;
            // 
            // lblIndustryCodeDesc
            // 
            lblIndustryCodeDesc.AutoSize = true;
            lblIndustryCodeDesc.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblIndustryCodeDesc.Location = new Point(208, 8);
            lblIndustryCodeDesc.Name = "lblIndustryCodeDesc";
            lblIndustryCodeDesc.Size = new Size(120, 36);
            lblIndustryCodeDesc.TabIndex = 1;
            lblIndustryCodeDesc.Text = "               ";
            // 
            // IndustryCodeSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIndustryCodeDesc);
            Controls.Add(cboIndustry);
            Name = "IndustryCodeSelect";
            Size = new Size(861, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboIndustry;
        private Label lblIndustryCodeDesc;
    }
}
