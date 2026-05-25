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

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmCustSelect : CommonForm
    {
        public string CustId { get; set; }
        public string CustAlias { get; set; }
        public string CustName { get; set; }
        private CustomerController _customerController;
        public FrmCustSelect()
        {
            InitializeComponent();
            initGridView();
            if (_customerController == null)
                _customerController = new CustomerController();
        }

        private void initGridView()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<C客戶設定> customerRep = _customerController.getCustomerList();
            if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
            {
                MessageBox.Show(customerRep.ErrorMessage);
                return;
            }
            List<C客戶設定> custList = customerRep.resultList.Where(x=>!string.IsNullOrEmpty( x.正航編號)).ToList();
            inflateGridViewRow(custList);
            //throw new NotImplementedException();
        }

        private void inflateGridViewRow(List<C客戶設定> custList)
        {
            int index = 0;
            this.dataGridView1.Rows.Clear();
            foreach (var item in custList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.正航編號;
                row.Cells[index++].Value = item.COMPANY;
                row.Cells[index++].Value = item.欄位2;
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            CustId = row.Cells[0].Value?.ToString();
            CustName = row.Cells[1].Value?.ToString();
            CustAlias = row.Cells[2].Value?.ToString();
            this.DialogResult = DialogResult.OK; // 👈 關鍵
            this.Close();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
