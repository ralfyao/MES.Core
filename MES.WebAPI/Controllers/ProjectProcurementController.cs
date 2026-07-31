using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ProjectProcurementController : ControllerBase
    {
        [Route("api/GetProjectProcurementList"), HttpGet]
        public CommonRep<採購計畫> GetProjectProcurementList()
        {
            CommonRep<採購計畫> commonRep = new CommonRep<採購計畫>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.resultList = projectProcurementMiddle.getProjectProcurementList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMiscControlReportList"), HttpGet]
        public CommonRep<採購計畫> GetMiscControlReportList()
        {
            CommonRep<採購計畫> commonRep = new CommonRep<採購計畫>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.resultList = projectProcurementMiddle.getMiscControlReportList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMiscControlOrderByNo"), HttpGet]
        public CommonRep<採購計畫> GetMiscControlOrderByNo(string controlNo)
        {
            CommonRep<採購計畫> commonRep = new CommonRep<採購計畫>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.result = projectProcurementMiddle.getMiscControlOrderByNo(controlNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetProductionUnitList"), HttpGet]
        public CommonRep<產製單位> GetProductionUnitList()
        {
            CommonRep<產製單位> commonRep = new CommonRep<產製單位>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.resultList = projectProcurementMiddle.getProductionUnitList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMiscControlInspectionList"), HttpGet]
        public CommonRep<採購零件檢驗履歷> GetMiscControlInspectionList(string controlNo)
        {
            CommonRep<採購零件檢驗履歷> commonRep = new CommonRep<採購零件檢驗履歷>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.resultList = projectProcurementMiddle.getMiscControlInspectionList(controlNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateMiscControlOrder"), HttpPost]
        public CommonRep<int> UpdateMiscControlOrder([FromBody] 採購計畫 form)
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.result = projectProcurementMiddle.updateMiscControlOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateMiscControlInspectionList"), HttpPost]
        public CommonRep<int> UpdateMiscControlInspectionList([FromBody] List<採購零件檢驗履歷> list)
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.result = projectProcurementMiddle.updateMiscControlInspectionList(list);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ValidateMiscControlOrder"), HttpGet]
        public CommonRep<int> ValidateMiscControlOrder(string controlNo, bool approve, string account)
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                commonRep.result = projectProcurementMiddle.validateMiscControlOrder(controlNo, approve, account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateProjectProcurement"), HttpPost]
        public CommonRep<string> UpdateProjectProcurement([FromBody] 採購計畫 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProjectProcurementMiddle projectProcurementMiddle = new ProjectProcurementMiddle();
            try
            {
                int execCnt = projectProcurementMiddle.updateProjectProcurement(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "修改失敗，請洽系統人員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }
}
