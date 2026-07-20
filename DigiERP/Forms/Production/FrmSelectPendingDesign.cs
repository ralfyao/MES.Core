using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectPendingDesign : Form
    {
        private readonly List<設計派案> _items;
        public 設計派案 SelectedItem { get; private set; }

        public FrmSelectPendingDesign(List<設計派案> items)
        {
            InitializeComponent();
            _items = items ?? new List<設計派案>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colDesigner.Index].Value = x.設計人員;
                row.Cells[colDrawingFile.Index].Value = x.製圖檔名;
                row.Cells[colDrawingIssueDate.Index].Value = x.圖檔發行日;
                row.Tag = x;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Confirm(e.RowIndex);
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一筆設計派案");
                return;
            }
            Confirm(dataGridView1.CurrentRow.Index);
        }

        private void Confirm(int rowIndex)
        {
            SelectedItem = (設計派案)dataGridView1.Rows[rowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
