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

namespace DigiERP.UserControl.Customer.Quotation
{
    public partial class QuotationControl : System.Windows.Forms.UserControl
    {
        public QuotationControl()
        {
            InitializeComponent();
            initGridView();
        }

        private CustomerController customerController;

        private void initGridView()
        {
            if (customerController == null)
            {
                customerController = new CustomerController();
            }
            CommonRep<C報價單> commonRep = customerController.GetQuotationList(string.Empty);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in commonRep.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.QUONO;
                row.Cells[index++].Value = !string.IsNullOrEmpty(item.QUODATE) ? DateTime.Parse(item.QUODATE).ToString("yyyy/MM/dd") : "";
                row.Cells[index++].Value = item.COMPANY;
                row.Cells[index++].Value = item.CONTACT;
                row.Cells[index++].Value = item.MTYPE;
                try
                {
                    row.Cells[index++].Value = Properties.Resources.search_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
                }
                catch { }
                row.Cells[index++].Value = item.AMOUNT;
                row.Cells[index++].Value = item.SALES;
                row.Cells[index++].Value = item.業務人員;
                row.Cells[index++].Value = item.RFQNO;
                row.Cells[index++].Value = item.RECALL;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0) return;

            // 判斷是否為放大鏡那一欄
            if (dataGridView1.Columns[e.ColumnIndex].Name == "明細查詢")
            {
                MessageBox.Show("明細查詢");
                //SearchForm frm = new SearchForm();

                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    // 範例：把回傳值寫回某個欄位
                //    dataGridView1.Rows[e.RowIndex].Cells["YourTargetColumn"].Value = frm.SelectedValue;
                //}
            }
        }
    }
}
