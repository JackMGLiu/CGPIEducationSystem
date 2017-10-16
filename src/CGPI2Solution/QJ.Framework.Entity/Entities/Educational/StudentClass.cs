using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class StudentClass: BaseEntity
    {
        public int? StudentId { get; set; }
        public int? ClassId { get; set; }
        public bool? IsTemporary { get; set; }

        public ClassInfo Class { get; set; }
        public Student Student { get; set; }
    }
}
