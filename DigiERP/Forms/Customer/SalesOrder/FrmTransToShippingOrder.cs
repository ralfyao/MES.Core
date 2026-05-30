using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmTransToShippingOrder : Form
    {
        private CustomerController _customerController;
        public void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }
        public string custId { get; set; }
        public FrmTransToShippingOrder()
        {
            InitializeComponent();
        }

        private void btnTransShippingOrder_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            initController();
            CommonRep<C訂單明細> commonRep = _customerController.GetShipOrderListBySalesOrderId(custId);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            int index = 0;
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別碼;
                index++;//勾選
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.出貨數量;
                row.Cells[index++].Value = item.數量1;
                row.Cells[index++].Value = item.建檔;
                row.Cells[index++].Value = item.QUONO;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 判斷是不是 checkbox 欄
            if (e.RowIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "勾選")
            {
                // 先取消所有勾選
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["勾選"].Value = false;
                }

                // 勾選目前列
                dataGridView1.Rows[e.RowIndex].Cells["勾選"].Value = true;
            }
        }
    }
}
