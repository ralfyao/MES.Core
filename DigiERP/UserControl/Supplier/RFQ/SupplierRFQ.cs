using DigiERP.Common;
using DigiERP.Forms.Inventory;
using DigiERP.Forms.Supplier;
using DigiERP.UserControl.Supplier.SupplierManage;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.RFQ
{
    public partial class SupplierRFQ : CommonUserControl
    {
        private static string id = "95A9B2A7-482F-41AB-A48F-657A63F858FB";
        public SupplierRFQ()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initInquiryPersonCombo();
            AddBlankRow();
        }

        // ── 編修材料設定：依目前材料編號，帶入料品新增修改視窗 ─────────────────
        private void btnEditMaterialSetting_Click(object sender, EventArgs e)
        {
            string itemNo = txtMaterialNo.Text.Trim();
            if (string.IsNullOrEmpty(itemNo))
            {
                MessageBox.Show("請先查詢並選取材料編號");
                return;
            }

            var rep = new ItemController().ItemList(itemNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var item = rep.resultList?.FirstOrDefault();
            if (item == null)
            {
                MessageBox.Show("查無此材料資料");
                return;
            }

            using var frm = new FrmAddPart(item);
            frm.ShowDialog(this);
        }

        // ── 新增預詢材料：跳出新增料品視窗 ──────────────────────────────────
        private void btnAddPreQueryMaterial_Click(object sender, EventArgs e)
        {
            using var frm = new FrmAddPart();
            frm.ShowDialog(this);
        }

        // ── 新增詢價單：清空目前材料及廠商資訊，讓使用者編輯新的詢價清單 ────────
        private void btnAddRFQ_Click(object sender, EventArgs e)
        {
            txtMaterialNo.Text = "";
            txtPurchaseType.Text = "";
            txtCategory.Text = "";
            txtSubCategory.Text = "";
            txtProductCode.Text = "";
            txtSpec.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
            txtThickness.Text = "";
            txtOuterDia.Text = "";
            txtInnerDia.Text = "";

            dataGridView1.Rows.Clear();
            AddBlankRow();
        }

        // ── 詢價人員下拉：H員工清冊，狀況不為離職 ─────────────────────────
        private void initInquiryPersonCombo()
        {
            var rep = new HRController().AllWorkers();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var names = (rep.resultList ?? new List<H員工清冊>())
                .Where(x => x.狀況 != "離職")
                .Select(x => x.姓名)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .ToArray();
            colInquiryPerson.Items.Clear();
            colInquiryPerson.Items.AddRange(names);
        }

        // ── 查料：跳出料品篩選器，選取後帶入材料識別欄位 ─────────────────────
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            using var frmQuery = new FrmPartsQuery();
            if (frmQuery.ShowDialog(this) != DialogResult.OK) return;

            var item = frmQuery.summaryRepList?.FirstOrDefault();
            if (item == null) return;

            txtMaterialNo.Text = item.產品編號;
            txtPurchaseType.Text = item.品別;
            txtCategory.Text = item.大分類;
            txtSubCategory.Text = item.小分類;
            txtProductCode.Text = item.產品代號;
            txtSpec.Text = item.品名規格;
            txtLength.Text = item.外尺寸長?.ToString();
            txtWidth.Text = item.外尺寸寬?.ToString();
            txtThickness.Text = item.厚度?.ToString();
            txtOuterDia.Text = item.外徑?.ToString();
            txtInnerDia.Text = item.內徑?.ToString();

            LoadQuotationList(item.產品編號);
        }

        // ── 讀取該材料已存在的廠商供料清單，填入列表 ─────────────────────────
        private void LoadQuotationList(string? itemNo)
        {
            if (string.IsNullOrEmpty(itemNo)) return;

            var rep = new SupplierController().QuotationByItem(itemNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillQuotationGrid(rep.result?.materialList ?? new List<B廠商供料>());
        }

        private void FillQuotationGrid(List<B廠商供料> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var q in list)
            {
                AddRow(q);
            }
            AddBlankRow();
        }

        // ── 新增一列，source 為 null 時代表尚未儲存的空白列（詢價/報價日期預設今天） ──
        private void AddRow(B廠商供料? source)
        {
            int idx = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[idx];
            string today = DateTime.Now.ToString("yyyy/MM/dd");

            row.Cells[colInquiryDate.Index].Value = source?.詢價日期 ?? today;
            row.Cells[colQuoteValidDate.Index].Value = source?.報價有效日期 ?? today;
            if (source == null) return;

            AddComboItemIfMissing(colSupplierNo, source.廠商編號);
            AddComboItemIfMissing(colCurrency, source.幣別);
            AddComboItemIfMissing(colInquiryPerson, source.詢價人員);

            row.Cells[colSupplierNo.Index].Value = source.廠商編號;
            row.Cells[colSupplierShortName.Index].Value = source.廠商簡稱;
            row.Cells[colUnitPrice.Index].Value = source.單價;
            row.Cells[colCurrency.Index].Value = source.幣別;
            row.Cells[colPurchaseUnit.Index].Value = source.採購單位;
            row.Cells[colMinPurchaseQty.Index].Value = source.最低採購量;
            row.Cells[colPlannedPurchaseQty.Index].Value = source.最大採購量;
            row.Cells[colInquiryPerson.Index].Value = source.詢價人員;
            row.Cells[colSupplierPartNo.Index].Value = source.廠商品號;
            row.Tag = source;
        }

        private void AddBlankRow() => AddRow(null);

        private static void AddComboItemIfMissing(DataGridViewComboBoxColumn column, string? value)
        {
            if (!string.IsNullOrEmpty(value) && !column.Items.Contains(value))
            {
                column.Items.Add(value);
            }
        }

        // ── 儲存紀錄：依材料編號，將列表中的廠商資訊寫入/更新 B廠商供料 ───────
        // 既有列（row.Tag 帶有識別）走更新，其餘一律視為新增，交由後端依 識別 是否為 null 判斷
        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            string itemNo = txtMaterialNo.Text.Trim();
            if (string.IsNullOrEmpty(itemNo))
            {
                MessageBox.Show("請先查詢並選取材料編號");
                return;
            }

            var toSave = new List<B廠商供料>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string? supplierNo = row.Cells[colSupplierNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(supplierNo)) continue;

                var existing = row.Tag as B廠商供料;
                toSave.Add(new B廠商供料
                {
                    識別 = existing?.識別,
                    廠商編號 = supplierNo,
                    品項編號 = itemNo,
                    詢價日期 = row.Cells[colInquiryDate.Index].Value?.ToString(),
                    採購單位 = row.Cells[colPurchaseUnit.Index].Value?.ToString(),
                    最低採購量 = ToInt(row.Cells[colMinPurchaseQty.Index].Value),
                    最大採購量 = ToInt(row.Cells[colPlannedPurchaseQty.Index].Value),
                    單價 = ToInt(row.Cells[colUnitPrice.Index].Value),
                    幣別 = row.Cells[colCurrency.Index].Value?.ToString(),
                    詢價人員 = row.Cells[colInquiryPerson.Index].Value?.ToString(),
                    報價有效日期 = row.Cells[colQuoteValidDate.Index].Value?.ToString(),
                    廠商品號 = row.Cells[colSupplierPartNo.Index].Value?.ToString(),
                });
            }

            if (toSave.Count == 0)
            {
                MessageBox.Show("請至少輸入一筆廠商資料");
                return;
            }

            var rep = new SupplierController().UpdateSupplierQuotationList(toSave);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("儲存成功");
            LoadQuotationList(itemNo);
        }

        private static int? ToInt(object? value) => decimal.TryParse(value?.ToString(), out var d) ? (int?)d : null;

        // ── 列印詢價單：直接用畫面上目前的資料（含尚未儲存的新列），
        //    不重新查詢資料庫，避免新增未儲存時列印出空白內容 ───────────────
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colPrint.Index) return;

            string itemNo = txtMaterialNo.Text.Trim();
            if (string.IsNullOrEmpty(itemNo))
            {
                MessageBox.Show("請先查詢並選取材料編號");
                return;
            }

            var row = dataGridView1.Rows[e.RowIndex];
            string? supplierNo = row.Cells[colSupplierNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(supplierNo))
            {
                MessageBox.Show("請先選取廠商編號");
                return;
            }

            var supplierRep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(supplierRep.ErrorMessage))
            {
                MessageBox.Show(supplierRep.ErrorMessage);
                return;
            }
            var supplier = (supplierRep.resultList ?? new List<B廠商設定>()).FirstOrDefault(x => x.廠商編號 == supplierNo);
            if (supplier == null)
            {
                MessageBox.Show("查無廠商資料");
                return;
            }

            var quote = new B廠商供料
            {
                廠商編號 = supplierNo,
                廠商簡稱 = row.Cells[colSupplierShortName.Index].Value?.ToString(),
                詢價日期 = row.Cells[colInquiryDate.Index].Value?.ToString(),
                單價 = ToInt(row.Cells[colUnitPrice.Index].Value),
                幣別 = row.Cells[colCurrency.Index].Value?.ToString(),
                採購單位 = row.Cells[colPurchaseUnit.Index].Value?.ToString(),
                最低採購量 = ToInt(row.Cells[colMinPurchaseQty.Index].Value),
                最大採購量 = ToInt(row.Cells[colPlannedPurchaseQty.Index].Value),
                詢價人員 = row.Cells[colInquiryPerson.Index].Value?.ToString(),
                報價有效日期 = row.Cells[colQuoteValidDate.Index].Value?.ToString(),
                廠商品號 = row.Cells[colSupplierPartNo.Index].Value?.ToString(),
            };

            using var frm = new FrmPrintPurchaseRFQ(supplier, quote, itemNo, txtSpec.Text);
            frm.ShowDialog(this);
        }

        // ── 廠商編號下拉：改跳出廠商選取清單，選取後帶回廠商編號/廠商簡稱 ──────
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != colSupplierNo.Index) return;
            e.Cancel = true;

            using var frmSelect = new FrmSelectSupplier();
            if (frmSelect.ShowDialog(this) != DialogResult.OK || frmSelect.Selected == null) return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (!colSupplierNo.Items.Contains(frmSelect.Selected.廠商編號))
            {
                colSupplierNo.Items.Add(frmSelect.Selected.廠商編號);
            }
            row.Cells[colSupplierNo.Index].Value = frmSelect.Selected.廠商編號;
            row.Cells[colSupplierShortName.Index].Value = frmSelect.Selected.廠商簡稱;
        }
    }
}
