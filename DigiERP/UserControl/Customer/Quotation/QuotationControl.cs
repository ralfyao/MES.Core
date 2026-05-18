using DigiERP.Forms.Customer.Quotation;
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

namespace DigiERP.UserControl.Customer.Quotation
{
    public partial class QuotationControl : System.Windows.Forms.UserControl
    {
        public QuotationControl()
        {
            InitializeComponent();
            initGridView(null);
        }

        private CustomerController customerController;
        private void initGridView(List<C報價單> list)
        {
            if (customerController == null)
            {
                customerController = new CustomerController();
            }
            if (list == null || list.Count() == 0)
            {
                CommonRep<C報價單> commonRep = customerController.GetQuotationList(string.Empty);
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                    return;
                }
                list = commonRep.resultList;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in list)
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
        bool queryDetail = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0) return;
            if (!queryDetail) return;
            // 判斷是否為放大鏡那一欄
            if (e.ColumnIndex == 5)
            {
                //MessageBox.Show("明細查詢");
                FrmQuotationDetailList frmQuotationDetailList = new FrmQuotationDetailList();
                frmQuotationDetailList.quotationNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                frmQuotationDetailList.GetQuotationDetail();
                frmQuotationDetailList.ShowDialog();
            }
        }


        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "明細查詢")
            {
                dataGridView1.Cursor = Cursors.Hand;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Default;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            queryDetail = true;
            dataGridView1_CellContentClick(sender, e);
            queryDetail = false;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            queryDetail = true;
            dataGridView1_CellContentClick(sender, e);
            queryDetail = false;
        }

        private void txtQUONO_Leave(object sender, EventArgs e)
        {
            if (customerController == null)
                customerController = new CustomerController();
            CommonRep<C報價單> commonRep = customerController.GetQuotationList();
            var list = commonRep.resultList;
            if (!string.IsNullOrEmpty(txtQUONO.Text))
            {
                var quono = txtQUONO.Text.ToString();
                list = list.Where(x => x.QUONO != "" && x.QUONO != null && x.QUONO?.Trim().IndexOf(quono.Trim()) != -1)?.ToList();
            }
            if (!string.IsNullOrEmpty(txtCompany.Text))
            {
                list = list.Where(x => !string.IsNullOrEmpty(x.COMPANY) && x.COMPANY?.Trim().IndexOf(txtCompany.Text.Trim()) != -1)?.ToList();
            }
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                list = list.Where(x => x.quotationDetailFormList.Where(xx => xx.品名規格?.IndexOf(txtItemName.Text) != -1)?.Count() > 0)?.ToList();
            }
            initGridView(list);
        }

        private void txtQUONO_Leave_1(object sender, EventArgs e)
        {
            //txtQUONO_Leave(sender, e);
        }

        private void txtCompany_Leave(object sender, EventArgs e)
        {

            //txtQUONO_Leave(sender, e);
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {

            //txtQUONO_Leave(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQUONO_Leave(sender, e);
        }
    }
}
