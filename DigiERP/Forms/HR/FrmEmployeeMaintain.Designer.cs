using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.HR
{
    partial class FrmEmployeeMaintain
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
            panelHeader = new Panel();
            lblTitle = new Label();
            btnSave = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            lblEmpNo = new Label();
            txtEmpNo = new TextBox();
            lblDept = new Label();
            txtDept = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSkill = new Label();
            txtSkill = new TextBox();
            lblIdNo = new Label();
            txtIdNo = new TextBox();
            lblBirthday = new Label();
            txtBirthday = new TextBox();
            lblJobTitle = new Label();
            txtJobTitle = new TextBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblHRNo = new Label();
            txtHRNo = new TextBox();
            lblCardNo = new Label();
            txtCardNo = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Wheat;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(620, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "員工資料表";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(340, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(470, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lblEmpNo);
            panelBody.Controls.Add(txtEmpNo);
            panelBody.Controls.Add(lblDept);
            panelBody.Controls.Add(txtDept);
            panelBody.Controls.Add(lblName);
            panelBody.Controls.Add(txtName);
            panelBody.Controls.Add(lblSkill);
            panelBody.Controls.Add(txtSkill);
            panelBody.Controls.Add(lblIdNo);
            panelBody.Controls.Add(txtIdNo);
            panelBody.Controls.Add(lblBirthday);
            panelBody.Controls.Add(txtBirthday);
            panelBody.Controls.Add(lblJobTitle);
            panelBody.Controls.Add(txtJobTitle);
            panelBody.Controls.Add(lblStatus);
            panelBody.Controls.Add(cboStatus);
            panelBody.Controls.Add(lblHRNo);
            panelBody.Controls.Add(txtHRNo);
            panelBody.Controls.Add(lblCardNo);
            panelBody.Controls.Add(txtCardNo);
            panelBody.Controls.Add(lblAddress);
            panelBody.Controls.Add(txtAddress);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 56);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(620, 364);
            panelBody.TabIndex = 1;
            // 
            // lblEmpNo
            // 
            lblEmpNo.AutoSize = true;
            lblEmpNo.Font = new Font("微軟正黑體", 10F);
            lblEmpNo.Location = new Point(30, 24);
            lblEmpNo.Name = "lblEmpNo";
            lblEmpNo.Size = new Size(36, 18);
            lblEmpNo.TabIndex = 0;
            lblEmpNo.Text = "工號";
            // 
            // txtEmpNo
            // 
            txtEmpNo.Font = new Font("微軟正黑體", 10F);
            txtEmpNo.Location = new Point(110, 20);
            txtEmpNo.Name = "txtEmpNo";
            txtEmpNo.Size = new Size(180, 25);
            txtEmpNo.TabIndex = 1;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("微軟正黑體", 10F);
            lblDept.Location = new Point(330, 24);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(36, 18);
            lblDept.TabIndex = 2;
            lblDept.Text = "部門";
            // 
            // txtDept
            // 
            txtDept.Font = new Font("微軟正黑體", 10F);
            txtDept.Location = new Point(410, 20);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(180, 25);
            txtDept.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("微軟正黑體", 10F);
            lblName.Location = new Point(30, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(36, 18);
            lblName.TabIndex = 4;
            lblName.Text = "姓名";
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 10F);
            txtName.Location = new Point(110, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 25);
            txtName.TabIndex = 5;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Font = new Font("微軟正黑體", 10F);
            lblSkill.Location = new Point(330, 66);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(36, 18);
            lblSkill.TabIndex = 6;
            lblSkill.Text = "職能";
            // 
            // txtSkill
            // 
            txtSkill.Font = new Font("微軟正黑體", 10F);
            txtSkill.Location = new Point(410, 62);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(180, 25);
            txtSkill.TabIndex = 7;
            // 
            // lblIdNo
            // 
            lblIdNo.AutoSize = true;
            lblIdNo.Font = new Font("微軟正黑體", 10F);
            lblIdNo.Location = new Point(30, 108);
            lblIdNo.Name = "lblIdNo";
            lblIdNo.Size = new Size(64, 18);
            lblIdNo.TabIndex = 8;
            lblIdNo.Text = "身分證號";
            // 
            // txtIdNo
            // 
            txtIdNo.Font = new Font("微軟正黑體", 10F);
            txtIdNo.Location = new Point(110, 104);
            txtIdNo.Name = "txtIdNo";
            txtIdNo.Size = new Size(180, 25);
            txtIdNo.TabIndex = 9;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("微軟正黑體", 10F);
            lblBirthday.Location = new Point(330, 108);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(36, 18);
            lblBirthday.TabIndex = 10;
            lblBirthday.Text = "生日";
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("微軟正黑體", 10F);
            txtBirthday.Location = new Point(410, 104);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(180, 25);
            txtBirthday.TabIndex = 11;
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("微軟正黑體", 10F);
            lblJobTitle.Location = new Point(30, 150);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(36, 18);
            lblJobTitle.TabIndex = 12;
            lblJobTitle.Text = "職稱";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Font = new Font("微軟正黑體", 10F);
            txtJobTitle.Location = new Point(110, 146);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(180, 25);
            txtJobTitle.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("微軟正黑體", 10F);
            lblStatus.Location = new Point(330, 150);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(36, 18);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "狀況";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("微軟正黑體", 10F);
            cboStatus.Items.AddRange(new object[] { "正常", "離職", "留職停薪" });
            cboStatus.Location = new Point(410, 146);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(180, 25);
            cboStatus.TabIndex = 15;
            // 
            // lblHRNo
            // 
            lblHRNo.AutoSize = true;
            lblHRNo.Font = new Font("微軟正黑體", 10F);
            lblHRNo.Location = new Point(30, 192);
            lblHRNo.Name = "lblHRNo";
            lblHRNo.Size = new Size(64, 18);
            lblHRNo.TabIndex = 16;
            lblHRNo.Text = "人事編號";
            // 
            // txtHRNo
            // 
            txtHRNo.Font = new Font("微軟正黑體", 10F);
            txtHRNo.Location = new Point(110, 188);
            txtHRNo.Name = "txtHRNo";
            txtHRNo.Size = new Size(180, 25);
            txtHRNo.TabIndex = 17;
            // 
            // lblCardNo
            // 
            lblCardNo.AutoSize = true;
            lblCardNo.Font = new Font("微軟正黑體", 10F);
            lblCardNo.Location = new Point(330, 192);
            lblCardNo.Name = "lblCardNo";
            lblCardNo.Size = new Size(36, 18);
            lblCardNo.TabIndex = 18;
            lblCardNo.Text = "卡號";
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("微軟正黑體", 10F);
            txtCardNo.Location = new Point(410, 188);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(180, 25);
            txtCardNo.TabIndex = 19;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("微軟正黑體", 10F);
            lblAddress.Location = new Point(30, 234);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(36, 18);
            lblAddress.TabIndex = 20;
            lblAddress.Text = "地址";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("微軟正黑體", 10F);
            txtAddress.Location = new Point(110, 230);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 70);
            txtAddress.TabIndex = 21;
            // 
            // FrmEmployeeMaintain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 420);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmployeeMaintain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "員工資料維護";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnSave;
        private Button btnExit;
        private Panel panelBody;
        private Label lblEmpNo;
        private TextBox txtEmpNo;
        private Label lblDept;
        private TextBox txtDept;
        private Label lblName;
        private TextBox txtName;
        private Label lblSkill;
        private TextBox txtSkill;
        private Label lblIdNo;
        private TextBox txtIdNo;
        private Label lblBirthday;
        private TextBox txtBirthday;
        private Label lblJobTitle;
        private TextBox txtJobTitle;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblHRNo;
        private TextBox txtHRNo;
        private Label lblCardNo;
        private TextBox txtCardNo;
        private Label lblAddress;
        private TextBox txtAddress;
    }
}
