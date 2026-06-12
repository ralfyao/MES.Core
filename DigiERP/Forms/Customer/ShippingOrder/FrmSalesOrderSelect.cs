using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.ShippingOrder
{
    public partial class FrmSalesOrderSelect : Form
    {
        public string custId { get; set; }
        private CustomerController _customerController;
        public FrmSalesOrderSelect()
        {
            InitializeComponent();
            initController();
        }

        public void initDataGrid()
        {
            if (string.IsNullOrEmpty(custId))
            {
                return;
            }
            var salesOrderForShipping = _customerController.getSalesOrderLinesForShipping(custId);
            if (!string.IsNullOrEmpty(salesOrderForShipping.ErrorMessage))
            {
                MessageBox.Show(salesOrderForShipping.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in salesOrderForShipping.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別碼;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量1;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.單價1;
                row.Cells[index++].Value = item.單號;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }
        public C訂單明細 selectedOrderLine { get; set; }
        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrderLine = new C訂單明細();
            selectedOrderLine.單號 = dataGridView1.Rows[e.RowIndex].Cells["SalesOrderNo"].Value?.ToString();
            selectedOrderLine.產品編號 = dataGridView1.Rows[e.RowIndex].Cells["ProductNo"].Value?.ToString();
            selectedOrderLine.品名規格 = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value?.ToString();
            try
            {
                selectedOrderLine.數量1 =decimal.Parse( dataGridView1.Rows[e.RowIndex].Cells["Qty"].Value?.ToString());
            }
            catch (Exception)
            {
                selectedOrderLine.數量1 = 0;
            }
            selectedOrderLine.單位 = dataGridView1.Rows[e.RowIndex].Cells["Unit"].Value?.ToString();
            try
            {
                selectedOrderLine.單價1 =decimal.Parse( dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value?.ToString());
            }
            catch (Exception)
            {
                selectedOrderLine.單價1 = 0;
            }
            this.DialogResult = DialogResult.OK;
            Dispose();
            Close();
        }
    }
}
