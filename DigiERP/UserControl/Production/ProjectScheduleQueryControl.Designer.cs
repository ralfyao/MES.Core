using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProjectScheduleQueryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblWeek1 = new Label();
            dtpWeek1 = new DateTimePicker();
            lblWeek2 = new Label();
            dtpWeek2 = new DateTimePicker();
            lblWeek3 = new Label();
            dtpWeek3 = new DateTimePicker();
            lblWeek4 = new Label();
            dtpWeek4 = new DateTimePicker();
            lblWeek5 = new Label();
            dtpWeek5 = new DateTimePicker();
            lblWeek6 = new Label();
            dtpWeek6 = new DateTimePicker();
            btnDesign = new Button();
            btnPurchase = new Button();
            btnMachining = new Button();
            btnPostProcess = new Button();
            btnAssemTest = new Button();
            btnElecControl = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.ForeColor = Color.Blue;
            lblStartDate.Location = new Point(20, 20);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(64, 18);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "查詢起日";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy/M/d";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(100, 18);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(160, 25);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // lblWeek1
            // 
            lblWeek1.AutoSize = true;
            lblWeek1.ForeColor = Color.Blue;
            lblWeek1.Location = new Point(20, 70);
            lblWeek1.Name = "lblWeek1";
            lblWeek1.Size = new Size(50, 18);
            lblWeek1.TabIndex = 2;
            lblWeek1.Text = "第一週";
            // 
            // dtpWeek1
            // 
            dtpWeek1.CustomFormat = "yyyy/M/d";
            dtpWeek1.Format = DateTimePickerFormat.Custom;
            dtpWeek1.Location = new Point(100, 68);
            dtpWeek1.Name = "dtpWeek1";
            dtpWeek1.Size = new Size(160, 25);
            dtpWeek1.TabIndex = 3;
            // 
            // lblWeek2
            // 
            lblWeek2.AutoSize = true;
            lblWeek2.ForeColor = Color.Blue;
            lblWeek2.Location = new Point(20, 120);
            lblWeek2.Name = "lblWeek2";
            lblWeek2.Size = new Size(50, 18);
            lblWeek2.TabIndex = 4;
            lblWeek2.Text = "第二週";
            // 
            // dtpWeek2
            // 
            dtpWeek2.CustomFormat = "yyyy/M/d";
            dtpWeek2.Format = DateTimePickerFormat.Custom;
            dtpWeek2.Location = new Point(100, 118);
            dtpWeek2.Name = "dtpWeek2";
            dtpWeek2.Size = new Size(160, 25);
            dtpWeek2.TabIndex = 5;
            // 
            // lblWeek3
            // 
            lblWeek3.AutoSize = true;
            lblWeek3.ForeColor = Color.Blue;
            lblWeek3.Location = new Point(20, 170);
            lblWeek3.Name = "lblWeek3";
            lblWeek3.Size = new Size(50, 18);
            lblWeek3.TabIndex = 6;
            lblWeek3.Text = "第三週";
            // 
            // dtpWeek3
            // 
            dtpWeek3.CustomFormat = "yyyy/M/d";
            dtpWeek3.Format = DateTimePickerFormat.Custom;
            dtpWeek3.Location = new Point(100, 168);
            dtpWeek3.Name = "dtpWeek3";
            dtpWeek3.Size = new Size(160, 25);
            dtpWeek3.TabIndex = 7;
            // 
            // lblWeek4
            // 
            lblWeek4.AutoSize = true;
            lblWeek4.ForeColor = Color.Blue;
            lblWeek4.Location = new Point(20, 220);
            lblWeek4.Name = "lblWeek4";
            lblWeek4.Size = new Size(50, 18);
            lblWeek4.TabIndex = 8;
            lblWeek4.Text = "第四週";
            // 
            // dtpWeek4
            // 
            dtpWeek4.CustomFormat = "yyyy/M/d";
            dtpWeek4.Format = DateTimePickerFormat.Custom;
            dtpWeek4.Location = new Point(100, 218);
            dtpWeek4.Name = "dtpWeek4";
            dtpWeek4.Size = new Size(160, 25);
            dtpWeek4.TabIndex = 9;
            // 
            // lblWeek5
            // 
            lblWeek5.AutoSize = true;
            lblWeek5.ForeColor = Color.Blue;
            lblWeek5.Location = new Point(20, 270);
            lblWeek5.Name = "lblWeek5";
            lblWeek5.Size = new Size(50, 18);
            lblWeek5.TabIndex = 10;
            lblWeek5.Text = "第五週";
            // 
            // dtpWeek5
            // 
            dtpWeek5.CustomFormat = "yyyy/M/d";
            dtpWeek5.Format = DateTimePickerFormat.Custom;
            dtpWeek5.Location = new Point(100, 268);
            dtpWeek5.Name = "dtpWeek5";
            dtpWeek5.Size = new Size(160, 25);
            dtpWeek5.TabIndex = 11;
            // 
            // lblWeek6
            // 
            lblWeek6.AutoSize = true;
            lblWeek6.ForeColor = Color.Blue;
            lblWeek6.Location = new Point(20, 320);
            lblWeek6.Name = "lblWeek6";
            lblWeek6.Size = new Size(50, 18);
            lblWeek6.TabIndex = 12;
            lblWeek6.Text = "第六週";
            // 
            // dtpWeek6
            // 
            dtpWeek6.CustomFormat = "yyyy/M/d";
            dtpWeek6.Format = DateTimePickerFormat.Custom;
            dtpWeek6.Location = new Point(100, 318);
            dtpWeek6.Name = "dtpWeek6";
            dtpWeek6.Size = new Size(160, 25);
            dtpWeek6.TabIndex = 13;
            // 
            // btnDesign
            // 
            btnDesign.BackColor = Color.SeaGreen;
            btnDesign.FlatStyle = FlatStyle.Flat;
            btnDesign.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDesign.ForeColor = Color.White;
            btnDesign.Location = new Point(340, 68);
            btnDesign.Name = "btnDesign";
            btnDesign.Size = new Size(140, 32);
            btnDesign.TabIndex = 14;
            btnDesign.Text = "設計";
            btnDesign.UseVisualStyleBackColor = false;
            btnDesign.Click += btnDesign_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.SeaGreen;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(340, 118);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(140, 32);
            btnPurchase.TabIndex = 15;
            btnPurchase.Text = "採購";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnMachining
            // 
            btnMachining.BackColor = Color.SeaGreen;
            btnMachining.FlatStyle = FlatStyle.Flat;
            btnMachining.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnMachining.ForeColor = Color.White;
            btnMachining.Location = new Point(340, 168);
            btnMachining.Name = "btnMachining";
            btnMachining.Size = new Size(140, 32);
            btnMachining.TabIndex = 16;
            btnMachining.Text = "機加工";
            btnMachining.UseVisualStyleBackColor = false;
            btnMachining.Click += btnMachining_Click;
            // 
            // btnPostProcess
            // 
            btnPostProcess.BackColor = Color.SeaGreen;
            btnPostProcess.FlatStyle = FlatStyle.Flat;
            btnPostProcess.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPostProcess.ForeColor = Color.White;
            btnPostProcess.Location = new Point(340, 218);
            btnPostProcess.Name = "btnPostProcess";
            btnPostProcess.Size = new Size(140, 32);
            btnPostProcess.TabIndex = 17;
            btnPostProcess.Text = "後製程";
            btnPostProcess.UseVisualStyleBackColor = false;
            btnPostProcess.Click += btnPostProcess_Click;
            // 
            // btnAssemTest
            // 
            btnAssemTest.BackColor = Color.SeaGreen;
            btnAssemTest.FlatStyle = FlatStyle.Flat;
            btnAssemTest.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAssemTest.ForeColor = Color.White;
            btnAssemTest.Location = new Point(340, 268);
            btnAssemTest.Name = "btnAssemTest";
            btnAssemTest.Size = new Size(140, 32);
            btnAssemTest.TabIndex = 18;
            btnAssemTest.Text = "組測";
            btnAssemTest.UseVisualStyleBackColor = false;
            btnAssemTest.Click += btnAssemTest_Click;
            // 
            // btnElecControl
            // 
            btnElecControl.BackColor = Color.SeaGreen;
            btnElecControl.FlatStyle = FlatStyle.Flat;
            btnElecControl.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnElecControl.ForeColor = Color.White;
            btnElecControl.Location = new Point(340, 318);
            btnElecControl.Name = "btnElecControl";
            btnElecControl.Size = new Size(140, 32);
            btnElecControl.TabIndex = 19;
            btnElecControl.Text = "程控";
            btnElecControl.UseVisualStyleBackColor = false;
            btnElecControl.Click += btnElecControl_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(340, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 32);
            btnExit.TabIndex = 20;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // ProjectScheduleQueryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            Controls.Add(lblStartDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblWeek1);
            Controls.Add(dtpWeek1);
            Controls.Add(lblWeek2);
            Controls.Add(dtpWeek2);
            Controls.Add(lblWeek3);
            Controls.Add(dtpWeek3);
            Controls.Add(lblWeek4);
            Controls.Add(dtpWeek4);
            Controls.Add(lblWeek5);
            Controls.Add(dtpWeek5);
            Controls.Add(lblWeek6);
            Controls.Add(dtpWeek6);
            Controls.Add(btnDesign);
            Controls.Add(btnPurchase);
            Controls.Add(btnMachining);
            Controls.Add(btnPostProcess);
            Controls.Add(btnAssemTest);
            Controls.Add(btnElecControl);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectScheduleQueryControl";
            Size = new Size(1900, 656);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblWeek1;
        private DateTimePicker dtpWeek1;
        private Label lblWeek2;
        private DateTimePicker dtpWeek2;
        private Label lblWeek3;
        private DateTimePicker dtpWeek3;
        private Label lblWeek4;
        private DateTimePicker dtpWeek4;
        private Label lblWeek5;
        private DateTimePicker dtpWeek5;
        private Label lblWeek6;
        private DateTimePicker dtpWeek6;
        private Button btnDesign;
        private Button btnPurchase;
        private Button btnMachining;
        private Button btnPostProcess;
        private Button btnAssemTest;
        private Button btnElecControl;
        private Button btnExit;
    }
}
