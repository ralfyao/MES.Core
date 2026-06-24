using DigiERP.Common;
using DigiERP.UserControl.Customer.Quotation;
using MES.Core;
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

namespace DigiERP.UserControl.Customer.EQPCSustService
{
    public partial class EQPCustServiceControl : CommonUserControl
    {
        private CustomerController _customerController;
        private string id = "1fdcb68d-91be-48a4-9b21-e8e1c7c6a565";
        public EQPCustServiceControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initGrid()
        {
            var eqpCustServList = _customerController.GetEqpCustServiceList();
            if (!string.IsNullOrEmpty(eqpCustServList.ErrorMessage))
            {
                MessageBox.Show(eqpCustServList.ErrorMessage);
                return;
            }
            int index = 0;
            foreach (var item in eqpCustServList.resultList)
            {
                index = 0;
                var customerRep = _customerController.getCustomerList(item.客戶簡稱);
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                var customer = customerRep.resultList.FirstOrDefault();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item?.單號 ?? "";
                row.Cells[index++].Value = Utility.ConvertDate(item?.日期 ?? "1900-01-01");
                row.Cells[index++].Value = item?.客戶簡稱 ?? "";
                row.Cells[index++].Value = customer?.COMPANY;
                row.Cells[index++].Value = item?.專案序號 ?? "";
                row.Cells[index++].Value = item?.機台型號 ?? "";
                row.Cells[index++].Value = item?.事件Events ?? "";
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            //throw new NotImplementedException();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;

            var dataGridView = (DataGridView)(from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                C機台客服 data = new C機台客服();
                int index = row1.Cells.Count - 1;
                data.單號 = row1.Cells[0].Value?.ToString();
                data = new CustomerController().GetEqpCustServiceList("", data.單號)?.resultList.FirstOrDefault();

                var customerMaintainControl = (EQPCustServiceMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(EQPCustServiceMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new EQPCustServiceMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                else
                {
                    int ctrlRemoveIndex = 0;
                    int index1 = 0;
                    foreach(var ctrl in panel2.Controls)
                    {
                        if (ctrl.GetType().Name.IndexOf("EQPCustServiceMaintainControl") != -1)
                        {
                            ctrlRemoveIndex = index1;
                            break;
                        }
                        index1++;
                    }
                    panel2.Controls.RemoveAt(index1);
                    customerMaintainControl = new EQPCustServiceMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((EQPCustServiceMaintainControl)customerMaintainControl).form = data;
                ((EQPCustServiceMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(EQPCustServiceMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            //if (customerMaintainControl == null)
            //{
            //if (form != null)
            //{
            //    customerMaintainControl = new EQPCustServiceMaintainControl(form);
            //    //((QuotationMaintain)customerMaintainControl).form = form;
            //}
            //else
            //{
                customerMaintainControl = new EQPCustServiceMaintainControl();
            //}
            customerMaintainControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(customerMaintainControl);
            //}
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((EQPCustServiceMaintainControl)customerMaintainControl).form = new C機台客服();
            ((EQPCustServiceMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }
    }
}
