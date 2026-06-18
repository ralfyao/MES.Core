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
using DigiERP.UserControl.Customer.Receivables;

namespace DigiERP
{
    public partial class FrmSupplier : Form
    {
        private bool isloaded = false;
        public FrmSupplier()
        {
            isloaded = false;
            InitializeComponent();
            initMenu();
            treeView.SelectedNode = null;
            ToggleDrawer(null, null);
            ToggleDrawer(null, null);
            isloaded = true;
        }

        private void initMenu()
        {
            //throw new NotImplementedException();
        }

        private void FrmCust_Shown(object sender, EventArgs e)
        {
            treeView.SelectedNode = null;
            this.ActiveControl = null;
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
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
                "Quotation" => new QuotationControl() { Width = tab.Width },
                "SalesOrder" => new OrderControl() { Width = tab.Width },
                "ShippingOrder" => new ShippingOrderControl() { Width = tab.Width },
                "AccountsReceivables" => new ReceivableControl() { Width = tab.Width },
                _ => null
            }; ;
            if (ctrl == null || ctrl.IsDisposed)
                return;
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
