using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRole : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public SysUser User { get; set; }

        [Required]
        public int RoleId { get; set; }

        public SysRole Role { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }

        [Required, Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}