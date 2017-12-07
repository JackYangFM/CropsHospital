using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    [Export(typeof(IReplyExpertRepository))]
    public class ReplyExpertRepository : Base<ReplyExpertEntity>, IReplyExpertRepository
    {
    }
}
