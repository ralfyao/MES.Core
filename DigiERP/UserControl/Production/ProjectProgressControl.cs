using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ProjectProgressControl : CommonUserControl
    {
        private static string id = "5B9E3A17-2D6C-4F84-9A1B-8E7D3C4F6A29";

        public ProjectProgressControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initGrid();
            dataGridView1.Resize += (s, e) => PositionGroupHeaders();
            PositionGroupHeaders();
        }

        // ── 讓群組表頭(作業流程/設計/採購...)的寬度隨 dataGridView1 的欄寬(Fill模式)同步對齊 ──
        private void PositionGroupHeaders()
        {
            Label[] groupLabels = { lblGrpFlow, lblGrpDesign, lblGrpPurchase, lblGrpProcess, lblGrpMachine, lblGrpSpecial, lblGrpPrecision, lblGrpAntiDeform, lblGrpSurface, lblGrpAssembly, lblGrpElectrical };
            int[] groupColumnCounts = { 1, 4, 4, 1, 2, 2, 2, 2, 2, 3, 4 };
            int colIndex = 0;
            int x = 0;
            for (int g = 0; g < groupColumnCounts.Length; g++)
            {
                int width = 0;
                for (int c = 0; c < groupColumnCounts[g]; c++)
                {
                    width += dataGridView1.Columns[colIndex].Width;
                    colIndex++;
                }
                groupLabels[g].Left = x;
                groupLabels[g].Width = width;
                groupLabels[g].Top = 0;
                groupLabels[g].Height = panelGroupHeader.Height;
                x += width;
            }
        }

        private void initGrid()
        {
            var rep = new ProjectProgressController().GetProjectProgressList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<專案進度表>());
        }

        private void FillGrid(List<專案進度表> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.D;
                row.Cells[i++].Value = x.DS;
                row.Cells[i++].Value = x.DF;
                row.Cells[i++].Value = x.DP + "%";
                row.Cells[i++].Value = x.P;
                row.Cells[i++].Value = x.PS;
                row.Cells[i++].Value = x.PF;
                row.Cells[i++].Value = x.PP + "%";
                row.Cells[i++].Value = x.M;
                row.Cells[i++].Value = x.M1S;
                row.Cells[i++].Value = x.M1F;
                row.Cells[i++].Value = x.M2S;
                row.Cells[i++].Value = x.M2F;
                row.Cells[i++].Value = x.M3S;
                row.Cells[i++].Value = x.M3F;
                row.Cells[i++].Value = x.M4S;
                row.Cells[i++].Value = x.M4F;
                row.Cells[i++].Value = x.M5S;
                row.Cells[i++].Value = x.M5F;
                row.Cells[i++].Value = x.ASP;
                row.Cells[i++].Value = x.AF;
                row.Cells[i++].Value = x.AUF + "%";
                row.Cells[i++].Value = x.E;
                row.Cells[i++].Value = x.ES;
                row.Cells[i++].Value = x.EF;
                row.Cells[i++].Value = x.EUF + "%";
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 專案序號(綠)：開啟專案管控表頁籤 / 進度%(紅) 點擊：對應之明細查詢畫面尚未提供 ─────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == colProjectNo.Index)
            {
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(projectNo)) OpenProjectProgressDetail(projectNo);
            }
            else if (e.ColumnIndex == colDP.Index)
            {
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(projectNo)) OpenModuleDesignProgress(projectNo);
            }
            else if (e.ColumnIndex == colPP.Index)
            {
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(projectNo)) OpenModuleProcurementProgress(projectNo);
            }
            else if (e.ColumnIndex == colAUF.Index)
            {
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(projectNo)) OpenModuleAssemTestProgress(projectNo);
            }
            else if (e.ColumnIndex == colEUF.Index)
            {
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(projectNo)) OpenElecControlProgress(projectNo);
            }
        }

        // ── 點擊電控進度%，開啟該專案篩選後的專案電控進度表頁籤 ───────────
        private void OpenElecControlProgress(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ElecControlProgress_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ElecControlProgressControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + " 電控進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊組測進度%，開啟該專案篩選後的模組組測進度表頁籤 ───────────
        private void OpenModuleAssemTestProgress(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleAssemTestProgress_" + projectNo;
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
            ctrl.LoadData(projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + "組測進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊採購進度%，開啟該專案篩選後的模組零件採購進度表頁籤 ───────
        private void OpenModuleProcurementProgress(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleProcurementProgress_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ModuleProcurementProgressControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + " 採購進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊設計進度%，開啟該專案篩選後的模組設計進度表頁籤 ───────────
        private void OpenModuleDesignProgress(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleDesignProgress_" + projectNo;
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
            ctrl.LoadData(projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + " 設計進度表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊專案序號，開啟專案管控表頁籤(顯示工令單表頭與設計派案明細) ───
        private void OpenProjectProgressDetail(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ProjectProgressDetail_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var detail = new ProjectProgressDetailControl();
            if (detail.IsDisposed) return;
            detail.LoadData(projectNo);
            detail.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + " 專案管控表") { Name = tabName };
            tab.Controls.Add(detail);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 點擊專案排程查詢，開啟排程查詢頁籤 ────────────────────────────
        private void btnScheduleQuery_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "ProjectScheduleQuery";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ProjectScheduleQueryControl();
            if (ctrl.IsDisposed) return;
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("專案排程查詢") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        // ── 關閉 — 回到列表，或若是獨立頁籤則直接關閉該頁籤 ───────────────
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

        // ── Grid 回顯時重刷 ──────────────────────────────────────────────
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                initGrid();
                PositionGroupHeaders();
            }
        }
    }
}
