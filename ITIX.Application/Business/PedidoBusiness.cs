using ITIX.Application.Business.Base;
using ITIX.Core.Model;
using ITIX.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using ITIX.EntityFramework.EntityFramework;
using System.Data.Entity;
using ITIX.Domain.Repositories;

namespace ITIX.Application.Business
{
    public class PedidoBusiness
    {

        private ItemPedidoBusiness bnsItemPedido;
        private readonly IPedidoRepository PedidoRepository;
        private readonly IProdutoRepository ProdutoRepository;


        public PedidoBusiness(IPedidoRepository pedidoRepository, IProdutoRepository produtoRepository)
        {
            this.PedidoRepository = pedidoRepository;
            this.ProdutoRepository = produtoRepository;
        }

        public void Validate(Pedido entity)
        {
            if (entity.Comentario.Trim() == "")
            {
                throw new Exception("Comentário em Branco.");
            }

        }

        public List<Pedido> GetByDescricao(String descricao)
        {
            return this.PedidoRepository.All().Where(p => p.Comentario.Contains(descricao)).ToList();
        }

        public void Delete(List<Pedido> pedidos)
        {
            this.PedidoRepository.Delete(pedidos);
            this.PedidoRepository.Save();
        }

        public Pedido Save(int id, string descricao, double total, double desconto, double subtotal, List<ItemPedido> itensPedido)
        {
            Pedido pedido = new Pedido { Id = id, Comentario = descricao, Desconto = desconto, ItensPedido = itensPedido, Subtotal = subtotal, TotalGeral = total };

            Validate(pedido);

            foreach (ItemPedido item in pedido.ItensPedido)
            {
                item.Produto = this.ProdutoRepository.All().FirstOrDefault(p => p.NomeProduto == item.Produto.NomeProduto);
            }

            this.PedidoRepository.AddOrUpdate(pedido);
            this.PedidoRepository.Save();

            return pedido;
        }

        public List<Pedido> GetAll()
        {
            return this.PedidoRepository.All().ToList();
        }
    }
}
