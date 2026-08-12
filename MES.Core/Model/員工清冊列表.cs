using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 員工清冊總覽扁平化 DTO：H員工基本資料 RIGHT JOIN H員工清冊 ON 工號 ──────
    public class 員工清冊列表
    {
        public string 工號 { get; set; }
        public string 姓名 { get; set; }
        public string 部門 { get; set; }
        public string 人事編號 { get; set; }
        public string 卡號 { get; set; }
        public string 生日 { get; set; }
        public int? 職等 { get; set; }
        public int? 職級 { get; set; }
        public string 核薪日 { get; set; }
        public string 離職日 { get; set; }
        public string 狀況 { get; set; }
    }
}
