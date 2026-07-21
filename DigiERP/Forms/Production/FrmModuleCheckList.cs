using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    public partial class FrmModuleCheckList : Form
    {
        private string _category;
        private bool _isNew;
        private static string moduleId = "17710D59-5F02-451E-9A16-5103B8D77DB8";

        public string SelectedCategory { get; private set; }

        // ── 既有分類：載入資料，按「修改」才能編輯 ──────────────────────
        public FrmModuleCheckList(模組圖檢查 category)
        {
            InitializeComponent();
            _isNew = false;
            _category = category?.檢查分類;
            txtCategory.Text = category?.檢查分類;
            txtCategory.ReadOnly = true;

            LoadDutyList(category?.職務);

            disableAllControls(true);
            LoadData();
        }

        //public FrmModuleCheckList()
        //{
        //    InitializeComponent();
        //    _isNew = true;
        //    //_category = category?.檢查分類;
        //    //txtCategory.Text = category?.檢查分類;
        //    txtCategory.ReadOnly = true;

        //    LoadDutyList("");

        //    disableAllControls(true);
        //    LoadData();
        //}

        // ── 新增分類：一開啟就可編輯，只顯示 儲存/關閉 ─────────────────────
        public FrmModuleCheckList()
        {
            InitializeComponent();
            _isNew = true;
            _category = null;
            txtCategory.ReadOnly = false;

            LoadDutyList(null);

            btnEdit.Visible = false;
            btnAddItem.Visible = false;
            cboDuty.Enabled = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            btnSave.Enabled = true;
        }

        private void LoadDutyList(string currentDuty)
        {
            var dutyRep = new ProjectProgressController().GetCostUnitDutyList();
            cboDuty.Items.Clear();
            cboDuty.Items.AddRange((dutyRep.resultList ?? new List<string>()).ToArray());
            if (!string.IsNullOrEmpty(currentDuty) && !cboDuty.Items.Contains(currentDuty))
            {
                cboDuty.Items.Add(currentDuty);
            }
            cboDuty.Text = currentDuty;
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(_category)) return;
            var rep = new ProjectProgressController().GetModuleCheckItemList(_category);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<模組圖檢查項目>());
        }

        private void FillGrid(List<模組圖檢查項目> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colSeq.Index].Value = x.項次;
                row.Cells[colCheckItem.Index].Value = x.檢查項目;
                row.Cells[colCheckMethod.Index].Value = x.檢查方法;
                row.Cells[colDesc.Index].Value = x.說明;
            }
        }

        private List<模組圖檢查項目> CollectGrid()
        {
            var list = new List<模組圖檢查項目>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string checkItem = row.Cells[colCheckItem.Index].Value?.ToString();
                if (string.IsNullOrWhiteSpace(checkItem)) continue;
                list.Add(new 模組圖檢查項目
                {
                    項次 = row.Cells[colSeq.Index].Value?.ToString(),
                    檢查項目 = checkItem,
                    檢查方法 = row.Cells[colCheckMethod.Index].Value?.ToString(),
                    說明 = row.Cells[colDesc.Index].Value?.ToString(),
                });
            }
            return list;
        }

        // ── 跟其他 Maintain 畫面一致：按「修改」前，除了 修改/關閉 以外的
        //    按鈕與可編輯欄位/表身明細都是 Disable ─────────────────────────
        private void disableAllControls(bool disable)
        {
            bool enabled = !disable;
            cboDuty.Enabled = enabled;
            dataGridView1.ReadOnly = disable;
            btnAddItem.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            disableAllControls(false);
        }

        private void btnAddItem_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string categoryName = txtCategory.Text?.Trim();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("請輸入檢查分類名稱");
                return;
            }

            var rep = new ProjectProgressController().SaveModuleCheckItemList(new MES.WebAPI.Models.SaveModuleCheckItemListReq
            {
                category = categoryName,
                duty = cboDuty.Text,
                items = CollectGrid(),
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _category = categoryName;
            MessageBox.Show("已儲存");

            if (_isNew)
            {
                _isNew = false;
                txtCategory.ReadOnly = true;
                btnEdit.Visible = true;
                btnAddItem.Visible = true;
            }
            disableAllControls(true);
            LoadData();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            SelectedCategory = txtCategory.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
