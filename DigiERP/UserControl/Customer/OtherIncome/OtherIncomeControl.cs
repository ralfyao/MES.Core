using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.OtherIncome
{
    public partial class OtherIncomeControl : CommonUserControl
    {
        FrmCustSelect popup;
        private static string id = "3344F4D3-18C6-49AD-BE21-6068618F4448";
        private ARController _arController { get; set; }
        List<F其他收入單> otherIncomeList { get; set; }

        public OtherIncomeControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initController()
        {
            if (_arController == null)
                _arController = new ARController();
        }

        private static string FmtDate(string s)
        {
            if (DateTime.TryParse(s, out DateTime d)) return d.ToString("yyyy/MM/dd");
            return s ?? "";
        }

        private void initGrid()
        {
            initController();
            dataGridView1.Rows.Clear();
            CommonRep<F其他收入單> rep = _arController.GetOtherIncomeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            otherIncomeList = rep.resultList ?? new List<F其他收入單>();
            FillGrid(otherIncomeList);
        }

        private void FillGrid(List<F其他收入單> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = FmtDate(item.日期);
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.業務員;
                row.Cells[index++].Value = item.幣別;
                row.Cells[index++].Value = item.稅別;
                row.Cells[index++].Value = item.總額?.ToString("N2");
                row.Cells[index++].Value = item.付款方式;
                row.Cells[index++].Value = item.結案 == 1 ? "是" : "";
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
            string custId = cboCustId.Text?.Trim() ?? "";
            if (otherIncomeList == null) return;

            var filtered = string.IsNullOrEmpty(custId)
                ? otherIncomeList
                : otherIncomeList.Where(x => x.客戶編號 == custId).ToList();
            FillGrid(filtered);
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            cboCustId.Items.Clear();
            cboCustId.Text = "";
            initGrid();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            openMaintainControl(new F其他收入單(), "新增");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string formNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(formNo)) return;

            var selected = otherIncomeList?.FirstOrDefault(x => x.單號 == formNo) ?? new F其他收入單 { 單號 = formNo };
            openMaintainControl(selected, "修改");
        }

        private void openMaintainControl(F其他收入單 form, string mode)
        {
            RemoveExistingMaintainControl();

            var maintainControl = new OtherIncomeMaintainControl();
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
            var existing = panel2.Controls.OfType<OtherIncomeMaintainControl>().FirstOrDefault();
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
