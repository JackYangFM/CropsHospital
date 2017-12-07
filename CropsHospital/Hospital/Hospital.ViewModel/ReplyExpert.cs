using System;

namespace Hospital.ViewModel
{
    /// <summary>
    /// 专家回复表
    /// </summary>
    public class ReplyExpert
    {
        /// <summary>
        /// 编号
        /// </summary>
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
