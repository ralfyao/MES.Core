using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmAddAR : Form
    {
        public string installmentPeriod { get; set; }
        public decimal 成數 { get; set; }
        public decimal 金額 { get; set; }
        public FrmAddAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            installmentPeriod = cboInstallmentPeriod.Text;
            成數 = numPercent.Value;
            金額 = numAmount.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
