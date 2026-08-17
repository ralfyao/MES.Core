using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.ClockInOut
{
    partial class FrmAttendanceMonthlyPrint
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
            btnPrint = new Button();
            btnExit = new Button();
            panelScroll = new Panel();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.WhiteSmoke;
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnExit);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1200, 48);
            panelToolbar.TabIndex = 0;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.LightSteelBlue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(980, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 32);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1088, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "關閉";
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
            panelScroll.Size = new Size(1200, 700);
            panelScroll.TabIndex = 1;
            //
            // FrmAttendanceMonthlyPrint
            //
            ClientSize = new Size(1200, 748);
            Controls.Add(panelScroll);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(700, 500);
            Name = "FrmAttendanceMonthlyPrint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "員工月出勤明細表 - 預覽列印";
            WindowState = FormWindowState.Maximized;
            Load += FrmAttendanceMonthlyPrint_Load;
            panelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Button btnPrint;
        private Button btnExit;
        private Panel panelScroll;
    }
}
