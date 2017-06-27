using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.DAL
{
    public class Venda_Item
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Venda_Item> Select()
        {
            List<MODEL.Venda_Item> lstCliente = new List<MODEL.Venda_Item>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda_Item;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {   
                    MODEL.Venda_Item venda_item = new MODEL.Venda_Item();
                    venda_item.id = Convert.ToInt32(reader["id"]);
                    venda_item.idVenda = Convert.ToInt32(reader["idVenda"]);
                    venda_item.idProduto = Convert.ToInt32(reader["idProduto"]);
                    venda_item.quantidade = Convert.ToInt32 (reader["quantidade"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select ....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }


        public List<MODEL.Venda_Item> selectByIdVenda(int idVenda)
        {
            List<MODEL.Venda_Item> lstVenda = new List<MODEL.Venda_Item>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda_Item where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idVenda", idVenda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Venda_Item venda_item = new MODEL.Venda_Item();
                    venda_item.id = Convert.ToInt32(reader["id"]);
                    venda_item.idVenda = Convert.ToInt32(reader["idVenda"]);
                    venda_item.idProduto = Convert.ToInt32(reader["idProduto"]);
                    venda_item.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    lstVenda.Add(venda_item);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select ....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public void Insert(MODEL.Venda_Item venda_item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Venda_Item values ";
            sql = sql + " (@idVenda, @quantidade, @idProduto);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVenda", venda_item.idVenda);
            cmd.Parameters.AddWithValue("@idProduto", venda_item.idProduto);
            cmd.Parameters.AddWithValue("@quantidade", venda_item.quantidade);
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

        public void Update(MODEL.Venda_Item venda_item)
        {
            //SqlConnection conexao = new SqlConnection(strCon);
            //string sql = "Update Venda_Item set id_produto=@id_produto, quantidade=@quantidade";
            //SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@id", venda_item.id);
            //cmd.Parameters.AddWithValue("@idCliente", venda_item.idCliente);
            //cmd.Parameters.AddWithValue("@nomeCliente", venda_item.nomeCliente);
            //cmd.Parameters.AddWithValue("@descProduto", venda_item.descProduto);
            //cmd.Parameters.AddWithValue("@quantidade", venda_item.quantidade);
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

        public void Delete(MODEL.Venda_Item venda_item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda_item.id);
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