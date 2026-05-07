using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.Common
{
    public class CommonComboBox : ComboBox
    {
        private Color backColor;
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            backColor = this.BackColor;
            this.BackColor = Color.LightYellow;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.BackColor = backColor;
        }
    }
}
