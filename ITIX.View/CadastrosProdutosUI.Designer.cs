namespace ITIX.View
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
            this.panelControlFiltros = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.textEditSKU = new DevExpress.XtraEditors.TextEdit();
            this.textEditNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControlSKU = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNome = new DevExpress.XtraEditors.LabelControl();
            this.gridControlProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backgroundWorkerFiltrar = new System.ComponentModel.BackgroundWorker();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoLiquido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltros)).BeginInit();
            this.panelControlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSKU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlFiltros
            // 
            this.panelControlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlFiltros.Controls.Add(this.simpleButtonFiltrar);
            this.panelControlFiltros.Controls.Add(this.textEditSKU);
            this.panelControlFiltros.Controls.Add(this.textEditNome);
            this.panelControlFiltros.Controls.Add(this.labelControlSKU);
            this.panelControlFiltros.Controls.Add(this.labelControlNome);
            this.panelControlFiltros.Location = new System.Drawing.Point(12, 12);
            this.panelControlFiltros.Name = "panelControlFiltros";
            this.panelControlFiltros.Size = new System.Drawing.Size(770, 49);
            this.panelControlFiltros.TabIndex = 0;
            // 
            // simpleButtonFiltrar
            // 
            this.simpleButtonFiltrar.Location = new System.Drawing.Point(534, 14);
            this.simpleButtonFiltrar.Name = "simpleButtonFiltrar";
            this.simpleButtonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonFiltrar.TabIndex = 4;
            this.simpleButtonFiltrar.Text = "Filtrar";
            this.simpleButtonFiltrar.Click += new System.EventHandler(this.simpleButtonFiltrar_Click);
            // 
            // textEditSKU
            // 
            this.textEditSKU.Location = new System.Drawing.Point(409, 16);
            this.textEditSKU.Name = "textEditSKU";
            this.textEditSKU.Size = new System.Drawing.Size(119, 20);
            this.textEditSKU.TabIndex = 3;
            // 
            // textEditNome
            // 
            this.textEditNome.Location = new System.Drawing.Point(38, 16);
            this.textEditNome.Name = "textEditNome";
            this.textEditNome.Size = new System.Drawing.Size(340, 20);
            this.textEditNome.TabIndex = 2;
            // 
            // labelControlSKU
            // 
            this.labelControlSKU.Location = new System.Drawing.Point(384, 19);
            this.labelControlSKU.Name = "labelControlSKU";
            this.labelControlSKU.Size = new System.Drawing.Size(19, 13);
            this.labelControlSKU.TabIndex = 1;
            this.labelControlSKU.Text = "SKU";
            // 
            // labelControlNome
            // 
            this.labelControlNome.Location = new System.Drawing.Point(5, 19);
            this.labelControlNome.Name = "labelControlNome";
            this.labelControlNome.Size = new System.Drawing.Size(27, 13);
            this.labelControlNome.TabIndex = 0;
            this.labelControlNome.Text = "Nome";
            // 
            // gridControlProdutos
            // 
            this.gridControlProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlProdutos.DataSource = this.produtoBindingSource;
            this.gridControlProdutos.Location = new System.Drawing.Point(12, 67);
            this.gridControlProdutos.MainView = this.gridViewProdutos;
            this.gridControlProdutos.Name = "gridControlProdutos";
            this.gridControlProdutos.ShowOnlyPredefinedDetails = true;
            this.gridControlProdutos.Size = new System.Drawing.Size(770, 445);
            this.gridControlProdutos.TabIndex = 1;
            this.gridControlProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNomeProduto,
            this.colPesoBruto,
            this.colPesoLiquido,
            this.colPreco,
            this.colDescricao});
            this.gridViewProdutos.GridControl = this.gridControlProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            // 
            // backgroundWorkerFiltrar
            // 
            this.backgroundWorkerFiltrar.WorkerSupportsCancellation = true;
            this.backgroundWorkerFiltrar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFiltrar_DoWork);
            this.backgroundWorkerFiltrar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFiltrar_RunWorkerCompleted);
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.BarAnimationElementThickness = 2;
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.Location = new System.Drawing.Point(294, 197);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(246, 66);
            this.progressPanel.TabIndex = 2;
            this.progressPanel.Text = "progressPanel";
            this.progressPanel.Visible = false;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ITIX.Core.Model.Produto);
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.FieldName = "NomeProduto";
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.Visible = true;
            this.colNomeProduto.VisibleIndex = 1;
            this.colNomeProduto.Width = 303;
            // 
            // colPesoBruto
            // 
            this.colPesoBruto.FieldName = "PesoBruto";
            this.colPesoBruto.Name = "colPesoBruto";
            this.colPesoBruto.Visible = true;
            this.colPesoBruto.VisibleIndex = 3;
            this.colPesoBruto.Width = 74;
            // 
            // colPesoLiquido
            // 
            this.colPesoLiquido.FieldName = "PesoLiquido";
            this.colPesoLiquido.Name = "colPesoLiquido";
            this.colPesoLiquido.Visible = true;
            this.colPesoLiquido.VisibleIndex = 4;
            this.colPesoLiquido.Width = 74;
            // 
            // colPreco
            // 
            this.colPreco.Caption = "Preço";
            this.colPreco.FieldName = "Preco";
            this.colPreco.Name = "colPreco";
            this.colPreco.Visible = true;
            this.colPreco.VisibleIndex = 5;
            this.colPreco.Width = 84;
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 558;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 49;
            // 
            // CadastrosProdutosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 524);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.gridControlProdutos);
            this.Controls.Add(this.panelControlFiltros);
            this.Name = "CadastrosProdutosUI";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltros)).EndInit();
            this.panelControlFiltros.ResumeLayout(false);
            this.panelControlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSKU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlFiltros;
        private DevExpress.XtraGrid.GridControl gridControlProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFiltrar;
        private DevExpress.XtraEditors.TextEdit textEditSKU;
        private DevExpress.XtraEditors.TextEdit textEditNome;
        private DevExpress.XtraEditors.LabelControl labelControlSKU;
        private DevExpress.XtraEditors.LabelControl labelControlNome;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFiltrar;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoLiquido;
        private DevExpress.XtraGrid.Columns.GridColumn colPreco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
    }
}