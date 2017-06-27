using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Relatorio
{
    public class relVenda
    {
        public static void relatorio(int idVenda)
        {
            string path = @"c:\Relatorio\relVenda";
            Camadas.DAL.Venda_Item dalVendaItem = new Camadas.DAL.Venda_Item();
            Camadas.DAL.Cliente dalCliente = new Camadas.DAL.Cliente();
            Camadas.DAL.Venda dalVenda = new Camadas.DAL.Venda();
            Camadas.DAL.Produto dalProduto = new Camadas.DAL.Produto();
            List<Camadas.MODEL.Venda_Item> lstVendaItem = dalVendaItem.selectByIdVenda(idVenda);
            Camadas.MODEL.Venda venda = dalVenda.SelectById(idVenda);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title> Relatorio de Venda </title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>" + dalCliente.selectById(venda.cliente_id).nome + " - Data: " + venda.data.ToShortDateString() + "</h1>");
                sw.WriteLine("<hr>");
                sw.WriteLine("<table> <tr> <th> Produto </th> <th> Quantidade </th> <th> Valor </th> <th> Total </th> </tr>");
                float valorTotal = 0;
                for (int i = 0; i < lstVendaItem.Count; i++)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td>" + dalProduto.selectByID(lstVendaItem[i].idProduto).descricao + " </td>");
                    sw.WriteLine("<td text-align = \"center\">" + lstVendaItem[i].quantidade+ " </td>");
                    sw.WriteLine("<td> R$" + dalProduto.selectByID(lstVendaItem[i].idProduto).valor.ToString("0.00") + " </td>");
                    sw.WriteLine("<td> R$" + (dalProduto.selectByID(lstVendaItem[i].idProduto).valor * lstVendaItem[i].quantidade).ToString("0.00") + " </td>");
                    valorTotal += dalProduto.selectByID(lstVendaItem[i].idProduto).valor * lstVendaItem[i].quantidade;
                    sw.WriteLine("</tr>");
                }
                sw.WriteLine("</table><hr>");
                sw.WriteLine("<h2> Valor Total: R$" + valorTotal.ToString("0.00") + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
                sw.WriteLine();
            }
            System.Diagnostics.Process.Start(path);
        }
    }
}
