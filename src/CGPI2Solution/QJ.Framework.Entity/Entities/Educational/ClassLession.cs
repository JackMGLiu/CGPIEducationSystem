using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class ClassLession : BaseEntity
    {
        public ClassLession()
        {
            ClassLessionItem = new HashSet<ClassLessionItem>();
        }
        
        public int? ClassId { get; set; }
        public int? LessionId { get; set; }
        public string TeacherName { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string TimeRemark { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public decimal? Credit { get; set; }
        public int? ShouldTotal { get; set; }
        public int? RealTotal { get; set; }
        public string Remark { get; set; }

        public ClassInfo Class { get; set; }
        public Lession Lession { get; set; }
        public ICollection<ClassLessionItem> ClassLessionItem { get; set; }
    }
}
