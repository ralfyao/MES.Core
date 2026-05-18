using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Common
{
    public partial class CommonUserControl : System.Windows.Forms.UserControl
    {
        public CommonUserControl()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == Keys.Enter)
            //{
            //    Control currentControl = GetFocusedControl(this);

            //    // 多行 TextBox 不攔截 Enter
            //    if (currentControl is TextBox tb && tb.Multiline)
            //    {
            //        return base.ProcessCmdKey(ref msg, keyData);
            //    }

            //    if (currentControl != null)
            //    {
            //        SelectNextControl(
            //            currentControl,
            //            true,
            //            true,
            //            true,
            //            true);
            //    }

            //    return true;
            //}

            //return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl is TextBox tb && tb.Multiline)
                    return base.ProcessCmdKey(ref msg, keyData);

                SendKeys.Send("{TAB}");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private Control GetFocusedControl(Control parent)
        {
            if (parent.Focused)
                return parent;

            foreach (Control c in parent.Controls)
            {
                Control focused = GetFocusedControl(c);

                if (focused != null)
                    return focused;
            }

            return null;
        }
    }
}
