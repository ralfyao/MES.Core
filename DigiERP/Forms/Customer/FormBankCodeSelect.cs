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
    public partial class FormBankCodeSelect : Form
    {
        public string SelectedCode { get; private set; }
        public string SelectedName { get; private set; }
        public FormBankCodeSelect()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            CommonRep<F銀行設定> commonRep = new CustomerController().getBankCodeList();
            foreach (var item in commonRep.resultList)
            {
                if (item != null)
                {
                    int index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.銀存編碼;//銀存編碼
                    row.Cells[index++].Value = item.銀行名稱;//銀行名稱
                    row.Cells[index++].Value = item.帳號;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            SelectedCode = row.Cells[0].Value?.ToString();
            SelectedName = row.Cells[1].Value?.ToString();

            this.DialogResult = DialogResult.OK; // 👈 關鍵
            this.Close();
        }
    }
}
