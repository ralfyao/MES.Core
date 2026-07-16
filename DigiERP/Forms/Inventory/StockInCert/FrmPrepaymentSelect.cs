using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class FrmPrepaymentSelect : Form
    {
        public List<F付款明細> ImportedItems { get; private set; } = new List<F付款明細>();

        private List<B採購明細> _fullList = new List<B採購明細>();

        public FrmPrepaymentSelect(string supplierNo)
        {
            InitializeComponent();
            LoadData(supplierNo);
        }

        private void LoadData(string supplierNo)
        {
            var rep = new ProcurementController().GetPrepaymentImportList(supplierNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<B採購明細>();
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
                row.Cells[colItemNo.Index].Value = x.品項編號;
                row.Cells[colDesc.Index].Value = x.品名規格;
                row.Cells[colAmount.Index].Value = x.採購金額;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectRow(e.RowIndex);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆項目!");
                return;
            }
            SelectRow(dataGridView1.CurrentRow.Index);
        }

        private void SelectRow(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];
            ImportedItems = new List<F付款明細>
            {
                new F付款明細
                {
                    帳款來源 = row.Cells[colNo.Index].Value?.ToString(),
                    沖帳碼 = row.Cells[colItemNo.Index].Value?.ToString(),
                    原幣收帳金額 = decimal.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var amt) ? amt : 0,
                    說明 = row.Cells[colDesc.Index].Value?.ToString()
                }
            };
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
