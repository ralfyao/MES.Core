using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    // ── 匯入款：依連結單號查詢既有銀行明細(存入)資料(需按修改才能異動)，或以預設值開啟新增 ──
    public partial class FrmBankDeposit : Form
    {
        private F銀行明細 _form;
        private List<F銀行設定> _bankList = new List<F銀行設定>();

        public FrmBankDeposit()
        {
            InitializeComponent();
            initBankCombo();
            disableControls(false);
        }

        // ── 新增模式：帶入呼叫端(收款沖帳單)的預設值，比照巨集 SetValue ────────────
        public void InitNew(DateTime date, string target, decimal deposit, string summary, string linkNo, string currency)
        {
            _form = new F銀行明細();
            dtDate.Value = date;
            txtTarget.Text = target;
            txtDeposit.Text = deposit.ToString();
            txtSummary.Text = summary;
            txtLinkNo.Text = linkNo;
            txtCurrency.Text = currency;
            txtRemark.Text = "";
            cboBankAccount.SelectedIndex = -1;
            txtBankAccountNo.Text = "";
            disableControls(false);
            btnModify.Visible = true;
        }

        // ── 修改模式：依連結單號查詢既有銀行明細資料，預設鎖定，需按修改才能異動 ──────
        public void LoadExisting(string linkNo)
        {
            var rep = new BankLedgerController().GetBankLedgerByLinkNo(linkNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _form = rep.result;
            if (_form == null)
            {
                MessageBox.Show($"查無連結單號 {linkNo} 的匯入款資料!");
                return;
            }

            dtDate.Value = DateTime.TryParse(_form.日期, out var d) ? d : DateTime.Now;
            txtTarget.Text = _form.對象;
            SelectComboItem(cboBankAccount, (F銀行設定 x) => x.銀存編碼, _form.銀存編碼);
            SyncBankAccountNo();
            txtSummary.Text = _form.摘要;
            txtCurrency.Text = _form.幣別;
            txtLinkNo.Text = _form.連結單號;
            txtDeposit.Text = _form.存入.ToString();
            txtRemark.Text = _form.備註;

            disableControls(false);
            btnModify.Visible = true;
        }

        private void initBankCombo()
        {
            var rep = new CustomerController().GetBankList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            _bankList = rep.resultList ?? new List<F銀行設定>();
            cboBankAccount.DataSource = null;
            cboBankAccount.DataSource = _bankList;
            cboBankAccount.DisplayMember = "銀存編碼";
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

        private void cboBankAccount_SelectedIndexChanged(object sender, EventArgs e) => SyncBankAccountNo();

        // ── 匯入帳號：=DLookUp("帳號","F銀行設定","銀存編碼='" & 兌收帳戶 & "'") ──────
        private void SyncBankAccountNo()
        {
            var bank = cboBankAccount.SelectedItem as F銀行設定;
            txtBankAccountNo.Text = bank?.帳號 ?? "";
        }

        private void disableControls(bool enable)
        {
            dtDate.Enabled = enable;
            txtTarget.Enabled = enable;
            cboBankAccount.Enabled = enable;
            txtSummary.Enabled = enable;
            txtCurrency.Enabled = enable;
            txtDeposit.Enabled = enable;
            txtRemark.Enabled = enable;
            btnConfirm.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e) => disableControls(true);

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinkNo.Text))
            {
                MessageBox.Show("請輸入連結單號!");
                return;
            }

            var form = _form ?? new F銀行明細();
            form.日期 = dtDate.Value.ToString("yyyy-MM-dd");
            form.對象 = txtTarget.Text;
            form.銀存編碼 = (cboBankAccount.SelectedItem as F銀行設定)?.銀存編碼?.Trim();
            form.摘要 = txtSummary.Text;
            form.幣別 = txtCurrency.Text;
            form.連結單號 = txtLinkNo.Text;
            decimal.TryParse(txtDeposit.Text, out var deposit);
            form.存入 = deposit;
            form.支出 = 0;
            form.匯率 = 1;
            form.備註 = txtRemark.Text;

            bool isNew = form.識別碼 == 0;
            var rep = isNew ? new BankLedgerController().SaveBankLedger(form) : new BankLedgerController().UpdateBankLedger(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
