using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    [Export(typeof(IMemberInfoRepository))]
    public class MemberInfoRepository : Base<MemberInfoEntity>, IMemberInfoRepository
    {
    }
}
