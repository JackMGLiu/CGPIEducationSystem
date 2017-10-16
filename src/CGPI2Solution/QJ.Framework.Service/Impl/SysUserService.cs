using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Security;
using QJ.Framework.Infrastructure.Validate;
using QJ.Framework.Service.DTO;
using QJ.Framework.Service.Interface;

namespace QJ.Framework.Service.Impl
{
    public class SysUserService : ISysUserService
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private IRepository<SysUser> _sysuseRepository;

        public SysUserService(IConfiguration config, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._config = config;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._sysuseRepository = _unitOfWork.GetRepository<SysUser>();
        }

        public bool AddUser(SysUser model)
        {
            try
            {
                model.GuidCode = Guid.NewGuid().ToString("N");
                model.Password = _config.GetSection("DefaultConfig:DefaultPwd").Value.ToMd5();
                model.IsEnableed = true;
                model.IsDeleted = false;
                model.CreateTime = DateTime.Now;
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

        public bool EditUser(SysUser model)
        {
            try
            {
                var user = _sysuseRepository.Find(model.Id);
                if (!user.IsEmpty())
                {
                    user.Account = model.Account;
                    user.RealName = model.RealName;
                    user.MobilePhone = model.MobilePhone;
                    user.Gender = model.Gender;
                    user.Nation = model.Nation;
                    user.Birthday = model.Birthday;
                    user.CardId = model.CardId;
                    user.Address = model.Address;
                    user.Remark = model.Remark;
                    user.ModifyTime = DateTime.Now;
                    user.ModifyUser = "testmanager";
                    _sysuseRepository.Update(user);
                    bool res = _unitOfWork.SaveChanges() > 0;
                    return res;
                }
                else
                {
                    return false;
                }
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

        public IPagedList<SysUser> GetPagedList(string keyword, int page, int pagesize)
        {
            if (keyword.IsEmpty())
            {
                var data = _sysuseRepository.GetPagedList(orderBy: ms => ms.OrderByDescending(m => m.CreateTime),
                    pageIndex: page - 1, pageSize: pagesize);
                return data;
            }
            else
            {
                var data = _sysuseRepository.GetPagedList(predicate: m => m.RealName.Contains(keyword) || m.EnCode.Contains(keyword) || m.MobilePhone.Contains(keyword), orderBy: ms => ms.OrderByDescending(m => m.CreateTime),
    pageIndex: page - 1, pageSize: pagesize);
                return data;
            }
        }

        public bool GetUserByAccount(string account)
        {
            try
            {
                var res = _sysuseRepository.Count(m => m.Account == account) > 0;
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool GetUserByMobile(string mobile)
        {
            try
            {
                var res = _sysuseRepository.Count(m => m.MobilePhone == mobile) > 0;
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Login(string account, string userPass, out UserLoginModel loginModel)
        {
            try
            {
                bool flag = false;
                var current = _sysuseRepository.GetFirstOrDefault(predicate: u => u.Account == account && u.IsDeleted == false);
                if (!current.IsEmpty())
                {
                    if (current.IsEnableed)
                    {
                        if (current.Password == userPass.ToMd5())
                        {
                            current.LastLoginTime = DateTime.Now;
                            current.LogOnCount = current.LogOnCount.HasValue ? (current.LogOnCount.Value) + 1 : 1;
                            _sysuseRepository.Update(current);
                            _unitOfWork.SaveChanges();
                            loginModel = _mapper.Map<UserLoginModel>(current);
                            flag = true;
                        }
                        else
                        {
                            loginModel = null;
                            flag = false;
                        }
                    }
                    else
                    {
                        loginModel = null;
                        flag = false;
                    }
                }
                else
                {
                    loginModel = null;
                    flag = false;
                }
                return flag;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}