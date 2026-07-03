using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmAddPartCode : Form
    {
        private ItemController _controller;

        public FrmAddPartCode()
        {
            InitializeComponent();
            _controller = new ItemController();
        }

        private void btnPickCategory_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmSelectMaterialCategory();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                txtCategory.Text = dlg.Selected.大分類 ?? "";
            }
        }

        private void btnPickFormula_Click(object sender, EventArgs e)
        {
            using var dlg = new FrmSelectMaterialFormula();
            if (dlg.ShowDialog() == DialogResult.OK && dlg.Selected != null)
            {
                txtFormula.Text = dlg.Selected.公式代號 ?? "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("請輸入材料產品代號!");
                return;
            }

            var form = new A材料品項代號
            {
                產品代號 = txtProductCode.Text.Trim(),
                大分類 = txtCategory.Text.Trim(),
                小分類 = txtSubCategory.Text.Trim(),
                小分類名稱 = txtSubCategoryName.Text.Trim(),
                密度 = txtDensity.Text.Trim(),
                公式代號 = txtFormula.Text.Trim(),
            };

            var rep = _controller.AddPartCode(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("新增成功");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
