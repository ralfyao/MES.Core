using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MES.Core.Model;

namespace DigiERP.Common
{
    public class CommonNumericUpDown : NumericUpDown
    {
        private Color originalBackColor;

        public CommonNumericUpDown()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            originalBackColor = this.BackColor;
            this.BackColor = Color.LightYellow;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.BackColor = originalBackColor;
        }
    }
}