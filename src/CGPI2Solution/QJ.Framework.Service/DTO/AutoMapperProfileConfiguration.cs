using AutoMapper;
using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Service.DTO.ViewModels;

namespace QJ.Framework.Service.DTO
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            #region SysUser 用户信息

            //用户信息
            CreateMap<SysUser, SysUserViewModel>();
            CreateMap<SysUserViewModel, SysUser>();

            //用户登陆信息
            CreateMap<SysUser, UserLoginModel>()
                .ForMember(dest => dest.userId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Secretkey))
                .ForMember(dest => dest.LoginTime, opt => opt.MapFrom(src => src.LastLoginTime));
            CreateMap<UserLoginModel, SysUser>();

            //人员api
            //CreateMap<SysUser, UserModel>()
            //    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.Mobile, opt => opt.MapFrom(src => src.MobilePhone))
            //    .ForMember(dest => dest.DepName, opt => opt.MapFrom(src => src.Department.FullName))
            //    .ForMember(dest => dest.OrganizeName, opt => opt.MapFrom(src => src.Organize.FullName))
            //    .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == true ? "1" : "0"));
            //CreateMap<UserModel, SysUser>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
            //    .ForMember(dest => dest.MobilePhone, opt => opt.MapFrom(src => src.Mobile))
            //    .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == "1" ? true : false));

            #endregion

            //角色信息
            CreateMap<SysRole, SysRoleViewModel>();
            CreateMap<SysRoleViewModel, SysRole>();


        }
    }
}
