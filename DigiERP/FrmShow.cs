using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP
{
    public partial class FrmShow : Form
    {

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public FrmShow()
        {
            InitializeComponent();
            timer.Interval = 5000;
            timer.Tick += showLogin;
            timer.Enabled = true;
            timer.Start();
        }

        private void showLogin(object? sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            this.Visible = false;
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
