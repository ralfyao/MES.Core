using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmSelectReviewItem
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
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnConfirm = new Button();
            dataGridView1 = new DataGridView();
            colChecked = new DataGridViewCheckBoxColumn();
            colReviewItem = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(230, 230, 250);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnConfirm);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(900, 48);
            panelToolbar.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "設計審查項目選擇";
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.FromArgb(198, 216, 255);
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(740, 6);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "確認審圖項目";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colReviewItem, colChecked });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 552);
            dataGridView1.TabIndex = 1;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            //
            // colReviewItem
            //
            colReviewItem.FillWeight = 500F;
            colReviewItem.HeaderText = "審查項目";
            colReviewItem.Name = "colReviewItem";
            colReviewItem.ReadOnly = true;
            //
            // colChecked
            //
            colChecked.FillWeight = 60F;
            colChecked.HeaderText = "選項";
            colChecked.Name = "colChecked";
            //
            // FrmSelectReviewItem
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(600, 400);
            Name = "FrmSelectReviewItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "設計審查項目選擇";
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnConfirm;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn colChecked;
        private DataGridViewTextBoxColumn colReviewItem;
    }
}
