using DigiERP.Common;
using DigiERP.Forms.HR;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR
{
    // ── 員工清冊：H員工基本資料 RIGHT JOIN H員工清冊 ON 工號 ─────────────────
    public partial class EmployeeControl : CommonUserControl
    {
        private static string id = "06241492-E82F-49D4-9B1F-678CE48863D1";

        private List<員工清冊列表> _fullList = new List<員工清冊列表>();

        public EmployeeControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var rep = new HRController().GetEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<員工清冊列表>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<員工清冊列表> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.工號;
                row.Cells[i++].Value = x.姓名;
                row.Cells[i++].Value = x.部門;
                row.Cells[i++].Value = x.人事編號;
                row.Cells[i++].Value = x.卡號;
                row.Cells[i++].Value = x.生日;
                row.Cells[i++].Value = x.狀況;
                row.Cells[i++].Value = x.職等;
                row.Cells[i++].Value = x.職級;
                row.Cells[i++].Value = x.核薪日;
                row.Cells[i++].Value = x.離職日;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 在職者查詢：僅顯示 狀況="正常" 的員工 ────────────────────────────
        private void btnActiveQuery_Click(object sender, EventArgs e)
        {
            FillGrid(_fullList.Where(x => x.狀況 == "正常").ToList());
        }

        // ── 復原：還原顯示全部員工(含離職) ───────────────────────────────
        private void btnRestore_Click(object sender, EventArgs e)
        {
            FillGrid(_fullList);
        }

        // ── 新增員工：開啟員工資料維護視窗，SAVE 後寫入 H員工清冊 ─────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new FrmEmployeeMaintain();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        // ── 點選工號：開啟(或切換至)「員工薪資核定紀錄」頁籤 ─────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colEmpNo) return;
            string empNo = dataGridView1.Rows[e.RowIndex].Cells[colEmpNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(empNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "EmployeeSalary_" + empNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    ((EmployeeSalaryControl)page.Controls[0]).LoadData(empNo);
                    return;
                }
            }
            var ctrl = new EmployeeSalaryControl { Dock = DockStyle.Fill };
            var tab = new TabPage("員工薪資核定紀錄-" + empNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(empNo);
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
