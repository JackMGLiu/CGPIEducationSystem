using System.ComponentModel;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Service.Interface
{
    public interface ISysUserService
    {
        bool AddUser(SysUser model);

        int GetCount();
    }
}