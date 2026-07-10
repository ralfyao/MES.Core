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
        private static int DAYS_A_WEEK = 7;
        private void RecalculateWeeks()
        {
            DateTime start = dtpStartDate.Value.Date;
            int cnt = 1;
            dtpWeek1.Value = start.AddDays(DAYS_A_WEEK * cnt++);
            dtpWeek2.Value = start.AddDays(DAYS_A_WEEK * cnt++);
            dtpWeek3.Value = start.AddDays(DAYS_A_WEEK * cnt++);
            dtpWeek4.Value = start.AddDays(DAYS_A_WEEK * cnt++);
            dtpWeek5.Value = start.AddDays(DAYS_A_WEEK * cnt++);
            dtpWeek6.Value = start.AddDays(DAYS_A_WEEK * cnt++);
        }

        // ── 點擊設計，開啟週排程-設計頁籤 ──────────────────────────────────
        private void btnDesign_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "DesignSchedule";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DesignScheduleControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(dtpStartDate.Value, dtpWeek1.Value, dtpWeek2.Value, dtpWeek3.Value, dtpWeek4.Value, dtpWeek5.Value, dtpWeek6.Value);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("週排程-設計") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        // ── 點擊採購，開啟週排程-採購頁籤 ──────────────────────────────────
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "ProcurementScheduling";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ProcurementSchedulingControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(dtpStartDate.Value, dtpWeek1.Value, dtpWeek2.Value, dtpWeek3.Value, dtpWeek4.Value);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("週排程-採購") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        // ── 點擊機加工，開啟週排程-機加工頁籤 ────────────────────────────
        private void btnMachining_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "MachiningScheduling";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new MachiningSchedulingControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(dtpStartDate.Value, dtpWeek1.Value, dtpWeek2.Value, dtpWeek3.Value, dtpWeek4.Value);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("週排程-機加工") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        // ── 點擊後製程，開啟週排程-後製程頁籤 ────────────────────────────
        private void btnPostProcess_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "PostProcessScheduling";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new PostProcessSchedulingControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData();
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("週排程-後製程") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        // ── 點擊組測，開啟週排程-組裝測試頁籤 ────────────────────────────
        private void btnAssemTest_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "AssemTestScheduling";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new AssemTestSchedulingControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(dtpStartDate.Value, dtpWeek1.Value, dtpWeek2.Value, dtpWeek3.Value, dtpWeek4.Value);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("週排程-組裝測試") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
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
