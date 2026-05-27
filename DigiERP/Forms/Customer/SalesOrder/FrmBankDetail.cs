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
    public partial class FrmBankDetail : Form
    {
        public string bankCode { get; set; }
        private CustomerController _customerController;
        public FrmBankDetail()
        {
            InitializeComponent();
            initController();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }

        public void initData()
        {
            CommonRep <F銀行設定> rep = _customerController.GetBankInfo(bankCode);
            if(!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtBankCode.Text = bankCode;
            txtBankName.Text = rep.result?.銀行名稱;
            txtBankNameE.Text = rep.result?.Bankname;
            txtBankAddress.Text = rep.result?.銀行地址;
            txtAccount.Text = rep.result?.帳號;
            txtSwiftCode.Text = rep.result?.SwiftCode;
            txtTel.Text = rep.result?.電話;
        }
    }
}
