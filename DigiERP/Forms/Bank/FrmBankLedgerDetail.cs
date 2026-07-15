using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    public partial class FrmBankLedgerDetail : Form
    {
        public string bankCode { get; set; }

        private List<F銀行明細> _allList = new List<F銀行明細>();

        public FrmBankLedgerDetail()
        {
            InitializeComponent();
        }

        public void initData()
        {
            var rep = new CustomerController().GetBankLedgerList(bankCode);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _allList = rep.resultList ?? new List<F銀行明細>();
            FillGrid(_allList);
        }

        private void FillGrid(List<F銀行明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colBankCode.Index].Value = x.銀存編碼;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colSummary.Index].Value = x.摘要;
                row.Cells[colCurrency.Index].Value = x.幣別;
                row.Cells[colExpense.Index].Value = x.支出;
                row.Cells[colDeposit.Index].Value = x.存入;
                row.Cells[colLinkNo.Index].Value = x.連結單號;
                row.Cells[colRemark.Index].Value = x.備註;
                row.Cells[colTarget.Index].Value = x.對象;
            }
            lblExpenseSum.Text = list.Sum(x => x.支出).ToString("N0");
            lblDepositSum.Text = list.Sum(x => x.存入).ToString("N0");
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            FillGrid(_allList.Where(x => DateTime.TryParse(x.日期, out var d) && d.Year == today.Year && d.Month == today.Month).ToList());
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            var lastMonth = DateTime.Now.AddMonths(-1);
            FillGrid(_allList.Where(x => DateTime.TryParse(x.日期, out var d) && d.Year == lastMonth.Year && d.Month == lastMonth.Month).ToList());
        }

        private void btnOver60_Click(object sender, EventArgs e)
        {
            var cutoff = DateTime.Now.AddDays(-60);
            FillGrid(_allList.Where(x => DateTime.TryParse(x.日期, out var d) && d < cutoff).ToList());
        }

        private void btnQueryMonth_Click(object sender, EventArgs e)
        {
            var target = dtYearMonth.Value;
            FillGrid(_allList.Where(x => DateTime.TryParse(x.日期, out var d) && d.Year == target.Year && d.Month == target.Month).ToList());
        }
    }
}
