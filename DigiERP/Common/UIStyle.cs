using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DigiERP.Common
{
    /// <summary>
    /// 全專案共用的表單設計常數（字體、顏色、標準尺寸）。
    /// 新表單與既有表單的修正皆應從此處取值，取代個別表單各自硬編碼的做法。
    /// </summary>
    public static class UIStyle
    {
        // 欄位取得焦點時的提示色，沿用 CommonTextBox/CommonComboBox/CommonDateTimePicker/CommonNumericUpDown/CommonCheckBox 既有行為。
        public static readonly Color FocusBackColor = Color.LightYellow;

        // 唯讀欄位底色：專案中最多表單已採用的顏色（WhiteSmoke），做為往後補色的統一標準。
        public static readonly Color ReadOnlyBackColor = Color.WhiteSmoke;

        // 可編輯欄位底色（沿用系統預設）。
        public static readonly Color EditableBackColor = SystemColors.Window;

        // 標準輸入欄位／按鈕尺寸，供新表單排版參考。
        public const int InputHeight = 32;
        public const int ButtonWidth = 100;
        public const int ButtonHeight = 32;

        // 按鈕語意顏色，供新表單排版參考。
        public static readonly Color ButtonSaveColor = Color.SteelBlue;
        public static readonly Color ButtonAddColor = Color.BlueViolet;
        public static readonly Color ButtonDeleteColor = Color.IndianRed;
        public static readonly Color ButtonApproveColor = Color.SeaGreen;
        public static readonly Color ButtonCancelApproveColor = Color.Orange;
        public static readonly Color ButtonNeutralColor = Color.Gainsboro;
        public static readonly Color ButtonExitColor = Color.DimGray;
        public static readonly Color ButtonForeColor = Color.Black;

        // 表單標準字體。
        public static readonly Font FormFont = new Font("Microsoft JhengHei UI", 10F);
        public static readonly Font TitleFont = new Font("微軟正黑體", 18F, FontStyle.Bold);
        public static readonly Color TitleColor = Color.Firebrick;

        // 按鈕尺寸規則：高度固定，寬度依文字長度自動計算（類似 CSS 的 height 固定 + width: auto + padding）。
        // MinWidth 避免極短文字（如「OK」）的按鈕過窄；Padding 是文字左右各留的間距。
        public const int ButtonMinWidth = 70;
        public const int ButtonHorizontalPadding = 32;

        // Tag="btn-modify" 按鈕的圓角半徑(px)。
        public const int ButtonCornerRadius = 5;

        // 樣式 class 表：在設計器把控制項的 Tag 設成這裡的鍵（可空白分隔多個，類似 CSS 的 class="a b"），
        // ApplyControlStyle 會自動套用對應樣式，覆蓋掉預設值。要新增一種樣式，只要在這裡加一筆規則即可，
        // 不用改 BaseForm／CommonUserControl，也不用逐一表單修改程式碼。
        public static readonly Dictionary<string, Action<Control>> StyleClasses =
            new(StringComparer.OrdinalIgnoreCase)
            {
                ["title"] = c => { c.Font = TitleFont; c.ForeColor = TitleColor; },
                ["btn-add"] = c => ApplyButtonColor(c, ButtonNeutralColor),
                ["btn-save"] = c => ApplyButtonColor(c, ButtonNeutralColor),
                ["btn-modify"] = c => { ApplyButtonColor(c, ButtonNeutralColor); if (c is Button btn) ApplyRoundedCorners(btn, ButtonCornerRadius); },
                ["btn-delete"] = c => ApplyButtonColor(c, ButtonDeleteColor),
                ["btn-approve"] = c => ApplyButtonColor(c, ButtonNeutralColor),
                ["btn-cancel-approve"] = c => ApplyButtonColor(c, ButtonNeutralColor),
                ["btn-exit"] = c => ApplyButtonColor(c, ButtonExitColor),
                ["btn-neutral"] = c => ApplyButtonColor(c, ButtonNeutralColor),
                ["readonly"] = c => c.BackColor = ReadOnlyBackColor,
                ["editable"] = c => c.BackColor = EditableBackColor,
            };

        private static void ApplyButtonColor(Control c, Color backColor)
        {
            c.BackColor = backColor;
            c.ForeColor = ButtonForeColor;
        }

        // WinForms 按鈕沒有原生圓角屬性，且 Region 裁切只能做出鋸齒狀的硬切角、
        // 切掉的角落也不會有邊框線。改為完全自行繪製(Paint 事件)：先用父容器
        // 底色蓋掉 FlatStyle 預設畫的方角背景，再以反鋸齒(AntiAlias)填色+描邊
        // 畫出圓角矩形本體，讓圓角處的邊框線也能平滑地畫出來；Hover/按下的變色
        // 狀態改由自己追蹤(isHover/isPressed)，取代 FlatAppearance 內建的方角
        // 版本 ──────────────────────────────────────────────────────────────
        private static void ApplyRoundedCorners(Button button, int radius)
        {
            bool isHover = false;
            bool isPressed = false;

            void Paint(object? sender, PaintEventArgs e)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                var rect = new Rectangle(0, 0, Math.Max(1, button.Width - 1), Math.Max(1, button.Height - 1));
                int d = Math.Max(2, Math.Min(radius * 2, Math.Min(rect.Width, rect.Height)));
                using var path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                Color parentColor = button.Parent?.BackColor ?? SystemColors.Control;
                using (var eraseBrush = new SolidBrush(parentColor))
                {
                    g.FillRectangle(eraseBrush, button.ClientRectangle);
                }

                Color fill = isPressed ? button.FlatAppearance.MouseDownBackColor
                    : isHover ? button.FlatAppearance.MouseOverBackColor
                    : button.BackColor;
                using (var fillBrush = new SolidBrush(fill))
                {
                    g.FillPath(fillBrush, path);
                }
                using (var pen = new Pen(button.FlatAppearance.BorderColor, Math.Max(1, button.FlatAppearance.BorderSize)))
                {
                    g.DrawPath(pen, path);
                }

                TextRenderer.DrawText(g, button.Text, button.Font, button.ClientRectangle, button.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }

            button.MouseEnter += (s, e) => { isHover = true; button.Invalidate(); };
            button.MouseLeave += (s, e) => { isHover = false; isPressed = false; button.Invalidate(); };
            button.MouseDown += (s, e) => { isPressed = true; button.Invalidate(); };
            button.MouseUp += (s, e) => { isPressed = false; button.Invalidate(); };
            button.Paint += Paint;
        }

        // 把顏色往白色方向混合，amount 為 0~1，數字越大越淡。
        private static Color Lighten(Color color, float amount)
        {
            int r = color.R + (int)((255 - color.R) * amount);
            int g = color.G + (int)((255 - color.G) * amount);
            int b = color.B + (int)((255 - color.B) * amount);
            return Color.FromArgb(color.A, r, g, b);
        }

        // 統一套用字型與按鈕外觀，取代個別 Form／UserControl 在 Designer 裡各自寫死的字型與按鈕樣式。
        // 供 BaseForm／CommonUserControl 的 OnLoad 呼叫，讓 Form 與 UserControl 套用同一套規則。
        public static void ApplyControlStyle(Control root)
        {
            foreach (Control child in root.Controls)
            {
                // 預設值：一般文字用 FormFont，名稱含 Title 的沿用既有慣例套標題字型與標題色。
                bool isTitle = child.Name.IndexOf("Title", StringComparison.OrdinalIgnoreCase) >= 0;
                child.Font = isTitle ? TitleFont : FormFont;
                if (isTitle)
                {
                    child.ForeColor = TitleColor;
                }

                Button? button = child as Button;
                if (button != null)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.Black;
                    button.Cursor = Cursors.Hand;
                    ApplyButtonSize(button);
                }

                // class：Tag 有指定的話，覆蓋掉上面的預設值（包含按鈕底色）。
                if (child.Tag is string tagText)
                {
                    foreach (var className in tagText.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (StyleClasses.TryGetValue(className, out var applyClass))
                        {
                            applyClass(child);
                            if (string.Equals(className, "title", StringComparison.OrdinalIgnoreCase))
                            {
                                isTitle = true;
                            }
                        }
                    }
                }

                // 標題文字固定貼齊圖示右邊 10px（跟圖示垂直置中），取代個別畫面各自擺放的座標。
                if (isTitle)
                {
                    PositionTitleNextToIcon(root, child);
                }

                // 滑鼠移入變淡：底色可能來自上面的 class，所以放在套用 class 之後，依最終底色計算。
                if (button != null)
                {
                    button.FlatAppearance.MouseOverBackColor = Lighten(button.BackColor, 0.3f);
                    button.FlatAppearance.MouseDownBackColor = Lighten(button.BackColor, 0.15f);
                }

                if (child.HasChildren)
                {
                    ApplyControlStyle(child);
                }
            }
        }

        // 標題與圖示的水平間距。
        public const int TitleIconGap = 10;

        // 在同一層找出圖示（PictureBox），把標題貼到它右邊 TitleIconGap px，並跟圖示垂直置中對齊。
        // 找不到圖示（該畫面沒有 icon）時維持原本座標，不做任何事。
        private static void PositionTitleNextToIcon(Control parent, Control title)
        {
            foreach (Control sibling in parent.Controls)
            {
                if (sibling is PictureBox icon)
                {
                    title.Location = new Point(icon.Right + TitleIconGap, icon.Top + (icon.Height - title.Height) / 2);
                    return;
                }
            }
        }

        // 高度統一為 ButtonHeight；寬度依目前字型量測文字寬度後加上左右留白，
        // 不足 ButtonMinWidth 時以 ButtonMinWidth 為準。AutoSize 關閉，改由此處手動控制。
        private static void ApplyButtonSize(Button button)
        {
            button.AutoSize = false;
            int textWidth = TextRenderer.MeasureText(button.Text, button.Font).Width;
            int width = Math.Max(ButtonMinWidth, textWidth + ButtonHorizontalPadding);
            button.Size = new Size(width, ButtonHeight);
        }
    }
}
