using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Service.Interface
{
    public interface ISysUserService
    {
        bool AddUser(SysUser model);

        int GetCount();

        IPagedList<SysUser> GetPagedList(string keyword,int page, int pagesize);
    }
}