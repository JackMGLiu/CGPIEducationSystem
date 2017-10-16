using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class StudentLeave: BaseEntity
    {
        public StudentLeave()
        {
            MarkupLession = new HashSet<MarkupLession>();
        }
        
        public int? Slid { get; set; }
        public string LeaveTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LeaveContent { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public int? Rstatus { get; set; }

        public StudentLession Sl { get; set; }
        public ICollection<MarkupLession> MarkupLession { get; set; }
    }
}
