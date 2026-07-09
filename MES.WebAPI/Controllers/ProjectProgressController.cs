using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ProjectProgressController : ControllerBase
    {
        [Route("api/GetProjectProgressList"), HttpGet]
        public CommonRep<專案進度表> GetProjectProgressList()
        {
            CommonRep<專案進度表> commonRep = new CommonRep<專案進度表>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getProjectProgressList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetWorkOrderByProjectNo"), HttpGet]
        public CommonRep<工令單> GetWorkOrderByProjectNo(string projectNo)
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.result = projectProgressMiddle.getWorkOrderByProjectNo(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetDesignAssignmentList"), HttpGet]
        public CommonRep<設計派案> GetDesignAssignmentList(string projectNo)
        {
            CommonRep<設計派案> commonRep = new CommonRep<設計派案>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getDesignAssignmentList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetPurchasePlanList"), HttpGet]
        public CommonRep<採購計畫> GetPurchasePlanList(string projectNo)
        {
            CommonRep<採購計畫> commonRep = new CommonRep<採購計畫>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getPurchasePlanList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetModuleMaterialList"), HttpGet]
        public CommonRep<專案模組用料清單> GetModuleMaterialList(string projectNo)
        {
            CommonRep<專案模組用料清單> commonRep = new CommonRep<專案模組用料清單>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getModuleMaterialList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetElectricScheduleList"), HttpGet]
        public CommonRep<專案電控排程> GetElectricScheduleList(string projectNo)
        {
            CommonRep<專案電控排程> commonRep = new CommonRep<專案電控排程>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getElectricScheduleList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetModuleDesignProgressList"), HttpGet]
        public CommonRep<模組設計進度表> GetModuleDesignProgressList(string projectNo = null)
        {
            CommonRep<模組設計進度表> commonRep = new CommonRep<模組設計進度表>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getModuleDesignProgressList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetModuleProcurementProgressList"), HttpGet]
        public CommonRep<模組零件採購進度表> GetModuleProcurementProgressList(string projectNo)
        {
            CommonRep<模組零件採購進度表> commonRep = new CommonRep<模組零件採購進度表>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getModuleProcurementProgressList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetModuleAssemTestProgressList"), HttpGet]
        public CommonRep<模組組測進度表> GetModuleAssemTestProgressList(string projectNo)
        {
            CommonRep<模組組測進度表> commonRep = new CommonRep<模組組測進度表>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getModuleAssemTestProgressList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetElecControlProgressList"), HttpGet]
        public CommonRep<電控排程進度表> GetElecControlProgressList(string projectNo)
        {
            CommonRep<電控排程進度表> commonRep = new CommonRep<電控排程進度表>();
            ProjectProgressMiddle projectProgressMiddle = new ProjectProgressMiddle();
            try
            {
                commonRep.resultList = projectProgressMiddle.getElecControlProgressList(projectNo);
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
