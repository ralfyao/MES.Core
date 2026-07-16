using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class FrmStockInCertImport : Form
    {
        public List<F付款明細> ImportedItems { get; private set; } = new List<F付款明細>();

        private readonly string _supplierNo;
        private List<B進退貨驗收明細> _fullList = new List<B進退貨驗收明細>();

        public FrmStockInCertImport(string supplierNo)
        {
            InitializeComponent();
            _supplierNo = supplierNo;
            LoadData(null, null);
        }

        private void LoadData(DateTime? from, DateTime? to)
        {
            var rep = new StockInController().GetIncomeCertImportList_StockIn(_supplierNo, from, to);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<B進退貨驗收明細>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _fullList)
            {
                // 付款金額為含稅總額，依 5% 營業稅率反推未稅金額，確保 未稅金額+稅額=付款金額
                decimal amount = (decimal)(x.付款金額 ?? 0);
                decimal untaxed = Math.Round(amount / 1.05m, 0);
                decimal tax = amount - untaxed;

                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colNo.Index].Value = x.單號;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colHandler.Index].Value = x.姓名;
                row.Cells[colVerify.Index].Value = x.採購覆核;
                row.Cells[colItemNo.Index].Value = x.品項編號;
                row.Cells[colDesc.Index].Value = x.品名規格;
                row.Cells[colCheck.Index].Value = x.勾選 ?? false;
                row.Cells[colUntaxed.Index].Value = untaxed;
                row.Cells[colTax.Index].Value = tax;
                row.Cells[colAmount.Index].Value = amount;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? from = dtFrom.Checked ? dtFrom.Value.Date : (DateTime?)null;
            DateTime? to = dtTo.Checked ? dtTo.Value.Date : (DateTime?)null;
            LoadData(from, to);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ImportedItems = new List<F付款明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                bool @checked = row.Cells[colCheck.Index].Value is bool b && b;
                if (!@checked) continue;
                ImportedItems.Add(new F付款明細
                {
                    帳款來源 = row.Cells[colNo.Index].Value?.ToString(),
                    沖帳碼 = row.Cells[colItemNo.Index].Value?.ToString(),
                    原幣收帳金額 = decimal.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var amt) ? amt : 0,
                    說明 = row.Cells[colDesc.Index].Value?.ToString()
                });
            }
            if (ImportedItems.Count == 0)
            {
                MessageBox.Show("請至少勾選一筆項目!");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
