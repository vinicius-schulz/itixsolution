using ITIX.Core.Model;
using ITIX.Domain.Repositories;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.EntityFramework.Repository
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
