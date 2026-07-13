using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ProjectProcurement
{
    partial class FrmProjectProcurementFilter
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            lblProjectNo = new Label();
            cboProjectNo = new ComboBox();
            lblModuleCode = new Label();
            cboModuleCode = new ComboBox();
            lblPartNo = new Label();
            cboPartNo = new ComboBox();
            btnConfirm = new Button();
            btnLeave = new Button();
            SuspendLayout();
            //
            // lblProjectNo
            //
            lblProjectNo.BackColor = Color.LightYellow;
            lblProjectNo.BorderStyle = BorderStyle.FixedSingle;
            lblProjectNo.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblProjectNo.ForeColor = Color.Navy;
            lblProjectNo.Location = new Point(20, 20);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(100, 30);
            lblProjectNo.TabIndex = 0;
            lblProjectNo.Text = "專案序號";
            lblProjectNo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // cboProjectNo
            //
            cboProjectNo.Font = new Font("微軟正黑體", 10F);
            cboProjectNo.Location = new Point(126, 20);
            cboProjectNo.Name = "cboProjectNo";
            cboProjectNo.Size = new Size(180, 27);
            cboProjectNo.TabIndex = 1;
            //
            // lblModuleCode
            //
            lblModuleCode.BackColor = Color.LightYellow;
            lblModuleCode.BorderStyle = BorderStyle.FixedSingle;
            lblModuleCode.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblModuleCode.ForeColor = Color.Navy;
            lblModuleCode.Location = new Point(20, 64);
            lblModuleCode.Name = "lblModuleCode";
            lblModuleCode.Size = new Size(100, 30);
            lblModuleCode.TabIndex = 2;
            lblModuleCode.Text = "模組編碼";
            lblModuleCode.TextAlign = ContentAlignment.MiddleCenter;
            //
            // cboModuleCode
            //
            cboModuleCode.Font = new Font("微軟正黑體", 10F);
            cboModuleCode.Location = new Point(126, 64);
            cboModuleCode.Name = "cboModuleCode";
            cboModuleCode.Size = new Size(180, 27);
            cboModuleCode.TabIndex = 3;
            //
            // lblPartNo
            //
            lblPartNo.BackColor = Color.LightYellow;
            lblPartNo.BorderStyle = BorderStyle.FixedSingle;
            lblPartNo.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblPartNo.ForeColor = Color.Navy;
            lblPartNo.Location = new Point(20, 108);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(100, 30);
            lblPartNo.TabIndex = 4;
            lblPartNo.Text = "零件號碼";
            lblPartNo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // cboPartNo
            //
            cboPartNo.Font = new Font("微軟正黑體", 10F);
            cboPartNo.Location = new Point(126, 108);
            cboPartNo.Name = "cboPartNo";
            cboPartNo.Size = new Size(180, 27);
            cboPartNo.TabIndex = 5;
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.SteelBlue;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(30, 160);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(110, 36);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "確定";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // btnLeave
            //
            btnLeave.BackColor = Color.Gainsboro;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnLeave.Location = new Point(180, 160);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(110, 36);
            btnLeave.TabIndex = 7;
            btnLeave.Text = "離開";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            //
            // FrmProjectProcurementFilter
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(326, 220);
            Controls.Add(lblProjectNo);
            Controls.Add(cboProjectNo);
            Controls.Add(lblModuleCode);
            Controls.Add(cboModuleCode);
            Controls.Add(lblPartNo);
            Controls.Add(cboPartNo);
            Controls.Add(btnConfirm);
            Controls.Add(btnLeave);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProjectProcurementFilter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "複式篩選";
            ResumeLayout(false);
        }

        #endregion

        private Label lblProjectNo;
        private ComboBox cboProjectNo;
        private Label lblModuleCode;
        private ComboBox cboModuleCode;
        private Label lblPartNo;
        private ComboBox cboPartNo;
        private Button btnConfirm;
        private Button btnLeave;
    }
}
