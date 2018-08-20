using ITIX.Domain.Model.Base;
using System;
using System.Collections.Generic;

namespace ITIX.Domain.Model
{
    public class Pedido : EntityBase
    {
        public double TotalGeral { get; set; }
        public double Desconto { get; set; }
        public double Subtotal { get; set; } 
        public string Comentario { get; set; }      

        public virtual List<ItemPedido> ItensPedido { get; set; }
    }
}
