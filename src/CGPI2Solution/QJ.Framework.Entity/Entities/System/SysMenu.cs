using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 系统目录
    /// </summary>
    public class SysMenu : BaseEntity
    {
        public int? ParentId { get; set; }

        public int? Layer { get; set; }

        [MaxLength(50)]
        public string EnCode { get; set; }

        [Required, MaxLength(50)]
        public string MenuName { get; set; }

        [MaxLength(50)]
        public string JsEvent { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(200)]
        public string Url { get; set; }

        public int? Type { get; set; }

        public int? SortCode { get; set; }

        public bool? IsPublic { get; set; }

        public bool? IsEdit { get; set; }

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

        public virtual List<UserAuthorize> UserAuthorizes { get; set; }

        public virtual List<RoleAuthorize> RoleAuthorizes { get; set; }

        #endregion
    }
}