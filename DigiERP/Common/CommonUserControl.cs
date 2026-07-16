using DigiERP.Models;
using MES.Core.Model;
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

        protected bool chkPrivilege(string id)
        {
            if (AppSession.User.name?.ToUpper() != "ADMIN")
            {
                int count = 0;
                var item1 = new A使用者授權();
                foreach (var item in AppSession.User.privilegeList)
                {
                    if (item.授權子表單?.ToString().ToLower() == id.ToLower())
                    {
                        count++;
                        item1 = item;
                        break;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
                var priv = item1;
                if (priv != null)
                {
                    if (!((bool)(priv.高管 ?? false)) && !((bool)(priv.編修 ?? false)) && !((bool)(priv.核准 ?? false)) && !((bool)(priv.報表 ?? false)) && !((bool)(priv.查詢 ?? false)) && !((bool)(priv.輸出 ?? false)) && (string.IsNullOrEmpty(priv.職務代理效期) || DateTime.Parse(priv.職務代理效期).ToString("yyyyMMdd") == "19000101"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // ── 是否具備該表單的「編修」權限：ADMIN 或 高管 視同具備，否則需 編修 旗標為 true ──
        protected bool chkEditPrivilege(string id)
        {
            if (AppSession.User.name?.ToUpper() == "ADMIN")
            {
                return true;
            }
            foreach (var item in AppSession.User.privilegeList)
            {
                if (item.授權子表單?.ToString().ToLower() == id.ToLower())
                {
                    return (bool)(item.高管 ?? false) || (bool)(item.編修 ?? false);
                }
            }
            return false;
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
