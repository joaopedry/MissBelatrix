using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class TamanhoBLL
    {
        public List<TamanhoInfo> Listar()
        {
            TamanhoDAL dal = new TamanhoDAL();
            return dal.Listar();
        }

        public TamanhoInfo Get(int pCdTamanho)
        {
            TamanhoDAL dal = new TamanhoDAL();
            return dal.Get(pCdTamanho);
        }

        public void Inserir(TamanhoInfo pInfo)
        {
            TamanhoDAL dal = new TamanhoDAL();
            dal.Inserir(pInfo);
        }

        public void Update(TamanhoInfo pInfo)
        {
            TamanhoDAL dal = new TamanhoDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdTamanho)
        {
            TamanhoDAL dal = new TamanhoDAL();
            dal.Delete(pCdTamanho);
        }
    }
}
