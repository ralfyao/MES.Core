using DigiERP.Forms.Settings;
using DigiERP.Models;
using DigiERP.UserControl.Auth;
using MES.WebAPI.Models;
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
    public partial class FrmMain : Form
    {
        private User _user { get; set; }
        public void SetUser(User user)
        {
            _user = user;
            if (_user != null)
            {
                lblUser.Text = _user.empNo;
                lblUserName.Text = _user.username;
                lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        public FrmMain()
        {
            InitializeComponent();
            //this.Cursor = Cursors.Hand;
            panel1.Cursor = Cursors.Hand;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            FrmCust frmCust = new FrmCust();
            frmCust.ShowDialog();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Rectangle area = new Rectangle(0, 0, 100, 80);

            //if (area.Contains(e.Location))
            //{
            panel1.Cursor = Cursors.Hand;
            //}
            //else
            //{
            //    panel1.Cursor = Cursors.Default;
            //}
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            //int baseWidth = 800;
            //int baseHeight = 450;
            //float scaleX = (float)this.ClientSize.Width / baseWidth;
            //float scaleY = (float)this.ClientSize.Height / baseHeight;

            //panel1.Left = (int)(panel1.Left * scaleX);
            //panel1.Top = (int)(panel1.Top * scaleY);
            //panel1.Width = (int)(panel1.Width * scaleX);
            //panel1.Height = (int)(panel1.Height * scaleY);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Cursor = Cursors.Default;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FrmCust frmCust = new FrmCust();
            frmCust.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void panelSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnPassworkChange_Click(object sender, EventArgs e)
        {
            FrmPasswordSetting frmPasswordSetting = new FrmPasswordSetting();
            frmPasswordSetting.SetAccount(_user.name);
            frmPasswordSetting.ShowDialog();
        }

        private void btnPasswordManage_Click(object sender, EventArgs e)
        {
            if (AppSession.User.username.ToLower() != "admin")
            {
                MessageBox.Show("非管理者無法使用此功能!");
                return;
            }
            FrmAuth frmAuth = new FrmAuth();
            frmAuth.ShowDialog();
        }
    }
}
