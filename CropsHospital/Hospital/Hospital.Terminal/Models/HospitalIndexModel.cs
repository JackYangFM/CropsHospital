
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.Terminal.Models
{
    /// <summary>
    /// 医院列表
    /// </summary>
    public class HospitalIndexModel
    {
        /// <summary>
        /// 医院列表
        /// </summary>
        public List<HospitalInfo> HospitalList { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 单页记录数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { get; set; }
    }
}