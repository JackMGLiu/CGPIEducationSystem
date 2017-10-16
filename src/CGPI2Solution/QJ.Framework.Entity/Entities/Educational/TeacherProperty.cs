using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class TeacherProperty:BaseEntity
    {
        public int? TeacherId { get; set; }
        public string Tpname { get; set; }
        public string Tpvalue { get; set; }
        public int? Iorder { get; set; }

        public Teacher Teacher { get; set; }
    }
}
