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
    public partial class FrmAddQuotation : CommonForm
    {
        public FrmAddQuotation()
        {
            InitializeComponent();
            txtProductId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductId.AutoCompleteCustomSource = GetProductIdList();
            if (_customerController == null)
                _customerController = new CustomerController();
            if (_itemController == null)
                _itemController = new ItemController();
        }
        private CustomerController _customerController;
        private ItemController _itemController;
        private AutoCompleteStringCollection GetProductIdList()
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            if (_itemController == null)
                _itemController = new ItemController();
            CommonRep<A材料> commonRep = _itemController.ItemList();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return autoCompleteStringCollection;
            }
            foreach (var item in commonRep.resultList)
            {
                autoCompleteStringCollection.Add(item.產品編號);
            }
            return autoCompleteStringCollection;
        }

        public string QUONO { get; set; }
        C報價明細 data = new C報價明細();
        public C報價明細 GetData()
        {
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text.Trim()))
            {
                MessageBox.Show("請輸入產品編號");
                return;
            }
            data.QUONO = QUONO;
            data.產品編號 = txtProductId.Text;
            data.品名規格 = txtProductName.Text;
            data.單位 = txtUnit.Text;
            data.單價 = numUnitPrice.Value;
            data.數量 = numQuantity.Value;
            data.金額 = numAmount.Value;
            data.描述 = txtDescription.Text;
            DialogResult = DialogResult.OK;
            Dispose();
            Close();
        }

        private void numQuantity_Leave(object sender, EventArgs e)
        {
            numAmount.Value = numQuantity.Value * numUnitPrice.Value;
        }

        private void txtProductId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text))
                return;
            if (string.IsNullOrEmpty(txtProductId.Text.Trim()))
            {
                txtProductName.Text = string.Empty;
                return;
            }
            CommonRep<A材料> commonRep = _itemController.ItemList(txtProductId.Text.Trim());

            if (string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                if (commonRep.resultList.Count() > 0)
                {
                    A材料 item = commonRep.resultList[0];
                    txtProductName.Text = item.品名規格;
                }
            }
            else
            {
                MessageBox.Show(commonRep.ErrorMessage);
            }
        }

        private void numUnitPrice_Leave(object sender, EventArgs e)
        {
            numQuantity_Leave(sender, e);
        }
    }
}
