using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class ProdutoBLL
    {
        public List<ProdutoInfo> Listar()
        {
            ProdutoDAL dal = new ProdutoDAL();
            return dal.Listar();
        }

        public void Inserir(ProdutoInfo info)
        {
            ProdutoDAL dal = new ProdutoDAL();
            dal.Inserir(info);
        }
    }
}
