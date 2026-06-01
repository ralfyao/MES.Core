using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.MiddleWare;
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
                account authenticate = new account();
                authenticate.帳號 = user.username;
                var result = repository.GetAccountList(authenticate, "", "");
                if (result.Count() > 0)
                {
                    foreach(var item in result)
                    {
                        if (((account)item).密碼 == user.password)
                        {
                            if ((bool)((account)item).停用)
                            {
                                rep.WorkStatus = WorkStatus.NG.ToString();
                                rep.ErrorMessage = "帳號已停用";
                                return rep;
                            }
                            else
                            {
                                rep.result = new User
                                {
                                    username = ((account)item).姓名,
                                    name = ((account)item).帳號,
                                    password = ((account)item).密碼,
                                    empNo = ((account)item).工號,
                                    isEmail = ((account)item).寄件允許,
                                    isActivate = ((account)item).停用,
                                    position = ((account)item).職能,
                                };
                                rep.WorkStatus = WorkStatus.OK.ToString();
                                rep.ErrorMessage = string.Empty;
                                return rep;
                            }
                        }
                        else
                        {
                            rep.WorkStatus = WorkStatus.NG.ToString();
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
        public CommonRep<account> GetUser(User user)
        {
            CommonRep<account> rep = new CommonRep<account>();
            rep.WorkStatus = WorkStatus.NG.ToString();
            rep.ErrorMessage = "無帳號資料";
            AccountRepository repository = new AccountRepository();
            try
            {
                account authenticate = new account();
                authenticate.帳號 = user.username;
                var result = repository.GetList(authenticate, "", "");
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
        [Route("api/UpdatePassword"), HttpGet]
        public CommonRep<string> UpdatePassword(string? account, string? password)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                int retCode = userMiddle.UpdatePassword(account, password);
                if (retCode  == 0)
                {
                    commonRep.ErrorMessage = "變更密碼失敗，請洽系統人員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                } 
                else
                {
                    commonRep.result = password;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得所有使用者帳號
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetAllUsers")]
        public CommonRep<account> GetAllUsers()
        {
            CommonRep<account> rep = new CommonRep<account>();
            try
            {
                List<account> userList = new AccountRepository().GetList(null, "", "");
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
        public CommonRep<account> addUser(User user)
        {
            CommonRep<account> rep = new Models.CommonRep<account>();
            try
            {
                account authenticate = user.ToAccount();
                AccountRepository authenticateRepository = new AccountRepository();
                int retCode = authenticateRepository.Insert(authenticate);
                if (retCode == 0)
                    rep.ErrorMessage = "寫入使用者資料有誤";
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
        public CommonRep<account> updateUser(User user)
        {
            CommonRep<account> rep = new Models.CommonRep<account>();
            try
            {
                account authenticate = user.ToAccount();
                AccountRepository authenticateRepository = new AccountRepository();
                int retCode = authenticateRepository.Insert(authenticate);
                if (retCode == 0)
                    rep.ErrorMessage = "寫入使用者資料有誤";
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
        /// 刪除使用者
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteUser")]
        public CommonRep<account> deleteUser(User user)
        {
            CommonRep<account> commonRep = new CommonRep<account>();
            try
            {
                account authenticate = user.ToAccount();
                AccountRepository authenticateRepository = new AccountRepository();
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
        [Route("api/GetMenuFuncByAccount")]
        public CommonRep<MenuSub> GetMenuFuncByAccount(string? account)
        {
            CommonRep<MenuSub> commonRep = new CommonRep<MenuSub>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                commonRep.resultList = userMiddle.GetMenuFuncByAccount(account);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/PositionList"), HttpGet]
        public CommonRep<string> PositionList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                commonRep.resultList = userMiddle.GetPositionList();
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateUserAuth"), HttpPost]
        public CommonRep<string> UpdateUserAuth([FromBody]List<MenuSub> menuSubs)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                int retCode = userMiddle.updateUserAuth(menuSubs);
                if (retCode == 0)
                {
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    commonRep.ErrorMessage = "更新使用者授權失敗，請洽系統人員";
                }
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
