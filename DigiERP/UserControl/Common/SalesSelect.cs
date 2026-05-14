using MES.Core.Model;
using MES.Core.Repository.Impl;
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

namespace DigiERP.UserControl.Common
{
    public partial class SalesSelect : System.Windows.Forms.UserControl
    {
        public SalesSelect()
        {
            InitializeComponent();
            initSelection();
        }
        List<H員工清冊> hs = null;
        private void initSelection()
        {
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            hs = humanResourceRepository.GetListBy(new H員工清冊() { 職能 = "業務" }, "職能").Where(x => x.狀況 == "正常").ToList();
            SetDataSource(hs);
            lblSalesName.Text = "";
        }

        public void SetDataSource(List<H員工清冊> dataSource)
        {
            if (dataSource != null)
            {
                cboSales.DataSource = dataSource;
            }
            cboSales.ValueMember = "工號";
            cboSales.DisplayMember = "工號";
        }
        public string GetSalesCode()
        {
            return cboSales.Text;
        }
        public void SetSalesCode(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                cboSales.Text = code;
                lblSalesName.Text = (from c in hs where c.工號 == code select c).FirstOrDefault()?.姓名??"";
            }
            else
            {
                cboSales.Text = string.Empty;
                lblSalesName.Text = string.Empty;
            }
        }

        private void cboSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSalesName.Text = (from c in hs where c.工號 == cboSales.Text select c).FirstOrDefault()?.姓名??"";
        }
    }
}
