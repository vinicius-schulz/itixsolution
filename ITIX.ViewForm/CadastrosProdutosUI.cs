﻿using System;
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
        public CadastrosProdutosUI()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonCriarProduto_Click(object sender, EventArgs e)
        {
            CadastrosProdutosDetalheUI form = new CadastrosProdutosDetalheUI();
            form.ShowDialog();
        }
    }
}
