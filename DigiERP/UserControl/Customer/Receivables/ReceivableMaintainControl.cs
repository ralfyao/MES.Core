using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.Models;
using DigiERP.UserControl.Objective.ARWriteOff;
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

namespace DigiERP.UserControl.Customer.Receivables
{
    public partial class ReceivableMaintainControl : CommonUserControl
    {
        // 沿用 ReceivableControl (應收帳款列表) 已註冊的權限 GUID
        private static string id = "6df5ee5c-41d3-4eb3-b093-09662e9951c3";

        public F收款 form;
        public C客戶設定 customer;
        private ARController _arController;
        private CustomerController _customerController;
        private void initController()
        {
            if (_arController == null)
                _arController = new ARController();
            if (_customerController == null)
                _customerController = new CustomerController();
        }
        public void initForm()
        {
            initController();
            inntControls();
            if (lblMode.Text == "修改")
            {
                if (form != null)
                {
                    if (customer == null)
                    {
                        var customerRep = _customerController.getCustomerList(form.客戶編號 ?? "");
                        if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                        {
                            MessageBox.Show(customerRep.ErrorMessage);
                            return;
                        }
                        customer = customerRep.resultList.FirstOrDefault() ?? new C客戶設定();
                    }
                    dt收款日.Value = DateTime.Parse(form.日期 ?? "1900-01-01");
                    txt單號.Text = form.單號;
                    cbo收款類別.Text = form.類別;
                    txt憑證種類.Text = form.MACHINENO;
                    if (string.IsNullOrEmpty(form.收款日期))
                    {
                        dt發票日期.Value = DateTime.Parse("1900-01-01");
                    }
                    else
                    {
                        dt發票日期.Value = DateTime.Parse(form.收款日期);
                    }
                    txt未稅金額.Text = (form.銀轉金額 ?? 0).ToString();
                    txt客戶編號.Text = form.客戶編號;
                    txt客戶名稱.Text = customer?.COMPANY ?? "";
                    txt發票號碼.Text = form.發票號碼;
                    txt收票金額.Text = (form.收票金額 ?? 0).ToString();
                    txt會計傳票.Text = form.傳票;
                    cbo幣別.Text = form.幣別;
                    txt匯率.Text = (form.匯率 ?? 0).ToString();
                    txt收款單號.Text = form.請款人員;
                    chk結案.Checked = (form.結案 ?? false);
                    txt備註.Text = form.備註;
                    txtTotalAmount.Text = (form.收款總額 ?? 0).ToString();
                    initGrid();
                    lbl財務覆核.Text = form.核准;
                    if (!string.IsNullOrWhiteSpace(form.核准日))
                    {
                        lbl財務覆核日.Text = DateTime.Parse(form.核准日).ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        lbl財務覆核日.Text = string.Empty;
                    }

                    lbl修改人員.Text = form.修改;
                    if (!string.IsNullOrWhiteSpace(form.修改日))
                    {
                        lbl修改日期.Text = DateTime.Parse(form.修改日).ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        lbl修改日期.Text = string.Empty;
                    }

                    lbl建立人員.Text = form.建檔;
                    if (!string.IsNullOrWhiteSpace(form.建檔日))
                    {
                        lbl建立日期.Text = DateTime.Parse(form.建檔日).ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        lbl建立日期.Text = string.Empty;
                    }
                }
                disableAllControls(true);
                btnCustSearch.Enabled = false;
                btnModify.Visible = chkEditPrivilege(id);
                btnDelete.Visible = chkEditPrivilege(id);
                if (!string.IsNullOrEmpty(form.核准))
                {
                    btnActivate.Visible = false;
                    btnCancelActivate.Visible = true;
                    btnPrint.Visible = true;
                    btn單筆收款.Visible = true;
                }
                else
                {
                    btnActivate.Visible = true;
                    btnCancelActivate.Visible = false;
                    btnPrint.Visible = false;
                    btn單筆收款.Visible = false;
                }
            }
            else
            {
                btnModify.Visible = false;
                btnReceive.Visible = false;
                btnDelete.Visible = false;
                btnActivate.Visible = false;
                btnCancelActivate.Visible = false;
                btnPrint.Visible = false;
                btn單筆收款.Visible = false;
                btnSubpoena.Visible = false;
                dt收款日.Value = DateTime.Now;
                var 單號rep = _customerController.GetShippingOrderNo();
                if (!string.IsNullOrEmpty(單號rep.ErrorMessage))
                {
                    MessageBox.Show(單號rep.ErrorMessage);
                    return;
                }
                txt單號.Text = 單號rep.result;
                lbl原幣收帳金額.Text = "0";
                lbl台幣換算金額.Text = "0";
                lbl建立人員.Text = "";
                lbl建立日期.Text = "";
                lbl財務覆核.Text = "";
                lbl財務覆核日.Text = "";
                lbl修改人員.Text = "";
                lbl修改日期.Text = "";
                disableAllControls(false);
            }
        }

