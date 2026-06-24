using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.EQPCSustService
{
    public partial class EQPServiceHistoryControl : CommonUserControl
    {
        public 工令單 form;
        private List<C機台客服> erpListDetail { get; set; }
        private CustomerController _customerController { get; set; }
        private ProductionController _productionController { get; set; }
        private C客戶設定 _customer { get; set; }
        private void initController()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            if (_productionController == null)
                _productionController = new ProductionController();
        }
        public EQPServiceHistoryControl()
        {
            InitializeComponent();
            initController();
            lbl客戶名稱.Text = string.Empty;
            lbl客戶簡稱.Text = string.Empty;
            lbl專案序號.Text = string.Empty;
            lbl機台名稱.Text = string.Empty;
            lbl機台型號.Text = string.Empty;
            lbl機台類型.Text = string.Empty;
        }

        internal void initForm()
        {
            if (form != null)
            {
                var customerRep = _customerController.getCustomerList(form.客戶簡稱 ?? "");
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                _customer = customerRep.resultList.FirstOrDefault() ?? new C客戶設定();
                lbl客戶簡稱.Text = form?.客戶簡稱;
                lbl客戶名稱.Text = _customer?.COMPANY;
                lbl專案序號.Text = form?.專案序號;
                lbl機台名稱.Text = form?.機台名稱;
                lbl機台型號.Text = form?.機台型號;
                lbl機台類型.Text = form?.機台類型;
                initGrid();
            }
            //throw new NotImplementedException();
        }

        private void initGrid()
        {
            if (string.IsNullOrEmpty(form.專案序號))
                return;
            var eqpCustServiceList = _productionController.GetEqpServiceListByProjSerial(form.專案序號);
            if (!string.IsNullOrEmpty(eqpCustServiceList.ErrorMessage))
            {
                MessageBox.Show(eqpCustServiceList.ErrorMessage);
                return;
            }
            erpListDetail = eqpCustServiceList.resultList;
            int index = 0;
            foreach (var item in erpListDetail)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.事件Events;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var detailList = erpListDetail.Where(x=>x.單號 == orderNo).FirstOrDefault();
            if (detailList != null)
            {
                var detailListDetail = detailList.detailList;
                int index = 0;
                dataGridView2.Rows.Clear();
                foreach (var item in detailListDetail)
                {
                    index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2);
                    row.Cells[index++].Value = item.日期;
                    row.Cells[index++].Value = item.客戶反映;
                    row.Cells[index++].Value = item.聯絡者;
                    row.Cells[index++].Value = item.公司回覆;
                    row.Cells[index++].Value = item.執行者;
                    row.Cells[index++].Value = item.業務紀錄;
                    row.Cells[index++].Value = item.客訴單號;
                    row.Cells[index++].Value = item.報價單號;
                    dataGridView2.Rows.Add(row);
                }
            }
            
        }
    }
}
