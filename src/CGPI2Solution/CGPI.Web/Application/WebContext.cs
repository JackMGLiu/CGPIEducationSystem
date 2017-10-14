using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Interface;

namespace CGPI.Web.Application
{
    public static class ServiceLocator
    {
        public static IServiceProvider Instance { get; set; }
        public static T GetService<T>() where T : class => Instance.GetService<T>();
    }

    public static class WebContext
    {
        public static string LoginUserName
        {
            get
            {
                //获取cookie
                var hasCookie = ServiceLocator.GetService<IHttpContextAccessor>()
                    .HttpContext
                    .Request.Cookies
                    .TryGetValue(ApplicationKeys.User_Cookie_Key, out string encryptValue);
                if (!hasCookie || encryptValue.IsEmpty())
                {
                    return null;
                }
                var loginname = ServiceLocator.GetService<ISysUserService>().LoginDecrypt(encryptValue, ApplicationKeys.User_Cookie_EncryptionKey);
                return loginname;
            }
        }

        public const string LoginUrl = "/Home/Login";
    }
}
