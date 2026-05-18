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
    public partial class FrmQuotationDetailList : Form
    {
        public string quotationNo { get; set; }
        public FrmQuotationDetailList()
        {
            InitializeComponent();
        }
        CustomerController customerController = new CustomerController();
        internal void GetQuotationDetail()
        {
            if (customerController == null)
            {
                customerController = new CustomerController();
            }
            CommonRep<C報價明細> commonRep = customerController.GetQuotationDetailList(quotationNo);
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.單價;
                row.Cells[index++].Value = item.金額;
                row.Cells[index++].Value = item.描述;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }
    }
}
