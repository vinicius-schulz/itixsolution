using ITIX.Application.Business;
using ITIX.Domain.Model;
using ITIX.ViewForm.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIX.ViewForm
{
    public partial class VendasPedidosVendaUI : Form
    {
        private readonly PedidoBusiness pedidoBusiness;

        public VendasPedidosVendaUI(PedidoBusiness pedidoBusiness)
        {
            InitializeComponent();
            this.pedidoBusiness = pedidoBusiness;
        }

        private void VendasPedidosVendaUI_Load(object sender, EventArgs e)
        {
            loadPedidosToGrid();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                foreach (DataGridViewRow row in this.dataGridViewPedidos.SelectedRows)
                {
                    pedidos.Add(row.DataBoundItem as Pedido);
                }

                pedidoBusiness.Delete(pedidos);
                foreach (Pedido item in pedidos)
                {
                    this.pedidoBindingSource.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            VendasPedidosVendaDetalhesUI form = CompositionRoot.Resolve<VendasPedidosVendaDetalhesUI>();
            form.ShowDialog();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var list = pedidoBusiness.GetByDescricao(textBoxDescricao.Text);
                loadGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadPedidosToGrid()
        {
            try
            {
                List<Pedido> list = pedidoBusiness.GetAll();
                loadGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadGrid(List<Pedido> list)
        {
            pedidoBindingSource.Clear();
            foreach (Pedido item in list)
            {
                pedidoBindingSource.Add(item);
            }
        }
    }
}
