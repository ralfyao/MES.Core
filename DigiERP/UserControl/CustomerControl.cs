using DigiERP.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl
{
    public partial class CustomerControl : System.Windows.Forms.UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (customerMaintainControl != null)
            {
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "新增";
                }
                customerMaintainControl.Visible = true;
            }
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
            //frmCustomerMaintain frm = new frmCustomerMaintain();
            //frm.Show();
        }
    }
}
