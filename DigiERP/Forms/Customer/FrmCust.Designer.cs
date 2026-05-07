using DigiERP.UserControl;
using System.Windows.Forms;

namespace DigiERP
{
    partial class FrmCust
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer;
        private TreeView treeView;
        private TabControl tabControl;
        private Panel sidebar;
        private System.Windows.Forms.Timer animationTimer;

        bool isOpen = true;        // 目前是否展開
        bool isAnimating = false; // 是否動畫中
        bool isOpening = false;   // 這次動畫方向

        int targetWidth = 200;    // 展開寬度
        bool expand = true;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "主畫面";
            this.Width = 1200;
            this.Height = 700;
            this.WindowState = FormWindowState.Maximized;

            // Sidebar (always visible)
            sidebar = new Panel();
            sidebar.Width = 25;
            sidebar.Dock = DockStyle.Left;
            sidebar.BackColor = Color.DarkGray;
            sidebar.Cursor = Cursors.Hand;
            sidebar.Click += ToggleDrawer;

            // SplitContainer
            splitContainer = new SplitContainer();
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.SplitterDistance = targetWidth;

            // TreeView
            treeView = new TreeView();
            treeView.Dock = DockStyle.Fill;
            treeView.AfterSelect += TreeView_AfterSelect;
            treeView.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);

            treeView.Nodes.Add(new TreeNode("客戶管理") { Name = "Customer" });
            treeView.Nodes.Add(new TreeNode("訂單管理") { Name = "Order" });

            // TabControl
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;

            // Animation Timer
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += Timer_Tick;

            splitContainer.Panel1.Controls.Add(treeView);
            splitContainer.Panel2.Controls.Add(tabControl);

            this.Controls.Add(splitContainer);
            this.Controls.Add(sidebar);
            ToggleDrawer(null, null);
            ToggleDrawer(null, null);
        }
        private void ToggleDrawer(object sender, EventArgs e)
        {
            // 如果目前是收起來 → 要展開
            if (splitContainer.Panel1Collapsed)
            {
                splitContainer.Panel1Collapsed = false;
                expand = true;
            }
            else
            {
                splitContainer.Panel1Collapsed = true;
                expand = false;
            }

            animationTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                // 👉 展開
                splitContainer.SplitterDistance += 20;

                if (splitContainer.SplitterDistance >= targetWidth)
                {
                    splitContainer.SplitterDistance = targetWidth;
                    animationTimer.Stop();
                }
            }
            else
            {
                try
                {
                    // 👉 收合
                    splitContainer.SplitterDistance -= 20;

                    if (splitContainer.SplitterDistance <= 0)
                    {
                        animationTimer.Stop();
                        splitContainer.Panel1Collapsed = true;
                    }
                }
                catch { }
            }
        }

        private void AnimateDrawer(object sender, EventArgs e)
        {
            if (isOpening)
            {
                // 👉 展開
                splitContainer.SplitterDistance += 20;

                if (splitContainer.SplitterDistance >= targetWidth)
                {
                    splitContainer.SplitterDistance = targetWidth;

                    animationTimer.Stop();
                    isAnimating = false;
                    isOpen = true;
                }
            }
            else
            {
                // 👉 收合
                splitContainer.SplitterDistance -= 20;

                if (splitContainer.SplitterDistance <= 0)
                {
                    animationTimer.Stop();

                    splitContainer.Panel1Collapsed = true; // 最後才真的隱藏
                    isAnimating = false;
                    isOpen = false;
                }
            }
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
                "Customer" => new CustomerControl(),
                "Order" => new OrderControl(),
                _ => null
            };

            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                tab.Controls.Add(ctrl);
            }

            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = tabControl.TabPages[e.Index];
            var rect = e.Bounds;

            e.Graphics.DrawString(tab.Text, Font, Brushes.Black, rect.X, rect.Y);

            // Draw X
            e.Graphics.DrawString("x", Font, Brushes.Red, rect.Right - 15, rect.Y);
        }

        private void TabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top, 15, 15);

                if (closeButton.Contains(e.Location))
                {
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion
    }
}