using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository;
using System;
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

        public double CalculateValorTotal(ItemPedido itemPedido)
        {
            return itemPedido.PrecoUnitario * itemPedido.Quantidade - itemPedido.Desconto;
        }

        public double CalculateSubTotal(ItemPedido itemPedido)
        {
            return itemPedido.PrecoUnitario * itemPedido.Quantidade;
        }

        public double CalculateSubTotalGeral(List<ItemPedido> itensPedido)
        {
            double result = 0;
            foreach (ItemPedido item in itensPedido)
            {
                result += item.SubTotal;
            }
            return result;
        }

        public double CalculateValorTotalGeral(List<ItemPedido> itensPedido)
        {
            double result = 0;
            foreach (ItemPedido item in itensPedido)
            {
                result += item.ValorTotal;
            }
            return result;
        }

        public double CalculateDescontoGeral(List<ItemPedido> itensPedido)
        {
            double result = 0;
            foreach (ItemPedido item in itensPedido)
            {
                result += item.Desconto;
            }
            return result;
        }
    }
}
