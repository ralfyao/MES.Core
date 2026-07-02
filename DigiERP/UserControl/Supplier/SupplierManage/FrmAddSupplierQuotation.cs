using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class FrmAddSupplierQuotation : Form
    {
        private readonly string _supplierNo;
        private readonly SupplierController _controller;
        private List<成本單位人員配置> _staffList = new List<成本單位人員配置>();

        public FrmAddSupplierQuotation(string supplierNo, SupplierController controller)
        {
            InitializeComponent();
            _supplierNo = supplierNo ?? "";
            _controller = controller;
        }

        private void FrmAddSupplierQuotation_Load(object sender, EventArgs e)
        {
            txtSupplierNo.Text = _supplierNo;
            dtpQuotDate.Value = DateTime.Now;
            dtpValidDate.Value = DateTime.Now;
            numMinQty.Value = 1;
            numMaxQty.Value = 1;

            initCurrencyCombo();
            initInquirerCombo();
        }

        private void initCurrencyCombo()
        {
            var rep = new CustomerController().GetCurrencyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboCurrency.DisplayMember = "CURRENCY";
            cboCurrency.ValueMember = "CURRENCY";
            cboCurrency.DataSource = rep.resultList ?? new List<F幣別>();
            cboCurrency.Text = "TWD";
        }

        private void initInquirerCombo()
        {
            var rep = _controller.GetPurchaseStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _staffList = rep.resultList ?? new List<成本單位人員配置>();
            cboInquirer.DisplayMember = "員工姓名";
            cboInquirer.ValueMember = "員工編號";
            cboInquirer.DataSource = _staffList;
        }

        private void btnPickItem_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmSelectMaterial();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                txtItemNo.Text = dlg.Selected.產品編號 ?? "";
                txtUnit.Text = dlg.Selected.採購單位 ?? "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierNo.Text))
            {
                MessageBox.Show("廠商編號不可為空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemNo.Text))
            {
                MessageBox.Show("請選取品項編號");
                return;
            }

            var form = new B廠商供料
            {
                廠商編號 = txtSupplierNo.Text.Trim(),
                詢價日期 = dtpQuotDate.Value.ToString("yyyy/MM/dd"),
                品項編號 = txtItemNo.Text.Trim(),
                採購單位 = txtUnit.Text.Trim(),
                最低採購量 = (int)numMinQty.Value,
                最大採購量 = (int)numMaxQty.Value,
                單價 = (int)numPrice.Value,
                幣別 = cboCurrency.Text.Trim(),
                詢價人員 = cboInquirer.Text.Trim(),
                報價有效日期 = dtpValidDate.Value.ToString("yyyy/MM/dd"),
                廠商品號 = txtVendorItemNo.Text.Trim(),
            };

            var rep = _controller.AddSupplierQuotation(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("新增成功");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
