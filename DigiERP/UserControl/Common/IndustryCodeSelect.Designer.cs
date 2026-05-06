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
            label1 = new Label();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(208, 8);
            label1.Name = "label1";
            label1.Size = new Size(290, 36);
            label1.TabIndex = 1;
            label1.Text = "lblIndustryCodeDesc";
            // 
            // IndustryCodeSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(cboIndustry);
            Name = "IndustryCodeSelect";
            Size = new Size(798, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboIndustry;
        private Label label1;
    }
}
