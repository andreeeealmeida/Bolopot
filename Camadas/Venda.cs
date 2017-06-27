using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolopot
{
    public partial class Venda : Form
    {

        List<Camadas.MODEL.Venda_Item> lstCarrinho = new List<Camadas.MODEL.Venda_Item>();

        public Venda()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Venda_Item vendaItem = new Camadas.MODEL.Venda_Item();
            vendaItem.idProduto = Convert.ToInt32(cbNomeProd.SelectedValue);
            vendaItem.quantidade = Convert.ToInt32(txtProdutoQuantidade.Text);
            lstCarrinho.Add(vendaItem);
            carregarCarrinho();
            //dgvVenda.DataSource = dalVenda.Select();
        }


        private void carregarCarrinho()
        {
            Camadas.DAL.Produto dalProduto = new Camadas.DAL.Produto();
            var dados = from c in lstCarrinho
                        select new
                        {
                            produto = dalProduto.selectByID(c.idProduto).descricao,
                            quantidade = c.quantidade,
                            valorUni = "R$" + dalProduto.selectByID(c.idProduto).valor.ToString("0.00"),
                            valorTotal = "R$" + (dalProduto.selectByID(c.idProduto).valor * c.quantidade).ToString("0.00")
                        };
            dgvVenda.DataSource = dados.ToList();
            lblTotal.Text = lstCarrinho.Sum(p => p.quantidade * dalProduto.selectByID(p.idProduto).valor).ToString("0.00");
            verificarTroco();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bolopotDataSet.Produto' table. You can move, or remove it, as needed.
            Camadas.DAL.Cliente cliente = new Camadas.DAL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = cliente.Select();
            this.produtoTableAdapter.Fill(this.bolopotDataSet.Produto);
            Camadas.DAL.Venda_Item dalVenda = new Camadas.DAL.Venda_Item();
            dgvVenda.DataSource = dalVenda.Select();

        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            carregarClientes();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            carregarClientes();
        }

        private void carregarClientes()
        {
            Camadas.DAL.Cliente cliente = new Camadas.DAL.Cliente();
            if (ckbFiltrar.Checked)
            {
                cmbCliente.DataSource = cliente.SelectByName(txtFiltro.Text);
            }
            else
            {
                cmbCliente.DataSource = cliente.Select();
            }
        }

        private void lblTroco_Click(object sender, EventArgs e)
        {

        }

      
        private void txtRecibo_Leave(object sender, EventArgs e)
        {
            verificarTroco();
        }

        private void verificarTroco()
        {
            float recibo;
            if (float.TryParse(txtRecibo.Text, out recibo))
            {
                if (lblTotal.Text != "")
                {
                    lblTroco.Text = (recibo - Convert.ToSingle(lblTotal.Text)).ToString("0.00");
                }
            }
            else
            {
                txtRecibo.Text = "";
                lblTroco.Text = "";
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dgvVenda.SelectedRows.Count > 0)
            {
                lstCarrinho.RemoveAt(dgvVenda.SelectedRows[0].Index);
                carregarCarrinho();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Camadas.DAL.Venda dalVenda = new Camadas.DAL.Venda();
            Camadas.MODEL.Venda venda = new Camadas.MODEL.Venda();
            Camadas.DAL.Venda_Item dalVendaItem = new Camadas.DAL.Venda_Item();
            Camadas.DAL.Produto dalProduto = new Camadas.DAL.Produto();
            venda.cliente_id = Convert.ToInt32(cmbCliente.SelectedValue);
            venda.data = DateTime.Today;
            dalVenda.Insert(venda);
            List<Camadas.MODEL.Venda> lstVenda = dalVenda.Select();
            int idVenda = 0;
            for (int i  = 0; i < lstVenda.Count; i++)
            {
                if (idVenda < lstVenda[i].id)
                {
                    idVenda = lstVenda[i].id;
                }
            }
            for (int i = 0; i < lstCarrinho.Count; i++)
            {
                Camadas.MODEL.Venda_Item vendaItem = new Camadas.MODEL.Venda_Item();
                vendaItem.idProduto = lstCarrinho[i].idProduto;
                vendaItem.idVenda = idVenda;
                vendaItem.quantidade = lstCarrinho[i].quantidade;
                Camadas.MODEL.Produto produto = dalProduto.selectByID(vendaItem.idProduto);
                produto.estoque -= vendaItem.quantidade;
                dalProduto.Update(produto);
                dalVendaItem.Insert(vendaItem);
            }
            MessageBox.Show("Venda realizada com sucesso", "Venda Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Relatorio.relVenda.relatorio(idVenda);
            this.Close();
        }
    }
}
