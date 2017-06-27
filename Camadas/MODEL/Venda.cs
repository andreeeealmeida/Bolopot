using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.MODEL
{
    public class Venda{
        public int id { get; set; }
        public int cliente_id { get; set; }

        public DateTime data { get; set; }
    }
}
