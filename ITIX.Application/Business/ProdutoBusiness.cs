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

        protected override void Validate(Produto entity)
        {
            if (entity.NomeProduto.Trim() == "")
            {
                throw new Exception("Nome do Produto em Branco.");
            }
        }
    }
}
