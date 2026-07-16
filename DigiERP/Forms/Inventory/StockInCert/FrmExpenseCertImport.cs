using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class FrmExpenseCertImport : Form
    {
        public List<F付款明細> ImportedItems { get; private set; } = new List<F付款明細>();

        private readonly string _supplierNo;
        private List<F其他收支明細> _fullList = new List<F其他收支明細>();

        public FrmExpenseCertImport(string supplierNo)
        {
            InitializeComponent();
            _supplierNo = supplierNo;
            LoadData(null, null);
        }

        private void LoadData(DateTime? from, DateTime? to)
        {
            var rep = new GeneralExpensesController().GetExpenseCertImportList(_supplierNo, from, to);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<F其他收支明細>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _fullList)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colNo.Index].Value = x.單號;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colHandler.Index].Value = x.姓名;
                row.Cells[colVerify.Index].Value = x.核准;
                row.Cells[colItemNo.Index].Value = x.項目編號;
                row.Cells[colDesc.Index].Value = x.備註;
                row.Cells[colCheck.Index].Value = (x.勾選 ?? 0) != 0;
                row.Cells[colUntaxed.Index].Value = x.未稅;
                row.Cells[colTax.Index].Value = x.稅;
                row.Cells[colAmount.Index].Value = x.金額;
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
