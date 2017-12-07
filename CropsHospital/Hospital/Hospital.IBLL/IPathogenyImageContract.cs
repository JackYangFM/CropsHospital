
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    public interface IPathogenyImageContract
    {
        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="itemNumber"></param>
        /// <returns></returns>
        List<PathogenyImage> GetPathogenyImageList(string itemNumber);

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddPathogenyImage(PathogenyImage entity);
    }
}
