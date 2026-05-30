using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.UserControl.Auth
{
    partial class FrmAuth
    {
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            tabPasswordPrivilegeControl = new TabControl();
            tabPasswordControl = new TabPage();
            tabPrivilegeControl = new TabPage();
            tabPasswordPrivilegeControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPasswordPrivilegeControl
            // 
            tabPasswordPrivilegeControl.Controls.Add(tabPasswordControl);
            tabPasswordPrivilegeControl.Controls.Add(tabPrivilegeControl);
            tabPasswordPrivilegeControl.Dock = DockStyle.Fill;
            tabPasswordPrivilegeControl.Font = new Font("Microsoft JhengHei UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPasswordPrivilegeControl.Location = new Point(0, 0);
            tabPasswordPrivilegeControl.Name = "tabPasswordPrivilegeControl";
            tabPasswordPrivilegeControl.SelectedIndex = 0;
            tabPasswordPrivilegeControl.Size = new Size(704, 593);
            tabPasswordPrivilegeControl.TabIndex = 0;
            // 
            // tabPasswordControl
            // 
            tabPasswordControl.Location = new Point(4, 33);
            tabPasswordControl.Name = "tabPasswordControl";
            tabPasswordControl.Padding = new Padding(3);
            tabPasswordControl.Size = new Size(696, 556);
            tabPasswordControl.TabIndex = 0;
            tabPasswordControl.Text = "密碼控制";
            tabPasswordControl.UseVisualStyleBackColor = true;
            // 
            // tabPrivilegeControl
            // 
            tabPrivilegeControl.Location = new Point(4, 33);
            tabPrivilegeControl.Name = "tabPrivilegeControl";
            tabPrivilegeControl.Padding = new Padding(3);
            tabPrivilegeControl.Size = new Size(696, 556);
            tabPrivilegeControl.TabIndex = 1;
            tabPrivilegeControl.Text = "權限控制";
            tabPrivilegeControl.UseVisualStyleBackColor = true;
            // 
            // FrmAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 593);
            Controls.Add(tabPasswordPrivilegeControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAuth";
            Text = "帳密權限管理";
            tabPasswordPrivilegeControl.ResumeLayout(false);
            ResumeLayout(false);
        }
        private TabControl tabPasswordPrivilegeControl;
        private TabPage tabPasswordControl;
        private TabPage tabPrivilegeControl;
    }
}
