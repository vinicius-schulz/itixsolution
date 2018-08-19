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

        public void Detach<T>(List<T> entities) where T : EntityBase
        {
            foreach (T item in entities)
            {
                _defaultContext.Entry(item).State = EntityState.Detached;
            }
        }

        public void Detach<T>(T entity) where T : EntityBase
        {
            if (entity != null)
            {
                _defaultContext.Entry(entity).State = EntityState.Detached;
            }
        }

        public void Attach<T>(T entity) where T : EntityBase
        {
            if (entity != null) {
                _defaultContext.Set(typeof(T)).Attach(entity);
            }
        }

        public void Attach<T>(List<T> entities) where T : EntityBase
        {
            foreach (T item in entities)
            {
                _defaultContext.Set(typeof(T)).Attach(item);
            }
        }
    }
}