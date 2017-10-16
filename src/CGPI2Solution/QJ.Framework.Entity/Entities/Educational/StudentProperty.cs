using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class StudentProperty : BaseEntity
    {
        public int? StudentId { get; set; }
        public string Spname { get; set; }
        public string Spvalue { get; set; }
        public int? Iorder { get; set; }

        public Student Student { get; set; }
    }
}
