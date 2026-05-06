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
    public partial class FrmSetConf : Form
    {
        public FrmSetConf()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var s = new StreamWriter($@".\settings.conf"))
            {
                s.WriteLine($@"CONNECTION_STRING:Server={txtDBServer.Text};Database={txtDBName.Text};User={txtUser.Text};Password={txtPassword.Text};");
            }
            MessageBox.Show("設定完成! 將關閉程式，請再重新開啟");
            Dispose();
            Close();
        }
    }
}
