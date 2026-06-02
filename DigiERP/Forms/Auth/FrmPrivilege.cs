using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Auth
{
    public partial class FrmPrivilege : Form
    {
        public account account;
        private MenuController _menuController;
        private UserPrivilegeController _userPrivilegeController;
        private HRController _hrController;
        private void initController()
        {
            if (_menuController == null)
            {
                _menuController = new MenuController();
            }
            if (_userPrivilegeController == null)
            {
                _userPrivilegeController = new UserPrivilegeController();
            }
            if (_hrController == null)
            {
                _hrController = new HRController();
            }
        }
        public FrmPrivilege()
        {
            InitializeComponent();
            initGridView();
        }

        private void initGridView()
        {
            initController();
            dataGridView1.Rows.Clear();
            //throw new NotImplementedException();
            CommonRep<模組選單> commonRep = _menuController.GetModuleList();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            int index = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in commonRep.resultList)
            {
                foreach (var subItem in item.subModuleList)
                {
                    index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.ID;
                    row.Cells[index++].Value = subItem.ID;
                    row.Cells[index++].Value = item.模組名稱;
                    row.Cells[index++].Value = subItem.子選單名稱;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        internal void GetUserPrivilegeData()
        {
            initController();
            initGridView();
            if (!string.IsNullOrEmpty(account.帳號))
            {
                commonTextBox1.Text = account.帳號;
                commonTextBox2.Text = account.姓名;
                CommonRep<H員工清冊> hrRep = _hrController.GetWorkerByNumber(account.帳號);
                if (!string.IsNullOrEmpty (hrRep.ErrorMessage))
                {
                    MessageBox.Show(hrRep.ErrorMessage);
                    return;
                }
                commonTextBox3.Text = hrRep.result.職能;
                CommonRep<A使用者授權> commonRep = _userPrivilegeController.GetUserPrivilegeByAccount(account.帳號);
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                    return;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string menuID = row.Cells[1].Value?.ToString();
                    var privilegeList = (from c in commonRep.resultList where c.授權子表單 == Guid.Parse(menuID) select c).ToList();
                    if (privilegeList.Count() > 0)
                    {
                        var privilege = privilegeList[0];
                        int index = 4;
                        row.Cells[index++].Value = privilege.高管;
                        row.Cells[index++].Value = privilege.核准;
                        row.Cells[index++].Value = privilege.編修;
                        row.Cells[index++].Value = privilege.報表;
                        row.Cells[index++].Value = privilege.輸出;
                        row.Cells[index++].Value = privilege.查詢;
                        row.Cells[index++].Value = privilege.註記;
                        row.Cells[index++].Value = privilege.職務代理效期;
                        row.Cells[index++].Value = privilege.機號;
                    }
                }
            }

            //throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<A使用者授權> saveList = new List<A使用者授權>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                A使用者授權 a = new A使用者授權();
                a.員工編號 = commonTextBox1.Text;
                a.員工姓名 = commonTextBox2.Text;
                a.職務 = commonTextBox3.Text;
                a.授權表單 = Guid.Parse((row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : Guid.NewGuid().ToString()));
                a.授權子表單 = Guid.Parse((row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : Guid.NewGuid().ToString()));
                int index = 4;
                a.高管 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.核准 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.編修 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.報表 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.輸出 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.查詢 = row.Cells[index].Value != null ? bool.Parse(row.Cells[index].Value.ToString()) : false; index++;
                a.註記 = row.Cells[index].Value != null ? row.Cells[index].Value.ToString() : ""; index++;
                a.職務代理效期 = row.Cells[index].Value != null ? row.Cells[index].Value.ToString() : ""; index++;
                a.機號 = row.Cells[index].Value != null ? row.Cells[index].Value.ToString() : ""; 
                saveList.Add(a);
            }
            initController();
            CommonRep<int> saveRep = _userPrivilegeController.SaveUserPrivilege(saveList);
            if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
            {
                MessageBox.Show(saveRep.ErrorMessage);
                return;
            }
            MessageBox.Show($"儲存{saveRep.result}筆資料成功");
            Dispose();
            Close();
        }
    }
}
