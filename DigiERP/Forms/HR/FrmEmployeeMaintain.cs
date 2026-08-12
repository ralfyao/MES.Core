using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.HR
{
    // ── 員工資料維護：新增員工 或 修改員工個資(由 EmployeeSalaryControl 開啟)，
    //    按 SAVE 後寫入/更新 H員工清冊；狀況改為離職時，離職日期會同步寫入該工號
    //    目前最新一筆核薪紀錄(H員工基本資料)的離職日，改回非離職狀態則清空 ──────
    public partial class FrmEmployeeMaintain : Form
    {
        private readonly bool _isEdit;

        // ── 新增模式 ──────────────────────────────────────────────────
        public FrmEmployeeMaintain()
        {
            InitializeComponent();
            _isEdit = false;
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "正常", "留職停薪", "離職" });
            cboStatus.SelectedIndex = 0;
            dtpBirthday.Value = DateTime.Today;
            dtpResignDate.Value = DateTime.Today;
            UpdateResignDateVisibility();
        }

        // ── 修改員工個資模式：帶入既有工號，載入 H員工清冊 資料，工號鎖定不可修改 ──
        public FrmEmployeeMaintain(string empNo)
        {
            InitializeComponent();
            _isEdit = true;
            Text = "修改員工個資";
            lblTitle.Text = "修改員工個資";
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "正常", "留職停薪", "離職" });

            var rep = new HRController().GetWorkerByNumber(empNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
            }
            var x = rep.result ?? new H員工清冊 { 工號 = empNo };
            txtEmpNo.Text = x.工號;
            txtEmpNo.ReadOnly = true;
            txtName.Text = x.姓名;
            txtDept.Text = x.部門;
            txtSkill.Text = x.職能;
            txtAddress.Text = x.地址;
            dtpBirthday.Value = DateTime.TryParse(x.生日, out var birthday) ? birthday : DateTime.Today;
            txtJobTitle.Text = x.職稱;
            txtIdNo.Text = x.身分證號;
            txtHRNo.Text = x.人事編號;
            txtCardNo.Text = x.卡號;
            cboStatus.SelectedIndex = cboStatus.Items.IndexOf(x.狀況);
            if (cboStatus.SelectedIndex < 0 && cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            // ── 若目前已是離職狀態，帶出最新一筆核薪紀錄既有的離職日；否則預設今天 ──
            dtpResignDate.Value = DateTime.Today;
            if (x.狀況 == "離職")
            {
                var salaryRep = new HRController().GetEmployeeSalaryList(empNo);
                var latest = (salaryRep.resultList ?? new List<H員工基本資料>()).LastOrDefault();
                if (latest != null && DateTime.TryParse(latest.離職日, out var resignDate))
                {
                    dtpResignDate.Value = resignDate;
                }
            }
            UpdateResignDateVisibility();
        }

        // ── 狀況改為離職時顯示離職日期(預設今天或既有值)；改回非離職則隱藏 ──────
        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResignDateVisibility();
        }

        private void UpdateResignDateVisibility()
        {
            bool isResigned = cboStatus.Text == "離職";
            lblResignDate.Visible = isResigned;
            dtpResignDate.Visible = isResigned;
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
                生日 = dtpBirthday.Value.ToString("yyyy/MM/dd"),
                職稱 = txtJobTitle.Text.Trim(),
                狀況 = cboStatus.Text,
                身分證號 = txtIdNo.Text.Trim(),
                人事編號 = txtHRNo.Text.Trim(),
                卡號 = txtCardNo.Text.Trim(),
            };

            var rep = _isEdit
                ? new HRController().UpdateEmployee(form)
                : new HRController().SaveEmployee(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            // ── 同步最新一筆核薪紀錄的離職日：狀況=離職才寫入日期，否則清空 ──────
            string resignDate = cboStatus.Text == "離職" ? dtpResignDate.Value.ToString("yyyy/MM/dd") : null;
            var resignRep = new HRController().UpdateLatestSalaryResignDate(form.工號, resignDate);
            if (!string.IsNullOrEmpty(resignRep.ErrorMessage))
            {
                MessageBox.Show(resignRep.ErrorMessage);
            }

            MessageBox.Show(_isEdit ? "修改成功!" : "新增成功!");
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
