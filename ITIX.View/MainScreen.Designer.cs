namespace ITIX.View
{
    partial class MainScreen
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barHeader = new DevExpress.XtraBars.Bar();
            this.barSubItemCadastros = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemSuprimentos = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemEnderecamento = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemVendas = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemPedidosVenda = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPedidosEcommerce = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemConfiguracoes = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAcessos = new DevExpress.XtraBars.BarButtonItem();
            this.barFooter = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItemPedidosVenda = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemPedidosEcommerce = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemProdutos = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemAcessos = new DevExpress.XtraBars.BarSubItem();
            this.barDockingMenuItem = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barHeader,
            this.barFooter});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemSuprimentos,
            this.barSubItemVendas,
            this.barSubItemCadastros,
            this.barSubItemPedidosVenda,
            this.barSubItemPedidosEcommerce,
            this.barSubItemProdutos,
            this.barSubItemConfiguracoes,
            this.barSubItemAcessos,
            this.barButtonItemProdutos,
            this.barButtonItemPedidosVenda,
            this.barButtonItemPedidosEcommerce,
            this.barButtonItemAcessos,
            this.barDockingMenuItem,
            this.barButtonItem,
            this.barButtonItemClientes,
            this.barButtonItemEnderecamento});
            this.barManager.MainMenu = this.barHeader;
            this.barManager.MaxItemId = 16;
            this.barManager.StatusBar = this.barFooter;
            // 
            // barHeader
            // 
            this.barHeader.BarName = "Main menu";
            this.barHeader.DockCol = 0;
            this.barHeader.DockRow = 0;
            this.barHeader.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barHeader.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemCadastros),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemVendas)});
            this.barHeader.OptionsBar.MultiLine = true;
            this.barHeader.OptionsBar.UseWholeRow = true;
            this.barHeader.Text = "Main menu";
            // 
            // barSubItemCadastros
            // 
            this.barSubItemCadastros.Caption = "Cadastros";
            this.barSubItemCadastros.Id = 2;
            this.barSubItemCadastros.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemProdutos)});
            this.barSubItemCadastros.Name = "barSubItemCadastros";
            // 
            // barButtonItemProdutos
            // 
            this.barButtonItemProdutos.Caption = "Produtos";
            this.barButtonItemProdutos.Id = 8;
            this.barButtonItemProdutos.Name = "barButtonItemProdutos";
            this.barButtonItemProdutos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProdutos_ItemClick);
            // 
            // barButtonItemClientes
            // 
            this.barButtonItemClientes.Caption = "Clientes";
            this.barButtonItemClientes.Id = 14;
            this.barButtonItemClientes.Name = "barButtonItemClientes";
            // 
            // barSubItemSuprimentos
            // 
            this.barSubItemSuprimentos.Caption = "Suprimentos";
            this.barSubItemSuprimentos.Id = 0;
            this.barSubItemSuprimentos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEnderecamento)});
            this.barSubItemSuprimentos.Name = "barSubItemSuprimentos";
            // 
            // barButtonItemEnderecamento
            // 
            this.barButtonItemEnderecamento.Caption = "Endereçamento";
            this.barButtonItemEnderecamento.Id = 15;
            this.barButtonItemEnderecamento.Name = "barButtonItemEnderecamento";
            // 
            // barSubItemVendas
            // 
            this.barSubItemVendas.Caption = "Vendas";
            this.barSubItemVendas.Id = 1;
            this.barSubItemVendas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPedidosVenda)});
            this.barSubItemVendas.Name = "barSubItemVendas";
            // 
            // barButtonItemPedidosVenda
            // 
            this.barButtonItemPedidosVenda.Caption = "Pedidos de Venda";
            this.barButtonItemPedidosVenda.Id = 9;
            this.barButtonItemPedidosVenda.Name = "barButtonItemPedidosVenda";
            this.barButtonItemPedidosVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPedidosVenda_ItemClick);
            // 
            // barButtonItemPedidosEcommerce
            // 
            this.barButtonItemPedidosEcommerce.Caption = "Pedidos do E-commerce";
            this.barButtonItemPedidosEcommerce.Id = 10;
            this.barButtonItemPedidosEcommerce.Name = "barButtonItemPedidosEcommerce";
            // 
            // barSubItemConfiguracoes
            // 
            this.barSubItemConfiguracoes.Caption = "Configurações";
            this.barSubItemConfiguracoes.Id = 6;
            this.barSubItemConfiguracoes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAcessos)});
            this.barSubItemConfiguracoes.Name = "barSubItemConfiguracoes";
            // 
            // barButtonItemAcessos
            // 
            this.barButtonItemAcessos.Caption = "Acessos";
            this.barButtonItemAcessos.Id = 11;
            this.barButtonItemAcessos.Name = "barButtonItemAcessos";
            // 
            // barFooter
            // 
            this.barFooter.BarName = "Status bar";
            this.barFooter.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barFooter.DockCol = 0;
            this.barFooter.DockRow = 0;
            this.barFooter.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barFooter.OptionsBar.AllowQuickCustomization = false;
            this.barFooter.OptionsBar.DrawDragBorder = false;
            this.barFooter.OptionsBar.UseWholeRow = true;
            this.barFooter.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(818, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(818, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(818, 20);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // barSubItemPedidosVenda
            // 
            this.barSubItemPedidosVenda.Caption = "Pedidos de Venda";
            this.barSubItemPedidosVenda.Id = 3;
            this.barSubItemPedidosVenda.Name = "barSubItemPedidosVenda";
            // 
            // barSubItemPedidosEcommerce
            // 
            this.barSubItemPedidosEcommerce.Caption = "Pedidos do E-commerce";
            this.barSubItemPedidosEcommerce.Id = 4;
            this.barSubItemPedidosEcommerce.Name = "barSubItemPedidosEcommerce";
            // 
            // barSubItemProdutos
            // 
            this.barSubItemProdutos.Caption = "Produtos";
            this.barSubItemProdutos.Id = 5;
            this.barSubItemProdutos.Name = "barSubItemProdutos";
            // 
            // barSubItemAcessos
            // 
            this.barSubItemAcessos.Caption = "Acessos";
            this.barSubItemAcessos.Id = 7;
            this.barSubItemAcessos.Name = "barSubItemAcessos";
            // 
            // barDockingMenuItem
            // 
            this.barDockingMenuItem.Caption = "Window";
            this.barDockingMenuItem.Id = 12;
            this.barDockingMenuItem.Name = "barDockingMenuItem";
            // 
            // barButtonItem
            // 
            this.barButtonItem.Caption = "barButtonItem";
            this.barButtonItem.Id = 13;
            this.barButtonItem.Name = "barButtonItem";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.AllowDragDrop = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 480);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.Text = "Cantinho da Semente";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barHeader;
        private DevExpress.XtraBars.BarSubItem barSubItemCadastros;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProdutos;
        private DevExpress.XtraBars.BarSubItem barSubItemSuprimentos;
        private DevExpress.XtraBars.BarSubItem barSubItemVendas;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPedidosVenda;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPedidosEcommerce;
        private DevExpress.XtraBars.BarSubItem barSubItemConfiguracoes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAcessos;
        private DevExpress.XtraBars.Bar barFooter;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItemPedidosVenda;
        private DevExpress.XtraBars.BarSubItem barSubItemPedidosEcommerce;
        private DevExpress.XtraBars.BarSubItem barSubItemProdutos;
        private DevExpress.XtraBars.BarSubItem barSubItemAcessos;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClientes;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEnderecamento;
    }
}

