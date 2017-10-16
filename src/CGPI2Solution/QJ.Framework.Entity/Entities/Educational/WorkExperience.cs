using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class WorkExperience : BaseEntity
    {
        public int? StudentId { get; set; }
        public string UnitName { get; set; }
        public string UnitPost { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public Student Student { get; set; }
    }
}
