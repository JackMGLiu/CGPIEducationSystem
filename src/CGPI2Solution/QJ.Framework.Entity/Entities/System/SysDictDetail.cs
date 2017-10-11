using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    /// 版 本 1.0
    /// Copyright (c) 2017-2018
    /// 创建人：刘健
    /// 日 期：2017.02.10
    /// 描 述：数据字典明细实体
    /// </summary>
    public class SysDictDetail : BaseEntity
    {
        /// <summary>
        /// 字典类型
        /// </summary>
        [Required]
        public int SysDictId { get; set; }

        public SysDict SysDict { get; set; }

        /// <summary>
        /// 上级编号
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 明细名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string ItemName { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string ItemValue { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        public bool? IsDefault { get; set; }

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
    }
}
