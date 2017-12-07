using System.ComponentModel.Composition;
using System.Linq;
using System.Web.Mvc;
using Hospital.IBLL;
using Hospital.Terminal.Models;
using Hospital.Web.Base.Controllers;

namespace Hospital.Terminal.Controllers
{
    /// <summary>
    /// 病虫害库
    /// </summary>
    [Export]
    public class PlantController : BaseController
    {
        [Import]
        public ICategoryContract CategoryContract { get; set; }

        [Import]
        public IPathogenyInfoContract PathogenyInfoContract { get; set; }

        [Import]
        public IPathogenyImageContract PathogenyImageContract { get; set; }


        /// <summary>
        /// 分类列表页(缓存一天)
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Index()
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new CategoryIndexModel();
            model.CategoryList = CategoryContract.GetCategoryList();
            
            return View(model);
        }

        /// <summary>
        /// 分类二级页
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Category(int cid)
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new CategoryModel();
            model.MeCategoryList = CategoryContract.MeCategoryList(cid);
            model.CategoryList = CategoryContract.GetCategoryList(cid, 3);
            return View(model);
        }

        /// <summary>
        /// 病虫害列表
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult ItemList(int cid)
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new ItemListModel();
            model.MeCategoryList = CategoryContract.MeCategoryList(cid);
            model.PathogenyList = PathogenyInfoContract.GetPathogenyList(cid);
            model.BingTotal = model.PathogenyList.Count(m => m.ItemType == 0);
            model.ChongTotal = model.PathogenyList.Count(m => m.ItemType == 1);
            //model.CaoTotal = model.PathogenyList.Count(m => m.ItemType == 2);
            return View(model);
        }

        /// <summary>
        /// 病虫害详情页
        /// </summary>
        /// <param name="itemNumber">编号</param>
        /// <returns></returns>
        [OutputCache(Duration = 86400)]
        public ActionResult Detail(string itemNumber)
        {
            Response.Cache.SetOmitVaryStar(true);
            var model = new PlantDetailModel();

            model.PlantInfo = PathogenyInfoContract.GetPathogenyInfo(itemNumber);
            model.MeCategoryList = CategoryContract.MeCategoryList(model.PlantInfo.CategoryId);
            model.PathogenyImageList = PathogenyImageContract.GetPathogenyImageList(itemNumber);
            return View(model);
        }



    }
}
