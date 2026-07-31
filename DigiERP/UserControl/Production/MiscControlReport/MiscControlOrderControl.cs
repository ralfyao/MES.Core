using DigiERP.Common;
using DigiERP.Forms.Production;
using DigiERP.Models;
using DigiERP.UserControl.Production;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.MiscControlReport
{
    // ── 零件管制報告書：表頭資料來源為採購計畫；下方「零件生產工序」「零件檢驗履歷」
    //    兩個明細清單畫面先行建置，資料來源日後再串接 ─────────────────────────
    public partial class MiscControlOrderControl : CommonUserControl
    {
        private static string id = "2C06C0CD-838C-4B83-B9EA-6BC3B84D3110";

        private List<成本單位人員配置> _acceptStaffList = new List<成本單位人員配置>();
        private List<成本單位人員配置> _warehouseStaffList = new List<成本單位人員配置>();
        private List<產製單位> _productionUnitList = new List<產製單位>();
        private List<成本單位人員配置> _processOperatorList = new List<成本單位人員配置>();
        private List<成本單位人員配置> _inspectionCheckerList = new List<成本單位人員配置>();

        // ── 零件生產工序「工作站」下拉：依製程別各自對應不同的固定選項 ──────────
        private static readonly Dictionary<string, string[]> _workStationOptions = new Dictionary<string, string[]>
        {
            ["機械加工"] = new[] { "車床1", "銑床1", "焊接1", "車床2", "銑床2", "焊接2", "鑽床" },
            ["特殊塑型"] = new[] { "翻鑄", "銑平", "塘孔" },
            ["精密加工"] = new[] { "線切割", "研磨", "雷射切割" },
            ["防變形"] = new[] { "應力消除", "熱處理" },
            ["表面處理"] = new[] { "烤漆", "電鍍", "陽極", "鍍黑" },
        };

        // ── 零件檢驗履歷 尺寸精度/幾何精度/材質標準/表面工藝/硬度要求/毛邊修整/微觀裂痕 下拉：固定選項 ──
        private static readonly string[] _inspectionResultOptions = { "合格", "特採", "重工", "報廢", "設變" };

        public MiscControlOrderControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initAcceptStaffCombo();
            initWarehouseStaffCombo();
            initAcceptResultCombo();
            initProductionUnitCombo();
            initProcessOperatorCombo();
            initInspectionCheckerCombo();
            initInspectionResultCombos();
            cboAcceptStaff.DropDown += cboAcceptStaff_DropDown;
            cboWarehouseStaff.DropDown += cboWarehouseStaff_DropDown;
        }

        // ── 零件檢驗履歷「檢查人員」下拉：職務為加工/組測/程控的成本單位人員配置 ────
        private void initInspectionCheckerCombo()
        {
            var rep = new ProjectProgressController().GetInspectionCheckerStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _inspectionCheckerList = rep.resultList ?? new List<成本單位人員配置>();
        }

        // ── 零件檢驗履歷 尺寸精度/幾何精度/材質標準/表面工藝/硬度要求/毛邊修整/微觀裂痕 下拉：固定選項 ──
        private void initInspectionResultCombos()
        {
            foreach (var col in new[] { colSizeSpec, colGeoSpec, colMaterialSpec, colSurfaceSpec, colHardnessSpec, colBurrTrim, colMicroCrack })
            {
                col.Items.Clear();
                col.Items.Add("");
                col.Items.AddRange(_inspectionResultOptions);
            }
        }

        // ── 零件生產工序「產製單位」下拉：來源為 產製單位 主檔 ────────────────
        private void initProductionUnitCombo()
        {
            var rep = new ProjectProcurementController().GetProductionUnitList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _productionUnitList = rep.resultList ?? new List<產製單位>();
        }

        // ── 零件生產工序「作業人員」下拉：職務為加工/倉管的成本單位人員配置 ─────
        private void initProcessOperatorCombo()
        {
            var rep = new ProjectProgressController().GetProcessOperatorStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _processOperatorList = rep.resultList ?? new List<成本單位人員配置>();
        }

        // ── 驗收結果下拉：固定選項 ──────────────────────────────────
        private void initAcceptResultCombo()
        {
            cboAcceptResult.Items.Clear();
            cboAcceptResult.Items.AddRange(new object[] { "", "合格允收", "轉設計變更" });
        }

        // ── 驗收人員下拉：職務為加工/組測/程控/倉管的成本單位人員配置(對應到 H員工清冊 取姓名) ──
        private void initAcceptStaffCombo()
        {
            var rep = new ProjectProgressController().GetAcceptanceStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _acceptStaffList = rep.resultList ?? new List<成本單位人員配置>();
            cboAcceptStaff.Items.Clear();
            cboAcceptStaff.Items.Add("");
            foreach (var name in _acceptStaffList.Select(x => x.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                cboAcceptStaff.Items.Add(name);
            }
        }

        // ── 倉管人員下拉：職務為倉管的成本單位人員配置(對應到 H員工清冊 取姓名) ──────
        private void initWarehouseStaffCombo()
        {
            var rep = new ProjectProgressController().GetWarehouseStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _warehouseStaffList = rep.resultList ?? new List<成本單位人員配置>();
            cboWarehouseStaff.Items.Clear();
            cboWarehouseStaff.Items.Add("");
            foreach (var name in _warehouseStaffList.Select(x => x.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                cboWarehouseStaff.Items.Add(name);
            }
        }

        // ── 驗收人員下拉改為跳出選取視窗(FrmSelectStaff)，不使用原生下拉清單 ──────
        private void cboAcceptStaff_DropDown(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                cboAcceptStaff.DroppedDown = false;
                using var frm = new FrmSelectStaff(_acceptStaffList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    cboAcceptStaff.Text = frm.SelectedItem.姓名;
                }
            }));
        }

        // ── 倉管人員下拉改為跳出選取視窗(FrmSelectStaff)，不使用原生下拉清單 ──────
        private void cboWarehouseStaff_DropDown(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                cboWarehouseStaff.DroppedDown = false;
                using var frm = new FrmSelectStaff(_warehouseStaffList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    cboWarehouseStaff.Text = frm.SelectedItem.姓名;
                }
            }));
        }

        private 採購計畫 _current;

        // ── 由「零件管制報告總覽」點選零件管制單號開啟：載入表頭資料 ─────────
        internal void LoadData(string controlNo)
        {
            var rep = new ProjectProcurementController().GetMiscControlOrderByNo(controlNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var x = _current = rep.result;
            txtControlNo.Text = x?.零件管制單號;
            txtStockInDate.Text = x?.入庫移轉日;
            txtPartNo.Text = x?.零件號碼;
            txtProjectNo.Text = x?.專案序號;
            txtAcceptDate.Text = x?.驗收日期;
            txtPartName.Text = x?.品名;
            txtModuleCode.Text = x?.模組編碼;
            cboAcceptStaff.Text = x?.驗收人員;
            txtDesc.Text = x?.描述;
            txtModuleName.Text = x?.模組名稱;
            cboWarehouseStaff.Text = x?.倉管人員;
            txtQty.Text = x?.數量;
            cboAcceptResult.Text = x?.驗收合格;

            txtApprover.Text = x?.核准;
            txtApproveDate.Text = x?.核准日;
            txtModifier.Text = x?.修改;
            txtModifyDate.Text = x?.修改日;
            txtCreator.Text = x?.建檔;
            txtCreateDate.Text = x?.建檔日;

            FillProcessGrid(x);
            FillInspectionGrid(controlNo);

            // ── 開啟畫面預設鎖定，需按「修改」才能編輯 ──────────────────
            disableControls(false);
        }

        // ── 零件檢驗履歷：資料來源為 採購零件檢驗履歷，依零件管制單號查詢 ──────
        private void FillInspectionGrid(string controlNo)
        {
            dataGridView2.Rows.Clear();
            txtReasonNote.Text = "";

            colChecker.Items.Clear();
            colChecker.Items.Add("");
            foreach (var name in _inspectionCheckerList.Select(o => o.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colChecker.Items.Add(name);
            }

            var rep = new ProjectProcurementController().GetMiscControlInspectionList(controlNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            foreach (var item in rep.resultList ?? new List<採購零件檢驗履歷>())
            {
                string checker = (item.檢查人員 ?? "").Trim();
                if (!string.IsNullOrEmpty(checker) && !colChecker.Items.Contains(checker)) colChecker.Items.Add(checker);
                foreach (var (col, value) in new (DataGridViewComboBoxColumn col, string value)[]
                {
                    (colSizeSpec, item.尺寸精度), (colGeoSpec, item.幾何精度), (colMaterialSpec, item.材質標準),
                    (colSurfaceSpec, item.表面工藝), (colHardnessSpec, item.硬度要求), (colBurrTrim, item.毛邊修整), (colMicroCrack, item.微觀裂痕)
                })
                {
                    string trimmed = (value ?? "").Trim();
                    if (!string.IsNullOrEmpty(trimmed) && !col.Items.Contains(trimmed)) col.Items.Add(trimmed);
                }

                int i = dataGridView2.Rows.Add();
                var row = dataGridView2.Rows[i];
                row.Cells[colCheckDate.Index].Value = item.檢查日期;
                row.Cells[colChecker.Index].Value = checker;
                row.Cells[colSizeSpec.Index].Value = (item.尺寸精度 ?? "").Trim();
                row.Cells[colGeoSpec.Index].Value = (item.幾何精度 ?? "").Trim();
                row.Cells[colMaterialSpec.Index].Value = (item.材質標準 ?? "").Trim();
                row.Cells[colSurfaceSpec.Index].Value = (item.表面工藝 ?? "").Trim();
                row.Cells[colHardnessSpec.Index].Value = (item.硬度要求 ?? "").Trim();
                row.Cells[colBurrTrim.Index].Value = (item.毛邊修整 ?? "").Trim();
                row.Cells[colMicroCrack.Index].Value = (item.微觀裂痕 ?? "").Trim();
                row.Tag = (item.識別碼, item.原因說明);
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 點選履歷紀錄，帶出該筆的查檢說明(原因說明) ─────────────────
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView2.Rows[e.RowIndex].Tag is ValueTuple<int, string> tag)
            {
                txtReasonNote.Text = tag.Item2 ?? "";
            }
        }

        // ── 鎖定/解鎖可編輯欄位：驗收人員/倉管人員/驗收結果 下拉、零件生產工序/零件檢驗履歷 Grid ──
        private void disableControls(bool enable)
        {
            cboAcceptStaff.Enabled = enable;
            cboWarehouseStaff.Enabled = enable;
            cboAcceptResult.Enabled = enable;
            dataGridView1.ReadOnly = !enable;
            dataGridView2.ReadOnly = !enable;
        }

        // ── 零件生產工序：採購計畫中「機械加工/特殊塑型/精密加工/防變形/表面處理」
        //    五組並列欄位(各自搭配 產製單位N/作業人員N/開工日期N/預交日期N/完工日期N/完工數量N)
        //    轉為 5 列呈現 ──────────────────────────────────────
        private void FillProcessGrid(採購計畫 x)
        {
            dataGridView1.Rows.Clear();

            colProductionUnit.Items.Clear();
            colProductionUnit.Items.Add("");
            foreach (var name in _productionUnitList.Select(u => u.產製單位名稱).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colProductionUnit.Items.Add(name);
            }

            colOperator.Items.Clear();
            colOperator.Items.Add("");
            foreach (var name in _processOperatorList.Select(o => o.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colOperator.Items.Add(name);
            }

            if (x == null) return;

            AddProcessRow("機械加工", x.機械加工, x.產製單位1, x.作業人員1, x.開工日期1, x.預交日期1, x.完工日期1, x.完工數量1);
            AddProcessRow("特殊塑型", x.特殊塑型, x.產製單位2, x.作業人員2, x.開工日期2, x.預交日期2, x.完工日期2, x.完工數量2);
            AddProcessRow("精密加工", x.精密加工, x.產製單位3, x.作業人員3, x.開工日期3, x.預交日期3, x.完工日期3, x.完工數量3);
            AddProcessRow("防變形", x.防變形, x.產製單位4, x.作業人員4, x.開工日期4, x.預交日期4, x.完工日期4, x.完工數量4);
            AddProcessRow("表面處理", x.表面處理, x.產製單位5, x.作業人員5, x.開工日期5, x.預交日期5, x.完工日期5, x.完工數量5);
        }

        private void AddProcessRow(string processType, string workStation, string productionUnit, string operatorName, string startDate, string dueDate, string finishDate, string finishQty)
        {
            workStation = (workStation ?? "").Trim();
            productionUnit = (productionUnit ?? "").Trim();
            operatorName = (operatorName ?? "").Trim();

            int i = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[i];

            // ── 工作站下拉依製程別套用各自的固定選項清單 ──────────────
            var stationCell = (DataGridViewComboBoxCell)row.Cells[colWorkStation.Index];
            stationCell.Items.Clear();
            stationCell.Items.Add("");
            foreach (var station in _workStationOptions.TryGetValue(processType, out var options) ? options : Array.Empty<string>())
            {
                stationCell.Items.Add(station);
            }
            if (!string.IsNullOrEmpty(workStation) && !stationCell.Items.Contains(workStation)) stationCell.Items.Add(workStation);

            if (!string.IsNullOrEmpty(productionUnit) && !colProductionUnit.Items.Contains(productionUnit)) colProductionUnit.Items.Add(productionUnit);
            if (!string.IsNullOrEmpty(operatorName) && !colOperator.Items.Contains(operatorName)) colOperator.Items.Add(operatorName);

            row.Cells[colProcessType.Index].Value = processType;
            row.Cells[colWorkStation.Index].Value = workStation;
            row.Cells[colProductionUnit.Index].Value = productionUnit;
            row.Cells[colOperator.Index].Value = operatorName;
            row.Cells[colStartDate.Index].Value = startDate;
            row.Cells[colDueDate.Index].Value = dueDate;
            row.Cells[colFinishDate.Index].Value = finishDate;
            row.Cells[colFinishQty.Index].Value = decimal.TryParse(finishQty, out var qty) ? qty : 0m;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnDelete_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 已生效(核准/核准日尚未清空)的紀錄需先按「取消生效」才能修改 ─────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_current?.核准) || !string.IsNullOrEmpty(_current?.核准日))
            {
                MessageBox.Show("請先取消生效");
                return;
            }
            disableControls(true);
        }

        // ── 儲存：表頭+零件生產工序 Grid 寫回 採購計畫；零件檢驗履歷 Grid 寫回 採購零件檢驗履歷 ──
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_current == null) return;

            _current.驗收人員 = cboAcceptStaff.Text;
            _current.倉管人員 = cboWarehouseStaff.Text;
            _current.驗收合格 = cboAcceptResult.Text;
            _current.修改 = AppSession.User?.username;
            _current.修改日 = DateTime.Now.ToString("yyyy/MM/dd");
            CollectProcessGrid(_current);

            var orderRep = new ProjectProcurementController().UpdateMiscControlOrder(_current);
            if (!string.IsNullOrEmpty(orderRep.ErrorMessage)) { MessageBox.Show(orderRep.ErrorMessage); return; }

            var inspectionList = CollectInspectionGrid();
            if (inspectionList.Count > 0)
            {
                var inspectionRep = new ProjectProcurementController().UpdateMiscControlInspectionList(inspectionList);
                if (!string.IsNullOrEmpty(inspectionRep.ErrorMessage)) { MessageBox.Show(inspectionRep.ErrorMessage); return; }
            }

            MessageBox.Show("儲存成功!");
            disableControls(false);
            LoadData(_current.零件管制單號);
        }

        // ── 依固定 5 列順序(機械加工/特殊塑型/精密加工/防變形/表面處理)取回工序 Grid 內容 ──
        private void CollectProcessGrid(採購計畫 x)
        {
            (string workStation, string productionUnit, string operatorName, string startDate, string dueDate, string finishDate, decimal finishQty) GetRow(int i)
            {
                var row = dataGridView1.Rows[i];
                return (
                    row.Cells[colWorkStation.Index].Value as string ?? "",
                    row.Cells[colProductionUnit.Index].Value as string ?? "",
                    row.Cells[colOperator.Index].Value as string ?? "",
                    row.Cells[colStartDate.Index].Value as string ?? "",
                    row.Cells[colDueDate.Index].Value as string ?? "",
                    row.Cells[colFinishDate.Index].Value as string ?? "",
                    row.Cells[colFinishQty.Index].Value is decimal d ? d : 0m);
            }

            var r1 = GetRow(0);
            x.機械加工 = r1.workStation; x.產製單位1 = r1.productionUnit; x.作業人員1 = r1.operatorName;
            x.開工日期1 = r1.startDate; x.預交日期1 = r1.dueDate; x.完工日期1 = r1.finishDate; x.完工數量1 = r1.finishQty.ToString();

            var r2 = GetRow(1);
            x.特殊塑型 = r2.workStation; x.產製單位2 = r2.productionUnit; x.作業人員2 = r2.operatorName;
            x.開工日期2 = r2.startDate; x.預交日期2 = r2.dueDate; x.完工日期2 = r2.finishDate; x.完工數量2 = r2.finishQty.ToString();

            var r3 = GetRow(2);
            x.精密加工 = r3.workStation; x.產製單位3 = r3.productionUnit; x.作業人員3 = r3.operatorName;
            x.開工日期3 = r3.startDate; x.預交日期3 = r3.dueDate; x.完工日期3 = r3.finishDate; x.完工數量3 = r3.finishQty.ToString();

            var r4 = GetRow(3);
            x.防變形 = r4.workStation; x.產製單位4 = r4.productionUnit; x.作業人員4 = r4.operatorName;
            x.開工日期4 = r4.startDate; x.預交日期4 = r4.dueDate; x.完工日期4 = r4.finishDate; x.完工數量4 = r4.finishQty.ToString();

            var r5 = GetRow(4);
            x.表面處理 = r5.workStation; x.產製單位5 = r5.productionUnit; x.作業人員5 = r5.operatorName;
            x.開工日期5 = r5.startDate; x.預交日期5 = r5.dueDate; x.完工日期5 = r5.finishDate; x.完工數量5 = r5.finishQty.ToString();
        }

        // ── 取回零件檢驗履歷 Grid 內容(僅既有紀錄，識別碼來自載入時存於 Tag 的值) ──
        private List<採購零件檢驗履歷> CollectInspectionGrid()
        {
            var list = new List<採購零件檢驗履歷>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;
                int id = row.Tag is ValueTuple<int, string> tag ? tag.Item1 : 0;
                list.Add(new 採購零件檢驗履歷
                {
                    識別碼 = id,
                    零件管制單號 = _current.零件管制單號,
                    檢查日期 = row.Cells[colCheckDate.Index].Value as string,
                    檢查人員 = row.Cells[colChecker.Index].Value as string,
                    尺寸精度 = row.Cells[colSizeSpec.Index].Value as string,
                    幾何精度 = row.Cells[colGeoSpec.Index].Value as string,
                    材質標準 = row.Cells[colMaterialSpec.Index].Value as string,
                    表面工藝 = row.Cells[colSurfaceSpec.Index].Value as string,
                    硬度要求 = row.Cells[colHardnessSpec.Index].Value as string,
                    毛邊修整 = row.Cells[colBurrTrim.Index].Value as string,
                    微觀裂痕 = row.Cells[colMicroCrack.Index].Value as string,
                });
            }
            return list;
        }

        // ── 生效：寫入核准/核准日 ────────────────────────────────
        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_current?.零件管制單號)) return;
            var rep = new ProjectProcurementController().ValidateMiscControlOrder(_current.零件管制單號, true, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            _current.核准 = AppSession.User?.username;
            _current.核准日 = DateTime.Now.ToString("yyyy/MM/dd");
            txtApprover.Text = _current.核准;
            txtApproveDate.Text = _current.核准日;
            MessageBox.Show("生效成功!");
            OpenAbnormalCorrectionTab();
        }

        // ── 生效後開啟(或切換至)空白的異常矯正單頁籤 ─────────────────
        private void OpenAbnormalCorrectionTab()
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "AbnormalCorrection_" + _current.零件管制單號;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new AbnormalCorrectionReportControl { Dock = DockStyle.Fill };
            var tab = new TabPage("異常矯正單-" + _current.零件管制單號) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadBySourceDoc(_current.零件管制單號, _current.專案序號, _current.模組編碼, _current.模組名稱);
        }

        // ── 取消生效：清空核准/核准日 ─────────────────────────────
        private void btnCancelActivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_current?.零件管制單號)) return;
            var rep = new ProjectProcurementController().ValidateMiscControlOrder(_current.零件管制單號, false, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            _current.核准 = null;
            _current.核准日 = null;
            txtApprover.Text = "";
            txtApproveDate.Text = "";
            MessageBox.Show("取消生效成功!");
        }

        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private void btnClose_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }
    }
}
