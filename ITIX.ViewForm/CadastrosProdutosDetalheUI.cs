using ITIX.Application.Business;
using ITIX.Core.Model;
using ITIX.ViewForm.Base;
using System;
using System.Windows.Forms;

namespace ITIX.ViewForm
{
    public partial class CadastrosProdutosDetalheUI : Form
    {
        public CadastrosProdutosDetalheUI()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoBusiness bns = new ProdutoBusiness();
                Produto produto = bns.Save(Convert.ToInt32(headerComponent.getTextBoxId().Text), textBoxNomeProduto.Text, textBoxDescricao.Text, Convert.ToDouble(textBoxPreco.Text), Convert.ToDouble(textBoxPesoBruto.Text), Convert.ToDouble(textBoxPesoLiquido.Text));
                headerComponent.getTextBoxId().Text = produto.Id.ToString();
                MessageBox.Show("Registro salvo com sucesso!");
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
