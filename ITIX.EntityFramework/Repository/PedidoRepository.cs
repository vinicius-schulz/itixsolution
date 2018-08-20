using ITIX.Domain.Model;
using ITIX.Domain.Model.Base;
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
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
