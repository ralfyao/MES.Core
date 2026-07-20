using MES.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectReviewItem : Form
    {
        private readonly List<設計審查項目表> _items;
        public List<設計審查項目表> SelectedItems { get; private set; } = new List<設計審查項目表>();

        public FrmSelectReviewItem(List<設計審查項目表> items)
        {
            InitializeComponent();
            _items = items ?? new List<設計審查項目表>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colChecked.Index].Value = false;
                row.Cells[colReviewItem.Index].Value = x.審查項目;
                row.Tag = x;
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

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
                .Select(r => (設計審查項目表)r.Tag)
                .ToList();

            if (SelectedItems.Count == 0)
            {
                MessageBox.Show("請至少勾選一筆審查項目");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
