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
