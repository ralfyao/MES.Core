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

namespace DigiERP.Forms.Customer.Quotation
{
    public partial class FrmAddQuotation : Form
    {
        public FrmAddQuotation()
        {
            InitializeComponent();
        }
        public string QUONO { get; set; }
        C報價明細 data = new C報價明細();
        public C報價明細 GetData()
        {
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.QUONO = QUONO;
            data.產品編號 = txtProductId.Text;
            data.品名規格 = txtProductName.Text;
            data.單位 = txtUnit.Text;
            data.單價 = numUnitPrice.Value;
            data.數量 = numQuantity.Value;
            data.金額 = numAmount.Value;
            data.描述 = txtDescription.Text;
            Dispose();
            Close();
        }
    }
}
