using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ProjectProgressDetailControl : CommonUserControl
    {
        private static string id = "6C1F4A28-3E7D-4B95-8A2C-9F6D5E1B7A34";
        private string _projectNo;

        public ProjectProgressDetailControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        internal void LoadData(string projectNo)
        {
            _projectNo = projectNo;
            var workOrderRep = new ProjectProgressController().GetWorkOrderByProjectNo(projectNo);
            if (!string.IsNullOrEmpty(workOrderRep.ErrorMessage))
            {
                MessageBox.Show(workOrderRep.ErrorMessage);
                return;
            }
            FillHeader(workOrderRep.result);

            var detailRep = new ProjectProgressController().GetDesignAssignmentList(projectNo);
            if (!string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                MessageBox.Show(detailRep.ErrorMessage);
                return;
            }
            FillGrid(detailRep.resultList ?? new List<設計派案>());

            var purchaseRep = new ProjectProgressController().GetPurchasePlanList(projectNo);
            if (!string.IsNullOrEmpty(purchaseRep.ErrorMessage))
            {
                MessageBox.Show(purchaseRep.ErrorMessage);
                return;
            }
            var purchaseList = purchaseRep.resultList ?? new List<採購計畫>();
            FillPurchaseGrid(purchaseList);
            FillProcessGrid(purchaseList);

            var moduleRep = new ProjectProgressController().GetModuleMaterialList(projectNo);
            if (!string.IsNullOrEmpty(moduleRep.ErrorMessage))
            {
                MessageBox.Show(moduleRep.ErrorMessage);
                return;
            }
            FillModuleGrid(moduleRep.resultList ?? new List<專案模組用料清單>());

            var electricRep = new ProjectProgressController().GetElectricScheduleList(projectNo);
            if (!string.IsNullOrEmpty(electricRep.ErrorMessage))
            {
                MessageBox.Show(electricRep.ErrorMessage);
                return;
            }
            FillElectricGrid(electricRep.resultList ?? new List<專案電控排程>());
        }

        private void FillHeader(工令單 x)
        {
            if (x == null) return;
            txtProjectNo.Text = x.專案序號;
            txtOrderDate.Text = x.訂單日期;
            txtCustShort.Text = x.客戶簡稱;
            txtCustName.Text = x.客戶名稱;
            txtMachineModel.Text = x.機台型號;
            txtMachineType.Text = x.機台類型;
            txtInspectDate.Text = x.驗機日期;
            txtDeliveryDate.Text = x.交貨日期;
            txtMachineName.Text = x.機台名稱;
        }

        private void FillGrid(List<設計派案> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.模組名稱;
                row.Cells[i++].Value = x.設計人員;
                row.Cells[i++].Value = x.設計圖類;
                row.Cells[i++].Value = x.製圖檔名;
                row.Cells[i++].Value = x.實際開工日;
                row.Cells[i++].Value = x.預計完工日;
                row.Cells[i++].Value = x.圖檔發行日;
                row.Cells[i++].Value = x.審圖通過;
                row.Cells[i++].Value = x.清單編號;
                dataGridView1.Rows.Add(row);
            }
        }

        private void FillPurchaseGrid(List<採購計畫> list)
        {
            dataGridView2.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                int i = 0;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.零件號碼;
                row.Cells[i++].Value = x.品名;
                row.Cells[i++].Value = x.描述;
                row.Cells[i++].Value = x.數量;
                row.Cells[i++].Value = x.零件分類;
                row.Cells[i++].Value = x.採購人員;
                row.Cells[i++].Value = x.實際採購日;
                row.Cells[i++].Value = x.預計到貨日;
                row.Cells[i++].Value = x.入庫移轉日;
                row.Cells[i++].Value = x.零件管制單號;
                dataGridView2.Rows.Add(row);
            }
        }

        private void FillProcessGrid(List<採購計畫> list)
        {
            dataGridView3.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView3);
                int i = 0;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.零件號碼;
                row.Cells[i++].Value = x.品名;
                row.Cells[i++].Value = x.產製單位1;
                row.Cells[i++].Value = x.開工日期1;
                row.Cells[i++].Value = x.完工日期1;
                row.Cells[i++].Value = x.產製單位2;
                row.Cells[i++].Value = x.開工日期2;
                row.Cells[i++].Value = x.完工日期2;
                row.Cells[i++].Value = x.產製單位3;
                row.Cells[i++].Value = x.開工日期3;
                row.Cells[i++].Value = x.完工日期3;
                row.Cells[i++].Value = x.產製單位4;
                row.Cells[i++].Value = x.開工日期4;
                row.Cells[i++].Value = x.完工日期4;
                row.Cells[i++].Value = x.產製單位5;
                row.Cells[i++].Value = x.開工日期5;
                row.Cells[i++].Value = x.完工日期5;
                dataGridView3.Rows.Add(row);
            }
        }

        private void FillModuleGrid(List<專案模組用料清單> list)
        {
            dataGridView4.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView4);
                int i = 0;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.模組名稱;
                row.Cells[i++].Value = x.製圖檔名;
                row.Cells[i++].Value = x.圖檔發行日;
                row.Cells[i++].Value = x.組裝人員;
                row.Cells[i++].Value = x.開工日期;
                row.Cells[i++].Value = x.預交日期;
                row.Cells[i++].Value = x.完工日期;
                row.Cells[i++].Value = x.結案回報;
                row.Cells[i++].Value = x.用途;
                dataGridView4.Rows.Add(row);
            }
        }

        private void FillElectricGrid(List<專案電控排程> list)
        {
            dataGridView5.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView5);
                int i = 0;
                row.Cells[i++].Value = x.電控工序;
                row.Cells[i++].Value = x.簡要描述;
                row.Cells[i++].Value = x.程控人員;
                row.Cells[i++].Value = x.開始作業日期;
                row.Cells[i++].Value = x.預計完成日期;
                row.Cells[i++].Value = x.實際完成日期;
                dataGridView5.Rows.Add(row);
            }
        }

        // ── 雙擊設計進度明細，開啟模組設計進度表頁籤 ─────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            OpenModuleDesignProgress();
        }

        private void OpenModuleDesignProgress()
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "ModuleDesignProgress";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ModuleDesignProgressControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData();
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("模組設計進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊組測進度標題列，開啟模組組測進度表頁籤 ─────────────────────
        private void panelModuleTitle_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(_projectNo)) return;
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleAssemTestProgress_" + _projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ModuleAssemTestProgressControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(_projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(_projectNo + " 模組組測進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        private void btnOverview_Click(object sender, System.EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnClose_Click(object sender, System.EventArgs e)
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
