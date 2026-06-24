using Dapper;
using DigiERP.Common;
using DigiERP.Forms.Customer;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.UserControl.Customer.Quotation;
using MES.Core;
using MES.Core.Model;
using MES.MiddleWare;
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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiERP.UserControl.Customer.EQPCSustService
{
    public partial class EQPCustServiceMaintainControl : CommonUserControl
    {
        internal C機台客服 form;
        private CustomerController _customerController { get; set; }
        private ProductionController _productionController { get; set; }
        public EQPCustServiceMaintainControl()
        {
            InitializeComponent();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            if (_productionController == null)
            {
                _productionController = new ProductionController();
            }
        }
        private C客戶設定 _customer { get; set; }
        internal void initForm()
        {
            initController();
            initControls();
            SetMType(form.機台類型);
            if (lblMode.Text == "修改")
            {
                cboCustId.Items.Add(form.客戶簡稱 ?? "");
                cboCustId.Text = form.客戶簡稱;
                var customerRep = _customerController.getCustomerList(form.客戶簡稱 ?? "");
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                _customer = customerRep.resultList.FirstOrDefault() ?? new C客戶設定();
                if (_customer != null)
                {
                    txtCompany.Text = _customer.COMPANY;
                }
                if (!string.IsNullOrEmpty(form.日期))
                {
                    try
                    {
                        dtORDERDATE.Value = DateTime.Parse(form.日期);
                    }
                    catch { }
                }
                txtOrderNo.Text = form.單號;
                txtDescription.Text = form.描述;
                cboProjectSerial.Text = form.專案序號;
                txtEQPNo.Text = form.機台型號;
                txtEQPName.Text = form.機台名稱;
                initGrid();
                disableAllControls(true);
            }
            else if (lblMode.Text == "新增")
            {
                var orderNoRep = _customerController.GetEqpCustServiceNo();
                if (!string.IsNullOrEmpty(orderNoRep.ErrorMessage)) { MessageBox.Show(orderNoRep.ErrorMessage); return; }
                txtOrderNo.Text = orderNoRep.result;
                dtORDERDATE.Value = DateTime.Now;
                disableAllControls(false);
            }
        }

        private void initGrid()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            var formRep = _customerController.GetEqpCustServiceList("", form.單號);
            if (!string.IsNullOrEmpty(formRep.ErrorMessage))
            {
                MessageBox.Show(formRep.ErrorMessage);
                return;
            }
            form = formRep.resultList.FirstOrDefault() ?? new C機台客服();
            foreach (var item in form.detailList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                DateTime now = DateTime.Now;
                DateTime.TryParse(item.日期, out now);
                row.Cells[index++].Value = now.ToString("yyyy/MM/dd");
                row.Cells[index++].Value = item.客戶反映;
                row.Cells[index++].Value = item.公司回覆;
                row.Cells[index++].Value = item.聯絡者;
                row.Cells[index++].Value = item.執行者;
                row.Cells[index++].Value = item.業務紀錄;
                row.Cells[index++].Value = item.客訴單號;
                row.Cells[index++].Value = item.報價單號;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void disableAllControls(bool disable)
        {
            var enable = !disable;
            cboCustId.Enabled = enable;
            txtDescription.Enabled = enable;
            cboProjectSerial.Enabled = enable;
            dtEQPShippingDate.Enabled = enable;
            cboCustContact.Enabled = enable;
            cboMType.Enabled = enable;
            txtEQPNo.Enabled = enable;
            txtEQPName.Enabled = enable;
            cbo機款.Enabled = enable;
            cbo機種.Enabled = enable;
            cbo機種分類.Enabled = enable;
            cbo問題歸類.Enabled = enable;
            cbo狀況.Enabled = enable;
            dataGridView1.Enabled = enable;
            //throw new NotImplementedException();
        }

        private void initControls()
        {
            initProjectCbo();
            initEqpShippingOrderTxt();
            initCustContact();
            initEQPKeywordList();
        }

        private void initEQPKeywordList()
        {
            init("機款", cbo機款, form.Keywords1 ?? "");
            init("機種", cbo機種, form.Keywords2 ?? "");
            initDetail("機種分類", cbo機種分類, form.Keywords5);
            init("問題", cbo問題歸類, form.Keywords3 ?? "");
            init("狀況", cbo狀況, form.Keywords4 ?? "");
            //throw new NotImplementedException();
        }

        private void initDetail(string type, CommonComboBox comboBox, string? value)
        {
            //throw new NotImplementedException();//SELECT 查修關鍵次分類查詢.類別 FROM 查修關鍵次分類查詢; 
            CommonRep<string> keywords = _productionController.GetKeywordDetail(type);
            if (!string.IsNullOrEmpty(keywords.ErrorMessage))
            {
                MessageBox.Show(keywords.ErrorMessage);
                return;
            }
            comboBox.Items.Clear();
            foreach (var item in keywords.resultList)
            {
                comboBox.Items.Add(item);
            }
            comboBox.Text = value;
        }

        private void init(string type, CommonComboBox comboBox, string value)
        {
            CommonRep<string> keywords = _productionController.GetKeyword(type);
            if (!string.IsNullOrEmpty(keywords.ErrorMessage))
            {
                MessageBox.Show(keywords.ErrorMessage);
                return;
            }
            comboBox.Items.Clear();
            foreach (var item in keywords.resultList)
            {
                comboBox.Items.Add(item);
            }
            comboBox.Text = value;
        }

        private void initCustContact()
        {
            CommonRep<C客戶連絡人清單> commonRep = _customerController.GetCustContactList(form.客戶簡稱);
            if (!string.IsNullOrEmpty(cboCustId.Text))
            {
                commonRep = _customerController.GetCustContactList(cboCustId.Text);
            }
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            cboCustContact.Items.Clear();
            foreach (var item in commonRep.resultList)
            {
                cboCustContact.Items.Add(item.姓名);
            }
            if (!string.IsNullOrEmpty(form?.專案人員))
            {
                if (cboCustContact.Items.IndexOf(form?.專案人員) == -1)
                {
                    cboCustContact.Items.Add(form?.專案人員);
                }
                cboCustContact.Text = form?.專案人員;
            }
            //throw new NotImplementedException();
        }

        專案機台交貨單 projShpOrd = null;
        private void initEqpShippingOrderTxt()
        {
            CommonRep<專案機台交貨單> projShippiingOrder = _productionController.GetProjectShippingOrder(form?.專案序號 ?? "");
            if (!string.IsNullOrEmpty(projShippiingOrder.ErrorMessage))
            {
                MessageBox.Show(projShippiingOrder.ErrorMessage);
                return;
            }
            if (projShippiingOrder.resultList.FirstOrDefault() != null)
            {
                projShpOrd = projShippiingOrder.resultList.FirstOrDefault();
                var eqpShippingDate = projShpOrd?.日期;
                if (!string.IsNullOrEmpty(eqpShippingDate))
                {
                    try
                    {
                        dtEQPShippingDate.Value = DateTime.Parse(eqpShippingDate);
                    }
                    catch { }
                }
            }
            //throw new NotImplementedException();
        }

        private void initProjectCbo()
        {
            initController();
            CommonRep<工令單> workOrder = _productionController.GetWorkOrdersByCustId(form?.客戶簡稱 ?? "");
            if (!string.IsNullOrEmpty(workOrder.ErrorMessage))
            {
                MessageBox.Show(workOrder.ErrorMessage);
                return;
            }
            cboProjectSerial.Items.Clear();
            foreach (var item in workOrder.resultList)
            {
                cboProjectSerial.Items.Add(item.專案序號 ?? "");
            }
            if (form != null)
            {
                cboProjectSerial.Text = form.專案序號;
            }
        }

        FrmCustSelect popup;
        private void cboCustId_Leave(object sender, EventArgs e)
        {
            if (popup != null)
            {
                popup.Dispose();
                popup.Close();
            }
        }

        private void cboCustId_Enter(object sender, EventArgs e)
        {

        }

        private void cboCustId_MouseClick(object sender, MouseEventArgs e)
        {
            popup = new FrmCustSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
                txtCompany.Text = popup.CustName;
            }
        }

        private void cboCustId_MouseLeave(object sender, EventArgs e)
        {
            cboCustId_Leave(null, null);
        }

        private void SetMType(string? mTYPE)
        {
            CommonRep<A機台類型> commonRep = _customerController.GetEqpType();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            cboMType.DataSource = commonRep.resultList;
            cboMType.DisplayMember = "TYPEID";
            cboMType.ValueMember = "TYPEID";
            foreach (var item in commonRep.resultList)
            {
                if (((A機台類型)item).TYPEID == mTYPE)
                {
                    cboMType.SelectedItem = item;
                    cboMType.Text = item.TYPEID;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }

        private void cbo機種_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCbo機種分類List();
        }

        private void changeCbo機種分類List()
        {
            cbo機種分類.Items.Clear();
            var 機種分類rep = _productionController.GetKeywordDetailByCategory(cbo機種.Text);
            if (!string.IsNullOrEmpty(機種分類rep.ErrorMessage))
            {
                MessageBox.Show(機種分類rep.ErrorMessage);
                return;
            }
            foreach (var item in 機種分類rep.resultList)
            {
                cbo機種分類.Items.Add(item);
            }
            //throw new NotImplementedException();
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (lblMode.Text == "新增")
            {
                var saveRep = _customerController.SaveEQPCustService(form);
                if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
                {
                    MessageBox.Show(saveRep.ErrorMessage);
                    return;
                }
            }
            else if (lblMode.Text == "修改")
            {
                var saveRep = _customerController.UpdateEQPCustService(form);
                if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
                {
                    MessageBox.Show(saveRep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnClose_Click(null, null);
        }

        private void CollectUserInput()
        {
            form.單號 = txtOrderNo.Text;
            form.客戶簡稱 = cboCustId.Text;
            form.日期 = dtORDERDATE.Value.ToString("yyyy.MM/dd");
            form.描述 = txtDescription.Text;
            form.專案序號 = cboProjectSerial.Text;
            form.機台類型 = cboMType.SelectedValue?.ToString();
            form.機台名稱 = txtEQPName.Text;
            form.Keywords1 = cbo機款.Text;
            form.Keywords2 = cbo機種.Text;
            form.Keywords5 = cbo機種分類.Text;
            form.Keywords3 = cbo問題歸類.Text;
            form.Keywords4 = cbo狀況.Text;
            if (form.detailList == null)
                form.detailList = new List<C機台客服明細>();
            form.detailList.Clear();
            int index = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                index = 0;
                C機台客服明細 detail = new C機台客服明細();
                detail.日期 = row.Cells[index++].Value.ToString();
                detail.客戶反映 = row.Cells[index++].Value.ToString();
                detail.單號 = form.單號;
                detail.公司回覆 = row.Cells[index++].Value.ToString();
                detail.聯絡者 = row.Cells[index++].Value?.ToString();
                detail.執行者 = row.Cells[index++].Value?.ToString();
                detail.業務紀錄 = row.Cells[index++].Value?.ToString();
                detail.客訴單號 = row.Cells[index++].Value?.ToString();
                detail.報價單號 = row.Cells[index++].Value?.ToString();
                form.detailList.Add(detail);
            }
            //throw new NotImplementedException();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // 排除表頭

            // 判斷是否為指定欄位
            if (dataGridView1.Columns[e.ColumnIndex].Name == "repairNo")
            {
                string value = dataGridView1.Rows[e.RowIndex]
                                            .Cells[e.ColumnIndex]
                                            .Value?.ToString();

                if (string.IsNullOrEmpty(value))
                {
                    if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //TO-DO 產生維修單
                        //var repariNoRep = _customerController.GetRepairFormNo();
                        //if (!string.IsNullOrEmpty(repariNoRep.ErrorMessage))
                        //{
                        //    MessageBox.Show(repariNoRep.ErrorMessage);
                        //    return;
                        //}
                        //dataGridView1.Rows[e.RowIndex]
                        //                    .Cells[e.ColumnIndex]
                        //                    .Value = repariNoRep.result;
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "quotation")
            {
                string value = dataGridView1.Rows[e.RowIndex]
                                            .Cells[e.ColumnIndex]
                                            .Value?.ToString();

                if (string.IsNullOrEmpty(value))
                {
                    if (MessageBox.Show("是否確認產生報價單?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //TO-DO 產生報價單
                        var quotationFormRep = _customerController.GenerateQuotationFromRepair(form, cboCustId.Text, txtOrderNo.Text);
                        if (!string.IsNullOrEmpty(quotationFormRep.ErrorMessage))
                        {
                            MessageBox.Show(quotationFormRep.ErrorMessage);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("新增完成");
                        }
                        var theCustRep = _customerController.getCustomerList(form.客戶簡稱 ?? "");
                        if (!string.IsNullOrEmpty(theCustRep.ErrorMessage))
                        {
                            MessageBox.Show(theCustRep.ErrorMessage);
                            return;
                        }
                        var cust = theCustRep.resultList.FirstOrDefault() ?? new C客戶設定();
                        dataGridView1.Rows[e.RowIndex]
                                            .Cells[e.ColumnIndex]
                                            .Value = quotationFormRep.result.QUONO;
                        QuotationMaintain quotationMaintain = new QuotationMaintain();
                        quotationMaintain.form = quotationFormRep.result;
                        quotationMaintain.SetCustNo(cust.正航編號 ?? "");
                        quotationMaintain.SetCustAlias(cust.欄位2 ?? "");
                        quotationMaintain.lblMode.Text = "修改";
                        quotationMaintain.initForm();
                        quotationMaintain.Dock = DockStyle.Fill;
                        TabPage tabPage = new TabPage();
                        tabPage.Controls.Add(quotationMaintain);
                        tabPage.Name = "產品報價";
                        tabPage.Text = "產品報價";
                        tabPage.Dock = DockStyle.Fill;
                        findParendTabControlAdd(this.Parent, tabPage);
                    }
                }
            }
        }

        private void findParendTabControlAdd(Control thisCtrl, TabPage tabPage)
        {
            if (thisCtrl == null)
                return;
            if (thisCtrl.GetType().Name.IndexOf("TabControl") != -1)
            {
                thisCtrl.Controls.Add(tabPage);
            }
            else
            {
                findParendTabControlAdd(thisCtrl.Parent, tabPage);
            }
            //throw new NotImplementedException();
        }

        private void btn新增機台服務紀錄_Click(object sender, EventArgs e)
        {
            var custRep = _customerController.getCustomerList(cboCustId.Text);
            if (!string.IsNullOrEmpty(custRep.ErrorMessage))
            {
                MessageBox.Show(custRep.ErrorMessage);
                return;
            }
            var customer = custRep.resultList.FirstOrDefault() ?? new C客戶設定();
            FrmRfqWorkRecord frmRfqWorkRecord = new FrmRfqWorkRecord();
            frmRfqWorkRecord.source = "機台客服明細";
            frmRfqWorkRecord.SetProjSerial(cboProjectSerial.Text);
            frmRfqWorkRecord.SetModuleName(txtOrderNo.Text);
            frmRfqWorkRecord.SetCustomer(customer);
            frmRfqWorkRecord.ShowDialog();
            initGrid();
        }

        private void EQPCustServiceMaintainControl_Load(object sender, EventArgs e)
        {

        }

        private void cboCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            initCustContact();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Name = "機台服務歷程";
            tabPage.Text = tabPage.Name;

            CommonRep<工令單> workOrderRep = _productionController.GetWorkOrdersByProjSerial( cboProjectSerial.Text);
            工令單 workOrder = new 工令單();
            if (!string.IsNullOrEmpty(workOrderRep.ErrorMessage))
            {
                MessageBox.Show(workOrderRep.ErrorMessage);
                return;
            }
            workOrder = workOrderRep.result;
            if (string.IsNullOrEmpty(workOrder.專案序號))
            {
                MessageBox.Show($"找不到與此專案序號:{cboProjectSerial.Text} 相關之工令單");
                return;
            }
            EQPServiceHistoryControl eQPServiceHistoryControl = new EQPServiceHistoryControl();
            eQPServiceHistoryControl.Dock = DockStyle.Fill;
            eQPServiceHistoryControl.form = workOrder;
            eQPServiceHistoryControl.initForm();
            tabPage.Controls.Add(eQPServiceHistoryControl);
            findParendTabControlAdd(this.Parent, tabPage);
        }
    }
}
