using DigiERP.Common;
using DigiERP.Forms.Customer;
using DigiERP.UserControl.Common;
using DigiERP.Util;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using OfficeOpenXml.ConditionalFormatting.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.RFQ
{
    public partial class RFQMaintainControl : CommonUserControl
    {
        // 沿用 RFQControl (詢價單列表) 已註冊的權限 GUID
        private static string id = "2D923859-7D2E-4870-90F1-E438086FD583";

        public RFQMaintainControl()
        {
            InitializeComponent();
            ControlUtil.initAgentList(cboAgentList);
            ControlUtil.initIndustryCodeList(industryCodeSelect1);
            ControlUtil.initStatusSelect(rfqStatusSelect1);
        }

        public C客戶詢問函 form { get; set; }
        public List<C報價單> quotationList { get; set; }
        public List<C報價明細> quotationDetail { get; set; }

        private C客戶設定 _cust { get; set; }
        CustomerController customerController = new CustomerController();
        public void initForm()
        {
            if (form == null)
                return;
            if (customerController == null)
                customerController = new CustomerController();
            dtRfqDate.Enabled = false;
            txtRFQNO.Enabled = false;
            if (lblMode.Text == "新增")
            {
                dtRfqDate.Value = DateTime.Now;
                txtRFQNO.Text = customerController.GetRfqNo().result;
                txtCompany.Text = string.Empty;
                txtAlias.Text = string.Empty;
                industryCodeSelect1.SetText("");
                txtTel.Text = string.Empty;
                txtContact.Text = string.Empty;
                txtPosition.Text = string.Empty;
                txtCountry.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMa.Text = string.Empty;
                txtEndUser.Text = string.Empty;
                cboAgentList.Text = string.Empty;
                salesSelect1.SetSalesCode("");
                txtSource.Text = string.Empty;
                cboSuccessRate.Text = string.Empty;
                txtMachine.Text = string.Empty;
                rfqStatusSelect1.SetStatusCode(string.Empty);
                txtComment.Text = string.Empty;
                btnModify.Visible = false;
                btnWorkRecord.Visible = false;
                btnQuotation.Visible = false;
                btnDelete.Visible = false;
                disableControls(false);
            }
            else if (lblMode.Text == "修改")
            {
                _cust = customerController.GetCompany(form.COMPANY).result;
                dtRfqDate.Value = DateTime.Parse(form.RFQDATE);
                txtRFQNO.Text = form.RFQNO;
                txtCompany.Text = form.COMPANY;
                txtAlias.Text = customerController.GetCompany(form.COMPANY).result?.欄位2 ?? "";
                industryCodeSelect1.SetIndustryCode(form.INDUSTRYCODE);
                txtContact.Text = form.CONTACT;
                txtPosition.Text = form.POSITION;
                txtCountry.Text = form.COUNTRY;
                txtEmail.Text = form.EMAIL;
                txtTel.Text = form.TEL;
                txtMa.Text = form.MA;
                txtEndUser.Text = form.ENDUSER;
                cboAgentList.Text = form.AGENT;
                salesSelect1.SetSalesCode(form.SALES);
                txtSource.Text = form.SOURCE;
                cboSuccessRate.Text = form.RANKING;
                txtMachine.Text = form.MACHINE;
                rfqStatusSelect1.SetStatusCode(form.STATUS);
                txtComment.Text = form.DESCRIPTION;
                btnModify.Visible = chkEditPrivilege(id);
                btnWorkRecord.Visible = true;
                btnQuotation.Visible = true;
                btnDelete.Visible = chkEditPrivilege(id);
                disableControls(true);
                initQuotationGridView();
                initWorkRecordGridView();
            }
            //throw new NotImplementedException();
        }

        private void initWorkRecordGridView()
        {
            CommonRep<C詢問函聯絡紀錄> commonRep = customerController.GetSalesWorkRecordList(txtRFQNO.Text);
            dgvWorkRecord.Rows.Clear();
            int index = 0;
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvWorkRecord);
                row.Cells[index++].Value = item.RFQDATE;
                row.Cells[index++].Value = item.DESCRIPTION;
                row.Cells[index++].Value = item.RECALL;
                row.Cells[index++].Value = item.SALES;
                row.Cells[index++].Value = item.姓名;
                dgvWorkRecord.Rows.Add(row);
            }
        }

        private void initQuotationGridView()
        {
            CommonRep<C報價單> commonRep = customerController.GetQuotationList(txtRFQNO.Text);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            dgvQuotation.Rows.Clear();
            int index = 0;
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvQuotation);
                row.Cells[index++].Value = item.QUONO;
                row.Cells[index++].Value = item.QUODATE;
                dgvQuotation.Rows.Add(row);
            }
            // TO-DO init grid view
            //throw new NotImplementedException();
        }

        public void GetUserInput()
        {
            form.COMPANY = txtCompany.Text;
            form.RFQDATE = dtRfqDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            form.RFQNO = txtRFQNO.Text;
            form.COMMISSION = txtCompany.Text;
            form.INDUSTRYCODE = industryCodeSelect1.GetIndustryCode();
            form.CONTACT = txtContact.Text;
            form.POSITION = txtPosition.Text;
            form.COUNTRY = txtCountry.Text;
            form.MA = txtMa.Text;
            form.TEL = txtTel.Text;
            form.EMAIL = txtEmail.Text;
            form.ENDUSER = txtEndUser.Text;
            form.AGENT = cboAgentList.Text;
            form.SALES = salesSelect1.GetSalesCode();
            form.SOURCE = txtSource.Text;
            form.RANKING = cboSuccessRate.Text;
            form.MACHINE = txtMachine.Text;
            form.STATUS = rfqStatusSelect1.GetStatusCode();
            form.DESCRIPTION = txtComment.Text;
        }

        public void disableControls(bool isDisable)
        {
            txtCompany.Enabled = !isDisable;
            txtAlias.Enabled = !isDisable;
            industryCodeSelect1.Enabled = !isDisable;
            txtContact.Enabled = !isDisable;
            txtPosition.Enabled = !isDisable;
            txtCountry.Enabled = !isDisable;
            txtTel.Enabled = !isDisable;
            txtEmail.Enabled = !isDisable;
            txtMa.Enabled = !isDisable;
            txtEndUser.Enabled = !isDisable;
            cboAgentList.Enabled = !isDisable;
            salesSelect1.Enabled = !isDisable;
            txtSource.Enabled = !isDisable;
            cboSuccessRate.Enabled = !isDisable;
            txtMachine.Enabled = !isDisable;
            rfqStatusSelect1.SetEnabled(!isDisable);
            txtComment.Enabled = !isDisable;
        }

        private void RFQMaintainControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }
        C客戶連絡人清單 custContact;
        /// <summary>
        /// 客戶聯絡人欄位移開時，自動去找該聯絡人職位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (customerController == null)
                customerController = new CustomerController();
            custContact = customerController.GetContactList(txtCompany.Text).resultList.Where(x => x.姓名 == txtContact.Text).ToList().FirstOrDefault();
            if (custContact != null)
            {
                txtPosition.Text = custContact.職稱;
                txtCountry.Text = _cust != null ? _cust.COUNTRY : "";
                txtTel.Text = custContact.電話;
            }
        }

        private void txtCompany_Leave(object sender, EventArgs e)
        {
            txtCountry.Text = _cust?.COUNTRY;
            txtMa.Text = _cust?.MA;
            txtSource.Text = _cust?.SOURCE;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(false);
            btnSubmit.Text = "確認修改";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (customerController == null)
            {
                customerController = new CustomerController();
            }
            if (MessageBox.Show($"確認{lblMode.Text}?", "確認", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                GetUserInput();
                CommonRep<C客戶詢問函> commonRep = null;
                if (lblMode.Text == "新增")
                    commonRep = customerController.SaveRfq(form);
                if (lblMode.Text == "修改")
                    commonRep = customerController.UpdateRfq(form);
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                    return;
                }
                else
                {
                    MessageBox.Show("執行成功");
                    var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
                    if (dataGridView != null)
                    {
                        dataGridView.Visible = true;
                    }
                    //this.Dispose();
                    this.Visible = false;
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認刪除?", "確認", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var commonRep = customerController.DeleteRfq(form.RFQNO);
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("執行成功");
                    var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
                    if (dataGridView != null)
                    {
                        dataGridView.Visible = true;
                    }
                    //this.Dispose();
                    this.Visible = false;
                    return;
                }
            }
        }

        private void btnWorkRecord_Click(object sender, EventArgs e)
        {
            FrmRfqWorkRecord frmRfqWorkRecord = new FrmRfqWorkRecord();
            frmRfqWorkRecord.SetPosition("業務");
            frmRfqWorkRecord.SetProjSerial(txtRFQNO.Text);
            frmRfqWorkRecord.SetModuleCode(txtAlias.Text);
            frmRfqWorkRecord.SetModuleName(txtCompany.Text);
            frmRfqWorkRecord.ShowDialog();
        }

        private void dgvQuotation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string quono = dgvQuotation.Rows[e.RowIndex].Cells[0].Value.ToString();
            CommonRep<C報價單> commonRep1 = customerController.GetQuotation(quono);
            if (!string.IsNullOrEmpty(commonRep1.ErrorMessage))
            {
                MessageBox.Show(commonRep1.ErrorMessage);
                return;
            }
            List<C報價明細> commonRep = commonRep1.result.quotationDetailFormList;
            int index = 0;
            dgvQuotationDetail.Rows.Clear();
            foreach (var item in commonRep)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvQuotationDetail);
                row.Cells[index++].Value = item.QUONO;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量;
                row.Cells[index++].Value = item.單價;
                row.Cells[index++].Value = item.單價 * item.數量;
                dgvQuotationDetail.Rows.Add(row);
            }
        }

        private void btnQuotation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定新增報價單?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                C報價單 quotation = new C報價單();
                CommonRep<string> quotationNoRep = customerController.GetQuono();
                if (!string.IsNullOrEmpty(quotationNoRep.ErrorMessage))
                {
                    MessageBox.Show(quotationNoRep.ErrorMessage);
                    return;
                }
                quotation.QUONO = quotationNoRep.result;
                quotation.RFQNO = txtRFQNO.Text;
                quotation.SALES = salesSelect1.GetSalesCode();
                // 先移除先前已開的報價單分頁
                // 取得父Form
                FrmCust frm = this.FindForm() as FrmCust;

                if (frm != null)
                {
                    frm.OpenNewAddQuotationForm(quotation);
                }
            }
        }
    }
}
