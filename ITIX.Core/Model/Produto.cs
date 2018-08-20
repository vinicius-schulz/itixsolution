using ITIX.Domain.Model.Base;
using System;
using System.Collections.Generic;

namespace ITIX.Domain.Model
{
    public class Produto : EntityBase
    {
        public string NomeProduto { get; set; }
        public double PesoBruto { get; set; }
        public double PesoLiquido { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public virtual List<ItemPedido> ItemPedidos { get; set; }
    }
}
