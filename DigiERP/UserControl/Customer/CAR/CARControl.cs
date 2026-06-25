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

namespace DigiERP.UserControl.Customer.CAR
{
    public partial class CARControl : CommonUserControl
    {
        FrmCustSelect popup;
        private CustomerController _customerController { get; set; }
        public CARControl()
        {
            InitializeComponent();
            initGrid();
        }
        List<客戶訴願處理單> carList { get; set; }
        private void initGrid()
        {
            initController();
            int index = 0;
            dataGridView1.Rows.Clear();
            carList = getCARList();
            foreach(var item in carList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.申請日期;
                row.Cells[index++].Value = item.客戶簡稱;
                row.Cells[index++].Value = item.專案序號;
                row.Cells[index++].Value = item.機台型號;
                row.Cells[index++].Value = item.機台名稱;
                row.Cells[index++].Value = item.訴願類別;
                row.Cells[index++].Value = item.訴求內容;
                row.Cells[index++].Value = item.解決對策;
                row.Cells[index++].Value = item.回覆日期;
                row.Cells[index++].Value = item.客戶反應;
                row.Cells[index++].Value = item.滿意度評分;
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private List<客戶訴願處理單> getCARList()
        {
            initController();
            List<客戶訴願處理單> list = new List<客戶訴願處理單>();
            CommonRep<客戶訴願處理單> carListRep = _customerController.CARList();
            if (!string.IsNullOrEmpty(carListRep.ErrorMessage))
            {
                MessageBox.Show(carListRep.ErrorMessage);
                return list;
            }
            list = carListRep.resultList;
            return list;
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
        }

        private void cboCustId_MouseClick(object sender, MouseEventArgs e)
        {
            popup = new FrmCustSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
                //txtCompany.Text = popup.CustName;
            }
        }
    }
}
