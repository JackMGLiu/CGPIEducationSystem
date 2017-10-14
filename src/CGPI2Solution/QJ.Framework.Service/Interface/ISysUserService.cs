using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Service.DTO;

namespace QJ.Framework.Service.Interface
{
    public interface ISysUserService
    {
        bool AddUser(SysUser model);

        bool EditUser(SysUser model);

        int GetCount();

        bool GetUserByAccount(string account);

        bool GetUserByMobile(string mobile);

        bool Login(string account, string userPass,out UserLoginModel loginModel);

        IPagedList<SysUser> GetPagedList(string keyword,int page, int pagesize);

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
}