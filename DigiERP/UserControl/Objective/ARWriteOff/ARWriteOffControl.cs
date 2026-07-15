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

namespace DigiERP.UserControl.Objective.ARWriteOff
{
    public partial class ARWriteOffControl : CommonUserControl
    {
        private static string id = "a688ada1-1fa2-481a-9a2c-16a0cb90d665";
        public string custId { get; set; }
        private ARController _arControlle;
        private F沖款收 form;
        public ARWriteOffControl()
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

        public ARWriteOffControl(string custId)
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
            var rWoffList = _arControlle.RWirteOffList(custId);
            if (!string.IsNullOrEmpty(rWoffList.ErrorMessage))
            {
                MessageBox.Show(rWoffList.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in rWoffList.resultList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.單號;
                row.Cells[index++].Value = item.日期;
                row.Cells[index++].Value = item.客戶編號;
                row.Cells[index++].Value = item.幣別;
                row.Cells[index++].Value = item.原幣加總();
                row.Cells[index++].Value = item.台幣加總();
                row.Cells[index++].Value = item.折讓加總();
                row.Cells[index++].Value = item.匯差加總();
                row.Cells[index++].Value = item.核准;
                row.Cells[index++].Value = item.核准日;

                dataGridView1.Rows.Add(row);
            }
            //throw new NotImplementedException();
        }

        private void initController()
        {
            if (_arControlle == null)
            {
                _arControlle = new ARController();
            }
            //throw new NotImplementedException();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {

        }
    }
}
