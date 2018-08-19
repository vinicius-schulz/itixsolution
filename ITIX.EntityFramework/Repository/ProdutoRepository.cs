using ITIX.Core.Model;
using ITIX.Core.Model.Base;
using ITIX.Domain.Repositories;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITIX.EntityFramework.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
