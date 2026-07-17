using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.Accounting
{
    // ── 付票：依票據號碼查詢既有票據異動資料(唯讀顯示，需按修改才能異動)，或以預設值開啟新增 ──
    public partial class FrmBill : Form
    {
        private F票據異動 _form;
        private List<F銀行設定> _bankList = new List<F銀行設定>();

        public FrmBill()
        {
            InitializeComponent();
            initBankCombo();
            disableControls(false);
        }

        // ── 新增模式：帶入呼叫端(收款單/付款單)的預設值，比照巨集 SetValue ──────────
        public void InitNew(DateTime payDate, string payType, string target, decimal amount, string billStatus, string linkNo)
        {
            _form = new F票據異動();
            dtPayDate.Value = payDate;
            txtPayType.Text = payType;
            txtTarget.Text = target;
            txtAmount.Text = amount.ToString();
            txtBillStatus.Text = billStatus;
            txtLinkNo.Text = linkNo;
            txtBillNo.Text = "";
            dtCashDate.Checked = false;
            txtRemark.Text = "";
            cboBankAccount.SelectedIndex = -1;
            txtIssueAccount.Text = "";
            disableControls(false);
            btnModify.Visible = true;
        }

        // ── 修改模式：依票據號碼查詢既有票據異動資料，預設鎖定，需按修改才能異動 ──────
        public void LoadExisting(string billNo)
        {
            var rep = new BillController().GetBillByNo(billNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _form = rep.result;
            if (_form == null)
            {
                MessageBox.Show($"查無票據號碼 {billNo} 的票據異動資料!");
                return;
            }

            dtPayDate.Value = DateTime.TryParse(_form.收付日期, out var d) ? d : DateTime.Now;
            txtPayType.Text = _form.收付別;
            txtTarget.Text = _form.對象;
            SelectComboItem(cboBankAccount, (F銀行設定 x) => x.銀存編碼, _form.兌付帳戶);
            SyncIssueAccount();
            dtCashDate.Checked = !string.IsNullOrEmpty(_form.兌現日期);
            if (dtCashDate.Checked && DateTime.TryParse(_form.兌現日期, out var cd)) dtCashDate.Value = cd;
            txtAmount.Text = _form.金額?.ToString();
            txtBillStatus.Text = _form.票況;
            txtLinkNo.Text = _form.連結單號;
            txtBillNo.Text = _form.票據號碼;
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

        private void cboBankAccount_SelectedIndexChanged(object sender, EventArgs e) => SyncIssueAccount();

        // ── 開票帳號：=DLookUp("帳號","dbo_F銀行設定","銀存編碼='" & 兌付帳戶 & "'") ──
        private void SyncIssueAccount()
        {
            var bank = cboBankAccount.SelectedItem as F銀行設定;
            txtIssueAccount.Text = bank?.帳號 ?? "";
        }

        private void disableControls(bool enable)
        {
            dtPayDate.Enabled = enable;
            txtTarget.Enabled = enable;
            cboBankAccount.Enabled = enable;
            dtCashDate.Enabled = enable;
            txtAmount.Enabled = enable;
            txtBillNo.Enabled = enable;
            txtRemark.Enabled = enable;
            btnConfirm.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e) => disableControls(true);

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBillNo.Text))
            {
                MessageBox.Show("請輸入票據號碼!");
                return;
            }

            var form = _form ?? new F票據異動();
            form.收付日期 = dtPayDate.Value.ToString("yyyy-MM-dd");
            form.收付別 = txtPayType.Text;
            form.對象 = txtTarget.Text;
            form.兌付帳戶 = (cboBankAccount.SelectedItem as F銀行設定)?.銀存編碼;
            form.兌現日期 = dtCashDate.Checked ? dtCashDate.Value.ToString("yyyy-MM-dd") : null;
            form.票況 = txtBillStatus.Text;
            form.票據號碼 = txtBillNo.Text;
            form.連結單號 = txtLinkNo.Text;
            decimal.TryParse(txtAmount.Text, out var amt);
            form.金額 = amt;
            form.備註 = txtRemark.Text;

            bool isNew = form.識別碼 == 0;
            var rep = isNew ? new BillController().SaveBill(form) : new BillController().UpdateBill(form);
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
