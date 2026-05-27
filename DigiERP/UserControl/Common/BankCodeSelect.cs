using DigiERP.Forms.Customer;
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
    public partial class BankCodeSelect : System.Windows.Forms.UserControl
    {
        private FormBankCodeSelect popup { get; set; }
        public BankCodeSelect()
        {
            InitializeComponent();
        }

        private void cboIndustry_Click(object sender, EventArgs e)
        {
            popup = new FormBankCodeSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboIndustry.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);

            // 建立 DataGridView
            //var grid = new DataGridView();
            //grid.Dock = DockStyle.Fill;
            //grid.ReadOnly = true;
            //grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //grid.DataSource = new List<dynamic>(); // 你的資料

            //// 點選事件
            //grid.CellClick += (s, ev) =>
            //{
            //    var row = grid.Rows[ev.RowIndex];
            //    cboIndustry.Text = row.Cells["國別"].Value.ToString();
            //    cboIndustry.Tag = row.Cells["CODE"].Value; // 存值

            //    popup.Close();
            //};

            //popup.Controls.Add(grid);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboIndustry.SelectedValue = popup.SelectedCode;
                cboIndustry.SelectedText = popup.SelectedCode;
                //lblIndustryCodeDesc.Text = popup.SelectedName; // 存值（推薦）
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

        internal void SetBankCode(string? cREDIBILITY)
        {
            //cboIndustry.SelectedValue = cREDIBILITY;
            if (cboIndustry.DataSource == null)
            {
                return;
            }
            foreach (var aItem in cboIndustry.DataSource as IEnumerable<dynamic>)
            {
                if (aItem.銀行編碼 == cREDIBILITY)
                {
                    cboIndustry.SelectedItem = aItem;
                }
            }
        }

        private void cboIndustry_Enter(object sender, EventArgs e)
        {
            cboIndustry_Click(sender, e);
        }

        internal string? GetBankCode()
        {
            return string.IsNullOrEmpty( cboIndustry.SelectedValue?.ToString()) ? cboIndustry.Text : cboIndustry.SelectedValue?.ToString();
        }
    }
}
