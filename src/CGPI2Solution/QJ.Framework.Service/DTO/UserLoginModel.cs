using System;
using System.Collections.Generic;

namespace QJ.Framework.Service.DTO
{
    /// <summary>
    /// 操作模型，保存登陆用户必要信息。
    /// </summary>
    [Serializable]
    public class UserLoginModel
    {
        public int userId { get; set; }
        public string GuidId { get; set; }
        public string Account { get; set; }
        public string RealName { get; set; }
        public string NickName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Avatar { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Signature { get; set; }
        public string Address { get; set; }
        //public string OrganizeId { get; set; }
        //public string DepartmentId { get; set; }
        //public List<int> RoleId { get; set; }
        public string Token { get; set; }
        public DateTime LoginTime { get; set; }
    }
}