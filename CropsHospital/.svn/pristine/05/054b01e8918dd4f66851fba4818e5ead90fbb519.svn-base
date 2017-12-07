using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 咨询内容
    /// </summary>
    [Export(typeof(IAskInfoContract))]
    public class AskInfoContract : Base, IAskInfoContract
    {
        [Import]
        public IAskInfoRepository AskInfoRepository { get; set; }

        /// <summary>
        /// 获取内容列表
        /// </summary>
        /// <returns></returns>
        public List<AskInfo> GetAskList()
        {
            return AskInfoRepository.Entities.Select(m => new AskInfo
            {
                AskId = m.AskId,
                AskTypeId = m.AskTypeId,
                HospitalId = m.HospitalId,
                ExpertId = m.ExpertId,
                CreateTime = m.CreateTime,
                Title = m.Title,
                Content = m.Content,
                Status = m.Status
            }).ToList();
        }

        /// <summary>
        /// 获取内容列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public List<AskInfo> GetAskList(int pageIndex, int pageSize, out int total)
        {
            total = AskInfoRepository.Entities.Count();
            return AskInfoRepository.Entities
                .OrderBy(m => m.AskId)
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize)
                .Select(m => new AskInfo
                {
                    AskId = m.AskId,
                    AskTypeId = m.AskTypeId,
                    HospitalId = m.HospitalId,
                    ExpertId = m.ExpertId,
                    CreateTime = m.CreateTime,
                    Title = m.Title,
                    Content = m.Content,
                    Status = m.Status
                }).ToList();
        }

    }
}
