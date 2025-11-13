using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    public class MenuController : ControllerBase
    {
        private static ILog _logger = LogManager.GetLogger(typeof(MenuController));
        public MenuController()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        [HttpGet]
        [Route("api/GetMenu")]
        public CommonRep<Menu> GetMenu(string account)
        {
            CommonRep<Menu> rep = new CommonRep<Menu>();
            try
            {
                AuthenticateMenu authenticateMenu = new AuthenticateMenu();
                List<Menu> menuList = authenticateMenu.GetMenuByAccount(account);
                rep.resultList = menuList;
            }
            catch (Exception ex)
            {
                _logger.Error(ex+ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                throw;
            }
            return rep;
        }
    }
}
