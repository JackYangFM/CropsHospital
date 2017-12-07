using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.DataModel;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 问题记录表
    /// </summary>
    [Export(typeof(IQuestionInfoContract))]
    public class QuestionInfoContract : Base, IQuestionInfoContract
    {
        [Import]
        public IQuestionInfoRepository QuestionInfoRepository { get; set; }

        [Import]
        public IQuestionImageRepository QuestionImageRepository { get; set; }

        [Import]
        public IReplyExpertRepository ReplyExpertRepository { get; set; }

        [Import]
        public IReplyMemberRepository ReplyMemberRepository { get; set; }

        /// <summary>
        /// 获取问题列表
        /// </summary>
        /// <param name="hospitalId">医院编号 0：所有 其他：编号医院的问题</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">单页记录数</param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        public List<QuestionInfo> GetQuestionList(int hospitalId, int pageIndex, int pageSize, out int total)
        {
            List<QuestionInfoEntity> questionList;
            if (hospitalId!=0)
            {
                questionList = QuestionInfoRepository.Entities.Where(m => m.HospitalId == hospitalId && m.Status==1).ToList();
            }
            else
            {
                questionList = QuestionInfoRepository.Entities.Where(m=>m.Status==1).ToList();
            }

            total = questionList.Count;
            return questionList.OrderByDescending(m => m.CreateTime)
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize)
                .Select(m => new QuestionInfo
                {
                    QuestionId = m.QuestionId,
                    HospitalId = m.HospitalId,
                    ExpertId = m.ExpertId,
                    MemberId = m.MemberId,
                    PlantId = m.PlantId,
                    Title = m.Title,
                    Content = m.Content,
                    Views = m.Views,
                    Replys = m.Replys,
                    CreateTime = m.CreateTime,
                    Status = m.Status
                }).ToList();
        }

        /// <summary>
        /// 获取单个问题信息
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public QuestionInfo GetQuestionInfo(int questionId)
        {
            var questionInfo = QuestionInfoRepository.Entities.Where(m => m.QuestionId == questionId && m.Status == 1)
                    .Select(m => new QuestionInfo
                    {
                        QuestionId = m.QuestionId,
                        HospitalId = m.HospitalId,
                        ExpertId = m.ExpertId,
                        MemberId = m.MemberId,
                        PlantId = m.PlantId,
                        Title = m.Title,
                        Content = m.Content,
                        Views = m.Views,
                        Replys = m.Replys,
                        CreateTime = m.CreateTime,
                        Status = m.Status
                    }).FirstOrDefault();

            if (questionInfo==null)
            {
                return null;
            }

            //图片列表
            questionInfo.QuestionImageList = QuestionImageRepository.Entities.Where(m => m.QuestionId == questionId).Select(m => new QuestionImage
            {
                ImageId = m.ImageId,
                QuestionId = m.QuestionId,
                ImgUrl = m.ImgUrl
            }).ToList();
            //会员回复评论
            questionInfo.ReplyMemberList =
                ReplyMemberRepository.Entities.Where(m => m.QuestionId == questionId).Select(m => new ReplyMember
                {
                    ReplyId = m.ReplyId,
                    QuestionId = m.QuestionId,
                    MemberId = m.MemberId,
                    ReplyContent = m.ReplyContent,
                    ReplyTime = m.ReplyTime
                }).ToList();
            //专家回复列表
            questionInfo.ReplyExpertList =
                ReplyExpertRepository.Entities.Where(m => m.QuestionId == questionId).Select(m => new ReplyExpert
                {
                    ReplyId = m.ReplyId,
                    QuestionId = m.QuestionId,
                    ExpertId = m.ExpertId,
                    ReplyContent = m.ReplyContent,
                    ReplyTime = m.ReplyTime
                }).ToList();

            return questionInfo;
        }

    }
}
