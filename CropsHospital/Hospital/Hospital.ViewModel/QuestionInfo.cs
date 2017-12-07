using System;
using System.Collections.Generic;

namespace Hospital.ViewModel
{
    /// <summary>
    /// 问题记录表
    /// </summary>
    public class QuestionInfo
    {
        /// <summary>
        /// 问题编号
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// 医院编号
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 专家编号
        /// </summary>
        public int ExpertId { get; set; }
        /// <summary>
        /// 会员编号
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 植物编号
        /// </summary>
        public int PlantId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 问题描述
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 浏览数
        /// </summary>
        public int Views { get; set; }
        /// <summary>
        /// 回复数
        /// </summary>
        public int Replys { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 状态 0：不显示 1：显示
        /// </summary>
        public int Status { get; set; }

        //扩展
        /// <summary>
        /// 图片列表
        /// </summary>
        public List<QuestionImage> QuestionImageList { get; set; }
        /// <summary>
        /// 会员回复列表
        /// </summary>
        public List<ReplyMember> ReplyMemberList { get; set; }
        /// <summary>
        /// 专家回复列表
        /// </summary>
        public List<ReplyExpert> ReplyExpertList { get; set; }
    }
}
