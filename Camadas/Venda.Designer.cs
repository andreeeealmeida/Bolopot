namespace Bolopot
{
    partial class Venda
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.lblProdutoBuscaNome = new System.Windows.Forms.Label();
            this.lblProdutoQuantidade = new System.Windows.Forms.Label();
            this.txtProdutoQuantidade = new System.Windows.Forms.TextBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cbNomeProd = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolopotDataSet = new Bolopot.BolopotDataSet();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new Bolopot.BolopotDataSetTableAdapters.ProdutoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ckbFiltrar = new System.Windows.Forms.CheckBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolopotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(157, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(75, 24);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNome.Location = new System.Drawing.Point(405, 57);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(48, 22);
            this.lblClienteNome.TabIndex = 3;
            this.lblClienteNome.Text = "Filtro";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(157, 57);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(24, 22);
            this.lblClienteId.TabIndex = 4;
            this.lblClienteId.Text = "ID";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(409, 82);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(211, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionar.Location = new System.Drawing.Point(457, 173);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 45);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valorUni,
            this.valorTotal});
            this.dgvVenda.Location = new System.Drawing.Point(53, 266);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(467, 208);
            this.dgvVenda.TabIndex = 10;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // lblProdutoBuscaNome
            // 
            this.lblProdutoBuscaNome.AutoSize = true;
            this.lblProdutoBuscaNome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoBuscaNome.Location = new System.Drawing.Point(156, 168);
            this.lblProdutoBuscaNome.Name = "lblProdutoBuscaNome";
            this.lblProdutoBuscaNome.Size = new System.Drawing.Size(130, 22);
            this.lblProdutoBuscaNome.TabIndex = 12;
            this.lblProdutoBuscaNome.Text = "Buscar por Nome";
            // 
            // lblProdutoQuantidade
            // 
            this.lblProdutoQuantidade.AutoSize = true;
            this.lblProdutoQuantidade.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoQuantidade.Location = new System.Drawing.Point(323, 168);
            this.lblProdutoQuantidade.Name = "lblProdutoQuantidade";
            this.lblProdutoQuantidade.Size = new System.Drawing.Size(91, 22);
            this.lblProdutoQuantidade.TabIndex = 13;
            this.lblProdutoQuantidade.Text = "Quantidade";
            // 
            // txtProdutoQuantidade
            // 
            this.txtProdutoQuantidade.Location = new System.Drawing.Point(327, 198);
            this.txtProdutoQuantidade.Name = "txtProdutoQuantidade";
            this.txtProdutoQuantidade.Size = new System.Drawing.Size(108, 20);
            this.txtProdutoQuantidade.TabIndex = 18;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoverItem.Location = new System.Drawing.Point(53, 480);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(145, 36);
            this.btnRemoverItem.TabIndex = 20;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(157, 133);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(81, 24);
            this.lblProduto.TabIndex = 21;
            this.lblProduto.Text = "Produto";
            // 
            // cbNomeProd
            // 
            this.cbNomeProd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "id", true));
            this.cbNomeProd.DataSource = this.produtoBindingSource1;
            this.cbNomeProd.DisplayMember = "descricao";
            this.cbNomeProd.FormattingEnabled = true;
            this.cbNomeProd.Location = new System.Drawing.Point(160, 197);
            this.cbNomeProd.Name = "cbNomeProd";
            this.cbNomeProd.Size = new System.Drawing.Size(161, 21);
            this.cbNomeProd.TabIndex = 24;
            this.cbNomeProd.ValueMember = "id";
            this.cbNomeProd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bolopotDataSet;
            // 
            // bolopotDataSet
            // 
            this.bolopotDataSet.DataSetName = "BolopotDataSet";
            this.bolopotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.bolopotDataSet;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFinalizar.Location = new System.Drawing.Point(570, 430);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 36);
            this.btnFinalizar.TabIndex = 25;
            this.btnFinalizar.Text = "Finalizar venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Recebido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Troco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(619, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(619, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(619, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(654, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 20);
            this.lblTotal.TabIndex = 32;
            // 
            // lblTroco
            // 
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTroco.Location = new System.Drawing.Point(654, 380);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(83, 20);
            this.lblTroco.TabIndex = 34;
            this.lblTroco.Click += new System.EventHandler(this.lblTroco_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(113, 201);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 13);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "-1";
            this.lblID.Visible = false;
            // 
            // ckbFiltrar
            // 
            this.ckbFiltrar.AutoSize = true;
            this.ckbFiltrar.Location = new System.Drawing.Point(626, 84);
            this.ckbFiltrar.Name = "ckbFiltrar";
            this.ckbFiltrar.Size = new System.Drawing.Size(51, 17);
            this.ckbFiltrar.TabIndex = 36;
            this.ckbFiltrar.Text = "Filtrar";
            this.ckbFiltrar.UseVisualStyleBackColor = true;
            this.ckbFiltrar.CheckedChanged += new System.EventHandler(this.ckbFiltrar_CheckedChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(161, 82);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(226, 21);
            this.cmbCliente.TabIndex = 37;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.Location = new System.Drawing.Point(654, 325);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(83, 26);
            this.txtRecibo.TabIndex = 38;
            this.txtRecibo.Leave += new System.EventHandler(this.txtRecibo_Leave);
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 150;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valorUni
            // 
            this.valorUni.DataPropertyName = "valorUni";
            this.valorUni.HeaderText = "Valor Unitário";
            this.valorUni.Name = "valorUni";
            this.valorUni.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 539);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.ckbFiltrar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cbNomeProd);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.txtProdutoQuantidade);
            this.Controls.Add(this.lblProdutoQuantidade);
            this.Controls.Add(this.lblProdutoBuscaNome);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.lblClienteNome);
            this.Controls.Add(this.lblCliente);
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolopotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label lblProdutoBuscaNome;
        private System.Windows.Forms.Label lblProdutoQuantidade;
        private System.Windows.Forms.TextBox txtProdutoQuantidade;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cbNomeProd;
        private System.Windows.Forms.Button btnFinalizar;
        private BolopotDataSet bolopotDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private BolopotDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox ckbFiltrar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}