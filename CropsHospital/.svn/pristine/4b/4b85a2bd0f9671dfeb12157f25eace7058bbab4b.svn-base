using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 咨询类型
    /// </summary>
    [Export(typeof(IAskTypeContract))]
    public class AskTypeContract : Base, IAskTypeContract
    {
        [Import]
        public IAskTypeRepository AskTypeRepository { get; set; }

        /// <summary>
        /// 获取资讯类型列表
        /// </summary>
        /// <returns></returns>
        public List<AskType> GetAskTypeList()
        {
            return AskTypeRepository.Entities.OrderBy(m => m.AskTypeId).Select(m => new AskType
            {
                AskTypeId = m.AskTypeId,
                TypeName = m.TypeName
            }).ToList();
        }

    }
}
