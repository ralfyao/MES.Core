using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.Repair
{
    public partial class RepairFormMaintainControl : CommonUserControl
    {
        // 此模組（維修服務單）先前完全沒有註冊權限 GUID，此為新建立，需在權限管理畫面另行設定「編修」權限
        private static string id = "B3E7A159-6D2C-4F84-9A1E-7C5D3B6F8A92";

        public 維修服務單 form { get; set; }
        private CustomerController _customerController;
        private List<成本單位人員配置> _inspectorList;
        FrmCustSelect popup;

        public RepairFormMaintainControl()
        {
            InitializeComponent();
            initController();
        }

        private void initController()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
        }

        internal void initForm()
        {
            initController();
            initInspectorCbo();
            initReasonCbo();

            if (lblMode.Text == "新增")
            {
                CommonRep<string> noRep = _customerController.GetRepairFormNo();
                if (!string.IsNullOrEmpty(noRep.ErrorMessage))
                {
                    MessageBox.Show(noRep.ErrorMessage);
                    return;
                }
                txtFormNo.Text = noRep.result;
                dtApplyDate.Value = DateTime.Now;
                dtDesiredDate.Value = DateTime.Now.AddDays(7);
                dtActualDate.Value = DateTime.Now;
                dtCloseDate.Value = DateTime.Now;
                dtActualDate.Enabled = false;
                dtCloseDate.Enabled = false;
                txtServiceHours.Text = "0";
                chkTransferParts.Enabled = false;
                btnTransferParts.Enabled = false;
                btnApprove.Visible = false;
                btnCancelApprove.Visible = false;
                btnDelete.Visible = false;
                btnModify.Visible = false;
                disableControls(true);
            }
            else if (lblMode.Text == "修改")
            {
                GetFormData();
                // 修改模式：客戶簡稱、名稱、申請日期不可變更
                txtCustId.ReadOnly = true;
                txtCustId.BackColor = Color.LightGray;
                txtCustName.ReadOnly = true;
                txtCustName.BackColor = Color.LightGray;
                dtApplyDate.Enabled = false;
                btnCustLookup.Visible = false;
                txtCustId.MouseClick -= txtCustId_MouseClick;
                if (string.IsNullOrEmpty(form.核准日))
                {
                    btnApprove.Visible = true;
                    btnCancelApprove.Visible = false;
                }
                else
                {
                    btnApprove.Visible = false;
                    btnCancelApprove.Visible = true;
                }
                btnTransferParts.Enabled = form.轉零件申請 != true;
                disableControls(false);
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
            }
        }

        // ── 除客戶簡稱/名稱/申請日期(恆不可變更)外，其餘欄位依 enable 切換 ──
        private void disableControls(bool enable)
        {
            txtEqpModel.Enabled = enable;
            cboInspectorCode.Enabled = enable;
            txtProjectSerial.Enabled = enable;
            txtEqpType.Enabled = enable;
            txtEqpName.Enabled = enable;
            cboServiceType.Enabled = enable;
            dtActualDate.Enabled = enable;
            txtCustContact.Enabled = enable;
            txtRepairLocation.Enabled = enable;
            txtFaultDesc.Enabled = enable;
            dtDesiredDate.Enabled = enable;
            dtCloseDate.Enabled = enable;
            txtServiceHours.Enabled = enable;
            txtDiagnosis1.Enabled = enable;
            cboReason1.Enabled = enable;
            txtDesc1.Enabled = enable;
            txtRecommendation.Enabled = enable;
            txtCustomerReaction.Enabled = enable;
            btnSave.Enabled = enable;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        private void initInspectorCbo()
        {
            CommonRep<成本單位人員配置> rep = _customerController.get組測維修人員List();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _inspectorList = rep.resultList ?? new List<成本單位人員配置>();

            cboInspectorCode.Items.Clear();
            cboInspectorCode.Items.Add("");
            foreach (var p in _inspectorList)
                cboInspectorCode.Items.Add(p.員工編號 ?? "");

            // 設定目前值
            cboInspectorCode.Text = form?.維修檢查人員 ?? "";
            SyncInspectorName();
        }

        private void SyncInspectorName()
        {
            var code = cboInspectorCode.Text;
            var person = _inspectorList?.FirstOrDefault(p => p.員工編號 == code);
            txtInspectorName.Text = person?.姓名 ?? "";
        }

        private void cboInspectorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncInspectorName();
        }

        private void initReasonCbo()
        {
            CommonRep<客訴及維修原因類別> rep = _customerController.CARRepairReasonList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var reasons = rep.resultList;
            var emptyItem = new 客訴及維修原因類別 { 原因類別 = "" };
            var source = new List<客訴及維修原因類別> { emptyItem };
            source.AddRange(reasons);

            cboReason1.DataSource = new List<客訴及維修原因類別>(source);
            cboReason1.DisplayMember = "原因類別";
            cboReason1.ValueMember = "原因類別";
        }

        private static string FmtDate(string s)
        {
            if (DateTime.TryParse(s, out DateTime d)) return d.ToString("yyyy/MM/dd");
            return s ?? "";
        }

        private void GetFormData()
        {
            txtFormNo.Text = form.單號 ?? "";
            try { dtApplyDate.Value = DateTime.Parse(form.申請日期 ?? DateTime.Now.ToString("yyyy/MM/dd")); } catch { dtApplyDate.Value = DateTime.Now; }
            cboInspectorCode.Text = form.維修檢查人員 ?? "";
            SyncInspectorName();
            cboServiceType.Text = form.服務型態 ?? "";
            txtCustId.Text = form.客戶簡稱 ?? "";
            txtCustName.Text = form.客戶名稱 ?? "";
            txtProjectSerial.Text = form.專案序號 ?? "";
            txtEqpModel.Text = form.機台型號 ?? "";
            txtEqpType.Text = form.機台類型 ?? "";
            txtEqpName.Text = form.機台名稱 ?? "";
            txtCustContact.Text = form.客戶聯絡窗口 ?? "";
            txtRepairLocation.Text = form.維修地點 ?? "";
            try { dtDesiredDate.Value = DateTime.Parse(form.希望服務日期 ?? DateTime.Now.ToString("yyyy/MM/dd")); } catch { dtDesiredDate.Value = DateTime.Now; }
            try { dtActualDate.Value = DateTime.Parse(form.實際服務日期 ?? DateTime.Now.ToString("yyyy/MM/dd")); } catch { dtActualDate.Value = DateTime.Now; }
            try { dtCloseDate.Value = DateTime.Parse(form.維修結案日期 ?? DateTime.Now.ToString("yyyy/MM/dd")); } catch { dtCloseDate.Value = DateTime.Now; }
            txtFaultDesc.Text = form.故障情形 ?? "";
            txtRecommendation.Text = form.處置建議 ?? "";
            txtPartsWorkOrder.Text = form.零件工令編號 ?? "";
            txtCustomerReaction.Text = form.客戶反應 ?? "";
            txtServiceHours.Text = form.維修服務時數?.ToString() ?? "0";
            chkTransferParts.Checked = form.轉零件申請 ?? false;

            txtDiagnosis1.Text = form.原因鑑定1 ?? "";
            cboReason1.Text = form.原因類別1 ?? "";
            txtDesc1.Text = form.簡要描述1 ?? "";
        }

        private void CollectUserInput()
        {
            form.單號 = txtFormNo.Text;
            form.申請日期 = dtApplyDate.Value.ToString("yyyy/MM/dd");
            form.維修檢查人員 = cboInspectorCode.Text;
            form.服務型態 = cboServiceType.Text;
            form.客戶簡稱 = txtCustId.Text;
            form.客戶名稱 = txtCustName.Text;
            form.專案序號 = txtProjectSerial.Text;
            form.機台型號 = txtEqpModel.Text;
            form.機台類型 = txtEqpType.Text;
            form.機台名稱 = txtEqpName.Text;
            form.客戶聯絡窗口 = txtCustContact.Text;
            form.維修地點 = txtRepairLocation.Text;
            form.希望服務日期 = dtDesiredDate.Value.ToString("yyyy/MM/dd");
            form.實際服務日期 = dtActualDate.Value.ToString("yyyy/MM/dd");
            form.維修結案日期 = dtCloseDate.Value.ToString("yyyy/MM/dd");
            form.故障情形 = txtFaultDesc.Text;
            form.處置建議 = txtRecommendation.Text;
            form.零件工令編號 = txtPartsWorkOrder.Text;
            form.客戶反應 = txtCustomerReaction.Text;
            form.維修服務時數 = int.TryParse(txtServiceHours.Text, out int hrs) ? hrs : 0;
            form.轉零件申請 = chkTransferParts.Checked;
            form.原因鑑定1 = txtDiagnosis1.Text;
            form.原因類別1 = cboReason1.Text;
            form.簡要描述1 = txtDesc1.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CollectUserInput();

            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<維修服務單> rep = _customerController.SaveRepairTest(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
                CommonRep<維修服務單> rep = _customerController.UpdateRepairTest(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnBack_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要刪除維修服務單 {form.單號} 嗎?", "確認刪除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            CommonRep<維修服務單> rep = _customerController.DeleteRepairTest(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            btnBack_Click(null, null);
        }

        private void btnTransferParts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(form.單號))
            {
                MessageBox.Show("請先儲存維修服務單後再轉零件申請!");
                return;
            }
            if (MessageBox.Show($"確定要將 {form.單號} 轉零件申請單嗎?", "確認轉單",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            CollectUserInput();
            CommonRep<string> rep = _customerController.TransferRepairTo零件申請單(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("轉零件申請單成功!");
            form.零件工令編號 = rep.result;
            form.轉零件申請 = true;
            txtPartsWorkOrder.Text = rep.result;
            chkTransferParts.Checked = true;
            btnOpenPartsOrder.Visible = false;
            btnTransferParts.Enabled = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(form.單號))
            {
                MessageBox.Show("請先儲存維修服務單!");
                return;
            }
            CommonRep<string> rep = _customerController.ValidateRepairForm(form.單號, true, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("核准成功!");
            form.核准 = AppSession.User.username;
            form.核准日 = DateTime.Now.ToString("yyyy/MM/dd");
            btnApprove.Visible = false;
            btnCancelApprove.Visible = true;
        }

        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消核准嗎?", "確認取消核准",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            CommonRep<string> rep = _customerController.ValidateRepairForm(form.單號, false, AppSession.User.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("取消核准成功!");
            form.核准 = null;
            form.核准日 = null;
            btnApprove.Visible = true;
            btnCancelApprove.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                var grid = parentPanel.Controls.OfType<DataGridView>().FirstOrDefault();
                if (grid != null)
                    grid.Visible = true;
                parentPanel.Controls.Remove(this);
            }
        }

        private void btnCustLookup_Click(object sender, EventArgs e)
        {
            OpenCustSelectPopup();
        }

        private void txtCustId_MouseClick(object sender, MouseEventArgs e)
        {
            if (!txtCustId.ReadOnly)
                OpenCustSelectPopup();
        }

        private void OpenCustSelectPopup()
        {
            popup = new FrmCustSelect();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;
            var location = txtCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtCustId.Text = popup.CustId;
                txtCustName.Text = popup.CustName;
            }
        }
    }
}
