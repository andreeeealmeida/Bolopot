using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolopot.Camadas.BLL
{
   public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();

            return dalProd.Select();
        }

        public List<MODEL.Produto> SelectByDesc(string descricao)
        {
            DAL.Produto dalProd = new DAL.Produto();

            return dalProd.SelectByDesc(descricao);
        }

        public void Insert(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

            dalProd.Insert(produto);
        }

        public void Update(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Update(produto);
        }

        public void Delete(MODEL.Produto produto)
        {
            DAL.Produto dalCli = new DAL.Produto();

            dalCli.Delete(produto);
        }
    }
}
