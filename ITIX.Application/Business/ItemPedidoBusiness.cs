using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ITIX.Application.Business
{
    public class ItemPedidoBusiness : BaseBusiness<ItemPedidoRepository<ItemPedido>, ItemPedido>
    {

        public ItemPedidoBusiness(ITIXDbContext context) : base(context)
        {
        }

        public ItemPedidoBusiness() : base(new ITIXDbContext())
        {

        }

        public override void Validate(ItemPedido entity)
        {
            
        }

        protected override void LoadBusiness()
        {
            
        }
    }
}
