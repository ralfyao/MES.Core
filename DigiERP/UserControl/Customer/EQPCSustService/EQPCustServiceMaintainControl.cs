using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
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
            foreach(var item in 機種分類rep.resultList)
            {
                cbo機種分類.Items.Add(item);
            }
            //throw new NotImplementedException();
        }
    }
}
