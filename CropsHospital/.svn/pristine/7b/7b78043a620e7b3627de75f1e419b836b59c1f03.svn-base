using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.ViewModel;

namespace Hospital.Web.Base.Filters
{
    public class UserAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                var strUser = ((FormsIdentity)httpContext.User.Identity).Ticket.UserData;
                var member = Utility.SerializableHelper.Decrypt<MemberInfo>(strUser);
                if (member == null || member.MemberId <= 0)
                {
                    return false;
                }
            }
            return base.AuthorizeCore(httpContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var type = -1;
            var msg = "程序出现异常,请稍后重试!";
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                type = 0;
                msg = "请登录或刷新页面";
            }

            //Ajax请求处理
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new JsonResult
                {
                    Data = new { Result = false, Type = type, Msg = msg },
                    ContentEncoding = Encoding.UTF8,
                    ContentType = "Json",
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            else
            {
                //正常请求处理
                if (type == 0)
                {
                    base.HandleUnauthorizedRequest(filterContext);
                    if (filterContext.Result is HttpUnauthorizedResult)
                    {
                        if (filterContext.HttpContext.Request.Url != null)
                        {
                            filterContext.Result =
                                new RedirectResult(string.Concat(FormsAuthentication.LoginUrl, "?ReturnUrl=",
                                    filterContext.HttpContext.Server.UrlEncode(
                                        filterContext.HttpContext.Request.Url.AbsolutePath)));
                        }
                    }
                }
                else
                {
                    throw new HttpException(500, msg);
                }
            }
        }
    }
}