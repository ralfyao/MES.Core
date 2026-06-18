using DigiERP.Common;
using DigiERP.UserControl.Customer.Quotation;
using DigiERP.UserControl.Customer.SalesOrder;
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

namespace DigiERP.UserControl.Customer.Receivables
{
    public partial class ReceivableControl : DigiERP.Common.CommonUserControl
    {
        private ARController _arController;
        private string id = "6df5ee5c-41d3-4eb3-b093-09662e9951c3";
        private List<F收款> arList;
        public ReceivableControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
            }
            InitializeComponent();
            //initContros();
            //initController();
            //initGrid();
        }

      

        private void initGrid(List<F收款> list = null)
        {
            initController();
            initData();
            int index = 0;
            dataGridView1.Rows.Clear();
            var aList = arList;
            if (list != null)
            {
                aList = list;
            }
            foreach (var item in aList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = DateTime.Parse(item.日期).ToString("yyyy/MM/dd");
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.客戶名稱;
                row.Cells[index++].Value = item.幣別;
                row.Cells[index++].Value = item.類別;
                row.Cells[index++].Value = item.收款日期;
                row.Cells[index++].Value = item.發票號碼;
                row.Cells[index++].Value = item.MACHINENO;
                row.Cells[index++].Value = item.銀轉金額;
                row.Cells[index++].Value = item.收票金額;
                row.Cells[index++].Value = item.收款總額;
                row.Cells[index++].Value = item.傳票;
                row.Cells[index++].Value = item.核准;
                row.Cells[index++].Value = item.結案;
                dataGridView1.Rows.Add(row);
            }
        }

        private void initData()
        {
            var arListRep = _arController.GetArList();
            if (!string.IsNullOrEmpty(arListRep.ErrorMessage))
            {
                MessageBox.Show(arListRep.ErrorMessage);
                return;
            }
            arList = arListRep.resultList;
        }

        private void initController()
        {
            if (_arController == null)
            {
                _arController = new ARController();
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            initGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;
            //panel2.AutoScroll = true;
            //panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            var dataGridView = (DataGridView)(from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                F收款 data = new F收款();
                int index = row1.Cells.Count - 1;
                data.單號 = row1.Cells[0].Value?.ToString();
                var tmpdata = new ARController().GetArList(data.單號).resultList;
                if (tmpdata.Count() > 0)
                {
                    data = tmpdata[0];
                }
                var customerMaintainControl = (ReceivableMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(ReceivableMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new ReceivableMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((ReceivableMaintainControl)customerMaintainControl).form = data;
                ((ReceivableMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }

        private void btnUnClosed_Click(object sender, EventArgs e)
        {
            var arListClosed = arList.Where(x => x.結案 == false).ToList();
            initGrid(arListClosed);
        }
        F收款 form;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(QuotationMaintain) select c).FirstOrDefault();
            var dataGridView = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            //if (customerMaintainControl == null)
            //{
            if (form != null)
            {
                customerMaintainControl = new ReceivableMaintainControl(form);
                //((QuotationMaintain)customerMaintainControl).form = form;
            }
            else
            {
                customerMaintainControl = new ReceivableMaintainControl();
            }
            customerMaintainControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(customerMaintainControl);
            //}
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((ReceivableMaintainControl)customerMaintainControl).form = new F收款();
            ((ReceivableMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            var arListClosed = arList.Where(x => x.結案 == true).ToList();
            initGrid(arListClosed);
        }
    }
}
