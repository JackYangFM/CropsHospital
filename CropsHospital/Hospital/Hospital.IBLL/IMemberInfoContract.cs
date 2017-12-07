using Hospital.Utility;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 会员表
    /// </summary>
    public interface IMemberInfoContract
    {
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="entity">用户信息</param>
        /// <returns></returns>
        OperationResult AddMemberInfo(MemberInfo entity);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="phone">手机编号</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        OperationResult Login(string phone, string passWord);
    }
}
