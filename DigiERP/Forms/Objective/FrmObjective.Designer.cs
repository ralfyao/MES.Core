using DigiERP.UserControl;
using DigiERP.UserControl.Customer.RFQ;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiERP
{
    partial class FrmObjective
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjective));
            sidebar = new Panel();
            splitContainer = new SplitContainer();
            treeView = new System.Windows.Forms.TreeView();
            tabControl = new TabControl();
            animationTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.DarkGray;
            sidebar.Cursor = Cursors.Hand;
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(25, 669);
            sidebar.TabIndex = 1;
            sidebar.Click += ToggleDrawer;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(25, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.AutoScroll = true;
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new Size(1161, 669);
            splitContainer.SplitterDistance = 387;
            splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Fill;
            treeView.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(387, 669);
            treeView.TabIndex = 0;
            treeView.AfterSelect += TreeView_AfterSelect;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(770, 669);
            tabControl.TabIndex = 0;
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;
            // 
            // animationTimer
            // 
            animationTimer.Interval = 5;
            animationTimer.Tick += Timer_Tick;
            // 
            // FrmObjective
            // 
            ClientSize = new Size(1186, 669);
            Controls.Add(splitContainer);
            Controls.Add(sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmObjective";
            Text = "Goal目標管理";
            WindowState = FormWindowState.Maximized;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.Text = "CRM客戶關係";
        //    this.Width = 1200;
        //    this.Height = 700;
        //    this.WindowState = FormWindowState.Maximized;

        //    // Sidebar (always visible)
        //    sidebar = new Panel();
        //    sidebar.Width = 25;
        //    sidebar.Dock = DockStyle.Left;
        //    sidebar.BackColor = Color.DarkGray;
        //    sidebar.Cursor = Cursors.Hand;
        //    sidebar.Click += ToggleDrawer;

        //    // SplitContainer
        //    splitContainer = new SplitContainer();
        //    splitContainer.Dock = DockStyle.Fill;
        //    splitContainer.SplitterDistance = targetWidth;

        //    // TreeView
        //    treeView = new TreeView();
        //    treeView.Dock = DockStyle.Fill;
        //    treeView.AfterSelect += TreeView_AfterSelect;
        //    treeView.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);

        //    treeView.Nodes.Add(new TreeNode("客戶管理") { Name = "Customer" });
        //    treeView.Nodes.Add(new TreeNode("訂單管理") { Name = "Order" });

        //    // TabControl
        //    tabControl = new TabControl();
        //    tabControl.Dock = DockStyle.Fill;
        //    tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
        //    tabControl.DrawItem += TabControl_DrawItem;
        //    tabControl.MouseDown += TabControl_MouseDown;

        //    // Animation Timer
        //    animationTimer = new System.Windows.Forms.Timer();
        //    animationTimer.Interval = 10;
        //    animationTimer.Tick += Timer_Tick;

        //    splitContainer.Panel1.Controls.Add(treeView);
        //    splitContainer.Panel2.Controls.Add(tabControl);

        //    this.Controls.Add(splitContainer);
        //    this.Controls.Add(sidebar);
        //    ToggleDrawer(null, null);
        //    ToggleDrawer(null, null);
        //}

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