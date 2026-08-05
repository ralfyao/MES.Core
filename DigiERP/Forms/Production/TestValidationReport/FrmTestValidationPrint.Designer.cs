using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.TestValidationReport
{
    partial class FrmTestValidationPrint
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
            btnPreviewPrint = new Button();
            btnExit = new Button();
            panelScroll = new Panel();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.WhiteSmoke;
            panelToolbar.Controls.Add(btnPreviewPrint);
            panelToolbar.Controls.Add(btnExit);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(900, 48);
            panelToolbar.TabIndex = 0;
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.LightSteelBlue;
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPreviewPrint.Location = new Point(680, 8);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(100, 32);
            btnPreviewPrint.TabIndex = 0;
            btnPreviewPrint.Text = "預覽列印";
            btnPreviewPrint.UseVisualStyleBackColor = false;
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(788, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelScroll
            // 
            panelScroll.AutoScroll = true;
            panelScroll.BackColor = Color.Gainsboro;
            panelScroll.Dock = DockStyle.Fill;
            panelScroll.Location = new Point(0, 48);
            panelScroll.Name = "panelScroll";
            panelScroll.Size = new Size(900, 700);
            panelScroll.TabIndex = 1;
            // 
            // FrmTestValidationPrint
            // 
            ClientSize = new Size(900, 748);
            Controls.Add(panelScroll);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(700, 500);
            Name = "FrmTestValidationPrint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "賣方廠驗收單 - 預覽列印";
            WindowState = FormWindowState.Maximized;
            Load += FrmTestValidationPrint_Load;
            panelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Button btnPreviewPrint;
        private Button btnExit;
        private Panel panelScroll;
    }
}
