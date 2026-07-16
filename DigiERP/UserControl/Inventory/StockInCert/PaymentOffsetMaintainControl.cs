using DigiERP.Common;
using DigiERP.Models;
using DigiERP.UserControl.Inventory.StockIn;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class PaymentOffsetMaintainControl : CommonUserControl
    {
        // 此畫面（付款沖帳單）為新建立功能，尚未註冊於既有列表，需在權限管理畫面另行設定「編修」權限
        private static string id = "C4F8A26D-7B3E-4A19-9C6D-8F2E5A7C1B93";

        internal event EventHandler Saved;

        private string _mode = "新增";
        private F沖款付 _form;
        private List<F銀行設定> _bankList = new List<F銀行設定>();

        public PaymentOffsetMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        // ── 進入點：由「進項憑證登載」單筆結案後，或列表頁呼叫，mode="新增" 或 "修改" ──
        internal void LoadData(string mode, string no)
        {
            _mode = mode;
            initCurrencyCombo();
            initBankCombo();

            if (_mode == "修改")
            {
                var rep = new StockInController().GetFundOffsetByNo(no);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                _form = rep.result ?? new F沖款付 { 單號 = no };
                PopulateForm(_form);
                disableControls(false);

                bool verified = !string.IsNullOrEmpty(_form.核准);
                btnVerify.Visible = !verified;
                btnCancelVerify.Visible = verified;
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
            else
            {
                _form = new F沖款付 { detailList = new List<F收支沖帳明細>() };
                dtDate.Value = DateTime.Now;
                txtCreator.Text = AppSession.User?.username;
                txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dataGridView1.Rows.Clear();
                RecalcSums();
                disableControls(true);

                btnModify.Visible = false;
                btnDelete.Visible = false;
                btnVerify.Visible = false;
                btnCancelVerify.Visible = false;
            }
        }

        private void PopulateForm(F沖款付 form)
        {
            dtDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtNo.Text = form.單號;
            cboCurrency.Text = form.幣別;
            txtExRate.Text = form.匯率?.ToString();
            txtSupplierNo.Text = form.廠商編號;
            SyncSupplierName();
            txtVoucher.Text = form.傳票;
            txtRemark.Text = form.備註;
            txtCashAmt.Text = form.付現金額?.ToString();
            txtFee.Text = form.匯費?.ToString();
            txtBankAmt.Text = form.銀轉金額?.ToString();
            SelectComboItem(cboBankCode, (F銀行設定 x) => x.銀存編碼, form.銀存編碼);
            txtCheckAmt.Text = form.付票金額?.ToString();
            txtCheckNo.Text = form.票據號碼;
            txtPayTotal.Text = form.付款總額;
            txtReviewer.Text = form.核准;
            txtReviewDate.Text = form.核准日;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtCreator.Text = form.建檔;
            txtCreateDate.Text = form.建檔日;
            FillGrid(form.detailList ?? new List<F收支沖帳明細>());
        }

        private void FillGrid(List<F收支沖帳明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colSource.Index].Value = item.帳款來源;
                row.Cells[colAccDate.Index].Value = item.帳款日期;
                row.Cells[colNature.Index].Value = item.收款性質;
                row.Cells[colOffsetCode.Index].Value = item.沖帳碼;
                row.Cells[colOrigUntaxed.Index].Value = item.原幣未稅;
                row.Cells[colTwdUntaxed.Index].Value = item.台幣未稅;
                row.Cells[colTax.Index].Value = item.稅;
                row.Cells[colAmount.Index].Value = item.金額;
                row.Cells[colOrigOffsetAmt.Index].Value = item.原幣沖帳金額;
                row.Cells[colTwdOffsetAmt.Index].Value = item.台幣沖帳金額;
                row.Cells[colAllowance.Index].Value = item.折讓金額;
                row.Cells[colExDiff.Index].Value = item.匯差;
                row.Cells[colRemark.Index].Value = item.備註;
            }
            RecalcSums();
        }

        private void initCurrencyCombo()
        {
            var rep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboCurrency.Items.Clear();
            foreach (var c in rep.resultList ?? new List<F幣別>())
            {
                cboCurrency.Items.Add(c.CURRENCY);
            }
        }

        private void initBankCombo()
        {
            var rep = new CustomerController().GetBankList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _bankList = rep.resultList ?? new List<F銀行設定>();
            cboBankCode.DataSource = null;
            cboBankCode.DataSource = _bankList;
            cboBankCode.DisplayMember = "銀存編碼";
        }

        private void SyncSupplierName()
        {
            if (string.IsNullOrEmpty(txtSupplierNo.Text)) { txtSupplierName.Text = ""; return; }
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            var supplier = (rep.resultList ?? new List<B廠商設定>())
                .FirstOrDefault(x => (x.廠商編號 ?? "").Trim() == txtSupplierNo.Text.Trim());
            txtSupplierName.Text = supplier?.廠商名稱 ?? "";
        }

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

        private void disableControls(bool enable)
        {
            cboCurrency.Enabled = enable;
            txtExRate.Enabled = enable;
            txtVoucher.Enabled = enable;
            txtRemark.Enabled = enable;
            txtCashAmt.Enabled = enable;
            txtFee.Enabled = enable;
            txtBankAmt.Enabled = enable;
            cboBankCode.Enabled = enable;
            txtCheckAmt.Enabled = enable;
            txtCheckNo.Enabled = enable;
            dataGridView1.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currency = cboCurrency.Text?.Trim();
            if (string.IsNullOrEmpty(currency)) return;
            var rep = new CustomerController().GetExRateList(currency);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            txtExRate.Text = rep.resultList?.FirstOrDefault()?.匯率 ?? "0";
        }

        // ── 明細列沖帳/匯差/折讓金額異動：重算表頭合計 ────────────────────────
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == colOrigOffsetAmt.Index || e.ColumnIndex == colTwdOffsetAmt.Index
                || e.ColumnIndex == colAllowance.Index || e.ColumnIndex == colExDiff.Index)
            {
                RecalcSums();
            }
        }

        private void RecalcSums()
        {
            decimal origUntaxed = 0, twdUntaxed = 0, tax = 0, amount = 0, origOffset = 0, twdOffset = 0, allowance = 0, exDiff = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                origUntaxed += ParseDecimal(row.Cells[colOrigUntaxed.Index].Value);
                twdUntaxed += ParseDecimal(row.Cells[colTwdUntaxed.Index].Value);
                tax += ParseDecimal(row.Cells[colTax.Index].Value);
                amount += ParseDecimal(row.Cells[colAmount.Index].Value);
                origOffset += ParseDecimal(row.Cells[colOrigOffsetAmt.Index].Value);
                twdOffset += ParseDecimal(row.Cells[colTwdOffsetAmt.Index].Value);
                allowance += ParseDecimal(row.Cells[colAllowance.Index].Value);
                exDiff += ParseDecimal(row.Cells[colExDiff.Index].Value);
            }
            txtSumOrigUntaxed.Text = origUntaxed.ToString();
            txtSumTwdUntaxed.Text = twdUntaxed.ToString();
            txtSumTax.Text = tax.ToString();
            txtSumAmount.Text = amount.ToString();
            txtSumOrigOffsetAmt.Text = origOffset.ToString();
            txtSumTwdOffsetAmt.Text = twdOffset.ToString();
            txtSumAllowance.Text = allowance.ToString();
            txtSumExDiff.Text = exDiff.ToString();

            txtOrigOffset.Text = origOffset.ToString();
            txtTwdOffset.Text = twdOffset.ToString();
            txtAllowance.Text = allowance.ToString();
            txtExDiff.Text = exDiff.ToString();
        }

        private static decimal ParseDecimal(object v) => decimal.TryParse(v?.ToString(), out var d) ? d : 0;

        // ── 付現/銀轉/付票金額異動：重算付款總額 ─────────────────────────────
        private void RecalcPayTotal()
        {
            decimal.TryParse(txtCashAmt.Text, out var cash);
            decimal.TryParse(txtBankAmt.Text, out var bank);
            decimal.TryParse(txtCheckAmt.Text, out var check);
            txtPayTotal.Text = (cash + bank + check).ToString();
        }

        private void txtCashAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();
        private void txtBankAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();
        private void txtCheckAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();

        private F沖款付 CollectFormData()
        {
            var form = _form ?? new F沖款付();
            form.單號 = txtNo.Text;
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.廠商編號 = txtSupplierNo.Text?.Trim();
            form.幣別 = cboCurrency.Text;
            decimal.TryParse(txtExRate.Text, out var exRate);
            form.匯率 = exRate;
            form.傳票 = txtVoucher.Text;
            form.備註 = txtRemark.Text;
            decimal.TryParse(txtCashAmt.Text, out var cashAmt);
            form.付現金額 = cashAmt;
            decimal.TryParse(txtFee.Text, out var fee);
            form.匯費 = fee;
            decimal.TryParse(txtBankAmt.Text, out var bankAmt);
            form.銀轉金額 = bankAmt;
            form.銀存編碼 = (cboBankCode.SelectedItem as F銀行設定)?.銀存編碼?.Trim();
            decimal.TryParse(txtCheckAmt.Text, out var checkAmt);
            form.付票金額 = checkAmt;
            form.票據號碼 = txtCheckNo.Text;
            form.付款總額 = txtPayTotal.Text;

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

            form.detailList = new List<F收支沖帳明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string source = row.Cells[colSource.Index].Value?.ToString();
                string offsetCode = row.Cells[colOffsetCode.Index].Value?.ToString();
                if (string.IsNullOrEmpty(source) && string.IsNullOrEmpty(offsetCode)) continue;
                form.detailList.Add(new F收支沖帳明細
                {
                    單號 = form.單號,
                    帳款來源 = source,
                    收款性質 = row.Cells[colNature.Index].Value?.ToString(),
                    帳款日期 = row.Cells[colAccDate.Index].Value?.ToString(),
                    沖帳碼 = offsetCode,
                    原幣未稅 = ParseDecimal(row.Cells[colOrigUntaxed.Index].Value),
                    台幣未稅 = ParseDecimal(row.Cells[colTwdUntaxed.Index].Value),
                    稅 = ParseDecimal(row.Cells[colTax.Index].Value),
                    金額 = ParseDecimal(row.Cells[colAmount.Index].Value),
                    原幣沖帳金額 = ParseDecimal(row.Cells[colOrigOffsetAmt.Index].Value),
                    台幣沖帳金額 = ParseDecimal(row.Cells[colTwdOffsetAmt.Index].Value),
                    折讓金額 = ParseDecimal(row.Cells[colAllowance.Index].Value),
                    匯差 = ParseDecimal(row.Cells[colExDiff.Index].Value),
                    備註 = row.Cells[colRemark.Index].Value?.ToString()
                });
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var form = CollectFormData();
            if (MessageBox.Show($"確定{_mode}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            var rep = _mode == "新增"
                ? new StockInController().SaveFundOffset(form)
                : new StockInController().UpdateFundOffset(form);
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
            var rep = new StockInController().ValidateFundOffset(txtNo.Text, true, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = AppSession.User?.username;
            txtReviewDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btnVerify.Visible = false;
            btnCancelVerify.Visible = true;
            MessageBox.Show("覆核成功!");
        }

        private void btnCancelVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text)) return;
            if (MessageBox.Show("確定取消覆核?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new StockInController().ValidateFundOffset(txtNo.Text, false, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtReviewer.Text = "";
            txtReviewDate.Text = "";
            btnVerify.Visible = true;
            btnCancelVerify.Visible = false;
            MessageBox.Show("取消覆核成功!");
        }

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
            var rep = new StockInController().DeleteFundOffset(txtNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnClose_Click(sender, e);
        }

        // ── 會計傳票：依畫面上的傳票編號查詢並顯示既有會計傳票資料 ─────────────
        private void btnVoucherEntry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucher.Text))
            {
                MessageBox.Show("尚無傳票編號!");
                return;
            }
            using var frm = new FrmVoucher();
            frm.LoadExisting(txtVoucher.Text);
            frm.ShowDialog(this);
        }
        private void btnImportDetail_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnRemit_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnCheck_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
