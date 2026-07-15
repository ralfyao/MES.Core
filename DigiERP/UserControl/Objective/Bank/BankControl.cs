using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class BankControl : CommonUserControl
    {
        private static string id = "3B7D9E24-6A1C-4F58-9D3B-8E5A2C7F1B94";

        public BankControl()
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
            var rep = new CustomerController().GetBankList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<F銀行設定>());
        }

        private void FillGrid(List<F銀行設定> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colBankCode.Index].Value = x.銀存編碼;
                row.Cells[colBankName.Index].Value = x.銀行名稱;
                row.Cells[colBankFullName.Index].Value = x.Bankname;
                row.Cells[colBeneficiary.Index].Value = x.Beneficiary;
                row.Cells[colAccountNo.Index].Value = x.帳號;
                row.Cells[colSwiftCode.Index].Value = x.SwiftCode;
                row.Cells[colContact.Index].Value = x.聯絡窗口;
                row.Cells[colPhone.Index].Value = x.電話;
                row.Cells[colExt.Index].Value = x.分機;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnMonthBalance_Click(object sender, EventArgs e)
        {
            using var frm = new BankMonthSummaryBalance();
            frm.monthEnd = dtMonthEnd.Value.ToString("yyyyMM");
            frm.initData();
            frm.ShowDialog(this);
        }
        /// <summary>
        /// 點選單號欄位：於頁籤中開啟該筆銀行設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colBankCode.Index) return;
            string bankCode = dataGridView1.Rows[e.RowIndex].Cells[colBankCode.Index].Value?.ToString();
            if (string.IsNullOrEmpty(bankCode)) return;
            OpenMaintainTab("修改", bankCode);
        }
        /// <summary>
        /// 新增銀行設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainTab("新增", null);
        }
        /// <summary>
        /// 開啟銀行設定維護的作業
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="bankCode"></param>
        private void OpenMaintainTab(string mode, string bankCode)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = mode == "新增" ? "BankMaintain_New" : $"BankMaintain_{bankCode}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new BankMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Saved += (s, args) => LoadData();
            var tab = new TabPage(mode == "新增" ? "銀行設定-新增" : $"銀行設定-{bankCode}") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
            ctrl.LoadData(mode, bankCode);
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
