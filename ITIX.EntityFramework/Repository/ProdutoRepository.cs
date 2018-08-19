using ITIX.Core.Model;
using ITIX.Core.Model.Base;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITIX.EntityFramework.Repository
{
    public class ProdutoRepository<T> : BaseRepository<T> where T : Produto
    {
        public ProdutoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
