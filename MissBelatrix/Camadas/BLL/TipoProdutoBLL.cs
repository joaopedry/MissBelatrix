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

        public TipoProdutoInfo Get(int pCdTipoProduto)
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            return dal.Get(pCdTipoProduto);
        }

        public void Inserir(TipoProdutoInfo pInfo)
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            dal.Inserir(pInfo);
        }

        public void Update(TipoProdutoInfo pInfo)
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdTipoProduto)
        {
            TipoProdutoDAL dal = new TipoProdutoDAL();
            dal.Delete(pCdTipoProduto);
        }
    }
}
