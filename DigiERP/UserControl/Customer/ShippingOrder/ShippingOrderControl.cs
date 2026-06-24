using DigiERP.Common;
using DigiERP.Models;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.ShippingOrder
{
    public partial class ShippingOrderControl : CommonUserControl
    {
        private static string id = "CF770F40-EA82-4FBF-9D2D-EAD798440F3E";
        private CustomerController _customerController;
        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }
        public ShippingOrderControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            initController();
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                initGridView();
            }
        }

        private void initGridView()
        {
            initController();
            CommonRep<C出貨單> shippingOrderList = _customerController.GetShippingOrderList();
            if (!string.IsNullOrEmpty(shippingOrderList.ErrorMessage))
            {
                MessageBox.Show(shippingOrderList.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in shippingOrderList.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別;
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.客戶簡稱;
                row.Cells[index++].Value = item.客戶名稱;
                row.Cells[index++].Value = item.總額;
                row.Cells[index++].Value = item.原定交貨日期;
                row.Cells[index++].Value = item.付款方式;
                row.Cells[index++].Value = item.交貨方式;
                row.Cells[index++].Value = item.價格條件;
                row.Cells[index++].Value = item.業務員;
                row.Cells[index++].Value = item.業務人員;
                row.Cells[index++].Value = item.核准;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                C出貨單 data = new C出貨單();
                int index = row1.Cells.Count - 1;
                data.單號 = row1.Cells[1].Value?.ToString();
                var tmpdata = new CustomerController().GetShippingOrderList(data.單號).resultList;
                if (tmpdata.Count() > 0)
                {
                    data = tmpdata[0];
                }
                var customerMaintainControl = (ShippingOrderMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(ShippingOrderMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new ShippingOrderMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                else
                {
                    int ctrlRemoveIndex = 0;
                    int index1 = 0;
                    foreach (var ctrl in panel2.Controls)
                    {
                        if (ctrl.GetType().Name.IndexOf("ShippingOrderMaintainControl") != -1)
                        {
                            ctrlRemoveIndex = index1;
                            break;
                        }
                        index1++;
                    }
                    panel2.Controls.RemoveAt(ctrlRemoveIndex);
                    customerMaintainControl = new ShippingOrderMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((ShippingOrderMaintainControl)customerMaintainControl).form = data;
                ((ShippingOrderMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }
        public C出貨單 form;
        public string custId;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(ShippingOrderMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            //if (customerMaintainControl == null)
            //{
            if (form != null)
            {
                customerMaintainControl = new ShippingOrderMaintainControl(form);
                //((QuotationMaintain)customerMaintainControl).form = form;
            }
            else
            {
                customerMaintainControl = new ShippingOrderMaintainControl();
            }
            customerMaintainControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(customerMaintainControl);
            //}
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((ShippingOrderMaintainControl)customerMaintainControl).form = new C出貨單();
            ((ShippingOrderMaintainControl)customerMaintainControl).custId = custId;
            ((ShippingOrderMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }
    }
}
