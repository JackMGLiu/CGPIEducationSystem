using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class WorkUserProperty : BaseEntity
    {
        public int? WuId { get; set; }
        public string Wpname { get; set; }
        public string Wpvalue { get; set; }
        public int? Iorder { get; set; }

        public WorkUser Wu { get; set; }
    }
}
