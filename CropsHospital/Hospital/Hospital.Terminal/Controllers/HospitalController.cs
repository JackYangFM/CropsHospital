﻿using System.ComponentModel.Composition;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Terminal.Models;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    /// <summary>
    /// 医院
    /// </summary>
    [Export]
    public class HospitalController : BaseController
    {
        [Import]
        public IHospitalInfoContract HospitalInfoContract { get; set; }

        [Import]
        public IExpertInfoContract ExpertInfoContract { get; set; }

        /// <summary>
        /// 医院列表
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Index(int page=1)
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new HospitalIndexModel();
            int total;
            model.HospitalList = HospitalInfoContract.GetHospitalList(page, 10, out total);

            model.PageIndex = page;
            model.PageSize = 10;
            model.TotalCount = total;
            return View(model);
        }

        #region  医院详情页

        /// <summary>
        /// 医院详情页
        /// </summary>
        /// <param name="hospitalId">医院编号</param>
        /// <param name="page">专家页当前页数</param>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Detail(int hospitalId,int page=1)
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new HospitalDetailModel();
            int total;
            model.Hospital = HospitalInfoContract.GetHospitalInfo(hospitalId);    //庄稼医院信息
            model.ExpertList = ExpertInfoContract.GetExpertList(hospitalId, page, 10, out total);  //专家列表
            model.PageIndex = page;
            model.PageSize = 10;
            model.TotalCount = total;
            return View(model);
        }

        /// <summary>
        /// 联系方式
        /// </summary>
        /// <param name="hospitalId"></param>
        /// <returns></returns>
        public ActionResult ContactWay(int hospitalId)
        {
            var model = new ContactWayModel();
            model.Hospital = HospitalInfoContract.GetHospitalInfo(hospitalId);    //庄稼医院信息
            return View(model);
        }

        /// <summary>
        /// 医院介绍
        /// </summary>
        /// <param name="hospitalId"></param>
        /// <returns></returns>
        public ActionResult HospitalInfo(int hospitalId)
        {
            var model = new ContactWayModel();
            model.Hospital = HospitalInfoContract.GetHospitalInfo(hospitalId);    //庄稼医院信息
            return View(model);
        }

        #endregion

        #region 专家

        /// <summary>
        /// 专家列表
        /// </summary>
        /// <param name="hospitalId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult ExpertList(int hospitalId, int page = 1)
        {
            var model = new HospitalDetailModel();
            int total;
            model.Hospital = HospitalInfoContract.GetHospitalInfo(hospitalId);    //庄稼医院信息
            model.ExpertList = ExpertInfoContract.GetExpertList(hospitalId, page, 10, out total);  //专家列表
            model.PageIndex = page;
            model.PageSize = 10;
            model.TotalCount = total;
            return View(model);
        }

        /// <summary>
        /// 专家
        /// </summary>
        /// <param name="expertId"></param>
        /// <returns></returns>
        public ActionResult ExpertInfo(int expertId=1)
        {
            var model = ExpertInfoContract.GetExpertInfo(expertId);

            return View(model);
        }

        #endregion

    }
}
