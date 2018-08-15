using ITIX.Core.Model;
using ITIX.EntityFramework.Mappings;
using System.Data.Entity;

namespace ITIX.EntityFramework.EntityFramework
{
    public class ITIXDbContext : DbContext
    {

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        public ITIXDbContext() : base("name=ITIX")
        {
            this.Configuration.ProxyCreationEnabled = true;
            //this.Configuration.LazyLoadingEnabled = true;
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new ItemPedidoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
    }
}
