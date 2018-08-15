using ITIX.Core.Model;
using ITIX.Core.Model.Base;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.EntityFramework.Repository
{
    public class PedidoRepository<T> : BaseRepository<T> where T : Pedido
    {
        public PedidoRepository(ITIXDbContext context) : base(context)
        {
        }
    }
}
