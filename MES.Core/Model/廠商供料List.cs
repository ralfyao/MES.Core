using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 廠商供料List : A材料
    {
        public 廠商供料List(A材料 parent)
        {
            this.產品編號 = parent?.產品編號;
            this.品別         = parent?.品別			  ;
            this.大分類       = parent?.大分類		  ;
            this.小分類       = parent?.小分類		  ;
            this.產品代號     = parent?.產品代號		  ;
            this.品名規格     = parent?.品名規格		  ;
            this.英文品名     = parent?.英文品名		  ;
            this.外尺寸長     = parent?.外尺寸長		  ;
            this.外尺寸寬     = parent?.外尺寸寬		  ;
            this.厚度         = parent?.厚度			  ;
            this.內徑         = parent?.內徑			  ;
            this.外徑 = parent?.外徑;
        }
        public 廠商供料List() { }
        public List<B廠商供料> materialList { get; set; }
    }
}
