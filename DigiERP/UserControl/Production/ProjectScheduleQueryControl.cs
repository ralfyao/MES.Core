using DigiERP.Common;
using System;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ProjectScheduleQueryControl : CommonUserControl
    {
        private static string id = "9D3E7B52-1F6A-4C89-8D4E-5B2A7F9C3E68";

        public ProjectScheduleQueryControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today;
            RecalculateWeeks();
        }

        // ── 查詢起日變更時，重新計算第一~六週(每週往後遞增7天，同一星期幾) ──
        private void dtpStartDate_ValueChanged(object sender, EventArgs e) => RecalculateWeeks();

        private void RecalculateWeeks()
        {
            DateTime start = dtpStartDate.Value.Date;
            dtpWeek1.Value = start.AddDays(7);
            dtpWeek2.Value = start.AddDays(14);
            dtpWeek3.Value = start.AddDays(21);
            dtpWeek4.Value = start.AddDays(28);
            dtpWeek5.Value = start.AddDays(35);
            dtpWeek6.Value = start.AddDays(42);
        }

        private void btnDesign_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnPurchase_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnMachining_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnPostProcess_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnAssemTest_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnElecControl_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }
    }
}
