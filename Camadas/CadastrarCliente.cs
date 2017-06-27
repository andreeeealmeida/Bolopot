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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dgvCliente.DataSource = dalCli.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadCliSalvar_Click(object sender, EventArgs e)
        {
            if(!txtCadNome.Text.Equals(String.Empty) && !txtCadTelefone.Text.Equals(String.Empty) && !cbSexo.Text.Equals(String.Empty) & !txtCadRua.Text.Equals(String.Empty) && !txtCadNum.Text.Equals(String.Empty))
            {
                MODEL.Cliente cliente = new MODEL.Cliente();
                DAL.Cliente dalCli = new DAL.Cliente();

                cliente.id = Convert.ToInt32(lblID.Text);
                cliente.nome = txtCadNome.Text;
                cliente.telefone = txtCadTelefone.Text;
                cliente.sexo = cbSexo.Text;
                cliente.rua_casa = txtCadRua.Text;
                cliente.numero_casa = txtCadNum.Text;

                dalCli.Insert(cliente);

                dgvCliente.DataSource = dalCli.Select();

                txtCadNome.Text = "";
                txtCadTelefone.Text = "";
                cbSexo.Text = "";
                txtCadRua.Text = "";
                txtCadNum.Text = "";
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DAL.Cliente dalCliente = new DAL.Cliente();
            dgvCliente.DataSource = dalCliente.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlFiltro.Visible = true;
            btnEsconder.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            DAL.Cliente dalCliente = new DAL.Cliente();
            DAL.Cliente dalCli = new DAL.Cliente();

            dgvCliente.DataSource = dalCli.Select();

            pnlFiltro.Visible = false;
            btnBuscar.Visible = true;
            btnEsconder.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblID.Text != string.Empty)
            {
                
                msg = "Deseja remover o cliente " + txtCadNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
                    Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
                    cliente.id = id;
                    bllCliente.Delete(cliente);
                    dgvCliente.DataSource = "";
                    dgvCliente.DataSource = bllCliente.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    

        private void rdTodos_CheckedChanged(object sender, EventArgs e)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dgvCliente.DataSource = dalCli.Select();
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
                if (txtFiltro.Text != string.Empty)
                {
                    Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
                    List<Camadas.MODEL.Cliente> lstCliente = new List<Camadas.MODEL.Cliente>();

                if (rdNome.Checked)
                    lstCliente = bllCliente.SelectByName(txtFiltro.Text);

                    dgvCliente.DataSource = "";
                    dgvCliente.DataSource = lstCliente;
                }
                else
                {
                    string msg = "Campo Pesquisa esta vazio...";
                    MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MODEL.Cliente cliente = new MODEL.Cliente();
            DAL.Cliente dalCli = new DAL.Cliente();

            cliente.id = Convert.ToInt32(lblID.Text);
            cliente.nome = txtCadNome.Text;
            cliente.telefone = txtCadTelefone.Text;
            cliente.sexo = cbSexo.Text;
            cliente.rua_casa = txtCadRua.Text;
            cliente.numero_casa = txtCadNum.Text;

            dalCli.Update(cliente);

            dgvCliente.DataSource = dalCli.Select();

            txtCadNome.Text = "";
            txtCadTelefone.Text = "";
            cbSexo.Text = "";
            txtCadRua.Text = "";
            txtCadNum.Text = "";
        }

        private void dgvCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                lblID.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtCadNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtCadTelefone.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                cbSexo.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtCadRua.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtCadNum.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
