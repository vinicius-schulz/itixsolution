using ITIX.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ITIX.Persistence.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        //DbContext DefaultContext { get; }

        void Save();
        DbSet<T> Set<T>() where T : EntityBase;
    }
}
