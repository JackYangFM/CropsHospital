using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("问题记录表")]
    [Table("Question_Info")]
    public class QuestionInfoEntity:EntityBase
    {
        /// <summary>
        /// 问题编号
        /// </summary>
        [Key]
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


    }
}
