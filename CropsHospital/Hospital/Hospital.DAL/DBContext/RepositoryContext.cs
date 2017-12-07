using System.ComponentModel.Composition;
using System.Data.Entity;
using Hospital.Base;

namespace Hospital.DAL.DBContext
{
    [Export(typeof(IUnitofWork))]
    public class RepositoryContext : UnitOfWorkContextBase
    {
        protected override DbContext Context
        {
            get { return ReadDbContext; }
        }

        private DbContext _readDbContext;

        public DbContext ReadDbContext
        {
            get { return _readDbContext ?? (_readDbContext = new DbContextBase("MsSql")); }
        }
    }
}
