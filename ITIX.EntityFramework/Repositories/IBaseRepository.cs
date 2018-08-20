using ITIX.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.Persistence.Repositories
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        void AddOrUpdate(IEnumerable<T> entidades);
        void AddOrUpdate(T entidade);
        void Delete(IEnumerable<T> entidades);
        void Delete(T entidade);
        void Delete(int id);
        void Dispose();
        T Get(int id);
        IQueryable<T> All();
        void Save();
    }
}
