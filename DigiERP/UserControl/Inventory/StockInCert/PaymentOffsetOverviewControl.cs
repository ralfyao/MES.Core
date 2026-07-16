using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class PaymentOffsetOverviewControl : CommonUserControl
    {
        // 此畫面（付款沖帳總覽）為新建立功能，尚未註冊於既有選單，需在權限管理畫面另行設定存取權限
        private static string id = "9E4C7A28-3D6F-4B81-A159-6C2E8D4F7A93";

        private List<付款沖帳總覽> _fullList = new List<付款沖帳總覽>();
        private bool _showOver60 = false;

        public PaymentOffsetOverviewControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initGrid();
        }

        private void initGrid()
        {
            var rep = new StockInController().GetPaymentOffsetOverviewList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<付款沖帳總覽>();
            lblTitle.Text = _showOver60 ? "付款沖帳總覽-超過60天" : "付款沖帳總覽-60天內";
            FillGrid();
        }

        private void FillGrid()
        {
            var threshold = DateTime.Now.Date.AddDays(-60);
            var list = _fullList.Where(x =>
            {
                bool ok = DateTime.TryParse(x.日期, out var d);
                bool within60 = ok && d >= threshold;
                return _showOver60 ? !within60 : within60;
            }).ToList();

            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colNo.Index].Value = x.單號;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colSupplierNo.Index].Value = x.廠商編號;
                row.Cells[colSupplierName.Index].Value = x.廠商名稱;
                row.Cells[colCurrency.Index].Value = x.幣別;
                row.Cells[colOrigUntaxed.Index].Value = x.原幣未稅之總計;
                row.Cells[colAmount.Index].Value = x.金額之總計;
                row.Cells[colOrigOffset.Index].Value = x.原幣沖帳金額之總計;
                row.Cells[colTwdOffset.Index].Value = x.台幣沖帳金額之總計;
                row.Cells[colAllowance.Index].Value = x.折讓金額之總計;
                row.Cells[colExDiff.Index].Value = x.匯差之總計;
                row.Cells[colReviewer.Index].Value = x.核准;
                row.Cells[colReviewDate.Index].Value = x.核准日;
            }
        }

        private void btnWithin60_Click(object sender, EventArgs e)
        {
            _showOver60 = false;
            initGrid();
        }

        private void btnOver60_Click(object sender, EventArgs e)
        {
            _showOver60 = true;
            initGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainTab(null, "新增");
        }

        // ── 點選單號欄位：於頁籤中開啟該筆付款沖帳單 ─────────────────────────
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
            string tabName = mode == "新增" ? "PaymentOffsetMaintain_New" : $"PaymentOffsetMaintain_{no}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new PaymentOffsetMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Saved += (s, args) => initGrid();
            var tab = new TabPage(mode == "新增" ? "付款沖帳-新增" : $"付款沖帳-{no}") { Name = tabName };
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
