using System;
using System.Linq;
using System.Collections.Generic;
using ITIX.Domain.Model.Base;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using ITIX.Persistence.EntityFramework;
using ITIX.Persistence.Repositories;

namespace ITIX.Persistence.Repository.Base
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : EntityBase
    {

        private readonly IUnitOfWork unitOfWork; 

        public BaseRepository(DbContext context)
        {
            this.unitOfWork = new UnitOfWork(context);
        }

        public void AddOrUpdate(IEnumerable<T> entidades)
        {
            unitOfWork.Set<T>().AddOrUpdate(entidades.ToArray());
        }

        public void AddOrUpdate(T entidade)
        {
            unitOfWork.Set<T>().AddOrUpdate(entidade);
        }

        public IQueryable<T> All()
        {
            return unitOfWork.Set<T>();
        }

        public void Delete(IEnumerable<T> entidades)
        {
            if (entidades.Any())
                unitOfWork.Set<T>().RemoveRange(entidades);
        }

        public void Delete(T entidade)
        {
            unitOfWork.Set<T>().Remove(entidade);
        }

        public void Delete(int id)
        {
            var entidade = Get(id);
            if (entidade != null)
                Delete(entidade);
        }

        public T Get(int id)
        {
            return unitOfWork.Set<T>().Find(id);
        }

        public void Save()
        {
            unitOfWork.Save();
        }

        public void Dispose()
        {
            
        }
    }
}
