
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 医院表
    /// </summary>
    public interface IHospitalInfoContract
    {
        /// <summary>
        /// 获取医院列表
        /// </summary>
        /// <param name="pageIndex">开始页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">返回记录总数</param>
        /// <returns></returns>
        List<HospitalInfo> GetHospitalList(int pageIndex, int pageSize, out int total);

        /// <summary>
        /// 单个医院信息
        /// </summary>
        /// <param name="hospitalId">医院编号</param>
        /// <returns></returns>
        HospitalInfo GetHospitalInfo(int hospitalId);
    }
}
