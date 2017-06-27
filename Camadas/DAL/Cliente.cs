using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Clientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto cliente     
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    //carregar os dado no objeto cliente -- popular objeto
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.rua_casa = reader["rua_casa"].ToString();
                    cliente.numero_casa = reader["numero_casa"].ToString();
                    cliente.sexo = reader["sexo"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }


        public MODEL.Cliente selectById(int clienteID)
        {
            MODEL.Cliente cliente = new MODEL.Cliente();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Clientes where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", clienteID);
            conexao.Open();
            //try
            //{
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.rua_casa = reader["rua_casa"].ToString();
                    cliente.numero_casa = reader["numero_casa"].ToString();
                    cliente.sexo = reader["sexo"].ToString();
                }
            //}
            //catch
            //{
                Console.WriteLine("Erro - Sql Select Cliente....;");
            //}
            //finally
            //{
                conexao.Close();
            //}
            return cliente;
        }

        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values ";
            sql = sql + " (@nome, @telefone, @rua_casa, @numero_casa, @sexo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
            cmd.Parameters.AddWithValue("@rua_casa", cliente.rua_casa);
            cmd.Parameters.AddWithValue("@numero_casa", cliente.numero_casa);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Cliente> SelectByName(string nome)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Clientes where nome like @nome;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto cliente     
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    //carregar os dado no objeto cliente -- popular objeto
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.sexo = reader["sexo"].ToString();
                    cliente.rua_casa = reader["rua_casa"].ToString();
                    cliente.numero_casa = reader["numero_casa"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Clientes set nome=@nome, telefone=@telefone, ";
            sql += "rua_casa=@rua_casa, numero_casa=@numero_casa, sexo=@sexo";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
            cmd.Parameters.AddWithValue("@rua_casa", cliente.rua_casa);
            cmd.Parameters.AddWithValue("@numero_casa", cliente.numero_casa);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Clientes where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Cliente");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}