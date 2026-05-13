using DigiERP.Common;
using DigiERP.Forms.Customer;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl
{
    public partial class CustomerControl : CommonUserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            initGridView();
            initCountrySelect();
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel2.AutoScroll = true;
            //panel3.AutoScroll = true;
        }

        private void initCountrySelect()
        {
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶國別> commonRep = customerController.getCountryList();
            var list = new List<object>();
            list.Add(new
            {
                國別 = string.Empty,
                CODE = string.Empty,
            });
            foreach (var country in commonRep.resultList)
            {
                list.Add(new
                {
                    國別 = country.國別,
                    CODE = country.CODE,
                });
            }
            cboCountry.DataSource = list;
            cboCountry.DisplayMember = "國別";
            cboCountry.ValueMember = "CODE";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void initGridView()
        {
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶設定> custList = customerController.getCustomerList();
            foreach (var cust in custList.resultList)
            {
                if (cust != null)
                {
                    int index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = cust.COMPANY;//客戶名稱
                    index++;
                    row.Cells[index++].Value = cust.CONTACTPERSON;//主要聯絡人
                    row.Cells[index++].Value = cust.正航編號;
                    row.Cells[index++].Value = cust.COUNTRY;
                    row.Cells[index++].Value = cust.INDUSTRY;
                    row.Cells[index++].Value = cust.INDUSTRYCODE_C;
                    row.Cells[index++].Value = cust.INDUSTRYCODE_E;
                    row.Cells[index++].Value = cust.MA;
                    row.Cells[index++].Value = cust.EMAIL;
                    row.Cells[index++].Value = cust.CREDATE;
                    row.Cells[index++].Value = cust.MODIFYDATE;
                    row.Cells[index++].Value = cust.識別;
                    dataGridView1.Rows.Add(row);
                }
            }
            dataGridView1.Width = this.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (customerMaintainControl == null)
            {
                customerMaintainControl = new CustomerMaintainControl();
                customerMaintainControl.Dock = DockStyle.Fill;
                panel1.Controls.Add(customerMaintainControl);
            }
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((CustomerMaintainControl)customerMaintainControl).form = new C客戶設定();
            ((CustomerMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
            //frmCustomerMaintain frm = new frmCustomerMaintain();
            //frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;

            var dataGridView = (DataGridView)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                C客戶設定 data = new C客戶設定();
                int index = row1.Cells.Count - 1;
                data.識別 = int.Parse(row1.Cells[index].Value.ToString());
                data = new CustomerController().GetCustomer(data).result;

                var customerMaintainControl = (CustomerMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new CustomerMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((CustomerMaintainControl)customerMaintainControl).form = data;
                ((CustomerMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }

        private void txtCustQueryFIeld_Leave(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString().IndexOf(txtCustQueryFIeld.Text.Trim()) != -1)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dynamic selected = cboCountry.SelectedItem;
                if (selected != null && !string.IsNullOrEmpty(selected.國別))
                {
                    if (row.Cells[3].Value?.ToString().Trim().IndexOf(selected.國別) != -1)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = true;
                }
                //{

                    //}
                    //foreach (var aItem in cboCountry.DataSource as IEnumerable<dynamic>)
                    //{
                    //    if (row.Cells[3].Value?.ToString().Trim().IndexOf(aItem.國別.Trim()) != -1)
                    //    {
                    //        row.Visible = true;
                    //    }
                    //    else
                    //    {
                    //        row.Visible = false;
                    //    }
                    //}
            }
        }
    }
}
