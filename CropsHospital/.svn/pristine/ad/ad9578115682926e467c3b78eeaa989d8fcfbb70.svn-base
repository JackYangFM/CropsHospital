using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("病虫害图片表")]
    [Table("Pathogeny_Image")]
    public class PathogenyImageEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 主表编号
        /// </summary>
        public string ItemNumber { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImgUrl { get; set; }
    }
}
