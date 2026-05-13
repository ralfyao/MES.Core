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
