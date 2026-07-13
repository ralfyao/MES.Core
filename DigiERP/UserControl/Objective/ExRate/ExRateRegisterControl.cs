using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.ExRate
{
    public partial class ExRateRegisterControl : CommonUserControl
    {
        private static string id = "4F8A2C16-7E3D-4B9A-9C5F-1D6E8A3B7C42";

        private List<F幣別> _currencies = new List<F幣別>();
        private List<F匯率> _allRates = new List<F匯率>();
        private int _currentIndex = 0;
        private bool _isLoading;
        private HashSet<int> _dirtyRows = new HashSet<int>();

        public ExRateRegisterControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            var currencyRep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(currencyRep.ErrorMessage))
            {
                MessageBox.Show(currencyRep.ErrorMessage);
                return;
            }
            _currencies = (currencyRep.resultList ?? new List<F幣別>())
                .Where(x => !string.IsNullOrEmpty(x.CURRENCY))
                .ToList();

            LoadRates();
            _currentIndex = 0;
            LoadCurrency();
        }

        private void LoadRates()
        {
            var rateRep = new ExRateController().GetAllExRateList();
            if (!string.IsNullOrEmpty(rateRep.ErrorMessage))
            {
                MessageBox.Show(rateRep.ErrorMessage);
                return;
            }
            _allRates = rateRep.resultList ?? new List<F匯率>();
        }

        private void LoadCurrency()
        {
            if (_currencies.Count == 0) return;
            string currency = _currencies[_currentIndex].CURRENCY;
            txtCurrency.Text = currency;
            var rates = _allRates.Where(x => x.CURRENCY == currency).OrderBy(x => x.日期).ToList();
            FillGrid(rates);
        }

        private void FillGrid(List<F匯率> rates)
        {
            _isLoading = true;
            dataGridView1.Rows.Clear();
            _dirtyRows.Clear();
            foreach (var x in rates)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colRate.Index].Value = x.匯率;
            }
            _isLoading = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currencies.Count == 0) return;
            _currentIndex = (_currentIndex - 1 + _currencies.Count) % _currencies.Count;
            LoadCurrency();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currencies.Count == 0) return;
            _currentIndex = (_currentIndex + 1) % _currencies.Count;
            LoadCurrency();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── 只有實際被異動過的儲存格才標記為待存檔 ──────────────────────────
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isLoading || e.RowIndex < 0) return;
            _dirtyRows.Add(e.RowIndex);
        }

        // ── 離開該列時：若該列有異動，依識別碼是否已存在決定新增(儲存)或更新(修改) ──
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (_isLoading || e.RowIndex < 0 || !_dirtyRows.Contains(e.RowIndex)) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            string date = row.Cells[colDate.Index].Value?.ToString();
            string rate = row.Cells[colRate.Index].Value?.ToString();
            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(rate)) return;

            int.TryParse(row.Cells[colId.Index].Value?.ToString(), out var id);
            var form = new F匯率
            {
                識別 = id,
                CURRENCY = txtCurrency.Text,
                日期 = date,
                匯率 = rate
            };
            var rep = new ExRateController().SaveExRate(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            row.Cells[colId.Index].Value = rep.result;
            _dirtyRows.Remove(e.RowIndex);
            LoadRates();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }
    }
}
