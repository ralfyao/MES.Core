using DigiERP.UserControl;
using MES.WebAPI.Controllers;
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

namespace DigiERP.Forms.Customer
{
    public partial class FrmChangeCustName : Form
    {
        public FrmChangeCustName()
        {
            InitializeComponent();
        }
        public string GetChangedName()
        {
            return txtChangedName.Text;
        }

        public void SetOriginalName(string oName)
        {
            txtOriginalName.Text = oName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChangedName.Text))
            {
                MessageBox.Show("請輸入更名後名稱");
                return;
            }
            CustomerController customerController = new CustomerController();
            CommonRep<string> commonRep = customerController.UpdateCompanyName(txtOriginalName.Text, txtChangedName.Text);
            if (string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show("變更成功，您現在可關閉更名視窗");
            }
            else
            {
                MessageBox.Show(commonRep.ErrorMessage);
            }
            //Dispose();
            //Close();
        }
    }
}
