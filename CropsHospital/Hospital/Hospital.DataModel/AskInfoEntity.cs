using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("咨询内容主表")]
    [Table("Ask_Info")]
    public class AskInfoEntity : EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int AskId { get; set; }
        /// <summary>
        /// 咨询类型编号
        /// </summary>
        public int AskTypeId { get; set; }
        /// <summary>
        /// 医院编号
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 专家编号
        /// </summary>
        public int ExpertId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 状态（0：:不显示 1：:显示）
        /// </summary>
        public int Status { get; set; }
    }
}
