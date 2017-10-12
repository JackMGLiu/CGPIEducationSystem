using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CGPI.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Interface;

namespace CGPI.Web.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class DemoController : BaseController
    {
        private readonly ISysUserService _sysUserService;

        public DemoController(ISysUserService sysUserService)
        {
            this._sysUserService = sysUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("default/main")]
        public IActionResult Main()
        {
            return View();
        }

        [HttpGet("demo/users")]
        public IActionResult Users()
        {
            return View();
        }

        [HttpPost("demo/addusers")]
        public IActionResult AddUsers(SysUser model)
        {
            if (model.Id == 0 || model.Id.IsEmpty())
            {
                //add
                var res = _sysUserService.AddUser(model);
                if (res)
                {
                    return Success();
                }
                else
                {
                    return Error();
                }
            }
            else
            {
                //edit
                return Json("true");
            }
        }

        [HttpGet("demo/count")]
        public IActionResult UserCount()
        {
            var res = _sysUserService.GetCount();
            return Content(res.ToString());
        }

        [HttpGet("demo/menus")]
        public IActionResult GetMenus()
        {
            List<MenuModel> menus = new List<MenuModel>
            {
                new MenuModel
                {
                    id = 1000,
                    title = "系统管理",
                    spread = true,
                    icon = "fa-gears",
                    children =
                    {
                        new MenuModel
                        {
                            id = 10001,
                            title = "用户管理",
                            icon = "fa-users",
                            url = "/demo/users"
                        },
                        new MenuModel
                        {
                            id = 10002,
                            title = "角色管理",
                            icon = "fa-user-secret",
                            url = "/demo/roles"
                        }
                    }
                },
                new MenuModel
                {
                    id = 2000,
                    title = "系统安全",
                    icon = "fa-windows",
                    spread = false
                }
            };

            return Json(menus);
        }
    }

    public class MenuModel
    {
        public MenuModel()
        {
            children = new List<MenuModel>();
        }

        public int id { get; set; }

        public string title { get; set; }

        public bool spread { get; set; }

        public string icon { get; set; }

        public string url { get; set; }

        public List<MenuModel> children { get; set; }
    }
}