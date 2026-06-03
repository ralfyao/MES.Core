using DigiERP.Common;
using DigiERP.Models;
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

namespace DigiERP.UserControl.Customer.ShippingOrder
{
    public partial class ShippingOrderControl : CommonUserControl
    {
        private static string id = "CF770F40-EA82-4FBF-9D2D-EAD798440F3E";
        private CustomerController _customerController;
        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }
        public ShippingOrderControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            initController();
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                initGridView();
            }
        }

        private void initGridView()
        {
            initController();
            CommonRep<C出貨單> shippingOrderList = _customerController.GetShippingOrderList();
            if (!string.IsNullOrEmpty(shippingOrderList.ErrorMessage))
            {
                MessageBox.Show(shippingOrderList.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach(var item in shippingOrderList.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別;
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.客戶簡稱;
                row.Cells[index++].Value = item.客戶名稱;
                row.Cells[index++].Value = item.總額;
                row.Cells[index++].Value = item.原定交貨日期;
                row.Cells[index++].Value = item.付款方式;
                row.Cells[index++].Value = item.交貨方式;
                row.Cells[index++].Value = item.價格條件;
                row.Cells[index++].Value = item.業務員;
                row.Cells[index++].Value = item.業務人員;
                row.Cells[index++].Value = item.核准;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }
    }
}
