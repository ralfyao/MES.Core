namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class FrmSelectContact
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
            panelTop    = new Panel();
            btnSave     = new Button();
            dgvContact  = new DataGridView();
            colSeq      = new DataGridViewTextBoxColumn();
            colContact  = new DataGridViewTextBoxColumn();
            colTitle    = new DataGridViewTextBoxColumn();
            colEmail    = new DataGridViewTextBoxColumn();
            colPhone    = new DataGridViewTextBoxColumn();
            colExt      = new DataGridViewTextBoxColumn();
            colFax      = new DataGridViewTextBoxColumn();
            colBranch   = new DataGridViewTextBoxColumn();
            colAddress  = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(btnSave);
            panelTop.Dock     = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name     = "panelTop";
            panelTop.Size     = new Size(1080, 46);
            panelTop.TabIndex = 1;

            // btnSave
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font      = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location  = new Point(8, 6);
            btnSave.Name      = "btnSave";
            btnSave.Size      = new Size(110, 34);
            btnSave.TabIndex  = 0;
            btnSave.Text      = "儲存聯絡名冊";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click    += btnSave_Click;

            // dgvContact
            dgvContact.AllowUserToDeleteRows        = false;
            dgvContact.AutoSizeColumnsMode          = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContact.BackgroundColor              = Color.White;
            dgvContact.ColumnHeadersHeightSizeMode  = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Columns.AddRange(new DataGridViewColumn[] {
                colSeq, colContact, colTitle, colEmail,
                colPhone, colExt, colFax, colBranch, colAddress
            });
            dgvContact.Dock              = DockStyle.Fill;
            dgvContact.Font              = new Font("微軟正黑體", 10F);
            dgvContact.Location          = new Point(0, 46);
            dgvContact.Name              = "dgvContact";
            dgvContact.RowHeadersVisible = true;
            dgvContact.RowTemplate.Height = 26;
            dgvContact.SelectionMode     = DataGridViewSelectionMode.FullRowSelect;
            dgvContact.Size              = new Size(1080, 484);
            dgvContact.TabIndex          = 0;
            dgvContact.CellDoubleClick  += dgvContact_CellDoubleClick;

            // colSeq
            colSeq.FillWeight = 40F;
            colSeq.HeaderText = "編號";
            colSeq.Name       = "colSeq";
            colSeq.ReadOnly   = true;

            // colContact
            colContact.FillWeight = 80F;
            colContact.HeaderText = "聯絡人";
            colContact.Name       = "colContact";

            // colTitle
            colTitle.FillWeight = 80F;
            colTitle.HeaderText = "職稱";
            colTitle.Name       = "colTitle";

            // colEmail
            colEmail.FillWeight = 140F;
            colEmail.HeaderText = "電郵";
            colEmail.Name       = "colEmail";

            // colPhone
            colPhone.FillWeight = 90F;
            colPhone.HeaderText = "電話";
            colPhone.Name       = "colPhone";

            // colExt
            colExt.FillWeight = 50F;
            colExt.HeaderText = "分機";
            colExt.Name       = "colExt";

            // colFax
            colFax.FillWeight = 90F;
            colFax.HeaderText = "傳真";
            colFax.Name       = "colFax";

            // colBranch
            colBranch.FillWeight = 80F;
            colBranch.HeaderText = "分支機構";
            colBranch.Name       = "colBranch";

            // colAddress
            colAddress.FillWeight = 150F;
            colAddress.HeaderText = "地址";
            colAddress.Name       = "colAddress";

            // FrmSelectContact
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(1080, 530);
            Controls.Add(dgvContact);
            Controls.Add(panelTop);
            Font            = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize     = new Size(800, 400);
            Name            = "FrmSelectContact";
            StartPosition   = FormStartPosition.CenterParent;
            Text            = "聯絡名冊";
            Load           += FrmSelectContact_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel   panelTop;
        private Button  btnSave;
        private DataGridView dgvContact;
        private DataGridViewTextBoxColumn colSeq;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colExt;
        private DataGridViewTextBoxColumn colFax;
        private DataGridViewTextBoxColumn colBranch;
        private DataGridViewTextBoxColumn colAddress;
    }
}
