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
    public partial class FrmCustRfqtList : Form
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
        public FrmCustRfqtList()
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
            CommonRep<C客戶詢問函> commonRep = customerController.GetRfqListByCust(_custName);
            foreach(var item in commonRep.resultList)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = 0;
                row.CreateCells(dataGridView1);

                row.Cells[index++].Value = item.RFQNO;
                row.Cells[index++].Value = item.MACHINE;
                row.Cells[index++].Value = item.RFQDATE;
                //row.Cells[index++].Value = item.RFQNO;
                row.Cells[index++].Value = item.STATUS;
                row.Cells[index++].Value = item.RFQSTATUS;
                row.Cells[index++].Value = item.QUONO;

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
