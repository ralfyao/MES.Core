using DigiERP.Util;
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

namespace DigiERP.UserControl.Common
{
    public partial class RFQStatusSelect : System.Windows.Forms.UserControl
    {
        public RFQStatusSelect()
        {
            InitializeComponent();
            lblStatusText.Text = string.Empty;
        }

        internal void SetDataSource(List<C客戶動態> cs)
        {
            cboStatusSelect.DataSource = cs;
            cboStatusSelect.ValueMember = "狀況";
        }

        internal void SetEnabled(bool v)
        {
            cboStatusSelect.Enabled = v ;
        }

        internal void SetStatusCode(string empty)
        {
            cboStatusSelect.Text = empty;
            if (!string.IsNullOrEmpty(empty))
            {
                foreach(var item in cboStatusSelect.Items)
                {
                    if (((dynamic)item)?.狀況 == empty)
                    {
                        lblStatusText.Text = ((dynamic)item)?.狀況說明??"";
                    }
                }
            }
            else
            {
                lblStatusText.Text = string.Empty;
            }
        }
    }
}
