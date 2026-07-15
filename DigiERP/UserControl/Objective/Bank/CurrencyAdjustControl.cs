using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class CurrencyAdjustControl : CommonUserControl
    {
        private static string id = "6D3A8F27-4C9B-4E15-9A7D-2E5C8B4F9D63";

        public CurrencyAdjustControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var rep = new CurrencyAdjustController().GetCurrencyAdjustList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<資金調節總覽>());
        }

        private void FillGrid(List<資金調節總覽> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colNo.Index].Value = x.單號;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colPurpose.Index].Value = x.用途;
                row.Cells[colVoucherNo.Index].Value = x.傳票編號;
                row.Cells[colRemark.Index].Value = x.備註;
                row.Cells[colCreator.Index].Value = x.建檔;
                row.Cells[colApproval.Index].Value = x.核准;
                row.Cells[colBankCode.Index].Value = x.銀存編碼;
                row.Cells[colSummary.Index].Value = x.摘要;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainTab(null, "新增");
        }

        // ── 點選單號欄位：於頁籤中開啟該筆資金調節單 ───────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colNo.Index) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            OpenMaintainTab(no, "修改");
        }

        private void OpenMaintainTab(string no, string mode)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = mode == "新增" ? "CurrencyAdjustMaintain_New" : $"CurrencyAdjustMaintain_{no}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new CurrencyAdjustMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Saved += (s, args) => LoadData();
            var tab = new TabPage(mode == "新增" ? "資金調節" : $"資金調節") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
            ctrl.LoadData(mode, no);
        }

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
