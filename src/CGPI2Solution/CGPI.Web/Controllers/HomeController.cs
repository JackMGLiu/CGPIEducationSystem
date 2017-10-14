using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CGPI.Web.Models;
using QJ.Framework.Service.DTO.RequestViewModels;

namespace CGPI.Web.Controllers
{
    public class HomeController : Controller
    {
        #region login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("account/checklogin")]
        public IActionResult Login(AccountModel model)
        {
            //验证模型是否正确
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
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
