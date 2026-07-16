using MES.Core.Model;
using MES.Core.Repository.Impl;
using System.Collections.Generic;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    public class VoucherMiddle
    {
        public string getFormNo()
        {
            var repo = new VoucherRepository();
            return repo.getFormNo();
        }

        public int createVoucher(F會計傳票 form)
        {
            var repo = new VoucherRepository();
            return repo.Insert(form);
        }

        public F會計傳票 getVoucherByNo(string no)
        {
            var repo = new VoucherRepository();
            return repo.GetByNo(no);
        }

        // ── 會計科目選擇：僅列出未停用的科目 ──────────────────────────────
        public List<F會計科目> getAccountingSubjectList()
        {
            var repo = new CommonRepository<F會計科目>();
            return repo.GetList((F會計科目)null).Where(x => !x.停用).ToList();
        }
    }
}
