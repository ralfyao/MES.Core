using DigiERP.UserControl.Customer.SalesOrder;
using MES.Core.Model;
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
        public FrmSalesOrderPrint()
        {
            InitializeComponent();
        }
        public FrmSalesOrderPrint(C訂單 customerOrder)
        {
            InitializeComponent();
            this.customerOrder = customerOrder;
        }
    }
}
