using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.OtherIncome
{
    public partial class OtherIncomeMaintainControl : CommonUserControl
    {
        // 沿用 OtherIncomeControl (其他收入單列表) 已註冊的權限 GUID
        private static string id = "3344F4D3-18C6-49AD-BE21-6068618F4448";

        public F其他收入單 form { get; set; }
        private ARController _arController;
        private CustomerController _customerController;
        private List<H員工清冊> _salesList;
        private List<F幣別> _currencyList;
        private List<F收支項目設定> _itemList;
        private FrmCustSelect popup;

        public OtherIncomeMaintainControl()
        {
            InitializeComponent();
            initControllers();
        }

        private void initControllers()
        {
            if (_arController == null) _arController = new ARController();
            if (_customerController == null) _customerController = new CustomerController();
        }

        internal void initForm()
        {
            initControllers();
            initSalesCbo();
            initCurrencyCbo();
            initTaxTypeCbo();
            initTaxRateCbo();
            initItemCbo();

            if (lblMode.Text == "新增")
            {
                CommonRep<string> noRep = _arController.GetOtherIncomeNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                    return;
                }
                txtFormNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                btnApprove.Visible = false;
                btnCancelApprove.Visible = false;
                btnDelete.Visible = false;
                btnModify.Visible = false;
                form = form ?? new F其他收入單();
                form.detailList = new List<F其他收支明細>();
                // trigger initPriceCondList with correct txType
                priceCondControl1.SetPriceCond("");
                payMethod.SetPriceCond("");
                disableControls(true);
            }
            else if (lblMode.Text == "修改")
            {
                GetFormData();
                if (string.IsNullOrEmpty(form.核准日))
                {
                    btnApprove.Visible = true;
                    btnCancelApprove.Visible = false;
                }
                else
                {
                    btnApprove.Visible = false;
                    btnCancelApprove.Visible = true;
                }
                disableControls(false);
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
        }

        private void disableControls(bool enable)
        {
            dtDate.Enabled = enable;
            cboCustId.Enabled = enable;
            txtVoucher.Enabled = enable;
            cboSales.Enabled = enable;
            cboCurrency.Enabled = enable;
            txtExRate.Enabled = enable;
            cboTaxType.Enabled = enable;
            cboTaxRate.Enabled = enable;
            txtMachineNo.Enabled = enable;
            priceCondControl1.Enabled = enable;
            payMethod.Enabled = enable;
            txtRemark.Enabled = enable;
            dataGridView1.Enabled = enable;
            btnSubmit.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        private void initSalesCbo()
        {
            CommonRep<H員工清冊> rep = _customerController.getSalesList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _salesList = rep.resultList ?? new List<H員工清冊>();
            var source = new List<H員工清冊> { new H員工清冊 { 工號 = "" } };
            source.AddRange(_salesList);
            cboSales.DataSource = source;
            cboSales.DisplayMember = "工號";
            cboSales.ValueMember = "工號";
            cboSales.Text = form?.業務員 ?? "";
            SyncSalesName();
        }

        private void SyncSalesName()
        {
            var code = cboSales.Text;
            var person = _salesList?.FirstOrDefault(p => p.工號 == code);
            txtSalesName.Text = person?.姓名 ?? "";
        }

        private void cboSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncSalesName();
        }

        private void initCurrencyCbo()
        {
            CommonRep<F幣別> rep = _customerController.GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _currencyList = rep.resultList ?? new List<F幣別>();
            var source = new List<F幣別> { new F幣別 { CURRENCY = "" } };
            source.AddRange(_currencyList);
            cboCurrency.DataSource = source;
            cboCurrency.DisplayMember = "CURRENCY";
            cboCurrency.ValueMember = "CURRENCY";
            cboCurrency.Text = form?.幣別 ?? "";
            SyncExRate();
        }

        private void SyncExRate()
        {
            string currency = cboCurrency.Text?.Trim() ?? "";
            if (string.IsNullOrEmpty(currency)) { txtExRate.Text = ""; return; }
            CommonRep<F匯率> rep = _customerController.GetExRateList(currency);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            var rate = rep.resultList?.FirstOrDefault();
            txtExRate.Text = rate?.匯率?.ToString() ?? (form?.匯率?.ToString() ?? "");
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncExRate();
        }

        private void initTaxTypeCbo()
        {
            cboTaxType.Items.Clear();
            cboTaxType.Items.Add("");
            cboTaxType.Items.Add("應稅");
            cboTaxType.Items.Add("免稅");
            cboTaxType.Items.Add("零稅率");
            cboTaxType.Text = form?.稅別 ?? "";
        }

        private void initTaxRateCbo()
        {
            CommonRep<string> rep = _customerController.GetTaxRateList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            cboTaxRate.Items.Clear();
            cboTaxRate.Items.Add("");
            foreach (var r in rep.resultList ?? new List<string>())
                cboTaxRate.Items.Add(r);
            cboTaxRate.Text = form?.稅率?.ToString() ?? "";
        }

        private void initItemCbo()
        {
            CommonRep<F收支項目設定> rep = _arController.GetItemNumberList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            _itemList = rep.resultList ?? new List<F收支項目設定>();

            colItemNo.Items.Clear();
            colItemNo.Items.Add("");
            foreach (var item in _itemList)
                colItemNo.Items.Add(item.項目編號 ?? "");
        }

        private static void SetPriceCondByNameOrCode(Common.PriceCondControl ctrl, string value)
        {
            if (string.IsNullOrEmpty(value)) { ctrl.SetPriceCond(""); return; }
            // try match by 條文編號 first, then by 條文名稱
            ctrl.SetPriceCond(value.Trim());
            if (string.IsNullOrEmpty(ctrl.GetPriceCondTxt()))
            {
                // fallback: match by 條文名稱
                var matched = ctrl.selectionItems?.FirstOrDefault(x =>
                    x.條文名稱?.Trim() == value.Trim());
                if (matched != null)
                    ctrl.SetPriceCond(matched.條文編號?.Trim() ?? "");
            }
        }

        private static string FmtDate(string s)
        {
            if (DateTime.TryParse(s, out DateTime d)) return d.ToString("yyyy/MM/dd");
            return s ?? "";
        }

        private void GetFormData()
        {
            if (form == null) return;
            try { dtDate.Value = DateTime.Parse(form.日期 ?? DateTime.Now.ToString("yyyy/MM/dd")); }
            catch { dtDate.Value = DateTime.Now; }
            txtFormNo.Text = form.單號 ?? "";
            cboCustId.Items.Clear();
            if (!string.IsNullOrEmpty(form.客戶編號))
            {
                cboCustId.Items.Add(form.客戶編號);
                cboCustId.Text = form.客戶編號;
                SyncCustFields(form.客戶編號);
            }
            txtVoucher.Text = form.傳票 ?? "";
            cboSales.Text = form.業務員 ?? "";
            SyncSalesName();
            cboCurrency.Text = form.幣別 ?? "";
            txtExRate.Text = form.匯率?.ToString() ?? "";
            cboTaxType.Text = form.稅別 ?? "";
            cboTaxRate.Text = form.稅率?.ToString() ?? "";
            txtMachineNo.Text = form.MACHINENO ?? "";
            txtRemark.Text = form.Remark ?? "";
            SetPriceCondByNameOrCode(priceCondControl1, form.價格條件);
            SetPriceCondByNameOrCode(payMethod, form.付款方式);
            // footer
            txtApprover.Text = form.核准 ?? "";
            txtApprove.Text = form.核准 ?? "";
            txtApproveDate.Text = FmtDate(form.核准日);
            txtModifier.Text = form.修改 ?? "";
            txtModify.Text = form.修改 ?? "";
            txtModifyDate.Text = FmtDate(form.修改日);
            txtCreator.Text = form.建檔 ?? "";
            txtCreate.Text = form.建檔 ?? "";
            txtCreateDate.Text = FmtDate(form.建檔日);
            // detail grid
            initDetailGrid();
        }

        private void SyncCustFields(string custId)
        {
            if (string.IsNullOrEmpty(custId)) return;
            CommonRep<C客戶設定> rep = _customerController.getCustomerList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            var cust = rep.resultList?.FirstOrDefault(x => x.正航編號 == custId);
            if (cust == null) return;
            txtCompany.Text = cust.COMPANY ?? "";
            txtCredibility.Text = cust.CREDIBILITY ?? "";
            txtCustAlias.Text = cust.欄位2 ?? "";
        }

        private void cboCustId_MouseClick(object sender, MouseEventArgs e)
        {
            popup = new FrmCustSelect();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
                SyncCustFields(popup.CustId);
            }
        }

        private void initDetailGrid()
        {
            dataGridView1.Rows.Clear();
            var details = form?.detailList ?? new List<F其他收支明細>();
            foreach (var item in details)
            {
                // ensure the item number exists in combo items to avoid DataError
                string itemNo = item.項目編號 ?? "";
                if (!string.IsNullOrEmpty(itemNo) && !colItemNo.Items.Contains(itemNo))
                    colItemNo.Items.Add(itemNo);

                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colItemNo.Index].Value = itemNo;
                row.Cells[colItemName.Index].Value = GetItemName(itemNo);
                row.Cells[colOrigAmount.Index].Value = item.原幣未稅?.ToString() ?? "";
                row.Cells[colTaxFree.Index].Value = item.未稅?.ToString() ?? "";
                row.Cells[colTax.Index].Value = item.稅?.ToString() ?? "";
                decimal total = (item.未稅 ?? 0m) + (item.稅 ?? 0m);
                row.Cells[colTotal.Index].Value = total.ToString();
                row.Cells[colRemark.Index].Value = item.備註 ?? "";
            }
        }

        private string GetItemName(string itemNo)
        {
            if (string.IsNullOrEmpty(itemNo)) return "";
            return _itemList?.FirstOrDefault(x => x.項目編號 == itemNo)?.項目名稱 ?? "";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == colItemNo.Index)
            {
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString() ?? "";
                row.Cells[colItemName.Index].Value = GetItemName(itemNo);
            }
            if (e.ColumnIndex == colTaxFree.Index || e.ColumnIndex == colTax.Index)
            {
                decimal taxFree = decimal.TryParse(row.Cells[colTaxFree.Index].Value?.ToString(), out decimal tf) ? tf : 0m;
                decimal tax = decimal.TryParse(row.Cells[colTax.Index].Value?.ToString(), out decimal tx) ? tx : 0m;
                row.Cells[colTotal.Index].Value = (taxFree + tax).ToString();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // suppress combo value validation error when loading existing data
            e.ThrowException = false;
        }

        private void CollectUserInput()
        {
            form.日期 = dtDate.Value.ToString("yyyy/MM/dd");
            form.單號 = txtFormNo.Text;
            form.客戶編號 = cboCustId.Text;
            form.業務員 = cboSales.Text;
            form.幣別 = cboCurrency.Text;
            form.匯率 = (decimal.TryParse(txtExRate.Text, out decimal r) ? r : (decimal?)0).ToString();
            form.稅別 = cboTaxType.Text;
            form.稅率 = decimal.TryParse(cboTaxRate.Text, out decimal tr) ? tr : (decimal?)null;
            form.MACHINENO = txtMachineNo.Text;
            form.Remark = txtRemark.Text;
            form.價格條件 = priceCondControl1.InnerComboBox.Text;
            form.付款方式 = payMethod.InnerComboBox.Text;
            form.傳票 = txtVoucher.Text;
            // collect detail
            form.detailList = new List<F其他收支明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(itemNo)) continue;
                form.detailList.Add(new F其他收支明細
                {
                    單號 = form.單號,
                    項目編號 = itemNo,
                    原幣未稅 = decimal.TryParse(row.Cells[colOrigAmount.Index].Value?.ToString(), out decimal oa) ? oa : (decimal?)null,
                    未稅 = decimal.TryParse(row.Cells[colTaxFree.Index].Value?.ToString(), out decimal tf) ? tf : (decimal?)null,
                    稅 = decimal.TryParse(row.Cells[colTax.Index].Value?.ToString(), out decimal tax) ? tax : (decimal?)null,
                    金額 = decimal.TryParse(row.Cells[colTotal.Index].Value?.ToString(), out decimal tot) ? tot : (decimal?)null,
                    備註 = row.Cells[colRemark.Index].Value?.ToString() ?? "",
                });
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<F其他收入單> rep = _arController.SaveOtherIncome(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<F其他收入單> rep = _arController.UpdateOtherIncome(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnBack_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要刪除其他收入單 {form.單號} 嗎?", "確認刪除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            CommonRep<F其他收入單> rep = _arController.DeleteOtherIncome(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnBack_Click(null, null);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(form.單號)) { MessageBox.Show("請先儲存!"); return; }
            CommonRep<F其他收入單> rep = _arController.ValidateOtherIncome(form.單號, true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("核准成功!");
            form.核准 = AppSession.User.username;
            form.核准日 = DateTime.Now.ToString("yyyy/MM/dd");
            txtApprover.Text = form.核准;
            txtApprove.Text = form.核准;
            txtApproveDate.Text = form.核准日;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = true;
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消核准嗎?", "確認取消核准",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            CommonRep<F其他收入單> rep = _arController.ValidateOtherIncome(form.單號, false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("取消核准成功!");
            form.核准 = null;
            form.核准日 = null;
            txtApprover.Text = "";
            txtApprove.Text = "";
            txtApproveDate.Text = "";
            btnApprove.Visible = true;
            btnCancelApprove.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                var grid = parentPanel.Controls.OfType<DataGridView>().FirstOrDefault();
                if (grid != null) grid.Visible = true;
                parentPanel.Controls.Remove(this);
            }
        }
    }
}
