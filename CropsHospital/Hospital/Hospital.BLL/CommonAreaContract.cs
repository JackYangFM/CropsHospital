using System.ComponentModel.Composition;
using Hospital.IBLL;

namespace Hospital.BLL
{
    /// <summary>
    /// 区县
    /// </summary>
    [Export(typeof(ICommonAreaContract))]
    public class CommonAreaContract : Base, ICommonAreaContract
    {
    }
}
