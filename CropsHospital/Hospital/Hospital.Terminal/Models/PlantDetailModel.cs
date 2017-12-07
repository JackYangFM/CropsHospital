using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.Terminal.Models
{
    public class PlantDetailModel
    {
        /// <summary>
        /// 单个病虫害信息
        /// </summary>
        public PathogenyInfo PlantInfo { get; set; }
        /// <summary>
        /// 获取分类
        /// </summary>
        public List<Category> MeCategoryList { get; set; }

        public List<PathogenyImage> PathogenyImageList { get; set; }
    }
}