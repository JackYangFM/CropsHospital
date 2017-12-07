
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 植物信息表
    /// </summary>
    public interface IPlantInfoContract
    {
        /// <summary>
        /// 获取所有植物列表
        /// </summary>
        /// <returns></returns>
        List<PlantInfo> GetPlantList();

        /// <summary>
        /// 获取字母列表
        /// </summary>
        /// <returns></returns>
        List<string> GetLetterList();

    }
}
