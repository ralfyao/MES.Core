using DigiERP.Common;
using DigiERP.Forms.Inventory;
using DigiERP.Forms.Supplier;
using DigiERP.Models;
using DigiERP.UserControl.Supplier.SupplierManage;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.Procurement
{
    public partial class ProcurementMaintainControl : CommonUserControl
    {
        // 沿用 ProcurementControl (採購單列表) 已註冊的權限 GUID
        private static string id = "6E4C2F1D-8A3B-4E6F-9C7D-2B5A9E1F0C3D";

        public B採購單 form { get; set; }

        private List<B廠商設定> _supplierList = new List<B廠商設定>();
        private List<H員工清冊> _purchaserList = new List<H員工清冊>();

        public ProcurementMaintainControl()
        {
            InitializeComponent();
            initCombos();
        }

        public ProcurementMaintainControl(B採購單 form)
        {
            InitializeComponent();
            this.form = form;
            initCombos();
        }

        // ── 下拉選單初始化：廠商／幣別／採購人員 ─────────────────────────
        private void initCombos()
        {
            var supplierRep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(supplierRep.ErrorMessage))
            {
                MessageBox.Show(supplierRep.ErrorMessage);
            }
            else
            {
                _supplierList = (supplierRep.resultList ?? new List<B廠商設定>()).Where(x => x.停用 != true).ToList();
                cboSupplierNo.Items.Clear();
                cboSupplierNo.Items.AddRange(_supplierList.Select(x => (object)x.廠商編號).ToArray());
            }

            var currencyRep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(currencyRep.ErrorMessage))
            {
                MessageBox.Show(currencyRep.ErrorMessage);
            }
            else
            {
                cboCurrency.Items.Clear();
                cboCurrency.Items.AddRange((currencyRep.resultList ?? new List<F幣別>()).Select(x => (object)x.CURRENCY).ToArray());
            }

            var purchaserRep = new ProcurementController().GetProcurementorList();
            if (!string.IsNullOrEmpty(purchaserRep.ErrorMessage))
            {
                MessageBox.Show(purchaserRep.ErrorMessage);
            }
            else
            {
                _purchaserList = purchaserRep.resultList ?? new List<H員工清冊>();
                cboPurchaser.Items.Clear();
                cboPurchaser.Items.AddRange(_purchaserList.Select(x => (object)x.工號).ToArray());
            }
        }

        // ── 對外：由列表頁在設好 lblMode.Text 後呼叫，載入或初始化表單 ────────
        internal void initForm()
        {
            if (lblMode.Text == "修改")
            {
                if (form != null && !string.IsNullOrEmpty(form.單號))
                {
                    var fresh = FetchOrder(form.單號);
                    if (fresh != null) form = fresh;
                }
                PopulateControls(form ?? new B採購單());
                disableAllControls(true);
                SetHeaderIdentityFieldsEnabled(false);
                SetExistingRecordButtonsVisible(true);
                btnDeleteRecord.Visible = chkEditPrivilege(id);
                UpdateActivateButtons();
            }
            else
            {
                form = new B採購單 { procurementList = new List<B採購明細>() };
                var noRep = new ProcurementController().GetPoNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                }
                txtNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                dtDeliveryDate.Value = DateTime.Now;
                dgvDetail.Rows.Clear();
                RecalcFooter();
                disableAllControls(false);
                SetHeaderIdentityFieldsEnabled(true);
                SetExistingRecordButtonsVisible(false);
                btnActivate.Visible = false;
                btnCancelActivate.Visible = false;
                btnPrint.Visible = false;
            }
        }

        // ── 分項結案／刪除紀錄／填入日誌／複製僅適用於已存在的單據 ─────────────
        private void SetExistingRecordButtonsVisible(bool visible)
        {
            btnItemClose.Visible = visible;
            btnDeleteRecord.Visible = visible;
            btnLog.Visible = visible;
            btnCopy.Visible = visible;
        }

        // ── 依單號重新查詢完整表單（含明細），結案/未結案都嘗試 ───────────────
        private B採購單 FetchOrder(string no)
        {
            var rep = new ProcurementController().AllPurchasesList(no, false, false);
            if (string.IsNullOrEmpty(rep.ErrorMessage) && (rep.resultList?.Count ?? 0) > 0)
            {
                return rep.resultList[0];
            }
            var repClosed = new ProcurementController().AllPurchasesList(no, true, false);
            if (string.IsNullOrEmpty(repClosed.ErrorMessage) && (repClosed.resultList?.Count ?? 0) > 0)
            {
                return repClosed.resultList[0];
            }
            return null;
        }

        private void UpdateActivateButtons()
        {
            if (string.IsNullOrEmpty(form?.核准))
            {
                btnActivate.Visible = true;
                btnCancelActivate.Visible = false;
                btnPrint.Visible = false;
            }
            else
            {
                btnActivate.Visible = false;
                btnCancelActivate.Visible = true;
                btnPrint.Visible = true;
            }
        }

        private static DateTime SafeDate(string s)
        {
            return DateTime.TryParse(s, out var d) ? d : DateTime.Now;
        }

        private static string FormatPercent(double? v)
        {
            if (v == null) return "";
            return ((v.Value) * 100).ToString("0") + "%";
        }

        private static double ParsePercent(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            return double.TryParse(s.Replace("%", ""), out var d) ? d / 100.0 : 0;
        }

        private static double ParseDouble(object v)
        {
            return double.TryParse(v?.ToString(), out var d) ? d : 0;
        }

        // ── 將 form 內容帶入畫面控制項 ───────────────────────────────────
        private void PopulateControls(B採購單 f)
        {
            dtDate.Value = SafeDate(f.日期);
            txtNo.Text = f.單號;
            cboSupplierNo.Text = f.廠商編號 ?? "";
            RefreshSupplierDependent();
            cboContact.Text = f.聯絡人 ?? "";
            cboTaxRate.Text = FormatPercent(f.營業稅率);
            cboCurrency.Text = f.幣別 ?? "";
            RefreshExRate();
            cboDeliveryAddr.Text = f.送貨地址 ?? "";
            cboPurchaseCategory.Text = f.採購類別 ?? "";
            cboPayTerm.Text = f.交易條件 ?? "";
            txtShipMethod.Text = f.運輸方式 ?? "";
            cboPurchaser.Text = f.採購人員 ?? "";
            RefreshPurchaserName();
            chkClosed.Checked = f.結案 ?? false;
            txtNote.Text = f.注意事項 ?? "";
            txtTradeTerm.Text = f.貿易條件 ?? "";
            dtDeliveryDate.Value = SafeDate(f.交貨日期);
            txtCreator.Text = f.建檔 ?? "";
            txtCreateDate.Text = f.建檔日 ?? "";
            txtModifier.Text = f.修改 ?? "";
            txtModifyDate.Text = f.修改日 ?? "";
            txtApprover.Text = f.核准 ?? "";
            txtApproveDate.Text = f.核准日 ?? "";
            FillDetailGrid(f.procurementList ?? new List<B採購明細>());
        }

        private void FillDetailGrid(List<B採購明細> list)
        {
            dgvDetail.Rows.Clear();
            foreach (var item in list)
            {
                int idx = dgvDetail.Rows.Add();
                var row = dgvDetail.Rows[idx];
                row.Cells[colItemNo.Index].Value = item.品項編號;
                row.Cells[colItemSpec.Index].Value = item.品名規格;
                row.Cells[colQty.Index].Value = item.數量;
                row.Cells[colUntaxedAmt.Index].Value = item.未稅金額;
                row.Cells[colPurchaseAmt.Index].Value = item.採購金額;
                row.Cells[colProject.Index].Value = item.專案序號;
                row.Cells[colSample.Index].Value = item.樣品 ?? false;
                row.Cells[colNote.Index].Value = item.備註;
                row.Cells[colReqSerial.Index].Value = item.請購序號;
                row.Cells[colOutsourceType.Index].Value = item.代工類別;
                row.Tag = item.識別;
            }
            RecalcFooter();
        }

        private void RefreshSupplierDependent()
        {
            var supplier = _supplierList.FirstOrDefault(x => x.廠商編號 == cboSupplierNo.Text);
            txtSupplierName.Text = supplier?.廠商名稱 ?? "";
            cboContact.Items.Clear();
            if (supplier == null) return;
            var contactRep = new SupplierController().GetContactList(supplier.廠商編號);
            if (!string.IsNullOrEmpty(contactRep.ErrorMessage)) return;
            cboContact.Items.AddRange((contactRep.resultList ?? new List<B廠商聯絡名冊>()).Select(x => (object)x.聯絡人).ToArray());
        }

        private void RefreshExRate()
        {
            if (string.IsNullOrEmpty(cboCurrency.Text))
            {
                txtExRate.Text = "";
                return;
            }
            var rep = new CustomerController().GetExRateList(cboCurrency.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            txtExRate.Text = rep.resultList?.FirstOrDefault()?.匯率 ?? "";
        }

        private void RefreshPurchaserName()
        {
            var p = _purchaserList.FirstOrDefault(x => x.工號 == cboPurchaser.Text);
            lblPurchaserName.Text = p?.姓名 ?? "";
        }

        private void RecalcFooter()
        {
            double untaxed = 0, purchase = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.IsNewRow) continue;
                untaxed += ParseDouble(row.Cells[colUntaxedAmt.Index].Value);
                purchase += ParseDouble(row.Cells[colPurchaseAmt.Index].Value);
            }
            double tax = untaxed * ParsePercent(cboTaxRate.Text);
            txtSumUntaxed.Text = untaxed.ToString("0.##");
            txtSumTax.Text = tax.ToString("0.##");
            txtSumPurchase.Text = purchase.ToString("0.##");
        }

        // ── 將畫面控制項收集回 form ───────────────────────────────────────
        private void CollectUserInput()
        {
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.單號 = txtNo.Text;
            form.廠商編號 = cboSupplierNo.Text;
            form.聯絡人 = cboContact.Text;
            form.營業稅率 = ParsePercent(cboTaxRate.Text);
            form.幣別 = cboCurrency.Text;
            form.匯率 = ParseDouble(txtExRate.Text);
            form.送貨地址 = cboDeliveryAddr.Text;
            form.採購類別 = cboPurchaseCategory.Text;
            form.交易條件 = cboPayTerm.Text;
            form.運輸方式 = txtShipMethod.Text;
            form.採購人員 = cboPurchaser.Text;
            form.結案 = chkClosed.Checked;
            form.注意事項 = txtNote.Text;
            form.貿易條件 = txtTradeTerm.Text;
            form.交貨日期 = dtDeliveryDate.Value.ToString("yyyy-MM-dd");
            form.procurementList = CollectDetailGrid();
        }

        private List<B採購明細> CollectDetailGrid()
        {
            var list = new List<B採購明細>();
            double taxRate = ParsePercent(cboTaxRate.Text);
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.IsNewRow) continue;
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(itemNo)) continue;
                double qty = ParseDouble(row.Cells[colQty.Index].Value);
                double untaxed = ParseDouble(row.Cells[colUntaxedAmt.Index].Value);
                list.Add(new B採購明細
                {
                    識別 = row.Tag is int tagId ? tagId : 0,
                    單號 = form.單號,
                    品項編號 = itemNo,
                    品名規格 = row.Cells[colItemSpec.Index].Value?.ToString(),
                    數量 = qty,
                    原幣未稅 = untaxed,
                    未稅金額 = untaxed,
                    稅額 = untaxed * taxRate,
                    採購金額 = ParseDouble(row.Cells[colPurchaseAmt.Index].Value),
                    單價 = qty != 0 ? untaxed / qty : (double?)null,
                    專案序號 = row.Cells[colProject.Index].Value?.ToString(),
                    樣品 = row.Cells[colSample.Index].Value is bool b && b,
                    備註 = row.Cells[colNote.Index].Value?.ToString(),
                    請購序號 = row.Cells[colReqSerial.Index].Value?.ToString(),
                    代工類別 = row.Cells[colOutsourceType.Index].Value?.ToString(),
                    結案 = false,
                });
            }
            return list;
        }

        private void disableAllControls(bool disable)
        {
            bool enabled = !disable;
            btnActivate.Enabled = enabled;
            btnAllocate.Enabled = enabled;
            btnCancelActivate.Enabled = enabled;
            btnAddNew.Enabled = enabled;
            //btnClose.Enabled = enabled;
            btnCopy.Enabled = enabled;
            btnDeleteRecord.Enabled = enabled;
            btnItemClose.Enabled = enabled;
            btnLog.Enabled = enabled;
            btnOverview.Enabled = enabled;
            btnPrint.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnSelectContact.Enabled = enabled;
            btnVoidAll.Enabled = enabled;
            cboContact.Enabled = enabled;
            btnSelectContact.Enabled = enabled;
            cboTaxRate.Enabled = enabled;
            cboCurrency.Enabled = enabled;
            cboDeliveryAddr.Enabled = enabled;
            cboPurchaseCategory.Enabled = enabled;
            cboPayTerm.Enabled = enabled;
            txtShipMethod.Enabled = enabled;
            cboPurchaser.Enabled = enabled;
            chkClosed.Enabled = enabled;
            btnVoidAll.Enabled = enabled;
            txtNote.Enabled = enabled;
            txtTradeTerm.Enabled = enabled;
            dtDeliveryDate.Enabled = enabled;
            dgvDetail.Enabled = enabled;
            btnModify.Visible = disable && chkEditPrivilege(id);
        }

        // ── 日期／單號／廠商編號／廠商名稱：修改模式下永遠不可異動 ──────────────
        private void SetHeaderIdentityFieldsEnabled(bool enabled)
        {
            dtDate.Enabled = enabled;
            cboSupplierNo.Enabled = enabled;
            btnSelectSupplier.Enabled = enabled;
        }

        // ── 廠商／聯絡人下拉變動 ─────────────────────────────────────────
        private void cboSupplierNo_SelectedIndexChanged(object sender, EventArgs e) => RefreshSupplierDependent();
        private void cboSupplierNo_Leave(object sender, EventArgs e) => RefreshSupplierDependent();
        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e) => RefreshExRate();
        private void cboCurrency_Leave(object sender, EventArgs e) => RefreshExRate();
        private void cboPurchaser_SelectedIndexChanged(object sender, EventArgs e) => RefreshPurchaserName();
        private void cboPurchaser_Leave(object sender, EventArgs e) => RefreshPurchaserName();

        // ── 放大鏡：跳出廠商選取視窗 ─────────────────────────────────────
        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectSupplier();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;
            if (!cboSupplierNo.Items.Contains(frm.Selected.廠商編號))
            {
                cboSupplierNo.Items.Add(frm.Selected.廠商編號);
            }
            cboSupplierNo.Text = frm.Selected.廠商編號;
            RefreshSupplierDependent();
        }

        // ── 聯絡人按鈕：跳出聯絡人選取視窗 ─────────────────────────────────
        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSupplierNo.Text))
            {
                MessageBox.Show("請先選擇廠商編號");
                return;
            }
            var controller = new SupplierController();
            var contactRep = controller.GetContactList(cboSupplierNo.Text);
            if (!string.IsNullOrEmpty(contactRep.ErrorMessage))
            {
                MessageBox.Show(contactRep.ErrorMessage);
                return;
            }
            using var frm = new FrmSelectContact(contactRep.resultList ?? new List<B廠商聯絡名冊>(), cboSupplierNo.Text, controller);
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;
            if (!cboContact.Items.Contains(frm.Selected.聯絡人))
            {
                cboContact.Items.Add(frm.Selected.聯絡人);
            }
            cboContact.Text = frm.Selected.聯絡人;
        }

        // ── 品項編號雙擊：跳出 A材料 選取視窗，帶回品項編號／品名規格／單位 ──────
        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDetail.Rows[e.RowIndex];

            if (e.ColumnIndex == colItemNo.Index)
            {
                using var frm = new FrmSelectMaterial();
                if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;
                row.Cells[colItemNo.Index].Value = frm.Selected.產品編號;
                row.Cells[colItemSpec.Index].Value = frm.Selected.品名規格;
                row.Cells[colUnit.Index].Value = frm.Selected.採購單位;
            }
            else if (e.ColumnIndex == colItemSpec.Index)
            {
                using var frm = new FrmPartsQuery();
                if (frm.ShowDialog(this) != DialogResult.OK) return;
                var item = frm.summaryRepList?.FirstOrDefault();
                if (item == null) return;
                row.Cells[colItemNo.Index].Value = item.產品編號;
                row.Cells[colItemSpec.Index].Value = item.品名規格;
                row.Cells[colUnit.Index].Value = item.採購單位;
            }
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e) => RecalcFooter();
        private void dgvDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => RecalcFooter();
        private void cboTaxRate_SelectedIndexChanged(object sender, EventArgs e) => RecalcFooter();
        private void cboTaxRate_Leave(object sender, EventArgs e) => RecalcFooter();

        // ── 全單作廢：等同勾選作廢 CheckBox ────────────────────────────────
        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            chkClosed.Checked = true;
        }

        // ── 新增／修改／複製／儲存 ───────────────────────────────────────
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblMode.Text = "新增";
            initForm();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
            SetHeaderIdentityFieldsEnabled(false);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            var noRep = new ProcurementController().GetPoNo();
            if (!string.IsNullOrEmpty(noRep.ErrorMessage))
            {
                MessageBox.Show(noRep.ErrorMessage);
                return;
            }
            form.單號 = noRep.result;
            form.建檔 = null;
            form.建檔日 = null;
            form.修改 = null;
            form.修改日 = null;
            form.核准 = null;
            form.核准日 = null;
            form.結案 = false;
            lblMode.Text = "新增";
            PopulateControls(form);
            disableAllControls(false);
            SetHeaderIdentityFieldsEnabled(true);
            SetExistingRecordButtonsVisible(false);
            btnActivate.Visible = false;
            btnCancelActivate.Visible = false;
            btnPrint.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSupplierNo.Text))
            {
                MessageBox.Show("請輸入廠商編號");
                return;
            }
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                var rep = new ProcurementController().CreatePurchaseOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
                var rep = new ProcurementController().UpdatePurchaseOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnClose_Click(null, null);
        }

        // ── 刪除紀錄 ────────────────────────────────────────────────────
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text)) return;
            if (MessageBox.Show("確認刪除整張採購單?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new ProcurementController().DeletePurchaseOrder(txtNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnClose_Click(null, null);
        }

        // ── 分項結案：對選取的明細列呼叫 VoidPurchaseOrderItem ───────────────
        private void btnItemClose_Click(object sender, EventArgs e)
        {
            if (dgvDetail.CurrentRow == null || dgvDetail.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請先選取一筆明細");
                return;
            }
            if (!(dgvDetail.CurrentRow.Tag is int itemId))
            {
                MessageBox.Show("請先儲存後再進行分項結案");
                return;
            }
            if (MessageBox.Show("確認將此明細結案?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new ProcurementController().VoidPurchaseOrderItem(itemId.ToString());
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("分項結案完成!");
            var fresh = FetchOrder(form.單號);
            if (fresh != null)
            {
                form = fresh;
                PopulateControls(form);
            }
        }

        // ── 生效／取消生效 ──────────────────────────────────────────────
        private void btnActivate_Click(object sender, EventArgs e)
        {
            var rep = new ProcurementController().EvaluatePurchaseOrder(txtNo.Text, true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            txtApprover.Text = AppSession.User.username;
            txtApproveDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            form.核准 = txtApprover.Text;
            form.核准日 = txtApproveDate.Text;
            UpdateActivateButtons();
        }

        private void btnCancelActivate_Click(object sender, EventArgs e)
        {
            var rep = new ProcurementController().EvaluatePurchaseOrder(txtNo.Text, false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("取消生效成功!");
            txtApprover.Text = "";
            txtApproveDate.Text = "";
            form.核准 = null;
            form.核准日 = null;
            UpdateActivateButtons();
        }

        // ── 請購分配：選取一筆未結案請購需求，帶入明細列 ─────────────────────
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectPurchaseRequest();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;

            var req = frm.Selected;
            int idx = dgvDetail.Rows.Add();
            var row = dgvDetail.Rows[idx];
            row.Cells[colItemNo.Index].Value = req.品項編號;
            row.Cells[colItemSpec.Index].Value = req.品名規格;
            row.Cells[colQty.Index].Value = req.數量;
            row.Cells[colUnit.Index].Value = req.單位;
            row.Cells[colReqSerial.Index].Value = req.請購序號?.ToString();
            RecalcFooter();
        }

        // ── 尚未開放的功能（無對應後端） ────────────────────────────────
        private void btnLog_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        // ── 列印：直接用畫面上目前的資料（含明細列），不重新查詢資料庫 ─────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            var supplier = _supplierList.FirstOrDefault(x => x.廠商編號 == form.廠商編號);
            using var frm = new FrmPrintPurchaseOrder(form, supplier, lblPurchaserName.Text);
            frm.ShowDialog(this);
        }
        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 關閉 — 回到列表，或若是獨立頁籤則直接關閉該頁籤 ───────────────
        private void btnClose_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
                foreach (Control c in parentCtrl.Controls)
                {
                    if (c is DataGridView) c.Visible = true;
                }
            }
            Dispose();
        }
    }
}
