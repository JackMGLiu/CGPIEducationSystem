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
    /// 描 述：部门实体
    /// </summary>
    public class BaseDepartment : BaseEntity
    {
        /// <summary>
        /// 上级编号
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        public int OrganizeId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string DepName { get; set; }

        /// <summary>
        /// 部门代码
        /// </summary>
        [StringLength(50)]
        public string EnCode { get; set; }

        /// <summary>
        /// 部门简称
        /// </summary>
        [StringLength(50)]
        public string ShortName { get; set; }

        /// <summary>
        /// 部门电话
        /// </summary>
        [StringLength(50)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 排列序号
        /// </summary>
        public int? SortCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Required]
        public int Status { get; set; }

        /// <summary>
        /// 删除状态
        /// </summary>
        public int? DeleteFlag { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength(50)]
        public string CreateName { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// 编辑人
        /// </summary>
        [StringLength(50)]
        public string ModifyName { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        #region 扩展操作

        /// <summary>
        /// 新增调用
        /// </summary>
        public override void DoCreate()
        {
            this.DepartmentId = Guid.NewGuid().ToString();
            this.CreateTime = DateTime.Now;
            //this.CreateUserId = OperatorProvider.Provider.Current().UserId;
            //this.CreateUserName = OperatorProvider.Provider.Current().UserName;
            this.DeleteFlag = 0;
            //this.Status = 1;
        }

        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public override void DoModify(string keyValue)
        {
            this.DepartmentId = keyValue;
            this.ModifyTime = DateTime.Now;
            //this.ModifyUserId = OperatorProvider.Provider.Current().UserId;
            //this.ModifyUserName = OperatorProvider.Provider.Current().UserName;
        }

        #endregion
    }
}