        private void inntControls()
        {
            CommonRep<F幣別> currencuRep = _customerController.GetCurrencyList();
            if (!string.IsNullOrEmpty(currencuRep.ErrorMessage))
            {
                MessageBox.Show(currencuRep.ErrorMessage);
                return;
            }
            cbo幣別.Items.Clear();
            foreach (var item in currencuRep.resultList)
            {
                cbo幣別.Items.Add(item.CURRENCY);
            }
            //throw new NotImplementedException();
        }

        private void disableAllControls(bool isDisable)
        {
            bool enabled = !isDisable;
            btn送出.Enabled = enabled;
            btnReceive.Enabled = enabled;
            btnCustSearch.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnSubpoena.Enabled = enabled;
            btnImportDetail.Enabled = enabled;
            btnActivate.Enabled = enabled;
            btnCancelActivate.Enabled = enabled;
            btnPrint.Enabled = enabled;
            cbo收款類別.Enabled = enabled;
            txt憑證種類.Enabled = enabled;
            dt發票日期.Enabled = enabled;
            txt未稅金額.Enabled = enabled;
            txt客戶編號.Enabled = enabled;
            txt客戶名稱.Enabled = enabled;
            txt發票號碼.Enabled = enabled;
            txt收票金額.Enabled = enabled;
            txt會計傳票.Enabled = enabled;
            cbo幣別.Enabled = enabled;
            txt匯率.Enabled = enabled;
            txt收款單號.Enabled = enabled;
            btn單筆收款.Enabled = enabled;
            chk結案.Enabled = enabled;
            txt備註.Enabled = enabled;
            txtTotalAmount.Enabled = enabled;
            dataGridView1.Enabled = enabled;
            //throw new NotImplementedException();
        }

        private void initGrid()
        {
            int index = 0;
            dataGridView1.Rows.Clear();
            CommonRep<string> listAccountSourceRep = _customerController.GetAccountSource(txt客戶編號.Text);
            decimal? 原幣收帳金額 = 0m;
            decimal? 台幣換算金額 = 0m;
            foreach (var item in form.arListDetail)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                DataGridViewComboBoxCell accSourceCol = (DataGridViewComboBoxCell)row.Cells[index++];
                //ComboBox accCombo = (ComboBox)accSourceCol.Items[0];
                listAccountSourceRep.resultList.ForEach(x =>
                {
                    accSourceCol.Items.Add(x);
                });
                accSourceCol.Value = item.帳款來源?.Trim();
                DataGridViewComboBoxCell writeOffCodeCol = (DataGridViewComboBoxCell)row.Cells[index++];
                writeOffCodeCol.Value = null;
                writeOffCodeCol.Items.Add(item.沖帳碼?.Trim());
                writeOffCodeCol.Value = item.沖帳碼?.Trim();
                //accCombo.SelectedIndexChanged += AccCombo_SelectedIndexChanged;
                //index += 2;
                row.Cells[index++].Value = item.原幣收帳金額; 原幣收帳金額 += item.原幣收帳金額;
                row.Cells[index++].Value = item.台幣換算金額; 台幣換算金額 += item.台幣換算金額;
                row.Cells[index++].Value = item.說明;
                row.Cells[index++].Value = item.專案序號;
                //accSourceCol.
                dataGridView1.Rows.Add(row);
            }
            //txtTotalAmount.Text = (原幣收帳金額 ?? 0).ToString();
            lbl原幣收帳金額.Text = (原幣收帳金額 ?? 0).ToString();
            lbl台幣換算金額.Text = (台幣換算金額 ?? 0).ToString();
            //throw new NotImplementedException();
        }

