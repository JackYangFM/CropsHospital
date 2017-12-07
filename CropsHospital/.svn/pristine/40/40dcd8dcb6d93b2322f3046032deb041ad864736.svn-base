using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.ViewModel;

namespace Hospital.Web.Base.Controllers
{
    public class BaseController : Controller
    {
        private MemberInfo _member;

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        protected MemberInfo GetUserInfo
        {
            get
            {
                if (User.Identity.IsAuthenticated && _member == null)
                {
                    var strUser = ((FormsIdentity)User.Identity).Ticket.UserData;
                    _member = Utility.SerializableHelper.Decrypt<MemberInfo>(strUser);
                }
                return _member;
            }
        }

        /// <summary>
        /// 未处理异常保存操作（错误日志记录在站点根目录/app_data/下，主要处理500异常）
        /// </summary>
        /// <param name="filterContext">异常上下文</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                base.OnException(null);
                return;
            }
            var httpException = filterContext.Exception as HttpException;
            if (httpException != null)
            {
                return;  //http错误跳过，交给global处理
            }
            var controllerName = filterContext.RouteData.Values["controller"].ToString();
            var actionName = filterContext.RouteData.Values["action"].ToString();
            var timeStamp = filterContext.HttpContext.Timestamp;
            var routeId = string.Empty;
            if (filterContext.RouteData.Values["id"] != null)
            {
                routeId = filterContext.RouteData.Values["id"].ToString();
            }

            #region 收集记录异常信息到/Log/2014-12-25.log中，方便程序查阅

            var message = new StringBuilder();
            message.Append(Environment.NewLine);
            message.Append("请求信息：");
            message.Append(Environment.NewLine);
            message.AppendFormat("Controller={0}，Action={1}，RouteId={2}，TimeStamp={3}", controllerName, actionName, routeId, timeStamp);
            message.Append(Environment.NewLine);
            message.Append("异常信息：");
            message.Append(Environment.NewLine);
            message.Append(filterContext.Exception);
            Utility.LogHelper.Logger.Error(message.ToString());
            #endregion
        }

    }
}
