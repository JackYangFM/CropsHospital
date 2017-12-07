
namespace Hospital.ViewModel
{
    /// <summary>
    /// 问题记录图片表
    /// </summary>
    public class QuestionImage
    {
        /// <summary>
        /// 图片编号
        /// </summary>
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
