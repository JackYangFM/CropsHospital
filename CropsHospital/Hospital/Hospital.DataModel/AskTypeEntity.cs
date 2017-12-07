using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("咨询类型表")]
    [Table("Ask_Type")]
    public class AskTypeEntity:EntityBase
    {
        /// <summary>
        /// 咨询类型编号
        /// </summary>
        [Key]
        public int AskTypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
    }
}
