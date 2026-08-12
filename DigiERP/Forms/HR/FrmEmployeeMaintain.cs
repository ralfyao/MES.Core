using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Windows.Forms;

namespace DigiERP.Forms.HR
{
    // ── 員工資料維護：新增員工，按 SAVE 後寫入 H員工清冊 ─────────────────────
    public partial class FrmEmployeeMaintain : Form
    {
        public FrmEmployeeMaintain()
        {
            InitializeComponent();
            cboStatus.Items.AddRange(new object[] { "正常", "離職" });
            cboStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpNo.Text))
            {
                MessageBox.Show("請輸入工號!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("請輸入姓名!");
                return;
            }

            var form = new H員工清冊
            {
                工號 = txtEmpNo.Text.Trim(),
                姓名 = txtName.Text.Trim(),
                部門 = txtDept.Text.Trim(),
                職能 = txtSkill.Text.Trim(),
                地址 = txtAddress.Text.Trim(),
                生日 = txtBirthday.Text.Trim(),
                職稱 = txtJobTitle.Text.Trim(),
                狀況 = cboStatus.Text,
                身分證號 = txtIdNo.Text.Trim(),
                人事編號 = txtHRNo.Text.Trim(),
                卡號 = txtCardNo.Text.Trim(),
            };

            var rep = new HRController().SaveEmployee(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("新增成功!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
