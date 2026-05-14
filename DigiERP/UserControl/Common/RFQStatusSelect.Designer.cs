namespace DigiERP.UserControl.Common
{
    partial class RFQStatusSelect
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
            cboStatusSelect = new DigiERP.Common.CommonComboBox();
            lblStatusText = new Label();
            SuspendLayout();
            // 
            // cboStatusSelect
            // 
            cboStatusSelect.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboStatusSelect.FormattingEnabled = true;
            cboStatusSelect.Location = new Point(8, 8);
            cboStatusSelect.Name = "cboStatusSelect";
            cboStatusSelect.Size = new Size(121, 32);
            cboStatusSelect.TabIndex = 0;
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblStatusText.Location = new Point(136, 12);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(126, 24);
            lblStatusText.TabIndex = 1;
            lblStatusText.Text = "lblStatusText";
            // 
            // RFQStatusSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatusText);
            Controls.Add(cboStatusSelect);
            Name = "rfqStatusSelect";
            Size = new Size(580, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DigiERP.Common.CommonComboBox cboStatusSelect;
        private Label lblStatusText;
    }
}
