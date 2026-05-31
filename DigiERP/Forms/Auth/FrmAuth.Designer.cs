using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.UserControl.Auth
{
    partial class FrmAuth
    {
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            commonTextBox1 = new DigiERP.Common.CommonTextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            工號 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            部門 = new DataGridViewTextBoxColumn();
            職能 = new DataGridViewTextBoxColumn();
            地址 = new DataGridViewTextBoxColumn();
            生日 = new DataGridViewTextBoxColumn();
            職稱 = new DataGridViewTextBoxColumn();
            狀況 = new DataGridViewTextBoxColumn();
            身分證號 = new DataGridViewTextBoxColumn();
            人事編號 = new DataGridViewTextBoxColumn();
            卡號 = new DataGridViewTextBoxColumn();
            系統帳號 = new DataGridViewComboBoxColumn();
            功能權限 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(commonTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 51);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(299, 13);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "新增帳號";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(218, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "查詢";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 1;
            label1.Text = "帳號";
            // 
            // commonTextBox1
            // 
            commonTextBox1.Location = new Point(66, 13);
            commonTextBox1.Name = "commonTextBox1";
            commonTextBox1.Size = new Size(136, 23);
            commonTextBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 542);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 工號, 姓名, 部門, 職能, 地址, 生日, 職稱, 狀況, 身分證號, 人事編號, 卡號, 系統帳號, 功能權限 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1089, 542);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellLeave += dataGridView1_CellLeave;
            // 
            // 工號
            // 
            工號.HeaderText = "工號";
            工號.Name = "工號";
            工號.ReadOnly = true;
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.Name = "姓名";
            姓名.ReadOnly = true;
            // 
            // 部門
            // 
            部門.HeaderText = "部門";
            部門.Name = "部門";
            部門.ReadOnly = true;
            部門.Resizable = DataGridViewTriState.True;
            // 
            // 職能
            // 
            職能.HeaderText = "職能";
            職能.Name = "職能";
            職能.ReadOnly = true;
            // 
            // 地址
            // 
            地址.HeaderText = "地址";
            地址.Name = "地址";
            地址.ReadOnly = true;
            // 
            // 生日
            // 
            生日.HeaderText = "生日";
            生日.Name = "生日";
            生日.ReadOnly = true;
            // 
            // 職稱
            // 
            職稱.HeaderText = "職稱";
            職稱.Name = "職稱";
            職稱.ReadOnly = true;
            // 
            // 狀況
            // 
            狀況.HeaderText = "狀況";
            狀況.Name = "狀況";
            狀況.ReadOnly = true;
            // 
            // 身分證號
            // 
            身分證號.HeaderText = "身分證號";
            身分證號.Name = "身分證號";
            身分證號.ReadOnly = true;
            // 
            // 人事編號
            // 
            人事編號.HeaderText = "人事編號";
            人事編號.Name = "人事編號";
            人事編號.ReadOnly = true;
            // 
            // 卡號
            // 
            卡號.HeaderText = "卡號";
            卡號.Name = "卡號";
            卡號.ReadOnly = true;
            // 
            // 系統帳號
            // 
            系統帳號.HeaderText = "系統帳號";
            系統帳號.Name = "系統帳號";
            系統帳號.Resizable = DataGridViewTriState.True;
            系統帳號.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // 功能權限
            // 
            功能權限.HeaderText = "功能權限";
            功能權限.Name = "功能權限";
            功能權限.UseColumnTextForButtonValue = true;
            // 
            // FrmAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAuth";
            Text = "帳密權限管理";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private DigiERP.Common.CommonTextBox commonTextBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 工號;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 部門;
        private DataGridViewTextBoxColumn 職能;
        private DataGridViewTextBoxColumn 地址;
        private DataGridViewTextBoxColumn 生日;
        private DataGridViewTextBoxColumn 職稱;
        private DataGridViewTextBoxColumn 狀況;
        private DataGridViewTextBoxColumn 身分證號;
        private DataGridViewTextBoxColumn 人事編號;
        private DataGridViewTextBoxColumn 卡號;
        private DataGridViewComboBoxColumn 系統帳號;
        private DataGridViewButtonColumn 功能權限;
    }
}
