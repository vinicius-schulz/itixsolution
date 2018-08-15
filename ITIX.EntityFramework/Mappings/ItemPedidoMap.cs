using ITIX.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.EntityFramework.Mappings
{
    public class ItemPedidoMap : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMap()
        {
            ToTable("ItemPedido");
            HasKey(x => x.Id).Property(x => x.Id).HasColumnName("Id");

            //um pra muitos
            HasRequired(x => x.Produto).WithMany(x => x.ItemPedidos).HasForeignKey(x => x.IdProduto).WillCascadeOnDelete(true);

        }
    }
}
