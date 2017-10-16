using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class StudentLession: BaseEntity
    {
        public StudentLession()
        {
            StudentLeave = new HashSet<StudentLeave>();
        }
        
        public int? StudentId { get; set; }
        public int? Cliid { get; set; }
        public int Status { get; set; }
        public decimal? Credit { get; set; }
        public string Remark { get; set; }
        public DateTime? CheckinTime { get; set; }
        public DateTime? CheckoutTime { get; set; }

        public ClassLessionItem Cli { get; set; }
        public Student Student { get; set; }
        public ICollection<StudentLeave> StudentLeave { get; set; }
    }
}
