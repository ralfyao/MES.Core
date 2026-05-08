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

namespace DigiERP.Forms.Customer
{
    public partial class FrmCustEqpList : Form
    {
        private string _custNo { get; set; }
        private string _custAlias { get; set; }
        private string _custName { get; set; }
        public void SetCustNo(string custNo)
        {
            this._custNo = custNo;
        }
        public void SetCustAlias(string custAlias)
        {
            this._custAlias = custAlias;
        }
        public void SetCustName(string custName)
        {
            this._custName = custName;
        }
        public FrmCustEqpList()
        {
            InitializeComponent();
        }

        private void initGrid()
        {
            dataGridView1.Rows.Clear();
            if (string.IsNullOrEmpty(_custNo))
            {
                return;
            }
            CustomerController customerController = new CustomerController();
            CommonRep<C機台客服> commonRep = customerController.GetEqpCustServiceList(_custNo);
            foreach(var item in commonRep.resultList)
            {
                DataGridViewRow row = new DataGridViewRow();
                foreach (var subItem in item.detailList)
                {
                    int index = 0;
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.單號;
                    row.Cells[index++].Value = item.專案序號;
                    row.Cells[index++].Value = item.事件Events;
                    row.Cells[index++].Value = subItem.日期;
                    row.Cells[index++].Value = subItem.客戶反映;
                    row.Cells[index++].Value = subItem.公司回覆;
                }
                //row.Cells[index++].Value = item.COMPANY;//客戶名稱

                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        public void initCustInfo()
        {
            lblCustNo.Text = _custNo;
            lblCustAlias.Text = _custAlias;
            lblCustCompany.Text = _custName;
            initGrid();
        }
    }
}
