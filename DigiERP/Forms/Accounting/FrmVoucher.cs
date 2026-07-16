using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    // ── 會計傳票：目前僅實作「新增」流程（含借貸平衡檢查），其餘按鈕保留但尚未開放 ──
    public partial class FrmVoucher : Form
    {
        private string _sourceDoc;

        public FrmVoucher(string sourceDoc = null)
        {
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

        // ── 尚未開放的功能 ──────────────────────────────────────────────
        private void btnDeleteRecord_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnModify_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnPost_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnCancelPost_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnQuery_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
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
