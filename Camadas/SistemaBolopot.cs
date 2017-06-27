using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolopot.Camadas
{
    public partial class SistemaBolopot : Form
    {
        public SistemaBolopot()
        {
            InitializeComponent();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCliente = new CadastrarCliente();
            cadCliente.Show();
        }

        private void tsmiConsCliente_Click(object sender, EventArgs e)
        {
            Relatorio.RelCliente.relatorio();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiConsRelVendas_Click(object sender, EventArgs e)
        {
            ConsultarVendas consVenda = new ConsultarVendas();
            consVenda.Show();
        }

        private void tsmiCadProduto_Click(object sender, EventArgs e)
        {
            Form1 cadProduto = new Form1();
            cadProduto.Show();
        }

        private void tsmiEfetuarVenda_Click(object sender, EventArgs e)
        {
            Venda novaVenda = new Venda();
            novaVenda.Show(); 
        }
    }
}
