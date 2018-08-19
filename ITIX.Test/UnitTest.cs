using System;
using ITIX.Application.Business;
using ITIX.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ITIX.Test
{
    [TestClass]
    public class UnitTest
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
        public void Test_Save_Produto_Bem_Sucedido()
        {
            ProdutoBusiness bnsProduto = new ProdutoBusiness();

            //arrange
            int id = 0;
            string descricao = "Produto orgânico";
            string nomeProduto = "Maçã Orgânica";
            double pesoBruto = 0.3;
            double pesoLiquido = 0.25;
            double preco = 1;

            //act
            Produto produto = bnsProduto.Save(id, nomeProduto, descricao, preco, pesoBruto, pesoLiquido);

            //assert:
            Assert.IsNotNull(produto);
            Assert.IsFalse(produto.Id == id);
            Assert.IsTrue(produto.Descricao == descricao);
            Assert.IsTrue(produto.NomeProduto == nomeProduto);
            Assert.IsTrue(produto.PesoBruto == pesoBruto);
            Assert.IsTrue(produto.PesoLiquido == pesoLiquido);
            Assert.IsTrue(produto.Preco == preco);
        }
    }
}
