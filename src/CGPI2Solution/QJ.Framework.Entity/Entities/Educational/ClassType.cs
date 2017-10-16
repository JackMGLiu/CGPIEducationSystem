using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class ClassType : BaseEntity
    {
        public ClassType()
        {
            ClassInfo = new HashSet<ClassInfo>();
        }
        
        public string TypeName { get; set; }
        public int? ParentId { get; set; }
        public string TypeCode { get; set; }
        public bool? Status { get; set; }
        public string Remark { get; set; }
        public int? Iorder { get; set; }

        public ICollection<ClassInfo> ClassInfo { get; set; }
    }
}
