namespace ITIX.ViewForm
{
    partial class CadastrosProdutosUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCriarProduto = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoLiquidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFilters.Controls.Add(this.buttonExcluir);
            this.panelFilters.Controls.Add(this.buttonCriarProduto);
            this.panelFilters.Controls.Add(this.buttonFiltrar);
            this.panelFilters.Controls.Add(this.textBoxNomeProduto);
            this.panelFilters.Controls.Add(this.labelNomeProduto);
            this.panelFilters.Location = new System.Drawing.Point(12, 12);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(668, 53);
            this.panelFilters.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(505, 15);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCriarProduto
            // 
            this.buttonCriarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCriarProduto.Location = new System.Drawing.Point(586, 15);
            this.buttonCriarProduto.Name = "buttonCriarProduto";
            this.buttonCriarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonCriarProduto.TabIndex = 3;
            this.buttonCriarProduto.Text = "Criar Produto";
            this.buttonCriarProduto.UseVisualStyleBackColor = true;
            this.buttonCriarProduto.Click += new System.EventHandler(this.buttonCriarProduto_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(425, 15);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(99, 17);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(320, 20);
            this.textBoxNomeProduto.TabIndex = 1;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(3, 20);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.labelNomeProduto.TabIndex = 0;
            this.labelNomeProduto.Text = "Nome do Produto";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.AutoGenerateColumns = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.pesoLiquidoDataGridViewTextBoxColumn,
            this.pesoBrutoDataGridViewTextBoxColumn});
            this.dataGridViewProdutos.DataSource = this.produtoBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(668, 367);
            this.dataGridViewProdutos.TabIndex = 1;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ITIX.Core.Model.Produto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // pesoLiquidoDataGridViewTextBoxColumn
            // 
            this.pesoLiquidoDataGridViewTextBoxColumn.DataPropertyName = "PesoLiquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.HeaderText = "Peso Líquido";
            this.pesoLiquidoDataGridViewTextBoxColumn.Name = "pesoLiquidoDataGridViewTextBoxColumn";
            // 
            // pesoBrutoDataGridViewTextBoxColumn
            // 
            this.pesoBrutoDataGridViewTextBoxColumn.DataPropertyName = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.HeaderText = "Peso Bruto";
            this.pesoBrutoDataGridViewTextBoxColumn.Name = "pesoBrutoDataGridViewTextBoxColumn";
            // 
            // CadastrosProdutosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.panelFilters);
            this.Name = "CadastrosProdutosUI";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.CadastrosProdutosUI_Load);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCriarProduto;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoLiquidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBrutoDataGridViewTextBoxColumn;
    }
}