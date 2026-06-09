using DigiERP.UserControl.Customer.SalesOrder;
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

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmSalesOrderPrint : Form
    {
        public C訂單 customerOrder;
        public decimal percent;
        public FrmSalesOrderPrint()
        {
            InitializeComponent();
        }
        public FrmSalesOrderPrint(C訂單 customerOrder)
        {
            InitializeComponent();
            this.customerOrder = customerOrder;
            //this.initGrid();
        }

        public void initGrid()
        {
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach(var item in customerOrder.orderListDetail)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.數量1 ;
                row.Cells[index++].Value = item.單價1 * percent;
                row.Cells[index++].Value = item.數量1 * item.單價1 * percent;
                index++;
                row.Cells[index++].Value = item.專案序號;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void btnCorderT_Click(object sender, EventArgs e)
        {
            FrmPrintSalesOrderCT frmPrintSalesOrderCT = new FrmPrintSalesOrderCT();
            frmPrintSalesOrderCT.form = customerOrder;
            frmPrintSalesOrderCT.initControls();
            frmPrintSalesOrderCT.initData();
            frmPrintSalesOrderCT.ShowDialog(this);
        }

        private void btnPerformaInvoiceT_Click(object sender, EventArgs e)
        {
            FrmPrintSalesOrderPT frmPrintSalesOrderPT = new FrmPrintSalesOrderPT();
            frmPrintSalesOrderPT.form = customerOrder;
            frmPrintSalesOrderPT.initControls();
            frmPrintSalesOrderPT.initData();
            frmPrintSalesOrderPT.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrintSalesOrderIT frmPrintSalesOrderIT = new FrmPrintSalesOrderIT();
            frmPrintSalesOrderIT.form = customerOrder;
            frmPrintSalesOrderIT.initControls();
            frmPrintSalesOrderIT.initData();
            frmPrintSalesOrderIT.ShowDialog(this);
        }

        private void btnPerformaInvoiceP_Click(object sender, EventArgs e)
        {
            //customerOrder.orderListDetail = 
            List<C訂單明細> listDetail = new List<C訂單明細>();
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[4].Value.ToString() == "是")
                {
                    //var rep = new ItemController().ItemList(item.Cells[0].Value.ToString());
                    //if (!string.IsNullOrEmpty(rep.ErrorMessage))
                    //{
                    //    MessageBox.Show(rep.ErrorMessage);
                    //    return;
                    //}
                    var product = customerOrder.orderListDetail.Where(x => x.產品編號 == item.Cells[0].Value.ToString()).FirstOrDefault(); //rep.resultList.FirstOrDefault();
                    listDetail.Add(new C訂單明細()
                    {
                        產品編號 = item.Cells[0].Value.ToString(),
                        品名規格 = product?.品名規格,
                        數量1 = decimal.Parse(item?.Cells[1]?.Value?.ToString() ?? "0"),
                        單價1 = decimal.Parse(item?.Cells[2]?.Value?.ToString() ?? "0") * percent,
                        金額1 = decimal.Parse(item?.Cells[1]?.Value?.ToString() ?? "0") * decimal.Parse(item?.Cells[2]?.Value?.ToString()??"0") * percent,
                        專案序號 = item?.Cells[5]?.Value?.ToString(),
                        
                    }) ;
                }
            }
            customerOrder.orderPrintListDetail = listDetail;
            FrmPrintSalesOrderPT frmPrintSalesOrderIT = new FrmPrintSalesOrderPT();
            frmPrintSalesOrderIT.form = customerOrder;
            frmPrintSalesOrderIT.percent = this.percent;
            frmPrintSalesOrderIT.initControls();
            frmPrintSalesOrderIT.initData();
            frmPrintSalesOrderIT.ShowDialog(this);
        }

        private void btnInvoiceP_Click(object sender, EventArgs e)
        {
            //customerOrder.orderListDetail = 
            List<C訂單明細> listDetail = new List<C訂單明細>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[4].Value.ToString() == "是")
                {
                    //var rep = new ItemController().ItemList(item.Cells[0].Value.ToString());
                    //if (!string.IsNullOrEmpty(rep.ErrorMessage))
                    //{
                    //    MessageBox.Show(rep.ErrorMessage);
                    //    return;
                    //}
                    var product = customerOrder.orderListDetail.Where(x => x.產品編號 == item.Cells[0].Value.ToString()).FirstOrDefault(); //rep.resultList.FirstOrDefault();
                    listDetail.Add(new C訂單明細()
                    {
                        產品編號 = item.Cells[0].Value.ToString(),
                        品名規格 = product?.品名規格,
                        數量1 = decimal.Parse(item?.Cells[1]?.Value?.ToString() ?? "0"),
                        單價1 = decimal.Parse(item?.Cells[2]?.Value?.ToString() ?? "0") * percent,
                        金額1 = decimal.Parse(item?.Cells[1]?.Value?.ToString() ?? "0") * decimal.Parse(item?.Cells[2]?.Value?.ToString() ?? "0") * percent,
                        專案序號 = item?.Cells[5]?.Value?.ToString(),

                    });
                }
            }
            customerOrder.orderPrintListDetail = listDetail;
            FrmPrintSalesOrderIT frmPrintSalesOrderPT = new FrmPrintSalesOrderIT();
            frmPrintSalesOrderPT.form = customerOrder;
            frmPrintSalesOrderPT.percent = this.percent;
            frmPrintSalesOrderPT.initControls();
            frmPrintSalesOrderPT.initData();
            frmPrintSalesOrderPT.ShowDialog(this);
        }
    }
}
