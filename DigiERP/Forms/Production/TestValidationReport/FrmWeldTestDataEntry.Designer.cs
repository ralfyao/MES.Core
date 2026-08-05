using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.TestValidationReport
{
    partial class FrmWeldTestDataEntry
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelFields = new Panel();
            panelButtons = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            panelButtons.SuspendLayout();
            SuspendLayout();
            //
            // panelFields
            //
            panelFields.AutoScroll = true;
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(0, 0);
            panelFields.Name = "panelFields";
            panelFields.Size = new Size(600, 480);
            panelFields.TabIndex = 0;
            //
            // panelButtons
            //
            panelButtons.BackColor = Color.WhiteSmoke;
            panelButtons.Controls.Add(btnOK);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 480);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(600, 56);
            panelButtons.TabIndex = 1;
            //
            // btnOK
            //
            btnOK.BackColor = Color.LightSteelBlue;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOK.Location = new Point(340, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 32);
            btnOK.TabIndex = 0;
            btnOK.Text = "確定並列印";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(468, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // FrmWeldTestDataEntry
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 536);
            Controls.Add(panelFields);
            Controls.Add(panelButtons);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "FrmWeldTestDataEntry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "焊接測試數據登錄";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFields;
        private Panel panelButtons;
        private Button btnOK;
        private Button btnCancel;
    }
}
