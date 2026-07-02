using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class FrmSelectContact : Form
    {
        public B廠商聯絡名冊? Selected { get; private set; }

        private readonly string _supplierNo;
        private readonly SupplierController _controller;

        public FrmSelectContact(List<B廠商聯絡名冊> contactList,
                                string supplierNo,
                                SupplierController controller)
        {
            InitializeComponent();
            _supplierNo  = supplierNo ?? "";
            _controller  = controller;
            FillGrid(contactList ?? new List<B廠商聯絡名冊>());
        }

        private void FrmSelectContact_Load(object sender, EventArgs e) { }

        private void FillGrid(List<B廠商聯絡名冊> list)
        {
            dgvContact.Rows.Clear();
            foreach (var c in list)
            {
                int idx = dgvContact.Rows.Add();
                var row = dgvContact.Rows[idx];
                row.Cells[colSeq.Index].Value     = c.識別;
                row.Cells[colContact.Index].Value  = c.聯絡人;
                row.Cells[colTitle.Index].Value    = c.職稱;
                row.Cells[colEmail.Index].Value    = c.電郵;
                row.Cells[colPhone.Index].Value    = c.電話;
                row.Cells[colExt.Index].Value      = c.分機;
                row.Cells[colFax.Index].Value      = c.傳真;
                row.Cells[colBranch.Index].Value   = c.分支機構;
                row.Cells[colAddress.Index].Value  = c.地址;
            }
        }

        // ── 雙擊：帶回選定聯絡人資料並關閉 ─────────────────────────
        private void dgvContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvContact.Rows[e.RowIndex].IsNewRow) return;
            var row = dgvContact.Rows[e.RowIndex];
            Selected = new B廠商聯絡名冊
            {
                識別      = int.TryParse(row.Cells[colSeq.Index].Value?.ToString(), out int id) ? id : (int?)null,
                客廠編號  = _supplierNo,
                聯絡人    = row.Cells[colContact.Index].Value?.ToString() ?? "",
                職稱      = row.Cells[colTitle.Index].Value?.ToString() ?? "",
                電郵      = row.Cells[colEmail.Index].Value?.ToString() ?? "",
                電話      = row.Cells[colPhone.Index].Value?.ToString() ?? "",
                分機      = row.Cells[colExt.Index].Value?.ToString() ?? "",
                傳真      = row.Cells[colFax.Index].Value?.ToString() ?? "",
                分支機構  = row.Cells[colBranch.Index].Value?.ToString() ?? "",
                地址      = row.Cells[colAddress.Index].Value?.ToString() ?? "",
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 儲存：依廠商編號刪除全部後重新新增 ───────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = CollectRows();
            // 確保每筆都有廠商編號（空清單時也傳一筆 placeholder 以便後端知道 supplierNo）
            if (!list.Any())
                list.Add(new B廠商聯絡名冊 { 客廠編號 = _supplierNo });

            var rep = _controller.ReplaceContactList(list);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
                MessageBox.Show(rep.ErrorMessage);
            else
            {
                MessageBox.Show("儲存成功");
                // 重新從 DB 撈，更新 Grid（反映 AUTO 識別）
                var fresh = _controller.GetContactList(_supplierNo);
                if (string.IsNullOrEmpty(fresh.ErrorMessage))
                    FillGrid(fresh.resultList ?? new List<B廠商聯絡名冊>());
            }
        }

        private List<B廠商聯絡名冊> CollectRows()
        {
            var list = new List<B廠商聯絡名冊>();
            foreach (DataGridViewRow row in dgvContact.Rows)
            {
                if (row.IsNewRow) continue;
                string contact = row.Cells[colContact.Index].Value?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(contact)) continue;
                list.Add(new B廠商聯絡名冊
                {
                    識別      = int.TryParse(row.Cells[colSeq.Index].Value?.ToString(), out int id) ? id : (int?)null,
                    客廠編號  = _supplierNo,
                    聯絡人    = contact,
                    職稱      = row.Cells[colTitle.Index].Value?.ToString() ?? "",
                    電郵      = row.Cells[colEmail.Index].Value?.ToString() ?? "",
                    電話      = row.Cells[colPhone.Index].Value?.ToString() ?? "",
                    分機      = row.Cells[colExt.Index].Value?.ToString() ?? "",
                    傳真      = row.Cells[colFax.Index].Value?.ToString() ?? "",
                    分支機構  = row.Cells[colBranch.Index].Value?.ToString() ?? "",
                    地址      = row.Cells[colAddress.Index].Value?.ToString() ?? "",
                });
            }
            return list;
        }
    }
}
