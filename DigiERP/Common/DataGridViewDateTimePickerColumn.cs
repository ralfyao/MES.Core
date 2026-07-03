namespace DigiERP.Common
{
    public class DataGridViewDateTimePickerColumn : DataGridViewColumn
    {
        public DataGridViewDateTimePickerColumn() : base(new DataGridViewDateTimePickerCell())
        {
        }

        public override DataGridViewCell? CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !(value is DataGridViewDateTimePickerCell))
                {
                    throw new InvalidCastException("CellTemplate 必須是 DataGridViewDateTimePickerCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewDateTimePickerCell : DataGridViewTextBoxCell
    {
        public DataGridViewDateTimePickerCell()
        {
            Style.Format = "yyyy/MM/dd";
        }

        public override void InitializeEditingControl(int rowIndex, object? initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView?.EditingControl is DataGridViewDateTimePickerEditingControl ctl)
            {
                ctl.Value = DateTime.TryParse(Value?.ToString(), out var dt) ? dt : DateTime.Now;
            }
        }

        public override Type EditType => typeof(DataGridViewDateTimePickerEditingControl);
        public override Type ValueType => typeof(string);
        public override object DefaultNewRowValue => DateTime.Now.ToString("yyyy/MM/dd");
    }

    public class DataGridViewDateTimePickerEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView? _dataGridView;
        private bool _valueChanged = false;
        private int _rowIndex;

        public DataGridViewDateTimePickerEditingControl()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "yyyy/MM/dd";
        }

        public object EditingControlFormattedValue
        {
            get => Value.ToString("yyyy/MM/dd");
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
