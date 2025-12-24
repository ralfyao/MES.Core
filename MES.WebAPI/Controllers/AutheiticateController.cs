using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class AutheiticateController : ControllerBase
    {
        private static ILog _logger = LogManager.GetLogger(typeof(AutheiticateController));
        public AutheiticateController()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        /// <summary>
        /// 登入系統
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Login")]
        public CommonRep<User> Login(User user)
        {
            CommonRep<User> rep = new CommonRep<User>();
            rep.WorkStatus = WorkStatus.NG.ToString();
            rep.ErrorMessage = "無帳號資料";
            AuthenticateRepository repository = new AuthenticateRepository();
            try
            {
                Authenticate authenticate = new Authenticate();
                authenticate.Account = user.username;
                var result = repository.GetList(authenticate);
                if (result.Count > 0)
                {
                    foreach(var item in result)
                    {
                        if (item.Password == user.password)
                        {
                            rep.WorkStatus = WorkStatus.OK.ToString();
                            rep.ErrorMessage = string.Empty;
                            return rep;
                        }
                        else
                        {
                            rep.ErrorMessage = "密碼錯誤";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        /// <summary>
        /// 取得使用者帳號
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetUser")]
        public CommonRep<Authenticate> GetUser(User user)
        {
            CommonRep<Authenticate> rep = new CommonRep<Authenticate>();
            rep.WorkStatus = WorkStatus.NG.ToString();
            rep.ErrorMessage = "無帳號資料";
            AuthenticateRepository repository = new AuthenticateRepository();
            try
            {
                Authenticate authenticate = new Authenticate();
                authenticate.Account = user.username;
                var result = repository.GetList(authenticate);
                if (result.Count > 0)
                {
                    rep.WorkStatus = WorkStatus.OK.ToString();
                    rep.ErrorMessage = "";
                    rep.result = result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        /// <summary>
        /// 取得所有使用者帳號
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetAllUsers")]
        public CommonRep<Authenticate> GetAllUsers()
        {
            CommonRep<Authenticate> rep = new CommonRep<Authenticate>();
            try
            {
                List<Authenticate> userList = new AuthenticateRepository().GetList(null);
                rep.resultList = userList; 
            }
            catch (Exception ex)
            {
                _logger.Error (ex + ex.StackTrace);
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                //throw;
            }
            return rep;
        }
        /// <summary>
        /// 新增使用者
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/AddUser")]
        public CommonRep<Authenticate> addUser(User user)
        {
            CommonRep<Authenticate> rep = new Models.CommonRep<Authenticate>();
            try
            {
                Authenticate authenticate = user.ToAuthenticate();
                AuthenticateRepository authenticateRepository = new AuthenticateRepository();
                authenticateRepository.Insert(authenticate);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                //throw;
            }
            return rep;
        }
        /// <summary>
        /// 更新使用者
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateUser")]
        public CommonRep<Authenticate> updateUser(User user)
        {
            CommonRep<Authenticate> rep = new CommonRep<Authenticate>();
            try
            {
                Authenticate authenticate = user.ToAuthenticate();
                AuthenticateRepository authenticateRepository = new AuthenticateRepository();
                authenticateRepository.Update(authenticate);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        /// <summary>
        /// 刪除使用者
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteUser")]
        public CommonRep<Authenticate> deleteUser(User user)
        {
            CommonRep<Authenticate> commonRep = new CommonRep<Authenticate>();
            try
            {
                Authenticate authenticate = user.ToAuthenticate();
                AuthenticateRepository authenticateRepository = new AuthenticateRepository();
                authenticateRepository.Delete(authenticate);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }
}
