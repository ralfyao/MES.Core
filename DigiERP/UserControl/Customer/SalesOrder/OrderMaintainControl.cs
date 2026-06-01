using DigiERP.Common;
using DigiERP.Forms.Customer;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
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
            initForm();
            initControls(form);
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
            if (!string.IsNullOrEmpty(form?.幣別 ?? ""))
            {
                cboCurrency.Text = form?.幣別 ?? "";
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
            if (!string.IsNullOrEmpty(form?.業務人員 ?? ""))
            {
                cboSales.Text = form?.業務人員 ?? "";
            }
        }

        internal void initForm()
        {

            _isLoaded = false;
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
                // 價格條件
                priceCondControl1.SetPriceCond(form?.價格條件?.Trim() ?? "");
                // 交期要求
                ETDRequest.SetPriceCond(form?.交貨日期?.Trim() ?? "");
                // 交貨方式
                shipMethod.SetPriceCond(form?.交貨方式?.Trim() ?? "");
                // 付款方式
                payMethod.SetPriceCond(form?.付款方式?.Trim() ?? "");
                txtOrderNo.Text = soRep.result;
                dtORDERDATE.Value = DateTime.Now;
                visibleControls(false);
                disableAllControls(false);
                chkClosed.Enabled = false;
                // 沒有核准不能列印
                if (!string.IsNullOrEmpty(form?.核准))
                {
                    btnPrint.Visible = true;
                }
                else
                {
                    btnPrint.Visible = false;
                }
            }
            else if (lblMode.Text == "修改")
            {
                CommonRep<C訂單> soRep = _customerController.GetSalesOrderListByNo(form.單號);
                if (!string.IsNullOrEmpty(soRep.ErrorMessage))
                {
                    MessageBox.Show(soRep.ErrorMessage);
                    return;
                }
                if (soRep.resultList.Count > 0)
                {
                    form = soRep.resultList[0];
                }
                visibleControls(true);
                disableAllControls(true);
                initControls(form);
                GetFormData();
                cboCustId.Enabled = false;
                txtCompany.Enabled = false;
                txtAddress.Enabled = false;
                bankCodeSelect1.Enabled = false;
                txtAmount.Text = txtOrderSum.Text;
                if (string.IsNullOrEmpty(form.核准日))
                {
                    btnActivate.Visible = true;
                    btnCancelActivate.Visible = false;
                }
                else
                {
                    btnActivate.Visible = false;
                    btnCancelActivate.Visible = true;
                }
            }

            _isLoaded = true;
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
            cboCustId.Items.Add(form.客戶編號);
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
            priceCondControl1.SetPriceCond(form.價格條件?.Trim() ?? "");
            // 交期要求
            ETDRequest.SetPriceCond(form.交貨日期?.Trim() ?? "");
            // 交貨方式
            shipMethod.SetPriceCond(form.交貨方式?.Trim() ?? "");
            // 付款方式
            payMethod.SetPriceCond(form.付款方式?.Trim() ?? "");
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
            decimal sum = 0;
            dgvDetail.Rows.Clear();
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
                row.Cells[index++].Value = item.識別碼;
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
                sum += decimal.Parse(((item.數量1 ?? 0) * (item.單價1 ?? 0)).ToString());
                row.Cells[index++].Value = item.報價單價;
                row.Cells[index++].Value = item.折數;
                row.Cells[index++].Value = item.描述;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = item.MTYPE;
                row.Cells[index++].Value = item.佣金率;
                row.Cells[index++].Value = item.QUONO;
                dgvDetail.Rows.Add(row);
            }
            txtOrderSum.Text = sum.ToString();
            txtAmount.Text = sum.ToString();
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
                    row.Cells[index].Value = "轉立帳單";
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
            btnQuotationDistribution.Enabled = Enabled;
            btnTransWorkOrder.Enabled = Enabled;
            btnTransShipping.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            btnActivate.Enabled = Enabled;
            btnCancelActivate.Enabled = Enabled;
            btnPrint.Enabled = Enabled;
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
            cboCustId.Enabled = false;
            txtCompany.Enabled = false;
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
                //F收款分期 receivable = new F收款分期();
                //if (form.arListDetail == null)
                //    form.arListDetail = new List<F收款分期>();
                int index = 0;
                form.AR識別 = int.Parse(row.Cells[index++].Value?.ToString());
                if (form.AR識別 == 0 || form.AR識別 == null)
                {
                    MessageBox.Show("尚未將此筆資料寫入資料庫! 請先按送出後再重新查詢、編輯");
                    return;
                }
                //form.arListDetail.Add(new F收款分期()
                //{

                //    識別 = int.Parse(row.Cells[index++].Value?.ToString()),
                //    款項期別 = row.Cells[index++].Value?.ToString(),
                //    成數 = decimal.Parse(row.Cells[index++].Value.ToString()),
                //    金額 = decimal.Parse(row.Cells[index++].Value.ToString()),
                //}); ; ;
                initController();
                CommonRep<string> getArNo = _customerController.TransferReceivable(form);
                if (!string.IsNullOrEmpty(getArNo.ErrorMessage))
                {
                    MessageBox.Show(getArNo.ErrorMessage);
                    return;
                }
                MessageBox.Show("轉單成功!");
                row.Cells["立帳單號"].Value = getArNo.result;
                form.AR識別 = -1;
                form.AR單號 = string.Empty;
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

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            FrmAddSalesLine frmAddSalesLine = new FrmAddSalesLine();
            if (frmAddSalesLine.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDetail);
                int index = 0;
                row.Cells[index++].Value = 0;
                row.Cells[index++].Value = frmAddSalesLine.txtProductId.Text;
                row.Cells[index++].Value = frmAddSalesLine.txtProductName.Text;
                row.Cells[index++].Value = frmAddSalesLine.txtSalesUnit.Text;
                row.Cells[index++].Value = frmAddSalesLine.numQuantity.Value;
                row.Cells[index++].Value = frmAddSalesLine.numOrderUnitPrice.Value;
                row.Cells[index++].Value = frmAddSalesLine.numQuantity.Value * frmAddSalesLine.numOrderUnitPrice.Value;
                index++;//報價單價
                index++;//折數
                row.Cells[index++].Value = frmAddSalesLine.txtComment.Text;
                row.Cells[index++].Value = frmAddSalesLine.txtProjSerial.Text;
                row.Cells[index++].Value = frmAddSalesLine.cboEqpType.Text;
                row.Cells[index++].Value = frmAddSalesLine.numCommissionRate.Value;
                index++;
                index++;
                txtOrderSum.Text = (decimal.Parse(string.IsNullOrEmpty(txtOrderSum.Text) ? "0" : txtOrderSum.Text) + (frmAddSalesLine.numQuantity.Value * frmAddSalesLine.numOrderUnitPrice.Value)).ToString();
                txtAmount.Text = txtOrderSum.Text;
                dgvDetail.Rows.Add(row);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                CommonRep<C訂單> rep = _customerController.SaveSalesOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
                CommonRep<C訂單> rep = _customerController.UpdateSalesOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            button1_Click(null, null);
        }

        private void CollectUserInput()
        {
            //throw new NotImplementedException();
            // 日期
            //dtORDERDATE.Value = DateTime.Parse(form.日期 ?? "1900-01-01");
            form.日期 = dtORDERDATE.Value.ToString("yyyy-MM-dd");
            // 客戶編號
            //cboCustId.Text = form.客戶編號 ?? "";
            form.客戶編號 = cboCustId.Text;
            // 單號
            //txtOrderNo.Text = form.單號;
            form.單號 = txtOrderNo.Text;
            // 客戶簡稱
            //lblCustAlias.Text = _customer?.欄位2;
            // 預交日期
            //dtETD.Value = DateTime.Parse( ?? "1900-01-01");
            form.要望日期 = dtETD.Value.ToString("yyyy-MM-dd");
            // 客戶全名
            form.客戶全稱 = txtCompany.Text;
            // 結案
            form.結案 = chkClosed.Checked;
            // 業務人員
            form.業務員 = cboSales.Text;
            // 幣別
            form.幣別 = cboCurrency.Text;
            // 交貨地址
            form.交貨地址 = txtAddress.Text;
            // 稅別
            form.稅別 = cboTaxType.Text;
            // 稅率
            form.稅率 = cboTaxRate.Text;
            // 目的港
            form.目的港 = txtDestPort.Text;
            // 訂單總額
            //txtOrderSum.Text = form.訂單總額加總().ToString();
            // 價格條件
            form.價格條件 = priceCondControl1.GetPriceCond();
            // 交期要求
            form.交貨日期 = ETDRequest.GetPriceCond();
            // 交貨方式
            form.交貨方式 = shipMethod.GetPriceCond();
            // 付款方式
            form.付款方式 = payMethod.GetPriceCond();
            // 銀行代碼
            //bankCodeSelect1.SetBankCode(_customer?.CREDIBILITY ?? "");
            // 指配國別
            form.指配國別 = txtCountry.Text;
            // 備註說明
            form.Remark = txtComment.Text;
            // 核准
            form.核准 = txtApprover.Text;
            // 核准日
            form.核准日 = txtApproveDate.Text;
            // 修改
            form.修改 = txtModifier.Text;
            // 修改日
            form.修改日 = txtModifyDate.Text;
            // 建檔
            form.建檔 = txtCreator.Text;
            // 建檔日
            form.建檔日 = txtCreateDate.Text;
            // 核准
            form.核准 = txtCreator.Text;
            // 核准日
            form.核准日 = txtCreateDate.Text;
            if (string.IsNullOrEmpty(form.核准))
            {
                btnActivate.Visible = true;
                btnCancelActivate.Visible = false;
            }
            else
            {
                btnCancelActivate.Visible = true;
                btnActivate.Visible = false;
            }
            // 零件供令單號

            // 收款資料Grid
            collectArGrid();
            // 訂單細項Grid
            collectLineGrid();
            form.AR單號 = string.Empty;
            form.account = string.Empty;
            form.佣金 = 0;
            form.匯率 = 0;
            if (string.IsNullOrEmpty(form.稅率))
            {
                form.稅率 = "0";
            }
            else
            {
                if (form.稅率 == "0%")
                {
                    form.稅率 = "0";
                }
                if (form.稅率 == "5%")
                {
                    form.稅率 = "0.05";
                }
            }
            form.MACHINENO = string.Empty;
        }

        private void collectLineGrid()
        {
            form.orderListDetail?.Clear();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                int index = 0;
                C訂單明細 orderDetail = new C訂單明細();
                orderDetail.識別碼 = row.Cells[index++].Value?.ToString();
                orderDetail.產品編號 = row.Cells[index++].Value?.ToString();
                orderDetail.品名規格 = row.Cells[index++].Value?.ToString();
                orderDetail.單位 = row.Cells[index++].Value?.ToString();
                orderDetail.數量1 = decimal.Parse(row.Cells[index++].Value?.ToString());
                orderDetail.單價1 = decimal.Parse(row.Cells[index++].Value?.ToString());
                //orderDetail.產品編號 = row.Cells[index++].Value.ToString();
                index++;//總金額
                index++;//報價單價
                index++;//折數
                orderDetail.描述 = row.Cells[index++].Value?.ToString();
                orderDetail.專案序號 = row.Cells[index++].Value?.ToString();
                orderDetail.MTYPE = row.Cells[index++].Value?.ToString();
                orderDetail.佣金率 = row.Cells[index++].Value?.ToString();
                orderDetail.QUONO = row.Cells[index++].Value?.ToString();
                if (form.orderListDetail == null)
                    form.orderListDetail = new List<C訂單明細>();
                form.orderListDetail.Add(orderDetail);
            }
        }

        private void collectArGrid()
        {
            form.arListDetail?.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                F收款分期 f = new F收款分期();
                int index = 0;
                f.識別 = int.Parse(item.Cells[index++].Value.ToString());
                f.款項期別 = item.Cells[index++].Value.ToString();
                f.金額 = item.Cells[index++].Value == null ? 0m : decimal.Parse(item.Cells[index++].Value.ToString());//decimal.Parse((string)item.Cells[index++].Value ??"0");
                f.請款單號 = item.Cells[index++].Value?.ToString();
                f.單號 = txtOrderNo.Text;
                if (form.arListDetail == null)
                    form.arListDetail = new List<F收款分期>();
                form.arListDetail.Add(f);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認刪除?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                initController();
                CommonRep<C訂單> delRep = _customerController.DeleteSalesOrderNo(form.單號);
                if (!string.IsNullOrEmpty(delRep.ErrorMessage))
                {
                    MessageBox.Show(delRep.ErrorMessage);
                    return;
                }
                MessageBox.Show("刪除成功!");
                button1_Click(null, null);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            form.核准 = AppSession.User.username;
            form.核准日 = DateTime.Now.ToString("yyyy-MM-dd");
            CommonRep<C訂單> activateRep = _customerController.UpdateSalesOrder(form);
            if (!string.IsNullOrEmpty(activateRep.ErrorMessage))
            {
                MessageBox.Show(activateRep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            btnActivate.Visible = false;
            btnCancelActivate.Visible = true;
        }

        private void btnCancelActivate_Click(object sender, EventArgs e)
        {
            form.核准 = null;
            form.核准日 = null;
            CommonRep<C訂單> activateRep = _customerController.UpdateSalesOrder(form);
            if (!string.IsNullOrEmpty(activateRep.ErrorMessage))
            {
                MessageBox.Show(activateRep.ErrorMessage);
                return;
            }
            MessageBox.Show("取消生效成功!");
            btnActivate.Visible = true;
            btnCancelActivate.Visible = false;
        }
        List<int> quotationDistRemoveIndexLst = new List<int>();
        private void btnQuotationDistribution_Click(object sender, EventArgs e)
        {
            FrmQuotationDistribution frmQuotationDistribution = new FrmQuotationDistribution();
            frmQuotationDistribution.removedIndex = quotationDistRemoveIndexLst;
            frmQuotationDistribution.customerId = cboCustId.Text;
            frmQuotationDistribution.orderDate = dtORDERDATE.Value.ToString("yyyy-MM-dd");
            frmQuotationDistribution.initGrid();
            if (frmQuotationDistribution.ShowDialog() == DialogResult.OK)
            {
                quotationDistRemoveIndexLst = frmQuotationDistribution.removedIndex;
                foreach (C報價明細 c in frmQuotationDistribution.checkedList)
                {
                    bool isContinue = false;
                    foreach (var item in dgvDetail.Rows.Cast<DataGridViewRow>())
                    {
                        if ((item.Cells[13].Value ?? "").ToString() == c.QUONO && (item.Cells[1].Value ?? "").ToString() == c.產品編號)
                        {
                            isContinue = true;
                        }
                    }
                    if (isContinue)
                        continue;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDetail);
                    row.Cells[0].Value = 0;
                    row.Cells[1].Value = c.產品編號;
                    row.Cells[2].Value = c.品名規格;
                    row.Cells[3].Value = c.單位;
                    row.Cells[4].Value = c.數量;
                    row.Cells[7].Value = c.單價;
                    row.Cells[13].Value = c.QUONO;
                    dgvDetail.Rows.Add(row);
                }
            }
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 取得目前編輯的 row / column
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (colIndex == 4)
            {
                var quantity = dgvDetail.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                int numQuantity = -1;
                int.TryParse(quantity, out numQuantity);
                if (numQuantity > 0)
                {
                    var unitPrice = dgvDetail.Rows[rowIndex].Cells[colIndex + 1].Value?.ToString();
                    int numUnitPrice = -1;
                    int.TryParse(unitPrice, out numUnitPrice);
                    if (numUnitPrice > 0)
                    {
                        dgvDetail.Rows[rowIndex].Cells[colIndex + 2].Value = numQuantity * numUnitPrice;
                        if (!string.IsNullOrEmpty(dgvDetail.Rows[rowIndex].Cells[colIndex + 3].Value?.ToString()))
                        {
                            dgvDetail.Rows[rowIndex].Cells[colIndex + 4].Value = ((decimal)numUnitPrice / decimal.Parse(dgvDetail.Rows[rowIndex].Cells[colIndex + 3].Value != null ? dgvDetail.Rows[rowIndex].Cells[colIndex + 3].Value?.ToString() : "0") * 100).ToString() + "%";
                        }
                    }
                }

            }
            if (colIndex == 5)
            {
                var unitPrice = dgvDetail.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                int numUnitPrice = -1;
                int.TryParse(unitPrice, out numUnitPrice);
                if (numUnitPrice > 0)
                {
                    var quantity = dgvDetail.Rows[rowIndex].Cells[colIndex - 1].Value?.ToString();
                    int numQuantity = -1;
                    int.TryParse(quantity, out numQuantity);
                    if (numQuantity > 0)
                    {
                        dgvDetail.Rows[rowIndex].Cells[colIndex + 1].Value = numQuantity * numUnitPrice;
                        if (!string.IsNullOrEmpty(dgvDetail.Rows[rowIndex].Cells[colIndex + 2].Value?.ToString()))
                        {
                            dgvDetail.Rows[rowIndex].Cells[colIndex + 3].Value = Math.Round(((decimal)numUnitPrice / decimal.Parse(dgvDetail.Rows[rowIndex].Cells[colIndex + 2].Value != null ? dgvDetail.Rows[rowIndex].Cells[colIndex + 2].Value?.ToString() : "0") * 100), 2).ToString() + "%";
                        }
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnTransShipping_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCustId.Text))
            {
                MessageBox.Show("無客戶編號!");
                return;
            }
            FrmTransToShippingOrder frmTransToShippingOrder = new FrmTransToShippingOrder();
            frmTransToShippingOrder.custId = cboCustId.Text;
            frmTransToShippingOrder.loadData();
            frmTransToShippingOrder.ShowDialog();
        }
    }
}
