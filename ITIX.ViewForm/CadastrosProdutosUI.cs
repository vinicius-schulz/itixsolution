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
    public partial class CadastrosProdutosUI : Form
    {
        private ProdutoBusiness bns;

        public CadastrosProdutosUI()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var list = bns.GetByNomeProduto(textBoxNomeProduto.Text);
                loadGrid(list);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                List<Produto> produtos = new List<Produto>();
                foreach(DataGridViewRow row in this.dataGridViewProdutos.SelectedRows)
                {
                    produtos.Add(row.DataBoundItem as Produto);
                }

                bns.Delete(produtos);
                foreach (Produto item in produtos)
                {
                    this.produtoBindingSource.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCriarProduto_Click(object sender, EventArgs e)
        {
            CadastrosProdutosDetalheUI form = new CadastrosProdutosDetalheUI();
            form.ShowDialog();
        }

        private void CadastrosProdutosUI_Load(object sender, EventArgs e)
        {
            loadBusiness();
            loadProdutosToGrid();
        }

        private void loadBusiness()
        {
            this.bns = new ProdutoBusiness();
        }

        private void loadProdutosToGrid()
        {
            try
            {
                var list = bns.Get();
                loadGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadGrid(List<Produto> list)
        {
            produtoBindingSource.Clear();
            foreach (Produto item in list)
            {
                produtoBindingSource.Add(item);
            }
        }
    }
}
