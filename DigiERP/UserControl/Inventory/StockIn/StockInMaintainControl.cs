using DigiERP.Common;
using DigiERP.Forms.Inventory;
using DigiERP.Models;
using DigiERP.UserControl.Supplier.SupplierManage;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    public partial class StockInMaintainControl : CommonUserControl
    {
        public B進貨驗收單 form { get; set; }

        private List<H員工清冊> _warehouseWorkerList = new List<H員工清冊>();
        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();

        public StockInMaintainControl()
        {
            InitializeComponent();
            initCombos();
        }

        public StockInMaintainControl(B進貨驗收單 form)
        {
            InitializeComponent();
            this.form = form;
            initCombos();
        }

        private void initCombos()
        {
            var rep = new StockInController().GetWarehouseWorkers();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _warehouseWorkerList = rep.resultList ?? new List<H員工清冊>();
            cboWarehouseWorker.Items.Clear();
            cboWarehouseWorker.Items.AddRange(_warehouseWorkerList.Select(x => (object)x.工號).ToArray());

            var supplierRep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(supplierRep.ErrorMessage))
            {
                MessageBox.Show(supplierRep.ErrorMessage);
                return;
            }
            _supplierMap = (supplierRep.resultList ?? new List<B廠商設定>())
                .Where(x => !string.IsNullOrEmpty(x.廠商編號))
                .GroupBy(x => x.廠商編號!)
                .ToDictionary(g => g.Key, g => g.First());
        }

        // ── 依廠商編號查目前的廠商簡稱，避免明細內舊資料未同步 ───────────────
        private string ResolveSupplierShortName(string supplierNo, string fallback)
        {
            if (!string.IsNullOrEmpty(supplierNo) && _supplierMap.TryGetValue(supplierNo, out var supplier))
            {
                return supplier.廠商簡稱 ?? fallback;
            }
            return fallback;
        }

        // ── 對外：由列表頁在設好 lblMode.Text 後呼叫，載入或初始化表單 ────────
        internal void initForm()
        {
            if (lblMode.Text == "修改")
            {
                if (form != null && !string.IsNullOrEmpty(form.單號))
                {
                    var fresh = FetchStockIn(form.單號);
                    if (fresh != null) form = fresh;
                }
                PopulateControls(form ?? new B進貨驗收單());
                disableAllControls(true);
                SetExistingRecordButtonsVisible(true);
                UpdateReviewButtons();
            }
            else
            {
                form = new B進貨驗收單 { detailList = new List<B進退貨驗收明細>() };
                var noRep = new StockInController().GetFormNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                }
                txtNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                cboWarehouseWorker.Text = "";
                lblWarehouseWorkerName.Text = "";
                txtVoucher.Text = "";
                txtNote.Text = "";
                txtReviewer.Text = "";
                txtReviewDate.Text = "";
                dgvDetail.Rows.Clear();
                disableAllControls(false);
                SetExistingRecordButtonsVisible(false);
                btnReview.Visible = false;
                btnCancelReview.Visible = false;
            }
        }

        private B進貨驗收單 FetchStockIn(string no)
        {
            var rep = new StockInController().AllStockInList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return null;
            return (rep.resultList ?? new List<B進貨驗收單>()).FirstOrDefault(x => x.單號 == no);
        }

        private void UpdateReviewButtons()
        {
            if (string.IsNullOrEmpty(form?.採購覆核))
            {
                btnReview.Visible = true;
                btnCancelReview.Visible = false;
            }
            else
            {
                btnReview.Visible = false;
                btnCancelReview.Visible = true;
            }
        }

        // ── 分項結案／刪除紀錄／採購分配等僅適用於已存在的單據 ─────────────────
        private void SetExistingRecordButtonsVisible(bool visible)
        {
            btnAllocate.Visible = visible;
            btnVoucher.Visible = visible;
            btnDeleteRecord.Visible = visible;
        }

        private void PopulateControls(B進貨驗收單 f)
        {
            dtDate.Value = DateTime.TryParse(f.日期, out var d) ? d : DateTime.Now;
            txtNo.Text = f.單號;
            cboWarehouseWorker.Text = f.倉管人員 ?? "";
            RefreshWarehouseWorkerName();
            txtVoucher.Text = f.傳票 ?? "";
            txtNote.Text = f.備註 ?? "";
            txtReviewer.Text = f.採購覆核 ?? "";
            txtReviewDate.Text = f.覆核日 ?? "";
            dtDate.Enabled = false;
            txtNo.Enabled = false;
            if (string.IsNullOrEmpty(f.採購覆核)) 
            { 
                btnPrint.Visible = false; 
            } 
            else 
            { 
                btnPrint.Visible = true; 
            }
            FillDetailGrid(f.detailList ?? new List<B進退貨驗收明細>());
        }

        private void FillDetailGrid(List<B進退貨驗收明細> list)
        {
            dgvDetail.Rows.Clear();
            foreach (var item in list)
            {
                int idx = dgvDetail.Rows.Add();
                var row = dgvDetail.Rows[idx];
                row.Cells[colItemNo.Index].Value = item.品項編號;
                row.Cells[colItemSpec.Index].Value = item.品名規格;
                row.Cells[colUnit.Index].Value = item.單位;
                row.Cells[colSupplierNo.Index].Value = item.廠商編號;
                row.Cells[colSupplierShortName.Index].Value = ResolveSupplierShortName(item.廠商編號, item.廠商簡稱);
                row.Cells[colPurchaseQty.Index].Value = item.採購數量;
                row.Cells[colReceiveQty.Index].Value = item.收貨數量;
                row.Cells[colQualifiedQty.Index].Value = item.合格數量;
                row.Cells[colSpecialQty.Index].Value = item.特採數量;
                row.Cells[colReturnQty.Index].Value = item.退回數量;
                row.Cells[colSample.Index].Value = item.樣品 ?? false;
                row.Cells[colBatchNo.Index].Value = item.批號;
                row.Cells[colProject.Index].Value = item.包裝單號;
                row.Cells[colPurchaseNo.Index].Value = item.採購單號;
                row.Cells[colActualPrice.Index].Value = item.實際單價;
                row.Cells[colDiscountAmt.Index].Value = item.折讓金額;
                row.Cells[colPaymentAmt.Index].Value = item.付款金額;
                row.Tag = item.識別碼;
            }
        }

        private void RefreshWarehouseWorkerName()
        {
            var w = _warehouseWorkerList.FirstOrDefault(x => x.工號 == cboWarehouseWorker.Text);
            lblWarehouseWorkerName.Text = w?.姓名 ?? "";
        }

        private void cboWarehouseWorker_SelectedIndexChanged(object sender, EventArgs e) => RefreshWarehouseWorkerName();
        private void cboWarehouseWorker_Leave(object sender, EventArgs e) => RefreshWarehouseWorkerName();

        private void CollectUserInput()
        {
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.單號 = txtNo.Text;
            form.倉管人員 = cboWarehouseWorker.Text;
            form.傳票 = txtVoucher.Text;
            form.備註 = txtNote.Text;
            form.採購覆核 = string.IsNullOrEmpty(txtReviewer.Text) ? null : txtReviewer.Text;
            form.覆核日 = string.IsNullOrEmpty(txtReviewDate.Text) ? null : txtReviewDate.Text;
            form.detailList = CollectDetailGrid();
        }

        private List<B進退貨驗收明細> CollectDetailGrid()
        {
            var list = new List<B進退貨驗收明細>();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.IsNewRow) continue;
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(itemNo)) continue;
                list.Add(new B進退貨驗收明細
                {
                    識別碼 = row.Tag is int tagId ? tagId : 0,
                    單號 = form.單號,
                    品項編號 = itemNo,
                    品名規格 = row.Cells[colItemSpec.Index].Value?.ToString(),
                    單位 = row.Cells[colUnit.Index].Value?.ToString(),
                    廠商編號 = row.Cells[colSupplierNo.Index].Value?.ToString(),
                    廠商簡稱 = row.Cells[colSupplierShortName.Index].Value?.ToString(),
                    採購數量 = ToFloat(row.Cells[colPurchaseQty.Index].Value),
                    收貨數量 = ToFloat(row.Cells[colReceiveQty.Index].Value),
                    合格數量 = ToFloat(row.Cells[colQualifiedQty.Index].Value),
                    特採數量 = ToFloat(row.Cells[colSpecialQty.Index].Value),
                    退回數量 = ToFloat(row.Cells[colReturnQty.Index].Value),
                    樣品 = row.Cells[colSample.Index].Value is bool b && b,
                    批號 = row.Cells[colBatchNo.Index].Value?.ToString(),
                    包裝單號 = row.Cells[colProject.Index].Value?.ToString(),
                    採購單號 = row.Cells[colPurchaseNo.Index].Value?.ToString(),
                    實際單價 = ToFloat(row.Cells[colActualPrice.Index].Value),
                    折讓金額 = ToFloat(row.Cells[colDiscountAmt.Index].Value),
                    付款金額 = ToFloat(row.Cells[colPaymentAmt.Index].Value),
                });
            }
            return list;
        }

        private static float? ToFloat(object v) => float.TryParse(v?.ToString(), out var f) ? f : null;

        private void disableAllControls(bool disable)
        {
            bool enabled = !disable;
            btnAddNew.Enabled = enabled;
            btnAllocate.Enabled = enabled;
            btnVoucher.Enabled = enabled;
            btnDeleteRecord.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnReview.Enabled = enabled;
            btnCancelReview.Enabled = enabled;
            btnPrint.Enabled = enabled;
            dtDate.Enabled = enabled;
            cboWarehouseWorker.Enabled = enabled;
            txtVoucher.Enabled = enabled;
            txtNote.Enabled = enabled;
            dgvDetail.Enabled = enabled;
            btnModify.Visible = disable;
        }

        // ── 品項編號雙擊：跳出 A材料 選取視窗，帶回品項編號／品名規格／單位 ──────
        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colItemNo.Index) return;

            using var frm = new FrmSelectMaterial();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;

            var row = dgvDetail.Rows[e.RowIndex];
            row.Cells[colItemNo.Index].Value = frm.Selected.產品編號;
            row.Cells[colItemSpec.Index].Value = frm.Selected.品名規格;

            var itemRep = new ItemController().ItemList(frm.Selected.產品編號);
            var stockUnit = itemRep.resultList?.FirstOrDefault()?.庫存單位;
            row.Cells[colUnit.Index].Value = stockUnit ?? frm.Selected.採購單位;
        }

        // ── 點選品項編號：跳出該品項的材料庫存卡 ─────────────────────────────
        // ── 點選廠商編號：跳出選取廠商畫面，帶入廠商編號／廠商簡稱 ───────────────
        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colItemNo.Index)
            {
                string itemNo = dgvDetail.Rows[e.RowIndex].Cells[colItemNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(itemNo)) return;

                using var frm = new FrmMaterialStockCard(itemNo);
                frm.ShowDialog(this);
            }
            else if (e.ColumnIndex == colSupplierNo.Index)
            {
                using var frm = new FrmSelectSupplier();
                if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;

                var row = dgvDetail.Rows[e.RowIndex];
                row.Cells[colSupplierNo.Index].Value = frm.Selected.廠商編號;
                row.Cells[colSupplierShortName.Index].Value = frm.Selected.廠商簡稱;
            }
        }

        // ── 實際單價／折讓金額／合格數量異動時，自動算出付款金額 ───────────────
        // 付款金額 = 實際單價 × 合格數量 - 折讓金額（未輸入視為 0）
        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != colActualPrice.Index && e.ColumnIndex != colDiscountAmt.Index && e.ColumnIndex != colQualifiedQty.Index) return;

            var row = dgvDetail.Rows[e.RowIndex];
            float actualPrice = ToFloat(row.Cells[colActualPrice.Index].Value) ?? 0;
            float discount = ToFloat(row.Cells[colDiscountAmt.Index].Value) ?? 0;
            float qualifiedQty = ToFloat(row.Cells[colQualifiedQty.Index].Value) ?? 0;
            row.Cells[colPaymentAmt.Index].Value = actualPrice * qualifiedQty - discount;
        }

        // ── 採購分配：選取一筆尚未結案的採購明細，帶入明細列 ───────────────────
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectAvailablePurchaseItem();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;

            var picked = frm.Selected;
            int idx = dgvDetail.Rows.Add();
            var row = dgvDetail.Rows[idx];
            row.Cells[colItemNo.Index].Value = picked.品項編號;
            row.Cells[colItemSpec.Index].Value = picked.品名規格;
            row.Cells[colSupplierNo.Index].Value = picked.廠商編號;
            row.Cells[colSupplierShortName.Index].Value = picked.廠商簡稱;
            row.Cells[colPurchaseQty.Index].Value = picked.採購數量;
            row.Cells[colPurchaseNo.Index].Value = picked.單號;
            row.Cells[colSample.Index].Value = picked.樣品 ?? false;

            var itemRep = new ItemController().ItemList(picked.品項編號);
            row.Cells[colUnit.Index].Value = itemRep.resultList?.FirstOrDefault()?.庫存單位;
        }

        // ── 新增／修改／儲存 ───────────────────────────────────────────────
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblMode.Text = "新增";
            initForm();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboWarehouseWorker.Text))
            {
                MessageBox.Show("請選擇倉管人員");
                return;
            }
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            var rep = new StockInController().SaveUpdateStockInForm(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnClose_Click(null, null);
        }

        // ── 刪除紀錄 ────────────────────────────────────────────────────
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text)) return;
            if (MessageBox.Show("確認刪除整張進貨單?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new StockInController().DeleteStockInForm(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnClose_Click(null, null);
        }

        // ── 覆核／取消覆核 ──────────────────────────────────────────────
        private void btnReview_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            form.採購覆核 = AppSession.User.username;
            form.覆核日 = DateTime.Now.ToString("yyyy-MM-dd");
            var rep = new StockInController().SaveUpdateStockInForm(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = form.採購覆核;
            txtReviewDate.Text = form.覆核日;
            btnPrint.Visible = true;
            btnPrint.Enabled = true;
            MessageBox.Show("覆核成功!");
            UpdateReviewButtons();
        }

        private void btnCancelReview_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            form.採購覆核 = null;
            form.覆核日 = null;
            var rep = new StockInController().SaveUpdateStockInForm(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = "";
            txtReviewDate.Text = "";
            btnPrint.Visible = false;
            btnPrint.Enabled = false;
            MessageBox.Show("取消覆核成功!");
            UpdateReviewButtons();
        }

        // ── 尚未開放的功能（無對應後端／未提供設計） ────────────────────────
        private void btnVoucher_Click(object sender, EventArgs e)
        {
            using var frm = new FrmVoucher(txtNo.Text);
            frm.ShowDialog(this);
        }
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
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
