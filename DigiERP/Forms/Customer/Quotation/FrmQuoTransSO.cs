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

namespace DigiERP.Forms.Customer.Quotation
{
    public partial class FrmQuoTransSO : Form
    {
        public string quotationNo { get; set; }
        private CustomerController _customerController {get; set;}
        public FrmQuoTransSO()
        {
            InitializeComponent();
        }

        public void queryData()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            CommonRep<C訂單明細> soList = _customerController.QueryTransferToSalesOrder(quotationNo);
            if (!string.IsNullOrEmpty(soList.ErrorMessage))
            {
                MessageBox.Show(soList.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach(var item in soList.resultList) 
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量1;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.單價1;
                row.Cells[index++].Value = item.金額1;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = quotationNo;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
