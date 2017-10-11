using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 角色权限管理
    /// </summary>
    public class RoleAuthorize : BaseEntity
    {
        [Required]
        public int RoleId { get; set; }

        public SysRole Role { get; set; }

        [Required]
        public int MenuId { get; set; }

        public SysMenu Menu { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }

        [Required, Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}