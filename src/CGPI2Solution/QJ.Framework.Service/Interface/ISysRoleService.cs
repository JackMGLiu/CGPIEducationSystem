using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Service.Interface
{
    public interface ISysRoleService
    {
        bool AddRole(SysRole model);

        bool EditRole(SysRole model);

        List<SysRole> GetSysRoleList();

        bool AddRoleUsers(int roleid, List<int> userids);

        IPagedList<SysRole> GetPagedList(string keyword,int page, int pagesize);
    }
}