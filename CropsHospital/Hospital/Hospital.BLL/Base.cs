using System.ComponentModel.Composition;
using Hospital.Base;

namespace Hospital.BLL
{
    /// <summary>
    /// 业务层实现基类
    /// </summary>
    public abstract class Base
    {
        [Import(typeof(IUnitofWork))]
        protected IUnitofWork UnitofWork { get; set; }
    }
}
