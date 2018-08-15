using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITIX.Core.Model;
using DevExpress.Entity.Model.Metadata;

namespace ITIX.View
{
    public partial class VendasPedidosVendaDetalhesUI : DevExpress.XtraEditors.XtraForm
    {
        private Pedido pedido;

        public VendasPedidosVendaDetalhesUI()
        {
            InitializeComponent();
        }

        public VendasPedidosVendaDetalhesUI(Pedido _pedido)
        {
            InitializeComponent();
            this.pedido = _pedido;
            loadForm();
        }

        private void loadForm()
        {
            this.memoEditComentario.Text = this.pedido.Comentario;
            this.textEditDesconto.Text = this.pedido.Desconto.ToString();
            this.textEditSubTotal.Text = this.pedido.Subtotal.ToString();
            this.textEditTotal.Text = this.pedido.TotalGeral.ToString();

            loadItensPedido();
        }

        private void loadItensPedido()
        {
            this.itemPedidoBindingSource.Clear();
            if (pedido.ItensPedido != null)
            {
                foreach (ItemPedido item in pedido.ItensPedido)
                {
                    this.itemPedidoBindingSource.Add(item);
                }
            }
        }

        private void simpleButtonImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorkerImprimir_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorkerImprimir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void gridViewItensPedidoDTO_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
}