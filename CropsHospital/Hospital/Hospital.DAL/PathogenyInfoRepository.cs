using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    [Export(typeof(IPathogenyInfoRepository))]
    public class PathogenyInfoRepository : Base<PathogenyInfoEntity>, IPathogenyInfoRepository
    {
    }
}
