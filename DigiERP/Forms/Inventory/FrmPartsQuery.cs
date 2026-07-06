using DigiERP.UserControl.Inventory;
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

namespace DigiERP.Forms.Inventory
{
    public partial class FrmPartsQuery : Form
    {
        private ItemController _controller;
        public FrmPartsQuery()
        {
            InitializeComponent();
        }
        private void initController()
        {
            _controller ??= new ItemController();
        }
        public List<A材料> summaryRepList;
        public Dictionary<string, A材料庫存彙總> summaryAggregateRepList;
        private void btn選自料品_Click(object sender, EventArgs e)
        {
            initController();
            var summaryRep = _controller.ItemListByKeywordSerial(txtKeyword1.Text, txtKeyword2.Text, txtKeyword3.Text, txtProjSerial.Text);
            if (!string.IsNullOrEmpty(summaryRep.ErrorMessage))
            {
                MessageBox.Show(summaryRep.ErrorMessage);
                return;
            }

            using var frmSelect = new FrmSelectPartCode(summaryRep.resultList ?? new List<A材料>());
            if (frmSelect.ShowDialog(this) != DialogResult.OK) return;

            summaryRepList = frmSelect.SelectedItems;
            var summaryAggregateRep = _controller.GetStockSummaryList(txtKeyword1.Text, txtKeyword2.Text, txtKeyword3.Text, txtProjSerial.Text);
            if (!string.IsNullOrEmpty(summaryAggregateRep.ErrorMessage))
            {
                MessageBox.Show(summaryAggregateRep.ErrorMessage);
                return;
            }
            summaryAggregateRepList = (summaryAggregateRep.resultList ?? new List<A材料庫存彙總>())
                .Where(x => !string.IsNullOrEmpty(x.產品編號))
                .ToDictionary(x => x.產品編號!, x => x);
            this.DialogResult = DialogResult.OK;
        }
    }

}
