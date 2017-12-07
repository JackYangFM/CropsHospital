using System.ComponentModel.Composition;
using Hospital.Base;

namespace Hospital.DAL.DBContext
{
    public abstract class Base<TEntity> : RepositoryBase<TEntity> where TEntity : EntityBase
    {
        [Import(typeof(IUnitofWork))]
        public IUnitofWork UnitofWork { get; set; }
    }
}
