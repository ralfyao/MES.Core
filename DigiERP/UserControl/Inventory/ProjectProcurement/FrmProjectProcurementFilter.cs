using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ProjectProcurement
{
    public partial class FrmProjectProcurementFilter : Form
    {
        public string ProjectNo { get; private set; } = "";
        public string ModuleCode { get; private set; } = "";
        public string PartNo { get; private set; } = "";

        public FrmProjectProcurementFilter(List<採購計畫> list)
        {
            InitializeComponent();
            cboProjectNo.Items.AddRange(DistinctValues(list, x => x.專案序號));
            cboModuleCode.Items.AddRange(DistinctValues(list, x => x.模組編碼));
            cboPartNo.Items.AddRange(DistinctValues(list, x => x.零件號碼));
        }

        private static object[] DistinctValues(List<採購計畫> list, Func<採購計畫, string> selector)
        {
            return list.Select(selector)
                .Select(v => v?.Trim())
                .Where(v => !string.IsNullOrEmpty(v))
                .Distinct()
                .OrderBy(v => v)
                .Cast<object>()
                .ToArray();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ProjectNo = cboProjectNo.Text.Trim();
            ModuleCode = cboModuleCode.Text.Trim();
            PartNo = cboPartNo.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
