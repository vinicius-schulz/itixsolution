namespace ITIX.ViewForm
{
    partial class CadastrosProdutosDetalheUI
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
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.textBoxPesoBruto = new System.Windows.Forms.TextBox();
            this.textBoxPesoLiquido = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelPesoBruto = new System.Windows.Forms.Label();
            this.labelPesoLiquido = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.headerComponent = new ITIX.ViewForm.Components.HeaderComponent();
            this.panelCampos.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(13, 13);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.labelNomeProduto.TabIndex = 0;
            this.labelNomeProduto.Text = "Nome do Produto";
            // 
            // panelCampos
            // 
            this.panelCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.Controls.Add(this.textBoxPesoBruto);
            this.panelCampos.Controls.Add(this.textBoxPesoLiquido);
            this.panelCampos.Controls.Add(this.textBoxPreco);
            this.panelCampos.Controls.Add(this.textBoxDescricao);
            this.panelCampos.Controls.Add(this.textBoxNomeProduto);
            this.panelCampos.Controls.Add(this.labelPesoBruto);
            this.panelCampos.Controls.Add(this.labelPesoLiquido);
            this.panelCampos.Controls.Add(this.labelPreco);
            this.panelCampos.Controls.Add(this.labelDescricao);
            this.panelCampos.Controls.Add(this.labelNomeProduto);
            this.panelCampos.Location = new System.Drawing.Point(12, 75);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(594, 314);
            this.panelCampos.TabIndex = 1;
            // 
            // textBoxPesoBruto
            // 
            this.textBoxPesoBruto.Location = new System.Drawing.Point(484, 62);
            this.textBoxPesoBruto.Name = "textBoxPesoBruto";
            this.textBoxPesoBruto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoBruto.TabIndex = 11;
            this.textBoxPesoBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPesoLiquido
            // 
            this.textBoxPesoLiquido.Location = new System.Drawing.Point(302, 62);
            this.textBoxPesoLiquido.Name = "textBoxPesoLiquido";
            this.textBoxPesoLiquido.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoLiquido.TabIndex = 10;
            this.textBoxPesoLiquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(109, 62);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreco.TabIndex = 9;
            this.textBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(109, 36);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(475, 20);
            this.textBoxDescricao.TabIndex = 8;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(109, 10);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(475, 20);
            this.textBoxNomeProduto.TabIndex = 7;
            // 
            // labelPesoBruto
            // 
            this.labelPesoBruto.AutoSize = true;
            this.labelPesoBruto.Location = new System.Drawing.Point(419, 65);
            this.labelPesoBruto.Name = "labelPesoBruto";
            this.labelPesoBruto.Size = new System.Drawing.Size(59, 13);
            this.labelPesoBruto.TabIndex = 5;
            this.labelPesoBruto.Text = "Peso Bruto";
            // 
            // labelPesoLiquido
            // 
            this.labelPesoLiquido.AutoSize = true;
            this.labelPesoLiquido.Location = new System.Drawing.Point(226, 65);
            this.labelPesoLiquido.Name = "labelPesoLiquido";
            this.labelPesoLiquido.Size = new System.Drawing.Size(70, 13);
            this.labelPesoLiquido.TabIndex = 4;
            this.labelPesoLiquido.Text = "Peso Líquido";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(13, 65);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 3;
            this.labelPreco.Text = "Preço";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(13, 39);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoes.Controls.Add(this.buttonSair);
            this.panelBotoes.Controls.Add(this.buttonEditar);
            this.panelBotoes.Controls.Add(this.buttonSalvar);
            this.panelBotoes.Location = new System.Drawing.Point(12, 395);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(594, 57);
            this.panelBotoes.TabIndex = 2;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(178, 16);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(97, 16);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(16, 16);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // headerComponent
            // 
            this.headerComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerComponent.Location = new System.Drawing.Point(12, 9);
            this.headerComponent.Name = "headerComponent";
            this.headerComponent.Size = new System.Drawing.Size(594, 60);
            this.headerComponent.TabIndex = 3;
            // 
            // CadastrosProdutosDetalheUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 464);
            this.Controls.Add(this.headerComponent);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCampos);
            this.Name = "CadastrosProdutosDetalheUI";
            this.Text = "CadastrosProdutosDetalheUI";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxPesoBruto;
        private System.Windows.Forms.TextBox textBoxPesoLiquido;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label labelPesoBruto;
        private System.Windows.Forms.Label labelPesoLiquido;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonSair;
        private Components.HeaderComponent headerComponent;
    }
}