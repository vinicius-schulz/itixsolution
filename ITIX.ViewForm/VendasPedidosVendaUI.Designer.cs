namespace ITIX.ViewForm
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGeralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedidos.AutoGenerateColumns = false;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.totalGeralDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridViewPedidos.DataSource = this.pedidoBindingSource;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(776, 372);
            this.dataGridViewPedidos.TabIndex = 0;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(ITIX.Core.Model.Pedido);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // totalGeralDataGridViewTextBoxColumn
            // 
            this.totalGeralDataGridViewTextBoxColumn.DataPropertyName = "TotalGeral";
            this.totalGeralDataGridViewTextBoxColumn.HeaderText = "TotalGeral";
            this.totalGeralDataGridViewTextBoxColumn.Name = "totalGeralDataGridViewTextBoxColumn";
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFilters.Controls.Add(this.buttonFiltrar);
            this.panelFilters.Controls.Add(this.textBox1);
            this.panelFilters.Controls.Add(this.labelId);
            this.panelFilters.Location = new System.Drawing.Point(12, 12);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(776, 48);
            this.panelFilters.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(131, 9);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // VendasPedidosVendaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "VendasPedidosVendaUI";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.VendasPedidosVendaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGeralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelId;
    }
}