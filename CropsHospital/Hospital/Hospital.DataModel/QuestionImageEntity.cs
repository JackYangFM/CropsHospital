using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("问题记录图片表")]
    [Table("Question_Image")]
    public class QuestionImageEntity:EntityBase
    {
        /// <summary>
        /// 图片编号
        /// </summary>
        [Key]
        public int ImageId { get; set; }
        /// <summary>
        /// 问题编号
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImgUrl { get; set; }
    }
}
