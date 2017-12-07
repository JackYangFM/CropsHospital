using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 医院表
    /// </summary>
    [Export(typeof(IHospitalInfoContract))]
    public class HospitalInfoContract : Base, IHospitalInfoContract
    {
        [Import]
        public IHospitalInfoRepository HospitalInfoRepository { get; set; }

        /// <summary>
        /// 获取医院列表
        /// </summary>
        /// <param name="pageIndex">开始页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">返回记录总数</param>
        /// <returns></returns>
        public List<HospitalInfo> GetHospitalList(int pageIndex, int pageSize, out int total)
        {
            total = HospitalInfoRepository.Entities.Count();
            return HospitalInfoRepository.Entities.OrderBy(m => m.HospitalId)
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize)
                .Select(m => new HospitalInfo
                {
                    HospitalId = m.HospitalId,
                    HospitalName = m.HospitalName,
                    HospitalImage = m.HospitalImage,
                    Specialists = m.Specialists,
                    Brief = m.Brief,
                    Province = m.Province,
                    City = m.City,
                    Phone = m.Phone
                }).ToList();
        }

        /// <summary>
        /// 单个医院信息
        /// </summary>
        /// <param name="hospitalId">医院编号</param>
        /// <returns></returns>
        public HospitalInfo GetHospitalInfo(int hospitalId)
        {
            return HospitalInfoRepository.Entities.Where(m => m.HospitalId == hospitalId).Select(m => new HospitalInfo
            {
                HospitalId = m.HospitalId,
                HospitalName = m.HospitalName,
                HospitalImage = m.HospitalImage,
                Specialists = m.Specialists,
                Brief = m.Brief,
                Province = m.Province,
                City = m.City,
                Phone = m.Phone
            }).FirstOrDefault();
        }

    }
}
