using ITIX.Domain.Model;
using ITIX.Domain.Model.Base;
using ITIX.Persistence.EntityFramework;
using ITIX.Persistence.Repositories;
using ITIX.Persistence.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITIX.Persistence.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
