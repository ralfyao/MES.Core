using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class CurrencyAdjustMaintainControl : CommonUserControl
    {
        private static string id = "8F1C4A6D-2E9B-4D73-B815-3A6C9F2D7E48";

        internal event EventHandler Saved;

        private string _mode = "新增";
        private F資金調節 _form;
        private List<F會計科目> _subjectList = new List<F會計科目>();
        private List<F銀行設定> _bankList = new List<F銀行設定>();
        private Dictionary<string, string> _bankNameMap = new Dictionary<string, string>();
        private List<F幣別> _currencyList = new List<F幣別>();

        public CurrencyAdjustMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        // ── 進入點：由列表頁呼叫，mode="新增" 或 "修改" ─────────────────────
        internal void LoadData(string mode, string no)
        {
            _mode = mode;
            initPurposeCombo();
            initBankItems();
            initCurrencyItems();

            if (_mode == "修改")
            {
                var rep = new CurrencyAdjustController().GetFundAdjustByNo(no);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                _form = rep.result ?? new F資金調節 { 單號 = no };
                PopulateForm(_form);
                disableControls(true);

                bool verified = !string.IsNullOrEmpty(_form.核准);
                btnVerify.Visible = !verified;
                btnCancelVerify.Visible = verified;
                btnPrint.Visible = verified;
                btnModify.Visible = true;
            }
            else
            {
                _form = new F資金調節 { detailList = new List<F銀行明細>() };
                var noRep = new CurrencyAdjustController().GetFundAdjustNo();
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
            }
        }

        private void PopulateForm(F資金調節 form)
        {
            dtDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtNo.Text = form.單號;
            SelectComboItem(cboPurpose, (F會計科目 x) => x.會科代碼, form.用途);
            var subject = cboPurpose.SelectedItem as F會計科目;
            txtSubjectCode.Text = subject?.會科代碼;
            txtSubjectName.Text = subject?.會科名稱;
            txtVoucherNo.Text = form.傳票編號;
            txtRemark.Text = form.備註;
            txtReviewer.Text = form.核准;
            txtReviewDate.Text = form.核准日;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtCreator.Text = form.建檔;
            txtCreateDate.Text = form.建檔日;
            FillGrid(form.detailList ?? new List<F銀行明細>());
        }

        private void FillGrid(List<F銀行明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colBank.Index].Value = item.銀存編碼;
                _bankNameMap.TryGetValue((item.銀存編碼 ?? "").Trim(), out var bankName);
                row.Cells[colBankName.Index].Value = bankName;
                row.Cells[colDate.Index].Value = item.日期;
                row.Cells[colSummary.Index].Value = item.摘要;
                row.Cells[colDeposit.Index].Value = item.存入;
                row.Cells[colWithdraw.Index].Value = item.支出;
                row.Cells[colCurrency.Index].Value = item.幣別;
                row.Cells[colExRate.Index].Value = item.匯率;
                row.Cells[colDetailRemark.Index].Value = item.備註;
            }
        }

        // ── 用途下拉：帶出 F會計科目 清單，DisplayMember 顯示會科名稱 ───────
        private void initPurposeCombo()
        {
            var rep = new VoucherController().GetAccountingSubjectList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _subjectList = rep.resultList ?? new List<F會計科目>();
            cboPurpose.DataSource = _subjectList;
            cboPurpose.DisplayMember = "會科名稱";
        }

        private void initBankItems()
        {
            var rep = new CustomerController().GetBankList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _bankList = rep.resultList ?? new List<F銀行設定>();
            _bankNameMap = _bankList.Where(x => !string.IsNullOrEmpty(x.銀存編碼))
                .GroupBy(x => x.銀存編碼.Trim())
                .ToDictionary(g => g.Key, g => g.First().銀行名稱);
            colBank.Items.Clear();
            foreach (var b in _bankList)
            {
                colBank.Items.Add(b.銀存編碼);
            }
        }

        private void initCurrencyItems()
        {
            var rep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _currencyList = rep.resultList ?? new List<F幣別>();
            colCurrency.Items.Clear();
            foreach (var c in _currencyList)
            {
                colCurrency.Items.Add(c.CURRENCY);
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
            enable = !enable;
            cboPurpose.Enabled = enable;
            txtVoucherNo.Enabled = enable;
            txtRemark.Enabled = enable;
            dataGridView1.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var form = _form ?? new F資金調節();
            if (string.IsNullOrEmpty(form.核准))
            {
                MessageBox.Show("尚未核准，不允許修改");
                return;
            }
            disableControls(false);
        }

        private void cboPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = cboPurpose.SelectedItem as F會計科目;
            txtSubjectCode.Text = subject?.會科代碼;
            txtSubjectName.Text = subject?.會科名稱;
        }

        // ── 銀存編碼/幣別下拉選定後，即時提交，帶出銀存名稱／最近一筆匯率 ────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int col = dataGridView1.CurrentCell?.ColumnIndex ?? -1;
            if (dataGridView1.IsCurrentCellDirty && (col == colBank.Index || col == colCurrency.Index))
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == colBank.Index)
            {
                string bankCode = row.Cells[colBank.Index].Value?.ToString();
                _bankNameMap.TryGetValue((bankCode ?? "").Trim(), out var bankName);
                row.Cells[colBankName.Index].Value = bankName;
                return;
            }
            if (e.ColumnIndex == colCurrency.Index)
            {
                string currency = row.Cells[colCurrency.Index].Value?.ToString();
                if (string.IsNullOrEmpty(currency)) return;
                var rep = new CustomerController().GetExRateList(currency);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                row.Cells[colExRate.Index].Value = rep.resultList?.FirstOrDefault()?.匯率 ?? "0";
            }
        }

        private F資金調節 CollectFormData()
        {
            var form = _form ?? new F資金調節();
            form.單號 = txtNo.Text;
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.用途 = (cboPurpose.SelectedItem as F會計科目)?.會科代碼?.Trim();
            form.傳票編號 = txtVoucherNo.Text;
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

            form.detailList = new List<F銀行明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string bankCode = row.Cells[colBank.Index].Value?.ToString();
                string dateVal = row.Cells[colDate.Index].Value?.ToString();
                string summary = row.Cells[colSummary.Index].Value?.ToString();
                if (string.IsNullOrEmpty(bankCode) && string.IsNullOrEmpty(dateVal) && string.IsNullOrEmpty(summary)) continue;
                decimal.TryParse(row.Cells[colExRate.Index].Value?.ToString(), out var exRate);
                decimal.TryParse(row.Cells[colDeposit.Index].Value?.ToString(), out var deposit);
                decimal.TryParse(row.Cells[colWithdraw.Index].Value?.ToString(), out var withdraw);
                form.detailList.Add(new F銀行明細
                {
                    銀存編碼 = bankCode?.Trim(),
                    日期 = dateVal,
                    摘要 = summary,
                    幣別 = row.Cells[colCurrency.Index].Value?.ToString(),
                    匯率 = exRate,
                    存入 = deposit,
                    支出 = withdraw,
                    連結單號 = form.單號,
                    備註 = row.Cells[colDetailRemark.Index].Value?.ToString()
                });
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var form = CollectFormData();
            if (!form.detailList.Any())
            {
                MessageBox.Show("請至少輸入一筆明細並選擇銀存編碼!");
                return;
            }
            if (MessageBox.Show($"確定{_mode}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            var rep = _mode == "新增"
                ? new CurrencyAdjustController().SaveFundAdjust(form)
                : new CurrencyAdjustController().UpdateFundAdjust(form);
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
            var rep = new CurrencyAdjustController().ValidateFundAdjust(txtNo.Text, true, AppSession.User?.username);
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
            var rep = new CurrencyAdjustController().ValidateFundAdjust(txtNo.Text, false, AppSession.User?.username);
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
            var rep = new CurrencyAdjustController().DeleteFundAdjust(txtNo.Text);
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
