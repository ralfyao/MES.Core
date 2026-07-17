using DigiERP.Common;
using DigiERP.Forms.Accounting;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Accounting
{
    public partial class BillControl : CommonUserControl
    {
        private static string id = "C5F06577-607C-4B09-AB35-C61F885DC52B";

        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();
        private Dictionary<string, C客戶設定> _customerMap = new Dictionary<string, C客戶設定>();

        public BillControl()
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
            initSupplierMap();
            initCustomerMap();

            var rep = new BillController().GetBillList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<F票據異動>());
        }

        private void initSupplierMap()
        {
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            _supplierMap = (rep.resultList ?? new List<B廠商設定>())
                .Where(s => !string.IsNullOrEmpty(s.廠商編號))
                .GroupBy(s => s.廠商編號!)
                .ToDictionary(g => g.Key, g => g.First());
        }

        private void initCustomerMap()
        {
            var rep = new CustomerController().getCustomerList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            _customerMap = (rep.resultList ?? new List<C客戶設定>())
                .Where(c => !string.IsNullOrEmpty(c.正航編號))
                .GroupBy(c => c.正航編號!)
                .ToDictionary(g => g.Key, g => g.First());
        }

        // ── 對象名稱：=IIf(IsNull([對象]),"",IIf([收付別]="付",DLookUp(廠商名稱...),IIf(IsNull([收付別]),"",DLookUp(COMPANY...)))) ──
        private string ResolveTargetName(F票據異動 x)
        {
            if (string.IsNullOrEmpty(x.對象)) return "";
            if ((x.收付別 ?? "").Trim() == "付")
            {
                _supplierMap.TryGetValue(x.對象.Trim(), out var supplier);
                return supplier?.廠商名稱 ?? "";
            }
            if (string.IsNullOrEmpty(x.收付別)) return "";
            _customerMap.TryGetValue(x.對象.Trim(), out var customer);
            return customer?.COMPANY ?? "";
        }

        private void FillGrid(List<F票據異動> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colBillNo.Index].Value = x.票據號碼;
                row.Cells[colPayDate.Index].Value = x.收付日期;
                row.Cells[colPayType.Index].Value = x.收付別;
                row.Cells[colTargetCode.Index].Value = x.對象;
                row.Cells[colTargetName.Index].Value = ResolveTargetName(x);
                row.Cells[colBankAccount.Index].Value = x.兌付帳戶;
                row.Cells[colCashDate.Index].Value = x.兌現日期;
                row.Cells[colBillStatus.Index].Value = x.票況;
                row.Cells[colLinkNo.Index].Value = x.連結單號;
                row.Cells[colAmount.Index].Value = x.金額;
                row.Cells[colCollectDate.Index].Value = x.代收日期;
                row.Cells[colVoucherNo.Index].Value = x.傳票編號;
                row.Cells[colTargetBank.Index].Value = x.對象銀行;
                row.Cells[colRemark.Index].Value = x.備註;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new FrmBill();
            frm.ShowDialog(this);
            initGrid();
        }

        // ── 點選票據號碼，開啟該筆票據異動資料 ──────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colBillNo) return;
            string billNo = dataGridView1.Rows[e.RowIndex].Cells[colBillNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(billNo)) return;

            using var frm = new FrmBill();
            frm.LoadExisting(billNo);
            frm.ShowDialog(this);
            initGrid();
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
