using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Common
{
    // ── 分頁內容捲動：畫面內容(例如表頭 Panel 裡以固定座標擺放的欄位/按鈕)超出
    //    分頁可視範圍時，自動在畫面根控制項上出現垂直/水平捲軸，可以捲過去看到
    //    被遮住的元件。
    //    作法：根控制項(UserControl，Dock=Fill)開啟 AutoScroll，並把
    //    AutoScrollMinSize 設成「內容實際需要的最小尺寸」；ScrollableControl 會以
    //    此尺寸作為 DisplayRectangle 排版，Dock=Top/Fill 的 Panel 會跟著被撐寬，
    //    固定座標的元件就不會被切掉，視窗夠大時則照常填滿、不出現捲軸。
    //    Attach() 掛在各主畫面共用的 TabControl 上，之後新增的任何分頁都會自動套用；
    //    ZoomMessageFilter 縮放後也會呼叫 Update() 重新計算 ─────────────────────
    public static class ContentScroller
    {
        private const int Margin = 8;
        private static readonly HashSet<TabControl> _wired = new HashSet<TabControl>();

        public static void Attach(TabControl tabControl)
        {
            if (tabControl == null || !_wired.Add(tabControl)) return;

            foreach (TabPage page in tabControl.TabPages)
            {
                WirePage(page);
            }
            tabControl.ControlAdded += (s, e) =>
            {
                if (e.Control is TabPage page) WirePage(page);
            };
        }

        private static void WirePage(TabPage page)
        {
            foreach (Control c in page.Controls)
            {
                WireRoot(c);
            }
            page.ControlAdded += (s, e) => WireRoot(e.Control);
        }

        private static void WireRoot(Control root)
        {
            Update(root);
            // 加入分頁當下可能還沒套用 DPI 自動縮放，建立 Handle 後再重新計算一次
            EventHandler onCreated = null;
            onCreated = (s, e) =>
            {
                root.HandleCreated -= onCreated;
                root.BeginInvoke(new Action(() => Update(root)));
            };
            if (root.IsHandleCreated)
                root.BeginInvoke(new Action(() => Update(root)));
            else
                root.HandleCreated += onCreated;
        }

        // ── 依目前內容重新計算捲動範圍；只處理 Dock=Fill 的可捲動根控制項 ──────
        public static void Update(Control root)
        {
            if (!(root is ScrollableControl sc) || root.Dock != DockStyle.Fill) return;

            // 先捲回原點，確保子控制項座標不含捲動位移
            sc.AutoScrollPosition = Point.Empty;
            sc.AutoScrollMinSize = Size.Empty;
            sc.AutoScroll = true;
            sc.AutoScrollMinSize = MeasureNeed(root);
        }

        // ── 計算容器要完整顯示所有子控制項所需的最小尺寸。會隨父層伸縮的子控制項
        //    (Dock，或同時錨定左右/上下)不看它目前的大小，而是遞迴計算它自己內容
        //    所需，避免「目前被撐多大就要求多大」而無法縮回 ──────────────────────
        private static Size MeasureNeed(Control container)
        {
            int w = 0, h = 0;
            int dockLR = 0, dockTB = 0;
            Size fillNeed = Size.Empty;

            foreach (Control ch in container.Controls)
            {
                if (!ch.Visible) continue;

                switch (ch.Dock)
                {
                    case DockStyle.Top:
                    case DockStyle.Bottom:
                        dockTB += ch.Height;
                        w = Math.Max(w, ChildNeed(ch).Width);
                        break;
                    case DockStyle.Left:
                    case DockStyle.Right:
                        dockLR += ch.Width;
                        h = Math.Max(h, ChildNeed(ch).Height);
                        break;
                    case DockStyle.Fill:
                        var need = ChildNeed(ch);
                        fillNeed = new Size(Math.Max(fillNeed.Width, need.Width), Math.Max(fillNeed.Height, need.Height));
                        break;
                    default:
                        bool stretchW = (ch.Anchor & (AnchorStyles.Left | AnchorStyles.Right)) == (AnchorStyles.Left | AnchorStyles.Right);
                        bool stretchH = (ch.Anchor & (AnchorStyles.Top | AnchorStyles.Bottom)) == (AnchorStyles.Top | AnchorStyles.Bottom);
                        var childNeed = (stretchW || stretchH) ? ChildNeed(ch) : Size.Empty;
                        w = Math.Max(w, stretchW ? ch.Left + childNeed.Width : ch.Right);
                        h = Math.Max(h, stretchH ? ch.Top + childNeed.Height : ch.Bottom);
                        break;
                }
            }

            w = Math.Max(w, dockLR + fillNeed.Width);
            h = Math.Max(h, dockTB + fillNeed.Height);
            if (w > 0) w += container.Padding.Right + Margin;
            if (h > 0) h += container.Padding.Bottom + Margin;
            return new Size(w, h);
        }

        private static Size ChildNeed(Control ch)
        {
            // DataGridView/TextBox 等本身有捲軸或不是版面容器的控制項，不往內計算
            bool isLayoutContainer = ch is Panel || ch is GroupBox || ch is SplitContainer || ch is TableLayoutPanel
                                     || ch is FlowLayoutPanel || ch is TabControl || ch is TabPage || ch is SplitterPanel
                                     || ch is System.Windows.Forms.UserControl;
            var need = isLayoutContainer ? MeasureNeed(ch) : Size.Empty;
            return new Size(Math.Max(need.Width, ch.MinimumSize.Width), Math.Max(need.Height, ch.MinimumSize.Height));
        }
    }
}
