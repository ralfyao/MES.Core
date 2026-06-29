using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.EQPShipping
{
    public partial class EQPShippingMaintainControl : CommonUserControl
    {
        public 專案機台交貨單 form { get; set; }

        private ProductionController _productionController;
        private CustomerController _customerController;
        private List<工令單> _workOrderList;
        private List<C客戶連絡人清單> _contactList;
        private List<F幣別> _currencyList;

        public EQPShippingMaintainControl()
        {
            InitializeComponent();
            initControllers();
        }

        private void initControllers()
        {
            if (_productionController == null) _productionController = new ProductionController();
            if (_customerController == null) _customerController = new CustomerController();
        }

        internal void initForm()
        {
            initControllers();
            initSerialNoCbo();
            initCurrencyCbo();
            initDropdownLists();

            if (lblMode.Text == "新增")
            {
                CommonRep<string> noRep = _productionController.GetNewEQPShippingNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                    return;
                }
                txtFormNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                form = form ?? new 專案機台交貨單();
                form.專案機台裝箱明細 = new List<專案機台裝箱明細>();
                form.專案應收沖款明細 = new List<專案應收沖款明細>();
                btnDelete.Visible = false;
                btnApprove.Visible = false;
                btnCancelApprove.Visible = false;
            }
            else if (lblMode.Text == "修改")
            {
                GetFormData();
                if (string.IsNullOrEmpty(form?.核准日))
                {
                    btnApprove.Visible = true;
                    btnCancelApprove.Visible = false;
                }
                else
                {
                    btnApprove.Visible = false;
                    btnCancelApprove.Visible = true;
                }
            }
        }

        private void initSerialNoCbo()
        {
            CommonRep<工令單> rep = _productionController.GetAllWorkOrderSerials();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            _workOrderList = rep.resultList ?? new List<工令單>();
            var source = new List<工令單> { new 工令單 { 專案序號 = "" } };
            source.AddRange(_workOrderList);
            cboSerialNo.DataSource = source;
            cboSerialNo.DisplayMember = "專案序號";
            cboSerialNo.ValueMember = "專案序號";
            cboSerialNo.Text = form?.專案序號 ?? "";
            SyncWorkOrderFields(form?.專案序號);
        }

        private void SyncWorkOrderFields(string serial)
        {
            if (string.IsNullOrEmpty(serial)) { txtClient.Text = ""; txtModel.Text = ""; txtMachine.Text = ""; return; }
            var wo = _workOrderList?.FirstOrDefault(x => x.專案序號 == serial);
            if (wo == null) return;
            txtClient.Text = wo.客戶簡稱 ?? "";
            txtModel.Text = wo.機台型號 ?? "";
            txtMachine.Text = wo.機台名稱 ?? "";
            // load contacts for ATTN / TEL
            string companyName = wo.客戶名稱 ?? wo.客戶簡稱 ?? "";
            LoadContacts(companyName);
        }

        private void LoadContacts(string companyName)
        {
            if (string.IsNullOrEmpty(companyName)) return;
            CommonRep<C客戶連絡人清單> rep = _customerController.GetContactList(companyName);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            _contactList = rep.resultList ?? new List<C客戶連絡人清單>();
            cboAttn.Items.Clear();
            cboAttn.Items.Add("");
            cboTel.Items.Clear();
            cboTel.Items.Add("");
            foreach (var c in _contactList)
            {
                if (!string.IsNullOrEmpty(c.姓名)) cboAttn.Items.Add(c.姓名);
                if (!string.IsNullOrEmpty(c.電話)) cboTel.Items.Add(c.電話);
            }
        }

        private void cboSerialNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncWorkOrderFields(cboSerialNo.Text);
        }

        private void initCurrencyCbo()
        {
            CommonRep<F幣別> rep = _customerController.GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            _currencyList = rep.resultList ?? new List<F幣別>();
            cboCurrency.Items.Clear();
            cboCurrency.Items.Add("");
            foreach (var c in _currencyList) cboCurrency.Items.Add(c.CURRENCY ?? "");
            cboCurrency.Text = form?.Trade ?? "";
        }

        private void initDropdownLists()
        {
            cboContainer.Items.Clear();
            cboContainer.Items.AddRange(new object[] { "", "FCL (Full Container Load)", "LCL (Less Than Container Load)", "Less Than Container Load", "Full Container Load" });
            cboContainer.Text = form?.Container ?? "";

            cboPacking.Items.Clear();
            cboPacking.Items.AddRange(new object[] { "", "Wooden Case(s)", "Carton(s)", "Pallet(s)", "Wooden Pallet(s)" });
            cboPacking.Text = form?.Packing ?? "";

            cboInsurance.Items.Clear();
            cboInsurance.Items.AddRange(new object[] { "", "Buyer Responsible", "Seller Responsible", "Included" });
            cboInsurance.Text = form?.Insurance ?? "";

            cboTypesOfBL.Items.Clear();
            cboTypesOfBL.Items.AddRange(new object[] { "", "Forwarder B/L", "Master B/L", "Sea Waybill", "Express B/L" });
            cboTypesOfBL.Text = form?.TypesOfBL ?? "";

            cboDeliveryTerm.Items.Clear();
            cboDeliveryTerm.Items.AddRange(new object[] { "", "EX-Work", "FOB", "CIF", "CFR", "DAP", "DDP" });
            cboDeliveryTerm.Text = form?.Trade ?? "";

            cboCertOfOrigin.Items.Clear();
            cboCertOfOrigin.Items.AddRange(new object[] { "", "Yes", "No" });
            cboCertOfOrigin.Text = form?.CertOfOrigin ?? "";

            cboSurrenderBL.Items.Clear();
            cboSurrenderBL.Items.AddRange(new object[] { "", "Yes", "No" });
            cboSurrenderBL.Text = form?.SurrenderBL ?? "";

            cboDoc.Items.Clear();
            cboDoc.Items.AddRange(new object[] { "", "Yes", "No" });
            cboDoc.Text = form?.Doc ?? "";

            cboMark.Items.Clear();
            cboMark.Items.AddRange(new object[] { "", "No Mark", "As Per L/C", "As Per Invoice" });
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
            cboSerialNo.Text = form.專案序號 ?? "";
            SyncWorkOrderFields(form.專案序號);
            txtConsignee.Text = form.聯絡人 ?? "";
            txtPostalAdd.Text = form.單據地址 ?? "";
            txtDeliveryAdd.Text = form.交貨地址 ?? "";
            cboAttn.Text = form.聯絡人 ?? "";
            cboTel.Text = form.電話 ?? "";
            txtPONumber.Text = form.訂購單號 ?? "";
            txtPINumber.Text = form.發票單號 ?? "";
            cboContainer.Text = form.Container ?? "";
            txtContainerType.Text = form.ContainerType ?? "";
            cboDeliveryTerm.Text = form.Trade ?? "";
            txtDestinationPort.Text = form.DestinationPort ?? "";
            cboPacking.Text = form.Packing ?? "";
            cboInsurance.Text = form.Insurance ?? "";
            txtCutOff.Text = FmtDate(form.CustomsClose);
            txtETD.Text = FmtDate(form.ETD);
            txtETA.Text = FmtDate(form.ETA);
            cboTypesOfBL.Text = form.TypesOfBL ?? "";
            txtShipName.Text = form.Ship ?? "";
            txtForwarder.Text = form.Forwarder ?? "";
            cboCertOfOrigin.Text = form.CertOfOrigin ?? "";
            cboSurrenderBL.Text = form.SurrenderBL ?? "";
            txtVoyage.Text = form.Voyage ?? "";
            cboDoc.Text = form.Doc ?? "";
            // Mark: split by space into combo + text
            string mark = form.Mark ?? "";
            int sp = mark.IndexOf(' ');
            if (sp > 0) { cboMark.Text = mark.Substring(0, sp); txtMark2.Text = mark.Substring(sp + 1); }
            else { cboMark.Text = mark; txtMark2.Text = ""; }
            txtDestination.Text = form.DestinationPort ?? "";
            txtCaseNo.Text = form.CaseNo ?? "";
            txtTotal.Text = form.Total ?? "";
            // footer
            txtApprover.Text = form.核准 ?? "";
            txtApproveDate.Text = FmtDate(form.核准日);
            txtModifier.Text = form.修改 ?? "";
            txtModifyDate.Text = FmtDate(form.修改日);
            txtCreator.Text = form.建檔 ?? "";
            txtCreateDate.Text = FmtDate(form.建檔日);
            // grids
            initBoxGrid();
            initPaymentGrid();
            CalcPaymentSummary();
        }

        private void initBoxGrid()
        {
            dgvBox.Rows.Clear();
            foreach (var d in form?.專案機台裝箱明細 ?? new List<專案機台裝箱明細>())
            {
                int idx = dgvBox.Rows.Add();
                var row = dgvBox.Rows[idx];
                row.Cells[colDesc.Index].Value = d.Description;
                row.Cells[colQTY.Index].Value = d.QTY?.ToString();
                row.Cells[colUnit.Index].Value = d.Unit;
                row.Cells[colDollar1.Index].Value = d.Dollar1;
                row.Cells[colUnitPrice.Index].Value = d.UnitPrice?.ToString();
                row.Cells[colDollar2.Index].Value = d.Dollar2;
                row.Cells[colAmount.Index].Value = d.Amount?.ToString();
                row.Cells[colNW.Index].Value = d.NWkgs?.ToString();
                row.Cells[colGW.Index].Value = d.GWkgs?.ToString();
                row.Cells[colDim.Index].Value = d.Dimensioncm;
                row.Cells[colHS.Index].Value = d.HSCode;
            }
        }

        private void initPaymentGrid()
        {
            dgvPayment.Rows.Clear();
            foreach (var d in form?.專案應收沖款明細 ?? new List<專案應收沖款明細>())
            {
                int idx = dgvPayment.Rows.Add();
                var row = dgvPayment.Rows[idx];
                row.Cells[colPayDate.Index].Value = FmtDate(d.收款日期);
                row.Cells[colPayItem.Index].Value = d.收款項目;
                row.Cells[colPayType.Index].Value = d.交付形式;
                row.Cells[colWriteOff.Index].Value = d.沖帳金額?.ToString();
                row.Cells[colReceived.Index].Value = d.實收金額?.ToString();
                row.Cells[colFee.Index].Value = d.手續費?.ToString();
                row.Cells[colOtherDeduct.Index].Value = d.其他減項;
                row.Cells[colDeductReason.Index].Value = d.折減事由;
                row.Cells[colOperator.Index].Value = d.沖帳人員;
                row.Cells[colReview.Index].Value = d.業務複審;
            }
        }

        private void CalcPaymentSummary()
        {
            decimal total = (form?.專案應收沖款明細 ?? new List<專案應收沖款明細>())
                .Sum(x => x.實收金額 ?? 0m);
            txtReceivableTotal.Text = total.ToString("N2");
        }

        private void dgvBox_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBox.Rows[e.RowIndex];
            if (e.ColumnIndex == colQTY.Index || e.ColumnIndex == colUnitPrice.Index)
            {
                decimal qty = decimal.TryParse(row.Cells[colQTY.Index].Value?.ToString(), out decimal q) ? q : 0m;
                decimal up = decimal.TryParse(row.Cells[colUnitPrice.Index].Value?.ToString(), out decimal u) ? u : 0m;
                row.Cells[colAmount.Index].Value = (qty * up).ToString("N2");
            }
        }

        private void dgvBox_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void CollectUserInput()
        {
            form.日期 = dtDate.Value.ToString("yyyy/MM/dd");
            form.單號 = txtFormNo.Text;
            form.專案序號 = cboSerialNo.Text;
            form.聯絡人 = cboAttn.Text;
            form.電話 = cboTel.Text;
            form.單據地址 = txtPostalAdd.Text;
            form.交貨地址 = txtDeliveryAdd.Text;
            form.訂購單號 = txtPONumber.Text;
            form.發票單號 = txtPINumber.Text;
            form.Container = cboContainer.Text;
            form.ContainerType = txtContainerType.Text;
            form.Trade = cboDeliveryTerm.Text;
            form.DestinationPort = txtDestinationPort.Text;
            form.Packing = cboPacking.Text;
            form.Insurance = cboInsurance.Text;
            form.CustomsClose = txtCutOff.Text;
            form.ETD = txtETD.Text;
            form.ETA = txtETA.Text;
            form.TypesOfBL = cboTypesOfBL.Text;
            form.Ship = txtShipName.Text;
            form.Forwarder = txtForwarder.Text;
            form.CertOfOrigin = cboCertOfOrigin.Text;
            form.SurrenderBL = cboSurrenderBL.Text;
            form.Voyage = txtVoyage.Text;
            form.Doc = cboDoc.Text;
            string markPart = cboMark.Text?.Trim() ?? "";
            string markPart2 = txtMark2.Text?.Trim() ?? "";
            form.Mark = string.IsNullOrEmpty(markPart2) ? markPart : markPart + " " + markPart2;
            form.CaseNo = txtCaseNo.Text;
            form.Total = txtTotal.Text;
            // collect 裝箱明細
            form.專案機台裝箱明細 = new List<專案機台裝箱明細>();
            foreach (DataGridViewRow row in dgvBox.Rows)
            {
                if (row.IsNewRow) continue;
                string desc = row.Cells[colDesc.Index].Value?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(desc)) continue;
                form.專案機台裝箱明細.Add(new 專案機台裝箱明細
                {
                    單號 = form.單號,
                    Description = desc,
                    QTY = decimal.TryParse(row.Cells[colQTY.Index].Value?.ToString(), out decimal q) ? q : (decimal?)null,
                    Unit = row.Cells[colUnit.Index].Value?.ToString(),
                    Dollar1 = row.Cells[colDollar1.Index].Value?.ToString(),
                    UnitPrice = decimal.TryParse(row.Cells[colUnitPrice.Index].Value?.ToString(), out decimal up) ? up : (decimal?)null,
                    Dollar2 = row.Cells[colDollar2.Index].Value?.ToString(),
                    Amount = decimal.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out decimal amt) ? amt : (decimal?)null,
                    NWkgs = decimal.TryParse(row.Cells[colNW.Index].Value?.ToString(), out decimal nw) ? nw : (decimal?)null,
                    GWkgs = decimal.TryParse(row.Cells[colGW.Index].Value?.ToString(), out decimal gw) ? gw : (decimal?)null,
                    Dimensioncm = row.Cells[colDim.Index].Value?.ToString(),
                    HSCode = row.Cells[colHS.Index].Value?.ToString(),
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<int> rep = _productionController.SaveEQPShipping(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
                lblMode.Text = "修改";
                MessageBox.Show("新增成功!");
                btnDelete.Visible = true;
                btnApprove.Visible = true;
            }
            else
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<int> rep = _productionController.UpdateEQPShipping(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
                MessageBox.Show("儲存成功!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要刪除 {form?.單號} 嗎?", "確認刪除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            CommonRep<int> rep = _productionController.DeleteEQPShipping(form.單號);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("刪除成功!");
            btnBack_Click(null, null);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(form?.單號)) { MessageBox.Show("請先儲存!"); return; }
            CommonRep<int> rep = _productionController.ValidateEQPShipping(form.單號, true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("生效成功!");
            form.核准 = AppSession.User.username;
            form.核准日 = DateTime.Now.ToString("yyyy/MM/dd");
            txtApprover.Text = form.核准;
            txtApproveDate.Text = form.核准日;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = true;
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消生效嗎?", "確認取消生效",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            CommonRep<int> rep = _productionController.ValidateEQPShipping(form.單號, false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("取消生效成功!");
            form.核准 = null; form.核准日 = null;
            txtApprover.Text = ""; txtApproveDate.Text = "";
            btnApprove.Visible = true; btnCancelApprove.Visible = false;
        }

        private void btnUpdateBox_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (string.IsNullOrEmpty(form?.單號)) { MessageBox.Show("請先儲存單號!"); return; }
            form.修改 = AppSession.User.username;
            form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
            CommonRep<int> rep = _productionController.UpdateEQPShipping(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("裝箱明細更新成功!");
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
