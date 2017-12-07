using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("专家回复表")]
    [Table("ReplyExpert")]
    public class ReplyExpertEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int ReplyId { get; set; }
        /// <summary>
        /// 问题编号
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// 专家编号
        /// </summary>
        public int ExpertId { get; set; }
        /// <summary>
        /// 回复内容
        /// </summary>
        public string ReplyContent { get; set; }
        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime ReplyTime { get; set; }
    }
}
