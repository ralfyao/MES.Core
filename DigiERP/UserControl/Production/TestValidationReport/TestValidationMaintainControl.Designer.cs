using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.TestValidationReport
{
    partial class TestValidationMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestValidationMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblWarning = new Label();
            btnModify = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnCancelApprove = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panelScroll = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblWarning);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnCancelApprove);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "賣方廠驗收單";
            //
            // lblWarning
            //
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Firebrick;
            lblWarning.Location = new Point(60, 32);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(260, 18);
            lblWarning.TabIndex = 1;
            lblWarning.Text = "覆核後若將改正措施寫進會議紀錄!";
            //
            // btnModify
            //
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(1284, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(86, 32);
            btnModify.TabIndex = 2;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(1376, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnApprove
            //
            btnApprove.BackColor = Color.Gainsboro;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.Location = new Point(1468, 12);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(86, 32);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "覆核";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            //
            // btnCancelApprove
            //
            btnCancelApprove.BackColor = Color.Gainsboro;
            btnCancelApprove.FlatStyle = FlatStyle.Flat;
            btnCancelApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelApprove.Location = new Point(1560, 12);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(86, 32);
            btnCancelApprove.TabIndex = 5;
            btnCancelApprove.Text = "取消覆核";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1652, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 32);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnOverview
            //
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(1744, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(86, 32);
            btnOverview.TabIndex = 7;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1836, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 32);
            btnClose.TabIndex = 8;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // panelScroll
            //
            panelScroll.AutoScroll = true;
            panelScroll.Dock = DockStyle.Fill;
            panelScroll.Location = new Point(0, 56);
            panelScroll.Name = "panelScroll";
            panelScroll.Size = new Size(1900, 680);
            panelScroll.TabIndex = 1;
            //
            // TestValidationMaintainControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelScroll);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "TestValidationMaintainControl";
            Size = new Size(1900, 736);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblWarning;
        private Button btnModify;
        private Button btnSave;
        private Button btnApprove;
        private Button btnCancelApprove;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnClose;
        private Panel panelScroll;
    }
}
