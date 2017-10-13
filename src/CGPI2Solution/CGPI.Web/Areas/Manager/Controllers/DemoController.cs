using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CGPI.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.FormatModels;
using QJ.Framework.Infrastructure.Json;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.DTO.ViewModels;
using QJ.Framework.Service.Interface;

namespace CGPI.Web.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class DemoController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ISysUserService _sysUserService;
        private readonly ISysRoleService _sysRoleService;

        public DemoController(IMapper mapper, ISysUserService sysUserService, ISysRoleService sysRoleService)
        {
            this._mapper = mapper;
            this._sysUserService = sysUserService;
            this._sysRoleService = sysRoleService;
        }

        #region login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        #endregion


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("default/main")]
        public IActionResult Main()
        {
            return View();
        }

        #region demo user

        [HttpGet("demo/users")]
        public IActionResult Users()
        {
            return View();
        }

        [HttpPost("demo/getusers")]
        public IActionResult UserData(string keyword, int page, int limit)
        {
            var res = _sysUserService.GetPagedList(keyword, page, limit);
            var userdata = _mapper.Map<List<SysUserViewModel>>(res.Items);
            var json = new { code = 0, msg = "", count = res.TotalCount, data = userdata };
            return Content(json.ToJson());
        }

        [HttpPost("user/getaccount")]
        public IActionResult CheckAccount(string account)
        {
            var res = _sysUserService.GetUserByAccount(account);
            if (res)
            {
                return Error("已存在当前用户名，请重新输入");
            }
            return Success("恭喜您，该用户名可以注册");
        }

        [HttpPost("user/getmobile")]
        public IActionResult CheckMobile(string mobile)
        {
            var res = _sysUserService.GetUserByMobile(mobile);
            if (res)
            {
                return Error("当前手机号已经注册，请重新输入");
            }
            return Success("恭喜您，该手机号可以注册");
        }

        [HttpPost("demo/saveuser")]
        public IActionResult SaveData(SysUser model)
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
                var res = _sysUserService.EditUser(model);
                if (res)
                {
                    return Success();
                }
                else
                {
                    return Error();
                }
            }
        }

        #endregion

        #region demo role

        [HttpGet("demo/roles")]
        public IActionResult Roles()
        {
            return View();
        }

        [HttpPost("demo/getroles")]
        public IActionResult RoleData(string keyword, int page, int limit)
        {
            var res = _sysRoleService.GetPagedList(keyword, page, limit);
            var roledata = _mapper.Map<List<SysRoleViewModel>>(res.Items);
            var json = new { code = 0, msg = "", count = res.TotalCount, data = roledata };
            return Content(json.ToJson());
        }

        /// <summary>
        /// 获取角色数
        /// </summary>
        /// <returns></returns>
        [HttpPost("role/roletree")]
        public IActionResult GetRoleTreeSelect()
        {
            var rolelist = _sysRoleService.GetSysRoleList();
            var listTree = new List<TreeSelect>();
            foreach (var item in rolelist)
            {
                TreeSelect model = new TreeSelect();
                model.id = item.Id.ToString();
                model.text = item.RoleName;
                listTree.Add(model);
            }
            return Content(listTree.ToJson());
        }

        [HttpPost("demo/saverole")]
        public IActionResult SaveData(SysRole model)
        {
            if (model.Id == 0 || model.Id.IsEmpty())
            {
                //add
                var res = _sysRoleService.AddRole(model);
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
                var res = _sysRoleService.EditRole(model);
                if (res)
                {
                    return Success();
                }
                else
                {
                    return Error();
                }
            }
        }

        #endregion

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
                            icon = "fa-user",
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