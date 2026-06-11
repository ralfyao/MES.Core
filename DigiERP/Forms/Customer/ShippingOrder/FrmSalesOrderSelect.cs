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
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }
    }
}
