using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmWorkLogEntry : Form
    {
        private const string Position = "設計";
        private List<H職務工作分類> _taskCategoryList = new List<H職務工作分類>();

        public FrmWorkLogEntry(設計派案 row)
        {
            InitializeComponent();

            txtWorkDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtWorkerNo.Text = AppSession.User.empNo;
            txtName.Text = AppSession.User.username;
            txtPosition.Text = Position;

            txtProjectNo.Text = row?.專案序號;
            txtModuleCode.Text = row?.模組編碼;
            txtModuleName.Text = row?.模組名稱;
            txtActualStart.Text = row?.實際開工日;
            txtPlannedFinish.Text = row?.預計完工日;
            txtEstHours.Text = row?.製圖;
            txtWorkItem.Text = row?.製圖檔名;

            var rep = new HRController().getPositionList(Position);
            _taskCategoryList = rep.resultList ?? new List<H職務工作分類>();
            cboTaskCategory.DataSource = _taskCategoryList;
            cboTaskCategory.DisplayMember = "分類";
            cboTaskCategory.ValueMember = "代碼";
            cboTaskCategory.SelectedIndex = -1;
        }

        private void cboTaskCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTaskCategory.SelectedItem is H職務工作分類 item)
            {
                txtScore.Text = item.積分點數?.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTaskCategory.SelectedItem == null)
            {
                MessageBox.Show("請選擇任務分類");
                return;
            }

            var log = new 工作紀錄A
            {
                日誌單號 = txtWorkerNo.Text + "-" + DateTime.Now.ToString("yyyyMMdd"),
                工作日期 = txtWorkDate.Text,
                職務 = Position,
                員工編號 = txtWorkerNo.Text,
                姓名 = txtName.Text,
                專案序號 = txtProjectNo.Text,
                模組編碼 = txtModuleCode.Text,
                模組名稱 = txtModuleName.Text,
                任務分類 = cboTaskCategory.SelectedValue?.ToString(),
                成效點數 = float.TryParse(txtScore.Text, out var score) ? score : (float?)null,
                工作項目 = txtWorkItem.Text,
                組裝零件 = txtAssemblyPart.Text,
                進度 = float.TryParse(txtProgress.Text, out var progress) ? progress : (float?)null,
                本日工時 = txtTodayHours.Text,
                特別註記 = txtRemark.Text,
                工作簡述 = txtSummary.Text,
            };

            var rep = new HRController().SaveUpdateJournal(log);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
