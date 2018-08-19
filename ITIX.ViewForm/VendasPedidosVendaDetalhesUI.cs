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
    public partial class VendasPedidosVendaDetalhesUI : Form
    {

        private readonly PedidoBusiness pedidoBusiness;
        private readonly ItemPedidoBusiness itemPedidoBusiness;
        private readonly ProdutoBusiness produtoBusiness;

        public VendasPedidosVendaDetalhesUI(PedidoBusiness pedidoBusiness, ItemPedidoBusiness itemPedidoBusiness, ProdutoBusiness produtoBusiness)
        {
            InitializeComponent();
            this.pedidoBusiness = pedidoBusiness;
            this.itemPedidoBusiness = itemPedidoBusiness;
            this.produtoBusiness = produtoBusiness;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ItemPedido> itensPedido = new List<ItemPedido>();
                foreach (DataGridViewRow row in this.dataGridViewItensPedido.Rows)
                {
                    if (row.DataBoundItem as ItemPedido != null)
                    {
                        itensPedido.Add(row.DataBoundItem as ItemPedido);
                    }
                }

                Pedido pedido = pedidoBusiness.Save(Convert.ToInt32(headerComponent.getTextBoxId().Text),
                    richTextBoxDescricao.Text,
                    textBoxTotal.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxTotal.Text),
                    textBoxDesconto.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxDesconto.Text),
                    textBoxSubTotal.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxSubTotal.Text),
                    itensPedido);
                headerComponent.getTextBoxId().Text = pedido.Id.ToString();
                MessageBox.Show(this, "Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendasPedidosVendaDetalhesUI_Load(object sender, EventArgs e)
        {
            loadEvents();
        }

        private void loadEvents()
        {
            this.footerComponent.getbuttonSalvar().Click += new System.EventHandler(this.buttonSalvar_Click);
            this.footerComponent.getButtonSair().Click += new System.EventHandler(this.buttonSair_Click);
        }

        private void dataGridViewItensPedido_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido) != null)
            {
                if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).Produto == null)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridViewItensPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            String sCellName = dataGridViewItensPedido.Columns[dataGridViewItensPedido.CurrentCell.ColumnIndex].HeaderText;

            if (sCellName == "PrecoUnitario" || sCellName == "Quantidade" || sCellName == "Desconto")
            {
                DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
                if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
                {
                    e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                    e.Handled = s.Text.Contains(e.KeyChar);
                }
                else
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }

        private void dataGridViewItensPedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            String sCellName = dataGridViewItensPedido.Columns[dataGridViewItensPedido.CurrentCell.ColumnIndex].HeaderText;

            if (sCellName == "Nome do Produto")
            {
                AutoCompleteStringCollection acBusIDSorce = new AutoCompleteStringCollection();
                List<String> nomes = produtoBusiness.GetAllNomesProdutos();
                acBusIDSorce.AddRange(nomes.ToArray());

                TextBox txtBusID = e.Control as TextBox;
                if (txtBusID != null)
                {
                    txtBusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtBusID.AutoCompleteCustomSource = acBusIDSorce;
                    txtBusID.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
            }

            if (sCellName == "PrecoUnitario" || sCellName == "Quantidade" || sCellName == "Desconto")
            //if (dataGridViewItensPedido.CurrentCell.ColumnIndex == 3 || dataGridViewItensPedido.CurrentCell.ColumnIndex == 4 || dataGridViewItensPedido.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                e.Control.KeyPress -= dataGridViewItensPedido_KeyPress;
                e.Control.KeyPress += dataGridViewItensPedido_KeyPress;
            }
        }

        private void dataGridViewItensPedido_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            String sCellName = dataGridViewItensPedido.Columns[dataGridViewItensPedido.CurrentCell.ColumnIndex].HeaderText;

            if (sCellName == "Nome do Produto")
            {
                Produto produto = produtoBusiness.GetProdutoByNomeProduto(e.FormattedValue.ToString());

                if (produto != null)
                {
                    (dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).Produto = produto;
                }
                else
                {
                    if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido) != null)
                    {
                        (dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).Produto = null;
                    }
                }
            }
        }


        private void dataGridViewItensPedido_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            String sCellName = dataGridViewItensPedido.Columns[dataGridViewItensPedido.CurrentCell.ColumnIndex].HeaderText;

            if (sCellName == "Nome do Produto")
            {
                if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido) != null)
                {
                    if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).Produto == null)
                    {
                        dataGridViewItensPedido.CurrentCell.Value = "";
                    }
                }
                else
                {
                    dataGridViewItensPedido.CurrentCell.Value = "";
                }
            }

            if ((dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido) != null)
            {
                //if (dataGridViewItensPedido.CurrentCell.ColumnIndex == 3 || dataGridViewItensPedido.CurrentCell.ColumnIndex == 4 || dataGridViewItensPedido.CurrentCell.ColumnIndex == 5)
                if (sCellName == "PrecoUnitario" || sCellName == "Quantidade" || sCellName == "Desconto")
                {
                    ItemPedido item = (dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido);
                    (dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).ValorTotal = itemPedidoBusiness.CalculateValorTotal(item);
                    (dataGridViewItensPedido.Rows[e.RowIndex].DataBoundItem as ItemPedido).SubTotal = itemPedidoBusiness.CalculateSubTotal(item);
                }
            }
        }

        private void dataGridViewItensPedido_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            List<ItemPedido> itensPedido = new List<ItemPedido>();
            foreach (DataGridViewRow row in this.dataGridViewItensPedido.Rows)
            {
                if (row.DataBoundItem as ItemPedido != null)
                {
                    itensPedido.Add(row.DataBoundItem as ItemPedido);
                }
            }

            if (itensPedido.Count > 0)
            {
                this.textBoxSubTotal.Text = itemPedidoBusiness.CalculateSubTotalGeral(itensPedido).ToString();
                this.textBoxTotal.Text = itemPedidoBusiness.CalculateValorTotalGeral(itensPedido).ToString();
                this.textBoxDesconto.Text = itemPedidoBusiness.CalculateDescontoGeral(itensPedido).ToString();
            }
        }
    }
}
