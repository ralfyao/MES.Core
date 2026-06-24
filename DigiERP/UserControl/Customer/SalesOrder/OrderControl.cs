using DigiERP.Common;
using DigiERP.Models;
using DigiERP.UserControl.Customer.EQPCSustService;
using DigiERP.UserControl.Customer.Quotation;
using DigiERP.UserControl.Customer.SalesOrder;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.SalesOrder
{
    public partial class OrderControl : CommonUserControl
    {
        public string custId { get; set; }
        private CustomerController _customerController;
        private static string id = "A29F4CAB-2932-49A3-89E7-034A60700FAD";
        public OrderControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            initData();
        }
        private void initData()
        {
            // 初始化列表資料
            CommonRep<C訂單> commonRep = _customerController.GetSalesOrderList();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            initGrid(commonRep.resultList);
            // 初始化國別下拉選單資料
            CommonRep<C客戶國別> commonRep1 = _customerController.getCountryList();
            if (!string.IsNullOrEmpty(commonRep1.ErrorMessage))
            {
                MessageBox.Show(commonRep1.ErrorMessage);
                return;
            }
            commonRep1.resultList.Insert(0, new C客戶國別() { CODE = "", 國別 = "" });
            cboCountry.DataSource = commonRep1.resultList;
            cboCountry.DisplayMember = "國別";
            cboCountry.ValueMember = "國別";
        }

        private void initGrid(List<C訂單> list)
        {

            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (var item in list)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.客戶全稱;
                row.Cells[index++].Value = item.指配國別;
                row.Cells[index++].Value = item.訂單總額加總();
                row.Cells[index++].Value = item.要望日期;
                row.Cells[index++].Value = item.付款方式;
                row.Cells[index++].Value = item.交貨方式;
                row.Cells[index++].Value = item.價格條件;
                row.Cells[index++].Value = item.業務員;
                row.Cells[index++].Value = item.業務人員;
                row.Cells[index++].Value = item.核准;
                row.Cells[index++].Value = item.結案;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CommonRep<C訂單> commonRep = _customerController.GetSalesOrderList();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            var list = commonRep.resultList;
            if (!string.IsNullOrEmpty(txtCustomer.Text))
            {
                list = list.Where(x => x.客戶全稱 != null && x.客戶全稱?.IndexOf(txtCustomer.Text.Trim()) != -1).ToList();
            }

            if (!string.IsNullOrEmpty(cboCountry.Text))
            {
                list = list.Where(x => x.指配國別 != null && x.指配國別.IndexOf(cboCountry.Text.Trim()) != -1).ToList();
            }
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                list = list.Where(x => x.orderListDetail.Where(xx => xx.產品編號 != null && xx.產品編號.IndexOf(txtItemName.Text.Trim()) != -1).Count() > 0).ToList();
            }
            initGrid(list);
        }
        public C訂單 form;
        public void btnAdd_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(OrderMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            //if (customerMaintainControl == null)
            //{
            if (form != null)
            {
                customerMaintainControl = new OrderMaintainControl(form);
                //((QuotationMaintain)customerMaintainControl).form = form;
            }
            else
            {
                customerMaintainControl = new OrderMaintainControl();
            }
            customerMaintainControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(customerMaintainControl);
            //}
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((OrderMaintainControl)customerMaintainControl).form = new C訂單();
            ((OrderMaintainControl)customerMaintainControl).custId = custId;
            ((OrderMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;
            //panel2.AutoScroll = true;
            //panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            var dataGridView = (DataGridView)(from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                C訂單 data = new C訂單();
                int index = row1.Cells.Count - 1;
                data.單號 = row1.Cells[0].Value?.ToString();
                var tmpdata = new CustomerController().GetSalesOrderListByNo(data.單號).resultList;
                if (tmpdata.Count() > 0)
                {
                    data = tmpdata[0];
                }
                var customerMaintainControl = (OrderMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(OrderMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new OrderMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                else
                {
                    int ctrlRemoveIndex = 0;
                    int index1 = 0;
                    foreach (var ctrl in panel2.Controls)
                    {
                        if (ctrl.GetType().Name.IndexOf("OrderMaintainControl") != -1)
                        {
                            ctrlRemoveIndex = index1;
                            break;
                        }
                        index1++;
                    }
                    panel2.Controls.RemoveAt(ctrlRemoveIndex);
                    customerMaintainControl = new OrderMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((OrderMaintainControl)customerMaintainControl).form = data;
                ((OrderMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                initData();
            }
        }
    }
}
