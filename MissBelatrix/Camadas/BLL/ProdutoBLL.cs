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

        public ProdutoInfo Get(int pCdProduto)
        {
            ProdutoDAL dal = new ProdutoDAL();
            return dal.Get(pCdProduto);
        }

        public void Inserir(ProdutoInfo pInfo)
        {
            ProdutoDAL dal = new ProdutoDAL();
            dal.Inserir(pInfo);
        }

        public void Update(ProdutoInfo pInfo)
        {
            ProdutoDAL dal = new ProdutoDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdProduto)
        {
            ProdutoDAL dal = new ProdutoDAL();
            dal.Delete(pCdProduto);
        }
    }
}
