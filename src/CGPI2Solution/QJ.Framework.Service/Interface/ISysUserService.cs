using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Service.Interface
{
    public interface ISysUserService
    {
        bool AddUser(SysUser model);

        bool EditUser(SysUser model);

        int GetCount();

        bool GetUserByAccount(string account);

        bool GetUserByMobile(string mobile);

        IPagedList<SysUser> GetPagedList(string keyword,int page, int pagesize);
    }
}