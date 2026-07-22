using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectStaff : Form
    {
        private List<成本單位人員配置> _items;
        public 成本單位人員配置 SelectedItem { get; private set; }

        public FrmSelectStaff(List<成本單位人員配置> items)
        {
            InitializeComponent();
            _items = items ?? new List<成本單位人員配置>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colName.Index].Value = x.姓名;
                row.Cells[colEmpNo.Index].Value = x.員工編號;
                row.Tag = x;
            }
        }

        // ── 雙擊：直接選取該筆人員並帶回上一層 ────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (成本單位人員配置)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 確定選擇：把目前選取的人員帶回上一層 ─────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一位人員");
                return;
            }
            SelectedItem = (成本單位人員配置)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
