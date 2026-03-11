using MES.Core.Model;
using MES.Core.Repository.Impl;

namespace MES.WebAPI.MiddleWare
{
    public class SupplierMiddle
    {
        public List<B廠商設定> getSupplierList()
        {
            List<B廠商設定> list = new List<B廠商設定> ();
            try
            {
                SupplierRepository supplierMiddle = new SupplierRepository();
                SupplierDetailRepository supplierDetailRepository = new Core.Repository.Impl.SupplierDetailRepository();
                list = supplierMiddle.GetList(null);
                // 詢價清單
                foreach(var  item in list)
                {
                    B廠商供料 aItem = new B廠商供料();
                    aItem.廠商編號 = item.廠商編號;
                    item.supplyList = supplierDetailRepository.GetListBy(aItem, "廠商編號");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

    }
}
