using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 系统角色
    /// </summary>
    public class SysRole : BaseEntity
    {
        [MaxLength(50)]
        public string EnCode { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        public int? Type { get; set; }

        public int? OrganizeId { get; set; }

        public virtual SysOrganize Organize { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        public bool? AllowEdit { get; set; }

        public int? SortCode { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }

        [Required, Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        [MaxLength(50)]
        public string ModifyUser { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifyTime { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        #region 关联

        public virtual List<UserRole> UserRoles { get; set; }

        public virtual List<RoleAuthorize> RoleAuthorizes { get; set; }

        #endregion
    }
}
