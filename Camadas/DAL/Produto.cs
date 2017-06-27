using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto cliente     
                    MODEL.Produto produto = new MODEL.Produto();
                    //carregar os dado no objeto cliente -- popular objeto
                    produto.id = Convert.ToInt32(reader["id"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.estoque = Convert.ToInt32(reader["estoque"].ToString());
                    produto.valor = Convert.ToInt32(reader["valor"]);
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public void Insert(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values ";
            sql = sql + " (@descricao, @estoque, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@estoque", produto.estoque);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de produto...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Produto> SelectByDesc(string descricao)
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where descricao like @descricao;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto cliente     
                    MODEL.Produto produto = new MODEL.Produto();
                    //carregar os dado no objeto cliente -- popular objeto
                    produto.id = Convert.ToInt32(reader["id"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.estoque = Convert.ToInt32(reader["estoque"]);
                    produto.valor = Convert.ToSingle(reader["valor"]);
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public MODEL.Produto selectByID(int idProduto)
        {
            MODEL.Produto produto = new MODEL.Produto();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idProduto);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    //instanciando objeto cliente     
                    //carregar os dado no objeto cliente -- popular objeto
                    produto.id = Convert.ToInt32(reader["id"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.estoque = Convert.ToInt32(reader["estoque"]);
                    produto.valor = Convert.ToSingle(reader["valor"]);
                    
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return produto;
        }

        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set descricao=@descricao, estoque=@estoque, valor=@valor ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@estoque", produto.estoque);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Produto...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Produto");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}