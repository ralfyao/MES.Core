namespace DigiERP.UserControl.Common
{
    partial class PriceCondControl
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
            lblPriceCond = new TextBox();
            cboPriceCond = new DigiERP.Common.CommonComboBox();
            SuspendLayout();
            // 
            // lblPriceCond
            // 
            lblPriceCond.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblPriceCond.Location = new Point(8, 48);
            lblPriceCond.Name = "lblPriceCond";
            lblPriceCond.Size = new Size(320, 32);
            lblPriceCond.TabIndex = 194;
            lblPriceCond.Text = "lblPriceCond";
            lblPriceCond.Click += lblPriceCond_Click;
            // 
            // cboPriceCond
            // 
            cboPriceCond.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboPriceCond.FormattingEnabled = true;
            cboPriceCond.Location = new Point(8, 8);
            cboPriceCond.Name = "cboPriceCond";
            cboPriceCond.Size = new Size(182, 32);
            cboPriceCond.TabIndex = 193;
            cboPriceCond.SelectedIndexChanged += cboPriceCond_SelectedIndexChanged;
            // 
            // PriceCondControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPriceCond);
            Controls.Add(cboPriceCond);
            Name = "PriceCondControl";
            Size = new Size(426, 82);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblPriceCond;
        private DigiERP.Common.CommonComboBox cboPriceCond;
    }
}
