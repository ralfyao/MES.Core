using MES.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmSelectPartCode : Form
    {
        private readonly List<A材料> _items;
        public List<A材料> SelectedItems { get; private set; } = new List<A材料>();

        public FrmSelectPartCode(List<A材料> items)
        {
            InitializeComponent();
            _items = items ?? new List<A材料>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var m in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colProductNo.Index].Value = m.產品編號;
                row.Cells[colProductCode.Index].Value = m.產品代號;
                row.Cells[colSpec.Index].Value = m.品名規格;
                row.Cells[colChecked.Index].Value = false;
                row.Cells[colType.Index].Value = m.品別;
                row.Tag = m;
            }
        }

        // ── 勾選 CheckBox 需立即提交才會即時反映在 Value 上 ─────────────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── FullRowSelect 下，勾選欄第一下只會選取整列而不會勾選，
        //    改在 MouseDown 就先切到該格並進入編輯，讓同一下點擊就能勾選 ──
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colChecked.Index) return;
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[colChecked.Index];
            dataGridView1.BeginEdit(true);
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            SelectedItems = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Cells[colChecked.Index].Value is bool b && b)
                .Select(r => (A材料)r.Tag)
                .ToList();

            if (SelectedItems.Count == 0)
            {
                MessageBox.Show("請至少勾選一筆料號");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
