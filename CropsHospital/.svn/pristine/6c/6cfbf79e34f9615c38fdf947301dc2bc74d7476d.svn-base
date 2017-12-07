using System.ComponentModel.Composition;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Terminal.Models;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    /// <summary>
    /// 问题列表
    /// </summary>
    [Export]
    public class QuestionController : BaseController
    {
        [Import]
        public IPlantInfoContract PlantInfoContract { get; set; }

        [Import]
        public IQuestionInfoContract QuestionInfoContract { get; set; }

        /// <summary>
        /// 问题列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new QuestionIndexModel();
            model.LetterList = PlantInfoContract.GetLetterList();  //字母列表
            model.PlantList = PlantInfoContract.GetPlantList();   //植物列表
            return View(model);
        }

        /// <summary>
        /// 问题详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {

            return View();
        }

        /// <summary>
        /// 我来回答
        /// </summary>
        /// <returns></returns>
        public ActionResult Answer()
        {

            return View();
        }


    }
}
