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
    }
}