using ITIX.Application.Business.Base;
using ITIX.Domain.Model;
using ITIX.Persistence.EntityFramework;
using ITIX.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITIX.Application.Business
{
    public class ItemPedidoBusiness : BaseBusiness
    {
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
