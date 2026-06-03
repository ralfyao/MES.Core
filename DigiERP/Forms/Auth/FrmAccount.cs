using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Auth
{
    public partial class FrmAccount : Form
    {
        public account user;
        private UserPrivilegeController _privilegeController;
        private void initController() 
        {
            if (_privilegeController == null)
            {
                _privilegeController = new UserPrivilegeController();
            }
        }
        public FrmAccount()
        {
            InitializeComponent();
        }

        internal void SetData()
        {
            if (user != null)
            {
                txtAccount.Text = user.帳號;
                txtPasword.Text = user.密碼;
                txtName.Text = user.姓名;
                chkActive.Checked = user.停用 ?? false;
                chkIsEmail.Checked = user.寄件允許 ?? false;
                btnSetAccountData.Text = "更新帳號資料";
            }
            else
            {
                btnSetAccountData.Text = "新增帳號資料";
            }
            //throw new NotImplementedException();
        }

        private void btnSetPrivilege_Click(object sender, EventArgs e)
        {
            FrmPrivilege frmPrivilege = new FrmPrivilege();
            frmPrivilege.account = this.user;
            frmPrivilege.GetUserPrivilegeData();
            frmPrivilege.ShowDialog(this);
        }

        private void btnSetAccountData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要{(user!=null?"更新":"新增")}資料?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                initController();
                collectAccount();
                CommonRep<int> rep = _privilegeController.SaveAccount(user);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                MessageBox.Show($"{(user != null ? "更新" : "新增")}成功");
                Dispose();
                Close();
            }
        }

        private void collectAccount()
        {
            this.user.姓名 = txtName.Text;
            this.user.帳號 = txtAccount.Text;
            this.user.密碼 = txtPasword.Text;
            this.user.寄件允許 = chkIsEmail.Checked;
            this.user.停用 = chkActive.Checked;
        }
    }
}
