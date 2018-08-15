using ITIX.Core.Model.Base;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ITIX.EntityFramework.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        //DbContext DefaultContext { get; }

        void Save();
        Task SaveAsync();
        DbSet<T> Set<T>() where T : EntityBase;
        Database Database();
    }
}
