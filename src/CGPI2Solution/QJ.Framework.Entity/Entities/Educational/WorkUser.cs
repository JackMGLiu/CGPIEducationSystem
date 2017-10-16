using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class WorkUser: BaseEntity
    {
        public WorkUser()
        {
            ClassManager = new HashSet<ClassManager>();
            WorkUserProperty = new HashSet<WorkUserProperty>();
        }
        
        public int? DepId { get; set; }
        public int SysUserId { get; set; }
        public string PostName { get; set; }
        public string RealName { get; set; }
        public string EnglishName { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public string BankAccount { get; set; }
        public string AccountNumber { get; set; }
        public string Remark { get; set; }
        public int? Iorder { get; set; }

        public Department Dep { get; set; }
        public SysUser SysUser { get; set; }
        public ICollection<ClassManager> ClassManager { get; set; }
        public ICollection<WorkUserProperty> WorkUserProperty { get; set; }
    }
}
