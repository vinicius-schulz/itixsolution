using ITIX.Core.Model.Base;
using System;
using System.Collections.Generic;
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
        void Detach<T>(List<T> entities) where T : EntityBase;
        void Detach<T>(T entity) where T : EntityBase;
        void Attach<T>(T entity) where T : EntityBase;
        void Attach<T>(List<T> entities) where T : EntityBase;
    }
}
