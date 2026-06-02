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
            帳號 = new DataGridViewTextBoxColumn();
            密碼 = new DataGridViewTextBoxColumn();
            帳號稱謂 = new DataGridViewTextBoxColumn();
            停用 = new DataGridViewCheckBoxColumn();
            寄件允許 = new DataGridViewCheckBoxColumn();
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
            panel1.Size = new Size(469, 51);
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
            button2.Click += button2_Click;
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
            panel2.Size = new Size(469, 542);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 帳號, 密碼, 帳號稱謂, 停用, 寄件允許 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 542);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellLeave += dataGridView1_CellLeave;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // 帳號
            // 
            帳號.HeaderText = "帳號";
            帳號.Name = "帳號";
            帳號.ReadOnly = true;
            帳號.Resizable = DataGridViewTriState.True;
            帳號.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // 密碼
            // 
            密碼.HeaderText = "密碼";
            密碼.Name = "密碼";
            // 
            // 帳號稱謂
            // 
            帳號稱謂.HeaderText = "帳號稱謂";
            帳號稱謂.Name = "帳號稱謂";
            帳號稱謂.ReadOnly = true;
            // 
            // 停用
            // 
            停用.HeaderText = "停用";
            停用.Name = "停用";
            停用.ReadOnly = true;
            // 
            // 寄件允許
            // 
            寄件允許.HeaderText = "寄件允許";
            寄件允許.Name = "寄件允許";
            寄件允許.ReadOnly = true;
            // 
            // FrmAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 593);
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
        private DataGridViewTextBoxColumn 帳號;
        private DataGridViewTextBoxColumn 密碼;
        private DataGridViewTextBoxColumn 帳號稱謂;
        private DataGridViewCheckBoxColumn 停用;
        private DataGridViewCheckBoxColumn 寄件允許;
    }
}
