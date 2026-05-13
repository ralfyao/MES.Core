using DigiERP.Common;

namespace DigiERP.Forms.Customer
{
    partial class FrmRfqWorkRecord
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
            lblDate = new Label();
            lblWorkerNumber = new Label();
            label3 = new Label();
            lblName = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProjSerial = new CommonTextBox();
            label7 = new Label();
            cboPosition = new CommonComboBox();
            label2 = new Label();
            successPropability = new NumericUpDown();
            txtModuleCode = new CommonTextBox();
            label4 = new Label();
            txtModuleName = new CommonTextBox();
            label8 = new Label();
            label9 = new Label();
            cboMissionCiass = new CommonComboBox();
            label10 = new Label();
            label11 = new Label();
            points = new NumericUpDown();
            txtInterviewPoints = new CommonTextBox();
            label12 = new Label();
            txtComments = new CommonTextBox();
            label13 = new Label();
            label14 = new Label();
            dtRevisit = new DateTimePicker();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)successPropability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)points).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "聯絡日期";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblDate.ForeColor = SystemColors.ActiveCaptionText;
            lblDate.Location = new Point(104, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 24);
            lblDate.TabIndex = 1;
            lblDate.Text = "lblDate";
            // 
            // lblWorkerNumber
            // 
            lblWorkerNumber.AutoSize = true;
            lblWorkerNumber.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWorkerNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblWorkerNumber.Location = new Point(296, 8);
            lblWorkerNumber.Name = "lblWorkerNumber";
            lblWorkerNumber.Size = new Size(173, 24);
            lblWorkerNumber.TabIndex = 3;
            lblWorkerNumber.Text = "lblWorkerNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(248, 8);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 2;
            label3.Text = "工號";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(600, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 24);
            lblName.TabIndex = 5;
            lblName.Text = "lblName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(552, 8);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 4;
            label5.Text = "姓名";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(8, 64);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 6;
            label6.Text = "詢問函/專案";
            // 
            // txtProjSerial
            // 
            txtProjSerial.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtProjSerial.Location = new Point(128, 64);
            txtProjSerial.Name = "txtProjSerial";
            txtProjSerial.Size = new Size(128, 31);
            txtProjSerial.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(272, 64);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 8;
            label7.Text = "職務";
            // 
            // cboPosition
            // 
            cboPosition.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(328, 62);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(121, 32);
            cboPosition.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(504, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 10;
            label2.Text = "要望機率";
            // 
            // successPropability
            // 
            successPropability.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            successPropability.Location = new Point(600, 60);
            successPropability.Name = "successPropability";
            successPropability.Size = new Size(88, 31);
            successPropability.TabIndex = 11;
            // 
            // txtModuleCode
            // 
            txtModuleCode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtModuleCode.Location = new Point(128, 112);
            txtModuleCode.Name = "txtModuleCode";
            txtModuleCode.Size = new Size(128, 31);
            txtModuleCode.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(31, 112);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 12;
            label4.Text = "客戶簡稱";
            // 
            // txtModuleName
            // 
            txtModuleName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtModuleName.Location = new Point(369, 112);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.Size = new Size(319, 31);
            txtModuleName.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(272, 112);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 14;
            label8.Text = "程序來源";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(31, 163);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 16;
            label9.Text = "任務分類";
            // 
            // cboMissionCiass
            // 
            cboMissionCiass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMissionCiass.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMissionCiass.FormattingEnabled = true;
            cboMissionCiass.Location = new Point(128, 161);
            cboMissionCiass.Name = "cboMissionCiass";
            cboMissionCiass.Size = new Size(365, 31);
            cboMissionCiass.TabIndex = 17;
            cboMissionCiass.Click += cboMissionCiass_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(504, 163);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 18;
            label10.Text = "成效點數";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(694, 64);
            label11.Name = "label11";
            label11.Size = new Size(27, 24);
            label11.TabIndex = 19;
            label11.Text = "%";
            // 
            // points
            // 
            points.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            points.Location = new Point(596, 161);
            points.Name = "points";
            points.Size = new Size(88, 31);
            points.TabIndex = 20;
            // 
            // txtInterviewPoints
            // 
            txtInterviewPoints.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtInterviewPoints.Location = new Point(128, 214);
            txtInterviewPoints.Name = "txtInterviewPoints";
            txtInterviewPoints.Size = new Size(556, 31);
            txtInterviewPoints.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(31, 214);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 21;
            label12.Text = "訪談重點";
            // 
            // txtComments
            // 
            txtComments.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtComments.Location = new Point(128, 264);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(556, 133);
            txtComments.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(31, 264);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 23;
            label13.Text = "內容簡述";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(31, 412);
            label14.Name = "label14";
            label14.Size = new Size(105, 24);
            label14.TabIndex = 25;
            label14.Text = "預計再訪日";
            // 
            // dtRevisit
            // 
            dtRevisit.CalendarFont = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtRevisit.Location = new Point(142, 412);
            dtRevisit.Name = "dtRevisit";
            dtRevisit.Size = new Size(128, 23);
            dtRevisit.TabIndex = 26;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(586, 422);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FrmRfqWorkRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(748, 473);
            Controls.Add(btnSubmit);
            Controls.Add(dtRevisit);
            Controls.Add(label14);
            Controls.Add(txtComments);
            Controls.Add(label13);
            Controls.Add(txtInterviewPoints);
            Controls.Add(label12);
            Controls.Add(points);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboMissionCiass);
            Controls.Add(label9);
            Controls.Add(txtModuleName);
            Controls.Add(label8);
            Controls.Add(txtModuleCode);
            Controls.Add(label4);
            Controls.Add(successPropability);
            Controls.Add(label2);
            Controls.Add(cboPosition);
            Controls.Add(label7);
            Controls.Add(txtProjSerial);
            Controls.Add(label6);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(lblWorkerNumber);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Name = "FrmRfqWorkRecord";
            Text = "FrmRfqWorkRecord";
            ((System.ComponentModel.ISupportInitialize)successPropability).EndInit();
            ((System.ComponentModel.ISupportInitialize)points).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDate;
        private Label lblWorkerNumber;
        private Label label3;
        private Label lblName;
        private Label label5;
        private Label label6;
        private CommonTextBox txtProjSerial;
        private Label label7;
        private CommonComboBox cboPosition;
        private Label label2;
        private NumericUpDown successPropability;
        private CommonTextBox txtModuleCode;
        private Label label4;
        private CommonTextBox txtModuleName;
        private Label label8;
        private Label label9;
        private CommonComboBox cboMissionCiass;
        private Label label10;
        private Label label11;
        private NumericUpDown points;
        private CommonTextBox txtInterviewPoints;
        private Label label12;
        private CommonTextBox txtComments;
        private Label label13;
        private Label label14;
        private DateTimePicker dtRevisit;
        private Button btnSubmit;
    }
}