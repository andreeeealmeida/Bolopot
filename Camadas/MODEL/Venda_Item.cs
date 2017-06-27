using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.MODEL
{
    public class Venda_Item
    {
        public int id { get; set; }
        public int idVenda { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }
    }
}
