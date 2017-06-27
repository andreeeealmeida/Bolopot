using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.DAL
{
    class Conexao{
        public static string getConexao(){
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=Bolopot;Integrated Security=True";
        }
    }
}