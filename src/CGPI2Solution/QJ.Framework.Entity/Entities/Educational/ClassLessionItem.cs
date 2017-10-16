using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class ClassLessionItem : BaseEntity
    {
        public ClassLessionItem()
        {
            StudentLession = new HashSet<StudentLession>();
        }
        
        public int? Clid { get; set; }
        public decimal? Credit { get; set; }
        public DateTime? LessionDate { get; set; }
        public DateTime? StartLessionTime { get; set; }
        public DateTime? EndLessionTime { get; set; }

        public ClassLession Cl { get; set; }
        public ICollection<StudentLession> StudentLession { get; set; }
    }
}
