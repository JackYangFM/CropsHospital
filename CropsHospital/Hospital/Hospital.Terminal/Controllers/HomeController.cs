using System.ComponentModel.Composition;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Terminal.Models;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    [Export]
    public class HomeController : BaseController
    {
        [Import]
        public IPlantInfoContract PlantInfoContract { get; set; }

        [Import]
        public IQuestionInfoContract QuestionInfoContract { get; set; }

        [Import]
        public IHospitalInfoContract HospitalInfoContract { get; set; }


        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        //[OutputCache(Duration = 86400)]
        public ActionResult Index()
        {
            //Response.Cache.SetOmitVaryStar(true);
            var model = new HomeIndexModel();
            int total;
            model.QuestionList = QuestionInfoContract.GetQuestionList(0, 1, 10, out total);
            int hosTotal;
            model.HospitalList = HospitalInfoContract.GetHospitalList(1, 5, out hosTotal);  //医院列表
            return View(model);
        }

    }
}
