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
    public partial class FrmProduction : Form
    {
        private bool isloaded = false;

        private static string moduleId = "C00C0FB8-3C91-4CC2-AD47-309DBDFD8D1C";
        public FrmProduction()
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
            var menuList = new MenuController().GetModuleList(FrmProduction.moduleId);
            if (!string.IsNullOrEmpty(menuList.ErrorMessage))
            {
                MessageBox.Show(menuList.ErrorMessage);
                return;
            }
            treeView.Nodes.Clear();
            foreach (var menu in menuList.resultList)
            {
                foreach (var subMenu in menu.subModuleList)
                {
                    menuMappingDict.Add(subMenu.ModuleName, subMenu.ModuleClass.ToString());
                    treeView.Nodes.Add(new TreeNode() { Name = subMenu.ModuleName, Text = subMenu.子選單名稱 });
                }
            }
        }
        /// <summary>
        /// 供外部（如廠商維護頁的「廠商評鑑」按鈕）動態開啟新頁籤
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        public void AddTab(string title, Control content)
        {
            TabPage tab = new TabPage(title);
            tab.Name = Guid.NewGuid().ToString();
            content.Dock = DockStyle.Fill;
            tab.Controls.Add(content);
            tab.AutoScroll = true;
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
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
            ctrl.Name = tab.Name;
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
