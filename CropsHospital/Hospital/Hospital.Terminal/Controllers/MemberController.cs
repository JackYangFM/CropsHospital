﻿using System.ComponentModel.Composition;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    /// <summary>
    /// 会员中心
    /// </summary>
    [Export]
    public class MemberController : BaseController
    {
        [Import]
        public IMemberInfoContract MemberInfoContract { get; set; }


        /// <summary>
        /// 会员中心首页
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Index()
        {
            Response.Cache.SetOmitVaryStar(true);
            return View();
        }

        #region  收藏

        /// <summary>
        /// 收藏首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Collect()
        {
            return View();
        }

        /// <summary>
        /// 收藏医院
        /// </summary>
        /// <returns></returns>
        public ActionResult CollectHospital()
        {
            return View();
        }

        /// <summary>
        /// 收藏病虫害
        /// </summary>
        /// <returns></returns>
        public ActionResult CollectPathogeny()
        {
            return View();
        }

        /// <summary>
        /// 收藏专家
        /// </summary>
        /// <returns></returns>
        public ActionResult CollectExpert()
        {

            return View();

        }

        #endregion

    }
}