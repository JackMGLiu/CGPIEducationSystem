using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Entity.Entities.System
{
    /// <summary>
    // 操作日志
    /// </summary>
    public class SysLog : BaseEntity
    {
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }

        [MaxLength(50)]
        public string LogLevel { get; set; }

        [MaxLength(50)]
        public string Operation { get; set; }

        [MaxLength(2000)]
        public string Message { get; set; }

        [MaxLength(200)]
        public string Request { get; set; }

        [MaxLength(50)]
        public string Account { get; set; }

        [MaxLength(50)]
        public string RealName { get; set; }

        [MaxLength(50)]
        public string IP { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }

        [MaxLength(50)]
        public string Browser { get; set; }

        [MaxLength(2000)]
        public string Exception { get; set; }

        [MaxLength(2000)]
        public string StackTrace { get; set; }
    }
}