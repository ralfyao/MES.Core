using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmMaterialItemCode : Form
    {
        private ItemController _controller;
        private List<A材料品項代號> _list = new List<A材料品項代號>();

        public FrmMaterialItemCode()
        {
            InitializeComponent();
            _controller = new ItemController();
            initGrid();
        }

        private void initGrid()
        {
            var rep = _controller.GetPartCodeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _list = rep.resultList ?? new List<A材料品項代號>();
            FillGrid(_list);
        }

        private void FillGrid(List<A材料品項代號> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var m in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = m.產品代號;
                row.Cells[i++].Value = m.大分類;
                row.Cells[i++].Value = m.小分類;
                row.Cells[i++].Value = m.小分類名稱;
                row.Cells[i++].Value = m.密度;
                row.Cells[i++].Value = m.公式代號;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 大分類/公式代號欄位：按下後跳出選取視窗，選取結果帶入該欄位 ─────
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colCategory.Index)
            {
                using var dlg = new FrmSelectMaterialCategory();
                if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[colCategory.Index].Value = dlg.Selected.大分類;
                }
            }
            else if (e.ColumnIndex == colFormula.Index)
            {
                using var dlg = new FrmSelectMaterialFormula();
                if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[colFormula.Index].Value = dlg.Selected.公式代號;
                }
            }
        }

        // ── 新增材料產品代號：跳出新增視窗，儲存後回到本頁並重新查詢 ─────────
        private void btnAddPartCode_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmAddPartCode();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                initGrid();
            }
        }
    }
}
