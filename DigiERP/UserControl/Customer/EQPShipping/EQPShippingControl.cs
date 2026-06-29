using DigiERP.Common;
using DigiERP.UserControl.Customer.Quotation;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.EQPShipping
{
    public partial class EQPShippingControl : CommonUserControl
    {
        private static string id = "751F454E-D6C2-41B0-B3A3-5ED8C1AE82CE";
        private ProductionController _productionController;
        private List<專案機台交貨單> shippingList;

        public EQPShippingControl()
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
            if (_productionController == null)
                _productionController = new ProductionController();
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
            CommonRep<專案機台交貨單> rep = _productionController.GetAllProjectShippingOrders();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            shippingList = rep.resultList ?? new List<專案機台交貨單>();
            FillGrid(shippingList);
        }

        private void FillGrid(List<專案機台交貨單> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = FmtDate(item.日期);
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = FmtDate(item.ETD);
                row.Cells[index++].Value = FmtDate(item.ETA);
                row.Cells[index++].Value = item.DestinationPort;
                row.Cells[index++].Value = item.聯絡人;
                row.Cells[index++].Value = item.Forwarder;
                row.Cells[index++].Value = item.核准;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            openMaintainControl(new 專案機台交貨單(), "新增");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string 單號 = dataGridView1.Rows[e.RowIndex].Cells[colOrderNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(單號)) return;
            CommonRep<專案機台交貨單> rep = _productionController.GetEQPShippingByNo(單號);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            openMaintainControl(rep.result ?? new 專案機台交貨單 { 單號 = 單號 }, "修改");
        }

        private void openMaintainControl(專案機台交貨單 data, string mode)
        {
            RemoveExistingMaintainControl();
            var ctrl = new EQPShippingMaintainControl();
            ctrl.form = data;
            ctrl.Dock = DockStyle.Fill;
            var lblMode = ctrl.Controls.Find("lblMode", true).FirstOrDefault() as System.Windows.Forms.Label;
            if (lblMode != null) lblMode.Text = mode;
            dataGridView1.Visible = false;
            panel2.Controls.Add(ctrl);
            ctrl.initForm();
        }

        private void RemoveExistingMaintainControl()
        {
            var existing = panel2.Controls.OfType<EQPShippingMaintainControl>().ToList();
            foreach (var c in existing) panel2.Controls.Remove(c);
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
                initGrid();
        }
    }
}
