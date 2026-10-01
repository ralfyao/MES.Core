using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DigiERP.Common
{
    // ── 全域縮放：在任一畫面上按住 Ctrl 滾動滑鼠滾輪，放大/縮小該畫面(比照瀏覽器
    //    Ctrl+滾輪縮放頁面的操作方式)。以 IMessageFilter 攔截 WM_MOUSEWHEEL，找出
    //    滑鼠所在的「畫面根控制項」(往上找到最近一層、其 Parent 是 TabPage 或
    //    Form 的祖先本身，亦即該分頁底下的最外層畫面控制項——切勿只判斷到 Form
    //    為止，否則會一路爬到共用的 TabControl，導致縮放整個 TabControl 底下
    //    "所有" 分頁而非只有目前這一頁)：
    //      1. Control.Scale() 等比例縮放底下所有子控制項的座標/大小(含固定座標
    //         擺放的表頭欄位)，並額外遞迴縮放每個子控制項自身的 Font(Scale() 對
    //         AutoScaleMode.Font 只會調整根控制項自己的字型，不會處理子控制項)。
    //      2. DataGridView 另外處理欄寬(Width)、ColumnHeadersHeight、儲存格樣式
    //         Font(皆不算在 Control.Bounds/Font 底下)，並在字型變更後呼叫
    //         AutoResizeRows() 讓既有列高跟著文字調整。
    //      3. 根控制項改為固定大小(取消 Dock，依原始大小 × 目前縮放倍率設定絕對
    //         尺寸)，並開啟其父層(通常是 TabPage)的 AutoScroll，讓放大超出可視
    //         範圍時能夠捲動檢視，取代原本 Dock=Fill 被父層鎖死大小、放大也看不
    //         到超出部分的問題。縮小(< 100%)時則只縮小元件，根控制項維持原本的
    //         Dock/大小填滿分頁，不會連畫面本體一起縮小而切到元件。
    //    Reset() 供 TabNavigator 呼叫：關閉分頁、切回來源分頁時，強制把來源分頁
    //    的內容重置回 100%(而非延續使用者先前對它做過的縮放) ───────────────────
    public class ZoomMessageFilter : IMessageFilter
    {
        private const int WM_MOUSEWHEEL = 0x020A;
        private const float ZoomStep = 1.1f;
        private const float MinZoom = 0.6f;
        private const float MaxZoom = 2.5f;

        private class ZoomState
        {
            public float Level = 1f;
            public Size OriginalSize;
            public DockStyle OriginalDock;
            public Size? OriginalFormSize;
            public bool Captured;
        }

        private static readonly ConditionalWeakTable<Control, ZoomState> _zoomStates = new ConditionalWeakTable<Control, ZoomState>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg != WM_MOUSEWHEEL) return false;
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control) return false;

            Control target = Control.FromHandle(m.HWnd);
            if (target == null) return false;

            target = FindZoomRoot(target);
            if (target == null) return false;

            var state = _zoomStates.GetOrCreateValue(target);
            CaptureOriginal(target, state);

            short wheelDelta = (short)((m.WParam.ToInt64() >> 16) & 0xFFFF);
            float newLevel = wheelDelta > 0 ? state.Level * ZoomStep : state.Level / ZoomStep;
            newLevel = Math.Max(MinZoom, Math.Min(MaxZoom, newLevel));

            if (Math.Abs(newLevel - state.Level) > 0.001f)
            {
                ApplyZoom(target, state, newLevel);
            }

            return true;
        }

        // ── 找出「畫面根控制項」：往上爬，直到爬到的這一層自己的 Parent 已經是
        //    TabPage 或 Form 為止(此時這一層即為單一分頁/視窗底下的畫面本體)，
        //    避免繼續往上爬到 TabPage 或共用的 TabControl 本身 ───────────────
        private static Control FindZoomRoot(Control control)
        {
            while (control.Parent != null && !(control.Parent is TabPage) && !(control.Parent is Form))
            {
                control = control.Parent;
            }
            return control;
        }

        private static void CaptureOriginal(Control target, ZoomState state)
        {
            if (state.Captured) return;
            state.OriginalSize = target.Size;
            state.OriginalDock = target.Dock;
            if (target.Parent is Form form)
            {
                state.OriginalFormSize = form.Size;
            }
            state.Captured = true;
        }

        private static void ApplyZoom(Control target, ZoomState state, float newLevel)
        {
            float factor = newLevel / state.Level;
            bool isForm = target.Parent is Form && state.OriginalFormSize.HasValue;

            if (!isForm)
            {
                // 先捲回原點並清掉捲動範圍，避免子控制項座標帶著捲動位移一起被縮放
                if (target is ScrollableControl sc && sc.AutoScroll)
                {
                    sc.AutoScrollPosition = Point.Empty;
                    sc.AutoScrollMinSize = Size.Empty;
                }

                // 縮放前先解除 Dock、以目前實際大小固定下來，讓 Scale() 連同根控制項本身
                // 一起等比例縮放。若在 Dock=Fill 狀態下 Scale()，根控制項大小不會跟著變，
                // 之後才另外調整根控制項大小時，錨定在右/下側(Anchor Right/Bottom)的子
                // 控制項會被「重複縮放」一次，導致縮小時右側元件被切掉
                var currentSize = target.Size;
                target.Dock = DockStyle.None;
                target.Location = Point.Empty;
                target.Size = currentSize;
            }

            target.Scale(new SizeF(factor, factor));
            ScaleFonts(target, factor);

            bool isReset = Math.Abs(newLevel - 1f) < 0.001f;

            if (target.Parent is Form form && state.OriginalFormSize.HasValue)
            {
                // 獨立視窗(非分頁)：連同包住 Control 的 Form 本身一起縮放/還原大小，
                // 內容本身維持原本的 Dock 讓它自動填滿新的視窗大小，不需額外開捲軸
                form.Size = isReset
                    ? state.OriginalFormSize.Value
                    : new Size(
                        Math.Max(200, (int)(state.OriginalFormSize.Value.Width * newLevel)),
                        Math.Max(150, (int)(state.OriginalFormSize.Value.Height * newLevel)));
                target.Dock = state.OriginalDock;
            }
            else if (state.OriginalDock == DockStyle.Fill && target is ScrollableControl)
            {
                // 分頁畫面(Dock=Fill)：不論放大/縮小，畫面本體都維持填滿分頁，只縮放裡面
                // 的元件；內容超出可視範圍時由 ContentScroller 在畫面本體上開垂直/水平
                // 捲軸，可以捲過去看到被遮住的元件
                target.Dock = DockStyle.Fill;
                target.Location = Point.Empty;
                ContentScroller.Update(target);
            }
            else if (isReset || newLevel < 1f)
            {
                // 回到 100% 或縮小：只縮小裡面的元件，畫面本體(根控制項)維持原本的 Dock/
                // 大小照常填滿分頁，不跟著縮小——錨定在右/下側的元件會隨之貼齊邊緣，
                // 不會被切掉，也不留殘留的固定尺寸/捲動狀態
                target.Dock = state.OriginalDock;
                target.Location = Point.Empty;
                if (state.OriginalDock == DockStyle.None)
                {
                    target.Size = state.OriginalSize;
                }
            }
            else
            {
                if (target.Parent is ScrollableControl scrollableParent)
                {
                    scrollableParent.AutoScroll = true;
                }
                target.Dock = DockStyle.None;
                target.Size = new Size(
                    Math.Max(1, (int)(state.OriginalSize.Width * newLevel)),
                    Math.Max(1, (int)(state.OriginalSize.Height * newLevel)));
                target.Location = Point.Empty;
            }

            state.Level = newLevel;
        }

        // ── 供 TabNavigator 呼叫：分頁關閉、自動切回來源分頁時，把來源分頁的內容
        //    強制重置回 100%，不延續使用者先前對它做過的縮放 ───────────────────
        public static void Reset(Control root)
        {
            if (root == null) return;
            var target = FindZoomRoot(root);
            if (!_zoomStates.TryGetValue(target, out var state)) return;
            if (Math.Abs(state.Level - 1f) < 0.001f) return;

            ApplyZoom(target, state, 1f);
        }

        private static void ScaleFonts(Control control, float factor)
        {
            if (control.Font != null)
            {
                float newSize = Math.Max(6f, control.Font.Size * factor);
                control.Font = new Font(control.Font.FontFamily, newSize, control.Font.Style);
            }

            if (control is DataGridView grid)
            {
                ScaleCellStyleFont(grid.DefaultCellStyle, factor);
                ScaleCellStyleFont(grid.ColumnHeadersDefaultCellStyle, factor);
                ScaleCellStyleFont(grid.RowHeadersDefaultCellStyle, factor);
                if (grid.ColumnHeadersHeightSizeMode != DataGridViewColumnHeadersHeightSizeMode.AutoSize)
                {
                    grid.ColumnHeadersHeight = Math.Max(15, (int)(grid.ColumnHeadersHeight * factor));
                }
                grid.RowTemplate.Height = Math.Max(15, (int)(grid.RowTemplate.Height * factor));
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    ScaleCellStyleFont(col.DefaultCellStyle, factor);
                    col.Width = Math.Max(20, (int)(col.Width * factor));
                }
                grid.AutoResizeColumnHeadersHeight();
                grid.AutoResizeRows();
            }

            foreach (Control child in control.Controls)
            {
                ScaleFonts(child, factor);
            }
        }

        private static void ScaleCellStyleFont(DataGridViewCellStyle style, float factor)
        {
            if (style?.Font == null) return;
            float newSize = Math.Max(6f, style.Font.Size * factor);
            style.Font = new Font(style.Font.FontFamily, newSize, style.Font.Style);
        }
    }
}
