using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class ClassInfo:BaseEntity
    {
        public ClassInfo()
        {
            ClassLession = new HashSet<ClassLession>();
            ClassManager = new HashSet<ClassManager>();
            StudentClass = new HashSet<StudentClass>();
        }
        
        public int? DepId { get; set; }
        public int? Ctid { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public string ClassImage { get; set; }
        public string ClassType { get; set; }
        public decimal? Tuition { get; set; }
        public string ClassContent { get; set; }
        public DateTime? RegStartDate { get; set; }
        public DateTime? RegEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsReg { get; set; }
        public bool? IsShow { get; set; }
        public string ClassRemark { get; set; }
        public string Remark { get; set; }

        public ClassType Ct { get; set; }
        public Department Dep { get; set; }
        public ICollection<ClassLession> ClassLession { get; set; }
        public ICollection<ClassManager> ClassManager { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
