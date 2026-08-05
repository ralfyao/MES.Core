using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.TestValidationReport
{
    // ── 焊接測試數據登錄：列印賣方廠驗收單前，讓使用者填入 TEST AND TRIAL
    //    PARAMETERS 焊接測試數據 這一列的值，按「確定並列印」存檔後帶到列印表單顯示 ──
    public partial class FrmWeldTestDataEntry : Form
    {
        // ── 對應 A01~A16 的真實欄位意義(與列印表單顯示的標題一致)，全部為 NumericUpDown ──
        private static readonly (string Caption, string Key)[] Fields =
        {
            ("Model", "Model"),
            ("Motor Speed", "A01"),
            ("Weld P kgf/cm²", "A02"),
            ("Clamp P", "A03"),
            ("SQZ", "A04"),
            ("Weld KA1", "A05"),
            ("Weld Time1", "A06"),
            ("Cool Time1", "A07"),
            ("Weld KA2", "A08"),
            ("Weld Time2", "A09"),
            ("Cool Time2", "A10"),
            ("Weld KA3", "A11"),
            ("Weld Time3", "A12"),
            ("Hold Time", "A13"),
            ("Pri.kA", "A14"),
            ("Sec.kA", "A15"),
            ("Peel Test", "A16"),
        };

        private readonly Dictionary<string, NumericUpDown> _inputs = new Dictionary<string, NumericUpDown>();
        private readonly int _existingId;
        private readonly string _projectNo;

        public 專案焊接測試數據 Result { get; private set; }

        public FrmWeldTestDataEntry(string projectNo, 專案焊接測試數據 existing)
        {
            InitializeComponent();
            _projectNo = projectNo;
            _existingId = existing?.識別碼 ?? 0;
            BuildFields();
            if (existing != null) FillFrom(existing);
        }

        private void BuildFields()
        {
            int x = 16, y = 16;
            int col = 0;
            foreach (var (caption, key) in Fields)
            {
                var lbl = new Label
                {
                    Text = caption,
                    Location = new Point(x, y + 4),
                    AutoSize = false,
                    Size = new Size(110, 24),
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                panelFields.Controls.Add(lbl);

                var input = new NumericUpDown
                {
                    Location = new Point(x + 112, y + 2),
                    Size = new Size(120, 26),
                    DecimalPlaces = 2,
                    Minimum = 0,
                    Maximum = 999999,
                };
                panelFields.Controls.Add(input);
                _inputs[key] = input;

                col++;
                if (col % 2 == 0)
                {
                    x = 16;
                    y += 34;
                }
                else
                {
                    x = 288;
                }
            }
        }

        private void FillFrom(專案焊接測試數據 x)
        {
            SetValue("Model", x.Model);
            SetValue("A01", x.A01); SetValue("A02", x.A02); SetValue("A03", x.A03); SetValue("A04", x.A04);
            SetValue("A05", x.A05); SetValue("A06", x.A06); SetValue("A07", x.A07); SetValue("A08", x.A08);
            SetValue("A09", x.A09); SetValue("A10", x.A10); SetValue("A11", x.A11); SetValue("A12", x.A12);
            SetValue("A13", x.A13); SetValue("A14", x.A14); SetValue("A15", x.A15); SetValue("A16", x.A16);
        }

        private void SetValue(string key, string value)
        {
            if (_inputs.TryGetValue(key, out var nud) && decimal.TryParse(value, out var d))
            {
                nud.Value = Math.Min(Math.Max(d, nud.Minimum), nud.Maximum);
            }
        }

        private string GetValue(string key) => _inputs.TryGetValue(key, out var nud) ? nud.Value.ToString() : null;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = new 專案焊接測試數據
            {
                識別碼 = _existingId,
                專案序號 = _projectNo,
                Model = GetValue("Model"),
                A01 = GetValue("A01"), A02 = GetValue("A02"), A03 = GetValue("A03"), A04 = GetValue("A04"),
                A05 = GetValue("A05"), A06 = GetValue("A06"), A07 = GetValue("A07"), A08 = GetValue("A08"),
                A09 = GetValue("A09"), A10 = GetValue("A10"), A11 = GetValue("A11"), A12 = GetValue("A12"),
                A13 = GetValue("A13"), A14 = GetValue("A14"), A15 = GetValue("A15"), A16 = GetValue("A16"),
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
