using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("分类表")]
    [Table("Category")]
    public class CategoryEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 父编号
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Grade { get; set; }
    }
}
