using DigiERP.Forms.Customer;
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

namespace DigiERP.UserControl
{
    public partial class CustomerControl : System.Windows.Forms.UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            initGridView();
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
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (customerMaintainControl != null)
            {
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode"  select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "新增";
                }
                customerMaintainControl.Visible = true;
            }
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
            //frmCustomerMaintain frm = new frmCustomerMaintain();
            //frm.Show();
        }
    }
}
