using System;
using System.Linq;
using System.Collections.Generic;
using ITIX.Core.Model.Base;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using ITIX.EntityFramework.EntityFramework;
using ITIX.Domain.Repositories;

namespace ITIX.EntityFramework.Repository.Base
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

        public void ExecuteSql(string sql)
        {
            unitOfWork.Database().ExecuteSqlCommand(sql);
        }

        public T Get(int id)
        {
            return unitOfWork.Set<T>().Find(id);
        }

        public void Save()
        {
            unitOfWork.Save();
        }

        public Task SaveAsync()
        {
            return unitOfWork.SaveAsync();
        }

        public void Dispose()
        {
            
        }

        public void Detach(List<T> result)
        {
            unitOfWork.Detach(result);
        }

        public void Detach(T entity)
        {
            unitOfWork.Detach(entity);
        }

        public void Attach(T entity)
        {
            unitOfWork.Attach(entity);
        }

        public void Attach(List<T> entities)
        {
            unitOfWork.Attach(entities);
        }
    }
}
