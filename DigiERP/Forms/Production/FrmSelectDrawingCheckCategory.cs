using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectDrawingCheckCategory : Form
    {
        private List<模組圖檢查> _items;
        public 模組圖檢查 SelectedItem { get; private set; }

        public FrmSelectDrawingCheckCategory(List<模組圖檢查> items)
        {
            InitializeComponent();
            _items = items ?? new List<模組圖檢查>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colCheckCategory.Index].Value = x.檢查分類;
                row.Cells[colDuty.Index].Value = x.職務;
                row.Tag = x;
            }
        }

        // ── 新增：開啟空白的模組圖自檢一覽表建立新分類，關閉後重新整理清單 ──
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using var addForm = new FrmModuleCheckList();
            addForm.ShowDialog(this);

            var rep = new ProjectProgressController().GetModuleDrawingCheckList();
            _items = rep.resultList ?? new List<模組圖檢查>();
            FillGrid();
        }

        // ── 雙擊：開啟該筆檢查分類進行編輯(非選取)，關閉後重新整理清單 ──────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var category = (模組圖檢查)dataGridView1.Rows[e.RowIndex].Tag;

            using var editForm = new FrmModuleCheckList(category);
            editForm.ShowDialog(this);

            var rep = new ProjectProgressController().GetModuleDrawingCheckList();
            _items = rep.resultList ?? new List<模組圖檢查>();
            FillGrid();
        }

        // ── 確定選擇：把目前選取的檢查分類帶回上一層 ────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一筆檢查分類");
                return;
            }
            SelectedItem = (模組圖檢查)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
