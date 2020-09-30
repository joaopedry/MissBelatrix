using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class TipoAcessoBLL
    {
        public List<TipoAcessoInfo> Listar()
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            return dal.Listar();
        }

        public TipoAcessoInfo Get(int pCdTipoAcesso)
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            return dal.Get(pCdTipoAcesso);
        }

        public void Inserir(TipoAcessoInfo pInfo)
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            dal.Inserir(pInfo);
        }

        public void Update(TipoAcessoInfo pInfo)
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdTipoAcesso)
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            dal.Delete(pCdTipoAcesso);
        }
    }
}
