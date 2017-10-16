using QJ.Framework.Entity.Entities.System;
using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class Teacher : BaseEntity
    {
        public Teacher()
        {
            TeacherProperty = new HashSet<TeacherProperty>();
        }

        public int SysUserId { get; set; }
        public string RealName { get; set; }
        public string EnglishName { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string BankAccount { get; set; }
        public string AccountNumber { get; set; }
        public string PostName { get; set; }
        public string AppointmentType { get; set; }
        public string AssessmentScore { get; set; }
        public string AssessmentContent { get; set; }
        public string TeachLessions { get; set; }
        public string ClassCost { get; set; }
        public string PersonRemark { get; set; }
        public bool? IsScanning { get; set; }
        public bool? IsShow { get; set; }
        public string PassportStatus { get; set; }
        public string PassportTimeSpan { get; set; }
        public string Contacts { get; set; }
        public string OtherContacts { get; set; }
        public string Coordinator { get; set; }
        public string Matters { get; set; }
        public string Remark { get; set; }
        public int? Iorder { get; set; }

        public ICollection<TeacherProperty> TeacherProperty { get; set; }

        public SysUser SysUser { get; set; }
    }
}
