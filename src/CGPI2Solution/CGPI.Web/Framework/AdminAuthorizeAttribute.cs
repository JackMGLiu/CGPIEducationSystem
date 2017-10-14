using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using CGPI.Web.Application;
using QJ.Framework.Infrastructure.Validate;

namespace CGPI.Web.Framework
{
    public class AdminAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {          
            if (WebContext.LoginUserName.IsEmpty())
            {
                if (filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    filterContext.Result = new JsonResult("未登录，请重新登陆！");
                }
                else
                {
                    filterContext.Result = new RedirectResult(WebContext.LoginUrl);
                }
                return;
            }
        }
    }
}
