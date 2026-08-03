using MES.Core.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmSelectWorkOrder : Form
    {
        private List<工令單> _items;
        public 工令單 SelectedItem { get; private set; }

        public FrmSelectWorkOrder(List<工令單> items)
        {
            InitializeComponent();
            _items = items ?? new List<工令單>();
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
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colCustomerName.Index].Value = x.客戶名稱;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Tag = x;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedItem = (工令單)dataGridView1.Rows[e.RowIndex].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("請選擇一筆專案"); return; }
            SelectedItem = (工令單)dataGridView1.CurrentRow.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
