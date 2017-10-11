using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 系统用户实体
    /// </summary>
    public partial class SysUser : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Account { get; set; }

        [Required, MaxLength(200)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public string RealName { get; set; }

        [MaxLength(50)]
        public string NickName { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }

        [Required,MaxLength(50)]
        public string MobilePhone { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        public int? OrganizeId { get; set; }

        public virtual SysOrganize Organize { get; set; }

        /// <summary>
        /// 个人签名
        /// </summary>
        [MaxLength(50)]
        public string Signature { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public int? DepartmentId { get; set; }

        public virtual SysOrganize Department { get; set; }

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

        public virtual List<UserAuthorize> UserAuthorizes { get; set; }

        #endregion

    }
}
