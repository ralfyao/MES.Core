using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using DigiERP.Models;
using System.Diagnostics.Metrics;

namespace DigiERP.UserControl
{
    public partial class CustomerMaintainControl : System.Windows.Forms.UserControl
    {
        public CustomerMaintainControl()
        {
            InitializeComponent();
            coutrySelect1.inflateDropDownList();
            initMaList();
        }

        private void initMaList()
        {
            List<TextValue> maList = new List<TextValue>();
            string json = File.ReadAllText(@".\cAgent.json");
            maList = JsonSerializer.Deserialize<List<TextValue>>(json);
            cboIndustrry.DataSource = maList;
            cboIndustrry.DisplayMember = "Text";
            cboIndustrry.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
            coutrySelect1.SetCountryCode(string.Empty);
        }
    }
}
