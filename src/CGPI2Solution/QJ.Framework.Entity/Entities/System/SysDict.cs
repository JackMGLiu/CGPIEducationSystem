using System;
using System.Collections.Generic;
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
    /// 描 述：数据字典分类实体
    /// </summary>
    public class SysDict : BaseEntity
    {
        /// <summary>
        /// 上级编号
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 分类编码
        /// </summary>
        [MaxLength(50)]
        public string DictCode { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Required,MaxLength(50)]
        public string DictName { get; set; }

        /// <summary>
        /// 树型结构
        /// </summary>
        public bool? IsTree { get; set; }

        /// <summary>
        /// 导航标记
        /// </summary>
        public bool? IsNav { get; set; }

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

        public virtual List<SysDictDetail> SysDictDetails { get; set; }

        #endregion
    }
}
