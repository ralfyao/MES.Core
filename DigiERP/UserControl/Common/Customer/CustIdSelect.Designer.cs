namespace DigiERP.UserControl.Common.Customer
{
    partial class CustIdSelect
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
            commonComboBox1 = new DigiERP.Common.CommonComboBox();
            SuspendLayout();
            // 
            // commonComboBox1
            // 
            commonComboBox1.FormattingEnabled = true;
            commonComboBox1.Location = new Point(8, 8);
            commonComboBox1.Name = "commonComboBox1";
            commonComboBox1.Size = new Size(121, 23);
            commonComboBox1.TabIndex = 0;
            // 
            // CustIdSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(commonComboBox1);
            Name = "CustIdSelect";
            Size = new Size(147, 42);
            ResumeLayout(false);
        }

        #endregion

        private DigiERP.Common.CommonComboBox commonComboBox1;
    }
}
