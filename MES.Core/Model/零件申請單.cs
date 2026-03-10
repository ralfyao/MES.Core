using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 零件申請單
    {
        public 零件申請單()
        {

        }
        public 零件申請單(維修服務單 form)
        {
            this.客戶編號 = form.客戶簡稱;
            this.專案序號 = form.專案序號;
            this.機台型號 = form.機台型號;
            this.機台類型 = form.機台類型;
            this.機台名稱 = form.機台名稱;
        }
        [Key]
        public string 單號 { get; set; }
        public string 申請日期 { get; set; }
        public string 申請人 { get; set; }
        public string 客戶簡稱 { get; set; }
        public string 專案序號 { get; set; }
        public string 機台型號 { get; set; }
        public string 機台類型 { get; set; }
        public string 機台名稱 { get; set; }
        public string 交貨日期 { get; set; }
        public string 保固效期 { get; set; }
        public string 收費機制 { get; set; }
        public string 運送方式 { get; set; }
        public string 建檔 { get; set; }
        public string 修改 { get; set; }
        public string 核准 { get; set; }
        public string 建檔日 { get; set; }
        public string 修改日 { get; set; }
        public string 核准日 { get; set; }
        public string 主旨 { get; set; }
        public string 申請用途 { get; set; }
        public string 客戶編號 { get; set; }
    }
}
