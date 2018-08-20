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
    public class PedidoBusinessUnitTest
    {
        [TestMethod]
        public void Test_Criacao_Pedido_Bem_Sucedido()
        {
            //arrange
            int id = 0;
            string comentario = "Pedido 1";
            double desconto = 5;
            double subTotal = 10;
            double totalGeral = 15;
            List<ItemPedido> itensPedido = Substitute.For<List<ItemPedido>>();

            //act
            Pedido pedido = new Pedido { Id = id, Comentario = comentario, Desconto = desconto, Subtotal = subTotal, TotalGeral = totalGeral , ItensPedido = itensPedido };

            //assert:
            Assert.IsNotNull(pedido);
            Assert.IsTrue(pedido.Comentario == comentario);
            Assert.IsTrue(pedido.Desconto == desconto);
            Assert.IsTrue(pedido.Subtotal == subTotal);
            Assert.IsTrue(pedido.TotalGeral == totalGeral);
        }

        [TestMethod]
        public void Test_Save_Bem_Sucedido()
        {
            // arrange
            var pedidoRepository = Substitute.For<IPedidoRepository>();
            var produtoRepository = Substitute.For<IProdutoRepository>();
            PedidoBusiness bnsPedido = new PedidoBusiness(pedidoRepository,produtoRepository);
            int id = 0;
            string comentario = "Pedido 1";
            double desconto = 5;
            double subTotal = 10;
            double totalGeral = 15;
            List<ItemPedido> itensPedido = Substitute.For<List<ItemPedido>>();

            // act
            var pedido = bnsPedido.Save(id, comentario, totalGeral, desconto, subTotal, itensPedido);

            // assert
            Assert.IsNotNull(pedido);
            Assert.IsTrue(pedido.Comentario == comentario);
            Assert.IsTrue(pedido.Desconto == desconto);
            Assert.IsTrue(pedido.Subtotal == subTotal);
            Assert.IsTrue(pedido.TotalGeral == totalGeral);

        }

        [TestMethod]
        public void Test_Save_Falha()
        {
            // arrange
            var pedidoRepository = Substitute.For<IPedidoRepository>();
            var produtoRepository = Substitute.For<IProdutoRepository>();
            PedidoBusiness bnsPedido = new PedidoBusiness(pedidoRepository, produtoRepository);
            int id = 0;
            string comentario = "";
            double desconto = 5;
            double subTotal = 10;
            double totalGeral = 15;
            List<ItemPedido> itensPedido = Substitute.For<List<ItemPedido>>();
            
            // act / assert
            Assert.ThrowsException<Exception>(() => bnsPedido.Save(id, comentario, totalGeral, desconto, subTotal, itensPedido));
        }

        [TestMethod]
        public void Test_GetByDescricao_Com_Retorno()
        {
            //arrange
            var pedidoRepository = Substitute.For<IPedidoRepository>();

            int id = 0;
            string comentario = "Pedido 1";
            double desconto = 5;
            double subTotal = 10;
            double totalGeral = 15;
            List<ItemPedido> itensPedido = Substitute.For<List<ItemPedido>>();
            Pedido pedido = new Pedido { Id = id, Comentario = comentario, Desconto = desconto, Subtotal = subTotal, TotalGeral = totalGeral, ItensPedido = itensPedido };

            List<Pedido> pedidos = new List<Pedido>();
            pedidos.Add(pedido);

            pedidoRepository.All().Returns(pedidos.AsQueryable());
            var produtoRepository = Substitute.For<IProdutoRepository>();

            PedidoBusiness bnsPedido = new PedidoBusiness(pedidoRepository, produtoRepository);

            //act
            var result = bnsPedido.GetByDescricao("Pedido 1");

            //assert
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault().Comentario == comentario);
        }
    }
}
