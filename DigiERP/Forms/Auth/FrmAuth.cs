using DigiERP.Forms;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.UserControl.Auth
{
    public partial class FrmAuth : CommonForm
    {
        private AutheiticateController _controller;
        public FrmAuth()
        {
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initGrid()
        {
            CommonRep<H員工清冊> authRep = _controller.GetAllHRData();
            if (!string.IsNullOrEmpty(authRep.ErrorMessage))
            {
                MessageBox.Show(authRep.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in authRep.resultList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                dataGridView1.Rows.Add(row);
            }
        }

        private void initController()
        {
            if (_controller == null)
            {
                _controller = new AutheiticateController();
            }
        }
    }
}
