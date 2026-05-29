using DigiERP.UserControl;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmQuotationDistribution : Form
    {
        private CustomerController _customerController;
        public string customerId { get; set; }
        public string orderDate { get; set; }
        public FrmQuotationDistribution()
        {
            InitializeComponent();
            initController();
        }
        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }

        public void initGrid()
        {
            CommonRep<C報價明細> data = _customerController.GetQuotationDistributionList(customerId, orderDate);
            if (!string.IsNullOrEmpty(data.ErrorMessage))
            {
                MessageBox.Show(data.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            //int rowIndex = 0;
            foreach (C報價明細 c in data.resultList)
            {
                //if (removedIndex.Contains(rowIndex))
                //{
                //    continue;
                //}
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = c.識別碼;
                index++;
                row.Cells[index++].Value = c.產品編號;
                row.Cells[index++].Value = c.品名規格;
                row.Cells[index++].Value = c.數量;
                row.Cells[index++].Value = c.單位;
                row.Cells[index++].Value = c.單價;
                row.Cells[index++].Value = c.QUONO;
                dataGridView1.Rows.Add(row);
                //rowIndex++;
            }
            //throw new NotImplementedException();
        }
        public List<C報價明細> checkedList = new List<C報價明細>();
        public List<int> removedIndex = new List<int>();
        private void btnOK_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++) 
            {
                // 避免處理最後那行新增列
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.IsNewRow)
                    continue;

                bool isChecked = Convert.ToBoolean(row.Cells["勾選"].Value);

                if (isChecked)
                {
                    int index = 0;
                    C報價明細 c = new C報價明細();
                    c.識別碼 = int.Parse((row?.Cells?[index].Value) == null ? "0" : row?.Cells?[index++].Value?.ToString());
                    index++;
                    c.產品編號 = row?.Cells?[index++].Value?.ToString();
                    c.品名規格 = row?.Cells?[index++].Value?.ToString();
                    c.數量 = decimal.Parse(row?.Cells?[index].Value == null ? "0" : row?.Cells?[index++].Value.ToString());
                    c.單位 = row?.Cells?[index++].Value?.ToString();
                    c.單價 = decimal.Parse(row?.Cells?[index].Value == null ? "0" : row?.Cells?[index++].Value.ToString());
                    c.QUONO = row?.Cells?[index++].Value?.ToString();
                    checkedList.Add(c);
                    //removedIndex.Add(i);
                }
                else
                {
                    checkedList = checkedList.Where(x => x.識別碼 != int.Parse((row?.Cells?[0].Value) == null ? "0" : row?.Cells?[0].Value?.ToString())).ToList();
                    //removedIndex = removedIndex.Where(x => x != i).ToList();
                }
            }
            //foreach(var i in removedIndex)
            //{
            //    dataGridView1.Rows.RemoveAt(i);
            //}
            DialogResult = DialogResult.OK;
        }
    }
}
