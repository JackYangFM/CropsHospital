using System.ComponentModel.Composition;
using Hospital.IBLL;

namespace Hospital.BLL
{
    /// <summary>
    /// 会员回复
    /// </summary>
    [Export(typeof(IReplyMemberContract))]
    public class ReplyMemberContract : Base, IReplyMemberContract
    {
    }
}
