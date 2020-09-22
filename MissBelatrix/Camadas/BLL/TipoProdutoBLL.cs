using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class TipoProdutoBLL
    {
        public List<TipoProdutoInfo> Listar()
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            return dal.Listar();
        }

        public void Inserir(TipoProdutoInfo info)
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            dal.Inserir(info);
        }
    }
}
