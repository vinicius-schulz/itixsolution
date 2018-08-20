namespace ITIX.ViewForm
{
    partial class VendasPedidosVendaDetalhesUI
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
            this.panelDetalhes = new System.Windows.Forms.Panel();
            this.labelItensPedido = new System.Windows.Forms.Label();
            this.dataGridViewItensPedido = new System.Windows.Forms.DataGridView();
            this.itemPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.footerComponent = new ITIX.ViewForm.Components.FooterComponent();
            this.headerComponent = new ITIX.ViewForm.Components.HeaderComponent();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetalhes
            // 
            this.panelDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDetalhes.Controls.Add(this.labelItensPedido);
            this.panelDetalhes.Controls.Add(this.dataGridViewItensPedido);
            this.panelDetalhes.Controls.Add(this.richTextBoxDescricao);
            this.panelDetalhes.Controls.Add(this.textBoxDesconto);
            this.panelDetalhes.Controls.Add(this.textBoxSubTotal);
            this.panelDetalhes.Controls.Add(this.textBoxTotal);
            this.panelDetalhes.Controls.Add(this.labelDescricao);
            this.panelDetalhes.Controls.Add(this.labelSubTotal);
            this.panelDetalhes.Controls.Add(this.labelDesconto);
            this.panelDetalhes.Controls.Add(this.labelTotal);
            this.panelDetalhes.Location = new System.Drawing.Point(12, 74);
            this.panelDetalhes.Name = "panelDetalhes";
            this.panelDetalhes.Size = new System.Drawing.Size(614, 365);
            this.panelDetalhes.TabIndex = 2;
            // 
            // labelItensPedido
            // 
            this.labelItensPedido.AutoSize = true;
            this.labelItensPedido.Location = new System.Drawing.Point(14, 88);
            this.labelItensPedido.Name = "labelItensPedido";
            this.labelItensPedido.Size = new System.Drawing.Size(66, 13);
            this.labelItensPedido.TabIndex = 9;
            this.labelItensPedido.Text = "Itens Pedido";
            // 
            // dataGridViewItensPedido
            // 
            this.dataGridViewItensPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItensPedido.AutoGenerateColumns = false;
            this.dataGridViewItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.searchProductDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.idPedidoDataGridViewTextBoxColumn,
            this.pedidoDataGridViewTextBoxColumn,
            this.idProdutoDataGridViewTextBoxColumn});
            this.dataGridViewItensPedido.DataSource = this.itemPedidoBindingSource;
            this.dataGridViewItensPedido.Location = new System.Drawing.Point(17, 104);
            this.dataGridViewItensPedido.Name = "dataGridViewItensPedido";
            this.dataGridViewItensPedido.Size = new System.Drawing.Size(579, 254);
            this.dataGridViewItensPedido.TabIndex = 8;
            this.dataGridViewItensPedido.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItensPedido_CellValidated);
            this.dataGridViewItensPedido.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewItensPedido_CellValidating);
            this.dataGridViewItensPedido.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewItensPedido_EditingControlShowing);
            this.dataGridViewItensPedido.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItensPedido_RowValidated);
            this.dataGridViewItensPedido.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewItensPedido_RowValidating);
            // 
            // itemPedidoBindingSource
            // 
            this.itemPedidoBindingSource.DataSource = typeof(ITIX.Domain.Model.ItemPedido);
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescricao.Location = new System.Drawing.Point(250, 9);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(346, 72);
            this.richTextBoxDescricao.TabIndex = 7;
            this.richTextBoxDescricao.Text = "";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(73, 35);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.ReadOnly = true;
            this.textBoxDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesconto.TabIndex = 6;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(73, 9);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 5;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(73, 61);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 4;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(189, 9);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 3;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(14, 12);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(49, 13);
            this.labelSubTotal.TabIndex = 2;
            this.labelSubTotal.Text = "Sub-total";
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(14, 38);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(53, 13);
            this.labelDesconto.TabIndex = 1;
            this.labelDesconto.Text = "Desconto";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(14, 64);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            // 
            // footerComponent
            // 
            this.footerComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerComponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.footerComponent.Location = new System.Drawing.Point(12, 447);
            this.footerComponent.Name = "footerComponent";
            this.footerComponent.Size = new System.Drawing.Size(614, 56);
            this.footerComponent.TabIndex = 1;
            // 
            // headerComponent
            // 
            this.headerComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerComponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerComponent.Location = new System.Drawing.Point(12, 12);
            this.headerComponent.Name = "headerComponent";
            this.headerComponent.Size = new System.Drawing.Size(614, 56);
            this.headerComponent.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.Visible = false;
            // 
            // searchProductDataGridViewTextBoxColumn
            // 
            this.searchProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.searchProductDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.searchProductDataGridViewTextBoxColumn.Name = "searchProductDataGridViewTextBoxColumn";
            this.searchProductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchProductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.Width = 60;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 60;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 70;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pedidoDataGridViewTextBoxColumn
            // 
            this.pedidoDataGridViewTextBoxColumn.DataPropertyName = "Pedido";
            this.pedidoDataGridViewTextBoxColumn.HeaderText = "Pedido";
            this.pedidoDataGridViewTextBoxColumn.Name = "pedidoDataGridViewTextBoxColumn";
            this.pedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // VendasPedidosVendaDetalhesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 515);
            this.Controls.Add(this.panelDetalhes);
            this.Controls.Add(this.footerComponent);
            this.Controls.Add(this.headerComponent);
            this.Name = "VendasPedidosVendaDetalhesUI";
            this.Text = "Detalhe do Pedido";
            this.Load += new System.EventHandler(this.VendasPedidosVendaDetalhesUI_Load);
            this.panelDetalhes.ResumeLayout(false);
            this.panelDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.HeaderComponent headerComponent;
        private Components.FooterComponent footerComponent;
        private System.Windows.Forms.Panel panelDetalhes;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.DataGridView dataGridViewItensPedido;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.BindingSource itemPedidoBindingSource;
        private System.Windows.Forms.Label labelItensPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
    }
}