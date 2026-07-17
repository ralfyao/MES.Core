using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    // ── 收支項目設定：整批維護，列表資料有異動執行UPDATE，新增資料執行INSERT ──────
    public partial class FrmInOutComeSetting : Form
    {
        public FrmInOutComeSetting()
        {
            InitializeComponent();
            initPayTypeCombo();
            initAccountCodeCombo();
            LoadList();
        }

        private void initPayTypeCombo()
        {
            colPayType.Items.Clear();
            colPayType.Items.Add("");
            colPayType.Items.Add("應收");
            colPayType.Items.Add("應付");
        }

        private void initAccountCodeCombo()
        {
            var rep = new VoucherController().GetAccountingSubjectList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var codes = (rep.resultList ?? new List<F會計科目>()).Select(x => x.會科代碼).ToList();
            colAccountCode.Items.Clear();
            colAccountCode.Items.Add("");
            foreach (var code in codes) colAccountCode.Items.Add(code);
        }

        private void LoadList()
        {
            var rep = new ARController().GetItemNumberList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<F收支項目設定>());
        }

        private void FillGrid(List<F收支項目設定> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                // 收付別為 nchar(10)，資料庫會補空白到定長，需先 Trim 再比對/指派，避免產生視覺上重複的選項
                string payType = (x.收付別 ?? "").Trim();
                if (!string.IsNullOrEmpty(payType) && !colPayType.Items.Contains(payType))
                {
                    colPayType.Items.Add(payType);
                }
                string accountCode = (x.會科代碼 ?? "").Trim();
                if (!string.IsNullOrEmpty(accountCode) && !colAccountCode.Items.Contains(accountCode))
                {
                    colAccountCode.Items.Add(accountCode);
                }

                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別;
                row.Cells[colItemNo.Index].Value = x.項目編號;
                row.Cells[colItemName.Index].Value = x.項目名稱;
                row.Cells[colPayType.Index].Value = payType;
                row.Cells[colAccountCode.Index].Value = accountCode;
                row.Cells[colDesc.Index].Value = x.說明;
            }
        }

        // ── 儲存：逐列比對，識別有值執行UPDATE，識別為空執行INSERT ────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = new List<F收支項目設定>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string itemNo = row.Cells[colItemNo.Index].Value?.ToString();
                string itemName = row.Cells[colItemName.Index].Value?.ToString();
                if (string.IsNullOrEmpty(itemNo) && string.IsNullOrEmpty(itemName)) continue;

                int? id = int.TryParse(row.Cells[colId.Index].Value?.ToString(), out var idVal) ? idVal : (int?)null;
                list.Add(new F收支項目設定
                {
                    識別 = id,
                    項目編號 = itemNo,
                    項目名稱 = itemName,
                    收付別 = row.Cells[colPayType.Index].Value?.ToString()?.Trim(),
                    會科代碼 = row.Cells[colAccountCode.Index].Value?.ToString()?.Trim(),
                    說明 = row.Cells[colDesc.Index].Value?.ToString(),
                });
            }

            if (list.Count == 0) return;

            var rep = new ARController().SaveItemNumberList(list);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
            LoadList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        // ── 防呆：避免下拉欄位值不在選項清單內時跳出預設錯誤對話方塊 ─────────────
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
