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

namespace ITIX.View
{
    public partial class CadastrosProdutosUI : DevExpress.XtraEditors.XtraForm
    {
        public CadastrosProdutosUI()
        {
            InitializeComponent();
        }

        private void simpleButtonFiltrar_Click(object sender, EventArgs e)
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
            //    ProdutoBusiness produtoBusiness = new ProdutoBusiness();
            //    List<Produto> produtos = produtoBusiness.ListarProdutos(textEditNome.Text, textEditSKU.Text);
            //    e.Result = produtos;
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
                List<Produto> produtos = (List<Produto>)e.Result;
                this.produtoBindingSource.Clear();

                foreach (Produto item in produtos)
                {
                    this.produtoBindingSource.Add(item);
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
    }
}