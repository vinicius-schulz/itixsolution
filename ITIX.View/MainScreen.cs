using ITIX.Application.Business;
using ITIX.Core.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ITIX.View
{
    public partial class MainScreen : DevExpress.XtraEditors.XtraForm
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void barButtonItemProdutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CadastrosProdutosUI form = new CadastrosProdutosUI();
            if (!CheckForDuplicate(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private bool CheckForDuplicate(XtraForm newForm)
        {
            bool bValue = false;
            foreach (XtraForm fm in this.MdiChildren)
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

        private void barButtonItemPedidosVenda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VendasPedidosVendaUI form = new VendasPedidosVendaUI();
            if (!CheckForDuplicate(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
