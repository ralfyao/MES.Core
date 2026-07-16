using DigiERP.Common;
using DigiERP.Models;
using DigiERP.UserControl.Supplier.SupplierManage;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class StockInCertMaintainControl : CommonUserControl
    {
        // 沿用 StockInCertControl (進項憑證沖銷總覽) 已註冊的權限 GUID
        private static string id = "8D2A5C41-3F7B-4E9A-B168-6C0D2E5F9A73";

        private static readonly string[] Categories = { "現金", "銀轉", "票據", "電匯" };
        private static readonly string[] CertTypes = { "發票", "收據", "其他" };

        internal event EventHandler Saved;

        private string _mode = "新增";
        private F付款 _form;
        private List<F銀行設定> _bankList = new List<F銀行設定>();

        public StockInCertMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            cboCategory.Items.AddRange(Categories);
            cboCertType.Items.AddRange(CertTypes);
        }

        // ── 進入點：由列表頁呼叫，mode="新增" 或 "修改" ─────────────────────
        internal void LoadData(string mode, string no)
        {
            _mode = mode;
            //initBankCombo();
            initCurrencyCombo();

            if (_mode == "修改")
            {
                var rep = new StockInController().GetIncomeCertRegByNo(no);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                _form = rep.result ?? new F付款 { 單號 = no };
                PopulateForm(_form);
                disableControls(false);

                bool verified = !string.IsNullOrEmpty(_form.核准);
                btnVerify.Visible = !verified;
                btnCancelVerify.Visible = verified;
                btnPrint.Visible = verified;
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
            else
            {
                _form = new F付款 { detailList = new List<F付款明細>() };
                var noRep = new StockInController().GetIncomeCertRegNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                    return;
                }
                txtNo.Text = noRep.result;
                dtDate.Value = DateTime.Now;
                dtPayDate.Value = DateTime.Now;
                txtCreator.Text = AppSession.User?.username;
                txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dataGridView1.Rows.Clear();
                RecalcDetailTotal();
                disableControls(true);

                btnModify.Visible = false;
                btnDelete.Visible = false;
                btnVerify.Visible = false;
                btnCancelVerify.Visible = false;
                btnPrint.Visible = false;
            }
        }

        private void PopulateForm(F付款 form)
        {
            dtDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtNo.Text = form.單號;
            cboCategory.Text = form.類別;
            cboCertType.Text = form.MACHINENO;
            dtPayDate.Value = DateTime.TryParse(form.付款日期, out var pd) ? pd : DateTime.Now;
            txtSupplierNo.Text = form.廠商編號;
            SyncSupplierName();
            txtInvoiceNo.Text = form.發票號碼;
            //SelectComboItem(cboBankCode, (F銀行設定 x) => x.銀存編碼, form.銀存編碼);
            txtVoucher.Text = form.傳票;
            cboCurrency.Text = form.幣別;
            txtExRate.Text = form.匯率?.ToString();
            txtRequester.Text = form.請款人員;
            //txtCheckNo.Text = form.票據號碼;
            //txtCashAmt.Text = form.付現金額?.ToString();
            txtBankAmt.Text = form.銀轉金額?.ToString();
            //txtFee.Text = form.匯費?.ToString();
            txtCheckAmt.Text = form.付票金額?.ToString();
            txtPayTotal.Text = form.付款總額;
            chkClosed.Checked = form.結案 ?? false;
            txtRemark.Text = form.備註;
            txtReviewer.Text = form.核准;
            txtReviewDate.Text = form.核准日;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtCreator.Text = form.建檔;
            txtCreateDate.Text = form.建檔日;
            FillGrid(form.detailList ?? new List<F付款明細>());
        }

        private void FillGrid(List<F付款明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colSource.Index].Value = item.帳款來源;
                row.Cells[colOffsetCode.Index].Value = item.沖帳碼;
                row.Cells[colOrigAmt.Index].Value = item.原幣收帳金額;
                row.Cells[colTwdAmt.Index].Value = item.台幣換算金額;
                row.Cells[colProject.Index].Value = item.專案序號;
                row.Cells[colDesc.Index].Value = item.說明;
            }
            RecalcDetailTotal();
        }

        //private void initBankCombo()
        //{
        //    var rep = new CustomerController().GetBankList();
        //    if (!string.IsNullOrEmpty(rep.ErrorMessage))
        //    {
        //        MessageBox.Show(rep.ErrorMessage);
        //        return;
        //    }
        //    _bankList = rep.resultList ?? new List<F銀行設定>();
        //    //cboBankCode.DataSource = null;
        //    //cboBankCode.DataSource = _bankList;
        //    //cboBankCode.DisplayMember = "銀存編碼";
        //}

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

        // ── 依 Trim 後之鍵值比對選取項目 ─────────────────────────────────
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
            cboCategory.Enabled = enable;
            cboCertType.Enabled = enable;
            dtPayDate.Enabled = enable;
            btnSelectSupplier.Enabled = enable;
            txtInvoiceNo.Enabled = enable;
            //cboBankCode.Enabled = enable;
            cboCurrency.Enabled = enable;
            txtExRate.Enabled = enable;
            txtRequester.Enabled = enable;
            //txtCheckNo.Enabled = enable;
            //txtCashAmt.Enabled = enable;
            txtBankAmt.Enabled = enable;
            //txtFee.Enabled = enable;
            txtCheckAmt.Enabled = enable;
            chkClosed.Enabled = enable;
            txtRemark.Enabled = enable;
            dataGridView1.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        // ── 點選放大鏡：跳出廠商選取視窗 ─────────────────────────────────
        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectSupplier();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;
            txtSupplierNo.Text = frm.Selected.廠商編號;
            txtSupplierName.Text = frm.Selected.廠商名稱;
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

        // ── 幣別變更：帶出最近一筆匯率 ───────────────────────────────────
        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currency = cboCurrency.Text?.Trim();
            if (string.IsNullOrEmpty(currency)) return;
            var rep = new CustomerController().GetExRateList(currency);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            txtExRate.Text = rep.resultList?.FirstOrDefault()?.匯率 ?? "0";
        }

        // ── 明細列原幣收帳金額異動：依匯率帶出台幣換算金額，並重算合計 ───────────
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colOrigAmt.Index) return;
            var row = dataGridView1.Rows[e.RowIndex];
            decimal.TryParse(row.Cells[colOrigAmt.Index].Value?.ToString(), out var origAmt);
            decimal.TryParse(txtExRate.Text, out var exRate);
            if (exRate <= 0) exRate = 1;
            row.Cells[colTwdAmt.Index].Value = Math.Round(origAmt * exRate, 0);
            RecalcDetailTotal();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colTwdAmt.Index) return;
            RecalcDetailTotal();
        }

        private void RecalcDetailTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                decimal.TryParse(row.Cells[colTwdAmt.Index].Value?.ToString(), out var amt);
                total += amt;
            }
            txtDetailTotal.Text = total.ToString();
        }

        // ── 付現/銀轉/付票金額異動：重算付款總額 ─────────────────────────────
        private void RecalcPayTotal()
        {
            //decimal.TryParse(txtCashAmt.Text, out var cash);
            decimal.TryParse(txtBankAmt.Text, out var bank);
            decimal.TryParse(txtCheckAmt.Text, out var check);
            //txtPayTotal.Text = (cash + bank + check).ToString();
        }

        private void txtCashAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();
        private void txtBankAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();
        private void txtCheckAmt_Leave(object sender, EventArgs e) => RecalcPayTotal();

        private F付款 CollectFormData()
        {
            var form = _form ?? new F付款();
            form.單號 = txtNo.Text;
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.廠商編號 = txtSupplierNo.Text?.Trim();
            form.類別 = cboCategory.Text;
            form.MACHINENO = cboCertType.Text;
            form.付款日期 = dtPayDate.Value.ToString("yyyy-MM-dd");
            form.發票號碼 = txtInvoiceNo.Text;
            //form.銀存編碼 = (cboBankCode.SelectedItem as F銀行設定)?.銀存編碼?.Trim();
            form.傳票 = txtVoucher.Text;
            form.幣別 = cboCurrency.Text;
            decimal.TryParse(txtExRate.Text, out var exRate);
            form.匯率 = exRate;
            form.請款人員 = txtRequester.Text;
            //form.票據號碼 = txtCheckNo.Text;
            //decimal.TryParse(txtCashAmt.Text, out var cashAmt);
            //form.付現金額 = cashAmt;
            decimal.TryParse(txtBankAmt.Text, out var bankAmt);
            form.銀轉金額 = bankAmt;
            //decimal.TryParse(txtFee.Text, out var fee);
            //form.匯費 = fee;
            decimal.TryParse(txtCheckAmt.Text, out var checkAmt);
            form.付票金額 = checkAmt;
            form.付款總額 = txtPayTotal.Text;
            form.結案 = chkClosed.Checked;
            form.備註 = txtRemark.Text;

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

            form.detailList = new List<F付款明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string source = row.Cells[colSource.Index].Value?.ToString();
                string offsetCode = row.Cells[colOffsetCode.Index].Value?.ToString();
                if (string.IsNullOrEmpty(source) && string.IsNullOrEmpty(offsetCode)) continue;
                decimal.TryParse(row.Cells[colOrigAmt.Index].Value?.ToString(), out var origAmt);
                decimal.TryParse(row.Cells[colTwdAmt.Index].Value?.ToString(), out var twdAmt);
                form.detailList.Add(new F付款明細
                {
                    單號 = form.單號,
                    帳款來源 = source,
                    沖帳碼 = offsetCode,
                    原幣收帳金額 = origAmt,
                    台幣換算金額 = twdAmt,
                    說明 = row.Cells[colDesc.Index].Value?.ToString(),
                    專案序號 = row.Cells[colProject.Index].Value?.ToString()
                });
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierNo.Text))
            {
                MessageBox.Show("請選擇廠商編號!");
                return;
            }
            var form = CollectFormData();
            if (MessageBox.Show($"確定{_mode}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            var rep = _mode == "新增"
                ? new StockInController().SaveUpdateIncomeRegNo(form)
                : new StockInController().UpdateIncomeRegForm(form);
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
            var rep = new StockInController().ValidateIncomeRegForm(txtNo.Text, true, AppSession.User?.username);
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
            var rep = new StockInController().ValidateIncomeRegForm(txtNo.Text, false, AppSession.User?.username);
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
            var rep = new StockInController().DeleteIncomeRegForm(txtNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnClose_Click(sender, e);
        }

        // ── 單筆結案：比照 Access 巨集 — 未覆核不可付款；未結案則執行單筆付款並開啟付款沖帳單，已結案則直接開啟 ──
        private void btnSingleClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReviewDate.Text))
            {
                MessageBox.Show("本單尚未經覆核，暫無法付款!", "系統操作防呆", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var existingRep = new StockInController().GetFundOffsetNoBySource(txtNo.Text);
            if (!string.IsNullOrEmpty(existingRep.ErrorMessage))
            {
                MessageBox.Show(existingRep.ErrorMessage);
                return;
            }

            if (string.IsNullOrEmpty(existingRep.result))
            {
                if (!chkEditPrivilege(id))
                {
                    MessageBox.Show("無編修權限，無法執行單筆付款!");
                    return;
                }
                if (MessageBox.Show("您確定要對此憑證單筆付款?", "請選擇", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    return;

                var rep = new StockInController().DoSingleClose(txtNo.Text, AppSession.User?.username);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                txtRequester.Text = rep.result;
                OpenPaymentOffsetTab(rep.result);
            }
            else
            {
                txtRequester.Text = existingRep.result;
                OpenPaymentOffsetTab(existingRep.result);
            }
        }

        private void OpenPaymentOffsetTab(string no)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = $"PaymentOffsetMaintain_{no}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new PaymentOffsetMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage($"付款沖帳單-{no}") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
            ctrl.LoadData("修改", no);
        }

        // ── 付款明細導入：比照 Access 巨集 — 驗證單號/發票號碼、權限檢查、已覆核禁止增添，依付款類別開啟對應核銷選單 ──
        private void btnImportDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text))
            {
                MessageBox.Show("請輸入日期及單號!", "系統操作管控", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                MessageBox.Show("請輸入發票、收據或憑證編號!", "系統操作管控", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非經授權，不得進入!", "權限管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtReviewDate.Text))
            {
                MessageBox.Show("此單已經覆核，請勿增添項目!", "系統操作防呆", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<F付款明細> imported;
            switch (cboCategory.Text)
            {
                case "進貨驗收":
                    using (var frm1 = new FrmStockInCertImport(txtSupplierNo.Text))
                    {
                        if (frm1.ShowDialog(this) != DialogResult.OK) return;
                        imported = frm1.ImportedItems;
                    }
                    break;
                case "委外加工":
                case "總務支出":
                    using (var frm2 = new FrmExpenseCertImport(txtSupplierNo.Text))
                    {
                        if (frm2.ShowDialog(this) != DialogResult.OK) return;
                        imported = frm2.ImportedItems;
                    }
                    break;
                case "採購預付":
                    using (var frm3 = new FrmPrepaymentSelect(txtSupplierNo.Text))
                    {
                        if (frm3.ShowDialog(this) != DialogResult.OK) return;
                        imported = frm3.ImportedItems;
                    }
                    break;
                default:
                    MessageBox.Show("請先選擇付款類別!");
                    return;
            }

            decimal.TryParse(txtExRate.Text, out var exRate);
            if (exRate <= 0) exRate = 1;
            foreach (var item in imported)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colSource.Index].Value = item.帳款來源;
                row.Cells[colOffsetCode.Index].Value = item.沖帳碼;
                row.Cells[colOrigAmt.Index].Value = item.原幣收帳金額;
                row.Cells[colTwdAmt.Index].Value = Math.Round((item.原幣收帳金額 ?? 0) * exRate, 0);
                row.Cells[colDesc.Index].Value = item.說明;
            }
            RecalcDetailTotal();
        }

        // ── 出納付款：於頁籤中開啟付款沖帳總覽 ───────────────────────────────
        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "PaymentOffsetOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new PaymentOffsetOverviewControl();
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("付款沖帳總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        private void btnVoucherEntry_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
