using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.Overtime
{
    // ── 加班明細表身「加班事由」選取視窗：列出 H加班事由 主檔，選取後帶回
    //    加班事由代碼(比照原 Access ComboBox RowSourceType=Table/Query 直接
    //    綁定 dbo_H加班事由 表格、預設 BoundColumn=第1欄=加班事由代碼) ────────
    public partial class FrmSelectOvertimeReason : Form
    {
        private List<H加班事由> _items;
        public H加班事由 SelectedItem { get; private set; }

        public FrmSelectOvertimeReason(List<H加班事由> items)
        {
            InitializeComponent();
            _items = items ?? new List<H加班事由>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colCode.Index].Value = x.加班事由代碼;
                row.Cells[colReason.Index].Value = x.加班事由;
                row.Tag = x;
            }
        }

        // ── 雙擊：直接選取該筆事由並帶回上一層 ────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (H加班事由)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 確定選擇：把目前選取的事由帶回上一層 ─────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一筆加班事由");
                return;
            }
            SelectedItem = (H加班事由)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
