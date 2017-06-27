using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.MODEL
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int estoque { get; set; }
        public float valor { get; set; }
    }
}
