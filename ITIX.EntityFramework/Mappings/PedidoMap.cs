using ITIX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.Persistence.Mappings
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");
            HasKey(x => x.Id).Property(x => x.Id).HasColumnName("Id");

            //muitos para um - ItemPedidos
            HasMany(x => x.ItensPedido).WithRequired(x => x.Pedido).HasForeignKey(x => x.IdPedido).WillCascadeOnDelete(true);
        }
    }
}
