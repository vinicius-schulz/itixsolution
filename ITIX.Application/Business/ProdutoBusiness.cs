using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using ITIX.EntityFramework.Repository.Base;
using ITIX.EntityFramework.EntityFramework;
using ITIX.Core.Model.Base;

namespace ITIX.Application.Business
{
    public class ProdutoBusiness : BaseBusiness<ProdutoRepository<Produto>, Produto>
    {
        public ProdutoBusiness(ITIXDbContext context) : base(context)
        {
        }

        public ProdutoBusiness() : base(new ITIXDbContext())
        {
        }

        public Produto Save(int id, String nomeProduto, String descricao, double preco, double pesoBruto, double pesoLiquido)
        {
            Produto produto = new Produto { Id = id, Descricao = descricao, NomeProduto = nomeProduto, Preco = preco, PesoBruto = pesoBruto, PesoLiquido = pesoBruto };
            Validate(produto);
            this.Dao.AddOrUpdate(produto);
            this.Dao.Save();

            return produto;
        }

        public override void Validate(Produto entity)
        {
            if (entity.NomeProduto.Trim() == "")
            {
                throw new Exception("Nome do Produto em Branco.");
            }
        }

        public List<Produto> GetListOfProdutoByNomeProduto(String nomeProduto)
        {
            return this.Dao.All().Where(p => p.NomeProduto.Contains(nomeProduto)).ToList(); ;
        }

        public Produto GetProdutoByNomeProduto(String nomeProduto)
        {
            Produto produto = this.Dao.All().Where(p => p.NomeProduto == nomeProduto).ToList().FirstOrDefault();
            this.Dao.Detach(produto);
            return produto;
        }

        public List<String> GetAllNomesProdutos()
        {
            List<String> str = new List<string>();
            List<Produto> produtos = this.Dao.All().ToList();

            foreach(Produto item in produtos)
            {
                str.Add(item.NomeProduto);
            }
            return str;

        }

        protected override void LoadBusiness()
        {
        }
    }
}
