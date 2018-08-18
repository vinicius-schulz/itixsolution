using ITIX.Application.Business;
using ITIX.Core.Model;
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
        private PedidoBusiness bns;

        public VendasPedidosVendaUI()
        {
            InitializeComponent();
        }

        private void VendasPedidosVendaUI_Load(object sender, EventArgs e)
        {
            loadBusiness();
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

                bns.Delete(pedidos);
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
            VendasPedidosVendaDetalhesUI form = new VendasPedidosVendaDetalhesUI();
            form.ShowDialog();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var list = bns.GetByDescricao(textBoxDescricao.Text);
                loadGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadBusiness()
        {
            this.bns = new PedidoBusiness();
        }

        private void loadPedidosToGrid()
        {
            try
            {
                var list = bns.GetAll();
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
