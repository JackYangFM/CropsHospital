using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.DataModel;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    [Export(typeof(IPathogenyImageContract))]
    public class PathogenyImageContract:Base,IPathogenyImageContract
    {
        [Import]
        public IPathogenyImageRepository PathogenyImageRepository { get; set; }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="itemNumber"></param>
        /// <returns></returns>
        public List<PathogenyImage> GetPathogenyImageList(string itemNumber)
        {
            return PathogenyImageRepository.Entities.Where(m => m.ItemNumber == itemNumber).Select(m => new PathogenyImage
            {
                Id = m.Id,
                ItemNumber = m.ItemNumber,
                ImgUrl = m.ImgUrl,
            }).ToList();

        }


        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool AddPathogenyImage(PathogenyImage entity)
        {
            var imageDm = new PathogenyImageEntity
            {
                ItemNumber = entity.ItemNumber,
                ImgUrl = entity.ImgUrl
            };
            return PathogenyImageRepository.Insert(imageDm) > 0;
        }

    }
}
