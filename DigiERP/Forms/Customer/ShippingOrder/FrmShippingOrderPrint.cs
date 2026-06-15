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
    public partial class FrmShippingOrderPrint : CommonForm
    {
        private CustomerController _customerController { get; set; }
        public string shippingOrderNo { get; set; }
        public string custId { get; set; }
        private C客戶設定 customer { get; set; }
        public C出貨單 shippingOrder { get; set; }
        public FrmShippingOrderPrint()
        {
            InitializeComponent();
        }
        public void initData()
        {
            initController();
            initCustomer();
            txtCustID.Text = custId;
            txtOrderNo.Text = shippingOrder.單號;
            txtCustName.Text = customer?.COMPANY;
        }

        private void initCustomer()
        {
            var customerRep = _customerController.QueryCustListByCondition(new MES.MiddleWare.Modules.QueryCustListByConditionReq() { custNo = custId });
            if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
            {
                MessageBox.Show(customerRep.ErrorMessage);
                return;
            }
            customer = customerRep.resultList?.FirstOrDefault() ?? new C客戶設定();
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            //throw new NotImplementedException();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FrmPrintShippingOrder frmPrintShippingOrder = new FrmPrintShippingOrder();
            frmPrintShippingOrder.ShowDialog();
        }
    }
}
