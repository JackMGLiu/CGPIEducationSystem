using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.DbContext;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Interface;

namespace QJ.Framework.Service.Impl
{
    public class SysRoleService : ISysRoleService
    {
        private readonly CGPIDbContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        private IRepository<SysRole> _sysroleRepository;

        public SysRoleService(CGPIDbContext dbContext, IUnitOfWork unitOfWork)
        {
            this._dbContext = dbContext;
            this._unitOfWork = unitOfWork;
            _sysroleRepository = this._unitOfWork.GetRepository<SysRole>();
        }

        public bool AddRole(SysRole model)
        {
            try
            {
                model.GuidCode = Guid.NewGuid().ToString("N");
                model.IsDeleted = false;
                model.CreateTime = DateTime.Now;
                model.CreateUser = "testmanager";
                _sysroleRepository.Insert(model);
                bool res = _unitOfWork.SaveChanges() > 0;
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EditRole(SysRole model)
        {
            throw new System.NotImplementedException();
        }

        public List<SysRole> GetSysRoleList()
        {
            try
            {
                var data = _dbContext.SysRoles.Where(r => r.IsEnableed && !r.IsDeleted).OrderBy(r => r.SortCode).ToList();
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IPagedList<SysRole> GetPagedList(string keyword, int page, int pagesize)
        {
            if (keyword.IsEmpty())
            {
                var data = _sysroleRepository.GetPagedList(orderBy: ms => ms.OrderBy(m => m.SortCode),
                    pageIndex: page - 1, pageSize: pagesize);
                return data;
            }
            else
            {
                var data =
                    _sysroleRepository.GetPagedList(
                        predicate: m => m.EnCode.Contains(keyword) || m.RoleName.Contains(keyword),
                        orderBy: ms => ms.OrderBy(m => m.SortCode),
                        pageIndex: page - 1, pageSize: pagesize);
                return data;
            }
        }

        public bool AddRoleUsers(int roleid, List<int> userids)
        {
            bool flag = false;
            if (!roleid.IsEmpty() && roleid > 0)
            {
                var current =
                    _sysroleRepository.GetFirstOrDefault(
                        predicate: r => r.Id == roleid && r.IsEnableed && !r.IsDeleted,
                        include: s => s.Include(rs => rs.UserRoles));
                if (!current.IsEmpty())
                {
                    if (userids.Any())
                    {
                        var rusers = new List<UserRole>();
                        UserRole ur = null;
                        foreach (var uid in userids)
                        {
                            ur = new UserRole();
                            ur.GuidCode = Guid.NewGuid().ToString("N");
                            ur.RoleId = current.Id;
                            ur.UserId = uid;
                            ur.CreateUser = "testadmin";
                            current.UserRoles.Add(ur);
                            rusers.Add(ur);
                        }
                        if (current.UserRoles.Any())
                        {
                            current.UserRoles.Clear();
                            current.UserRoles.AddRange(rusers);
                        }
                        else
                        {
                            current.UserRoles.AddRange(rusers);
                        }
                        _sysroleRepository.Update(current);
                        _unitOfWork.SaveChanges();
                        flag = true;
                    }
                    else
                    {
                        //清空当前角色用户
                        if (current.UserRoles.Any())
                        {
                            current.UserRoles.Clear();
                        }
                        _sysroleRepository.Update(current);
                        _unitOfWork.SaveChanges();
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}