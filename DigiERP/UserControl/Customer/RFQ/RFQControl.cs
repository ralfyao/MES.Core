using DigiERP.Forms.Customer;
using DigiERP.Models;
using DigiERP.Util;
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

namespace DigiERP.UserControl.Customer.RFQ
{
    public partial class RFQControl : System.Windows.Forms.UserControl
    {
        private static string id = "2D923859-7D2E-4870-90F1-E438086FD583";
        public RFQControl()
        {
            if (AppSession.User.username.ToUpper() != "admin")
            {
                var privList = (from p in AppSession.User.privilegeList where p.授權子表單.ToString() == id select p);
                if (privList.Count() == 0)
                {
                    MessageBox.Show("非授權使用者無法使用此功能!");
                    Dispose();
                }
                var priv = privList.FirstOrDefault();
                if (priv != null)
                {
                    if (!((bool)priv.高管) && !((bool)priv.編修) && !((bool)priv.核准) && !((bool)priv.報表) && !((bool)priv.查詢) && !((bool)priv.輸出) && string.IsNullOrEmpty(priv.職務代理效期))
                    {
                        MessageBox.Show("非授權使用者無法使用此功能!");
                        Dispose();
                    }
                }
            }
            InitializeComponent();
            initCountrySelect();
        }
        private void initCountrySelect()
        {
            ControlUtil.initCountrySelect(cboCountry);
        }
        private CustomerController customerController = new CustomerController();
        private void initGrid()
        {
            try
            {
                CommonRep<C客戶詢問函> commonRep = customerController.QuerySalesRecordList(new MES.MiddleWare.Modules.QuerySalesRecordListParam());
                inflateGrdiView(commonRep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //throw new NotImplementedException();
        }

        private void inflateGrdiView(CommonRep<C客戶詢問函> commonRep)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in commonRep.resultList)
            {
                int index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.RFQNO;
                row.Cells[index++].Value = DateTime.Parse(item.RFQDATE).ToString("yyyy/MM/dd");
                row.Cells[index++].Value = item.COMPANY;
                row.Cells[index++].Value = item.CONTACT;
                row.Cells[index++].Value = item.COUNTRY;
                row.Cells[index++].Value = item.INDUSTRYCODE;
                row.Cells[index++].Value = item.STATUS;
                row.Cells[index++].Value = item.RANKING;
                row.Cells[index++].Value = item.預計再訪日;
                row.Cells[index++].Value = item.業務人員;
                dataGridView1.Rows.Add(row);
            }
        }

        private void txtCustomerQuery_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerQuery.Text))
                {
                    initGrid();
                }
                else
                {
                    queryRFQList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;

            var dataGridView = (DataGridView)(from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                C客戶詢問函 data = new C客戶詢問函();
                //int index = row1.Cells.Count - 1;
                data.RFQNO = row1.Cells[0].Value.ToString();
                data = new CustomerController().GetRfq(data.RFQNO).result;

                var customerMaintainControl = (RFQMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(RFQMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new RFQMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel2.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((RFQMaintainControl)customerMaintainControl).form = data;
                ((RFQMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }
        FormIndustryCodeSelect popup;
        private void cboIndustry_Enter(object sender, EventArgs e)
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
                cboIndustry.SelectedValue = popup.SelectedCode;
                cboIndustry.SelectedText = popup.SelectedCode;
            }
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerQuery.Text = string.Empty;
            cboCountry.SelectedItem = new { CODE = "", 國別 = "" };
            cboIndustry.Text = "";
            queryRFQList();
        }

        public void queryRFQList(bool overOneYear = false)
        {
            CommonRep<C客戶詢問函> commonRep = customerController.QuerySalesRecordList(new MES.MiddleWare.Modules.QuerySalesRecordListParam()
            {
                custName = txtCustomerQuery.Text.Trim(),
                country = ((dynamic)cboCountry.SelectedItem).CODE,
                industrycode = cboIndustry.Text,
            });
            if (overOneYear)
            {
                commonRep.resultList = commonRep.resultList.Where(x => new TimeSpan(DateTime.Parse(x.RFQDATE).Ticks - DateTime.Now.Ticks).Days < -365).ToList();
            }
            inflateGrdiView(commonRep);
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryRFQList();
        }

        private void cboIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryRFQList();
        }

        private void cboIndustry_Leave(object sender, EventArgs e)
        {
            popup.Dispose();
            popup.Close();
        }

        private void cboIndustry_TextChanged(object sender, EventArgs e)
        {
            queryRFQList();
        }

        private void btnOverOneYear_Click(object sender, EventArgs e)
        {
            queryRFQList(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(RFQMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel2.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (customerMaintainControl == null)
            {
                customerMaintainControl = new RFQMaintainControl();
                customerMaintainControl.Dock = DockStyle.Fill;
                panel2.Controls.Add(customerMaintainControl);
            }
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((RFQMaintainControl)customerMaintainControl).form = new C客戶詢問函();
            ((RFQMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }
    }
}
