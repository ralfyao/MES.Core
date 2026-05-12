using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using DigiERP.Models;
using System.Diagnostics.Metrics;
using MES.Core.Model;
using DigiERP.Common;
using Newtonsoft.Json;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using DigiERP.Forms.Customer;

namespace DigiERP.UserControl
{
    public partial class CustomerMaintainControl : CommonUserControl
    {
        public C客戶設定 form { get; set; }
        public CustomerMaintainControl()
        {
            InitializeComponent();
            coutrySelect1.inflateDropDownList();
            initMaList();
            initForm();
            btnSubmit.Text = lblMode.Text;
        }



        public void initForm()
        {
            if (form == null)
                return;
            // 填充form資料到control
            btnSubmit.Text = lblMode.Text;
            txtIdentity.Text = form.識別 == null ? "0" : form.識別.ToString();
            txtCustomerCompany.Text = form.COMPANY;
            txtCustAlias.Text = form.欄位2;
            txtCustNumber.Text = form.正航編號;
            if (!string.IsNullOrEmpty(txtCustNumber.Text))
            {
                btnGenCustNumber.Visible = false;
            }
            coutrySelect1.SetCountryCode(form.COUNTRY);
            cboSource.SelectedValue = form.SOURCE;
            txtContactPersion.Text = form.CONTACTPERSON;
            txtAddress.Text = form.ADDRESS;
            txtDAddress.Text = form.DADDRESS;
            txtTel.Text = form.TEL;
            txtZipcode.Text = form.ZIPCODE;
            txtWebsite.Text = form.WEBSITE;
            txtFax.Text = form.FAX;
            txtEmail.Text = form.EMAIL;
            cboMa.SelectedValue = form.MA;
            txtColumn1.Text = form.欄位1;
            cboIndustrry.SelectedValue = form.INDUSTRY;
            industryCodeSelect1.SetIndustryCode(form.INDUSTRYCODE);
            txtMachineIssue.Text = form.MACHINEISSUE;
            bankCodeSelect1.SetBankCode(form.CREDIBILITY);
            if (!string.IsNullOrEmpty(form.啟用日))
                dtEnableDate.Value = DateTime.Parse(form.啟用日);
            if (!string.IsNullOrEmpty(form.停用日))
            {
                dtDisableDate.Value = DateTime.Parse(form.停用日);
                btnActivate.Visible = true;
                btnInactivate.Visible = false;
            }
            else
            {
                btnActivate.Visible = false;
                btnInactivate.Visible = true;
            }
            txtMemo.Text = form.MEMO;
            lblModifyUser.Text = form.修改;
            lblModifyDate.Text = form.修改日;
            lblCreator.Text = form.建檔;
            lblCreateDate.Text = form.建檔日;
            initDgvContactList(form.contactLists);
            initContactDetail(form.contactDetails);
            if (lblMode.Text == "修改")
            {
                btnQuotationHistory.Visible = true;
                btnShippingRecord.Visible = true;
                btnInquiryHistory.Visible = true;
                btnRecordWrite.Visible = true;
                btnRepairHistory.Visible = true;
                btnDelete.Visible = true;
                button2.Visible = true;
                // 預設為disable，直到按下【修改】按鈕後才變成可編輯
                disableAllControls(true);
            }
            else
            {
                btnQuotationHistory.Visible = false;
                btnShippingRecord.Visible = false;
                btnInquiryHistory.Visible = false;
                btnRecordWrite.Visible = false;
                btnRepairHistory.Visible = false;
                btnDelete.Visible = false;
                button2.Visible = false;
                disableAllControls(false);
            }
        }

        private void disableAllControls(bool isDisable)
        {
            btnSubmit.Enabled = !isDisable;
            btnCompanyChange.Enabled = !isDisable;
            txtIdentity.Enabled = !isDisable;
            txtCustomerCompany.Enabled = !isDisable;
            btnIndustryCodeManage.Enabled = !isDisable;
            txtCustAlias.Enabled = !isDisable;
            txtCustNumber.Enabled = !isDisable;
            btnGenCustNumber.Enabled = !isDisable;
            txtPosition.Enabled = !isDisable;
            txtMemo.Enabled = !isDisable;
            coutrySelect1.Enabled = !isDisable;
            cboSource.Enabled = !isDisable;
            txtContactPersion.Enabled = !isDisable;
            txtAddress.Enabled = !isDisable;
            txtDAddress.Enabled = !isDisable;
            txtWebsite.Enabled = !isDisable;
            txtTel.Enabled = !isDisable;
            txtZipcode.Enabled = !isDisable;
            txtEmail.Enabled = !isDisable;
            cboMa.Enabled = !isDisable;
            txtColumn1.Enabled = !isDisable;
            cboIndustrry.Enabled = !isDisable;
            industryCodeSelect1.Enabled = !isDisable;
            txtMachineIssue.Enabled = !isDisable;
            bankCodeSelect1.Enabled = !isDisable;
            btnActivate.Enabled = !isDisable;
            btnInactivate.Enabled = !isDisable;
        }

