using System;
using System.Collections.Generic;
using System.Linq;
using ITIX.Application.Business;
using ITIX.Domain.Model;
using ITIX.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ITIX.Test
{
    [TestClass]
    public class ProdutoBusinessUnitTest
    {
        [TestMethod]
        public void Test_Criacao_Produto_Bem_Sucedida()
        {
            //arrange
            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;

            //act
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };

            //assert:
            Assert.IsNotNull(produto);
            Assert.IsTrue(produto.Descricao == descricao);
            Assert.IsTrue(produto.NomeProduto == nomeProduto);
            Assert.IsTrue(produto.PesoBruto == pesoBruto);
            Assert.IsTrue(produto.PesoLiquido == pesoLiquido);
            Assert.IsTrue(produto.Preco == preco);
        }

        [TestMethod]
        public void Test_Save_Bem_Sucedido()
        {
            // arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);
            int id = 0;
            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;

            // act
            var produto = bnsProduto.Save(id, nomeProduto, descricao, preco, pesoBruto, pesoLiquido);

            // assert
            Assert.IsNotNull(produto);
            Assert.IsTrue(produto.Descricao == descricao);
            Assert.IsTrue(produto.NomeProduto == nomeProduto);
            Assert.IsTrue(produto.PesoBruto == pesoBruto);
            Assert.IsTrue(produto.PesoLiquido == pesoLiquido);
            Assert.IsTrue(produto.Preco == preco);
           
        }

        [TestMethod]
        public void Test_Save_Falha()
        {
            // arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);
            int id = 0;
            string descricao = "Produto orgânico";
            string nomeProduto = "";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            
            // act / assert
            Assert.ThrowsException<Exception>(()=>bnsProduto.Save(id, nomeProduto, descricao, preco, pesoBruto, pesoLiquido));
        }

        [TestMethod]
        public void Test_GetListOfProdutoByNomeProduto_Com_Retorno()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();
            
            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(produto);

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetListOfProdutoByNomeProduto("Orgâ");

            //assert
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault().NomeProduto == nomeProduto);
        }

        [TestMethod]
        public void Test_GetListOfProdutoByNomeProduto_Sem_Retorno()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();

            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(produto);

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetListOfProdutoByNomeProduto("taioba");

            //assert
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void Test_GetProdutoByNomeProduto_Com_Retorno()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();

            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(produto);

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetProdutoByNomeProduto("Maçã Orgânica");

            //assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Descricao == descricao);
            Assert.IsTrue(result.NomeProduto == nomeProduto);
            Assert.IsTrue(result.PesoBruto == pesoBruto);
            Assert.IsTrue(result.PesoLiquido == pesoLiquido);
            Assert.IsTrue(result.Preco == preco);
        }

        [TestMethod]
        public void Test_GetProdutoByNomeProduto_Sem_Retorno()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();

            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(produto);

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetProdutoByNomeProduto("Maçã");

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestGetAllNomesProdutos_Com_Registro()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();

            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;
            Produto produto = new Produto { Descricao = descricao, NomeProduto = nomeProduto, PesoBruto = pesoBruto, PesoLiquido = pesoLiquido, Preco = preco };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(produto);

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetAllNomesProdutos();

            //assert
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault() == nomeProduto);
        }

        [TestMethod]
        public void TestGetAllNomesProdutos_Sem_Registro()
        {
            //arrange
            var produtoRepository = Substitute.For<IProdutoRepository>();
            List<Produto> produtos = new List<Produto>();

            produtoRepository.All().Returns(produtos.AsQueryable());
            ProdutoBusiness bnsProduto = new ProdutoBusiness(produtoRepository);

            //act
            var result = bnsProduto.GetAllNomesProdutos();

            //assert
            Assert.IsTrue(result.Count == 0);
        }
    }
}
