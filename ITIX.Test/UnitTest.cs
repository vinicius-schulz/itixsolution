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
            ProdutoBusiness bnsProduto = new ProdutoBusiness();

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
    }
}
