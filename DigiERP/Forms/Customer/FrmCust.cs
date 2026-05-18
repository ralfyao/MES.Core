using DigiERP.UserControl.Customer.RFQ;
using DigiERP.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DigiERP.UserControl.Customer.Quotation;

namespace DigiERP
{
    public partial class FrmCust : Form
    {
        public FrmCust()
        {
            InitializeComponent();
            treeView.SelectedNode = null;
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = e.Node.Name;

            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == key)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }

            TabPage tab = new TabPage(e.Node.Text);
            tab.Name = key;

            Control ctrl = key switch
            {
                "Customer" => new CustomerControl() { Width = tab.Width },
                "Order" => new OrderControl() { Width = tab.Width },
                "RFQ" => new RFQControl() { Width = tab.Width },
                "Quotation" => new QuotationControl() {  Width = tab.Width },
                _ => null
            }; ;

            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                tab.Controls.Add(ctrl);
            }
            tab.AutoScroll = true;
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
        }
    }
}
