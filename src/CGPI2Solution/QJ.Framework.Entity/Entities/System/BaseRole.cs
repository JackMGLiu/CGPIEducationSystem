using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.Base
{
    /// <summary>
    /// 版 本 1.0
    /// Copyright (c) 2017-2018
    /// 创建人：刘健
    /// 日 期：2017.10.10
    /// 描 述：系统角色实体
    /// </summary>
    public class BaseRole:BaseEntity
    {
        /// <summary>
        /// 分类1-角色2-岗位3-职位4-工作组
        /// </summary>
        public int? Category { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色编码
        /// </summary>
        [MaxLength(50)]
        public string EnCode { get; set; }

        /// <summary>
        /// 排列序号
        /// </summary>
        public int? SortCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required, Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [MaxLength(50)]
        public string CreateName { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// 编辑人
        /// </summary>
        [MaxLength(50)]
        public string ModifyName { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}
