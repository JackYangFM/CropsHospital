
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 专家表
    /// </summary>
    public interface IExpertInfoContract
    {
        /// <summary>
        /// 获取专家列表
        /// </summary>
        /// <param name="hospitalId">医院编号</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        List<ExpertInfo> GetExpertList(int hospitalId, int pageIndex, int pageSize, out int total);

        /// <summary>
        /// 专家明细
        /// </summary>
        /// <param name="expertId">专家编号</param>
        /// <returns></returns>
        ExpertInfo GetExpertInfo(int expertId);
    }
}
