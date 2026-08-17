namespace DigiERP.Common
{
    // ── 時間(HH:mm)選取欄位：比照既有 DataGridViewDateTimePickerColumn 的作法，
    //    但用於純時間(無日期部分)欄位，例如每日出勤紀錄的正規/加班上下班 ──────
    public class DataGridViewTimePickerColumn : DataGridViewColumn
    {
        public DataGridViewTimePickerColumn() : base(new DataGridViewTimePickerCell())
        {
        }

        public override DataGridViewCell? CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !(value is DataGridViewTimePickerCell))
                {
                    throw new InvalidCastException("CellTemplate 必須是 DataGridViewTimePickerCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewTimePickerCell : DataGridViewTextBoxCell
    {
        public DataGridViewTimePickerCell()
        {
            Style.Format = "HH:mm";
        }

        public override void InitializeEditingControl(int rowIndex, object? initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView?.EditingControl is DataGridViewTimePickerEditingControl ctl)
            {
                ctl.Value = DateTime.TryParse(Value?.ToString(), out var dt) ? dt : DateTime.Now;
            }
        }

        public override Type EditType => typeof(DataGridViewTimePickerEditingControl);
        public override Type ValueType => typeof(string);
        public override object DefaultNewRowValue => "";
    }

    public class DataGridViewTimePickerEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView? _dataGridView;
        private bool _valueChanged = false;
        private int _rowIndex;

        public DataGridViewTimePickerEditingControl()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "HH:mm";
            ShowUpDown = true;
        }

        public object EditingControlFormattedValue
        {
            get => Value.ToString("HH:mm");
            set
            {
                if (value is string s && DateTime.TryParse(s, out var dt))
                {
                    Value = dt;
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex { get => _rowIndex; set => _rowIndex = value; }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey) => false;

        public void PrepareEditingControlForEdit(bool selectAll) { }

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
