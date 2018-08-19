using ITIX.Application.Business;
using ITIX.Core.Model;
using ITIX.Domain.Repositories;
using ITIX.EntityFramework.EntityFramework;
using ITIX.EntityFramework.Repository;
using ITIX.EntityFramework.Repository.Base;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIX.ViewForm.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            //Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            Bind(typeof(IPedidoRepository)).To(typeof(PedidoRepository));
            Bind(typeof(IProdutoRepository)).To(typeof(ProdutoRepository));
            Bind(typeof(IItemPedidoRepository)).To(typeof(ItemPedidoRepository));
            Bind(typeof(PedidoBusiness)).ToSelf();
            Bind(typeof(ProdutoBusiness)).ToSelf();
            Bind(typeof(ItemPedidoBusiness)).ToSelf();
            Bind(typeof(CadastrosProdutosDetalheUI)).ToSelf();
            Bind(typeof(CadastrosProdutosUI)).ToSelf();
            Bind(typeof(VendasPedidosVendaDetalhesUI)).ToSelf();
            Bind(typeof(VendasPedidosVendaUI)).ToSelf();
            Bind(typeof(ITIXDbContext)).ToSelf().InSingletonScope();
        }
    }
}

