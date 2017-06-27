namespace Bolopot.Camadas
{
    partial class SistemaBolopot
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEfetuarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.tsmiConsultar,
            this.tsmiEfetuarVenda,
            this.tsmiSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadCliente,
            this.tsmiCadProduto});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.clienteToolStripMenuItem.Text = "Cadastrar";
            // 
            // tsmiCadCliente
            // 
            this.tsmiCadCliente.Name = "tsmiCadCliente";
            this.tsmiCadCliente.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadCliente.Text = "Cliente";
            this.tsmiCadCliente.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // tsmiCadProduto
            // 
            this.tsmiCadProduto.Name = "tsmiCadProduto";
            this.tsmiCadProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadProduto.Text = "Produto";
            this.tsmiCadProduto.Click += new System.EventHandler(this.tsmiCadProduto_Click);
            // 
            // tsmiConsultar
            // 
            this.tsmiConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsCliente,
            this.tsmiConsRelVendas});
            this.tsmiConsultar.Name = "tsmiConsultar";
            this.tsmiConsultar.Size = new System.Drawing.Size(70, 20);
            this.tsmiConsultar.Text = "Consultar";
            // 
            // tsmiConsCliente
            // 
            this.tsmiConsCliente.Name = "tsmiConsCliente";
            this.tsmiConsCliente.Size = new System.Drawing.Size(177, 22);
            this.tsmiConsCliente.Text = "Clientes";
            this.tsmiConsCliente.Click += new System.EventHandler(this.tsmiConsCliente_Click);
            // 
            // tsmiConsRelVendas
            // 
            this.tsmiConsRelVendas.Name = "tsmiConsRelVendas";
            this.tsmiConsRelVendas.Size = new System.Drawing.Size(177, 22);
            this.tsmiConsRelVendas.Text = "Relatório de vendas";
            this.tsmiConsRelVendas.Click += new System.EventHandler(this.tsmiConsRelVendas_Click);
            // 
            // tsmiEfetuarVenda
            // 
            this.tsmiEfetuarVenda.Name = "tsmiEfetuarVenda";
            this.tsmiEfetuarVenda.Size = new System.Drawing.Size(91, 20);
            this.tsmiEfetuarVenda.Text = "Efetuar venda";
            this.tsmiEfetuarVenda.Click += new System.EventHandler(this.tsmiEfetuarVenda_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // SistemaBolopot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SistemaBolopot";
            this.Text = "SistemaBolopot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiEfetuarVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsRelVendas;
    }
}