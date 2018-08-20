using ITIX.Domain.Model.Base;
using ITIX.Persistence.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ITIX.Persistence.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _defaultContext;

        public DbContext DefaultContext
        {
            get
            {
                return _defaultContext;
            }
        }

        public UnitOfWork(DbContext contexto)
        {
            this._defaultContext = contexto;
        }

        public void Save()
        {
            _defaultContext.SaveChanges();
        }

        public void Dispose()
        {
            _defaultContext.Dispose();
        }

        public DbSet<T> Set<T>() where T : EntityBase
        {
            return _defaultContext.Set<T>();
        }
    }
}