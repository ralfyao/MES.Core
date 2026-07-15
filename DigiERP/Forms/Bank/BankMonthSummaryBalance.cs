using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class BankMonthSummaryBalance : Form
    {
        public string monthEnd { get; set; }

        public BankMonthSummaryBalance()
        {
            InitializeComponent();
        }

        public void initData()
        {
            var rep = new CustomerController().GetBankMonthSummaryList(monthEnd);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<銀行月底餘額>());
        }

        private void FillGrid(List<銀行月底餘額> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colYearMonth.Index].Value = x.日期_月;
                row.Cells[colBankCode.Index].Value = x.銀存編碼;
                row.Cells[colBankName.Index].Value = x.銀行名稱;
                row.Cells[colAccountNo.Index].Value = x.帳號;
                row.Cells[colCurrency.Index].Value = x.幣別;
                row.Cells[colDepositSum.Index].Value = x.存入總計;
                row.Cells[colExpenseSum.Index].Value = x.支出總計;
                row.Cells[colCount.Index].Value = x.筆數;
                row.Cells[colBalance.Index].Value = x.餘額;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要執行月結確定?", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new CustomerController().ConfirmBankMonthEnd(monthEnd);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("月結確定成功!");
            initData();
        }

        private void btnCancel_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
