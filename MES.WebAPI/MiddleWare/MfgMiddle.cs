
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class MfgMiddle
    {
        public string getMiscMfgNo()
        {
            string mfgNo = string.Empty;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                mfgNo = miscMfgRepository.GetMiscMfgNo();
            }
            catch (Exception)
            {

                throw;
            }
            return mfgNo;
        }

        public int createMiscMfgOrder(零件申請單 form)
        {
            int execCnt = 0;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                execCnt = miscMfgRepository.Insert(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        internal int updateSalesOrderMachineNo(零件申請單 form)
        {
            int execCnt = 0;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                execCnt = miscMfgRepository.updateSalesOrderMachineNo(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
    }
}
