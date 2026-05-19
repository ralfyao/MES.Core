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

namespace DigiERP.Forms.Customer.Quotation
{
    public partial class FrmDialog : CommonForm
    {
        public string IDNO { get; set; }
        public string QUONO { get; set; }
        public string CustNo { get; set; }
        public string COMPANY { get; set; }
        private CustomerController _customerController;
        public FrmDialog()
        {
            InitializeComponent();
        }
        public void initData()
        {
            txtQUONO.Text = QUONO;
            txtCustNo.Text = CustNo;
            txtCustName.Text = COMPANY;
            txtQUONO.Enabled = false;
            txtCustName.Enabled = false;
            txtCustNo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            C報價單 quotation = new C報價單();
            quotation.IDNO = IDNO;
            quotation.QUONO = QUONO;
            quotation.Remark = txtComment.Text;
            quotation.修改 = AppSession.User.username;
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<C報價單> commonRep = _customerController.UpdateQuotationRemark(quotation);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
            }
            else
            {
                MessageBox.Show("儲存成功");
            }
        }
    }
}
