using System.ComponentModel.Composition;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.IDAL;

namespace Hospital.DAL
{
    /// <summary>
    /// 庄稼医院
    /// </summary>
    [Export(typeof(IHospitalInfoRepository))]
    public class HospitalInfoRepository : Base<HospitalInfoEntity>, IHospitalInfoRepository
    {
    }
}
