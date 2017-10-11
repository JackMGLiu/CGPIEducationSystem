using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QJ.Framework.Infrastructure.Core
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column("Guid"), MaxLength(36)]
        public string GuidCode { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [Required]
        public bool IsEnableed { get; set; }

        /// <summary>
        /// 删除状态
        /// </summary>
        [Required]
        public bool IsDeleted { get; set; }
    }
}
