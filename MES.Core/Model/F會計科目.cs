using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F會計科目
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 會科代碼 { get; set; }
        public string 會科名稱 { get; set; }
        public string 說明 { get; set; }
        public string 借貸 { get; set; }
        public string 統科代碼 { get; set; }
        public decimal 期初餘額 { get; set; }
        public string 建檔日期 { get; set; }
        public string 修改日期 { get; set; }
        public bool 停用 { get; set; }
        public List<F會計科目明細> accountingDetail { get; set; }
    }
}
