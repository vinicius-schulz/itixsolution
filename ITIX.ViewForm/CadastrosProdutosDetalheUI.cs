using ITIX.Application.Business;
using ITIX.Core.Model;
using System;
using System.Windows.Forms;

namespace ITIX.ViewForm
{
    public partial class CadastrosProdutosDetalheUI : Form
    {
        private ProdutoBusiness bns;

        public CadastrosProdutosDetalheUI()
        {
            InitializeComponent();
        }

        private void loadBusiness()
        {
            this.bns = new ProdutoBusiness();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = bns.Save(Convert.ToInt32(headerComponent.getTextBoxId().Text), textBoxNomeProduto.Text, textBoxDescricao.Text, textBoxPreco.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxPreco.Text), textBoxPesoBruto.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxPesoBruto.Text), textBoxPesoLiquido.Text.Trim() == "" ? 0 : Convert.ToDouble(textBoxPesoLiquido.Text));
                headerComponent.getTextBoxId().Text = produto.Id.ToString();
                MessageBox.Show(this, "Registro salvo com sucesso!");
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CadastrosProdutosDetalheUI_Load(object sender, EventArgs e)
        {
            loadBusiness();
            loadEvents();
        }

        private void loadEvents()
        {
            this.footerComponent.getbuttonSalvar().Click += new System.EventHandler(this.buttonSalvar_Click);
            this.footerComponent.getButtonEditar().Click += new System.EventHandler(this.buttonEditar_Click);
            this.footerComponent.getButtonSair().Click += new System.EventHandler(this.buttonSair_Click);
        }
    }
}
