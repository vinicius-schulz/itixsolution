using ITIX.Application.Business;
using ITIX.Persistence.Repositories;
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
    public partial class Main : Form
    {
        private readonly PedidoBusiness pedidoBusiness;

        public Main(PedidoBusiness pedidoBusiness)
        {
            this.pedidoBusiness = pedidoBusiness;
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrosProdutosUI form = CompositionRoot.Resolve<CadastrosProdutosUI>();
            if (!CheckForDuplicate(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private bool CheckForDuplicate(Form newForm)
        {
            bool bValue = false;
            foreach (Form fm in this.MdiChildren)
            {
                if (fm.GetType() == newForm.GetType())
                {
                    fm.Activate();
                    //fm.WindowState = FormWindowState.Maximized;
                    bValue = true;
                }
            }
            return bValue;
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendasPedidosVendaUI form = CompositionRoot.Resolve<VendasPedidosVendaUI>();
            if (!CheckForDuplicate(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
