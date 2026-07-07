using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F會計傳票
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 單號 { get; set; }
        public string 日期 { get; set; }
        public string 原始憑證 { get; set; }
        public decimal 借方 { get; set; }
        public decimal 貸方 { get; set; }
        public string 狀態 { get; set; }
        public string 登錄人員 { get; set; }
        public string 修改 { get; set; }
        public string 修改日 { get; set; }
        public string 過帳 { get; set; }
        public string 過帳日 { get; set; }
        public string 月結 { get; set; }
        public List<F會計傳票明細> voucherList { get; set; }
    }
}
