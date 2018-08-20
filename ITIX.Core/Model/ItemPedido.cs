using ITIX.Domain.Model.Base;
using System;
using System.Collections.Generic;

namespace ITIX.Domain.Model
{
    public class ItemPedido : EntityBase
    {
        public double PrecoUnitario { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public double SubTotal { get; set; }
        public double ValorTotal { get; set; }

        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
