using DigiERP.Common;
using DigiERP.Forms.Customer;
using DigiERP.Forms.Customer.SalesOrder;
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

namespace DigiERP.UserControl.Customer.SalesOrder
{
    public partial class OrderMaintainControl : CommonUserControl
    {
        public C訂單 form;
        public CustomerController _customerController;
        public OrderMaintainControl()
        {
            InitializeComponent();
        }
        public OrderMaintainControl(C訂單 form)
        {
            InitializeComponent();
            this.form = form;
            initForm();
            initControls(form);
        }

        private void initControls(C訂單 form)
        {
            initSalesCbo(form);
            initCurrency(form);
        }

        private void initCurrency(C訂單 form)
        {
            //throw new NotImplementedException();
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<F幣別> currencyRep = _customerController.GetCurrencyList();
            if (!string.IsNullOrEmpty(currencyRep.ErrorMessage))
            {
                MessageBox.Show(currencyRep.ErrorMessage);
                return;
            }
            currencyRep.resultList.Insert(0, new F幣別() { CURRENCY = "" });
            cboCurrency.DataSource = currencyRep.resultList;
            cboCurrency.DisplayMember = "CURRENCY";
            cboCurrency.ValueMember = "CURRENCY";
            if (!string.IsNullOrEmpty(form.幣別))
            {
                cboCurrency.Text = form.幣別;
            }
        }

        private void initSalesCbo(C訂單 form)
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<H員工清冊> salesRep = _customerController.getSalesList();
            if (!string.IsNullOrEmpty(salesRep.ErrorMessage))
            {
                MessageBox.Show(salesRep.ErrorMessage);
                return;
            }
            salesRep.resultList.Insert(0, new H員工清冊() { 工號 = "" });
            cboSales.DataSource = salesRep.resultList;
            cboSales.DisplayMember = "工號";
            cboSales.ValueMember = "工號";
            if (!string.IsNullOrEmpty(form.業務人員))
            {
                cboSales.Text = form.業務人員;
            }
        }

        internal void initForm()
        {
            //throw new NotImplementedException();
            if (lblMode.Text == "新增")
            {

            }
            else if (lblMode.Text == "修改")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }
        FrmCustSelect popup;
        private void cboCustId_Enter(object sender, EventArgs e)
        {
            popup = new FrmCustSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.SelectedValue = popup.CustId;
                cboCustId.SelectedText = popup.CustId;
                lblCustAlias.Text = popup.CustAlias;
                txtCompany.Text = popup.CustName;
                //lblIndustryCodeDesc.Text = popup.SelectedName; // 存值（推薦）
            }
        }

        private void cboCustId_Leave(object sender, EventArgs e)
        {
            if (popup != null)
            {
                popup.Dispose();
                popup.Close();
            }
        }

        private void cboCustId_MouseClick(object sender, MouseEventArgs e)
        {
            cboCustId_Enter(null, null);
        }

        private void cboCustId_MouseLeave(object sender, EventArgs e)
        {
            cboCustId_Leave(null, null);
        }

        private void commonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<C訂單> commonRep = _customerController.UpdateSalesOrderCloseFlag(!(bool)(form.結案 == null ? false : form.結案), txtOrderNo.Text);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            MessageBox.Show((!(bool)(form.結案 == null ? false : form.結案) ? "結案" : "取消結案") + "完成");
        }

        private void btnAddAR_Click(object sender, EventArgs e)
        {
            FrmAddAR frm = new FrmAddAR();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
