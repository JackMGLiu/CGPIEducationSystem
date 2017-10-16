using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class Lession:BaseEntity
    {
        public Lession()
        {
            ClassLession = new HashSet<ClassLession>();
        }
        
        public int? Ltid { get; set; }
        public string LessionCode { get; set; }
        public string LessionName { get; set; }
        public bool? Status { get; set; }
        public string Remark { get; set; }

        public LessionType Lt { get; set; }
        public ICollection<ClassLession> ClassLession { get; set; }
    }
}
