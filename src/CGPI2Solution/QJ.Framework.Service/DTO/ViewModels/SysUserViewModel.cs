using System;
using System.Collections.Generic;
using System.Text;

namespace QJ.Framework.Service.DTO.ViewModels
{
    public class SysUserViewModel
    {
        public int Id { get; set; }

        public string Account { get; set; }

        public string RealName { get; set; }

        public string NickName { get; set; }

        public bool? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public int? OrganizeId { get; set; }

        //public virtual SysOrganize Organize { get; set; }

        public string Signature { get; set; }

        public string Address { get; set; }

        public int? DepartmentId { get; set; }

        //public virtual SysOrganize Department { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string EnCode { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int? UserType { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadIcon { get; set; }

        /// <summary>
        /// 是否新头像
        /// </summary>
        public bool HeadIsNew { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        public string SimpleSpelling { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string Secretkey { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public int? Nation { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public int? Political { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        public string DutyName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// QQ号码
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 微信号码
        /// </summary>
        public string WeChat { get; set; }

        /// <summary>
        /// MSN号码
        /// </summary>
        public string MSN { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CardId { get; set; }

        /// <summary>
        /// 在线状态
        /// </summary>
        public int? UserOnLine { get; set; }

        /// <summary>
        /// 密码提示问题
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 密码提示问题答案
        /// </summary>
        public string AnswerQuestion { get; set; }

        /// <summary>
        /// 允许多用户同时登录
        /// </summary>
        public int? CheckOnLine { get; set; }

        /// <summary>
        /// 允许登陆开始时间
        /// </summary>
        public DateTime? AllowStartTime { get; set; }

        /// <summary>
        /// 允许登陆结束时间
        /// </summary>
        public DateTime? AllowEndTime { get; set; }

        /// <summary>
        /// 锁定开始时间
        /// </summary>
        public DateTime? LockStartDate { get; set; }

        /// <summary>
        /// 锁定结束时间
        /// </summary>
        public DateTime? LockEndDate { get; set; }

        /// <summary>
        /// 登陆次数
        /// </summary>
        public int? LogOnCount { get; set; }

        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }

        public string CreateUser { get; set; }

        public DateTime CreateTime { get; set; }

        public string ModifyUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public string Remark { get; set; }
    }
}
