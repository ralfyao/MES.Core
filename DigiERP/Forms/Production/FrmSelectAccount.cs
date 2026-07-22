using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectAccount : Form
    {
        private List<account> _items;
        public account SelectedItem { get; private set; }

        public FrmSelectAccount(List<account> items)
        {
            InitializeComponent();
            _items = items ?? new List<account>();
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
                row.Cells[colAccountNo.Index].Value = x.帳號;
                row.Tag = x;
            }
        }

        // ── 雙擊：直接選取該帳號並帶回上一層 ────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (account)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 確定選擇：把目前選取的帳號帶回上一層 ─────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一位人員");
                return;
            }
            SelectedItem = (account)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
