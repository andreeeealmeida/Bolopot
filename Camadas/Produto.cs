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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DAL.Produto dalProduto = new DAL.Produto();
            dgvProduto.DataSource = dalProduto.Select();
        }

        private void txtCadNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();
            Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            if (!txtDescricao.Text.Equals(String.Empty) && !txtQuantidade.Text.Equals(String.Empty) && !txtValor2.Text.Equals(String.Empty))
            {
                produto.descricao = txtDescricao.Text;
                produto.estoque = Convert.ToInt32(txtQuantidade.Text);
                produto.valor = Convert.ToInt32(txtValor2.Text);

                dalProd.Insert(produto);

                dgvProduto.DataSource = dalProd.Select();

                txtDescricao.Text = "";
                txtQuantidade.Text = "";
                txtValor2.Text = "";
            }
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dgvProduto.DataSource = dalProd.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MODEL.Produto produto = new MODEL.Produto();
            DAL.Produto dalProd = new DAL.Produto();

            produto.id = Convert.ToInt32(lblID.Text);
            produto.descricao = txtDescricao.Text;
            produto.estoque = Convert.ToInt32(txtQuantidade.Text);
            produto.valor = Convert.ToInt32(txtValor2.Text);

            dalProd.Update(produto);

            dgvProduto.DataSource = dalProd.Select();

            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlFiltro.Visible = true;
            btnEsconder.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            MODEL.Produto produto = new MODEL.Produto();
            DAL.Produto dalProd = new DAL.Produto();

            dgvProduto.DataSource = dalProd.Select();
            pnlFiltro.Visible = false;
            btnBuscar.Visible = true;
            btnEsconder.Visible = false;
        }

        private void dgvProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                lblID.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
                txtQuantidade.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
                txtValor2.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblID.Text != string.Empty)
            {

                msg = "Confirma Remoção do Cliente " + txtDescricao.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
                    Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();
                    produto.id = id;
                    bllProduto.Delete(produto);
                    dgvProduto.DataSource = "";
                    dgvProduto.DataSource = bllProduto.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text != string.Empty)
            {
                Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
                List<Camadas.MODEL.Produto> lstProduto = new List<Camadas.MODEL.Produto>();

                if (rdNome.Checked)
                    lstProduto = bllProduto.SelectByDesc(txtFiltro.Text);

                dgvProduto.DataSource = "";
                dgvProduto.DataSource = lstProduto;
            }
            else
            {
                string msg = "Campo Pesquisa esta vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
