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
    public partial class FrmIndustryManage : Form
    {
        public FrmIndustryManage()
        {
            InitializeComponent();
            initGrid();
        }

        private void initGrid()
        {
            CommonRep<C產業代碼> commonRep = new CustomerController().getIndustryCodeLis();
            foreach (var item in commonRep.resultList)
            {
                if (item != null)
                {
                    int index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.大分類碼;//客戶名稱
                    row.Cells[index++].Value = item.大分類名稱;//主要聯絡人
                    row.Cells[index++].Value = item.中分類碼;//客戶名稱
                    row.Cells[index++].Value = item.中分類名稱;//主要聯絡人
                    row.Cells[index++].Value = item.英文;
                    row.Cells[index++].Value = item.内容;
                    row.Cells[index++].Value = item.其他;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIndustryCodeAdd addForm = new FrmIndustryCodeAdd();
            addForm.ShowDialog();
        }
    }
}
