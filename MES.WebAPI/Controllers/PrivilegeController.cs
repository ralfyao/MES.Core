using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    public class PrivilegeController : ControllerBase
    {
        private ILog logger = LogManager.GetLogger(typeof(PrivilegeController));
        public PrivilegeController() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        [Route("api/GetAllPrivilege"), HttpGet]
        public CommonRep<List<Privilege>> GetAlllPrivilege()
        {
            CommonRep<List<Privilege>> rep = new CommonRep<List<Privilege>>();
            try
            {
                PrivilegeRepository privilegeRepository = new PrivilegeRepository();
                rep.result = privilegeRepository.GetList(null);
            }
            catch (Exception ex)
            {
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(rep.ErrorMessage);
            }
            return rep;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
