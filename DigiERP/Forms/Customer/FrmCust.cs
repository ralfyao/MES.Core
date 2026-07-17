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
using MES.WebAPI.Controllers;

namespace DigiERP
{
    public partial class FrmCust : Form
    {
        private static string moduleId = "0FDCB68D-91BE-48A4-9B21-E8E1C7C6A565";
        private bool isloaded = false;
        public FrmCust()
        {
            isloaded = false;
            InitializeComponent();
            initMenu();
            treeView.SelectedNode = null;
            ToggleDrawer(null, null);
            ToggleDrawer(null, null);
            isloaded = true;
        }
        Dictionary<string, string> menuMappingDict = new Dictionary<string, string>();
        private void initMenu()
        {
            var menuList = new MenuController().GetModuleList(FrmCust.moduleId);
            if (!string.IsNullOrEmpty(menuList.ErrorMessage))
            {
                MessageBox.Show(menuList.ErrorMessage);
                return;
            }
            treeView.Nodes.Clear();
            foreach(var menu in menuList.resultList)
            {
                foreach(var subMenu in menu.subModuleList)
                {
                    menuMappingDict.Add(subMenu.ModuleName, subMenu.ModuleClass.ToString());
                    treeView.Nodes.Add(new TreeNode() { Name = subMenu.ModuleName, Text = subMenu.子選單名稱});
                }
            }
            
            //throw new NotImplementedException();
        }

        public void OpenNewAddQuotationForm(C報價單 quono)
        {
            foreach (TabPage page in tabControl.TabPages)
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

        internal void OpenNewAddSalesOrder(C訂單 salesOrder, string custId)
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == "SalesOrder")
                {
                    tabControl.TabPages.Remove(page);
                    break;
                }
            }
            TabPage tab = new TabPage($"訂單維護");
            tab.Name = "SalesOrder";
            tab.AutoScroll = true;
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
            OrderControl orderControl = new OrderControl() { Width = tab.Width };
            tab.Controls.Add(orderControl);
            orderControl.Dock = DockStyle.Fill;
            orderControl.custId = custId;
            //orderControl.(quono);
            orderControl.btnAdd_Click(null, null);
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

            string controlClass = string.Empty;
            if (menuMappingDict.ContainsKey(key))
            {
                controlClass = menuMappingDict[key];
            }
            if (string.IsNullOrEmpty(controlClass))
            {
                return;
            }
            Type type = Type.GetType(controlClass);
            if (type == null) return;

            // ── 子選單目標若是獨立視窗(Form)，改用 ShowDialog 開啟，不內嵌於頁籤 ──
            if (typeof(Form).IsAssignableFrom(type))
            {
                using var frm = (Form)Activator.CreateInstance(type);
                if (frm is DigiERP.UserControl.Inventory.StockIn.FrmVoucher voucherFrm)
                {
                    voucherFrm.HostTabControl = tabControl;
                }
                frm.ShowDialog(this);
                return;
            }

            Control ctrl = (Control)Activator.CreateInstance(type);
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

        internal void OpenNewAddShippingOrder(C訂單 salesOrder)
        {
            //throw new NotImplementedException();
        }
    }
}
