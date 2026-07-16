using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class SupplierEvaluateMaintainControl : CommonUserControl
    {
        // 沿用 SupplierEvaluateControl (廠商評鑑列表) 已註冊的權限 GUID
        private static string id = "7B2E5A19-4C6D-4F0B-9A3E-1D8C6F2B9A54";

        public B廠商評鑑 form = new B廠商評鑑();
        public string Mode { get => lblMode.Text; set => lblMode.Text = value; }

        private SupplierController _controller;
        private List<H員工清冊> _staffList = new List<H員工清冊>();
        private bool _lockSupplierContext = false;
        private string? _lockedSupplierNo;

        public SupplierEvaluateMaintainControl()
        {
            InitializeComponent();
            _controller = new SupplierController();
            initStaffCombo();
        }

        private void initStaffCombo()
        {
            var rep = new HRController().AllWorkers();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _staffList = (rep.resultList ?? new List<H員工清冊>())
                .Where(x => x.狀況 != "離職").ToList();

            cboEvaluator.DisplayMember = "姓名";
            cboEvaluator.ValueMember = "工號";
            cboEvaluator.DataSource = _staffList;
            cboEvaluator.Text = "";

            cboReviewer.DisplayMember = "姓名";
            cboReviewer.ValueMember = "工號";
            cboReviewer.DataSource = new List<H員工清冊>(_staffList);
            cboReviewer.Text = "";
        }

        private void disableControl(bool disable)
        {
            bool isEnabled = !disable;
            btnAdd.Enabled = isEnabled;
            btnDelete.Enabled = isEnabled;
            btnSave.Enabled = isEnabled;
            btnApprove.Enabled = isEnabled;
            btnCancelApprove.Enabled = isEnabled;
            btnPickSupplier.Enabled = isEnabled;
            dtpDate.Enabled = isEnabled;
            cboEvaluator.Enabled = isEnabled;
            cboReviewer.Enabled = isEnabled;
            dtpReviewDate.Enabled = isEnabled;
            foreach (var t in GetScoreBoxes()) t.Enabled = isEnabled;
            foreach (var t in GetRemarkBoxes()) t.Enabled = isEnabled;
        }

        // ── Entry point called by parent ─────────────────────────────
        public void initForm()
        {
            if (lblMode.Text == "新增")
            {
                ResetForNewRecord();
            }
            else
            {
                GetFormData();
                bool approved = !string.IsNullOrEmpty(form.核准日);
                btnApprove.Visible = !approved;
                btnCancelApprove.Visible = approved;
                disableControl(true);
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
        }

        private void ResetForNewRecord()
        {
            form = new B廠商評鑑();
            lblMode.Text = "新增";

            var rep = _controller.GetSupplierNo();
            txtFormNo.Text = string.IsNullOrEmpty(rep.ErrorMessage) ? (rep.result ?? "") : "";
            dtpDate.Value = DateTime.Now;
            dtpReviewDate.Value = DateTime.Now;

            txtSupplierNo.Text = "";
            txtShortName.Text = "";
            txtTaxNo.Text = "";
            txtIndustry.Text = "";
            txtSupplierName.Text = "";
            txtFactoryAddr.Text = "";
            txtCompanyAddr.Text = "";
            cboEvaluator.Text = "";
            cboReviewer.Text = "";

            foreach (var t in GetScoreBoxes()) t.Text = "";
            foreach (var t in GetRemarkBoxes()) t.Text = "";
            RecalcTotal();

            txtApprover.Text = "";
            txtApproveDate.Text = "";
            txtModifier.Text = "";
            txtModifyDate.Text = "";
            txtCreator.Text = "";
            txtCreateDate.Text = "";

            btnDelete.Visible = false;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = false;
            btnModify.Visible = false;
            disableControl(false);

            if (_lockSupplierContext)
            {
                txtSupplierNo.Text = _lockedSupplierNo ?? "";
                LoadSupplierDisplayFields(_lockedSupplierNo);
                ApplySupplierLock();
            }
        }

        // ── 供外部（如廠商維護頁的「廠商評鑑」按鈕）鎖定廠商，日期/廠商編號不可更改 ─
        public void LockToSupplier(string supplierNo)
        {
            _lockSupplierContext = true;
            _lockedSupplierNo = supplierNo;
            PrefillSupplier(supplierNo);
            ApplySupplierLock();
        }

        private void ApplySupplierLock()
        {
            if (!_lockSupplierContext) return;
            dtpDate.Enabled = false;
            btnPickSupplier.Enabled = false;
        }

        private void GetFormData()
        {
            txtFormNo.Text = form.單號 ?? "";
            dtpDate.Value = DateTime.TryParse(form.日期, out var d) ? d : DateTime.Now;
            txtSupplierNo.Text = form.廠商編號 ?? "";
            cboEvaluator.Text = form.評鑑人員 ?? "";
            cboReviewer.Text = form.覆審人員 ?? "";
            dtpReviewDate.Value = DateTime.TryParse(form.覆審日期, out var rd) ? rd : DateTime.Now;

            txt達成客戶要求的能力.Text = form.達成客戶要求的能力?.ToString() ?? "";
            txt提升經營效能的企圖.Text = form.提升經營效能的企圖?.ToString() ?? "";
            txt勞動安全與職工福利.Text = form.勞動安全與職工福利?.ToString() ?? "";
            txt能迅速處理客戶抱怨.Text = form.能迅速處理客戶抱怨?.ToString() ?? "";
            txt設備的產能與準確度.Text = form.設備的產能與準確度?.ToString() ?? "";
            txt足夠的人力資源條件.Text = form.足夠的人力資源條件?.ToString() ?? "";
            txt產銷接單適當無過載.Text = form.產銷接單適當無過載?.ToString() ?? "";
            txt健全的產品驗證系統.Text = form.健全的產品驗證系統?.ToString() ?? "";
            txt符合訂單的品質要求.Text = form.符合訂單的品質要求?.ToString() ?? "";
            txt依產品標準進行檢測.Text = form.依產品標準進行檢測?.ToString() ?? "";

            txtRemark達.Text = form.達 ?? "";
            txtRemark提.Text = form.提 ?? "";
            txtRemark勞.Text = form.勞 ?? "";
            txtRemark能.Text = form.能 ?? "";
            txtRemark設.Text = form.設 ?? "";
            txtRemark足.Text = form.足 ?? "";
            txtRemark產.Text = form.產 ?? "";
            txtRemark健.Text = form.健 ?? "";
            txtRemark符.Text = form.符 ?? "";
            txtRemark依.Text = form.依 ?? "";
            RecalcTotal();

            txtApprover.Text = form.核准 ?? "";
            txtApproveDate.Text = form.核准日 ?? "";
            txtModifier.Text = form.修改 ?? "";
            txtModifyDate.Text = form.修改日 ?? "";
            txtCreator.Text = form.建檔 ?? "";
            txtCreateDate.Text = form.建檔日 ?? "";

            LoadSupplierDisplayFields(form.廠商編號);
        }

        // ── 供外部（如廠商維護頁的「廠商評鑑」按鈕）帶入廠商編號 ───────────
        public void PrefillSupplier(string supplierNo)
        {
            txtSupplierNo.Text = supplierNo;
            LoadSupplierDisplayFields(supplierNo);
        }

        private void LoadSupplierDisplayFields(string? supplierNo)
        {
            txtShortName.Text = "";
            txtTaxNo.Text = "";
            txtIndustry.Text = "";
            txtSupplierName.Text = "";
            txtFactoryAddr.Text = "";
            txtCompanyAddr.Text = "";
            if (string.IsNullOrEmpty(supplierNo)) return;

            var rep = _controller.GetSupplierList(supplierNo, "");
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            var s = (rep.resultList ?? new List<B廠商設定>()).FirstOrDefault(x => x.廠商編號 == supplierNo);
            if (s == null) return;
            FillSupplierDisplayFields(s);
        }

        private void FillSupplierDisplayFields(B廠商設定 s)
        {
            txtShortName.Text = s.廠商簡稱 ?? "";
            txtTaxNo.Text = s.統一編號 ?? "";
            txtIndustry.Text = s.所屬業別 ?? "";
            txtSupplierName.Text = s.廠商名稱 ?? "";
            txtFactoryAddr.Text = s.工廠地址 ?? "";
            txtCompanyAddr.Text = s.公司地址 ?? "";
        }

        private void CollectUserInput()
        {
            form.單號 = txtFormNo.Text.Trim();
            form.日期 = dtpDate.Value.ToString("yyyy/MM/dd");
            form.廠商編號 = txtSupplierNo.Text.Trim();
            form.評鑑人員 = cboEvaluator.Text.Trim();
            form.覆審人員 = cboReviewer.Text.Trim();
            form.覆審日期 = dtpReviewDate.Value.ToString("yyyy/MM/dd");

            form.達成客戶要求的能力 = ParseScore(txt達成客戶要求的能力.Text);
            form.提升經營效能的企圖 = ParseScore(txt提升經營效能的企圖.Text);
            form.勞動安全與職工福利 = ParseScore(txt勞動安全與職工福利.Text);
            form.能迅速處理客戶抱怨 = ParseScore(txt能迅速處理客戶抱怨.Text);
            form.設備的產能與準確度 = ParseScore(txt設備的產能與準確度.Text);
            form.足夠的人力資源條件 = ParseScore(txt足夠的人力資源條件.Text);
            form.產銷接單適當無過載 = ParseScore(txt產銷接單適當無過載.Text);
            form.健全的產品驗證系統 = ParseScore(txt健全的產品驗證系統.Text);
            form.符合訂單的品質要求 = ParseScore(txt符合訂單的品質要求.Text);
            form.依產品標準進行檢測 = ParseScore(txt依產品標準進行檢測.Text);

            form.達 = txtRemark達.Text.Trim();
            form.提 = txtRemark提.Text.Trim();
            form.勞 = txtRemark勞.Text.Trim();
            form.能 = txtRemark能.Text.Trim();
            form.設 = txtRemark設.Text.Trim();
            form.足 = txtRemark足.Text.Trim();
            form.產 = txtRemark產.Text.Trim();
            form.健 = txtRemark健.Text.Trim();
            form.符 = txtRemark符.Text.Trim();
            form.依 = txtRemark依.Text.Trim();
        }

        private static int? ParseScore(string text)
        {
            return int.TryParse(text.Trim(), out int v) ? v : (int?)null;
        }

        private TextBox[] GetScoreBoxes() => new[]
        {
            txt達成客戶要求的能力, txt提升經營效能的企圖, txt勞動安全與職工福利, txt能迅速處理客戶抱怨,
            txt設備的產能與準確度, txt足夠的人力資源條件, txt產銷接單適當無過載, txt健全的產品驗證系統,
            txt符合訂單的品質要求, txt依產品標準進行檢測
        };

        private TextBox[] GetRemarkBoxes() => new[]
        {
            txtRemark達, txtRemark提, txtRemark勞, txtRemark能, txtRemark設,
            txtRemark足, txtRemark產, txtRemark健, txtRemark符, txtRemark依
        };

        private void RecalcTotal()
        {
            int total = GetScoreBoxes().Sum(t => int.TryParse(t.Text.Trim(), out int v) ? v : 0);
            lblTotalValue.Text = total.ToString();
        }

        private void ScoreBox_TextChanged(object sender, EventArgs e)
        {
            RecalcTotal();
        }

        // ── 廠商編號放大鏡：跳出視窗選取廠商 ─────────────────────────────
        private void btnPickSupplier_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmSelectSupplier();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                txtSupplierNo.Text = dlg.Selected.廠商編號 ?? "";
                FillSupplierDisplayFields(dlg.Selected);
            }
        }

        // ── 新增：於此畫面直接重置為新記錄 ────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = false;
            ResetForNewRecord();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControl(false);
            ApplySupplierLock();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierNo.Text.Trim()))
            {
                MessageBox.Show("請選取廠商編號!");
                return;
            }
            if (string.IsNullOrEmpty(cboEvaluator.Text.Trim()))
            {
                MessageBox.Show("請選取評鑑人員!");
                return;
            }

            CollectUserInput();

            CommonRep<string> rep;
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
                rep = _controller.SaveSupplierEvaluate(form);
            }
            else
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
                rep = _controller.UpdateSupplierEvaluate(form);
            }

            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("儲存成功");
            btnBack_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定刪除此筆廠商評鑑紀錄?", "確認刪除",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = _controller.DeleteSupplierEvaluate(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("刪除成功");
            btnBack_Click(sender, e);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            var rep = _controller.EvaluateSupplier(form.單號, true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            form.核准 = AppSession.User.username;
            form.核准日 = DateTime.Now.ToString("yyyy/MM/dd");
            txtApprover.Text = form.核准;
            txtApproveDate.Text = form.核准日;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = true;
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            var rep = _controller.EvaluateSupplier(form.單號, false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            form.核准 = "";
            form.核准日 = "";
            txtApprover.Text = "";
            txtApproveDate.Text = "";
            btnApprove.Visible = true;
            btnCancelApprove.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚未開放");
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚未開放");
        }

        // ── 關閉 — 回到列表，或若是獨立頁籤則直接關閉該頁籤 ───────────────
        private void btnBack_Click(object sender, EventArgs e)
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
                foreach (Control c in parentCtrl.Controls)
                    if (c is DataGridView) c.Visible = true;
            }
            Dispose();
        }
    }
}
