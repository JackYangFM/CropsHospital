using System;

namespace Hospital.ViewModel
{
    /// <summary>
    /// 会员回复表
    /// </summary>
    public class ReplyMember
    {
        /// <summary>
        /// 回复编号
        /// </summary>
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
