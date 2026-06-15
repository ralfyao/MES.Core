using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.ShippingOrder
{
    public partial class FrmPrintShippingOrder : Form
    {
        public FrmPrintShippingOrder()
        {
            InitializeComponent();
        }

        private void FrmPrintShippingOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認關閉?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
    }
}
