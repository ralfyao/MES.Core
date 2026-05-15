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
    public partial class FrmRfqWorkRecord : CommonForm
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
        }

        public void SetProjSerial(string projSerial)
        {
            txtProjSerial.Text = projSerial;
        }

        public void SetModuleCode(string moduleCode)
        {
            txtModuleCode.Text = moduleCode;
        }

        public void SetModuleName(string moduleName)
        {
            txtModuleName.Text = moduleName;
        }


        public void SetPosition(string position)
        {
            cboPosition.SelectedItem = position;
        }

        public void initCustInfo()
        {
            txtProjSerial.Text = _customer.欄位2;
            txtModuleCode.Text = _customer.正航編號;
            txtModuleName.Text = _customer.COMPANY;
            //throw new NotImplementedException();
        }
        FormPositionSelect popup;
        private void cboMissionCiass_Click(object sender, EventArgs e)
        {
            popup = new FormPositionSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboMissionCiass.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                //if (cboMissionCiass.DataSource == null || cboMissionCiass.DataSource)
                //{
                cboMissionCiass.DataSource = new List<string>() { popup.SelectedCode };
                //}
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //A工作紀錄
            try
            {
                工作紀錄A a = new 工作紀錄A();
                a.日誌單號 = lblWorkerNumber.Text + "-" + DateTime.Now.ToString("yyyyMMdd");
                a.工作日期 = lblDate.Text;
                a.員工編號 = lblWorkerNumber.Text;
                a.專案序號 = txtProjSerial.Text;
                a.進度 = float.Parse(successPropability.Value.ToString());
                a.模組編碼 = txtModuleCode.Text;
                a.模組名稱 = txtModuleName.Text;
                a.任務分類 = cboMissionCiass.SelectedValue.ToString();
                a.成效點數 = float.Parse(points.Value.ToString());
                a.工作簡述 = txtComments.Text;
                a.預計再訪 = dtRevisit.Value.ToString();
                CustomerController customerController = new CustomerController();
                CommonRep<string> rep = customerController.AddRfqTrackingRecord(a);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    Dispose();
                    Close(); return;
                }
                MessageBox.Show("執行成功");
                Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
