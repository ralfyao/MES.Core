using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class SupplierControl : CommonUserControl
    {
        private static string id = "54406a92-a15c-4e20-90f2-57d7c033bf69";
        private SupplierController _controller;
        private List<B廠商設定> _supplierList = new List<B廠商設定>();

        public SupplierControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initController()
        {
            _controller ??= new SupplierController();
        }

        private void initGrid()
        {
            initController();
            var rep = _controller.GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _supplierList = rep.resultList ?? new List<B廠商設定>();
            FillGrid(_supplierList);
        }

        private void FillGrid(List<B廠商設定> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var s in list)
            {
                // 若勾選「隱藏停用」則跳過停用廠商
                if (chkHideDisabled.Checked && (s.停用 == true)) continue;

                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = s.廠商編號;
                row.Cells[i++].Value = s.廠商簡稱;
                row.Cells[i++].Value = s.廠商名稱;
                row.Cells[i++].Value = s.統一編號;
                row.Cells[i++].Value = s.電話;
                row.Cells[i++].Value = s.傳真;
                row.Cells[i++].Value = s.聯絡人;
                row.Cells[i++].Value = s.職稱;
                row.Cells[i++].Value = s.所屬業別;
                row.Cells[i++].Value = s.等級;
                row.Cells[i++].Value = s.核准;
                row.Cells[i++].Value = s.停用 == true ? "停用" : "";
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 搜尋 ────────────────────────────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string no = txtSearchNo.Text.Trim().ToLower();
            string name = txtSearchName.Text.Trim().ToLower();
            var filtered = _supplierList.Where(s =>
                (string.IsNullOrEmpty(no) || (s.廠商編號 ?? "").ToLower().Contains(no)) &&
                (string.IsNullOrEmpty(name) ||
                 (s.廠商名稱 ?? "").ToLower().Contains(name) ||
                 (s.廠商簡稱 ?? "").ToLower().Contains(name))
            ).ToList();
            FillGrid(filtered);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void chkHideDisabled_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid(_supplierList);
        }

        // ── 新增 ────────────────────────────────────────────────────────
        private void btn新增_Click(object sender, EventArgs e)
        {
            openMaintainControl(null);
        }

        // ── 雙擊進入維護 ─────────────────────────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            var target = _supplierList.FirstOrDefault(s => s.廠商編號 == no);
            if (target == null) return;
            openMaintainControl(target);
        }

        private void openMaintainControl(B廠商設定? target)
        {
            RemoveExistingMaintainControl();
            dataGridView1.Visible = false;

            var maintain = new SupplierMaintainControl();
            maintain.Dock = DockStyle.Fill;

            if (target == null)
            {
                maintain.Mode = "新增";
            }
            else
            {
                maintain.form         = target;
                maintain.Mode = "修改";
            }

            panel2.Controls.Add(maintain);
            maintain.initForm();
        }

        private void RemoveExistingMaintainControl()
        {
            for (int i = panel2.Controls.Count - 1; i >= 0; i--)
            {
                if (panel2.Controls[i] is SupplierMaintainControl m)
                {
                    panel2.Controls.RemoveAt(i);
                    m.Dispose();
                }
            }
        }

        // ── Grid 回顯時重刷 ──────────────────────────────────────────────
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) initGrid();
        }
    }
}
