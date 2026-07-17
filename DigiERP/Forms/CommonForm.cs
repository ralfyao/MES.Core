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

namespace DigiERP.Forms
{
    public partial class CommonForm : Form
    {
        public CommonForm()
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                //Control control = this.ActiveControl;
                SelectNextControl(
                this.ActiveControl, // 目前控制項
                true,               // 下一個
                true,
                true,
                true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
