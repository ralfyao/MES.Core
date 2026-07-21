using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmSelectDrawingCheckCategory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnAdd = new Button();
            btnConfirm = new Button();
            dataGridView1 = new DataGridView();
            colCheckCategory = new DataGridViewTextBoxColumn();
            colDuty = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.FromArgb(230, 230, 250);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Controls.Add(btnConfirm);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(721, 48);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "檢查分類選擇";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(198, 232, 198);
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(440, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(198, 216, 255);
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(560, 6);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "確定選擇";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 250);
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCheckCategory, colDuty });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(721, 313);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colCheckCategory
            // 
            colCheckCategory.FillWeight = 300F;
            colCheckCategory.HeaderText = "檢查分類";
            colCheckCategory.Name = "colCheckCategory";
            colCheckCategory.ReadOnly = true;
            // 
            // colDuty
            // 
            colDuty.FillWeight = 200F;
            colDuty.HeaderText = "職務";
            colDuty.Name = "colDuty";
            colDuty.ReadOnly = true;
            // 
            // FrmSelectDrawingCheckCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 361);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(500, 400);
            Name = "FrmSelectDrawingCheckCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "檢查分類選擇";
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnConfirm;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colCheckCategory;
        private DataGridViewTextBoxColumn colDuty;
    }
}
