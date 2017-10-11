using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QJ.Framework.Entity.Entities.System
{
    public partial class SysUser
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        [MaxLength(50)]
        public string EnCode { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int? UserType { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [MaxLength(255)]
        public string HeadIcon { get; set; }

        /// <summary>
        /// 是否新头像
        /// </summary>
        public bool HeadIsNew { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [MaxLength(50)]
        public string SimpleSpelling { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        [MaxLength(255)]
        public string Secretkey { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public int? Nation { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [MaxLength(255)]
        public string Origin { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [MaxLength(50)]
        public int? Political { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [MaxLength(50)]
        public string DutyName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [MaxLength(50)]
        public string Telephone { get; set; }

        /// <summary>
        /// QQ号码
        /// </summary>
        [MaxLength(50)]
        public string QQ { get; set; }

        /// <summary>
        /// 微信号码
        /// </summary>
        [MaxLength(50)]
        public string WeChat { get; set; }

        /// <summary>
        /// MSN号码
        /// </summary>
        [MaxLength(50)]
        public string MSN { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [MaxLength(50)]
        public string CardId { get; set; }

        /// <summary>
        /// 在线状态
        /// </summary>
        public int? UserOnLine { get; set; }

        /// <summary>
        /// 密码提示问题
        /// </summary>
        [Column(TypeName = "text")]
        public string Question { get; set; }

        /// <summary>
        /// 密码提示问题答案
        /// </summary>
        [Column(TypeName = "text")]
        public string AnswerQuestion { get; set; }

        /// <summary>
        /// 允许多用户同时登录
        /// </summary>
        public int? CheckOnLine { get; set; }

        /// <summary>
        /// 允许登陆开始时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AllowStartTime { get; set; }

        /// <summary>
        /// 允许登陆结束时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AllowEndTime { get; set; }

        /// <summary>
        /// 锁定开始时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LockStartDate { get; set; }

        /// <summary>
        /// 锁定结束时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LockEndDate { get; set; }

        /// <summary>
        /// 登陆次数
        /// </summary>
        public int? LogOnCount { get; set; }

        /// <summary>
        /// 最后登陆时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginTime { get; set; }
    }
}