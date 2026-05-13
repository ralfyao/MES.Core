using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Settings
{
    public partial class FrmPasswordSetting : CommonForm
    {
        private string _account { get; set; }
        public void SetAccount(string account)
        {
            _account = account;
            lblAccount.Text = account;
        }
        public FrmPasswordSetting()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("請輸入【舊密碼】");
                return;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("請輸入【新密碼】");
                return;
            }
            if (string.IsNullOrEmpty(txtNewPasswordConfirm.Text.Trim()))
            {
                MessageBox.Show("請輸入【確認新密碼】");
                return;
            }
            if (txtNewPassword.Text.Trim() != txtNewPasswordConfirm.Text.Trim())
            {
                MessageBox.Show("【新密碼】與【確認新密碼】不同");
                return;
            }
            AutheiticateController autheiticateController = new AutheiticateController();
            var user = autheiticateController.GetUser(new MES.WebAPI.Models.User() { username = lblAccount.Text });
            if (user != null && user.result != null)
            {
                if (user.result.Password != txtPassword.Text)
                {
                    MessageBox.Show($"原密碼輸入錯誤!");
                    return;
                }
            }
            else
            {
                MessageBox.Show($"使用者：{lblAccount.Text}不存在!");
                return;
            }
            var rep = autheiticateController.UpdatePassword(lblAccount.Text, txtNewPassword.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
            }
            else
            {
                MessageBox.Show("執行成功!");
            }
            Dispose();
            Close();
        }
    }
}
