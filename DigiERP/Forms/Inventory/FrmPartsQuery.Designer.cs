namespace DigiERP.Forms.Inventory
{
    partial class FrmPartsQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartsQuery));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKeyword1 = new Common.CommonTextBox();
            txtKeyword2 = new Common.CommonTextBox();
            txtKeyword3 = new Common.CommonTextBox();
            txtProjSerial = new Common.CommonTextBox();
            btn選自料品 = new Button();
            btn選自BOM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 24);
            label1.TabIndex = 0;
            label1.Text = "料品清單查詢";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(213, 37);
            label2.TabIndex = 1;
            label2.Text = "Item Keyword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(20, 124);
            label3.Name = "label3";
            label3.Size = new Size(213, 37);
            label3.TabIndex = 2;
            label3.Text = "Item Keyword";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(20, 187);
            label4.Name = "label4";
            label4.Size = new Size(213, 37);
            label4.TabIndex = 3;
            label4.Text = "Item Keyword";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(20, 300);
            label5.Name = "label5";
            label5.Size = new Size(133, 37);
            label5.TabIndex = 4;
            label5.Text = "專案序號";
            // 
            // txtKeyword1
            // 
            txtKeyword1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtKeyword1.Location = new Point(256, 60);
            txtKeyword1.Name = "txtKeyword1";
            txtKeyword1.Size = new Size(304, 44);
            txtKeyword1.TabIndex = 5;
            // 
            // txtKeyword2
            // 
            txtKeyword2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtKeyword2.Location = new Point(256, 120);
            txtKeyword2.Name = "txtKeyword2";
            txtKeyword2.Size = new Size(304, 44);
            txtKeyword2.TabIndex = 6;
            // 
            // txtKeyword3
            // 
            txtKeyword3.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtKeyword3.Location = new Point(256, 184);
            txtKeyword3.Name = "txtKeyword3";
            txtKeyword3.Size = new Size(304, 44);
            txtKeyword3.TabIndex = 7;
            // 
            // txtProjSerial
            // 
            txtProjSerial.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProjSerial.Location = new Point(256, 296);
            txtProjSerial.Name = "txtProjSerial";
            txtProjSerial.Size = new Size(304, 44);
            txtProjSerial.TabIndex = 8;
            // 
            // btn選自料品
            // 
            btn選自料品.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn選自料品.Location = new Point(588, 112);
            btn選自料品.Name = "btn選自料品";
            btn選自料品.Size = new Size(120, 48);
            btn選自料品.TabIndex = 9;
            btn選自料品.Text = "選自料品";
            btn選自料品.UseVisualStyleBackColor = true;
            btn選自料品.Click += btn選自料品_Click;
            // 
            // btn選自BOM
            // 
            btn選自BOM.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn選自BOM.Location = new Point(576, 292);
            btn選自BOM.Name = "btn選自BOM";
            btn選自BOM.Size = new Size(144, 48);
            btn選自BOM.TabIndex = 10;
            btn選自BOM.Text = "選自BOM";
            btn選自BOM.UseVisualStyleBackColor = true;
            // 
            // FrmPartsQuery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 373);
            Controls.Add(btn選自BOM);
            Controls.Add(btn選自料品);
            Controls.Add(txtProjSerial);
            Controls.Add(txtKeyword3);
            Controls.Add(txtKeyword2);
            Controls.Add(txtKeyword1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPartsQuery";
            Text = "品名搜尋條件";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Common.CommonTextBox txtKeyword1;
        private Common.CommonTextBox txtKeyword2;
        private Common.CommonTextBox txtKeyword3;
        private Common.CommonTextBox txtProjSerial;
        private Button btn選自料品;
        private Button btn選自BOM;
    }
}