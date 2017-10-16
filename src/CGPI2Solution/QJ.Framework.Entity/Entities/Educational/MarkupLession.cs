using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class MarkupLession: BaseEntity
    {
        public int? Lid { get; set; }
        public int? ClassId { get; set; }
        public DateTime MlstartTime { get; set; }
        public DateTime MlendTime { get; set; }
        public bool? Status { get; set; }
        public string Remark { get; set; }

        public StudentLeave L { get; set; }
    }
}
