using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.Overtime
{
    // ── 加班申請單/加班明細表身「員工編號」選取視窗：列出狀況正常之員工，
    //    比照全站「Grid 儲存格內開啟選取彈窗」慣例(FrmSelectStaff 等) ────────
    public partial class FrmSelectOvertimeEmployee : Form
    {
        private List<H員工清冊> _items;
        public H員工清冊 SelectedItem { get; private set; }

        public FrmSelectOvertimeEmployee(List<H員工清冊> items)
        {
            InitializeComponent();
            _items = items ?? new List<H員工清冊>();
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in _items)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colEmpNo.Index].Value = x.工號;
                row.Cells[colName.Index].Value = x.姓名;
                row.Tag = x;
            }
        }

        // ── 雙擊：直接選取該筆員工並帶回上一層 ────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (H員工清冊)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 確定選擇：把目前選取的員工帶回上一層 ─────────────────────────
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請選擇一位員工");
                return;
            }
            SelectedItem = (H員工清冊)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
