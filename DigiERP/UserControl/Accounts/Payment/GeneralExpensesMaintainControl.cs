using DigiERP.Common;
using DigiERP.Models;
using DigiERP.UserControl.Supplier.SupplierManage;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Payment
{
    public partial class GeneralExpensesMaintainControl : CommonUserControl
    {
        private static string id = "2A6D9F13-5C8E-4B27-A146-9D3F6C8E1B75";

        private static readonly string[] PaymentTerms = { "貨到T/T", "即期票", "月結當月票", "月結30天", "月結60天", "月結90天" };
        private static readonly string[] Categories = { "委外代工", "工廠雜項", "行政事務", "市場行銷" };
        private static readonly string[] TaxRates = { "0", "5" };

        internal event EventHandler Saved;

        private string _mode = "新增";
        private F總務支出單 _form;
        private Dictionary<string, F收支項目設定> _itemMap = new Dictionary<string, F收支項目設定>();

        public GeneralExpensesMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            cboPaymentTerm.Items.AddRange(PaymentTerms);
            cboCategory.Items.AddRange(Categories);
            cboTaxRate.Items.AddRange(TaxRates);
        }

        // ── 進入點：由列表頁呼叫，mode="新增" 或 "修改" ─────────────────────
        internal void LoadData(string mode, string no)
        {
            _mode = mode;
            initSupplierCombo();
            initCurrencyCombo();
            initPurchaserCombo();
            initItemCombo();

            if (_mode == "修改")
            {
                var rep = new GeneralExpensesController().GetGeneralExpensesByNo(no);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                _form = rep.result ?? new F總務支出單 { 單號 = no };
                PopulateForm(_form);
                disableControls(true);

                bool verified = !string.IsNullOrEmpty(_form.核准);
                btnVerify.Visible = !verified;
                btnCancelVerify.Visible = verified;
                btnPrint.Visible = verified;
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
            else
            {
                _form = new F總務支出單 { detailList = new List<F其他收支明細>() };
                var noRep = new GeneralExpensesController().GetGeneralExpensesNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                    return;
                }
                txtNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                txtCreator.Text = AppSession.User?.username;
                txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dataGridView1.Rows.Clear();
                disableControls(false);

                btnModify.Visible = false;
                btnVerify.Visible = false;
                btnCancelVerify.Visible = false;
                btnPrint.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void PopulateForm(F總務支出單 form)
        {
            dtDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtNo.Text = form.單號;
            SelectComboItem(cboSupplier, (B廠商設定 x) => x.廠商編號, form.廠商編號);
            txtSupplierName.Text = (cboSupplier.SelectedItem as B廠商設定)?.廠商名稱;
            txtContact.Text = form.聯絡人;
            cboPaymentTerm.Text = form.交易條件;
            cboCurrency.SelectedValue = form.幣別;
            txtExRate.Text = form.匯率.ToString();
            SelectComboItem(cboPurchaser, (H員工清冊 x) => x.工號, form.採購人員);
            lblPurchaserName.Text = (cboPurchaser.SelectedItem as H員工清冊)?.姓名;
            chkVoid.Checked = !string.IsNullOrEmpty(form.結案);
            cboCategory.Text = form.採購類別;
            cboTaxRate.Text = form.營業稅率;
            txtVoucherNo.Text = form.傳票;
            txtNote.Text = form.注意事項;
            txtReviewer.Text = form.核准;
            txtReviewDate.Text = form.核准日;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtCreator.Text = form.建檔;
            txtCreateDate.Text = form.建檔日;
            FillGrid(form.detailList ?? new List<F其他收支明細>());
        }

        private void FillGrid(List<F其他收支明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colItemNo.Index].Value = item.項目編號;
                _itemMap.TryGetValue(item.項目編號 ?? "", out var itemDef);
                row.Cells[colItemName.Index].Value = itemDef?.項目名稱;
                row.Cells[colOrigAmt.Index].Value = item.原幣未稅;
                row.Cells[colTwdAmt.Index].Value = item.未稅;
                row.Cells[colTax.Index].Value = item.稅;
                row.Cells[colAmount.Index].Value = item.金額;
                row.Cells[colRemark.Index].Value = item.備註;
            }
        }

        // ── 廠商編號下拉（純下拉選單，不使用彈出選取視窗） ──────────────────
        private void initSupplierCombo()
        {
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboSupplier.DataSource = rep.resultList ?? new List<B廠商設定>();
            cboSupplier.DisplayMember = "廠商編號";
        }

        private void initCurrencyCombo()
        {
            var rep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboCurrency.DataSource = rep.resultList ?? new List<F幣別>();
            cboCurrency.DisplayMember = "CURRENCY";
            cboCurrency.ValueMember = "CURRENCY";
        }

        private void initPurchaserCombo()
        {
            var rep = new GeneralExpensesController().GetActiveEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboPurchaser.DataSource = rep.resultList ?? new List<H員工清冊>();
            cboPurchaser.DisplayMember = "工號";
        }

        // ── 依 Trim 後之鍵值比對選取項目（部分欄位為固定長度字串，含尾端空白）──
        private static void SelectComboItem<T>(ComboBox combo, Func<T, string> keySelector, string wantedKey)
        {
            string wanted = (wantedKey ?? "").Trim();
            foreach (var item in combo.Items)
            {
                if ((keySelector((T)item) ?? "").Trim() == wanted)
                {
                    combo.SelectedItem = item;
                    return;
                }
            }
            combo.SelectedIndex = -1;
        }

        private void initItemCombo()
        {
            var rep = new ARController().GetItemNumberList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<F收支項目設定>();
            _itemMap = list.Where(x => !string.IsNullOrEmpty(x.項目編號))
                .GroupBy(x => x.項目編號!)
                .ToDictionary(g => g.Key, g => g.First());
            colItemNo.Items.Clear();
            foreach (var item in list)
            {
                colItemNo.Items.Add(item.項目編號);
            }
        }

        // ── 除單號／日期恆不可修改外，其餘欄位依 enable 切換 ────────────────
        private void disableControls(bool enable)
        {
            enable = !enable;
            cboSupplier.Enabled = enable;
            btnSelectSupplier.Enabled = enable;
            txtContact.Enabled = enable;
            cboPaymentTerm.Enabled = enable;
            cboCurrency.Enabled = enable;
            txtExRate.Enabled = enable;
            cboPurchaser.Enabled = enable;
            chkVoid.Enabled = enable;
            cboCategory.Enabled = enable;
            cboTaxRate.Enabled = enable;
            txtNote.Enabled = enable;
            dataGridView1.Enabled = enable;
            btnVoidAll.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(false);
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSupplierName.Text = (cboSupplier.SelectedItem as B廠商設定)?.廠商名稱;
        }

        // ── 點選放大鏡：跳出廠商選取視窗 ─────────────────────────────────
        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectSupplier();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;
            SelectComboItem(cboSupplier, (B廠商設定 x) => x.廠商編號, frm.Selected.廠商編號);
            txtSupplierName.Text = frm.Selected.廠商名稱;
        }

        private void cboPurchaser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPurchaserName.Text = (cboPurchaser.SelectedItem as H員工清冊)?.姓名;
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currency = cboCurrency.SelectedValue?.ToString() ?? "";
            if (string.IsNullOrEmpty(currency)) return;
            var rep = new CustomerController().GetExRateList(currency);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtExRate.Text = rep.resultList?.FirstOrDefault()?.匯率 ?? "0";
        }

        // ── 明細項目編號下拉選定後，即時帶出項目名稱 ────────────────────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty && dataGridView1.CurrentCell?.ColumnIndex == colItemNo.Index)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colItemNo.Index) return;
            string itemNo = dataGridView1.Rows[e.RowIndex].Cells[colItemNo.Index].Value?.ToString();
            _itemMap.TryGetValue(itemNo ?? "", out var itemDef);
            dataGridView1.Rows[e.RowIndex].Cells[colItemName.Index].Value = itemDef?.項目名稱;
        }

        // ── 原幣未稅輸入完成後：帶出台幣未稅(×匯率)、稅額(台幣未稅×稅率)、金額(台幣未稅+稅額) ──
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colOrigAmt.Index) return;
            var row = dataGridView1.Rows[e.RowIndex];
            decimal.TryParse(row.Cells[colOrigAmt.Index].Value?.ToString(), out var origAmt);
            decimal.TryParse(txtExRate.Text, out var exRate);
            decimal twdAmt = Math.Round(origAmt * exRate, 0);
            decimal.TryParse(cboTaxRate.Text, out var taxRatePct);
            decimal tax = Math.Round(twdAmt * taxRatePct / 100m, 0);
            decimal amount = twdAmt + tax;
            row.Cells[colTwdAmt.Index].Value = twdAmt;
            row.Cells[colTax.Index].Value = tax;
            row.Cells[colAmount.Index].Value = amount;
        }

        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定全單作廢?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                chkVoid.Checked = true;
            }
        }

        private F總務支出單 CollectFormData()
        {
            var form = _form ?? new F總務支出單();
            form.單號 = txtNo.Text;
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.廠商編號 = (cboSupplier.SelectedItem as B廠商設定)?.廠商編號?.Trim();
            form.聯絡人 = txtContact.Text;
            form.交易條件 = cboPaymentTerm.Text;
            form.幣別 = cboCurrency.SelectedValue?.ToString();
            decimal.TryParse(txtExRate.Text, out var exRate);
            form.匯率 = exRate;
            form.採購人員 = (cboPurchaser.SelectedItem as H員工清冊)?.工號?.Trim();
            form.採購類別 = cboCategory.Text;
            form.營業稅率 = cboTaxRate.Text;
            form.傳票 = txtVoucherNo.Text;
            form.注意事項 = txtNote.Text;
            form.結案 = chkVoid.Checked ? (AppSession.User?.username ?? "V") : "";

            if (_mode == "新增")
            {
                form.建檔 = AppSession.User?.username;
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                form.修改 = AppSession.User?.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
            }

            form.detailList = new List<F其他收支明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(itemNo)) continue;
                decimal.TryParse(row.Cells[colOrigAmt.Index].Value?.ToString(), out var origAmt);
                decimal.TryParse(row.Cells[colTwdAmt.Index].Value?.ToString(), out var twdAmt);
                decimal.TryParse(row.Cells[colTax.Index].Value?.ToString(), out var tax);
                decimal.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var amount);
                form.detailList.Add(new F其他收支明細
                {
                    單號 = form.單號,
                    項目編號 = itemNo,
                    原幣未稅 = origAmt,
                    未稅 = twdAmt,
                    稅 = tax,
                    金額 = amount,
                    備註 = row.Cells[colRemark.Index].Value?.ToString()
                });
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSupplier.Text))
            {
                MessageBox.Show("請選擇廠商編號!");
                return;
            }
            var form = CollectFormData();
            if (MessageBox.Show($"確定{_mode}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            var rep = _mode == "新增"
                ? new GeneralExpensesController().SaveGeneralExpenses(form)
                : new GeneralExpensesController().UpdateGeneralExpenses(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show(_mode + "成功!");
            Saved?.Invoke(this, EventArgs.Empty);
            btnClose_Click(sender, e);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text)) return;
            if (MessageBox.Show("確定覆核?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new GeneralExpensesController().ValidateGeneralExpenses(txtNo.Text, true, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = AppSession.User?.username;
            txtReviewDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btnVerify.Visible = false;
            btnCancelVerify.Visible = true;
            btnPrint.Visible = true;
            MessageBox.Show("覆核成功!");
        }

        private void btnCancelVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text)) return;
            if (MessageBox.Show("確定取消覆核?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new GeneralExpensesController().ValidateGeneralExpenses(txtNo.Text, false, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = "";
            txtReviewDate.Text = "";
            btnVerify.Visible = true;
            btnCancelVerify.Visible = false;
            btnPrint.Visible = false;
            MessageBox.Show("取消覆核成功!");
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnVoucher_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData("新增", null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text) || _mode == "新增")
            {
                MessageBox.Show("尚未儲存，無需刪除!");
                return;
            }
            if (MessageBox.Show("確定刪除此筆紀錄?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new GeneralExpensesController().DeleteGeneralExpenses(txtNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnClose_Click(sender, e);
        }

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
            }
            Dispose();
        }
    }
}
