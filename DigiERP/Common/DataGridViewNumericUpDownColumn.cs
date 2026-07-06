namespace DigiERP.Common
{
    public class DataGridViewNumericUpDownColumn : DataGridViewColumn
    {
        public DataGridViewNumericUpDownColumn() : base(new DataGridViewNumericUpDownCell())
        {
        }

        public override DataGridViewCell? CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !(value is DataGridViewNumericUpDownCell))
                {
                    throw new InvalidCastException("CellTemplate 必須是 DataGridViewNumericUpDownCell");
                }
                base.CellTemplate = value;
            }
        }

        private DataGridViewNumericUpDownCell Template => (DataGridViewNumericUpDownCell)CellTemplate!;

        public int DecimalPlaces
        {
            get => Template.DecimalPlaces;
            set => Template.DecimalPlaces = value;
        }

        public decimal Minimum
        {
            get => Template.Minimum;
            set => Template.Minimum = value;
        }

        public decimal Maximum
        {
            get => Template.Maximum;
            set => Template.Maximum = value;
        }
    }

    public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
    {
        public int DecimalPlaces { get; set; } = 0;
        public decimal Minimum { get; set; } = 0;
        public decimal Maximum { get; set; } = 999999999;

        public override void InitializeEditingControl(int rowIndex, object? initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView?.EditingControl is DataGridViewNumericUpDownEditingControl ctl)
            {
                ctl.DecimalPlaces = DecimalPlaces;
                ctl.Minimum = Minimum;
                ctl.Maximum = Maximum;
                ctl.Value = decimal.TryParse(Value?.ToString(), out var v)
                    ? Math.Min(Math.Max(v, Minimum), Maximum)
                    : Minimum;
            }
        }

        public override Type EditType => typeof(DataGridViewNumericUpDownEditingControl);
        public override Type ValueType => typeof(decimal);
        public override object DefaultNewRowValue => 0m;
    }

    public class DataGridViewNumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView? _dataGridView;
        private bool _valueChanged = false;
        private int _rowIndex;

        public object EditingControlFormattedValue
        {
            get => Value.ToString();
            set
            {
                if (value is string s && decimal.TryParse(s, out var d))
                {
                    Value = Math.Min(Math.Max(d, Minimum), Maximum);
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ForeColor = dataGridViewCellStyle.ForeColor;
            BackColor = dataGridViewCellStyle.BackColor;
            TextAlign = HorizontalAlignment.Right;
        }

        public int EditingControlRowIndex { get => _rowIndex; set => _rowIndex = value; }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            if (!selectAll) return;
            foreach (Control c in Controls)
            {
                if (c is TextBox tb)
                {
                    tb.SelectAll();
                    break;
                }
            }
        }

        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView? EditingControlDataGridView { get => _dataGridView; set => _dataGridView = value; }

        public Cursor EditingPanelCursor => base.Cursor;

        public bool EditingControlValueChanged { get => _valueChanged; set => _valueChanged = value; }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            _valueChanged = true;
            _dataGridView?.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
