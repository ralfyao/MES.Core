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
        public C訂單 form { get; set; }
        private CustomerController _customerController;
        private ItemController _itemController;
        public OrderMaintainControl()
        {
            _isLoaded = false;
            InitializeComponent();
            initController();
            _isLoaded = true;
        }

        private bool _isLoaded = false;
        private void initController()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            if (_itemController == null)
                _itemController = new ItemController();
        }

        public OrderMaintainControl(C訂單 form)
        {
            _isLoaded = false;
            InitializeComponent();
            this.form = form;
            initForm();
            initControls(form);
            _isLoaded = true;
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
            initController();
            priceCondControl1.txType = "T";
            ETDRequest.txType = "R";
            shipMethod.txType = "D";
            payMethod.txType = "P,Y";
            if (lblMode.Text == "新增")
            {
                CommonRep<string> soRep = _customerController.GetSalesOrderNo();
                if (!string.IsNullOrEmpty(soRep.ErrorMessage))
                {
                    MessageBox.Show(soRep.ErrorMessage);
                }
                txtOrderNo.Text = soRep.result;
                dtORDERDATE.Value = DateTime.Now;
                visibleControls(false);
                disableAllControls(false);
                chkClosed.Enabled = false;
            }
            else if (lblMode.Text == "修改")
            {
                visibleControls(true);
                disableAllControls(true);
                GetFormData();
                cboCustId.Enabled = false;
                txtCompany.Enabled = false;
                txtAddress.Enabled = false;
                bankCodeSelect1.Enabled = false;
            }
        }

        private void visibleControls(bool v)
        {
            btnModify.Visible = v;
            btnQuotationDistribution.Visible = v;
            btnTransWorkOrder.Visible = v;
            btnTransShipping.Visible = v;
            btnDelete.Visible = v;
            btnActivate.Visible = v;
            btnCancelActivate.Visible = v;
            btnPrint.Visible = v;
        }

        private C客戶設定 _customer;
        private void GetCustomer()
        {
            initController();
            if (!string.IsNullOrEmpty(form.客戶全稱))
            {
                CommonRep<C客戶設定> custRep = _customerController.QueryCustListByCondition(new MES.MiddleWare.Modules.QueryCustListByConditionReq() { company = form.客戶全稱 });
                if (!string.IsNullOrEmpty(custRep.ErrorMessage))
                {
                    MessageBox.Show(custRep.ErrorMessage);
                    return;
                }
                if (custRep.resultList?.Count() > 0)
                    _customer = custRep.resultList?[0];
            }
        }
        private void GetFormData()
        {
            GetCustomer();
            // 日期
            dtORDERDATE.Value = DateTime.Parse(form.日期 ?? "1900-01-01");
            // 客戶編號
            cboCustId.Text = form.客戶編號 ?? "";
            // 單號
            txtOrderNo.Text = form.單號;
            // 客戶簡稱
            lblCustAlias.Text = _customer?.欄位2;
            // 預交日期
            dtETD.Value = DateTime.Parse(form.要望日期 ?? "1900-01-01");
            // 客戶全名
            txtCompany.Text = form.客戶全稱;
            // 結案
            chkClosed.Checked = form.結案 ?? false;
            // 業務人員
            cboSales.Text = form.業務員 ?? "";
            // 幣別
            cboCurrency.Text = form.幣別 ?? "";
            // 交貨地址
            txtAddress.Text = form.交貨地址 ?? "";
            // 稅別
            cboTaxType.Text = form.稅別 ?? "";
            // 稅率
            cboTaxRate.Text = form.稅率 ?? "";
            // 目的港
            txtDestPort.Text = form.目的港 ?? "";
            // 訂單總額
            txtOrderSum.Text = form.訂單總額加總().ToString();
            // 價格條件
            priceCondControl1.SetPriceCond(form.價格條件 ?? "");
            // 交期要求
            ETDRequest.SetPriceCond(form.交貨日期 ?? "");
            // 交貨方式
            shipMethod.SetPriceCond(form.交貨方式 ?? "");
            // 付款方式
            payMethod.SetPriceCond(form.付款方式 ?? "");
            // 銀行代碼
            bankCodeSelect1.SetBankCode(_customer?.CREDIBILITY ?? "");
            // 指配國別
            txtCountry.Text = form.指配國別 ?? "";
            // 備註說明
            txtComment.Text = form.Remark ?? "";
            // 核准
            txtApprover.Text = form.核准;
            // 核准日
            txtApproveDate.Text = form.核准日;
            // 修改
            txtModifier.Text = form.修改;
            // 修改日
            txtModifyDate.Text = form.修改日;
            // 建檔
            txtCreator.Text = form.建檔;
            // 建檔日
            txtCreateDate.Text = form.建檔日;
            // 零件供令單號

            // 收款資料Grid
            initArGrid();
            // 訂單細項Grid
            initLineGrid();
        }

        private void initLineGrid()
        {
            initController();
            List<C訂單明細> orderDetailList = form.orderListDetail;

            int index = 0;
            foreach (var item in orderDetailList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDetail);
                CommonRep<A材料> itemRep = _itemController.ItemList(item.產品編號);
                if (!string.IsNullOrEmpty(itemRep.ErrorMessage))
                {
                    MessageBox.Show(itemRep.ErrorMessage);
                    return;
                }
                A材料 aItem = new A材料();
                if (itemRep.resultList?.Count() > 0)
                {
                    aItem = itemRep.resultList?[0];
                }
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                try
                {
                    row.Cells[index++].Value = aItem.銷售單位;
                }
                catch { }
                row.Cells[index++].Value = item.數量1;
                row.Cells[index++].Value = item.單價1;
                row.Cells[index++].Value = item.數量1 * item.單價1;
                row.Cells[index++].Value = item.報價單價;
                row.Cells[index++].Value = item.折數;
                row.Cells[index++].Value = item.描述;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = item.MTYPE;
                row.Cells[index++].Value = item.佣金率;
                row.Cells[index++].Value = item.QUONO;
                dgvDetail.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void initArGrid()
        {
            //throw new NotImplementedException();
            initController();
            int index = 0;
            foreach (var item in form.arListDetail)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別;
                row.Cells[index++].Value = item.款項期別;
                row.Cells[index++].Value = item.成數;
                row.Cells[index++].Value = item.金額;
                row.Cells[index++].Value = item.請款單號;
                if (!string.IsNullOrEmpty(item.請款單號))
                {
                    // 已有立帳單號
                    row.Cells[index].Value = "";

                    ((DataGridViewButtonCell)row.Cells[index]).FlatStyle = FlatStyle.Flat;
                    row.Cells[index].Style.BackColor = dataGridView1.BackgroundColor;
                    row.Cells[index].ReadOnly = true;
                }
                else
                {
                    row.Cells["轉立帳單"].Value = "轉立帳單";
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void disableAllControls(bool disable)
        {
            bool Enabled = !disable;
            cboCustId.Enabled = Enabled;
            dtETD.Enabled = Enabled;
            txtCompany.Enabled = Enabled;
            chkClosed.Enabled = Enabled;
            cboSales.Enabled = Enabled;
            cboCurrency.Enabled = Enabled;
            txtAddress.Enabled = Enabled;
            cboTaxType.Enabled = Enabled;
            cboTaxRate.Enabled = Enabled;
            txtDestPort.Enabled = Enabled;
            //txtOrderSum.Enabled = Enabled;
            priceCondControl1.Enabled = Enabled;
            shipMethod.Enabled = Enabled;
            ETDRequest.Enabled = Enabled;
            payMethod.Enabled = Enabled;
            bankCodeSelect1.Enabled = Enabled;
            btnCheck.Enabled = Enabled;
            txtCountry.Enabled = Enabled;
            txtComment.Enabled = Enabled;
            btnAddLine.Enabled = Enabled;
            btnAddAR.Enabled = Enabled;
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
                //cboCustId.SelectedValue = popup.CustId;
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
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
            if (!_isLoaded)
            {
                return;
            }
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<C訂單> commonRep = _customerController.UpdateSalesOrderCloseFlag(!(bool)(form.結案 == null ? false : form.結案), txtOrderNo.Text);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            if (form.結案 == null)
                form.結案 = false;
            form.結案 = !form.結案;
            MessageBox.Show((!(bool)(form.結案 == null ? false : form.結案) ? "取消結案" : "結案") + "完成");
        }

        private void btnAddAR_Click(object sender, EventArgs e)
        {
            FrmAddAR frm = new FrmAddAR();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int index = 0;
                row.Cells[index++].Value = 0;
                row.Cells[index++].Value = frm.installmentPeriod;
                row.Cells[index++].Value = frm.成數;
                row.Cells[index++].Value = frm.金額;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // 避免點到 header

            if (dataGridView1.Columns[e.ColumnIndex].Name == "轉立帳單")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var value = row.Cells["識別"].Value.ToString();
                if (!string.IsNullOrEmpty(row.Cells[4].Value?.ToString()))
                {
                    return;
                }
                F收款分期 receivable = new F收款分期();
                if (form.arListDetail == null)
                    form.arListDetail = new List<F收款分期>();
                int index = 0;
                form.arListDetail.Add(new F收款分期()
                {

                    識別 = int.Parse(row.Cells[index++].Value?.ToString()),
                    款項期別 = row.Cells[index++].Value.ToString(),
                    成數 = decimal.Parse(row.Cells[index++].Value.ToString()),
                    金額 = decimal.Parse(row.Cells[index++].Value.ToString()),
                    //款項期別 = row.Cells[1].Value.ToString(),
                    //款項期別 = row.Cells[1].Value.ToString(),
                }); ; ;
                initController();
                CommonRep<string> getArNo = _customerController.TransferReceivable(form);
                if (!string.IsNullOrEmpty(getArNo.ErrorMessage))
                {
                    MessageBox.Show(getArNo.ErrorMessage);
                    return;
                }
                MessageBox.Show("轉單成功!");
                row.Cells["立帳單號"].Value = getArNo.result;

                // 已有立帳單號
                row.Cells["轉立帳單"].Value = "";

                ((DataGridViewButtonCell)row.Cells["轉立帳單"]).FlatStyle = FlatStyle.Flat;
                row.Cells["轉立帳單"].Style.BackColor = dataGridView1.BackgroundColor;
                row.Cells["轉立帳單"].ReadOnly = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bankCodeSelect1.GetBankCode()))
            {
                MessageBox.Show("請輸入收款帳號!");
                return;
            }
            FrmBankDetail frmBankDetail = new FrmBankDetail();
            frmBankDetail.bankCode = bankCodeSelect1.GetBankCode();
            frmBankDetail.initData();
            frmBankDetail.ShowDialog();
        }
    }
}