        private C客戶設定 GetUserInput()
        {
            C客戶設定 form = new C客戶設定();
            form.識別 = int.Parse(txtIdentity.Text);
            form.COMPANY = txtCustomerCompany.Text;
            form.欄位2 = txtCustAlias.Text;
            form.正航編號 = txtCustNumber.Text;
            form.COUNTRY = coutrySelect1.GetCountryCode();
            form.SOURCE = cboSource.SelectedValue?.ToString();
            form.CONTACTPERSON = txtContactPersion.Text;
            form.ADDRESS = txtAddress.Text;
            form.DADDRESS = txtDAddress.Text;
            form.TEL = txtTel.Text;
            form.ZIPCODE = txtZipcode.Text;
            form.WEBSITE = txtWebsite.Text;
            form.FAX = txtFax.Text;
            form.EMAIL = txtEmail.Text;
            form.MA = cboMa.SelectedValue?.ToString();
            form.欄位1 = txtColumn1.Text;
            form.INDUSTRY = cboIndustrry.SelectedValue?.ToString();
            form.INDUSTRYCODE = industryCodeSelect1.GetIndustryCode();
            form.MACHINEISSUE = txtMachineIssue.Text;
            form.CREDIBILITY = bankCodeSelect1.GetBankCode();

            return form;
        }

