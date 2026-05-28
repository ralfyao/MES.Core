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
    public partial class FrmAddSalesLine : Form
    {
        private CustomerController _customerController;
        private ItemController _itemController;
        public FrmAddSalesLine()
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
        FrmEqpType popup;
        private void cboEqpType_Enter(object sender, EventArgs e)
        {
            popup = new FrmEqpType();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboEqpType.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboEqpType.Items.Clear();
                cboEqpType.Items.Add(popup._TYPEID);
                cboEqpType.Text = popup._TYPEID;
                //lblIndustryCodeDesc.Text = popup.SelectedName; // 存值（推薦）
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
