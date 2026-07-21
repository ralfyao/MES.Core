using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ModuleMaterialMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleMaterialMaintainControl));
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnAddBomItem = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnActivate = new Button();
            btnDeactivate = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panelHeader = new Panel();
            panelDetail = new Panel();
            dataGridView1 = new DataGridView();
            colBallNo = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colLastModDate = new DataGridViewTextBoxColumn();
            colParentPartNo = new DataGridViewTextBoxColumn();
            colNoNeedPrep = new DataGridViewCheckBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            colChecked = new DataGridViewCheckBoxColumn();
            panelFooter = new Panel();
            pictureBox1 = new PictureBox();
            panelToolbar.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.LightBlue;
            panelToolbar.Controls.Add(pictureBox1);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnAddBomItem);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnActivate);
            panelToolbar.Controls.Add(btnDeactivate);
            panelToolbar.Controls.Add(btnOverview);
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
            lblTitle.Location = new Point(62, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案模組用料清單";
            // 
            // btnAddBomItem
            // 
            btnAddBomItem.BackColor = Color.LightSteelBlue;
            btnAddBomItem.FlatStyle = FlatStyle.Flat;
            btnAddBomItem.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAddBomItem.Location = new Point(240, 12);
            btnAddBomItem.Name = "btnAddBomItem";
            btnAddBomItem.Size = new Size(150, 32);
            btnAddBomItem.TabIndex = 1;
            btnAddBomItem.Text = "新增BOM材料明細";
            btnAddBomItem.UseVisualStyleBackColor = false;
            btnAddBomItem.Click += btnAddBomItem_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(398, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(496, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 3;
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
            btnActivate.Location = new Point(594, 12);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(90, 32);
            btnActivate.TabIndex = 4;
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
            btnDeactivate.Location = new Point(692, 12);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(100, 32);
            btnDeactivate.TabIndex = 5;
            btnDeactivate.Text = "取消生效";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.LightSteelBlue;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.Location = new Point(800, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(90, 32);
            btnOverview.TabIndex = 6;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(898, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 7;
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
            panelHeader.Size = new Size(1900, 130);
            panelHeader.TabIndex = 1;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(dataGridView1);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 186);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1900, 424);
            panelDetail.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBallNo, colPartNo, colPartName, colDesc, colQty, colLastModDate, colParentPartNo, colNoNeedPrep, colRemark, colChecked });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 424);
            dataGridView1.TabIndex = 0;
            // 
            // colBallNo
            // 
            colBallNo.HeaderText = "球號";
            colBallNo.Name = "colBallNo";
            colBallNo.ReadOnly = true;
            // 
            // colPartNo
            // 
            colPartNo.FillWeight = 130F;
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colPartName
            // 
            colPartName.FillWeight = 130F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "描述";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colLastModDate
            // 
            colLastModDate.HeaderText = "最後修改日期";
            colLastModDate.Name = "colLastModDate";
            colLastModDate.ReadOnly = true;
            // 
            // colParentPartNo
            // 
            colParentPartNo.FillWeight = 130F;
            colParentPartNo.HeaderText = "上一階品號";
            colParentPartNo.Name = "colParentPartNo";
            colParentPartNo.ReadOnly = true;
            // 
            // colNoNeedPrep
            // 
            colNoNeedPrep.HeaderText = "不需備料";
            colNoNeedPrep.Name = "colNoNeedPrep";
            colNoNeedPrep.ReadOnly = true;
            // 
            // colRemark
            // 
            colRemark.FillWeight = 150F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            colRemark.ReadOnly = true;
            // 
            // colChecked
            // 
            colChecked.HeaderText = "勾選";
            colChecked.Name = "colChecked";
            colChecked.ReadOnly = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 610);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1900, 46);
            panelFooter.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ModuleMaterialMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDetail);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ModuleMaterialMaintainControl";
            Size = new Size(1900, 656);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnAddBomItem;
        private Button btnEdit;
        private Button btnSave;
        private Button btnActivate;
        private Button btnDeactivate;
        private Button btnOverview;
        private Button btnClose;
        private Panel panelHeader;
        private Panel panelDetail;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colBallNo;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colLastModDate;
        private DataGridViewTextBoxColumn colParentPartNo;
        private DataGridViewCheckBoxColumn colNoNeedPrep;
        private DataGridViewTextBoxColumn colRemark;
        private DataGridViewCheckBoxColumn colChecked;
        private Panel panelFooter;
        private PictureBox pictureBox1;
    }
}
