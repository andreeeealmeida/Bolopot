using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.BLL
{
    public class Venda
    {
        public List<MODEL.Venda> Select()
        {
            DAL.Venda dalProd = new DAL.Venda();

            return dalProd.Select();
        }

        public void Insert(MODEL.Venda venda)
        {
            DAL.Venda dalCli = new DAL.Venda();

            dalCli.Insert(venda);
        }

        public void Update(MODEL.Venda venda)
        {
            DAL.Venda dalCli = new DAL.Venda();
            dalCli.Update(venda);
        }

        public void Delete(MODEL.Venda venda)
        {
            DAL.Venda dalCli = new DAL.Venda();

            dalCli.Delete(venda);
        }
    }
}
