using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    // ── 材料領用清單(M-領料組測清單)：依BOM編號顯示專案模組用料表頭資訊，
    //    明細取自 A材料庫存卡，以 產品編號=BOM編號 比對，僅列出摘要='領料'
    //    的異動紀錄；按「修改」後可新增明細列，產品編號欄位點選後跳出可
    //    領用零件選擇視窗(依此BOM的專案序號+模組編碼篩選市購品/庫存品) ──
    public partial class FrmMaterialRequisitionList : Form
    {
        private readonly string _bomNo;
        private string _projectNo;
        private string _moduleCode;
        private bool _editMode;

        public FrmMaterialRequisitionList(string bomNo)
        {
            InitializeComponent();
            _bomNo = bomNo;
            LoadHeader();
            LoadDetailGrid();
        }

        private void LoadHeader()
        {
            var rep = new ProjectProgressController().GetModuleMaterialByBomNo(_bomNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var header = rep.result;
            _projectNo = header?.專案序號;
            _moduleCode = header?.模組編碼;
            txtProjectNo.Text = header?.專案序號 ?? "";
            txtModuleCode.Text = header?.模組編碼 ?? "";
            txtModuleName.Text = header?.模組名稱 ?? "";
            txtBomNo.Text = header?.BOM編號 ?? "";
        }

        private void LoadDetailGrid()
        {
            var rep = new ItemController().GetMaterialRequisitionListByBomNo(_bomNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _editMode = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<A材料庫存卡>())
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.異動日期;
                row.Cells[i++].Value = x.產品編號;
                row.Cells[i++].Value = "";
                row.Cells[i++].Value = x.摘要;
                row.Cells[i++].Value = "";
                row.Cells[i++].Value = x.來源用途;
                row.Cells[i++].Value = x.單位;
                row.Cells[i++].Value = x.入庫;
                row.Cells[i++].Value = x.出庫;
                row.Cells[i++].Value = x.儲位;
                row.Cells[i++].Value = x.單價;
                row.Cells[i++].Value = x.領用人;
                row.Cells[i++].Value = x.領用長度;
                row.Cells[i++].Value = x.ERP領料單號;
                row.Cells[i++].Value = x.備註;
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].ReadOnly = true;
            }
        }

        // ── 修改：解鎖新增一列領用明細 ────────────────────────────────
        private void btnEdit_Click(object sender, EventArgs e)
        {
            _editMode = true;
            dataGridView1.AllowUserToAddRows = true;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colTxnDate.Index];
            }
        }

        // ── 點選『產品編號』欄位：修改模式下、且為新增列時，跳出可領用零件
        //    選擇視窗，選定後將產品編號帶入儲存格，並依產品編號帶出品名規格；
        //    同時帶出摘要='領料'、管制單號(取自零件清單的零件管制單號)，
        //    領用量(出庫)預設為0；點選『領用人』欄位：跳出未停用帳號選擇
        //    視窗，選定後將姓名帶回領用人 ──────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editMode || e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row.ReadOnly) return;

            if (e.ColumnIndex == colProductNo.Index)
            {
                var rep = new ProjectProgressController().GetPurchasablePartListForBom(_projectNo, _moduleCode);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                using var frm = new FrmSelectPurchasePart(rep.resultList ?? new List<可領用零件清單>());
                if (frm.ShowDialog(this) != DialogResult.OK) return;

                string productNo = frm.SelectedItem.產品編號;
                row.Cells[colProductNo.Index].Value = productNo;
                row.Cells[colSummary.Index].Value = "領料";
                row.Cells[colControlNo.Index].Value = frm.SelectedItem.零件管制單號;
                row.Cells[colStockOut.Index].Value = "0";

                var itemRep = new ItemController().ItemList(productNo);
                row.Cells[colSpec.Index].Value = itemRep.resultList?.FirstOrDefault()?.品名規格 ?? "";
            }
            else if (e.ColumnIndex == colRequester.Index)
            {
                var rep = new UserPrivilegeController().GetActiveAccountList();
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                using var frm = new FrmSelectAccount(rep.resultList ?? new List<account>());
                if (frm.ShowDialog(this) != DialogResult.OK) return;
                row.Cells[colRequester.Index].Value = frm.SelectedItem.姓名;
            }
        }

        // ── 儲存：只寫入新增的那幾列，既有紀錄不動；異動日期/產品編號為必填，
        //    出庫=領用量(即儲存格『出庫』欄位)，摘要固定寫入'領料' ─────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_editMode)
            {
                MessageBox.Show("請先按「修改」才能新增領用紀錄!");
                return;
            }

            var newRows = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && !r.ReadOnly)
                .ToList();

            if (newRows.Count == 0)
            {
                MessageBox.Show("沒有新增的領用資料可以儲存!");
                return;
            }

            foreach (var row in newRows)
            {
                string txnDate = row.Cells[colTxnDate.Index].Value?.ToString();
                string productNo = row.Cells[colProductNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(txnDate) || string.IsNullOrEmpty(productNo))
                {
                    MessageBox.Show("異動日期、產品編號為必填欄位，請確認每一列都已填寫!");
                    return;
                }
            }

            foreach (var row in newRows)
            {
                var card = new A材料庫存卡
                {
                    產品編號 = row.Cells[colProductNo.Index].Value?.ToString(),
                    異動日期 = row.Cells[colTxnDate.Index].Value?.ToString(),
                    摘要 = string.IsNullOrEmpty(row.Cells[colSummary.Index].Value?.ToString()) ? "領料" : row.Cells[colSummary.Index].Value.ToString(),
                    來源用途 = row.Cells[colSource.Index].Value?.ToString(),
                    單位 = row.Cells[colUnit.Index].Value?.ToString(),
                    入庫 = decimal.TryParse(row.Cells[colStockIn.Index].Value?.ToString(), out var stockIn) ? stockIn : (decimal?)null,
                    出庫 = decimal.TryParse(row.Cells[colStockOut.Index].Value?.ToString(), out var stockOut) ? stockOut : (decimal?)null,
                    儲位 = row.Cells[colLocation.Index].Value?.ToString(),
                    異動人員 = row.Cells[colRequester.Index].Value?.ToString(),
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                    單價 = decimal.TryParse(row.Cells[colUnitPrice.Index].Value?.ToString(), out var unitPrice) ? unitPrice : (decimal?)null,
                    領用長度 = row.Cells[colLength.Index].Value?.ToString(),
                    ERP領料單號 = row.Cells[colErpDocNo.Index].Value?.ToString(),
                };

                var rep = new ItemController().AddStockCard(card);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功");
            LoadDetailGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
