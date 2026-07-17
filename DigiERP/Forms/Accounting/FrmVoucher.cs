using DigiERP.Forms;
using DigiERP.Models;
using DigiERP.UserControl.Accounting;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    // ── 會計傳票：目前僅實作「新增」流程（含借貸平衡檢查），其餘按鈕保留但尚未開放 ──
    public partial class FrmVoucher : CommonForm
    {
        private string _sourceDoc;
        private static string _moduleId = "F8ABF0C1-57B9-45C6-B745-827D055DF413";

        // ── 開啟本視窗的來源控制項；查詢按鈕需要它才能反查所屬TabControl並開新頁籤 ──
        public Control CallerControl { get; set; }

        // ── 若以獨立視窗開啟(如選單「傳票作業」)，沒有 CallerControl 可反查，改由呼叫端直接指定 ──
        public TabControl HostTabControl { get; set; }

        // ── 需保留真正零參數建構子，供選單機制以 Activator.CreateInstance(type) 動態建立 ──
        public FrmVoucher() : this(null) { }

        public FrmVoucher(string sourceDoc)
        {
            if (!chkPrivilege(_moduleId))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                Close();
                return;
            }
            InitializeComponent();
            _sourceDoc = sourceDoc;
            InitNewVoucher();
        }

        // ── 依傳票單號查詢並帶出既有會計傳票資料（唯讀顯示現有資料，找不到才提示） ──
        public void LoadExisting(string voucherNo)
        {
            var rep = new VoucherController().GetVoucherByNo(voucherNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var form = rep.result;
            if (form == null)
            {
                MessageBox.Show($"查無傳票單號 {voucherNo} 的會計傳票資料!");
                return;
            }

            txtVoucherNo.Text = form.單號;
            dtDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtStatus.Text = form.狀態;
            txtRegistrar.Text = form.登錄人員;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtPost.Text = form.過帳;
            txtPostDate.Text = form.過帳日;
            chkMonthClose.Checked = form.月結 == "Y";

            dgvDetail.Rows.Clear();
            foreach (var item in form.voucherList ?? new List<F會計傳票明細>())
            {
                int idx = dgvDetail.Rows.Add();
                var row = dgvDetail.Rows[idx];
                row.Cells[colAccountCode.Index].Value = item.會科代碼;
                row.Cells[colAccountName.Index].Value = item.會計科目;
                row.Cells[colSummary.Index].Value = item.摘要;
                row.Cells[colDebit.Index].Value = item.借方;
                row.Cells[colCredit.Index].Value = item.貸方;
                row.Cells[colSourceDoc.Index].Value = item.來源單據;
                row.Cells[colNote.Index].Value = item.備註;
            }
            RecalcTotals();

            // ── 查詢帶出的既有傳票預設鎖定，需按下修改才能異動 ──────────────────
            disableControls(false);
        }

        // ── 鎖定/解鎖傳票內容：新增時預設可編輯，查詢帶出的既有傳票需按修改才能異動 ──
        private void disableControls(bool enable)
        {
            dtDate.Enabled = enable;
            dgvDetail.Enabled = enable;
            btnImportAccount.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void InitNewVoucher()
        {
            var noRep = new VoucherController().GetVoucherNo();
            if (!string.IsNullOrEmpty(noRep.ErrorMessage))
            {
                MessageBox.Show(noRep.ErrorMessage);
                return;
            }
            txtVoucherNo.Text = noRep.result;
            dtDate.Value = DateTime.Now;
            txtStatus.Text = "登錄";
            txtRegistrar.Text = AppSession.User?.username ?? "";
            txtModifier.Text = "";
            txtModifyDate.Text = "";
            txtPost.Text = "";
            txtPostDate.Text = "";
            chkMonthClose.Checked = false;

            dgvDetail.Rows.Clear();
            if (!string.IsNullOrEmpty(_sourceDoc))
            {
                int idx = dgvDetail.Rows.Add();
                dgvDetail.Rows[idx].Cells[colSourceDoc.Index].Value = _sourceDoc;
            }
            RecalcTotals();

            // ── 新增的傳票預設可直接編輯 ─────────────────────────────────────
            disableControls(true);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            InitNewVoucher();
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e) => RecalcTotals();
        private void dgvDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => RecalcTotals();

        private void RecalcTotals()
        {
            decimal debit = 0, credit = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.IsNewRow) continue;
                debit += ToDecimal(row.Cells[colDebit.Index].Value);
                credit += ToDecimal(row.Cells[colCredit.Index].Value);
            }
            txtTotalDebit.Text = debit.ToString("0.##");
            txtTotalCredit.Text = credit.ToString("0.##");
        }

        private static decimal ToDecimal(object v) => decimal.TryParse(v?.ToString(), out var d) ? d : 0;

        private List<F會計傳票明細> CollectDetailGrid()
        {
            var list = new List<F會計傳票明細>();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.IsNewRow) continue;
                string code = row.Cells[colAccountCode.Index].Value?.ToString();
                if (string.IsNullOrEmpty(code)) continue;
                list.Add(new F會計傳票明細
                {
                    會科代碼 = code,
                    會計科目 = row.Cells[colAccountName.Index].Value?.ToString(),
                    摘要 = row.Cells[colSummary.Index].Value?.ToString(),
                    借方 = ToDecimal(row.Cells[colDebit.Index].Value),
                    貸方 = ToDecimal(row.Cells[colCredit.Index].Value),
                    來源單據 = row.Cells[colSourceDoc.Index].Value?.ToString(),
                    備註 = row.Cells[colNote.Index].Value?.ToString(),
                });
            }
            return list;
        }

        // ── 儲存：先檢查明細借貸是否平衡，平衡才寫入 ─────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            var details = CollectDetailGrid();
            if (details.Count == 0)
            {
                MessageBox.Show("請至少輸入一筆傳票明細");
                return;
            }

            decimal totalDebit = details.Sum(x => x.借方);
            decimal totalCredit = details.Sum(x => x.貸方);
            if (totalDebit != totalCredit)
            {
                MessageBox.Show($"借貸不平衡，無法儲存!\n借方合計：{totalDebit}\n貸方合計：{totalCredit}");
                return;
            }

            var form = new F會計傳票
            {
                單號 = txtVoucherNo.Text,
                日期 = dtDate.Value.ToString("yyyy-MM-dd"),
                原始憑證 = _sourceDoc,
                借方 = totalDebit,
                貸方 = totalCredit,
                狀態 = txtStatus.Text,
                登錄人員 = txtRegistrar.Text,
                修改 = null,
                修改日 = null,
                過帳 = string.IsNullOrEmpty(txtPost.Text) ? null : txtPost.Text,
                過帳日 = string.IsNullOrEmpty(txtPostDate.Text) ? null : txtPostDate.Text,
                月結 = chkMonthClose.Checked ? "Y" : null,
                voucherList = details,
            };

            var rep = new VoucherController().CreateVoucher(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
        }

        // ── 過帳：已過帳提醒重複操作；未過帳則檢查借貸平衡後過帳，並鎖定畫面 ─────
        private void btnPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucherNo.Text))
            {
                MessageBox.Show("尚未儲存，無法過帳!");
                return;
            }
            if (txtStatus.Text == "過帳")
            {
                MessageBox.Show("本張傳票已過帳，請注意你的作業專注度!", "系統操作防呆", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtPost.Text))
            {
                MessageBox.Show("已經過帳,您按錯囉!", "提醒您集中精神", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RecalcTotals();
            if (txtTotalDebit.Text != txtTotalCredit.Text)
            {
                MessageBox.Show("借貸不平衡!", "系統作業異常管控", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = AppSession.User?.username ?? "";
            var rep = new VoucherController().PostVoucher(txtVoucherNo.Text, user);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            txtPost.Text = user;
            txtPostDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtStatus.Text = "過帳";
            dgvDetail.Enabled = false;
            btnSave.Enabled = false;
            MessageBox.Show("過帳成功!");
        }

        // ── 尚未開放的功能 ──────────────────────────────────────────────
        private void btnDeleteRecord_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 修改：已過帳的傳票不得再異動，否則解鎖畫面供編輯 ───────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text == "過帳")
            {
                MessageBox.Show("本張傳票已過帳，無法修改!", "系統操作管控", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            disableControls(true);
        }
        // ── 取消過帳：清除過帳／過帳日，狀態改回「登錄」，並解除鎖定 ─────────────
        private void btnCancelPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucherNo.Text))
            {
                MessageBox.Show("尚未儲存，無法取消過帳!");
                return;
            }
            if (MessageBox.Show("您確定要取消過帳?", "請選擇", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;

            var rep = new VoucherController().CancelPostVoucher(txtVoucherNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            txtPost.Text = "";
            txtPostDate.Text = "";
            txtStatus.Text = "登錄";
            dgvDetail.Enabled = true;
            btnSave.Enabled = true;
            MessageBox.Show("取消過帳成功!");
        }
        // ── 查詢：關閉本傳票視窗，於所屬TabControl開啟(或切換至)會計傳票查詢作業頁籤 ─────
        // 優先使用 HostTabControl（獨立視窗開啟時由呼叫端直接指定），否則退回從 CallerControl 反查
        private void btnQuery_Click(object sender, EventArgs e)
        {
            TabControl tabControl = HostTabControl;
            if (tabControl == null && CallerControl != null
                && CallerControl.Parent is TabPage callerTab && callerTab.Parent is TabControl callerTabControl)
            {
                tabControl = callerTabControl;
            }
            Close();

            if (tabControl == null) return;

            const string tabName = "VoucherQuery";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new VoucherQueryControl { Dock = DockStyle.Fill };
            var tab = new TabPage("會計傳票查詢作業") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        // ── 會科帶入：選取後帶入目前選取列(無則新增一列)，會科代碼／會計科目僅能由此帶入 ──
        private void btnImportAccount_Click(object sender, EventArgs e)
        {
            using var frm = new FrmSelectAccountingSubject();
            if (frm.ShowDialog(this) != DialogResult.OK || frm.Selected == null) return;

            var current = dgvDetail.CurrentRow;
            DataGridViewRow row;
            if (current != null && !current.IsNewRow)
            {
                row = current;
            }
            else
            {
                int idx = dgvDetail.Rows.Add();
                row = dgvDetail.Rows[idx];
            }
            row.Cells[colAccountCode.Index].Value = frm.Selected.會科代碼;
            row.Cells[colAccountName.Index].Value = frm.Selected.會科名稱;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
