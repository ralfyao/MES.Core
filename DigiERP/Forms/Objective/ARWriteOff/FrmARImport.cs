using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.ARWriteOff
{
    public partial class FrmARImport : Form
    {
        public List<F收支沖帳明細> ImportedItems { get; private set; } = new List<F收支沖帳明細>();

        private readonly string _custNo;
        private List<應收帳款導入清單> _fullList = new List<應收帳款導入清單>();

        public FrmARImport(string custNo)
        {
            InitializeComponent();
            _custNo = custNo;
            LoadData();
        }

        private void LoadData()
        {
            var rep = new ARController().GetReceivableImportList(_custNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<應收帳款導入清單>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<應收帳款導入清單> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colSource.Index].Value = x.帳款來源;
                row.Cells[colAccDate.Index].Value = x.帳款日期;
                row.Cells[colDocType.Index].Value = x.請款;
                row.Cells[colOffsetCode.Index].Value = x.請款單號;
                row.Cells[colInvoiceNo.Index].Value = x.發票號碼;
                row.Cells[colTerm.Index].Value = x.備註;
                row.Cells[colCheck.Index].Value = false;
                row.Cells[colCurrency.Index].Value = x.幣別;
                row.Cells[colOrigUntaxed.Index].Value = x.原幣未稅;
                row.Cells[colTwdUntaxed.Index].Value = x.未稅;
                row.Cells[colTax.Index].Value = x.稅;
                row.Cells[colAmount.Index].Value = x.金額;
            }
        }

        // ── 日期區間篩選：後端未提供日期參數，改於已載入清單上做前端過濾 ──────────
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? from = dtFrom.Checked ? dtFrom.Value.Date : (DateTime?)null;
            DateTime? to = dtTo.Checked ? dtTo.Value.Date : (DateTime?)null;
            if (from == null && to == null) { FillGrid(_fullList); return; }

            var filtered = _fullList.Where(x =>
            {
                if (!DateTime.TryParse(x.帳款日期, out var d)) return false;
                if (from != null && d.Date < from.Value.Date) return false;
                if (to != null && d.Date > to.Value.Date) return false;
                return true;
            }).ToList();
            FillGrid(filtered);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ImportedItems = new List<F收支沖帳明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                bool @checked = row.Cells[colCheck.Index].Value is bool b && b;
                if (!@checked) continue;

                string source = row.Cells[colSource.Index].Value?.ToString();
                string offsetCode = row.Cells[colOffsetCode.Index].Value?.ToString();
                if (string.IsNullOrEmpty(source) && string.IsNullOrEmpty(offsetCode)) continue; // 空資料不帶回收款單

                ImportedItems.Add(new F收支沖帳明細
                {
                    帳款來源 = source,
                    帳款日期 = row.Cells[colAccDate.Index].Value?.ToString(),
                    沖帳碼 = offsetCode,
                    原幣未稅 = ParseDecimal(row.Cells[colOrigUntaxed.Index].Value),
                    台幣未稅 = ParseDecimal(row.Cells[colTwdUntaxed.Index].Value),
                    稅 = ParseDecimal(row.Cells[colTax.Index].Value),
                    金額 = ParseDecimal(row.Cells[colAmount.Index].Value),
                    備註 = row.Cells[colTerm.Index].Value?.ToString(),
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

        private static decimal ParseDecimal(object v) => decimal.TryParse(v?.ToString(), out var d) ? d : 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
