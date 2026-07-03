using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmAddPart : Form
    {
        private ItemController _controller;
        private List<A材料品項代號> _partCodeList = new List<A材料品項代號>();
        private bool _suppressCheckedChanged = false;
        public string Mode { get; private set; } = "新增";

        private static readonly string[] SourceAttrOptions = { "客供", "市購", "自製", "採購預查" };

        public FrmAddPart(A材料? existingItem = null)
        {
            InitializeComponent();
            _controller = new ItemController();
            initTypeCombo();
            initSourceAttrCombo();
            initPartCodeList();

            if (existingItem != null)
            {
                Mode = "修改";
                LoadFromItem(existingItem);
                btnDisableManage.Visible = true;
                btnModify.Visible = true;
                btnDelete.Visible = true;
                UpdateApprovalButtonVisibility();
                disableControl(true);
            }
            else
            {
                ResetForNewRecord();
            }
        }

        // ── 全部欄位/動作按鈕啟用或停用；按「修改」才能解鎖 ─────────────────
        private void disableControl(bool disable)
        {
            bool isEnabled = !disable;

            btnDelete.Enabled = isEnabled;
            btnApprove.Enabled = isEnabled;
            btnCancelApprove.Enabled = isEnabled;
            btnSave.Enabled = isEnabled;
            btnDisableManage.Enabled = isEnabled;
            btnPreQueryTempCode.Enabled = isEnabled;
            btnAbandon.Enabled = isEnabled;

            txtItemNo.Enabled = isEnabled;
            txtName.Enabled = isEnabled;
            chkDisabled.Enabled = isEnabled;
            cboType.Enabled = isEnabled;
            txtEnglishName.Enabled = isEnabled;
            txtCategory.Enabled = isEnabled;
            btnPickCategory.Enabled = isEnabled;
            txtStockUnit.Enabled = isEnabled;
            numLength.Enabled = isEnabled;
            cboSubCategory.Enabled = isEnabled;
            txtPurchaseUnit.Enabled = isEnabled;
            txtWidth.Enabled = isEnabled;
            cboSourceAttr.Enabled = isEnabled;
            numPurchaseFactor.Enabled = isEnabled;
            numThickness.Enabled = isEnabled;
            txtMaterialCode.Enabled = isEnabled;
            txtSalesUnit.Enabled = isEnabled;
            numOuterDia.Enabled = isEnabled;
            numSalesFactor.Enabled = isEnabled;
            numInnerDia.Enabled = isEnabled;
        }

        private void UpdateApprovalButtonVisibility()
        {
            bool approved = !string.IsNullOrEmpty(txtApprover.Text);
            btnApprove.Visible = !approved;
            btnCancelApprove.Visible = approved;
        }

        // ── 重置為空白新增狀態，欄位全部解鎖 ─────────────────────────────
        private void ResetForNewRecord()
        {
            Mode = "新增";

            txtItemNo.Text = "";
            txtName.Text = "";
            chkDisabled.Checked = false;
            cboType.Text = "";
            txtEnglishName.Text = "";
            txtCategory.Text = "";
            txtStockUnit.Text = "";
            txtPurchaseUnit.Text = "";
            txtSalesUnit.Text = "";
            txtMaterialCode.Text = "";
            numLength.Value = 0;
            txtWidth.Text = "";
            numThickness.Value = 0;
            numInnerDia.Value = 0;
            numOuterDia.Value = 0;
            numPurchaseFactor.Value = 0;
            numSalesFactor.Value = 0;
            cboSourceAttr.Text = "";
            cboSubCategory.DataSource = null;
            txtApprover.Text = "";
            txtModifier.Text = "";
            txtModifyDate.Text = "";
            txtCreator.Text = "";
            txtCreateDate.Text = "";

            btnDisableManage.Visible = false;
            btnDelete.Visible = false;
            btnModify.Visible = false;
            btnApprove.Visible = false;
            btnCancelApprove.Visible = false;

            disableControl(false);
        }

        // ── 新增：清空資料，讓使用者輸入新增料品資料 ───────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetForNewRecord();
        }

        // ── 修改：解鎖畫面上所有欄位與按鈕 ────────────────────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControl(false);
        }

        // ── 生效 / 取消生效：核准欄位 ───────────────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemNo.Text))
            {
                MessageBox.Show("請輸入品項編號!");
                return;
            }
            var rep = _controller.ValidateItem(txtItemNo.Text.Trim(), true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }

            txtApprover.Text = AppSession.User.username;
            UpdateApprovalButtonVisibility();
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemNo.Text))
            {
                MessageBox.Show("請輸入品項編號!");
                return;
            }
            var rep = _controller.ValidateItem(txtItemNo.Text.Trim(), false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }

            txtApprover.Text = "";
            UpdateApprovalButtonVisibility();
        }

        // ── 帶入現有 A材料 資料（供「編修料品」開啟時使用）───────────────
        private void LoadFromItem(A材料 item)
        {
            txtItemNo.Text = item.產品編號 ?? "";
            txtName.Text = item.品名規格 ?? "";
            chkDisabled.Checked = item.停用 ?? false;
            cboType.Text = item.品別 ?? "";
            txtEnglishName.Text = item.英文品名 ?? "";
            txtCategory.Text = item.大分類 ?? "";
            txtStockUnit.Text = item.庫存單位 ?? "";
            txtPurchaseUnit.Text = item.採購單位 ?? "";
            txtSalesUnit.Text = item.銷售單位 ?? "";
            txtMaterialCode.Text = item.產品代號 ?? "";
            numLength.Value = ClampToRange(numLength, item.外尺寸長);
            txtWidth.Text = item.外尺寸寬?.ToString() ?? "";
            numThickness.Value = ClampToRange(numThickness, item.厚度);
            numInnerDia.Value = ClampToRange(numInnerDia, item.內徑);
            numOuterDia.Value = ClampToRange(numOuterDia, item.外徑);
            numPurchaseFactor.Value = ClampToRange(numPurchaseFactor, item.採購換算倍數);
            numSalesFactor.Value = ClampToRange(numSalesFactor, item.銷售換算倍數);
            cboSourceAttr.Text = item.來源屬性 ?? "";
            txtApprover.Text = item.核准 ?? "";
            txtModifier.Text = item.修改 ?? "";
            txtModifyDate.Text = item.修改日 ?? "";
            txtCreator.Text = item.建檔 ?? "";
            txtCreateDate.Text = item.建檔日 ?? "";

            RefreshSubCategoryCombo();
            cboSubCategory.SelectedValue = item.小分類??"";
        }

        private static decimal ClampToRange(NumericUpDown control, decimal? value)
        {
            decimal v = value ?? 0;
            if (v < control.Minimum) return control.Minimum;
            if (v > control.Maximum) return control.Maximum;
            return v;
        }

        private void initTypeCombo()
        {
            var rep = _controller.GetItemTypeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Items.Clear();
            cboType.Items.AddRange((rep.resultList ?? new List<string>()).ToArray());
        }

        private void initSourceAttrCombo()
        {
            cboSourceAttr.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSourceAttr.Items.Clear();
            cboSourceAttr.Items.AddRange(SourceAttrOptions);
        }

        private void initPartCodeList()
        {
            var rep = _controller.GetPartCodeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _partCodeList = rep.resultList ?? new List<A材料品項代號>();
        }

        // ── 主分類：跳出視窗選取 A材料分類，並依選取結果刷新次分類清單 ─────
        private void btnPickCategory_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmSelectMaterialCategory();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                txtCategory.Text = dlg.Selected.大分類 ?? "";
                RefreshSubCategoryCombo();
            }
        }

        // ── 次分類：依目前主分類從 A材料品項代號 篩選出的下拉清單 ─────────
        private void RefreshSubCategoryCombo()
        {
            string category = txtCategory.Text.Trim();
            var options = _partCodeList
                .Where(x => x.大分類 == category)
                .GroupBy(x => x.小分類)
                .Select(g => g.First())
                .ToList();

            cboSubCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCategory.DisplayMember = "小分類名稱";
            cboSubCategory.ValueMember = "小分類";
            cboSubCategory.DataSource = options;
        }

        // ── 依畫面目前欄位組出一筆 A材料 ──────────────────────────────────
        private A材料 BuildItemFromFields()
        {
            return new A材料
            {
                產品編號 = txtItemNo.Text.Trim(),
                品名規格 = txtName.Text.Trim(),
                停用 = chkDisabled.Checked,
                品別 = cboType.Text,
                英文品名 = txtEnglishName.Text.Trim(),
                大分類 = txtCategory.Text.Trim(),
                小分類 = cboSubCategory.SelectedValue?.ToString(),
                庫存單位 = txtStockUnit.Text.Trim(),
                採購單位 = txtPurchaseUnit.Text.Trim(),
                銷售單位 = txtSalesUnit.Text.Trim(),
                產品代號 = txtMaterialCode.Text.Trim(),
                外尺寸長 = numLength.Value,
                外尺寸寬 = decimal.TryParse(txtWidth.Text.Trim(), out var width) ? width : (decimal?)null,
                厚度 = numThickness.Value,
                內徑 = numInnerDia.Value,
                外徑 = numOuterDia.Value,
                採購換算倍數 = numPurchaseFactor.Value,
                銷售換算倍數 = numSalesFactor.Value,
                來源屬性 = cboSourceAttr.Text,
                建檔 = AppSession.User.username,
                建檔日 = DateTime.Now.ToString("yyyy/MM/dd"),
                勾選 = false,
            };
        }

        private bool SaveItem(A材料 item)
        {
            var rep = _controller.SaveUpdateItem(item);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return false;
            }
            MessageBox.Show("儲存成功");
            return true;
        }

        // ── 儲存：寫入一筆 A材料 ────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemNo.Text))
            {
                MessageBox.Show("請輸入品項編號!");
                return;
            }

            if (!SaveItem(BuildItemFromFields())) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        // ── 採購預查新增臨時品號：產生 XPRE-流水號，來源屬性寫入採購預查 ────
        private void btnPreQueryTempCode_Click(object sender, EventArgs e)
        {
            var codeRep = _controller.GetNextTempPartCode();
            if (!string.IsNullOrEmpty(codeRep.ErrorMessage))
            {
                MessageBox.Show(codeRep.ErrorMessage);
                return;
            }
            string tempCode = codeRep.result ?? "";

            var item = BuildItemFromFields();
            item.產品編號 = tempCode;
            item.來源屬性 = "採購預查";

            if (!SaveItem(item)) return;

            txtItemNo.Text = tempCode;
            cboSourceAttr.Text = "採購預查";
        }

        // ── 停用管理 / 停用 checkbox：切換目前品項的停用旗標 ────────────────
        private void btnDisableManage_Click(object sender, EventArgs e)
        {
            if (!ToggleDisabledOnServer()) return;

            _suppressCheckedChanged = true;
            chkDisabled.Checked = !chkDisabled.Checked;
            _suppressCheckedChanged = false;
        }

        private void chkDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (_suppressCheckedChanged) return;
            if (ToggleDisabledOnServer()) return;

            // 失敗則還原 checkbox 顯示，避免跟資料庫實際狀態不同步
            _suppressCheckedChanged = true;
            chkDisabled.Checked = !chkDisabled.Checked;
            _suppressCheckedChanged = false;
        }

        private bool ToggleDisabledOnServer()
        {
            if (string.IsNullOrWhiteSpace(txtItemNo.Text))
            {
                MessageBox.Show("請輸入品項編號!");
                return false;
            }

            var rep = _controller.ToggleDisableItem(txtItemNo.Text.Trim());
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return false;
            }
            return true;
        }
    }
}
