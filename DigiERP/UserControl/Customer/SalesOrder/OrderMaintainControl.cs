using DigiERP.Common;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.SalesOrder
{
    public partial class OrderMaintainControl : CommonUserControl
    {
        public C訂單 form;
        public OrderMaintainControl()
        {
            InitializeComponent();
        }
        public OrderMaintainControl(C訂單 form)
        {
            InitializeComponent();
            this.form = form;
        }

        internal void initForm()
        {
            //throw new NotImplementedException();
            if (lblMode.Text == "新增")
            {

            }
            else if (lblMode.Text == "修改")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }
    }
}
