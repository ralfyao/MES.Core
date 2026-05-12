using MES.Core.Model;
using MES.MiddleWare.Modules;
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
    public partial class FrmIndustryCodeAdd : Form
    {
        public FrmIndustryCodeAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            C產業代碼 add = new C產業代碼();
            add.大分類碼 = txtGrossClass.Text;
            add.大分類名稱 = txtGrossClassName.Text;
            add.中分類碼 = txtMiddleClass.Text;
            add.中分類名稱 = txtMiddleClassName.Text;
            add.英文 = txtEnglish.Text;
            add.内容 = txtContent.Text;
            add.其他 = txtOthers.Text;
            CustomerController customerController = new CustomerController();
            CommonRep<string> rep = customerController.saveIndustryCode(add);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                Dispose();
                Close();
                return;
            }
            MessageBox.Show("新增成功");
            Dispose();
            Close();
        }
    }
}
