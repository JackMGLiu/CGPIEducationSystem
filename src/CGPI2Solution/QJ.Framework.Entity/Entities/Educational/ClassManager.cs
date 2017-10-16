using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class ClassManager : BaseEntity
    {
        public int? ClassId { get; set; }
        public int? WuId { get; set; }

        public ClassInfo Class { get; set; }
        public WorkUser Wu { get; set; }
    }
}
