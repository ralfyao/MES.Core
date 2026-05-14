using DigiERP.Common;
using DigiERP.Forms.Customer;
using DigiERP.Util;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Components.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl
{
    public partial class CustomerControl : CommonUserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            initGridView();
            initCountrySelect();
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel2.AutoScroll = true;
            //panel3.AutoScroll = true;
        }

        private void initCountrySelect()
        {
            ControlUtil.initCountrySelect(cboCountry);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void initGridView()
        {
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶設定> custList = customerController.getCustomerList();
            inflateCustList(custList);
            dataGridView1.Width = this.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerMaintainControl = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
            var dataGridView = (from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (customerMaintainControl == null)
            {
                customerMaintainControl = new CustomerMaintainControl();
                customerMaintainControl.Dock = DockStyle.Fill;
                panel1.Controls.Add(customerMaintainControl);
            }
            var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
            if (lblMode != null)
            {
                lblMode.Text = "新增";
            }
            ((CustomerMaintainControl)customerMaintainControl).form = new C客戶設定();
            ((CustomerMaintainControl)customerMaintainControl).initForm();
            customerMaintainControl.Visible = true;
            if (dataGridView != null)
            {
                dataGridView.Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 避免點到標題列
            if (e.RowIndex < 0)
                return;

            var dataGridView = (DataGridView)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                var row1 = dataGridView.Rows[e.RowIndex];

                C客戶設定 data = new C客戶設定();
                int index = row1.Cells.Count - 1;
                data.識別 = int.Parse(row1.Cells[index].Value.ToString());
                data = new CustomerController().GetCustomer(data).result;

                var customerMaintainControl = (CustomerMaintainControl)(from c in panel1.Controls.Cast<Control>() where c.GetType() == typeof(CustomerMaintainControl) select c).FirstOrDefault();
                if (customerMaintainControl == null)
                {
                    customerMaintainControl = new CustomerMaintainControl();
                    customerMaintainControl.Dock = DockStyle.Fill;
                    panel1.Controls.Add(customerMaintainControl);
                }
                var lblMode = (from c in customerMaintainControl.Controls.Cast<Control>() where c.GetType() == typeof(Label) && c.Name == "lblMode" select c).FirstOrDefault();
                if (lblMode != null)
                {
                    lblMode.Text = "修改";
                }
                ((CustomerMaintainControl)customerMaintainControl).form = data;
                ((CustomerMaintainControl)customerMaintainControl).initForm();
                customerMaintainControl.Visible = true;
                if (dataGridView != null)
                {
                    dataGridView.Visible = false;
                }
            }
        }

        private void txtCustQueryFIeld_Leave(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶設定> custList = customerController.getCustomerList(txtCustQueryFIeld.Text.Trim().ToUpper());
            inflateCustList(custList);
        }

        private void inflateCustList(CommonRep<C客戶設定> custList)
        {
            foreach (var cust in custList.resultList)
            {
                if (cust != null)
                {
                    int index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = cust.COMPANY;//客戶名稱
                    index++;
                    row.Cells[index++].Value = cust.CONTACTPERSON;//主要聯絡人
                    row.Cells[index++].Value = cust.正航編號;
                    row.Cells[index++].Value = cust.COUNTRY;
                    row.Cells[index++].Value = cust.INDUSTRY;
                    row.Cells[index++].Value = cust.INDUSTRYCODE_C;
                    row.Cells[index++].Value = cust.INDUSTRYCODE_E;
                    row.Cells[index++].Value = cust.MA;
                    row.Cells[index++].Value = cust.EMAIL;
                    row.Cells[index++].Value = cust.CREDATE;
                    row.Cells[index++].Value = cust.MODIFYDATE;
                    row.Cells[index++].Value = cust.識別;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dynamic selected = cboCountry.SelectedItem;
                if (selected != null && !string.IsNullOrEmpty(selected.國別))
                {
                    if (row.Cells[4].Value?.ToString().Trim().IndexOf(selected.國別) != -1)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            isUpdatingCheckBox = true;
            try
            {
                foreach (int rowIndex in checkedIndexes)
                {
                    dataGridView1.Rows[rowIndex].Cells["chk"].Value = false;
                }
                dataGridView1.RefreshEdit();
            }
            catch { }
            isUpdatingCheckBox = false;
        }
        private List<int> checkedIndexes = new List<int>();
        private bool isUpdatingCheckBox = false;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isUpdatingCheckBox)
                return;
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView1.Columns["chk"].Index)
            {
                bool isChecked = Convert.ToBoolean(
                    dataGridView1.Rows[e.RowIndex].Cells["chk"].Value
                );

                if (isChecked)
                {
                    if (!checkedIndexes.Contains(e.RowIndex))
                    {
                        checkedIndexes.Add(e.RowIndex);
                    }
                }
                else
                {
                    checkedIndexes.Remove(e.RowIndex);
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        /// <summary>
        /// 匯出excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedIndexes.Count == 0)
            {
                MessageBox.Show("沒有勾選資料");
                return;
            }

            //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage.License.SetNonCommercialPersonal("DACHIN");
            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("Sheet1");

                int row = 1;

                // 標題列
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    ws.Cells[row, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                }

                row++;

                // 資料列
                foreach (int index in checkedIndexes)
                {
                    var dgvRow = dataGridView1.Rows[index];

                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        ws.Cells[row, col + 1].Value =
                            dgvRow.Cells[col].Value;
                    }

                    row++;
                }

                // 存檔
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"客戶資料{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx"
                );

                File.WriteAllBytes(filePath, package.GetAsByteArray());

                MessageBox.Show("匯出完成：" + filePath);
            }
        }
    }
}
