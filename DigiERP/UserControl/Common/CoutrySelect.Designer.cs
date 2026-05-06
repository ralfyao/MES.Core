namespace DigiERP.UserControl.Common
{
    partial class CoutrySelect : System.Windows.Forms.UserControl
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
            cboCountryList = new ComboBox();
            lblCountryName = new Label();
            SuspendLayout();
            // 
            // cboCountryList
            // 
            cboCountryList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountryList.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCountryList.FormattingEnabled = true;
            cboCountryList.Location = new Point(8, 8);
            cboCountryList.Name = "cboCountryList";
            cboCountryList.Size = new Size(232, 44);
            cboCountryList.TabIndex = 0;
            cboCountryList.SelectedIndexChanged += cboCountryList_SelectedIndexChanged;
            // 
            // lblCountryName
            // 
            lblCountryName.AutoSize = true;
            lblCountryName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCountryName.Location = new Point(256, 8);
            lblCountryName.Name = "lblCountryName";
            lblCountryName.Size = new Size(233, 36);
            lblCountryName.TabIndex = 1;
            lblCountryName.Text = "lblCountryName";
            // 
            // CoutrySelect
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCountryName);
            Controls.Add(cboCountryList);
            Name = "CoutrySelect";
            Size = new Size(674, 61);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCountryList;
        private Label lblCountryName;
    }
}
