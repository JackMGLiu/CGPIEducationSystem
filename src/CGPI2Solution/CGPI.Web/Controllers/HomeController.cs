using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CGPI.Web.Application;
using Microsoft.AspNetCore.Mvc;
using CGPI.Web.Models;
using QJ.Framework.Service.DTO;
using QJ.Framework.Service.DTO.RequestViewModels;
using QJ.Framework.Service.Interface;

namespace CGPI.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ISysUserService _sysUserService;
            
        public HomeController(ISysUserService sysUserService)
        {
            this._sysUserService = sysUserService;
        }

        #region login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("account/checklogin")]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountModel model)
        {
            //验证模型是否正确
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserLoginModel loginModel = null;

            var res = _sysUserService.Login(model.Account, model.Password, out loginModel);
            if (res)
            {
                //加密用户名写入cookie中，AdminAuthorizeAttribute特性标记取出cookie并解码除用户名
                var encryptValue = _sysUserService.LoginEncrypt(model.Account, ApplicationKeys.User_Cookie_EncryptionKey);
                //保存cookie
                HttpContext.Response.Cookies.Append(ApplicationKeys.User_Cookie_Key, encryptValue);

                return Success("登陆成功，正在跳转...", new { backurl = "/manager/demo/index" });
            }
            else
            {
                return Warning("登陆失败，请重试！");
            }
        }

        #endregion


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
