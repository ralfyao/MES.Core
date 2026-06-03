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
using MES.Core.Model;
using DigiERP.UserControl.SalesOrder;
using DigiERP.UserControl.Customer;
using DigiERP.UserControl.Customer.ShippingOrder;

namespace DigiERP
{
    public partial class FrmCust : Form
    {
        public FrmCust()
        {
            InitializeComponent();
            initMenu();
            treeView.SelectedNode = null;
            ToggleDrawer(null, null);
            ToggleDrawer(null, null);
        }

        private void initMenu()
        {
            //throw new NotImplementedException();
        }

        public void OpenNewAddQuotationForm(C報價單 quono)
        {
            foreach(TabPage page in tabControl.TabPages)
            {
                if (page.Name == "Quotation")
                {
                    page.Dispose();
                    break;
                }
            }
            TabPage tab = new TabPage($"產品報價");
            tab.Name = "Quotation";
            tab.AutoScroll = true;
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
            QuotationControl quotationControl = new QuotationControl() { Width = tab.Width };
            tab.Controls.Add(quotationControl);
            quotationControl.Dock = DockStyle.Fill;
            quotationControl.SetQuotation(quono);
            quotationControl.button1_Click(null, null);
        }

        internal void OpenNewAddSalesOrder(C訂單 salesOrder)
        {
            //throw new NotImplementedException();
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
                //"Order" => new OrderControl() { Width = tab.Width },
                "RFQ" => new RFQControl() { Width = tab.Width },
                "Quotation" => new QuotationControl() {  Width = tab.Width },
                "SalesOrder" => new OrderControl() {  Width = tab.Width },
                "ShippingOrder" => new ShippingOrderControl() {  Width = tab.Width },
                _ => null
            }; ;

            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                tab.Controls.Add(ctrl);
            }
            tab.AutoScroll = true;
            try
            {
                tabControl.TabPages.Add(tab);
                tabControl.SelectedTab = tab;
                tabControl.SizeMode = TabSizeMode.Fixed;
                tabControl.ItemSize = new Size(120, 30);
            }
            catch { }
        }
    }
}
