using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.Interface;

namespace QJ.Framework.Service.Impl
{
    public class SysUserService: ISysUserService
    {
        private readonly IConfiguration _config;
        private readonly IUnitOfWork _unitOfWork;
        private IRepository<SysUser> _sysuseRepository;

        public SysUserService(IConfiguration config,IUnitOfWork unitOfWork)
        {
            this._config = config;
            this._unitOfWork = unitOfWork;
            _sysuseRepository = this._unitOfWork.GetRepository<SysUser>();
        }

        public bool AddUser(SysUser model)
        {
            try
            {
                model.GuidCode=Guid.NewGuid().ToString("N");
                model.Password = _config.GetSection("DefaultConfig:DefaultPwd").Value.ToMd5();
                model.IsEnableed = true;
                model.IsDeleted = false;
                model.CreateTime=DateTime.Now;
                model.CreateUser = "testmanager";
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