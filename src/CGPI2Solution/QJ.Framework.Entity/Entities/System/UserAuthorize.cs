using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 用户权限管理
    /// </summary>
    public class UserAuthorize : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public SysUser User { get; set; }

        [Required]
        public int MenuId { get; set; }

        public SysMenu Menu { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }

        [Required, Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}