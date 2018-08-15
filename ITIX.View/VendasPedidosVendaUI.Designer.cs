using ITIX.View.Components;

namespace ITIX.View
{
    partial class VendasPedidosVendaUI
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasPedidosVendaUI));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridViewEnderecos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEnderecoEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogradouroEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidadeEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEPEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeDestinatarioEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSobrenomeDestinatarioEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefoneEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMagentoEnderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHistoricos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarioHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNotificadoHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedidoMagentoHistoricos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewItensPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProdutoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkuItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoUnitarioOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescontoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotalItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpcoesItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBrutoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtualizacaoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdutoItemPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewFaturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroFaturaFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescontoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreteFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtualizacaoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMagentoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEnderecoCobrancaMagento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedidoMagentoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdStoreMagentoFaturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewFaturasHistoricos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHistoricoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNotificadoHistoricoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarioHistoricoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoHistoricoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtualizacaoHistoricoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewFaturasItensFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeProdutoItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoUnitarioItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoTotalItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdItemPedidoItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFaturaItemFaturaFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewEntregas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtualizacaoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewEntregasHistoricos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHistoricoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNotificadoHistoricoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarioHistoricoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoHistoricoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewEntregasItensEntrega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProdutoItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoUnitarioItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdItemPedidoItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEntregaItemEntregaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewRastreamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTituloRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoRastreioRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransportadoraRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacaoRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtualizacaoRastreamentoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemButtonEditActionDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControlNumeroPedido = new DevExpress.XtraEditors.LabelControl();
            this.textEditNumeroPedido = new DevExpress.XtraEditors.TextEdit();
            this.labelControlDataInicial = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDataFinal = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.panelControlFiltros = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorkerFiltrar = new System.ComponentModel.BackgroundWorker();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistoricos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasHistoricos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasItensFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregasHistoricos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregasItensEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRastreamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditActionDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltros)).BeginInit();
            this.panelControlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewEnderecos
            // 
            this.gridViewEnderecos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEnderecos,
            this.colTipoEnderecoEnderecos,
            this.colLogradouroEnderecos,
            this.colCidadeEnderecos,
            this.colEstadoEnderecos,
            this.colCEPEnderecos,
            this.colNomeDestinatarioEnderecos,
            this.colSobrenomeDestinatarioEnderecos,
            this.colTelefoneEnderecos,
            this.colIdMagentoEnderecos});
            this.gridViewEnderecos.GridControl = this.gridControlPedidos;
            this.gridViewEnderecos.Name = "gridViewEnderecos";
            // 
            // colIdEnderecos
            // 
            this.colIdEnderecos.Caption = "Id";
            this.colIdEnderecos.FieldName = "Id";
            this.colIdEnderecos.Name = "colIdEnderecos";
            this.colIdEnderecos.OptionsColumn.AllowEdit = false;
            this.colIdEnderecos.OptionsColumn.AllowSize = false;
            this.colIdEnderecos.Visible = true;
            this.colIdEnderecos.VisibleIndex = 0;
            this.colIdEnderecos.Width = 55;
            // 
            // colTipoEnderecoEnderecos
            // 
            this.colTipoEnderecoEnderecos.Caption = "Tipo do Endereço";
            this.colTipoEnderecoEnderecos.FieldName = "TipoEndereco";
            this.colTipoEnderecoEnderecos.Name = "colTipoEnderecoEnderecos";
            this.colTipoEnderecoEnderecos.OptionsColumn.AllowEdit = false;
            this.colTipoEnderecoEnderecos.Visible = true;
            this.colTipoEnderecoEnderecos.VisibleIndex = 1;
            this.colTipoEnderecoEnderecos.Width = 119;
            // 
            // colLogradouroEnderecos
            // 
            this.colLogradouroEnderecos.Caption = "Logradouro";
            this.colLogradouroEnderecos.FieldName = "Logradouro";
            this.colLogradouroEnderecos.Name = "colLogradouroEnderecos";
            this.colLogradouroEnderecos.OptionsColumn.AllowEdit = false;
            this.colLogradouroEnderecos.Visible = true;
            this.colLogradouroEnderecos.VisibleIndex = 2;
            this.colLogradouroEnderecos.Width = 177;
            // 
            // colCidadeEnderecos
            // 
            this.colCidadeEnderecos.Caption = "Cidade";
            this.colCidadeEnderecos.FieldName = "Cidade";
            this.colCidadeEnderecos.Name = "colCidadeEnderecos";
            this.colCidadeEnderecos.OptionsColumn.AllowEdit = false;
            this.colCidadeEnderecos.Visible = true;
            this.colCidadeEnderecos.VisibleIndex = 3;
            this.colCidadeEnderecos.Width = 139;
            // 
            // colEstadoEnderecos
            // 
            this.colEstadoEnderecos.Caption = "Estado";
            this.colEstadoEnderecos.FieldName = "Estado";
            this.colEstadoEnderecos.Name = "colEstadoEnderecos";
            this.colEstadoEnderecos.OptionsColumn.AllowEdit = false;
            this.colEstadoEnderecos.Visible = true;
            this.colEstadoEnderecos.VisibleIndex = 4;
            this.colEstadoEnderecos.Width = 126;
            // 
            // colCEPEnderecos
            // 
            this.colCEPEnderecos.Caption = "CEP";
            this.colCEPEnderecos.FieldName = "CEP";
            this.colCEPEnderecos.Name = "colCEPEnderecos";
            this.colCEPEnderecos.OptionsColumn.AllowEdit = false;
            this.colCEPEnderecos.OptionsColumn.AllowSize = false;
            this.colCEPEnderecos.Visible = true;
            this.colCEPEnderecos.VisibleIndex = 5;
            this.colCEPEnderecos.Width = 96;
            // 
            // colNomeDestinatarioEnderecos
            // 
            this.colNomeDestinatarioEnderecos.Caption = "Nome do Destinatário";
            this.colNomeDestinatarioEnderecos.FieldName = "NomeDestinatario";
            this.colNomeDestinatarioEnderecos.Name = "colNomeDestinatarioEnderecos";
            this.colNomeDestinatarioEnderecos.OptionsColumn.AllowEdit = false;
            this.colNomeDestinatarioEnderecos.Visible = true;
            this.colNomeDestinatarioEnderecos.VisibleIndex = 6;
            this.colNomeDestinatarioEnderecos.Width = 135;
            // 
            // colSobrenomeDestinatarioEnderecos
            // 
            this.colSobrenomeDestinatarioEnderecos.Caption = "Sobrenome do Destinatário";
            this.colSobrenomeDestinatarioEnderecos.FieldName = "SobrenomeDestinatario";
            this.colSobrenomeDestinatarioEnderecos.Name = "colSobrenomeDestinatarioEnderecos";
            this.colSobrenomeDestinatarioEnderecos.OptionsColumn.AllowEdit = false;
            this.colSobrenomeDestinatarioEnderecos.Visible = true;
            this.colSobrenomeDestinatarioEnderecos.VisibleIndex = 7;
            this.colSobrenomeDestinatarioEnderecos.Width = 178;
            // 
            // colTelefoneEnderecos
            // 
            this.colTelefoneEnderecos.Caption = "Telefone";
            this.colTelefoneEnderecos.FieldName = "Telefone";
            this.colTelefoneEnderecos.Name = "colTelefoneEnderecos";
            this.colTelefoneEnderecos.OptionsColumn.AllowEdit = false;
            this.colTelefoneEnderecos.OptionsColumn.AllowSize = false;
            this.colTelefoneEnderecos.Visible = true;
            this.colTelefoneEnderecos.VisibleIndex = 8;
            this.colTelefoneEnderecos.Width = 117;
            // 
            // colIdMagentoEnderecos
            // 
            this.colIdMagentoEnderecos.Caption = "Id Magento";
            this.colIdMagentoEnderecos.FieldName = "IdMagento";
            this.colIdMagentoEnderecos.Name = "colIdMagentoEnderecos";
            this.colIdMagentoEnderecos.OptionsColumn.AllowEdit = false;
            this.colIdMagentoEnderecos.OptionsColumn.AllowSize = false;
            // 
            // gridControlPedidos
            // 
            this.gridControlPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPedidos.DataSource = this.pedidoBindingSource;
            gridLevelNode1.RelationName = "ItensPedido";
            this.gridControlPedidos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlPedidos.Location = new System.Drawing.Point(12, 67);
            this.gridControlPedidos.MainView = this.gridViewPedidos;
            this.gridControlPedidos.Name = "gridControlPedidos";
            this.gridControlPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditActionDelete});
            this.gridControlPedidos.ShowOnlyPredefinedDetails = true;
            this.gridControlPedidos.Size = new System.Drawing.Size(748, 488);
            this.gridControlPedidos.TabIndex = 0;
            this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistoricos,
            this.gridViewItensPedido,
            this.gridViewFaturas,
            this.gridViewFaturasHistoricos,
            this.gridViewFaturasItensFatura,
            this.gridViewEntregas,
            this.gridViewEntregasHistoricos,
            this.gridViewEntregasItensEntrega,
            this.gridViewRastreamentos,
            this.gridViewPedidos,
            this.gridViewEnderecos});
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(ITIX.Core.Model.Pedido);
            // 
            // gridViewHistoricos
            // 
            this.gridViewHistoricos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHistoricos,
            this.colComentarioHistoricos,
            this.colStatusHistoricos,
            this.colClienteNotificadoHistoricos,
            this.colDataCriacaoHistoricos,
            this.colIdPedidoMagentoHistoricos});
            this.gridViewHistoricos.GridControl = this.gridControlPedidos;
            this.gridViewHistoricos.Name = "gridViewHistoricos";
            // 
            // colIdHistoricos
            // 
            this.colIdHistoricos.Caption = "Id";
            this.colIdHistoricos.FieldName = "Id";
            this.colIdHistoricos.Name = "colIdHistoricos";
            this.colIdHistoricos.OptionsColumn.AllowEdit = false;
            this.colIdHistoricos.OptionsColumn.AllowSize = false;
            this.colIdHistoricos.Visible = true;
            this.colIdHistoricos.VisibleIndex = 0;
            this.colIdHistoricos.Width = 58;
            // 
            // colComentarioHistoricos
            // 
            this.colComentarioHistoricos.Caption = "Comentário";
            this.colComentarioHistoricos.FieldName = "Comentario";
            this.colComentarioHistoricos.Name = "colComentarioHistoricos";
            this.colComentarioHistoricos.OptionsColumn.AllowEdit = false;
            this.colComentarioHistoricos.Visible = true;
            this.colComentarioHistoricos.VisibleIndex = 2;
            this.colComentarioHistoricos.Width = 747;
            // 
            // colStatusHistoricos
            // 
            this.colStatusHistoricos.Caption = "Status";
            this.colStatusHistoricos.FieldName = "Status";
            this.colStatusHistoricos.Name = "colStatusHistoricos";
            this.colStatusHistoricos.OptionsColumn.AllowEdit = false;
            this.colStatusHistoricos.OptionsColumn.AllowSize = false;
            this.colStatusHistoricos.Visible = true;
            this.colStatusHistoricos.VisibleIndex = 3;
            this.colStatusHistoricos.Width = 111;
            // 
            // colClienteNotificadoHistoricos
            // 
            this.colClienteNotificadoHistoricos.Caption = "Cliente Notificado";
            this.colClienteNotificadoHistoricos.FieldName = "ClienteNotificado";
            this.colClienteNotificadoHistoricos.Name = "colClienteNotificadoHistoricos";
            this.colClienteNotificadoHistoricos.OptionsColumn.AllowEdit = false;
            this.colClienteNotificadoHistoricos.OptionsColumn.AllowSize = false;
            this.colClienteNotificadoHistoricos.Visible = true;
            this.colClienteNotificadoHistoricos.VisibleIndex = 1;
            this.colClienteNotificadoHistoricos.Width = 98;
            // 
            // colDataCriacaoHistoricos
            // 
            this.colDataCriacaoHistoricos.Caption = "Criação";
            this.colDataCriacaoHistoricos.FieldName = "DataCriacao";
            this.colDataCriacaoHistoricos.Name = "colDataCriacaoHistoricos";
            this.colDataCriacaoHistoricos.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoHistoricos.OptionsColumn.AllowSize = false;
            this.colDataCriacaoHistoricos.Visible = true;
            this.colDataCriacaoHistoricos.VisibleIndex = 4;
            this.colDataCriacaoHistoricos.Width = 128;
            // 
            // colIdPedidoMagentoHistoricos
            // 
            this.colIdPedidoMagentoHistoricos.Caption = "Id Pedido Magento";
            this.colIdPedidoMagentoHistoricos.FieldName = "IdPedidoMagento";
            this.colIdPedidoMagentoHistoricos.Name = "colIdPedidoMagentoHistoricos";
            this.colIdPedidoMagentoHistoricos.OptionsColumn.AllowEdit = false;
            this.colIdPedidoMagentoHistoricos.OptionsColumn.AllowSize = false;
            // 
            // gridViewItensPedido
            // 
            this.gridViewItensPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdItemPedido,
            this.colNomeProdutoItemPedido,
            this.colSkuItemPedido,
            this.colQuantidadeItemPedido,
            this.colPrecoUnitarioOriginal,
            this.colDescontoItemPedido,
            this.colSubTotalItemPedido,
            this.colValorTotalItemPedido,
            this.colOpcoesItemPedido,
            this.colPesoBrutoItemPedido,
            this.colDataCriacaoItemPedido,
            this.colDataAtualizacaoItemPedido,
            this.colProdutoItemPedido});
            this.gridViewItensPedido.GridControl = this.gridControlPedidos;
            this.gridViewItensPedido.Name = "gridViewItensPedido";
            // 
            // colIdItemPedido
            // 
            this.colIdItemPedido.Caption = "Id";
            this.colIdItemPedido.FieldName = "Id";
            this.colIdItemPedido.Name = "colIdItemPedido";
            this.colIdItemPedido.OptionsColumn.AllowEdit = false;
            this.colIdItemPedido.OptionsColumn.AllowSize = false;
            this.colIdItemPedido.Visible = true;
            this.colIdItemPedido.VisibleIndex = 0;
            this.colIdItemPedido.Width = 64;
            // 
            // colNomeProdutoItemPedido
            // 
            this.colNomeProdutoItemPedido.Caption = "Nome do Produto";
            this.colNomeProdutoItemPedido.FieldName = "NomeProduto";
            this.colNomeProdutoItemPedido.Name = "colNomeProdutoItemPedido";
            this.colNomeProdutoItemPedido.OptionsColumn.AllowEdit = false;
            this.colNomeProdutoItemPedido.Visible = true;
            this.colNomeProdutoItemPedido.VisibleIndex = 1;
            this.colNomeProdutoItemPedido.Width = 520;
            // 
            // colSkuItemPedido
            // 
            this.colSkuItemPedido.Caption = "SKU";
            this.colSkuItemPedido.FieldName = "Sku";
            this.colSkuItemPedido.Name = "colSkuItemPedido";
            this.colSkuItemPedido.OptionsColumn.AllowEdit = false;
            this.colSkuItemPedido.OptionsColumn.AllowSize = false;
            this.colSkuItemPedido.Visible = true;
            this.colSkuItemPedido.VisibleIndex = 2;
            this.colSkuItemPedido.Width = 84;
            // 
            // colQuantidadeItemPedido
            // 
            this.colQuantidadeItemPedido.Caption = "Quantidade";
            this.colQuantidadeItemPedido.FieldName = "Quantidade";
            this.colQuantidadeItemPedido.Name = "colQuantidadeItemPedido";
            this.colQuantidadeItemPedido.OptionsColumn.AllowEdit = false;
            this.colQuantidadeItemPedido.OptionsColumn.AllowSize = false;
            this.colQuantidadeItemPedido.Visible = true;
            this.colQuantidadeItemPedido.VisibleIndex = 3;
            this.colQuantidadeItemPedido.Width = 68;
            // 
            // colPrecoUnitarioOriginal
            // 
            this.colPrecoUnitarioOriginal.Caption = "Preço Unitário";
            this.colPrecoUnitarioOriginal.FieldName = "PrecoUnitarioOriginalItemPedido";
            this.colPrecoUnitarioOriginal.Name = "colPrecoUnitarioOriginal";
            this.colPrecoUnitarioOriginal.OptionsColumn.AllowEdit = false;
            this.colPrecoUnitarioOriginal.OptionsColumn.AllowSize = false;
            this.colPrecoUnitarioOriginal.Visible = true;
            this.colPrecoUnitarioOriginal.VisibleIndex = 4;
            this.colPrecoUnitarioOriginal.Width = 82;
            // 
            // colDescontoItemPedido
            // 
            this.colDescontoItemPedido.Caption = "Desconto";
            this.colDescontoItemPedido.FieldName = "Desconto";
            this.colDescontoItemPedido.Name = "colDescontoItemPedido";
            this.colDescontoItemPedido.OptionsColumn.AllowEdit = false;
            this.colDescontoItemPedido.OptionsColumn.AllowSize = false;
            this.colDescontoItemPedido.Visible = true;
            this.colDescontoItemPedido.VisibleIndex = 5;
            this.colDescontoItemPedido.Width = 59;
            // 
            // colSubTotalItemPedido
            // 
            this.colSubTotalItemPedido.Caption = "SubTotal";
            this.colSubTotalItemPedido.FieldName = "SubTotal";
            this.colSubTotalItemPedido.Name = "colSubTotalItemPedido";
            this.colSubTotalItemPedido.OptionsColumn.AllowEdit = false;
            this.colSubTotalItemPedido.OptionsColumn.AllowSize = false;
            this.colSubTotalItemPedido.Visible = true;
            this.colSubTotalItemPedido.VisibleIndex = 6;
            this.colSubTotalItemPedido.Width = 57;
            // 
            // colValorTotalItemPedido
            // 
            this.colValorTotalItemPedido.Caption = "Valor Total";
            this.colValorTotalItemPedido.FieldName = "ValorTotal";
            this.colValorTotalItemPedido.Name = "colValorTotalItemPedido";
            this.colValorTotalItemPedido.OptionsColumn.AllowEdit = false;
            this.colValorTotalItemPedido.OptionsColumn.AllowSize = false;
            this.colValorTotalItemPedido.Visible = true;
            this.colValorTotalItemPedido.VisibleIndex = 7;
            this.colValorTotalItemPedido.Width = 72;
            // 
            // colOpcoesItemPedido
            // 
            this.colOpcoesItemPedido.Caption = "Opções";
            this.colOpcoesItemPedido.FieldName = "Opcoes";
            this.colOpcoesItemPedido.Name = "colOpcoesItemPedido";
            this.colOpcoesItemPedido.OptionsColumn.AllowEdit = false;
            this.colOpcoesItemPedido.OptionsColumn.AllowSize = false;
            // 
            // colPesoBrutoItemPedido
            // 
            this.colPesoBrutoItemPedido.Caption = "Peso";
            this.colPesoBrutoItemPedido.FieldName = "PesoBruto";
            this.colPesoBrutoItemPedido.Name = "colPesoBrutoItemPedido";
            this.colPesoBrutoItemPedido.OptionsColumn.AllowEdit = false;
            this.colPesoBrutoItemPedido.OptionsColumn.AllowSize = false;
            this.colPesoBrutoItemPedido.Visible = true;
            this.colPesoBrutoItemPedido.VisibleIndex = 8;
            this.colPesoBrutoItemPedido.Width = 90;
            // 
            // colDataCriacaoItemPedido
            // 
            this.colDataCriacaoItemPedido.Caption = "Criação";
            this.colDataCriacaoItemPedido.FieldName = "DataCriacao";
            this.colDataCriacaoItemPedido.Name = "colDataCriacaoItemPedido";
            this.colDataCriacaoItemPedido.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoItemPedido.OptionsColumn.AllowSize = false;
            // 
            // colDataAtualizacaoItemPedido
            // 
            this.colDataAtualizacaoItemPedido.Caption = "Atualização";
            this.colDataAtualizacaoItemPedido.FieldName = "DataAtualizacao";
            this.colDataAtualizacaoItemPedido.Name = "colDataAtualizacaoItemPedido";
            this.colDataAtualizacaoItemPedido.OptionsColumn.AllowEdit = false;
            this.colDataAtualizacaoItemPedido.OptionsColumn.AllowSize = false;
            // 
            // colProdutoItemPedido
            // 
            this.colProdutoItemPedido.Caption = "Produto";
            this.colProdutoItemPedido.FieldName = "Produto";
            this.colProdutoItemPedido.Name = "colProdutoItemPedido";
            this.colProdutoItemPedido.OptionsColumn.AllowEdit = false;
            this.colProdutoItemPedido.OptionsColumn.AllowSize = false;
            // 
            // gridViewFaturas
            // 
            this.gridViewFaturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFaturas,
            this.colNumeroFaturaFaturas,
            this.colDescontoFaturas,
            this.colFreteFaturas,
            this.colSubTotalFaturas,
            this.colTotalFaturas,
            this.colStateFaturas,
            this.colDataCriacaoFaturas,
            this.colDataAtualizacaoFaturas,
            this.colIdMagentoFaturas,
            this.colIdEnderecoCobrancaMagento,
            this.colIdPedidoMagentoFaturas,
            this.colIdStoreMagentoFaturas});
            this.gridViewFaturas.GridControl = this.gridControlPedidos;
            this.gridViewFaturas.Name = "gridViewFaturas";
            // 
            // colIdFaturas
            // 
            this.colIdFaturas.Caption = "Id";
            this.colIdFaturas.FieldName = "Id";
            this.colIdFaturas.Name = "colIdFaturas";
            this.colIdFaturas.OptionsColumn.AllowEdit = false;
            this.colIdFaturas.Visible = true;
            this.colIdFaturas.VisibleIndex = 0;
            this.colIdFaturas.Width = 50;
            // 
            // colNumeroFaturaFaturas
            // 
            this.colNumeroFaturaFaturas.Caption = "Número da Fatura";
            this.colNumeroFaturaFaturas.FieldName = "NumeroFatura";
            this.colNumeroFaturaFaturas.Name = "colNumeroFaturaFaturas";
            this.colNumeroFaturaFaturas.OptionsColumn.AllowEdit = false;
            this.colNumeroFaturaFaturas.Visible = true;
            this.colNumeroFaturaFaturas.VisibleIndex = 1;
            this.colNumeroFaturaFaturas.Width = 154;
            // 
            // colDescontoFaturas
            // 
            this.colDescontoFaturas.Caption = "Desconto";
            this.colDescontoFaturas.FieldName = "Desconto";
            this.colDescontoFaturas.Name = "colDescontoFaturas";
            this.colDescontoFaturas.OptionsColumn.AllowEdit = false;
            this.colDescontoFaturas.Visible = true;
            this.colDescontoFaturas.VisibleIndex = 2;
            this.colDescontoFaturas.Width = 154;
            // 
            // colFreteFaturas
            // 
            this.colFreteFaturas.Caption = "Frete";
            this.colFreteFaturas.FieldName = "Frete";
            this.colFreteFaturas.Name = "colFreteFaturas";
            this.colFreteFaturas.OptionsColumn.AllowEdit = false;
            this.colFreteFaturas.Visible = true;
            this.colFreteFaturas.VisibleIndex = 3;
            this.colFreteFaturas.Width = 154;
            // 
            // colSubTotalFaturas
            // 
            this.colSubTotalFaturas.Caption = "SubTotal";
            this.colSubTotalFaturas.FieldName = "SubTotal";
            this.colSubTotalFaturas.Name = "colSubTotalFaturas";
            this.colSubTotalFaturas.OptionsColumn.AllowEdit = false;
            this.colSubTotalFaturas.Visible = true;
            this.colSubTotalFaturas.VisibleIndex = 4;
            this.colSubTotalFaturas.Width = 154;
            // 
            // colTotalFaturas
            // 
            this.colTotalFaturas.Caption = "Total";
            this.colTotalFaturas.FieldName = "Total";
            this.colTotalFaturas.Name = "colTotalFaturas";
            this.colTotalFaturas.OptionsColumn.AllowEdit = false;
            this.colTotalFaturas.Visible = true;
            this.colTotalFaturas.VisibleIndex = 5;
            this.colTotalFaturas.Width = 154;
            // 
            // colStateFaturas
            // 
            this.colStateFaturas.Caption = "Estado";
            this.colStateFaturas.FieldName = "State";
            this.colStateFaturas.Name = "colStateFaturas";
            this.colStateFaturas.OptionsColumn.AllowEdit = false;
            this.colStateFaturas.Visible = true;
            this.colStateFaturas.VisibleIndex = 6;
            this.colStateFaturas.Width = 154;
            // 
            // colDataCriacaoFaturas
            // 
            this.colDataCriacaoFaturas.Caption = "Criação";
            this.colDataCriacaoFaturas.FieldName = "DataCriacao";
            this.colDataCriacaoFaturas.Name = "colDataCriacaoFaturas";
            this.colDataCriacaoFaturas.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoFaturas.Visible = true;
            this.colDataCriacaoFaturas.VisibleIndex = 7;
            this.colDataCriacaoFaturas.Width = 168;
            // 
            // colDataAtualizacaoFaturas
            // 
            this.colDataAtualizacaoFaturas.Caption = "Atualização";
            this.colDataAtualizacaoFaturas.FieldName = "DataAtualizacao";
            this.colDataAtualizacaoFaturas.Name = "colDataAtualizacaoFaturas";
            this.colDataAtualizacaoFaturas.OptionsColumn.AllowEdit = false;
            // 
            // colIdMagentoFaturas
            // 
            this.colIdMagentoFaturas.Caption = "Id Magento";
            this.colIdMagentoFaturas.FieldName = "IdMagento";
            this.colIdMagentoFaturas.Name = "colIdMagentoFaturas";
            this.colIdMagentoFaturas.OptionsColumn.AllowEdit = false;
            // 
            // colIdEnderecoCobrancaMagento
            // 
            this.colIdEnderecoCobrancaMagento.Caption = "Id Endereço Cobrança Magento";
            this.colIdEnderecoCobrancaMagento.FieldName = "IdEnderecoCobrancaMagento";
            this.colIdEnderecoCobrancaMagento.Name = "colIdEnderecoCobrancaMagento";
            this.colIdEnderecoCobrancaMagento.OptionsColumn.AllowEdit = false;
            // 
            // colIdPedidoMagentoFaturas
            // 
            this.colIdPedidoMagentoFaturas.Caption = "Id Pedido Magento";
            this.colIdPedidoMagentoFaturas.FieldName = "IdPedidoMagento";
            this.colIdPedidoMagentoFaturas.Name = "colIdPedidoMagentoFaturas";
            this.colIdPedidoMagentoFaturas.OptionsColumn.AllowEdit = false;
            // 
            // colIdStoreMagentoFaturas
            // 
            this.colIdStoreMagentoFaturas.Caption = "Id Store Magento";
            this.colIdStoreMagentoFaturas.FieldName = "IdStoreMagento";
            this.colIdStoreMagentoFaturas.Name = "colIdStoreMagentoFaturas";
            this.colIdStoreMagentoFaturas.OptionsColumn.AllowEdit = false;
            // 
            // gridViewFaturasHistoricos
            // 
            this.gridViewFaturasHistoricos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHistoricoFatura,
            this.colClienteNotificadoHistoricoFatura,
            this.colComentarioHistoricoFatura,
            this.colDataCriacaoHistoricoFatura,
            this.colDataAtualizacaoHistoricoFatura});
            this.gridViewFaturasHistoricos.GridControl = this.gridControlPedidos;
            this.gridViewFaturasHistoricos.Name = "gridViewFaturasHistoricos";
            // 
            // colIdHistoricoFatura
            // 
            this.colIdHistoricoFatura.Caption = "Id";
            this.colIdHistoricoFatura.FieldName = "Id";
            this.colIdHistoricoFatura.Name = "colIdHistoricoFatura";
            this.colIdHistoricoFatura.OptionsColumn.AllowEdit = false;
            this.colIdHistoricoFatura.Visible = true;
            this.colIdHistoricoFatura.VisibleIndex = 0;
            this.colIdHistoricoFatura.Width = 71;
            // 
            // colClienteNotificadoHistoricoFatura
            // 
            this.colClienteNotificadoHistoricoFatura.Caption = "Cliente Notificado";
            this.colClienteNotificadoHistoricoFatura.FieldName = "IsClienteNotificado";
            this.colClienteNotificadoHistoricoFatura.Name = "colClienteNotificadoHistoricoFatura";
            this.colClienteNotificadoHistoricoFatura.OptionsColumn.AllowEdit = false;
            this.colClienteNotificadoHistoricoFatura.Visible = true;
            this.colClienteNotificadoHistoricoFatura.VisibleIndex = 1;
            this.colClienteNotificadoHistoricoFatura.Width = 106;
            // 
            // colComentarioHistoricoFatura
            // 
            this.colComentarioHistoricoFatura.Caption = "Comentário";
            this.colComentarioHistoricoFatura.FieldName = "Comentario";
            this.colComentarioHistoricoFatura.Name = "colComentarioHistoricoFatura";
            this.colComentarioHistoricoFatura.OptionsColumn.AllowEdit = false;
            this.colComentarioHistoricoFatura.Visible = true;
            this.colComentarioHistoricoFatura.VisibleIndex = 2;
            this.colComentarioHistoricoFatura.Width = 726;
            // 
            // colDataCriacaoHistoricoFatura
            // 
            this.colDataCriacaoHistoricoFatura.Caption = "Criação";
            this.colDataCriacaoHistoricoFatura.FieldName = "DataCriacao";
            this.colDataCriacaoHistoricoFatura.Name = "colDataCriacaoHistoricoFatura";
            this.colDataCriacaoHistoricoFatura.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoHistoricoFatura.Visible = true;
            this.colDataCriacaoHistoricoFatura.VisibleIndex = 3;
            this.colDataCriacaoHistoricoFatura.Width = 117;
            // 
            // colDataAtualizacaoHistoricoFatura
            // 
            this.colDataAtualizacaoHistoricoFatura.Caption = "Atualização";
            this.colDataAtualizacaoHistoricoFatura.FieldName = "DataAtualizacao";
            this.colDataAtualizacaoHistoricoFatura.Name = "colDataAtualizacaoHistoricoFatura";
            this.colDataAtualizacaoHistoricoFatura.OptionsColumn.AllowEdit = false;
            this.colDataAtualizacaoHistoricoFatura.Visible = true;
            this.colDataAtualizacaoHistoricoFatura.VisibleIndex = 4;
            this.colDataAtualizacaoHistoricoFatura.Width = 122;
            // 
            // gridViewFaturasItensFatura
            // 
            this.gridViewFaturasItensFatura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeProdutoItemFaturaFatura,
            this.colQuantidadeItemFaturaFatura,
            this.colPrecoUnitarioItemFaturaFatura,
            this.colPrecoTotalItemFaturaFatura,
            this.colIdItemPedidoItemFaturaFatura,
            this.colIdFaturaItemFaturaFatura});
            this.gridViewFaturasItensFatura.GridControl = this.gridControlPedidos;
            this.gridViewFaturasItensFatura.Name = "gridViewFaturasItensFatura";
            // 
            // colNomeProdutoItemFaturaFatura
            // 
            this.colNomeProdutoItemFaturaFatura.Caption = "Nome Produto";
            this.colNomeProdutoItemFaturaFatura.FieldName = "NomeProduto";
            this.colNomeProdutoItemFaturaFatura.Name = "colNomeProdutoItemFaturaFatura";
            this.colNomeProdutoItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colNomeProdutoItemFaturaFatura.Visible = true;
            this.colNomeProdutoItemFaturaFatura.VisibleIndex = 0;
            this.colNomeProdutoItemFaturaFatura.Width = 572;
            // 
            // colQuantidadeItemFaturaFatura
            // 
            this.colQuantidadeItemFaturaFatura.Caption = "Quantidade";
            this.colQuantidadeItemFaturaFatura.FieldName = "Quantidade";
            this.colQuantidadeItemFaturaFatura.Name = "colQuantidadeItemFaturaFatura";
            this.colQuantidadeItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colQuantidadeItemFaturaFatura.Visible = true;
            this.colQuantidadeItemFaturaFatura.VisibleIndex = 1;
            this.colQuantidadeItemFaturaFatura.Width = 138;
            // 
            // colPrecoUnitarioItemFaturaFatura
            // 
            this.colPrecoUnitarioItemFaturaFatura.Caption = "Preço Unitário";
            this.colPrecoUnitarioItemFaturaFatura.FieldName = "PrecoUnitario";
            this.colPrecoUnitarioItemFaturaFatura.Name = "colPrecoUnitarioItemFaturaFatura";
            this.colPrecoUnitarioItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colPrecoUnitarioItemFaturaFatura.Visible = true;
            this.colPrecoUnitarioItemFaturaFatura.VisibleIndex = 2;
            this.colPrecoUnitarioItemFaturaFatura.Width = 138;
            // 
            // colPrecoTotalItemFaturaFatura
            // 
            this.colPrecoTotalItemFaturaFatura.Caption = "Preço Total";
            this.colPrecoTotalItemFaturaFatura.FieldName = "PrecoTotal";
            this.colPrecoTotalItemFaturaFatura.Name = "colPrecoTotalItemFaturaFatura";
            this.colPrecoTotalItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colPrecoTotalItemFaturaFatura.Visible = true;
            this.colPrecoTotalItemFaturaFatura.VisibleIndex = 3;
            this.colPrecoTotalItemFaturaFatura.Width = 105;
            // 
            // colIdItemPedidoItemFaturaFatura
            // 
            this.colIdItemPedidoItemFaturaFatura.Caption = "Id Item Pedido";
            this.colIdItemPedidoItemFaturaFatura.FieldName = "IdItemPedido";
            this.colIdItemPedidoItemFaturaFatura.Name = "colIdItemPedidoItemFaturaFatura";
            this.colIdItemPedidoItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colIdItemPedidoItemFaturaFatura.Visible = true;
            this.colIdItemPedidoItemFaturaFatura.VisibleIndex = 4;
            this.colIdItemPedidoItemFaturaFatura.Width = 98;
            // 
            // colIdFaturaItemFaturaFatura
            // 
            this.colIdFaturaItemFaturaFatura.Caption = "Id Fatura";
            this.colIdFaturaItemFaturaFatura.FieldName = "IdFatura";
            this.colIdFaturaItemFaturaFatura.Name = "colIdFaturaItemFaturaFatura";
            this.colIdFaturaItemFaturaFatura.OptionsColumn.AllowEdit = false;
            this.colIdFaturaItemFaturaFatura.Visible = true;
            this.colIdFaturaItemFaturaFatura.VisibleIndex = 5;
            this.colIdFaturaItemFaturaFatura.Width = 91;
            // 
            // gridViewEntregas
            // 
            this.gridViewEntregas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEntrega,
            this.colNumeroEntregaEntrega,
            this.colDataCriacaoEntrega,
            this.colDataAtualizacaoEntrega});
            this.gridViewEntregas.GridControl = this.gridControlPedidos;
            this.gridViewEntregas.Name = "gridViewEntregas";
            // 
            // colIdEntrega
            // 
            this.colIdEntrega.Caption = "Id";
            this.colIdEntrega.FieldName = "Id";
            this.colIdEntrega.Name = "colIdEntrega";
            this.colIdEntrega.OptionsColumn.AllowEdit = false;
            this.colIdEntrega.Visible = true;
            this.colIdEntrega.VisibleIndex = 0;
            this.colIdEntrega.Width = 67;
            // 
            // colNumeroEntregaEntrega
            // 
            this.colNumeroEntregaEntrega.Caption = "Número da Entrega";
            this.colNumeroEntregaEntrega.FieldName = "NumeroEntrega";
            this.colNumeroEntregaEntrega.Name = "colNumeroEntregaEntrega";
            this.colNumeroEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colNumeroEntregaEntrega.Visible = true;
            this.colNumeroEntregaEntrega.VisibleIndex = 1;
            this.colNumeroEntregaEntrega.Width = 868;
            // 
            // colDataCriacaoEntrega
            // 
            this.colDataCriacaoEntrega.Caption = "Criação";
            this.colDataCriacaoEntrega.FieldName = "DataCriacao";
            this.colDataCriacaoEntrega.Name = "colDataCriacaoEntrega";
            this.colDataCriacaoEntrega.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoEntrega.Visible = true;
            this.colDataCriacaoEntrega.VisibleIndex = 2;
            this.colDataCriacaoEntrega.Width = 102;
            // 
            // colDataAtualizacaoEntrega
            // 
            this.colDataAtualizacaoEntrega.Caption = "Atualização";
            this.colDataAtualizacaoEntrega.FieldName = "DataAtualizacao";
            this.colDataAtualizacaoEntrega.Name = "colDataAtualizacaoEntrega";
            this.colDataAtualizacaoEntrega.OptionsColumn.AllowEdit = false;
            this.colDataAtualizacaoEntrega.Visible = true;
            this.colDataAtualizacaoEntrega.VisibleIndex = 3;
            this.colDataAtualizacaoEntrega.Width = 105;
            // 
            // gridViewEntregasHistoricos
            // 
            this.gridViewEntregasHistoricos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHistoricoEntrega,
            this.colClienteNotificadoHistoricoEntrega,
            this.colComentarioHistoricoEntrega,
            this.colDataCriacaoHistoricoEntrega});
            this.gridViewEntregasHistoricos.GridControl = this.gridControlPedidos;
            this.gridViewEntregasHistoricos.Name = "gridViewEntregasHistoricos";
            // 
            // colIdHistoricoEntrega
            // 
            this.colIdHistoricoEntrega.Caption = "Id";
            this.colIdHistoricoEntrega.FieldName = "Id";
            this.colIdHistoricoEntrega.Name = "colIdHistoricoEntrega";
            this.colIdHistoricoEntrega.OptionsColumn.AllowEdit = false;
            this.colIdHistoricoEntrega.Visible = true;
            this.colIdHistoricoEntrega.VisibleIndex = 0;
            this.colIdHistoricoEntrega.Width = 56;
            // 
            // colClienteNotificadoHistoricoEntrega
            // 
            this.colClienteNotificadoHistoricoEntrega.Caption = "Cliente Notificado";
            this.colClienteNotificadoHistoricoEntrega.FieldName = "IsClienteNotificado";
            this.colClienteNotificadoHistoricoEntrega.Name = "colClienteNotificadoHistoricoEntrega";
            this.colClienteNotificadoHistoricoEntrega.OptionsColumn.AllowEdit = false;
            this.colClienteNotificadoHistoricoEntrega.Visible = true;
            this.colClienteNotificadoHistoricoEntrega.VisibleIndex = 1;
            this.colClienteNotificadoHistoricoEntrega.Width = 99;
            // 
            // colComentarioHistoricoEntrega
            // 
            this.colComentarioHistoricoEntrega.Caption = "Comentário";
            this.colComentarioHistoricoEntrega.FieldName = "Comentario";
            this.colComentarioHistoricoEntrega.Name = "colComentarioHistoricoEntrega";
            this.colComentarioHistoricoEntrega.OptionsColumn.AllowEdit = false;
            this.colComentarioHistoricoEntrega.Visible = true;
            this.colComentarioHistoricoEntrega.VisibleIndex = 2;
            this.colComentarioHistoricoEntrega.Width = 871;
            // 
            // colDataCriacaoHistoricoEntrega
            // 
            this.colDataCriacaoHistoricoEntrega.Caption = "Criação";
            this.colDataCriacaoHistoricoEntrega.FieldName = "DataCriacao";
            this.colDataCriacaoHistoricoEntrega.Name = "colDataCriacaoHistoricoEntrega";
            this.colDataCriacaoHistoricoEntrega.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoHistoricoEntrega.Visible = true;
            this.colDataCriacaoHistoricoEntrega.VisibleIndex = 3;
            this.colDataCriacaoHistoricoEntrega.Width = 116;
            // 
            // gridViewEntregasItensEntrega
            // 
            this.gridViewEntregasItensEntrega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdItemEntregaEntrega,
            this.colNomeProdutoItemEntregaEntrega,
            this.colPrecoUnitarioItemEntregaEntrega,
            this.colQuantidadeItemEntregaEntrega,
            this.colPesoItemEntregaEntrega,
            this.colIdItemPedidoItemEntregaEntrega,
            this.colIdEntregaItemEntregaEntrega});
            this.gridViewEntregasItensEntrega.GridControl = this.gridControlPedidos;
            this.gridViewEntregasItensEntrega.Name = "gridViewEntregasItensEntrega";
            // 
            // colIdItemEntregaEntrega
            // 
            this.colIdItemEntregaEntrega.Caption = "Id";
            this.colIdItemEntregaEntrega.FieldName = "Id";
            this.colIdItemEntregaEntrega.Name = "colIdItemEntregaEntrega";
            this.colIdItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colIdItemEntregaEntrega.Width = 59;
            // 
            // colNomeProdutoItemEntregaEntrega
            // 
            this.colNomeProdutoItemEntregaEntrega.Caption = "Nome Produto";
            this.colNomeProdutoItemEntregaEntrega.FieldName = "NomeProduto";
            this.colNomeProdutoItemEntregaEntrega.Name = "colNomeProdutoItemEntregaEntrega";
            this.colNomeProdutoItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colNomeProdutoItemEntregaEntrega.Visible = true;
            this.colNomeProdutoItemEntregaEntrega.VisibleIndex = 0;
            this.colNomeProdutoItemEntregaEntrega.Width = 537;
            // 
            // colPrecoUnitarioItemEntregaEntrega
            // 
            this.colPrecoUnitarioItemEntregaEntrega.Caption = "Preço Unitário";
            this.colPrecoUnitarioItemEntregaEntrega.FieldName = "PrecoUnitario";
            this.colPrecoUnitarioItemEntregaEntrega.Name = "colPrecoUnitarioItemEntregaEntrega";
            this.colPrecoUnitarioItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colPrecoUnitarioItemEntregaEntrega.Visible = true;
            this.colPrecoUnitarioItemEntregaEntrega.VisibleIndex = 1;
            this.colPrecoUnitarioItemEntregaEntrega.Width = 107;
            // 
            // colQuantidadeItemEntregaEntrega
            // 
            this.colQuantidadeItemEntregaEntrega.Caption = "Quantidade";
            this.colQuantidadeItemEntregaEntrega.FieldName = "Quantidade";
            this.colQuantidadeItemEntregaEntrega.Name = "colQuantidadeItemEntregaEntrega";
            this.colQuantidadeItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colQuantidadeItemEntregaEntrega.Visible = true;
            this.colQuantidadeItemEntregaEntrega.VisibleIndex = 2;
            this.colQuantidadeItemEntregaEntrega.Width = 107;
            // 
            // colPesoItemEntregaEntrega
            // 
            this.colPesoItemEntregaEntrega.Caption = "Peso";
            this.colPesoItemEntregaEntrega.FieldName = "Peso";
            this.colPesoItemEntregaEntrega.Name = "colPesoItemEntregaEntrega";
            this.colPesoItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colPesoItemEntregaEntrega.Visible = true;
            this.colPesoItemEntregaEntrega.VisibleIndex = 3;
            this.colPesoItemEntregaEntrega.Width = 107;
            // 
            // colIdItemPedidoItemEntregaEntrega
            // 
            this.colIdItemPedidoItemEntregaEntrega.Caption = "Id Item Pedido";
            this.colIdItemPedidoItemEntregaEntrega.FieldName = "IdItemPedido";
            this.colIdItemPedidoItemEntregaEntrega.Name = "colIdItemPedidoItemEntregaEntrega";
            this.colIdItemPedidoItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colIdItemPedidoItemEntregaEntrega.Visible = true;
            this.colIdItemPedidoItemEntregaEntrega.VisibleIndex = 4;
            this.colIdItemPedidoItemEntregaEntrega.Width = 107;
            // 
            // colIdEntregaItemEntregaEntrega
            // 
            this.colIdEntregaItemEntregaEntrega.Caption = "Id Entrega";
            this.colIdEntregaItemEntregaEntrega.FieldName = "IdEntrega";
            this.colIdEntregaItemEntregaEntrega.Name = "colIdEntregaItemEntregaEntrega";
            this.colIdEntregaItemEntregaEntrega.OptionsColumn.AllowEdit = false;
            this.colIdEntregaItemEntregaEntrega.Visible = true;
            this.colIdEntregaItemEntregaEntrega.VisibleIndex = 5;
            this.colIdEntregaItemEntregaEntrega.Width = 118;
            // 
            // gridViewRastreamentos
            // 
            this.gridViewRastreamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRastreamentoEntrega,
            this.colTituloRastreamentoEntrega,
            this.colCodigoRastreioRastreamentoEntrega,
            this.colTransportadoraRastreamentoEntrega,
            this.colDataCriacaoRastreamentoEntrega,
            this.colDataAtualizacaoRastreamentoEntrega});
            this.gridViewRastreamentos.GridControl = this.gridControlPedidos;
            this.gridViewRastreamentos.Name = "gridViewRastreamentos";
            // 
            // colIdRastreamentoEntrega
            // 
            this.colIdRastreamentoEntrega.Caption = "Id";
            this.colIdRastreamentoEntrega.FieldName = "Id";
            this.colIdRastreamentoEntrega.Name = "colIdRastreamentoEntrega";
            this.colIdRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colIdRastreamentoEntrega.Visible = true;
            this.colIdRastreamentoEntrega.VisibleIndex = 0;
            this.colIdRastreamentoEntrega.Width = 69;
            // 
            // colTituloRastreamentoEntrega
            // 
            this.colTituloRastreamentoEntrega.Caption = "Título";
            this.colTituloRastreamentoEntrega.FieldName = "Titulo";
            this.colTituloRastreamentoEntrega.Name = "colTituloRastreamentoEntrega";
            this.colTituloRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colTituloRastreamentoEntrega.Visible = true;
            this.colTituloRastreamentoEntrega.VisibleIndex = 1;
            this.colTituloRastreamentoEntrega.Width = 479;
            // 
            // colCodigoRastreioRastreamentoEntrega
            // 
            this.colCodigoRastreioRastreamentoEntrega.Caption = "Código de Rastreio";
            this.colCodigoRastreioRastreamentoEntrega.FieldName = "CodigoRastreio";
            this.colCodigoRastreioRastreamentoEntrega.Name = "colCodigoRastreioRastreamentoEntrega";
            this.colCodigoRastreioRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colCodigoRastreioRastreamentoEntrega.Visible = true;
            this.colCodigoRastreioRastreamentoEntrega.VisibleIndex = 2;
            this.colCodigoRastreioRastreamentoEntrega.Width = 147;
            // 
            // colTransportadoraRastreamentoEntrega
            // 
            this.colTransportadoraRastreamentoEntrega.Caption = "Trasportadora";
            this.colTransportadoraRastreamentoEntrega.FieldName = "Transportadora";
            this.colTransportadoraRastreamentoEntrega.Name = "colTransportadoraRastreamentoEntrega";
            this.colTransportadoraRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colTransportadoraRastreamentoEntrega.Visible = true;
            this.colTransportadoraRastreamentoEntrega.VisibleIndex = 3;
            this.colTransportadoraRastreamentoEntrega.Width = 147;
            // 
            // colDataCriacaoRastreamentoEntrega
            // 
            this.colDataCriacaoRastreamentoEntrega.Caption = "Criação";
            this.colDataCriacaoRastreamentoEntrega.FieldName = "DataCriacao";
            this.colDataCriacaoRastreamentoEntrega.Name = "colDataCriacaoRastreamentoEntrega";
            this.colDataCriacaoRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colDataCriacaoRastreamentoEntrega.Visible = true;
            this.colDataCriacaoRastreamentoEntrega.VisibleIndex = 4;
            this.colDataCriacaoRastreamentoEntrega.Width = 147;
            // 
            // colDataAtualizacaoRastreamentoEntrega
            // 
            this.colDataAtualizacaoRastreamentoEntrega.Caption = "Atualização";
            this.colDataAtualizacaoRastreamentoEntrega.FieldName = "DataAtualizacao";
            this.colDataAtualizacaoRastreamentoEntrega.Name = "colDataAtualizacaoRastreamentoEntrega";
            this.colDataAtualizacaoRastreamentoEntrega.OptionsColumn.AllowEdit = false;
            this.colDataAtualizacaoRastreamentoEntrega.Visible = true;
            this.colDataAtualizacaoRastreamentoEntrega.VisibleIndex = 5;
            this.colDataAtualizacaoRastreamentoEntrega.Width = 153;
            // 
            // gridViewPedidos
            // 
            this.gridViewPedidos.GridControl = this.gridControlPedidos;
            this.gridViewPedidos.Name = "gridViewPedidos";
            this.gridViewPedidos.OptionsSelection.MultiSelect = true;
            this.gridViewPedidos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewPedidos.DoubleClick += new System.EventHandler(this.gridViewPedidos_DoubleClick);
            // 
            // repositoryItemButtonEditActionDelete
            // 
            this.repositoryItemButtonEditActionDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject1.Image")));
            serializableAppearanceObject1.Options.UseImage = true;
            serializableAppearanceObject2.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject2.Image")));
            serializableAppearanceObject2.Options.UseImage = true;
            serializableAppearanceObject3.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject3.Image")));
            serializableAppearanceObject3.Options.UseImage = true;
            serializableAppearanceObject4.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject4.Image")));
            serializableAppearanceObject4.Options.UseImage = true;
            this.repositoryItemButtonEditActionDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null)});
            this.repositoryItemButtonEditActionDelete.Name = "repositoryItemButtonEditActionDelete";
            this.repositoryItemButtonEditActionDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditActionDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditActionDelete_ButtonClick);
            // 
            // labelControlNumeroPedido
            // 
            this.labelControlNumeroPedido.Location = new System.Drawing.Point(8, 17);
            this.labelControlNumeroPedido.Name = "labelControlNumeroPedido";
            this.labelControlNumeroPedido.Size = new System.Drawing.Size(87, 13);
            this.labelControlNumeroPedido.TabIndex = 1;
            this.labelControlNumeroPedido.Text = "Número do Pedido";
            // 
            // textEditNumeroPedido
            // 
            this.textEditNumeroPedido.Location = new System.Drawing.Point(101, 14);
            this.textEditNumeroPedido.Name = "textEditNumeroPedido";
            this.textEditNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.textEditNumeroPedido.TabIndex = 2;
            // 
            // labelControlDataInicial
            // 
            this.labelControlDataInicial.Location = new System.Drawing.Point(207, 17);
            this.labelControlDataInicial.Name = "labelControlDataInicial";
            this.labelControlDataInicial.Size = new System.Drawing.Size(53, 13);
            this.labelControlDataInicial.TabIndex = 3;
            this.labelControlDataInicial.Text = "Data Inicial";
            // 
            // labelControlDataFinal
            // 
            this.labelControlDataFinal.Location = new System.Drawing.Point(372, 17);
            this.labelControlDataFinal.Name = "labelControlDataFinal";
            this.labelControlDataFinal.Size = new System.Drawing.Size(48, 13);
            this.labelControlDataFinal.TabIndex = 4;
            this.labelControlDataFinal.Text = "Data Final";
            // 
            // dateEditDataInicial
            // 
            this.dateEditDataInicial.EditValue = null;
            this.dateEditDataInicial.Location = new System.Drawing.Point(266, 14);
            this.dateEditDataInicial.Name = "dateEditDataInicial";
            this.dateEditDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDataInicial.Size = new System.Drawing.Size(100, 20);
            this.dateEditDataInicial.TabIndex = 5;
            // 
            // dateEditDataFinal
            // 
            this.dateEditDataFinal.EditValue = null;
            this.dateEditDataFinal.Location = new System.Drawing.Point(426, 14);
            this.dateEditDataFinal.Name = "dateEditDataFinal";
            this.dateEditDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDataFinal.Size = new System.Drawing.Size(100, 20);
            this.dateEditDataFinal.TabIndex = 6;
            // 
            // panelControlFiltros
            // 
            this.panelControlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlFiltros.Controls.Add(this.simpleButtonExcluir);
            this.panelControlFiltros.Controls.Add(this.simpleButtonFiltrar);
            this.panelControlFiltros.Controls.Add(this.labelControlNumeroPedido);
            this.panelControlFiltros.Controls.Add(this.dateEditDataFinal);
            this.panelControlFiltros.Controls.Add(this.textEditNumeroPedido);
            this.panelControlFiltros.Controls.Add(this.dateEditDataInicial);
            this.panelControlFiltros.Controls.Add(this.labelControlDataInicial);
            this.panelControlFiltros.Controls.Add(this.labelControlDataFinal);
            this.panelControlFiltros.Location = new System.Drawing.Point(12, 12);
            this.panelControlFiltros.Name = "panelControlFiltros";
            this.panelControlFiltros.Size = new System.Drawing.Size(748, 49);
            this.panelControlFiltros.TabIndex = 7;
            // 
            // simpleButtonExcluir
            // 
            this.simpleButtonExcluir.Location = new System.Drawing.Point(613, 12);
            this.simpleButtonExcluir.Name = "simpleButtonExcluir";
            this.simpleButtonExcluir.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonExcluir.TabIndex = 8;
            this.simpleButtonExcluir.Text = "Excluir";
            this.simpleButtonExcluir.Click += new System.EventHandler(this.simpleButtonExcluir_Click);
            // 
            // simpleButtonFiltrar
            // 
            this.simpleButtonFiltrar.Location = new System.Drawing.Point(532, 12);
            this.simpleButtonFiltrar.Name = "simpleButtonFiltrar";
            this.simpleButtonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonFiltrar.TabIndex = 7;
            this.simpleButtonFiltrar.Text = "Filtrar";
            this.simpleButtonFiltrar.Click += new System.EventHandler(this.Filtrar_Click);
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
            this.progressPanel.Location = new System.Drawing.Point(257, 245);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(246, 66);
            this.progressPanel.TabIndex = 8;
            this.progressPanel.Text = "progressPanel";
            this.progressPanel.Visible = false;
            // 
            // VendasPedidosVendaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 567);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.panelControlFiltros);
            this.Controls.Add(this.gridControlPedidos);
            this.Name = "VendasPedidosVendaUI";
            this.Text = "Pedidos de Venda";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistoricos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasHistoricos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasItensFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregasHistoricos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntregasItensEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRastreamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditActionDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltros)).EndInit();
            this.panelControlFiltros.ResumeLayout(false);
            this.panelControlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPedidos;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
        private DevExpress.XtraEditors.LabelControl labelControlNumeroPedido;
        private DevExpress.XtraEditors.TextEdit textEditNumeroPedido;
        private DevExpress.XtraEditors.LabelControl labelControlDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControlDataFinal;
        private DevExpress.XtraEditors.DateEdit dateEditDataInicial;
        private DevExpress.XtraEditors.DateEdit dateEditDataFinal;
        private DevExpress.XtraEditors.PanelControl panelControlFiltros;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFiltrar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFiltrar;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProdutoItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoUnitarioOriginal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescontoItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotalItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colOpcoesItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colSkuItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colIdItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoBrutoItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacaoItemPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colProdutoItemPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEnderecoEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colLogradouroEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colCidadeEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colCEPEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeDestinatarioEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colSobrenomeDestinatarioEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefoneEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMagentoEnderecos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarioHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNotificadoHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedidoMagentoHistoricos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroFaturaFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colDescontoFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colFreteFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colStateFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacaoFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMagentoFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEnderecoCobrancaMagento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedidoMagentoFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdStoreMagentoFaturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFaturasHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoHistoricoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNotificadoHistoricoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarioHistoricoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacaoHistoricoFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFaturasItensFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdItemPedidoItemFaturaFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProdutoItemFaturaFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeItemFaturaFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoUnitarioItemFaturaFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoTotalItemFaturaFatura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFaturaItemFaturaFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntregas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacaoEntrega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntregasHistoricos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNotificadoHistoricoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarioHistoricoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoHistoricoEntrega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntregasItensEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProdutoItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoUnitarioItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdItemPedidoItemEntregaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntregaItemEntregaEntrega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRastreamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRastreamentoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colTituloRastreamentoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoRastreioRastreamentoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportadoraRastreamentoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacaoRastreamentoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacaoRastreamentoEntrega;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditActionDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcluir;
    }
}