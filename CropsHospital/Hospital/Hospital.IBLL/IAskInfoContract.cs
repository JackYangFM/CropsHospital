
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 咨询内容
    /// </summary>
    public interface IAskInfoContract
    {
        /// <summary>
        /// 获取内容列表
        /// </summary>
        /// <returns></returns>
        List<AskInfo> GetAskList();

        /// <summary>
        /// 获取内容列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<AskInfo> GetAskList(int pageIndex, int pageSize, out int total);
    }
}
