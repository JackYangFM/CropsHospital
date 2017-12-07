using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 植物信息表
    /// </summary>
    [Export(typeof(IPlantInfoContract))]
    public class PlantInfoContract : Base, IPlantInfoContract
    {
        [Import]
        public IPlantInfoRepository PlantInfoRepository { get; set; }

        /// <summary>
        /// 获取所有植物列表
        /// </summary>
        /// <returns></returns>
        public List<PlantInfo> GetPlantList()
        {
            return PlantInfoRepository.Entities.OrderBy(m => m.First).Select(m => new PlantInfo
            {
                PlantId = m.PlantId,
                PlantName = m.PlantName,
                First = m.First
            }).ToList();
        }

        /// <summary>
        /// 获取字母列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetLetterList()
        {
            return PlantInfoRepository.Entities.Select(m => new {m.First}).Select(m=>m.First).Distinct().ToList();
        }

    }
}
