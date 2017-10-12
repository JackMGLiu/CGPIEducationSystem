﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Interface;

namespace QJ.Framework.Service.Impl
{
    public class SysRoleService : ISysRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IRepository<SysRole> _sysroleRepository;

        public SysRoleService(IUnitOfWork unitOfWork)
        {
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
    }
}