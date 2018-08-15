using ITIX.Core.Model.Base;
using ITIX.EntityFramework.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ITIX.EntityFramework.Repository.Base
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

        public Task SaveAsync()
        {
            return _defaultContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _defaultContext.Dispose();
        }

        public DbSet<T> Set<T>() where T : EntityBase
        {
            return _defaultContext.Set<T>();
        }

        public Database Database()
        {
            return _defaultContext.Database;
        }
    }
}