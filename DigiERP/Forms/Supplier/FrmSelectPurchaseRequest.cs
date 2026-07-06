using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class FrmSelectPurchaseRequest : Form
    {
        public B請購需求? Selected { get; private set; }

        private List<B請購需求> _fullList = new List<B請購需求>();

        public FrmSelectPurchaseRequest()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var rep = new ProcurementController().AllPurchaseRequestList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = (rep.resultList ?? new List<B請購需求>()).Where(x => x.結案 != true).ToList();
            FillGrid(_fullList);
        }

        private void FillGrid(List<B請購需求> list)
        {
            dgvRequest.Rows.Clear();
            foreach (var r in list)
            {
                int idx = dgvRequest.Rows.Add();
                var row = dgvRequest.Rows[idx];
                row.Cells[colProductNo.Index].Value = r.品項編號;
                row.Cells[colSpec.Index].Value = r.品名規格;
                row.Cells[colQty.Index].Value = r.數量;
                row.Cells[colUrgent.Index].Value = (r.緊急 ?? false) ? "是" : "";
                row.Cells[colDemandDate.Index].Value = r.需求日期;
                row.Tag = r;
            }
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvRequest.Rows[rowIndex].IsNewRow) return;
            Selected = dgvRequest.Rows[rowIndex].Tag as B請購需求;
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
