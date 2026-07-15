using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class BankMaintainControl : CommonUserControl
    {
        private static string id = "5E9C2A47-8B3D-4F16-A7E9-2D6C8B4F9A31";

        internal event EventHandler Saved;

        private string _mode = "新增";

        public BankMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }
        /// <summary>
        /// 進入點：由列表頁呼叫，mode="新增" 或 "修改"
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="bankCode"></param>
        internal void LoadData(string mode, string bankCode)
        {
            _mode = mode;
            if (_mode == "修改")
            {
                var rep = new CustomerController().GetBankList();
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                var form = (rep.resultList ?? new List<F銀行設定>()).FirstOrDefault(x => x.銀存編碼 == bankCode);
                PopulateForm(form ?? new F銀行設定 { 銀存編碼 = bankCode });
                disableControls(false);
                btnAdd.Visible = false;
            }
            else
            {
                ClearForm();
                disableControls(true);
                btnModify.Visible = false;
                btnDetail.Visible = false;
            }
        }

        private void PopulateForm(F銀行設定 form)
        {
            txtBankCode.Text = form.銀存編碼;
            txtBankName.Text = form.銀行名稱;
            txtBankFullName.Text = form.Bankname;
            txtBankAddress.Text = form.銀行地址;
            txtBeneficiary.Text = form.Beneficiary;
            txtAcctCode.Text = form.會科代碼;
            txtAccountNo.Text = form.帳號;
            txtSwiftCode.Text = form.SwiftCode;
            txtContact.Text = form.聯絡窗口;
            txtPhone.Text = form.電話;
            txtExt.Text = form.分機;
        }

        private void ClearForm()
        {
            txtBankCode.Text = "";
            txtBankName.Text = "";
            txtBankFullName.Text = "";
            txtBankAddress.Text = "";
            txtBeneficiary.Text = "";
            txtAcctCode.Text = "";
            txtAccountNo.Text = "";
            txtSwiftCode.Text = "";
            txtContact.Text = "";
            txtPhone.Text = "";
            txtExt.Text = "";
        }
        /// <summary>
        /// 銀存代號為主鍵，一旦建立不可修改；其餘欄位依 enable 切換
        /// </summary>
        /// <param name="enable"></param>
        private void disableControls(bool enable)
        {
            txtBankCode.Enabled = _mode == "新增";
            txtBankName.Enabled = enable;
            txtBankFullName.Enabled = enable;
            txtBankAddress.Enabled = enable;
            txtBeneficiary.Enabled = enable;
            txtAcctCode.Enabled = enable;
            txtAccountNo.Enabled = enable;
            txtSwiftCode.Enabled = enable;
            txtContact.Enabled = enable;
            txtPhone.Enabled = enable;
            txtExt.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData("新增", null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankCode.Text))
            {
                MessageBox.Show("請輸入銀存代號!");
                return;
            }
            if (MessageBox.Show($"確定{_mode}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            var form = new F銀行設定
            {
                銀存編碼 = txtBankCode.Text,
                銀行名稱 = txtBankName.Text,
                Bankname = txtBankFullName.Text,
                銀行地址 = txtBankAddress.Text,
                Beneficiary = txtBeneficiary.Text,
                會科代碼 = txtAcctCode.Text,
                帳號 = txtAccountNo.Text,
                SwiftCode = txtSwiftCode.Text,
                聯絡窗口 = txtContact.Text,
                電話 = txtPhone.Text,
                分機 = txtExt.Text
            };
            var rep = new CustomerController().SaveBankInfo(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show(_mode + "成功!");
            Saved?.Invoke(this, EventArgs.Empty);
            btnClose_Click(sender, e);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankCode.Text))
            {
                MessageBox.Show("請先輸入銀存代號!");
                return;
            }
            using var frm = new FrmBankLedgerDetail();
            frm.bankCode = txtBankCode.Text;
            frm.initData();
            frm.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            }
            Dispose();
        }
    }
}
