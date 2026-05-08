using DigiERP.Models;
using MES.Core.Model;
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
    public partial class FrmRfqWorkRecord : Form
    {
        private C客戶設定 _customer { get; set; }
        public void SetCustomer(C客戶設定 cust)
        {
            _customer = cust;
        }
        public FrmRfqWorkRecord()
        {
            InitializeComponent();
            initControls();
        }

        private void initControls()
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblWorkerNumber.Text = AppSession.User.empNo;
            lblName.Text = AppSession.User.username;
            ProcurementController procurementController = new ProcurementController();
            CommonRep<A成本單位> commonRep = procurementController.AllDepartmentList();
            List<string> positionList = (from c in commonRep.resultList select c.職務).ToList();
            cboPosition.DataSource = positionList;
            cboPosition.SelectedItem = "業務";
        }

        public void initCustInfo()
        {
            txtProjSerial.Text = _customer.欄位2;

            //throw new NotImplementedException();
        }
    }
}
