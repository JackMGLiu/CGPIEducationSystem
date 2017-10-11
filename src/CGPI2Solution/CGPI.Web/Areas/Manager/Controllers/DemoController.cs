using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CGPI.Web.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class DemoController : Controller
    {
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