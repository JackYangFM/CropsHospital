using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    [Export(typeof(IReplyMemberRepository))]
    public class ReplyMemberRepository : Base<ReplyMemberEntity>, IReplyMemberRepository
    {
    }
}
