using System;

namespace QJ.Framework.Service.DTO.ViewModels
{
    public class SysRoleViewModel
    {
        public int Id { get; set; }

        public string GuidCode { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>

        public bool IsEnableed { get; set; }

        /// <summary>
        /// 删除状态
        /// </summary>
        public bool IsDeleted { get; set; }

        public string EnCode { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        public int? Type { get; set; }

        public int? OrganizeId { get; set; }

        //public virtual SysOrganize Organize { get; set; }

        public string RoleName { get; set; }

        public bool? AllowEdit { get; set; }

        public int? SortCode { get; set; }

        public string CreateUser { get; set; }

        public DateTime CreateTime { get; set; }

        public string ModifyUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public string Remark { get; set; }

    }
}