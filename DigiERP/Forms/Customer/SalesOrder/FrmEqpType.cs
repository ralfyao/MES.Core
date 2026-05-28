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
    public partial class FrmEqpType : Form
    {
        private CustomerController _customerController;
        public FrmEqpType()
        {
            InitializeComponent();
            if (_customerController == null)
                _customerController = new CustomerController();
            initGrid();
        }

        private void initGrid()
        {
            //throw new NotImplementedException();
            CommonRep<A機台類型> commonRep = _customerController.GetEqpType();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            int index = 0;
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.TYPEID;
                row.Cells[index++].Value = item.TYPE;
                dataGridView1.Rows.Add(row);
            }
        }
        public string _TYPEID { get; set; }
        public string _TYPE { get; set; }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            this._TYPEID = row.Cells[0].Value?.ToString();
            this._TYPE = row.Cells[1].Value?.ToString();
            DialogResult = DialogResult.OK; // 👈 關鍵
            Close();
        }
    }
}
