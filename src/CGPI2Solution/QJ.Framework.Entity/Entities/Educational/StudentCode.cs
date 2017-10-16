using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class StudentCode: BaseEntity
    {
        public int? StudentId { get; set; }
        public string Sccode { get; set; }
        public string SccodeType { get; set; }

        public Student Student { get; set; }
    }
}
