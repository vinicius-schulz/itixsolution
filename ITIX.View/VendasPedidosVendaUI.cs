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
using ITIX.Application.Business;
using ITIX.Core.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ITIX.View
{
    public partial class VendasPedidosVendaUI : DevExpress.XtraEditors.XtraForm
    {
        public VendasPedidosVendaUI()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            dateEditDataInicial.DateTime = startDate;

            var endDate = startDate.AddMonths(1).AddDays(-1);
            dateEditDataFinal.DateTime = endDate;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerFiltrar.IsBusy)
            {
                //backgroundWorkerFiltrar.CancelAsync();
            }
            else
            {
                progressPanel.Caption = "Aguarde";
                progressPanel.Description = "Carregando ...";
                progressPanel.Visible = true;
                backgroundWorkerFiltrar.RunWorkerAsync();
            }
        }

        private void backgroundWorkerFiltrar_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            //    PedidoBusiness pedidoBusiness = new PedidoBusiness();
            //    List<Pedido> pedidos = pedidoBusiness.ListarPedidos(textEditNumeroPedido.Text, dateEditDataInicial.Text, dateEditDataFinal.Text);
            //    e.Result = pedidos;
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}
        }

        private void backgroundWorkerFiltrar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<Pedido> pedidos = (List<Pedido>)e.Result;
                this.pedidoBindingSource.Clear();

                foreach (Pedido item in pedidos)
                {
                    this.pedidoBindingSource.Add(item);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                this.progressPanel.Visible = false;
            }
        }

        private void gridViewPedidos_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                OpenForm(gridViewPedidos.GetRow(info.RowHandle) as Pedido);
            }
        }

        private void OpenForm(Pedido pedido)
        {
            VendasPedidosVendaDetalhesUI f = new VendasPedidosVendaDetalhesUI(pedido);
            f.Text = pedido.Id.ToString();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void repositoryItemButtonEditActionDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Deseja excluir este pedido de venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    PedidoBusiness pedidoBusiness = new PedidoBusiness();
                    var row = (Pedido)gridViewPedidos.GetFocusedRow();
                    pedidoBusiness.Delete(row);
                    pedidoBindingSource.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButtonExcluir_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Deseja excluir estes pedidos de venda?", "Confirmação", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    PedidoBusiness pedidoBusiness = new PedidoBusiness();
                    foreach (int i in gridViewPedidos.GetSelectedRows())
                    {
                        Pedido row = (Pedido)gridViewPedidos.GetRow(i);
                        pedidoBusiness.Delete(row);
                    }

                    for (int i = gridViewPedidos.GetSelectedRows().Length -1; i >=0; i--)
                    {
                        pedidoBindingSource.RemoveAt(gridViewPedidos.GetSelectedRows()[i]);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}