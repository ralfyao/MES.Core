using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectPurchasePart : Form
    {
        private List<可領用零件清單> _items;
        public 可領用零件清單 SelectedItem { get; private set; }

        public FrmSelectPurchasePart(List<可領用零件清單> items)
        {
            InitializeComponent();
            _items = items ?? new List<可領用零件清單>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colProductNo.Index].Value = x.產品編號;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartName.Index].Value = x.品名;
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colControlNo.Index].Value = x.零件管制單號;
                row.Cells[colPartCategory.Index].Value = x.零件分類;
                row.Cells[colBomNo.Index].Value = x.BOM編號;
                row.Tag = x;
            }
        }

        // ── 雙擊：直接選取該筆零件並帶回上一層 ────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (可領用零件清單)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 確定選擇：把目前選取的零件帶回上一層 ─────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一筆零件");
                return;
            }
            SelectedItem = (可領用零件清單)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
