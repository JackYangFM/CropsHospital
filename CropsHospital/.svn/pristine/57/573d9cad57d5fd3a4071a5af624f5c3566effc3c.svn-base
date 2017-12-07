using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("会员回复表")]
    [Table("ReplyMember")]
    public class ReplyMemberEntity:EntityBase
    {
        /// <summary>
        /// 回复编号
        /// </summary>
        [Key]
        public int ReplyId { get; set; }
        /// <summary>
        /// 问题编号
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// 会员编号
        /// </summary>
        public int MemberId { get; set; }
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
