using DigiERP.Common;
using DigiERP.UserControl;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.SalesTracking
{
    public partial class SalesTrackingControl : CommonUserControl
    {
        private static string id = "7A2E5C39-8B4D-4E17-9F6A-3C5D8E1B4A67";

        public SalesTrackingControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            SetDefaultDateRange();
            LoadData();
        }

        private void SetDefaultDateRange()
        {
            var today = DateTime.Now;
            dtStart.Value = new DateTime(today.Year, 1, 1);
            dtEnd.Value = today;
        }

        private void LoadData()
        {
            var rep = new SalesTrackingController().GetSalesTrackingList(dtStart.Value.Date, dtEnd.Value.Date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<客戶活動力分析>());
        }

        private void FillGrid(List<客戶活動力分析> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colCustomer.Index].Value = x.客戶;
                row.Cells[colCountry.Index].Value = x.所屬國別;
                row.Cells[colYear.Index].Value = x.客戶建檔年度;
                row.Cells[colContactCount.Index].Value = x.客戶連絡次數;
                row.Cells[colRfqCount.Index].Value = x.詢問函筆數;
                row.Cells[colRfqContactCount.Index].Value = x.詢問函往來次數;
                row.Cells[colQuoteCount.Index].Value = x.報價單筆數;
                row.Cells[colCurrency.Index].Value = x.Currency;
                row.Cells[colExRate.Index].Value = x.換算匯率;
                row.Cells[colQuoteOrigAmt.Index].Value = x.報價原幣金額;
                row.Cells[colQuoteTwdAmt.Index].Value = x.報價台幣金額;
                row.Cells[colOrderCount.Index].Value = x.訂單筆數;
                row.Cells[colOrderOrigAmt.Index].Value = x.訂單原幣金額;
                row.Cells[colOrderTwdAmt.Index].Value = x.訂單台幣金額;
                row.Cells[colQtyRate.Index].Value = x.單數成交率?.ToString("P0");
                row.Cells[colAmtRate.Index].Value = x.金額成交率?.ToString("P0");
            }

            int total = dataGridView1.Rows.Add();
            var totalRow = dataGridView1.Rows[total];
            totalRow.Cells[colCustomer.Index].Value = "合計";
            totalRow.Cells[colQuoteOrigAmt.Index].Value = list.Sum(x => x.報價原幣金額 ?? 0);
            totalRow.Cells[colQuoteTwdAmt.Index].Value = list.Sum(x => x.報價台幣金額 ?? 0);
            totalRow.Cells[colOrderOrigAmt.Index].Value = list.Sum(x => x.訂單原幣金額 ?? 0);
            totalRow.Cells[colOrderTwdAmt.Index].Value = list.Sum(x => x.訂單台幣金額 ?? 0);
            totalRow.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }

        // ── 點選客戶欄位：於頁籤中開啟該客戶的客戶維護畫面 ──────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colCustomer.Index) return;
            string company = dataGridView1.Rows[e.RowIndex].Cells[colCustomer.Index].Value?.ToString();
            if (string.IsNullOrEmpty(company) || company == "合計") return;
            OpenCustomerMaintainTab(company);
        }

        private void OpenCustomerMaintainTab(string company)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = $"CustomerMaintain_{company}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var custRep = new CustomerController().GetCustomerByName(company);
            if (!string.IsNullOrEmpty(custRep.ErrorMessage))
            {
                MessageBox.Show(custRep.ErrorMessage);
                return;
            }
            if (custRep.result == null)
            {
                MessageBox.Show("查無此客戶資料");
                return;
            }
            var ctrl = new CustomerMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            ctrl.form = custRep.result;
            var lblMode = ctrl.Controls.Find("lblMode", true).FirstOrDefault() as Label;
            if (lblMode != null) lblMode.Text = "修改";
            ctrl.initForm();
            var tab = new TabPage($"客戶維護") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaultDateRange();
            LoadData();
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