        public ReceivableMaintainControl()
        {
            InitializeComponent();
        }

        public ReceivableMaintainControl(F收款 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == 1)
            {
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[1];
                comboCell.Value = null;
                comboCell.Items.Clear();
                var accountSource = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                var writeOffRep = _customerController.GetWriteOffCode(accountSource);
                if (!string.IsNullOrEmpty(writeOffRep.ErrorMessage))
                {
                    MessageBox.Show(writeOffRep.ErrorMessage);
                    return;
                }
                writeOffRep.resultList.ForEach(x =>
                {
                    comboCell.Items.Add(x);
                });
            }
            if (e.ColumnIndex == 2)
            {
                try
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "0") * decimal.Parse(txt匯率.Text);
                }
                catch
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "0");
                }
                summaryAmount();
            }
            //dataGridView1.Rows[e.RowIndex].Cells[1].Value = accountSource;
            //if (!string.IsNullOrEmpty())
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var cell = dataGridView1.Rows[e.RowIndex]
                            .Cells[e.ColumnIndex];
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableAllControls(false);
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確認{lblMode.Text}?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GetUserInput();
                CommonRep<F收款> result = null;
                if (lblMode.Text == "新增")
                {
                    result = _arController.SaveAR(form);
                }
                else if (lblMode.Text == "修改")
                {
                    result = _arController.UpdateAR(form);
                }
                if (!string.IsNullOrEmpty(result.ErrorMessage))
                {
                    MessageBox.Show(result.ErrorMessage);
                    return;
                }
                MessageBox.Show($"{lblMode.Text}成功!");
                btnClose_Click(null, null);
            }
        }

        private void GetUserInput()
        {
            form.單號 = txt單號.Text;
            form.日期 = dt收款日.Value.ToString("yyyy/MM/dd");
            form.類別 = cbo收款類別.Text;
            form.MACHINENO = txt憑證種類.Text;
            form.收款日期 = dt發票日期.Value.ToString("yyyy/MM/dd");
            try
            {
                form.銀轉金額 = decimal.Parse(txt未稅金額.Text);
            }
            catch (Exception)
            {
                form.銀轉金額 = 0;
            }
            form.傳票 = txt會計傳票.Text;
            form.幣別 = cbo幣別.Text;
            try
            {
                form.匯率 = decimal.Parse(txt匯率.Text);
            }
            catch (Exception)
            {
                form.匯率 = 0;
            }
            form.請款人員 = txt收款單號.Text;
            form.結案 = chk結案.Checked;
            form.備註 = txt備註.Text;
            try
            {
                form.收款總額 = decimal.Parse(txtTotalAmount.Text);
            }
            catch (Exception)
            {
                form.收款總額 = 0;
            }
            collectGridData();
            if (lblMode.Text == "新增")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
            }
            else if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }

        private void collectGridData()
        {
            if (form.arListDetail == null)
                form.arListDetail = new List<F收款明細>();
            form.arListDetail.Clear();
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int index = 0;
                F收款明細 detailItem = new F收款明細();
                detailItem.帳款來源 = row.Cells[index++].Value?.ToString();
                detailItem.沖帳碼 = row.Cells[index++].Value?.ToString();
                if (row.Cells[index].Value != null)
                {
                    try
                    {
                        detailItem.原幣收帳金額 = decimal.Parse(row.Cells[index].Value?.ToString());
                        totalAmount += decimal.Parse(row.Cells[index].Value?.ToString());
                    }
                    catch (Exception)
                    {
                        detailItem.原幣收帳金額 = 0;
                        totalAmount += 0;
                    }
                }
                else
                {
                    detailItem.原幣收帳金額 = 0;
                    totalAmount += 0;
                }
                index++;
                if (row.Cells[index].Value != null)
                {
                    try
                    {
                        detailItem.台幣換算金額 = decimal.Parse(row.Cells[index].Value?.ToString());
                    }
                    catch (Exception)
                    {
                        detailItem.台幣換算金額 = 0;
                    }
                }
                else
                {
                    detailItem.台幣換算金額 = 0;
                }
                index++;
                detailItem.說明 = row.Cells[index].Value?.ToString();
                detailItem.專案序號 = row.Cells[index].Value?.ToString();
                form.arListDetail.Add(detailItem);
            }
            txtTotalAmount.Text = totalAmount.ToString();
            //throw new NotImplementedException();
        }

        private void summaryAmount()
        {
            decimal totalAmount = 0;
            decimal totalTaiwanAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int index = 0;
                if (row.Cells[index].Value != null)
                {
                    try
                    {
                        totalAmount += decimal.Parse(row.Cells[index].Value?.ToString());
                    }
                    catch (Exception)
                    {
                        totalAmount += 0;
                    }
                }
                else
                {
                    totalAmount += 0;
                }
                index++;
                if (row.Cells[index].Value != null)
                {
                    try
                    {
                        totalTaiwanAmount += decimal.Parse(row.Cells[index].Value?.ToString());
                    }
                    catch (Exception)
                    {
                        //detailItem.台幣換算金額 = 0;
                        totalTaiwanAmount += 0;
                    }
                }
                else
                {
                    totalTaiwanAmount += 0;
                }
            }
            txtTotalAmount.Text = totalAmount.ToString();
            lbl原幣收帳金額.Text = txtTotalAmount.Text;
            lbl台幣換算金額.Text = totalTaiwanAmount.ToString();
        }

        private void txt未稅金額_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txt未稅金額.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("未稅金額非數字!");
                txt未稅金額.Focus();
                txt未稅金額.Text = "0";
            }
        }

        private void txt收票金額_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txt收票金額.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("稅額非數字!");
                txt收票金額.Focus();
                txt收票金額.Text = "0";
            }
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            FrmCustSelect frmCustSelect = new FrmCustSelect();
            if (frmCustSelect.ShowDialog(this) == DialogResult.OK)
            {
                txt客戶編號.Text = frmCustSelect.CustId;
                var customerRep = _customerController.getCustomerList(txt客戶編號.Text);
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage); return;
                }
                customer = customerRep.resultList.FirstOrDefault();
                if (customer != null)
                {
                    txt客戶名稱.Text = customer.COMPANY;
                }
            }
        }

        private void cbo幣別_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonRep<F匯率> exRateRep = _customerController.GetExRateList(cbo幣別.Text);
            if (!string.IsNullOrEmpty(exRateRep.ErrorMessage))
            {
                MessageBox.Show(exRateRep.ErrorMessage);
                return;
            }
            txt匯率.Text = exRateRep.resultList?.FirstOrDefault()?.匯率;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認刪除?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var deleteRep = _arController.DeleteAR(form);
                if (!string.IsNullOrEmpty(deleteRep.ErrorMessage))
                {
                    MessageBox.Show(deleteRep.ErrorMessage);
                    return;
                }
                MessageBox.Show("刪除成功");
                btnClose_Click(null, null);
            }
        }

        private void chk結案_CheckedChanged(object sender, EventArgs e)
        {
            var chkClosedRep = _arController.UpdateCloseFlag(txt單號.Text);
            if (!string.IsNullOrEmpty(chkClosedRep.ErrorMessage))
            {
                MessageBox.Show(chkClosedRep.ErrorMessage);
                return;
            }
            form.結案 = !form.結案;
            //chk結案.Checked = !chk結案.Checked;
            MessageBox.Show($@"{(chk結案.Checked ? "結案" : "取消結案")}成功");
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ARWriteOffControl aRWriteOffControl = new ARWriteOffControl();
            if (!aRWriteOffControl.IsDisposed)
            {
                aRWriteOffControl.Dock = DockStyle.Fill;
                TabPage tab = new TabPage();
                tab.Name = "應收沖帳";
                tab.Text = tab.Name;
                tab.Controls.Add(aRWriteOffControl);
                //FrmCust frm = this.Parent.Parent.Parent.FindForm() as FrmCust;
                TabControl tabControl = (TabControl)this.Parent.Parent.Parent.Parent;
                try
                {
                    tabControl.TabPages.Add(tab);
                    tabControl.SelectedTab = tab;
                    tabControl.SizeMode = TabSizeMode.Fixed;
                    tabControl.ItemSize = new Size(120, 30);
                }
                catch { }
            }
        }

        private void btn單筆收款_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您確定要對此憑證單筆收款?", "請選擇", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.沖銷人員 = AppSession.User.username;
                var writeOffRep = _arController.WriteOffAccounts(form);
            }
        }
    }
}
