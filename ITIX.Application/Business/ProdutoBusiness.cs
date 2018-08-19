﻿using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using ITIX.EntityFramework.Repository.Base;
using ITIX.EntityFramework.EntityFramework;
using ITIX.Core.Model.Base;
using ITIX.Domain.Repositories;

namespace ITIX.Application.Business
{
    public class ProdutoBusiness
    {
        private readonly IProdutoRepository produtoRepository;
        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public Produto Save(int id, String nomeProduto, String descricao, double preco, double pesoBruto, double pesoLiquido)
        {
            Produto produto = new Produto { Id = id, Descricao = descricao, NomeProduto = nomeProduto, Preco = preco, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido };
            Validate(produto);
            this.produtoRepository.AddOrUpdate(produto);
            this.produtoRepository.Save();

            return produto;
        }

        public void Validate(Produto entity)
        {
            if (entity.NomeProduto.Trim() == "")
            {
                throw new Exception("Nome do Produto em Branco.");
            }
        }

        public List<Produto> GetListOfProdutoByNomeProduto(String nomeProduto)
        {
            return this.produtoRepository.All().Where(p => p.NomeProduto.Contains(nomeProduto)).ToList(); ;
        }

        public Produto GetProdutoByNomeProduto(String nomeProduto)
        {
            return this.produtoRepository.All().FirstOrDefault(p => p.NomeProduto == nomeProduto);
        }

        public List<String> GetAllNomesProdutos()
        {
            return this.produtoRepository.All().Select(p => p.NomeProduto).ToList();
        }

        public void Delete(List<Produto> produtos)
        {
            this.produtoRepository.Delete(produtos);
            this.produtoRepository.Save();
        }

        public List<Produto> GetAll()
        {
            return produtoRepository.All().ToList();
        }
    }
}
