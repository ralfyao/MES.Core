using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmModuleCheckList
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
            lblCategoryCaption = new Label();
            txtCategory = new TextBox();
            lblDutyCaption = new Label();
            cboDuty = new ComboBox();
            btnAddItem = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            colSeq = new DataGridViewTextBoxColumn();
            colCheckItem = new DataGridViewTextBoxColumn();
            colCheckMethod = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.Cornsilk;
            panelToolbar.Controls.Add(lblCategoryCaption);
            panelToolbar.Controls.Add(txtCategory);
            panelToolbar.Controls.Add(lblDutyCaption);
            panelToolbar.Controls.Add(cboDuty);
            panelToolbar.Controls.Add(btnAddItem);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnClose);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1100, 56);
            panelToolbar.TabIndex = 0;
            // 
            // lblCategoryCaption
            // 
            lblCategoryCaption.AutoSize = true;
            lblCategoryCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCategoryCaption.Location = new Point(16, 18);
            lblCategoryCaption.Name = "lblCategoryCaption";
            lblCategoryCaption.Size = new Size(64, 18);
            lblCategoryCaption.TabIndex = 0;
            lblCategoryCaption.Text = "檢查分類";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(90, 14);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(160, 25);
            txtCategory.TabIndex = 1;
            // 
            // lblDutyCaption
            // 
            lblDutyCaption.AutoSize = true;
            lblDutyCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblDutyCaption.Location = new Point(266, 18);
            lblDutyCaption.Name = "lblDutyCaption";
            lblDutyCaption.Size = new Size(36, 18);
            lblDutyCaption.TabIndex = 2;
            lblDutyCaption.Text = "用途";
            // 
            // cboDuty
            // 
            cboDuty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDuty.Enabled = false;
            cboDuty.Location = new Point(316, 14);
            cboDuty.Name = "cboDuty";
            cboDuty.Size = new Size(120, 25);
            cboDuty.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.LightSteelBlue;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAddItem.Location = new Point(460, 10);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(90, 32);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "新增";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(558, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(656, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(754, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 7;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(198, 224, 180);
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSeq, colCheckItem, colCheckMethod, colDesc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1100, 544);
            dataGridView1.TabIndex = 1;
            // 
            // colSeq
            // 
            colSeq.FillWeight = 60F;
            colSeq.HeaderText = "項次";
            colSeq.Name = "colSeq";
            colSeq.ReadOnly = true;
            // 
            // colCheckItem
            // 
            colCheckItem.FillWeight = 150F;
            colCheckItem.HeaderText = "檢查項目";
            colCheckItem.Name = "colCheckItem";
            colCheckItem.ReadOnly = true;
            // 
            // colCheckMethod
            // 
            colCheckMethod.FillWeight = 130F;
            colCheckMethod.HeaderText = "檢查方法";
            colCheckMethod.Name = "colCheckMethod";
            colCheckMethod.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 320F;
            colDesc.HeaderText = "檢查要求及說明";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // FrmModuleCheckList
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(800, 400);
            Name = "FrmModuleCheckList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "模組圖自檢一覽表";
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblCategoryCaption;
        private TextBox txtCategory;
        private Label lblDutyCaption;
        private ComboBox cboDuty;
        private Button btnAddItem;
        private Button btnSave;
        private Button btnEdit;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colSeq;
        private DataGridViewTextBoxColumn colCheckItem;
        private DataGridViewTextBoxColumn colCheckMethod;
        private DataGridViewTextBoxColumn colDesc;
    }
}
