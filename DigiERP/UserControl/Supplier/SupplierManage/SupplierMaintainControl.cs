using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class SupplierMaintainControl : CommonUserControl
    {
        public B廠商設定 form = new B廠商設定();
        public string Mode { get => lblMode.Text; set => lblMode.Text = value; }
        private SupplierController _controller;

        public SupplierMaintainControl()
        {
            InitializeComponent();
            _controller = new SupplierController();
            initGradeCombo();
        }
        private void disableControl(bool disable)
        {
            bool isEnabled = !disable;
            btnActivate.Enabled = isEnabled;
            btnDeactivate.Enabled = isEnabled;
            btnApprove.Enabled = isEnabled;
            btnCancelApprove.Enabled = isEnabled;
            btnSave.Enabled = isEnabled;
            btnSaveQuotation.Enabled = isEnabled;
            btnDelete.Enabled = isEnabled;
            txtSupplierNo.Enabled = isEnabled;
            txtShortName.Enabled = isEnabled;
            txtName.Enabled = isEnabled;
            cboCountry.Enabled = isEnabled;
            txtCompanyAddr.Enabled = isEnabled;
            txtFactoryAddr.Enabled = isEnabled;
            txtTaxNo.Enabled = isEnabled;
            txtContact.Enabled = isEnabled;
            txtTitle.Enabled = isEnabled;
            txtMobile.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            txtPhone.Enabled = isEnabled;
            txtFax.Enabled = isEnabled;
            txtIndustry.Enabled = isEnabled;
            txtMgmtClass.Enabled = isEnabled;
            cboGrade.Enabled = isEnabled;
            txtRemark.Enabled = isEnabled;
            txtR1.Enabled = isEnabled;
            txtR2.Enabled = isEnabled;
            txtR3.Enabled = isEnabled;
            chkDisabled.Enabled = isEnabled;
            txtApprover.Enabled = isEnabled;
            txtApproveDate.Enabled = isEnabled;
            txtCreator.Enabled = isEnabled;
            txtCreateDate.Enabled = isEnabled;
            txtModifier.Enabled = isEnabled;
            txtModifyDate.Enabled = isEnabled;
            dgvQuotation.Enabled = isEnabled;
        }
        // ── Entry point called by parent ─────────────────────────────
        public void initForm()
        {
            if (lblMode.Text == "新增")
            {
                //var rep = _controller.GetSupplierNo();
                //if (string.IsNullOrEmpty(rep.ErrorMessage)) txtSupplierNo.Text = rep.result ?? "";
                txtCreateDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                btnDelete.Visible = false;
                btnApprove.Visible = false;
                btnCancelApprove.Visible = false;
                btnDeactivate.Visible = false;
                btnActivate.Visible = false;
                disableControl(false);
            }
            else
            {
                GetFormData();
                bool approved = !string.IsNullOrEmpty(form.核准日);
                btnApprove.Visible = !approved;
                btnCancelApprove.Visible = approved;
                bool disabled = form.停用 == true;
                btnDeactivate.Visible = !disabled;
                btnActivate.Visible = disabled;
                disableControl(true);
            }
        }

        private void GetFormData()
        {
            txtSupplierNo.Text = form.廠商編號 ?? "";
            txtShortName.Text = form.廠商簡稱 ?? "";
            txtName.Text = form.廠商名稱 ?? "";
            cboCountry.Text = form.國別 ?? "";
            txtCompanyAddr.Text = form.公司地址 ?? "";
            txtFactoryAddr.Text = form.工廠地址 ?? "";
            txtTaxNo.Text = form.統一編號 ?? "";
            txtContact.Text = form.聯絡人 ?? "";
            txtTitle.Text = form.職稱 ?? "";
            txtMobile.Text = form.手機 ?? "";
            txtEmail.Text = form.電郵 ?? "";
            txtPhone.Text = form.電話 ?? "";
            txtFax.Text = form.傳真 ?? "";
            txtIndustry.Text = form.所屬業別 ?? "";
            txtMgmtClass.Text = form.管理分類 ?? "";
            cboGrade.Text = form.等級 ?? "";
            txtRemark.Text = form.備註 ?? "";
            txtR1.Text = form.R1 ?? "";
            txtR2.Text = form.R2 ?? "";
            txtR3.Text = form.R3 ?? "";
            chkDisabled.Checked = form.停用 == true;
            txtApprover.Text = form.核准 ?? "";
            txtApproveDate.Text = form.核准日 ?? "";
            txtCreator.Text = form.建檔 ?? "";
            txtCreateDate.Text = form.建檔日 ?? "";
            txtModifier.Text = form.修改 ?? "";
            txtModifyDate.Text = form.修改日 ?? "";

            initQuotationGrid();
        }

        private void CollectUserInput()
        {
            form.廠商編號 = txtSupplierNo.Text.Trim();
            form.廠商簡稱 = txtShortName.Text.Trim();
            form.廠商名稱 = txtName.Text.Trim();
            form.國別 = cboCountry.Text;
            form.公司地址 = txtCompanyAddr.Text.Trim();
            form.工廠地址 = txtFactoryAddr.Text.Trim();
            form.統一編號 = txtTaxNo.Text.Trim();
            form.聯絡人 = txtContact.Text.Trim();
            form.職稱 = txtTitle.Text.Trim();
            form.手機 = txtMobile.Text.Trim();
            form.電郵 = txtEmail.Text.Trim();
            form.電話 = txtPhone.Text.Trim();
            form.傳真 = txtFax.Text.Trim();
            form.所屬業別 = txtIndustry.Text.Trim();
            form.管理分類 = txtMgmtClass.Text.Trim();
            form.等級 = cboGrade.Text;
            form.備註 = txtRemark.Text.Trim();
            form.R1 = txtR1.Text.Trim();
            form.R2 = txtR2.Text.Trim();
            form.R3 = txtR3.Text.Trim();
        }

        private void initGradeCombo()
        {
            cboGrade.Items.Clear();
            cboGrade.Items.AddRange(new object[] { "", "A(81~100)", "B(61~80)", "C(41~60)", "D(21~40)", "E(0~20)" });
        }

        private void initQuotationGrid()
        {
            var rep = _controller.GetSupplierQuotationList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            dgvQuotation.Rows.Clear();
            var myList = (rep.resultList ?? new List<B廠商供料>())
                          .Where(q => q.廠商編號 == form.廠商編號).ToList();
            foreach (var q in myList)
            {
                int idx = dgvQuotation.Rows.Add();
                var row = dgvQuotation.Rows[idx];
                row.Cells[colQuotDate.Index].Value = q.詢價日期;
                row.Cells[colItemNo.Index].Value = q.品項編號;
                row.Cells[colItemName.Index].Value = q.品名規格;
                row.Cells[colUnit.Index].Value = q.採購單位;
                row.Cells[colMinQty.Index].Value = q.最低採購量;
                row.Cells[colMaxQty.Index].Value = q.最大採購量;
                row.Cells[colPrice.Index].Value = q.單價;
                row.Cells[colCurrency.Index].Value = q.幣別;
                row.Cells[colInquirer.Index].Value = q.詢價人員;
                row.Cells[colValidDate.Index].Value = q.報價有效日期;
                row.Cells[colVendorItemNo.Index].Value = q.廠商品號;
            }
        }

        // ── Toolbar buttons ──────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierNo.Text.Trim()))
            {
                MessageBox.Show("請輸入廠商編號!");
                return;
            }
            CollectUserInput();
            CommonRep<string> rep = lblMode.Text == "新增"
                ? _controller.SaveSupplier(form)
                : _controller.UpdateSupplier(form);

            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("儲存成功");
            if (lblMode.Text == "新增")
            {
                lblMode.Text = "修改";
                btnDelete.Visible = true;
                btnApprove.Visible = true;
                btnDeactivate.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定刪除此筆廠商資料?", "確認刪除",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            form.廠商編號 = txtSupplierNo.Text;
            var rep = _controller.DeleteSupplier(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("刪除成功");
            btnBack_Click(sender, e);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            var rep = _controller.ValidateSupplier(form.廠商編號, true, "");
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            txtApproveDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            btnApprove.Visible = false;
            btnCancelApprove.Visible = true;
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            var rep = _controller.ValidateSupplier(form.廠商編號, false, "");
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            txtApprover.Text = "";
            txtApproveDate.Text = "";
            btnApprove.Visible = true;
            btnCancelApprove.Visible = false;
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定停用此廠商?", "確認",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = _controller.ActivateSupplier(form.廠商編號, false, "");
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            chkDisabled.Checked = true;
            form.停用 = true;
            btnDeactivate.Visible = false;
            btnActivate.Visible = true;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定取消停用此廠商?", "確認",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = _controller.ActivateSupplier(form.廠商編號, true, "");
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            chkDisabled.Checked = false;
            form.停用 = false;
            btnDeactivate.Visible = true;
            btnActivate.Visible = false;
        }

        // ── 供料詢價：跳出新增視窗，儲存後刷新明細列表 ───────────────────
        private void btnSaveQuotation_Click(object sender, EventArgs e)
        {
            string supplierNo = txtSupplierNo.Text.Trim();
            if (string.IsNullOrEmpty(supplierNo))
            {
                MessageBox.Show("請先儲存廠商基本資料，取得廠商編號後再新增供料詢價");
                return;
            }

            using var dlg = new FrmAddSupplierQuotation(supplierNo, _controller);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                initQuotationGrid();
            }
        }

        // ── 關閉 — 回到列表 ───────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
                foreach (Control c in parentCtrl.Controls)
                    if (c is DataGridView) c.Visible = true;
            }
            Dispose();
        }

        // ── 放大鏡：從 B廠商聯絡名冊 WHERE 客廠編號=[廠商編號] ─────────
        private void btnFindContact_Click(object sender, EventArgs e)
        {
            string supplierNo = txtSupplierNo.Text.Trim();
            var contactList = new List<B廠商聯絡名冊>();

            if (!string.IsNullOrEmpty(supplierNo))
            {
                var rep = _controller.GetContactList(supplierNo);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                contactList = rep.resultList ?? new List<B廠商聯絡名冊>();
            }

            using var dlg = new FrmSelectContact(contactList, supplierNo, _controller);
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                var c = dlg.Selected;
                txtContact.Text = c.聯絡人 ?? "";
                txtTitle.Text = c.職稱 ?? "";
                txtEmail.Text = c.電郵 ?? "";
                txtPhone.Text = c.電話 ?? "";
                txtFax.Text = c.傳真 ?? "";
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControl(false);
        }
    }
}
