using ITIX.Domain.Model;
using ITIX.Persistence.EntityFramework;
using ITIX.Persistence.Repositories;
using ITIX.Persistence.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.Persistence.Repository
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
