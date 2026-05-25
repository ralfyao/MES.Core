namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmAddAR
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
            label1 = new Label();
            label2 = new Label();
            commonNumericUpDown1 = new Common.CommonNumericUpDown();
            commonNumericUpDown2 = new Common.CommonNumericUpDown();
            label3 = new Label();
            button1 = new Button();
            commonComboBox1 = new Common.CommonComboBox();
            ((System.ComponentModel.ISupportInitialize)commonNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commonNumericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "款項期別";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "成數";
            // 
            // commonNumericUpDown1
            // 
            commonNumericUpDown1.Location = new Point(84, 52);
            commonNumericUpDown1.Name = "commonNumericUpDown1";
            commonNumericUpDown1.Size = new Size(100, 23);
            commonNumericUpDown1.TabIndex = 3;
            // 
            // commonNumericUpDown2
            // 
            commonNumericUpDown2.Location = new Point(84, 84);
            commonNumericUpDown2.Name = "commonNumericUpDown2";
            commonNumericUpDown2.Size = new Size(100, 23);
            commonNumericUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 88);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "金額";
            // 
            // button1
            // 
            button1.Location = new Point(108, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            // 
            // commonComboBox1
            // 
            commonComboBox1.FormattingEnabled = true;
            commonComboBox1.Location = new Point(84, 20);
            commonComboBox1.Name = "commonComboBox1";
            commonComboBox1.Size = new Size(100, 23);
            commonComboBox1.TabIndex = 7;
            // 
            // FrmAddAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 171);
            Controls.Add(commonComboBox1);
            Controls.Add(button1);
            Controls.Add(commonNumericUpDown2);
            Controls.Add(label3);
            Controls.Add(commonNumericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAddAR";
            Text = "新增應收款";
            ((System.ComponentModel.ISupportInitialize)commonNumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)commonNumericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Common.CommonNumericUpDown commonNumericUpDown1;
        private Common.CommonNumericUpDown commonNumericUpDown2;
        private Label label3;
        private Button button1;
        private Common.CommonComboBox commonComboBox1;
    }
}