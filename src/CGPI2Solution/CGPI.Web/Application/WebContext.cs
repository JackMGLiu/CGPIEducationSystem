using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using QJ.Framework.Infrastructure.Security;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Impl;
using QJ.Framework.Service.Interface;

namespace CGPI.Web.Application
{
    public static class ServiceLocator
    {
        public static IServiceProvider Instance { get; set; }
        public static T GetService<T>() where T : class => Instance.GetService<T>();
    }

    public interface IUserService
    {

        /// <summary>
        /// 登录时使用的加密方法
        /// </summary>
        /// <param name="encryptString"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        string LoginEncrypt(string encryptString, string encryptKey);

        /// <summary>
        /// 登录时使用的解密方法
        /// </summary>
        /// <param name="decryptString"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        string LoginDecrypt(string decryptString, string encryptKey);
    }

    public class UserService:IUserService
    {
        public string LoginEncrypt(string encryptString, string encryptKey)
        {
            return SecurityHelper.EncryptDES(encryptString, encryptKey);
        }

        public string LoginDecrypt(string decryptString, string encryptKey)
        {
            return SecurityHelper.DecryptDES(decryptString, encryptKey);
        }
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
                var loginname = ServiceLocator.GetService<IUserService>().LoginDecrypt(encryptValue, ApplicationKeys.User_Cookie_EncryptionKey);
                return loginname;
            }
        }

        public const string LoginUrl = "/Home/Login";
    }
}
