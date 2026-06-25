using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
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

namespace DigiERP.UserControl.Customer.Repair
{
    public partial class RepairFormControl : CommonUserControl
    {
        FrmCustSelect popup;
        private CustomerController _customerController { get; set; }
        List<維修服務單> repairFormList { get; set; }

        public RepairFormControl()
        {
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initController()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
        }

        private static string FmtDate(string s)
        {
            if (DateTime.TryParse(s, out DateTime d)) return d.ToString("yyyy/MM/dd");
            return s ?? "";
        }

        private void initGrid()
        {
            initController();
            int index = 0;
            dataGridView1.Rows.Clear();
            CommonRep<維修服務單> repairListRep = _customerController.RepairTestList();
            if (!string.IsNullOrEmpty(repairListRep.ErrorMessage))
            {
                MessageBox.Show(repairListRep.ErrorMessage);
                return;
            }
            repairFormList = repairListRep.resultList;
            foreach (var item in repairFormList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = FmtDate(item.申請日期);
                row.Cells[index++].Value = item.客戶簡稱;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = item.機台型號;
                row.Cells[index++].Value = item.機台名稱;
                row.Cells[index++].Value = item.服務型態;
                row.Cells[index++].Value = item.維修地點;
                row.Cells[index++].Value = FmtDate(item.希望服務日期);
                row.Cells[index++].Value = FmtDate(item.實際服務日期);
                row.Cells[index++].Value = FmtDate(item.維修結案日期);
                row.Cells[index++].Value = item.維修檢查人員;
                row.Cells[index++].Value = item.轉零件申請 == true ? "是" : "";
                row.Cells[index++].Value = item.核准;
                dataGridView1.Rows.Add(row);
            }
        }

        private void cboCustId_MouseClick(object sender, MouseEventArgs e)
        {
            popup = new FrmCustSelect();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
            }
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            initController();
            string custId = cboCustId.Text?.Trim() ?? "";
            CommonRep<維修服務單> rep = _customerController.QueryRepairTestFormByCondition(
                string.IsNullOrEmpty(custId) ? null : custId);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            repairFormList = rep.resultList;

            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in repairFormList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = FmtDate(item.申請日期);
                row.Cells[index++].Value = item.客戶簡稱;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = item.機台型號;
                row.Cells[index++].Value = item.機台名稱;
                row.Cells[index++].Value = item.服務型態;
                row.Cells[index++].Value = item.維修地點;
                row.Cells[index++].Value = FmtDate(item.希望服務日期);
                row.Cells[index++].Value = FmtDate(item.實際服務日期);
                row.Cells[index++].Value = FmtDate(item.維修結案日期);
                row.Cells[index++].Value = item.維修檢查人員;
                row.Cells[index++].Value = item.轉零件申請 == true ? "是" : "";
                row.Cells[index++].Value = item.核准;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            cboCustId.Items.Clear();
            cboCustId.Text = "";
            initGrid();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            openMaintainControl(new 維修服務單(), "新增");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string formNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(formNo)) return;

            initController();
            CommonRep<維修服務單> rep = _customerController.QueryRepairTestFormByCondition(null);
            維修服務單 selected = rep.resultList.FirstOrDefault(x => x.單號 == formNo) ?? new 維修服務單 { 單號 = formNo };
            openMaintainControl(selected, "修改");
        }

        private void openMaintainControl(維修服務單 form, string mode)
        {
            RemoveExistingMaintainControl();

            var maintainControl = new RepairFormMaintainControl();
            maintainControl.Dock = DockStyle.Fill;
            maintainControl.form = form;
            maintainControl.lblMode.Text = mode;
            maintainControl.initForm();
            panel2.Controls.Add(maintainControl);

            dataGridView1.Visible = false;
            maintainControl.Visible = true;
        }

        private void RemoveExistingMaintainControl()
        {
            var existing = panel2.Controls.OfType<RepairFormMaintainControl>().FirstOrDefault();
            if (existing != null)
                panel2.Controls.Remove(existing);
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
                initGrid();
        }
    }
}
