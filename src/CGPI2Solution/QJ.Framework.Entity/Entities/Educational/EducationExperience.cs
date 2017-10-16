using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class EducationExperience:BaseEntity
    {
        public int? StudentId { get; set; }
        public string SchoolName { get; set; }
        public string Education { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public Student Student { get; set; }
    }
}
