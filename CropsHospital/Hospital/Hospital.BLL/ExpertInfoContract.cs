using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 专家表
    /// </summary>
    [Export(typeof(IExpertInfoContract))]
    public class ExpertInfoContract : Base, IExpertInfoContract
    {
        [Import]
        public IExpertInfoRepository ExpertInfoRepository { get; set; }

        /// <summary>
        /// 获取专家列表
        /// </summary>
        /// <param name="hospitalId">医院编号</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        public List<ExpertInfo> GetExpertList(int hospitalId, int pageIndex, int pageSize, out int total)
        {
            total = ExpertInfoRepository.Entities.Count(m => m.HospitalId == hospitalId);
            return ExpertInfoRepository.Entities.Where(m => m.HospitalId == hospitalId)
                .OrderBy(m => m.ExpertId)
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize)
                .Select(m => new ExpertInfo
                {
                    ExpertId = m.ExpertId,
                    HospitalId = m.HospitalId,
                    RealName = m.RealName,
                    Unit = m.Unit,
                    Profession = m.Profession,
                    Replys = m.Replys,
                    Fans = m.Fans,
                    ExpertBrief = m.ExpertBrief,
                    Province = m.Province,
                    City = m.City,
                    Area = m.Area
                }).ToList();
        }

        /// <summary>
        /// 专家明细
        /// </summary>
        /// <param name="expertId">专家编号</param>
        /// <returns></returns>
        public ExpertInfo GetExpertInfo(int expertId)
        {
            return ExpertInfoRepository.Entities.Where(m => m.ExpertId == expertId).Select(m => new ExpertInfo
            {
                ExpertId = m.ExpertId,
                HospitalId = m.HospitalId,
                RealName = m.RealName,
                Unit = m.Unit,
                Profession = m.Profession,
                Replys = m.Replys,
                Fans = m.Fans,
                ExpertBrief = m.ExpertBrief,
                Province = m.Province,
                City = m.City,
                Area = m.Area
            }).FirstOrDefault();
        }

    }
}
