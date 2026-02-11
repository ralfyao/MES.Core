using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using MES.WebAPI.Request;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
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
        [Route("api/GetUserPrivileges"), HttpGet]
        public CommonRep<Privilege> GetUserPrivilege(string account) 
        {
            CommonRep<Privilege> commonRep = new CommonRep<Privilege>();
            try
            {
                PrivilegeRepository privilegeRepository = new PrivilegeRepository();
                AuthenticateRepository authenticateRepository = new AuthenticateRepository();
                AuthenticatePrivilegeRepository authenticatePrivilegeRepository = new AuthenticatePrivilegeRepository();
                Authenticate authenticate = new Authenticate();
                authenticate.Account = account;
                authenticate = authenticateRepository.GetListBy(authenticate, "Account").ToList().FirstOrDefault();
                if (authenticate != null)
                {
                    var authenticatePrivileges = authenticatePrivilegeRepository.GetListBy(new AuthenticatePrivilege() { AuthenticatePrivilegeName = new Guid(authenticate.Privilege) }, "AuthenticatePrivilegeName");
                    foreach (var item in authenticatePrivileges)
                    {
                        var privilegeList = privilegeRepository.GetListBy(new Privilege() { PrivilegeName=item.PrivilegeNameMapped.ToString() }, "PrivilegeName").ToList();
                        commonRep.resultList.AddRange(privilegeList);
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/SaveRolePrivilege"), HttpPost]
        public CommonRep<string> SaveRole([FromBody]UserRoleRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                
                PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
                if (privilegeMiddle.checkRoleName(request.roleName))
                {
                    commonRep.ErrorMessage = $"{request.roleName}角色已經存在!";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    return commonRep;
                }
                // create privilege
                privilegeMiddle.createNewPrivilege(request);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/GetPrivMenuByRole"), HttpGet]
        public CommonRep<PrivilegeMenu> GetPrivMenuByRole(string roleName)
        {
            CommonRep<PrivilegeMenu> commonRep = new CommonRep<PrivilegeMenu>();
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            try
            {
                List<Privilege> privileges = privilegeRepository.GetListBy(new Privilege() { PrivilegeDesc = roleName }, "PrivilegeDesc", " DISTINCT PrivilegeName ");
                foreach (var item in privileges)
                {
                    List<PrivilegeMenu> privMenus = privilegeMenuRepository.GetListBy(new PrivilegeMenu() { PrivilegeName = item.PrivilegeName }, "PrivilegeName", " DISTINCT MenuID, MenuSubID");
                    commonRep.resultList.AddRange(privMenus);
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/UpdateUserPrivileges"), HttpPost]
        public CommonRep<Privilege> UpdateUserPrivileges(UpdateUserPrivilegesReq request)
        {
            CommonRep<Privilege> commonRep = new CommonRep<Privilege>();
            PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
            try
            {
                privilegeMiddle.updateUserPrivileges(request);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
    }
}
