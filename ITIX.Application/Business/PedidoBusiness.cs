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

        private ItemPedidoBusiness bnsItemPedido;

        public PedidoBusiness(ITIXDbContext context) : base(context)
        {
        }

        public PedidoBusiness() : base(new ITIXDbContext())
        {
        }

        public override void Validate(Pedido entity)
        {
            if (entity.Comentario.Trim() == "")
            {
                throw new Exception("Comentário em Branco.");
            }

        }

        public List<Pedido> GetByDescricao(String descricao)
        {
            return this.Dao.All().Where(p => p.Comentario.Contains(descricao)).ToList();
        }

        public Pedido Save(int id, string descricao, double total, double desconto, double subtotal, List<ItemPedido> itensPedido)
        {
            Pedido pedido = new Pedido { Id = id, Comentario = descricao, Desconto = desconto, ItensPedido = itensPedido, Subtotal = subtotal, TotalGeral = total };

            Validate(pedido);

            this.Dao.AddOrUpdate(pedido);
            this.Dao.Save();

            return pedido;
        }

        protected override void LoadBusiness()
        {
            bnsItemPedido = new ItemPedidoBusiness(this.Context);
        }
    }
}
