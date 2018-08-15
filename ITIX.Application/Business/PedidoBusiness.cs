using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using ITIX.EntityFramework.EntityFramework;

namespace ITIX.Application.Business
{
    public class PedidoBusiness : BaseBusiness<PedidoRepository<Pedido>, Pedido>
    {

        public PedidoBusiness(ITIXDbContext context) : base(context)
        {
        }

        public PedidoBusiness() : base(new ITIXDbContext())
        {
        }

        protected override void Validate(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
