using DigiERP.Util;
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

namespace DigiERP.UserControl.Customer.RFQ
{
    public partial class RFQControl : System.Windows.Forms.UserControl
    {
        public RFQControl()
        {
            InitializeComponent();
            initCountrySelect();
        }
        private void initCountrySelect()
        {
            ControlUtil.initCountrySelect(cboCountry);
        }
        private CustomerController customerController = new CustomerController();
        private void initGrid()
        {
            try
            {
                CommonRep<C客戶詢問函> commonRep = customerController.QuerySalesRecordList(new MES.MiddleWare.Modules.QuerySalesRecordListParam());
                inflateGrdiView(commonRep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //throw new NotImplementedException();
        }

        private void inflateGrdiView(CommonRep<C客戶詢問函> commonRep)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in commonRep.resultList)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.RFQNO;
                row.Cells[index++].Value = DateTime.Parse(item.RFQDATE).ToString("yyyy/MM/dd");
                row.Cells[index++].Value = item.COMPANY;
                row.Cells[index++].Value = item.CONTACT;
                row.Cells[index++].Value = item.COUNTRY;
                row.Cells[index++].Value = item.INDUSTRYCODE;
                row.Cells[index++].Value = item.STATUS;
                row.Cells[index++].Value = item.RANKING;
                row.Cells[index++].Value = item.預計再訪日;
                row.Cells[index++].Value = item.業務人員;
                dataGridView1.Rows.Add(row);
            }
        }

        private void txtCustomerQuery_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerQuery.Text))
                {
                    initGrid();
                }
                else
                {
                    CommonRep<C客戶詢問函> commonRep = customerController.QuerySalesRecordList(new MES.MiddleWare.Modules.QuerySalesRecordListParam() { custName = txtCustomerQuery.Text.Trim() });
                    inflateGrdiView(commonRep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic selected = cboCountry.SelectedItem;
            if (string.IsNullOrEmpty(selected.國別))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (selected != null && !string.IsNullOrEmpty(selected.國別))
                {
                    if (!string.IsNullOrEmpty(row.Cells[4].Value?.ToString().Trim()) 
                        && row.Cells[4].Value?.ToString().Trim().IndexOf(selected.國別) != -1)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
