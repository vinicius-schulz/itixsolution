namespace ITIX.View
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
            this.gridControlItensPedidoDTO = new DevExpress.XtraGrid.GridControl();
            this.gridViewItensPedidoDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlPedido = new DevExpress.XtraEditors.PanelControl();
            this.memoEditComentario = new DevExpress.XtraEditors.MemoEdit();
            this.labelControlComentario = new DevExpress.XtraEditors.LabelControl();
            this.textEditSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.textEditDesconto = new DevExpress.XtraEditors.TextEdit();
            this.labelControlDesconto = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.textEditTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNumeroPedido = new DevExpress.XtraEditors.LabelControl();
            this.textEditNumeroPedido = new DevExpress.XtraEditors.TextEdit();
            this.itemPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPrecoUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensPedidoDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensPedidoDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlPedido)).BeginInit();
            this.panelControlPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlItensPedidoDTO
            // 
            this.gridControlItensPedidoDTO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlItensPedidoDTO.DataSource = this.itemPedidoBindingSource;
            this.gridControlItensPedidoDTO.Location = new System.Drawing.Point(12, 130);
            this.gridControlItensPedidoDTO.MainView = this.gridViewItensPedidoDTO;
            this.gridControlItensPedidoDTO.Name = "gridControlItensPedidoDTO";
            this.gridControlItensPedidoDTO.ShowOnlyPredefinedDetails = true;
            this.gridControlItensPedidoDTO.Size = new System.Drawing.Size(857, 284);
            this.gridControlItensPedidoDTO.TabIndex = 0;
            this.gridControlItensPedidoDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItensPedidoDTO});
            // 
            // gridViewItensPedidoDTO
            // 
            this.gridViewItensPedidoDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrecoUnitario,
            this.colQuantidade,
            this.colDesconto,
            this.colSubTotal,
            this.colValorTotal,
            this.colIdPedido,
            this.colPedido,
            this.colIdProduto,
            this.colProduto,
            this.colId});
            this.gridViewItensPedidoDTO.GridControl = this.gridControlItensPedidoDTO;
            this.gridViewItensPedidoDTO.Name = "gridViewItensPedidoDTO";
            this.gridViewItensPedidoDTO.OptionsSelection.MultiSelect = true;
            this.gridViewItensPedidoDTO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewItensPedidoDTO.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewItensPedidoDTO.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewItensPedidoDTO_CellValueChanged);
            // 
            // panelControlPedido
            // 
            this.panelControlPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlPedido.Controls.Add(this.memoEditComentario);
            this.panelControlPedido.Controls.Add(this.labelControlComentario);
            this.panelControlPedido.Controls.Add(this.textEditSubTotal);
            this.panelControlPedido.Controls.Add(this.textEditDesconto);
            this.panelControlPedido.Controls.Add(this.labelControlDesconto);
            this.panelControlPedido.Controls.Add(this.labelControlSubTotal);
            this.panelControlPedido.Controls.Add(this.textEditTotal);
            this.panelControlPedido.Controls.Add(this.labelControl1);
            this.panelControlPedido.Controls.Add(this.labelControlNumeroPedido);
            this.panelControlPedido.Controls.Add(this.textEditNumeroPedido);
            this.panelControlPedido.Location = new System.Drawing.Point(12, 12);
            this.panelControlPedido.Name = "panelControlPedido";
            this.panelControlPedido.Size = new System.Drawing.Size(857, 112);
            this.panelControlPedido.TabIndex = 1;
            // 
            // memoEditComentario
            // 
            this.memoEditComentario.Location = new System.Drawing.Point(265, 5);
            this.memoEditComentario.Name = "memoEditComentario";
            this.memoEditComentario.Properties.ReadOnly = true;
            this.memoEditComentario.Size = new System.Drawing.Size(252, 98);
            this.memoEditComentario.TabIndex = 41;
            // 
            // labelControlComentario
            // 
            this.labelControlComentario.Location = new System.Drawing.Point(204, 8);
            this.labelControlComentario.Name = "labelControlComentario";
            this.labelControlComentario.Size = new System.Drawing.Size(55, 13);
            this.labelControlComentario.TabIndex = 32;
            this.labelControlComentario.Text = "Comentário";
            // 
            // textEditSubTotal
            // 
            this.textEditSubTotal.Location = new System.Drawing.Point(99, 57);
            this.textEditSubTotal.Name = "textEditSubTotal";
            this.textEditSubTotal.Properties.ReadOnly = true;
            this.textEditSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textEditSubTotal.TabIndex = 23;
            // 
            // textEditDesconto
            // 
            this.textEditDesconto.Location = new System.Drawing.Point(99, 83);
            this.textEditDesconto.Name = "textEditDesconto";
            this.textEditDesconto.Properties.ReadOnly = true;
            this.textEditDesconto.Size = new System.Drawing.Size(100, 20);
            this.textEditDesconto.TabIndex = 22;
            // 
            // labelControlDesconto
            // 
            this.labelControlDesconto.Location = new System.Drawing.Point(6, 86);
            this.labelControlDesconto.Name = "labelControlDesconto";
            this.labelControlDesconto.Size = new System.Drawing.Size(45, 13);
            this.labelControlDesconto.TabIndex = 16;
            this.labelControlDesconto.Text = "Desconto";
            // 
            // labelControlSubTotal
            // 
            this.labelControlSubTotal.Location = new System.Drawing.Point(6, 60);
            this.labelControlSubTotal.Name = "labelControlSubTotal";
            this.labelControlSubTotal.Size = new System.Drawing.Size(42, 13);
            this.labelControlSubTotal.TabIndex = 15;
            this.labelControlSubTotal.Text = "SubTotal";
            // 
            // textEditTotal
            // 
            this.textEditTotal.Location = new System.Drawing.Point(99, 31);
            this.textEditTotal.Name = "textEditTotal";
            this.textEditTotal.Properties.ReadOnly = true;
            this.textEditTotal.Size = new System.Drawing.Size(100, 20);
            this.textEditTotal.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Total";
            // 
            // labelControlNumeroPedido
            // 
            this.labelControlNumeroPedido.Location = new System.Drawing.Point(5, 8);
            this.labelControlNumeroPedido.Name = "labelControlNumeroPedido";
            this.labelControlNumeroPedido.Size = new System.Drawing.Size(87, 13);
            this.labelControlNumeroPedido.TabIndex = 4;
            this.labelControlNumeroPedido.Text = "Número do Pedido";
            // 
            // textEditNumeroPedido
            // 
            this.textEditNumeroPedido.Location = new System.Drawing.Point(98, 5);
            this.textEditNumeroPedido.Name = "textEditNumeroPedido";
            this.textEditNumeroPedido.Properties.ReadOnly = true;
            this.textEditNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.textEditNumeroPedido.TabIndex = 3;
            // 
            // itemPedidoBindingSource
            // 
            this.itemPedidoBindingSource.DataSource = typeof(ITIX.Core.Model.ItemPedido);
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.FieldName = "PrecoUnitario";
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.Visible = true;
            this.colPrecoUnitario.VisibleIndex = 1;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            // 
            // colDesconto
            // 
            this.colDesconto.FieldName = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.Visible = true;
            this.colDesconto.VisibleIndex = 3;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 4;
            // 
            // colValorTotal
            // 
            this.colValorTotal.FieldName = "ValorTotal";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.Visible = true;
            this.colValorTotal.VisibleIndex = 5;
            // 
            // colIdPedido
            // 
            this.colIdPedido.FieldName = "IdPedido";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.Visible = true;
            this.colIdPedido.VisibleIndex = 6;
            // 
            // colPedido
            // 
            this.colPedido.FieldName = "Pedido";
            this.colPedido.Name = "colPedido";
            this.colPedido.Visible = true;
            this.colPedido.VisibleIndex = 7;
            // 
            // colIdProduto
            // 
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 8;
            // 
            // colProduto
            // 
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 9;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 10;
            // 
            // VendasPedidosVendaDetalhesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 426);
            this.Controls.Add(this.panelControlPedido);
            this.Controls.Add(this.gridControlItensPedidoDTO);
            this.Name = "VendasPedidosVendaDetalhesUI";
            this.Text = "VendaPedidoVendaDetalhesUI";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensPedidoDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensPedidoDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlPedido)).EndInit();
            this.panelControlPedido.ResumeLayout(false);
            this.panelControlPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControlPedido;
        private DevExpress.XtraGrid.GridControl gridControlItensPedidoDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensPedidoDTO;
        private DevExpress.XtraEditors.TextEdit textEditNumeroPedido;
        private DevExpress.XtraEditors.LabelControl labelControlNumeroPedido;
        private DevExpress.XtraEditors.TextEdit textEditTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlDesconto;
        private DevExpress.XtraEditors.LabelControl labelControlSubTotal;
        private DevExpress.XtraEditors.TextEdit textEditDesconto;
        private DevExpress.XtraEditors.TextEdit textEditSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControlComentario;
        private DevExpress.XtraEditors.MemoEdit memoEditComentario;
        private System.Windows.Forms.BindingSource itemPedidoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}