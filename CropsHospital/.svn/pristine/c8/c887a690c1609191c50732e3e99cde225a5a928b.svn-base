using System.Web.Optimization;

namespace Hospital.Terminal
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 基础样式
            const string baseCss1 = "~/Content/css/global.css";
            const string baseCss2 = "~/Content/css/css.css";     //所有页面样式
            const string baseCss3 = "~/Content/css/swiper.min.css";
            #endregion

            #region 基础JS
            const string baseJs1 = "~/Content/js/jquery-1.10.1.min.js";  //基础
            const string baseJs2 = "~/Content/js/unslider.min.js";
            const string baseJs3 = "~/Content/js/master.js";      //通用JS
            const string baseJs4 = "~/Content/js/all-js.js"; 
            #endregion

            #region 通用

            bundles.Add(new StyleBundle("~/cms/css/Common").Include(baseCss1, baseCss2, baseCss3));
            bundles.Add(new ScriptBundle("~/cms/js/Common").Include(baseJs1, baseJs2, baseJs3, baseJs4));

            #endregion

        }
    }
}