using System;
using System.ComponentModel.Composition;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.IBLL;
using Hospital.Utility;
using Hospital.ViewModel;

namespace Hospital.Terminal.Controllers
{
    [Export]
    public class LoginController : Controller
    {
        [Import]
        public IMemberInfoContract MemberInfoContract { get; set; }


        /// <summary>
        /// 登录页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var strurl = Request.QueryString["ReturnUrl"];
            Session["Url"] = strurl;
            return View();
        }

        /// <summary>
        /// 提交登录
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public JsonResult SubmitLogin(string phone, string passWord)
        {
            var result = MemberInfoContract.Login(phone, passWord);
            if (result.ResultType== OperationResultType.Error)
            {
                return Json(new {Result = false, Msg = result.Message});
            }
            var memberInfo = (MemberInfo) result.AppendData;
            var ticket = new FormsAuthenticationTicket(memberInfo.MemberId, memberInfo.NickName, DateTime.Now, DateTime.Now.AddMinutes(60), false, SerializableHelper.Encrypt(memberInfo));

            //加密验证票据
            var strTicket = FormsAuthentication.Encrypt(ticket);
            // 使用新userdata保存cookie
            CookiesHelper.SetCookie(FormsAuthentication.FormsCookieName, strTicket, ticket.Expiration);

            return Json(new {Result = false, Msg = "登录失败"});
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginOut()
        {
            LogHelper.Logger.Info(User.Identity.Name + "退出终端机");
            FormsAuthentication.SignOut();
            return Redirect("/home/index/");
        }

    }
}
