

using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 问题记录表
    /// </summary>
    public interface IQuestionInfoContract
    {
        /// <summary>
        /// 获取问题列表
        /// </summary>
        /// <param name="hospitalId">医院编号 0：所有 其他：编号医院的问题</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        List<QuestionInfo> GetQuestionList(int hospitalId, int pageIndex, int pageSize, out int total);

        /// <summary>
        /// 获取单个问题信息
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        QuestionInfo GetQuestionInfo(int questionId);
    }
}
