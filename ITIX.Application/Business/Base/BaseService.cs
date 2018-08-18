using ITIX.Core.Model.Base;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ITIX.Application.Business.Base
{
    public abstract class BaseBusiness<T, K> where T : BaseRepository<K> where K : EntityBase
    {
        protected T Dao { get; set; }
        protected readonly ITIXDbContext Context;

        public BaseBusiness(ITIXDbContext context)
        {
            this.Context = context;
            this.Dao = (T)Activator.CreateInstance(typeof(T), new Object[] { this.Context });
            LoadBusiness();
        }

        public void AddOrUpdate(IEnumerable<K> entidades)
        {
            this.Dao.AddOrUpdate(entidades);
            this.Dao.Save();
        }
        public void AddOrUpdate(K entidade)
        {
            this.Dao.AddOrUpdate(entidade);
            this.Dao.Save();
        }
        public void Delete(IEnumerable<K> entidades)
        {
            this.Dao.Delete(entidades);
            this.Dao.Save();
        }
        public void Delete(K entidade)
        {
            this.Dao.Delete(entidade);
            this.Dao.Save();
        }

        public void Delete(int id)
        {
            this.Dao.Delete(id);
            this.Dao.Save();
        }

        public K Get(int id)
        {
            return this.Dao.Get(id);
        }

        public List<K> GetAll()
        {
            return this.Dao.All().ToList();
        }

        public abstract void Validate(K entity);
        protected abstract void LoadBusiness();
    }
}
