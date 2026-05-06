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
        public IndustryCodeSelect()
        {
            InitializeComponent();
        }

        private void cboIndustry_Click(object sender, EventArgs e)
        {
            var popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboIndustry.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - cboIndustry.Height);

            // 建立 DataGridView
            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.DataSource = new List<dynamic>(); // 你的資料

            // 點選事件
            grid.CellClick += (s, ev) =>
            {
                var row = grid.Rows[ev.RowIndex];
                cboIndustry.Text = row.Cells["國別"].Value.ToString();
                cboIndustry.Tag = row.Cells["CODE"].Value; // 存值

                popup.Close();
            };

            popup.Controls.Add(grid);
            popup.Size = new Size(cboIndustry.Width, 200);
            popup.Show();
        }
    }
}
