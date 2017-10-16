using QJ.Framework.Infrastructure.Core;
using System;
using System.Collections.Generic;

namespace QJ.Framework.Entity.Entities.Educational
{
    public partial class Student: BaseEntity
    {
        public Student()
        {
            EducationExperience = new HashSet<EducationExperience>();
            StudentClass = new HashSet<StudentClass>();
            StudentCode = new HashSet<StudentCode>();
            StudentLession = new HashSet<StudentLession>();
            StudentProperty = new HashSet<StudentProperty>();
            WorkExperience = new HashSet<WorkExperience>();
        }
        
        public string RealName { get; set; }
        public string EnglishName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Nation { get; set; }
        public string NativePlace { get; set; }
        public string Mobile { get; set; }
        public string LoginPass { get; set; }
        public string Photo { get; set; }
        public string CardId { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string WorkPhone { get; set; }
        public string UrgentName { get; set; }
        public string UrgentPhone { get; set; }
        public string UrgentFax { get; set; }
        public string UrgentEmail { get; set; }
        public string UrgentMobile { get; set; }
        public string Qq { get; set; }
        public string WeChart { get; set; }
        public string Weibo { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string PostName { get; set; }
        public string WelfareWorkTimeSpan { get; set; }
        public string OrgBack { get; set; }
        public string EnglishLevel { get; set; }
        public string CharitDomain { get; set; }
        public string LessionIds { get; set; }
        public bool? IsPassport { get; set; }
        public string PassportNum { get; set; }
        public string PassportValid { get; set; }
        public bool? IsUspassport { get; set; }
        public string VisaType { get; set; }
        public string VisaValid { get; set; }
        public string PassportImg { get; set; }
        public string VisaImg { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string Belief { get; set; }
        public string Taboo { get; set; }
        public string Gplscale { get; set; }
        public DateTime? GplcreateDate { get; set; }
        public string Remark { get; set; }
        public string QqopenId { get; set; }
        public string WeixinOpenId { get; set; }
        public string OpenKey { get; set; }

        public ICollection<EducationExperience> EducationExperience { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
        public ICollection<StudentCode> StudentCode { get; set; }
        public ICollection<StudentLession> StudentLession { get; set; }
        public ICollection<StudentProperty> StudentProperty { get; set; }
        public ICollection<WorkExperience> WorkExperience { get; set; }
    }
}
