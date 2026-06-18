using DigiERP.Common;
using MES.Core;
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
    public partial class EQPCustServiceControl : CommonUserControl
    {
        private CustomerController _customerController;
        private string id = "1fdcb68d-91be-48a4-9b21-e8e1c7c6a565";
        public EQPCustServiceControl()
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

        private void initGrid()
        {
            var eqpCustServList = _customerController.GetEqpCustServiceList();
            if (!string.IsNullOrEmpty(eqpCustServList.ErrorMessage))
            {
                MessageBox.Show(eqpCustServList.ErrorMessage);
                return;
            }
            int index = 0;
            foreach(var item in eqpCustServList.resultList)
            {
                index = 0;
                var customerRep = _customerController.getCustomerList(item.客戶簡稱);
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                var customer = customerRep.resultList.FirstOrDefault();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item?.單號 ?? "";
                row.Cells[index++].Value = Utility.ConvertDate(item?.日期??"1900-01-01");
                row.Cells[index++].Value = item?.客戶簡稱??"";
                row.Cells[index++].Value = customer?.COMPANY;
                row.Cells[index++].Value = item?.專案序號??"";
                row.Cells[index++].Value = item?.機台型號 ?? "";
                row.Cells[index++].Value = item?.事件Events ?? "";
                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            //throw new NotImplementedException();
        }
    }
}
