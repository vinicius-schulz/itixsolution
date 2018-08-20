namespace ITIX.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecoUnitario = c.Double(nullable: false),
                        Quantidade = c.Double(nullable: false),
                        Desconto = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        IdPedido = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.IdPedido, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.IdProduto, cascadeDelete: true)
                .Index(t => t.IdPedido)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalGeral = c.Double(nullable: false),
                        Desconto = c.Double(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        Comentario = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(unicode: false),
                        PesoBruto = c.Double(nullable: false),
                        PesoLiquido = c.Double(nullable: false),
                        Preco = c.Double(nullable: false),
                        Descricao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPedido", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.ItemPedido", "IdPedido", "dbo.Pedido");
            DropIndex("dbo.ItemPedido", new[] { "IdProduto" });
            DropIndex("dbo.ItemPedido", new[] { "IdPedido" });
            DropTable("dbo.Produto");
            DropTable("dbo.Pedido");
            DropTable("dbo.ItemPedido");
        }
    }
}
