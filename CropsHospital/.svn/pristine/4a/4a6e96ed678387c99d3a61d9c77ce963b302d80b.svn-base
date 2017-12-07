using System.ComponentModel.Composition;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Terminal.Models;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    /// <summary>
    /// 咨讯
    /// </summary>
    [Export]
    public class AskController : BaseController
    {
        [Import]
        public IAskInfoContract AskInfoContract { get; set; }

        [Import]
        public IAskTypeContract AskTypeContract { get; set; }

        #region 资讯

        /// <summary>
        /// 咨讯首页
        /// </summary>
        /// <returns></returns>
        //[OutputCache(Duration = 86400)]
        public ActionResult Index()
        {
            //Response.Cache.SetOmitVaryStar(true);
            var model = new AskIndexModel();
            //model.AskTypeList = AskTypeContract.GetAskTypeList();
            int total;
            model.AskInfoList = AskInfoContract.GetAskList(1, 10, out total);

            return View(model);
        }

        /// <summary>
        /// 咨讯详细页
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(int id)
        {

            return View();
        }

        #endregion

        #region 我要提问

        /// <summary>
        /// 我要提问
        /// </summary>
        /// <returns></returns>
        public ActionResult Question()
        {

            return View();
        }

        
        #endregion
    }
}
