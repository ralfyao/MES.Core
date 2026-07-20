using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class DesignAuditMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignAuditMaintainControl));
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            btnSelectItem = new Button();
            btnDrawingToBom = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnActivate = new Button();
            btnDeactivate = new Button();
            btnOverview = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            panelHeader = new Panel();
            panelDetail = new Panel();
            dataGridView1 = new DataGridView();
            colReviewItem = new DataGridViewComboBoxColumn();
            colFirstReview = new DataGridViewTextBoxColumn();
            colSecondReview = new DataGridViewTextBoxColumn();
            colThirdReview = new DataGridViewTextBoxColumn();
            colMatch = new DataGridViewCheckBoxColumn();
            panelFooter = new Panel();
            lblNote = new Label();
            pictureBox1 = new PictureBox();
            panelToolbar.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.Cornsilk;
            panelToolbar.Controls.Add(pictureBox1);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnRefresh);
            panelToolbar.Controls.Add(btnSelectItem);
            panelToolbar.Controls.Add(btnDrawingToBom);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnActivate);
            panelToolbar.Controls.Add(btnDeactivate);
            panelToolbar.Controls.Add(btnOverview);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnClose);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1900, 56);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(55, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "設計審查清單";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnRefresh.Location = new Point(190, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 32);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "重新整理";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSelectItem
            // 
            btnSelectItem.BackColor = Color.LightSteelBlue;
            btnSelectItem.FlatStyle = FlatStyle.Flat;
            btnSelectItem.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSelectItem.Location = new Point(308, 12);
            btnSelectItem.Name = "btnSelectItem";
            btnSelectItem.Size = new Size(130, 32);
            btnSelectItem.TabIndex = 2;
            btnSelectItem.Text = "選擇審查項目";
            btnSelectItem.UseVisualStyleBackColor = false;
            btnSelectItem.Click += btnSelectItem_Click;
            // 
            // btnDrawingToBom
            // 
            btnDrawingToBom.BackColor = Color.LightGray;
            btnDrawingToBom.Enabled = false;
            btnDrawingToBom.FlatStyle = FlatStyle.Flat;
            btnDrawingToBom.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDrawingToBom.Location = new Point(446, 12);
            btnDrawingToBom.Name = "btnDrawingToBom";
            btnDrawingToBom.Size = new Size(140, 32);
            btnDrawingToBom.TabIndex = 3;
            btnDrawingToBom.Text = "圖面發行轉BOM";
            btnDrawingToBom.UseVisualStyleBackColor = false;
            btnDrawingToBom.Click += btnDrawingToBom_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(594, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(692, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.LightGray;
            btnActivate.Enabled = false;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnActivate.Location = new Point(790, 12);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(90, 32);
            btnActivate.TabIndex = 6;
            btnActivate.Text = "生效";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.LightGray;
            btnDeactivate.Enabled = false;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDeactivate.Location = new Point(888, 12);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(100, 32);
            btnDeactivate.TabIndex = 7;
            btnDeactivate.Text = "取消生效";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.LightSteelBlue;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.Location = new Point(996, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(90, 32);
            btnOverview.TabIndex = 8;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Visible = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LightGray;
            btnPrint.Enabled = false;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(1094, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 32);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(1192, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 10;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 56);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1900, 150);
            panelHeader.TabIndex = 1;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(dataGridView1);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 206);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1900, 410);
            panelDetail.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colReviewItem, colFirstReview, colSecondReview, colThirdReview, colMatch });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 410);
            dataGridView1.TabIndex = 0;
            // 
            // colReviewItem
            // 
            colReviewItem.FillWeight = 150F;
            colReviewItem.HeaderText = "審查項目";
            colReviewItem.Name = "colReviewItem";
            colReviewItem.ReadOnly = true;
            // 
            // colFirstReview
            // 
            colFirstReview.FillWeight = 200F;
            colFirstReview.HeaderText = "初審意見";
            colFirstReview.Name = "colFirstReview";
            colFirstReview.ReadOnly = true;
            // 
            // colSecondReview
            // 
            colSecondReview.FillWeight = 200F;
            colSecondReview.HeaderText = "複審一意見";
            colSecondReview.Name = "colSecondReview";
            colSecondReview.ReadOnly = true;
            // 
            // colThirdReview
            // 
            colThirdReview.FillWeight = 200F;
            colThirdReview.HeaderText = "複審二意見";
            colThirdReview.Name = "colThirdReview";
            colThirdReview.ReadOnly = true;
            // 
            // colMatch
            // 
            colMatch.HeaderText = "符合";
            colMatch.Name = "colMatch";
            colMatch.ReadOnly = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.Cornsilk;
            panelFooter.Controls.Add(lblNote);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 616);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1900, 40);
            panelFooter.TabIndex = 3;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("微軟正黑體", 9F);
            lblNote.ForeColor = Color.DarkRed;
            lblNote.Location = new Point(10, 11);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(602, 16);
            lblNote.TabIndex = 0;
            lblNote.Text = "※本單於有權發行者按『生效』後即完成審圖驗收，圖面發行之授權人員可操作『圖面發行轉BOM』之執行按鈕!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // DesignAuditMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDetail);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "DesignAuditMaintainControl";
            Size = new Size(1900, 656);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnRefresh;
        private Button btnSelectItem;
        private Button btnDrawingToBom;
        private Button btnEdit;
        private Button btnSave;
        private Button btnActivate;
        private Button btnDeactivate;
        private Button btnOverview;
        private Button btnPrint;
        private Button btnClose;
        private Panel panelHeader;
        private Panel panelDetail;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colReviewItem;
        private DataGridViewTextBoxColumn colFirstReview;
        private DataGridViewTextBoxColumn colSecondReview;
        private DataGridViewTextBoxColumn colThirdReview;
        private DataGridViewCheckBoxColumn colMatch;
        private Panel panelFooter;
        private Label lblNote;
        private PictureBox pictureBox1;
    }
}
