using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Relatorio
{
    class RelCliente
    {
        public static void relatorio()
        {
            string path = @"c:\Relatorio\relCliente";
            Camadas.DAL.Cliente dalCliente = new Camadas.DAL.Cliente();
            List<Camadas.MODEL.Cliente> lstCliente = dalCliente.Select();
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title> Relatoria de Cliente </title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1> Relatório de Cliente </h1>");
                sw.WriteLine("<table border=\"1\"> ");
                sw.WriteLine("<tr> <th> ID </th> <th> Nome </th> <th> Endereço </th> <th> Telefone </th> </tr>");
                for (int i = 0; i < lstCliente.Count; i++)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td> " + lstCliente[i].id + "</td>");
                    sw.WriteLine("<td> " + lstCliente[i].nome+ "</td>");
                    sw.WriteLine("<td> " + lstCliente[i].rua_casa+ "</td>");
                    sw.WriteLine("<td> " + lstCliente[i].telefone + "</td>");
                    sw.WriteLine("</tr>");
                }
                sw.WriteLine("</html>");
                sw.WriteLine("</body>");
            }
            System.Diagnostics.Process.Start(path);
        }
    }
}
