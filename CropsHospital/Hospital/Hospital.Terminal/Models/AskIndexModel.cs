using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.Terminal.Models
{
    /// <summary>
    /// 咨询
    /// </summary>
    public class AskIndexModel
    {
        /// <summary>
        /// 咨询类型
        /// </summary>
        public List<AskType> AskTypeList { get; set; }
        /// <summary>
        /// 咨询内容
        /// </summary>
        public List<AskInfo> AskInfoList { get; set; }
    }
}