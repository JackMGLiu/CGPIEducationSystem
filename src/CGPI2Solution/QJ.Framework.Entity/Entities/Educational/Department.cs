using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class Department:BaseEntity
    {
        public Department()
        {
            ClassInfo = new HashSet<ClassInfo>();
            WorkUser = new HashSet<WorkUser>();
        }
        
        public int? ParentDepId { get; set; }
        public string DepCode { get; set; }
        public string DepName { get; set; }
        public bool? Status { get; set; }
        public string Remark { get; set; }
        public int? Iorder { get; set; }

        public ICollection<ClassInfo> ClassInfo { get; set; }
        public ICollection<WorkUser> WorkUser { get; set; }
    }
}