        private void initContactDetail(List<C客戶聯絡明細> contactDetails)
        {
            dgvCustIntView.Rows.Clear();
            foreach (var contact in contactDetails)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCustIntView);
                row.Cells[index++].Value = contact.日期;//客戶名稱
                row.Cells[index++].Value = contact.業務人員;//主要聯絡人
                row.Cells[index++].Value = contact.業務人員姓名;
                row.Cells[index++].Value = contact.RFQNO;
                row.Cells[index++].Value = contact.註記;
                dgvCustIntView.Rows.Add(row);
            }
        }

        private void initDgvContactList(List<C客戶連絡人清單> contactLists)
        {
            dgvContactList.Rows.Clear();
            foreach (var contact in contactLists)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvContactList);
                row.Cells[index++].Value = contact.姓名;//客戶名稱
                row.Cells[index++].Value = contact.職稱;//客戶名稱
                row.Cells[index++].Value = contact.EMAIL;//客戶名稱
                dgvContactList.Rows.Add(row);
            }
        }

        private void initMaList()
        {
            List<TextValue> maList = new List<TextValue>();
            string json = File.ReadAllText(@".\cAgent.json");
            maList = System.Text.Json.JsonSerializer.Deserialize<List<TextValue>>(json);
            cboIndustrry.DataSource = maList;
            cboIndustrry.DisplayMember = "Text";
            cboIndustrry.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
            coutrySelect1.SetCountryCode(string.Empty);
        }

        private void lblCreator_Click(object sender, EventArgs e)
        {

        }
        private Color backgroundColor;
        private void txtCustomerCompany_Enter(object sender, EventArgs e)
        {
            //backgroundColor = txtCustomerCompany.BackColor;
            //txtCustomerCompany.BackColor = Color.Yellow;
        }

        private void txtCustomerCompany_Leave(object sender, EventArgs e)
        {
            //txtCustomerCompany.BackColor = backgroundColor;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            C客戶設定 form = GetUserInput();
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶設定> response = null;
            if (lblMode.Text == "新增")
            {
                response = customerController.SaveCustomer(form);
                if (response.ErrorMessage == "")
                {
                    MessageBox.Show("新增成功");
                    this.Visible = false;
                    var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
                    if (dataGridView != null)
                    {
                        dataGridView.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("新增失敗:" + response.ErrorMessage);
                }
            }
            else
            {
                response = customerController.UpdateCustomer(form);
                if (response.ErrorMessage == "")
                {
                    MessageBox.Show("更新成功");
                    this.Visible = false;
                    var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
                    if (dataGridView != null)
                    {
                        dataGridView.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("更新失敗:" + response.ErrorMessage);
                }
            }
        }

        private void btnGenCustNumber_Click(object sender, EventArgs e)
        {
            CustomerController customerController = new CustomerController();
            if (string.IsNullOrEmpty(coutrySelect1.GetCountryCode()))
            {
                MessageBox.Show("國別不可為空!");
                return;
            }
            string custNo = customerController.CustNo(coutrySelect1.GetCountryCode()).result;
            txtCustNumber.Text = custNo;
        }

        private void btnCompanyChange_Click(object sender, EventArgs e)
        {
            using (FrmChangeCustName frmChangeCustName = new FrmChangeCustName())
            {
                frmChangeCustName.SetOriginalName(txtCustomerCompany.Text);
                frmChangeCustName.ShowDialog();
                txtCustomerCompany.Text = frmChangeCustName.GetChangedName();
                frmChangeCustName.Dispose();
                frmChangeCustName.Close();
            }
        }

        private void btnInactivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認要停用?", "確認", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                CustomerController customerController = new CustomerController();
                CommonRep<C客戶設定> commonRep = customerController.UpdateCustomerExpiry(new C客戶設定() { 識別 = int.Parse(txtIdentity.Text), 停用日 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                if (string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show("停用成功");
                    dtDisableDate.Value = DateTime.Now;
                    btnActivate.Visible = true;
                    btnInactivate.Visible = false;
                }
                else
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認要取消停用?", "確認", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                CustomerController customerController = new CustomerController();
                CommonRep<C客戶設定> commonRep = customerController.UpdateCustomerExpiry(new C客戶設定() { 識別 = int.Parse(txtIdentity.Text), 停用日 = "" });
                if (string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show("取消停用成功");
                    dtDisableDate.Value = DateTime.Parse("1900-01-01");
                    btnActivate.Visible = false;
                    btnInactivate.Visible = true;
                }
                else
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認刪除?", "確認", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                CustomerController customerController = new CustomerController();
                CommonRep<C客戶設定> commonRep = customerController.DeleteCustomer(new C客戶設定() { 識別 = int.Parse(txtIdentity.Text) });
                if (string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show("刪除成功!");
                }
                else
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                }
                button1_Click(sender, e);
            }
        }

        private void btnShippingRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnRepairHistory_Click(object sender, EventArgs e)
        {
            FrmCustEqpList frmCustEqpList = new FrmCustEqpList();
            frmCustEqpList.SetCustNo(txtCustNumber.Text);
            frmCustEqpList.SetCustAlias(txtCustAlias.Text);
            frmCustEqpList.SetCustName(txtCustomerCompany.Text);
            frmCustEqpList.initCustInfo();
            frmCustEqpList.ShowDialog();
        }


        private void btnQuotationHistory_Click_1(object sender, EventArgs e)
        {
            FrmCustQuotList frmCustEqpList = new FrmCustQuotList();
            frmCustEqpList.SetCustNo(txtCustNumber.Text);
            frmCustEqpList.SetCustAlias(txtCustAlias.Text);
            frmCustEqpList.SetCustName(txtCustomerCompany.Text);
            frmCustEqpList.initCustInfo();
            frmCustEqpList.ShowDialog();
        }

        private void btnInquiryHistory_Click(object sender, EventArgs e)
        {
            FrmCustRfqtList frmCustEqpList = new FrmCustRfqtList();
            frmCustEqpList.SetCustNo(txtCustNumber.Text);
            frmCustEqpList.SetCustAlias(txtCustAlias.Text);
            frmCustEqpList.SetCustName(txtCustomerCompany.Text);
            frmCustEqpList.initCustInfo();
            frmCustEqpList.ShowDialog();
        }

        private void btnRecordWrite_Click(object sender, EventArgs e)
        {
            FrmRfqWorkRecord frmRfqWorkRecord = new FrmRfqWorkRecord();
            frmRfqWorkRecord.SetCustomer(form);
            frmRfqWorkRecord.initCustInfo();
            frmRfqWorkRecord.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
        }

        private void btnIndustryCodeManage_Click(object sender, EventArgs e)
        {
            FrmIndustryManage frmIndustryManage = new FrmIndustryManage();
            frmIndustryManage.ShowDialog();
        }
    }
}
