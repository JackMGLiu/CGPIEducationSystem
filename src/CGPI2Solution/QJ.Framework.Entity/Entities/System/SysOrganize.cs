using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 组织机构
    /// </summary>
    public class SysOrganize : BaseEntity
    {
        public int? ParentId { get; set; }

        public int? Layer { get; set; }

        [MaxLength(50)]
        public string EnCode { get; set; }

        [Required, MaxLength(50)]
        public string FullName { get; set; }

        public int? Type { get; set; }

        [MaxLength(50)]
        public string ManagerId { get; set; }

        [MaxLength(50)]
        public string TelePhone { get; set; }

        [MaxLength(200)]
        public string WeChat { get; set; }

        [MaxLength(50)]
        public string Fax { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

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

        public virtual List<SysUser> SysOrgUsers { get; set; }

        public virtual List<SysUser> SysDepUsers { get; set; }

        public virtual List<SysRole> SysRoles { get; set; }

        #endregion
    }
}