using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(IPathogenyImageRepository))]
    public class PathogenyImageRepository : Base<PathogenyImageEntity>, IPathogenyImageRepository
    {

    }
}
