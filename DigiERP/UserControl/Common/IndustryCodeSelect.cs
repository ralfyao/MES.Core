using DigiERP.Forms.Customer;
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
    public partial class IndustryCodeSelect : System.Windows.Forms.UserControl
    {
        private FormIndustryCodeSelect popup { get; set; }
        public IndustryCodeSelect()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<C產業代碼> datasource)
        {
            this.cboIndustry.DataSource = datasource;
        }

        private void cboIndustry_Click(object sender, EventArgs e)
        {
            popup = new FormIndustryCodeSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboIndustry.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);

            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                
                cboIndustry.Text = popup.SelectedCode;
                lblIndustryCodeDesc.Text = popup.SelectedName; // 存值（推薦）
            }
            //}
        }

        private void cboIndustry_Leave(object sender, EventArgs e)
        {
            if (popup != null)
            {
                popup.Dispose();
                popup.Close();
            }
        }

        public void SetIndustryCode(string? industry)
        {
            //cboIndustry.SelectedValue = industry;
            if (cboIndustry.DataSource == null)
            {
                ControlUtil.initIndustryCodeList(this);
            }
                //return;
            cboIndustry.ValueMember = "中分類碼";
            foreach (var aItem in cboIndustry.DataSource as IEnumerable<dynamic>)
            {
                if (aItem.中分類碼?.Trim() == industry?.Trim())
                {
                    cboIndustry.SelectedValue = aItem.中分類碼;
                    lblIndustryCodeDesc.Text = aItem.中分類名稱;
                }
            }
        }

        public void SetText(string text)
        {
            cboIndustry.Text = text;
            if (string.IsNullOrEmpty(text))
            {
                lblIndustryCodeDesc.Text = text;
            }
        }

        private void cboIndustry_Enter(object sender, EventArgs e)
        {
            cboIndustry_Click(sender, e);
        }

        internal string? GetIndustryCode()
        {
            return cboIndustry.Text?.ToString();
        }
    }
}
