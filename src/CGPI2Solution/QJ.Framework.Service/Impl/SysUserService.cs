using System;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Service.Interface;

namespace QJ.Framework.Service.Impl
{
    public class SysUserService: ISysUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IRepository<SysUser> _sysuseRepository;

        public SysUserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _sysuseRepository = this._unitOfWork.GetRepository<SysUser>();
        }

        public bool AddUser(SysUser model)
        {
            try
            {
                _sysuseRepository.Insert(model);
                bool res = _unitOfWork.SaveChanges() > 0;
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int GetCount()
        {
            return _sysuseRepository.Count();
        }
    }
}