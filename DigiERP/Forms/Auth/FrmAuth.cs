using DigiERP.Forms;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.UserControl.Auth
{
    public partial class FrmAuth : CommonForm
    {
        private AutheiticateController _controller;
        private HRController _hrController;
        public FrmAuth()
        {
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initGrid()
        {
            //CommonRep<H員工清冊> authRep = _hrController.AllWorkers();
            //if (!string.IsNullOrEmpty(authRep.ErrorMessage))
            //{
            //    MessageBox.Show(authRep.ErrorMessage);
            //    return;
            //}
            int index = 0;
            //dataGridView1.Rows.Clear();
            //CommonRep<account> allAccountsRep = _controller.();
            //if (!string.IsNullOrEmpty(allAccountsRep.ErrorMessage))
            //{
            //    MessageBox.Show(allAccountsRep.ErrorMessage);
            //    return;
            //}
            AuthenticateRepository repository = new AuthenticateRepository();
            List<account> accounts = (List<account>)repository.GetAccountList(null, "", "");
            //List<string> accounts = new List<string>();
            //allAccountsRep.resultList.ForEach(x =>
            //{
            //    accounts.Add(x.Account);
            //});
            foreach (var item in accounts)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.帳號;
                row.Cells[index++].Value = item.密碼;
                row.Cells[index++].Value = item.姓名;
                row.Cells[index++].Value = item.停用;
                row.Cells[index++].Value = item.寄件允許;
                //row.Cells[index++].Value = item.部門;
                //row.Cells[index++].Value = item.職能;
                //row.Cells[index++].Value = item.地址;
                //row.Cells[index++].Value = item.生日;
                //row.Cells[index++].Value = item.職稱;
                //row.Cells[index++].Value = item.狀況;
                //row.Cells[index++].Value = item.身分證號;
                //row.Cells[index++].Value = item.人事編號;
                //row.Cells[index++].Value = item.卡號;
                //((DataGridViewComboBoxCell)row.Cells[index]).DataSource = accounts;
                //row.Cells[index].Value = item.系統帳號;
                index++;
                dataGridView1.Rows.Add(row);
            }
        }

        private void initController()
        {
            if (_controller == null)
            {
                _controller = new AutheiticateController();
            }
            if (_hrController == null)
            {
                _hrController = new HRController();
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //取得使用者選到的值
            //string value =
            //dataGridView1.CurrentRow.Cells["系統帳號"].Value?.ToString();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // 假設你要將第 1 欄（索引為 0）設定為密碼輸入
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                // 將編輯控制項轉型為 TextBox
                TextBox passwordTextBox = e.Control as TextBox;

                if (passwordTextBox != null)
                {
                    // 啟用系統預設的密碼遮罩字元（如 ● 或 *）
                    passwordTextBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                // 其他非密碼欄位要記得還原設定，避免複用控制項時出錯
                TextBox regularTextBox = e.Control as TextBox;
                if (regularTextBox != null)
                {
                    regularTextBox.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
