using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.DAL
{
    public class Venda
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Venda> Select()
        {
            List<MODEL.Venda> lstVenda = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(reader["id"]);
                    venda.cliente_id = Convert.ToInt32(reader["Cliente_id"]);

                    venda.data = Convert.ToDateTime(reader["data"]);
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Venda....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public MODEL.Venda SelectById(int id)
        {
            MODEL.Venda venda = new MODEL.Venda();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    venda.id = Convert.ToInt32(reader["id"]);
                    venda.cliente_id = Convert.ToInt32(reader["Cliente_id"]);
                    venda.data = Convert.ToDateTime(reader["data"]);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Venda....;");
            }
            finally
            {
                conexao.Close();
            }
            return venda;
        }

  
        public void Insert(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Venda values ";
            sql = sql + " (@Cliente_id, @data);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Cliente_id", venda.cliente_id);
            cmd.Parameters.AddWithValue("@data", venda.data);
            conexao.Open();
            //try
            //{
            cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            Console.WriteLine("Deu erro inserção de cliente...");
            //}
            //finally
            //{
            conexao.Close();
            //}
        }

        public void Update(MODEL.Venda venda)
        {
            //SqlConnection conexao = new SqlConnection(strCon);
            //string sql = "Update Venda set Cliente_id=@Cliente_id, Venda_item_id=@Venda_item_id, data=@data";
            //SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@id", venda.id);
            //cmd.Parameters.AddWithValue("@Cliente_id", venda.cliente_id);
            //cmd.Parameters.AddWithValue("@Venda_item_id", venda.venda_item_id);
            //cmd.Parameters.AddWithValue("@data", venda.data);
            //conexao.Open();
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    Console.WriteLine("Erro na atualização de Clientes...");
            //}
            //finally
            //{
            //    conexao.Close();
            //}
        }

        public void Delete(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.id);
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