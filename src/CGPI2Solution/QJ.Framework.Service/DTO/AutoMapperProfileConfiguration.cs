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
                //.ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday.Value.ToString("yy-MM-dd")));
            CreateMap<SysUserViewModel, SysUser>();

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
        }
    }
}
