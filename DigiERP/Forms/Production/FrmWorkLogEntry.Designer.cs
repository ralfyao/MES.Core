using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmWorkLogEntry
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
            panelMain = new Panel();
            lblWorkDateCaption = new Label();
            txtWorkDate = new TextBox();
            lblWorkerNoCaption = new Label();
            txtWorkerNo = new TextBox();
            lblNameCaption = new Label();
            txtName = new TextBox();
            lblProjectNoCaption = new Label();
            txtProjectNo = new TextBox();
            lblPositionCaption = new Label();
            txtPosition = new TextBox();
            lblProgressCaption = new Label();
            txtProgress = new TextBox();
            lblModuleCodeCaption = new Label();
            txtModuleCode = new TextBox();
            lblModuleNameCaption = new Label();
            txtModuleName = new TextBox();
            lblActualStartCaption = new Label();
            txtActualStart = new TextBox();
            lblPlannedFinishCaption = new Label();
            txtPlannedFinish = new TextBox();
            lblEstHoursCaption = new Label();
            txtEstHours = new TextBox();
            lblTaskCategoryCaption = new Label();
            cboTaskCategory = new ComboBox();
            lblScoreCaption = new Label();
            txtScore = new TextBox();
            lblWorkItemCaption = new Label();
            txtWorkItem = new TextBox();
            lblTodayHoursCaption = new Label();
            txtTodayHours = new TextBox();
            lblAssemblyPartCaption = new Label();
            txtAssemblyPart = new TextBox();
            lblSummaryCaption = new Label();
            txtSummary = new TextBox();
            lblRemarkCaption = new Label();
            txtRemark = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            //
            // panelMain
            //
            panelMain.BackColor = Color.LightYellow;
            panelMain.Controls.Add(lblWorkDateCaption);
            panelMain.Controls.Add(txtWorkDate);
            panelMain.Controls.Add(lblWorkerNoCaption);
            panelMain.Controls.Add(txtWorkerNo);
            panelMain.Controls.Add(lblNameCaption);
            panelMain.Controls.Add(txtName);
            panelMain.Controls.Add(lblProjectNoCaption);
            panelMain.Controls.Add(txtProjectNo);
            panelMain.Controls.Add(lblPositionCaption);
            panelMain.Controls.Add(txtPosition);
            panelMain.Controls.Add(lblProgressCaption);
            panelMain.Controls.Add(txtProgress);
            panelMain.Controls.Add(lblModuleCodeCaption);
            panelMain.Controls.Add(txtModuleCode);
            panelMain.Controls.Add(lblModuleNameCaption);
            panelMain.Controls.Add(txtModuleName);
            panelMain.Controls.Add(lblActualStartCaption);
            panelMain.Controls.Add(txtActualStart);
            panelMain.Controls.Add(lblPlannedFinishCaption);
            panelMain.Controls.Add(txtPlannedFinish);
            panelMain.Controls.Add(lblEstHoursCaption);
            panelMain.Controls.Add(txtEstHours);
            panelMain.Controls.Add(lblTaskCategoryCaption);
            panelMain.Controls.Add(cboTaskCategory);
            panelMain.Controls.Add(lblScoreCaption);
            panelMain.Controls.Add(txtScore);
            panelMain.Controls.Add(lblWorkItemCaption);
            panelMain.Controls.Add(txtWorkItem);
            panelMain.Controls.Add(lblTodayHoursCaption);
            panelMain.Controls.Add(txtTodayHours);
            panelMain.Controls.Add(lblAssemblyPartCaption);
            panelMain.Controls.Add(txtAssemblyPart);
            panelMain.Controls.Add(lblSummaryCaption);
            panelMain.Controls.Add(txtSummary);
            panelMain.Controls.Add(lblRemarkCaption);
            panelMain.Controls.Add(txtRemark);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(btnCancel);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(760, 620);
            panelMain.TabIndex = 0;
            //
            // lblWorkDateCaption
            //
            lblWorkDateCaption.AutoSize = true;
            lblWorkDateCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblWorkDateCaption.Location = new Point(20, 20);
            lblWorkDateCaption.Name = "lblWorkDateCaption";
            lblWorkDateCaption.Size = new Size(70, 20);
            lblWorkDateCaption.TabIndex = 0;
            lblWorkDateCaption.Text = "工作日期";
            //
            // txtWorkDate
            //
            txtWorkDate.Location = new Point(110, 17);
            txtWorkDate.Name = "txtWorkDate";
            txtWorkDate.ReadOnly = true;
            txtWorkDate.Size = new Size(140, 26);
            txtWorkDate.TabIndex = 1;
            //
            // lblWorkerNoCaption
            //
            lblWorkerNoCaption.AutoSize = true;
            lblWorkerNoCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblWorkerNoCaption.Location = new Point(270, 20);
            lblWorkerNoCaption.Name = "lblWorkerNoCaption";
            lblWorkerNoCaption.Size = new Size(40, 20);
            lblWorkerNoCaption.TabIndex = 2;
            lblWorkerNoCaption.Text = "工號";
            //
            // txtWorkerNo
            //
            txtWorkerNo.Location = new Point(320, 17);
            txtWorkerNo.Name = "txtWorkerNo";
            txtWorkerNo.ReadOnly = true;
            txtWorkerNo.Size = new Size(80, 26);
            txtWorkerNo.TabIndex = 3;
            //
            // lblNameCaption
            //
            lblNameCaption.AutoSize = true;
            lblNameCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblNameCaption.Location = new Point(420, 20);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(40, 20);
            lblNameCaption.TabIndex = 4;
            lblNameCaption.Text = "姓名";
            //
            // txtName
            //
            txtName.Location = new Point(470, 17);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(160, 26);
            txtName.TabIndex = 5;
            //
            // lblProjectNoCaption
            //
            lblProjectNoCaption.AutoSize = true;
            lblProjectNoCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblProjectNoCaption.Location = new Point(20, 60);
            lblProjectNoCaption.Name = "lblProjectNoCaption";
            lblProjectNoCaption.Size = new Size(70, 20);
            lblProjectNoCaption.TabIndex = 6;
            lblProjectNoCaption.Text = "專案序號";
            //
            // txtProjectNo
            //
            txtProjectNo.Location = new Point(110, 57);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.ReadOnly = true;
            txtProjectNo.Size = new Size(140, 26);
            txtProjectNo.TabIndex = 7;
            //
            // lblPositionCaption
            //
            lblPositionCaption.AutoSize = true;
            lblPositionCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblPositionCaption.Location = new Point(270, 60);
            lblPositionCaption.Name = "lblPositionCaption";
            lblPositionCaption.Size = new Size(40, 20);
            lblPositionCaption.TabIndex = 8;
            lblPositionCaption.Text = "職務";
            //
            // txtPosition
            //
            txtPosition.Location = new Point(320, 57);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(80, 26);
            txtPosition.TabIndex = 9;
            //
            // lblProgressCaption
            //
            lblProgressCaption.AutoSize = true;
            lblProgressCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblProgressCaption.Location = new Point(420, 60);
            lblProgressCaption.Name = "lblProgressCaption";
            lblProgressCaption.Size = new Size(70, 20);
            lblProgressCaption.TabIndex = 10;
            lblProgressCaption.Text = "專案進度";
            //
            // txtProgress
            //
            txtProgress.Location = new Point(500, 57);
            txtProgress.Name = "txtProgress";
            txtProgress.Size = new Size(130, 26);
            txtProgress.TabIndex = 11;
            //
            // lblModuleCodeCaption
            //
            lblModuleCodeCaption.AutoSize = true;
            lblModuleCodeCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblModuleCodeCaption.Location = new Point(20, 100);
            lblModuleCodeCaption.Name = "lblModuleCodeCaption";
            lblModuleCodeCaption.Size = new Size(70, 20);
            lblModuleCodeCaption.TabIndex = 12;
            lblModuleCodeCaption.Text = "模組編碼";
            //
            // txtModuleCode
            //
            txtModuleCode.Location = new Point(110, 97);
            txtModuleCode.Name = "txtModuleCode";
            txtModuleCode.ReadOnly = true;
            txtModuleCode.Size = new Size(140, 26);
            txtModuleCode.TabIndex = 13;
            //
            // lblModuleNameCaption
            //
            lblModuleNameCaption.AutoSize = true;
            lblModuleNameCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblModuleNameCaption.Location = new Point(270, 100);
            lblModuleNameCaption.Name = "lblModuleNameCaption";
            lblModuleNameCaption.Size = new Size(70, 20);
            lblModuleNameCaption.TabIndex = 14;
            lblModuleNameCaption.Text = "模組名稱";
            //
            // txtModuleName
            //
            txtModuleName.Location = new Point(350, 97);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.ReadOnly = true;
            txtModuleName.Size = new Size(280, 26);
            txtModuleName.TabIndex = 15;
            //
            // lblActualStartCaption
            //
            lblActualStartCaption.AutoSize = true;
            lblActualStartCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblActualStartCaption.Location = new Point(20, 140);
            lblActualStartCaption.Name = "lblActualStartCaption";
            lblActualStartCaption.Size = new Size(70, 20);
            lblActualStartCaption.TabIndex = 16;
            lblActualStartCaption.Text = "實際開工日";
            //
            // txtActualStart
            //
            txtActualStart.Location = new Point(110, 137);
            txtActualStart.Name = "txtActualStart";
            txtActualStart.ReadOnly = true;
            txtActualStart.Size = new Size(140, 26);
            txtActualStart.TabIndex = 17;
            //
            // lblPlannedFinishCaption
            //
            lblPlannedFinishCaption.AutoSize = true;
            lblPlannedFinishCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblPlannedFinishCaption.Location = new Point(270, 140);
            lblPlannedFinishCaption.Name = "lblPlannedFinishCaption";
            lblPlannedFinishCaption.Size = new Size(70, 20);
            lblPlannedFinishCaption.TabIndex = 18;
            lblPlannedFinishCaption.Text = "預計完工日";
            //
            // txtPlannedFinish
            //
            txtPlannedFinish.Location = new Point(350, 137);
            txtPlannedFinish.Name = "txtPlannedFinish";
            txtPlannedFinish.ReadOnly = true;
            txtPlannedFinish.Size = new Size(140, 26);
            txtPlannedFinish.TabIndex = 19;
            //
            // lblEstHoursCaption
            //
            lblEstHoursCaption.AutoSize = true;
            lblEstHoursCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblEstHoursCaption.Location = new Point(500, 140);
            lblEstHoursCaption.Name = "lblEstHoursCaption";
            lblEstHoursCaption.Size = new Size(80, 20);
            lblEstHoursCaption.TabIndex = 20;
            lblEstHoursCaption.Text = "預估總工時";
            //
            // txtEstHours
            //
            txtEstHours.Location = new Point(586, 137);
            txtEstHours.Name = "txtEstHours";
            txtEstHours.ReadOnly = true;
            txtEstHours.Size = new Size(100, 26);
            txtEstHours.TabIndex = 21;
            //
            // lblTaskCategoryCaption
            //
            lblTaskCategoryCaption.AutoSize = true;
            lblTaskCategoryCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTaskCategoryCaption.Location = new Point(20, 180);
            lblTaskCategoryCaption.Name = "lblTaskCategoryCaption";
            lblTaskCategoryCaption.Size = new Size(70, 20);
            lblTaskCategoryCaption.TabIndex = 22;
            lblTaskCategoryCaption.Text = "任務分類";
            //
            // cboTaskCategory
            //
            cboTaskCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaskCategory.Location = new Point(110, 177);
            cboTaskCategory.Name = "cboTaskCategory";
            cboTaskCategory.Size = new Size(280, 28);
            cboTaskCategory.TabIndex = 23;
            cboTaskCategory.SelectedIndexChanged += cboTaskCategory_SelectedIndexChanged;
            //
            // lblScoreCaption
            //
            lblScoreCaption.AutoSize = true;
            lblScoreCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblScoreCaption.Location = new Point(420, 180);
            lblScoreCaption.Name = "lblScoreCaption";
            lblScoreCaption.Size = new Size(70, 20);
            lblScoreCaption.TabIndex = 24;
            lblScoreCaption.Text = "成效點數";
            //
            // txtScore
            //
            txtScore.Location = new Point(500, 177);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(130, 26);
            txtScore.TabIndex = 25;
            //
            // lblWorkItemCaption
            //
            lblWorkItemCaption.AutoSize = true;
            lblWorkItemCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblWorkItemCaption.Location = new Point(20, 220);
            lblWorkItemCaption.Name = "lblWorkItemCaption";
            lblWorkItemCaption.Size = new Size(70, 20);
            lblWorkItemCaption.TabIndex = 26;
            lblWorkItemCaption.Text = "工作項目";
            //
            // txtWorkItem
            //
            txtWorkItem.Location = new Point(110, 217);
            txtWorkItem.Name = "txtWorkItem";
            txtWorkItem.Size = new Size(400, 26);
            txtWorkItem.TabIndex = 27;
            //
            // lblTodayHoursCaption
            //
            lblTodayHoursCaption.AutoSize = true;
            lblTodayHoursCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTodayHoursCaption.Location = new Point(520, 220);
            lblTodayHoursCaption.Name = "lblTodayHoursCaption";
            lblTodayHoursCaption.Size = new Size(70, 20);
            lblTodayHoursCaption.TabIndex = 28;
            lblTodayHoursCaption.Text = "本日工時";
            //
            // txtTodayHours
            //
            txtTodayHours.Location = new Point(600, 217);
            txtTodayHours.Name = "txtTodayHours";
            txtTodayHours.Size = new Size(110, 26);
            txtTodayHours.TabIndex = 29;
            //
            // lblAssemblyPartCaption
            //
            lblAssemblyPartCaption.AutoSize = true;
            lblAssemblyPartCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblAssemblyPartCaption.Location = new Point(20, 260);
            lblAssemblyPartCaption.Name = "lblAssemblyPartCaption";
            lblAssemblyPartCaption.Size = new Size(70, 20);
            lblAssemblyPartCaption.TabIndex = 30;
            lblAssemblyPartCaption.Text = "組裝零件";
            //
            // txtAssemblyPart
            //
            txtAssemblyPart.Location = new Point(110, 257);
            txtAssemblyPart.Name = "txtAssemblyPart";
            txtAssemblyPart.Size = new Size(600, 26);
            txtAssemblyPart.TabIndex = 31;
            //
            // lblSummaryCaption
            //
            lblSummaryCaption.AutoSize = true;
            lblSummaryCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSummaryCaption.Location = new Point(20, 300);
            lblSummaryCaption.Name = "lblSummaryCaption";
            lblSummaryCaption.Size = new Size(40, 20);
            lblSummaryCaption.TabIndex = 32;
            lblSummaryCaption.Text = "簡述";
            //
            // txtSummary
            //
            txtSummary.Location = new Point(110, 300);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(600, 90);
            txtSummary.TabIndex = 33;
            //
            // lblRemarkCaption
            //
            lblRemarkCaption.AutoSize = true;
            lblRemarkCaption.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblRemarkCaption.Location = new Point(20, 405);
            lblRemarkCaption.Name = "lblRemarkCaption";
            lblRemarkCaption.Size = new Size(70, 20);
            lblRemarkCaption.TabIndex = 34;
            lblRemarkCaption.Text = "特別註記";
            //
            // txtRemark
            //
            txtRemark.Location = new Point(110, 405);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.ScrollBars = ScrollBars.Vertical;
            txtRemark.Size = new Size(600, 70);
            txtRemark.TabIndex = 35;
            //
            // btnSave
            //
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(280, 540);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 36;
            btnSave.Text = "儲存紀錄";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.LightSteelBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(430, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "放棄離開";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // FrmWorkLogEntry
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 620);
            Controls.Add(panelMain);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(600, 500);
            Name = "FrmWorkLogEntry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "W-工作內容撰寫";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblWorkDateCaption;
        private TextBox txtWorkDate;
        private Label lblWorkerNoCaption;
        private TextBox txtWorkerNo;
        private Label lblNameCaption;
        private TextBox txtName;
        private Label lblProjectNoCaption;
        private TextBox txtProjectNo;
        private Label lblPositionCaption;
        private TextBox txtPosition;
        private Label lblProgressCaption;
        private TextBox txtProgress;
        private Label lblModuleCodeCaption;
        private TextBox txtModuleCode;
        private Label lblModuleNameCaption;
        private TextBox txtModuleName;
        private Label lblActualStartCaption;
        private TextBox txtActualStart;
        private Label lblPlannedFinishCaption;
        private TextBox txtPlannedFinish;
        private Label lblEstHoursCaption;
        private TextBox txtEstHours;
        private Label lblTaskCategoryCaption;
        private ComboBox cboTaskCategory;
        private Label lblScoreCaption;
        private TextBox txtScore;
        private Label lblWorkItemCaption;
        private TextBox txtWorkItem;
        private Label lblTodayHoursCaption;
        private TextBox txtTodayHours;
        private Label lblAssemblyPartCaption;
        private TextBox txtAssemblyPart;
        private Label lblSummaryCaption;
        private TextBox txtSummary;
        private Label lblRemarkCaption;
        private TextBox txtRemark;
        private Button btnSave;
        private Button btnCancel;
    }
}
